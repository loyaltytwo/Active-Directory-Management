﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace Active_Directory_Management
{
	public class User
	{
		private XElement xmlNode;
		private DirectoryEntry entry;
		static private XDocument xmlFile = XDocument.Load(Active_Directory_Management.Properties.Resources.XmlFile);

		static private string xmlFileLocation = Active_Directory_Management.Properties.Resources.XmlFile;

		static private string username = "bazhr1";
		static private string password = "vk.com123";

		public Dictionary<string, string> Properties { get; } = new Dictionary<string, string>();

		private Dictionary<string, bool> memberOf = new Dictionary<string, bool>();
		
		private int uac;
		private string dn;
		private string name;
        public string Dn { get => dn; }
		public string Name { get => name; }

		public User(string name, DirectoryEntry path, XElement parent)
		{
			// Get first name and family name from name string
			string surname = name.Split(' ')[0].ToLower();
			string firstName = name.Split(' ')[1].ToLower();

			// Create entry in Active Directory
			entry = path.Children.Add("CN=" + name, "user");
			
			// Build Searcher 
			DirectorySearcher searcher = new DirectorySearcher()
			{
				SearchRoot = new DirectoryEntry("LDAP://DC=nng,DC=kz"),
				SearchScope = SearchScope.Subtree
			};

			// Supposed samAccountName (login)
			string samAccountName = surname.Substring(0, Math.Min(4, surname.Length))
				+ firstName[0];
			int cnt = 0;
			
			// Iterate cnt while available login is found 
			do
			{
				cnt++;
				searcher.Filter = String.Format("(samAccountName={0})",
					samAccountName + cnt.ToString());
			}
			while (searcher.FindOne() != null);

			// Set final samAccountName
			samAccountName += cnt.ToString();
			entry.Properties["samAccountName"].Value = samAccountName;
			entry.Properties["userPrincipalName"].Value = samAccountName + "@nng.kz";

			

			// Commit changes to Active Directory (create user)
			entry.CommitChanges();

			// Set standart password and require to change it on next logon
			entry.Invoke("SetPassword", new object[] { "1234567Aa" });
			entry.Properties["pwdLastSet"].Value = 0;
			entry.CommitChanges();

			// Manually enable account
			entry.Properties["userAccountControl"].Value = 0x200;
			entry.CommitChanges();
			
			

			// Write local parameters
			dn = entry.Properties["distinguishedName"].Value.ToString();
			uac = 0x200;
			this.name = name;

			// Create new xml node 
			xmlNode = new XElement("user",
				new XAttribute("name", Name),
				new XAttribute("dn", Dn),
				new XElement("userAccountControl", uac),
				new XElement("memberOf"));

			// Append node to parent in document
			parent.Add(xmlNode);

			// Save changes
			xmlFile.Save(Active_Directory_Management.Properties.Resources.XmlFile);

			
		}
		
		/// <summary>
		/// Возвращает ранее созданного пользователя
		/// </summary>
		/// <param name="userDN">Distinguished Name искомого пользователя</param>
		/// <returns>Пользователь</returns>
		public static User Load(string userDN)
		{
			return new User(userDN);
		}
		

        private User(string userDN)
        {
			xmlNode = xmlFile.Root.Descendants("user")
				.Where(t => t.Attribute("dn").Value == userDN)
				.First();

			dn = xmlNode.Attribute("dn").Value;
			name = xmlNode.Attribute("name").Value;
			uac = int.Parse(xmlNode.Element("userAccountControl").Value);

			entry = new DirectoryEntry("LDAP://" + Dn);
		}

		public string Username
		{
			get
			{
				return username;
			}
			set
			{
				username = value;
			}
		}
		public string Password
		{
			set
			{
				password = value;
			}
		}
		static public string XmlFileLocation
		{
			get
			{
				return xmlFileLocation;
			}
			set
			{
				xmlFileLocation = value;
				xmlFile = XDocument.Load(XmlFileLocation);
			}
		}
		/// <summary>
		/// Запрашивает или устанавливает значение блокировки аккаунта
		/// </summary>
        public bool Enabled
        {
            get
            {
                return !Convert.ToBoolean(uac & 0x2);
            }
            set
            {
				int newUserAccountControl;

				if (value == true)
					// Enable, remove flag
					newUserAccountControl = uac & ~0x2;
                else
					// Disable, set flag
                    newUserAccountControl = uac | 0x2;

				// Set new parameters
				uac = newUserAccountControl;
				entry.Properties["userAccountControl"].Value = uac;
				xmlNode.Element("userAccountControl").Value = uac.ToString();

				// Save changes
				xmlFile.Save(xmlFileLocation);
				entry.CommitChanges();
            }
        }

		/// <summary>
		/// Возвращает информацию состоит ли пользователь в группе
		/// </summary>
		/// <param name="groupDN">Distinguished Name группы </param>
		/// <returns>Членство в группе</returns>
		public bool MemberOf(string groupDN)
        {
			return xmlNode.Element("memberOf").Elements()
				.Where(t => t.Value == groupDN)
				.ToArray()
				.Length > 0;
		}


        /// <summary>
		/// Добавление пользователя в группу
		/// </summary>
		/// <param name="groupDN">Distinguished Name группы куда добаляется пользователь</param>
        public void AddGroup(string groupDN)
        {
            if (!MemberOf(groupDN))
            {
                DirectoryEntry groupEntry = new DirectoryEntry("LDAP://" + groupDN);

				// Update property in object
				memberOf[groupDN] = true;

				// Update property in XML file
				xmlNode.Element("memberOf").Add(new XElement("group", groupDN));
				xmlFile.Save(xmlFileLocation);

				// Update Active Directory
				groupEntry.Properties["member"].Add(Dn);
				groupEntry.CommitChanges();

                groupEntry.Close();
            }
        }

		/// <summary>
		/// Удаление пользователя из группы
		/// </summary>
		/// <param name="groupDN">Distinguished Name группы откуда удаляется пользователь</param>
		public void RemoveGroup(string groupDN)
        {
            if (MemberOf(groupDN))
            {
                DirectoryEntry groupEntry = new DirectoryEntry("LDAP://" + groupDN);

				
				// Update property in object
				memberOf[groupDN] = false;

				// Update property in XML file
				xmlNode.Element("memberOf").Elements()
					.Where(t => t.Value == groupDN)
					.Remove();
				xmlFile.Save(xmlFileLocation);

                // Update Active Directory
				groupEntry.Properties["member"].Remove(Dn);
				groupEntry.CommitChanges();

				groupEntry.Close();
            }
        }

		/// <summary>
		/// Устанавливает членство пользователя в группе
		/// </summary>
		/// <param name="groupDN">Distinguished Name группы</param>
		/// <param name="state">Флаг "Членство в группе"</param>
		public void SetMembership(string groupDN, bool state)
        {
			if (state == true)
				AddGroup(groupDN);
            else
                RemoveGroup(groupDN);
        }

		/// <summary>
		/// Сохраняет все локальные изменения в Active Directory и XML файл
		/// </summary>
        public void CommitChanges()
        {
				
			foreach (KeyValuePair<string, string> prop in Properties)
            {
				string key = prop.Key;
				string value = prop.Value;

				

				if (value == string.Empty)
					continue;

				else if (value == null)
				{
					entry.Properties[key].Clear();
					value = string.Empty;
				}
				else if (key == "displayName")
				{
					string newName = String.Format("CN={0}", value);

					Debug.WriteLine(newName);

					entry.CommitChanges();
					entry.Rename(newName);

					entry.Properties["displayName"].Value = value;
					dn = newName;
					name = value;
					key = "name";
				}
				else if(key == "department")
				{
					entry.CommitChanges();

					string ouDN = xmlFile.Root.Descendants("dept")
						.Where(t => t.Attribute("nameRU").Value == value)
						.Select(t => t.Attribute("dn").Value)
						.First();

					entry.MoveTo(new DirectoryEntry("LDAP://" + ouDN));
					entry.Properties["displayName"].Value = value;
				}
				else
					entry.Properties[key].Value = value;

				try { xmlNode.Element(key).Value = value; }
				catch { xmlNode.Add(new XElement(key, value)); }
            }
			Properties.Clear();
			xmlFile.Save(XmlFileLocation);
			entry.CommitChanges();
		}

		public void DropPassword()
		{
			entry.Invoke("SetPassword", new object[] { "12345678Ab" });
			entry.Properties["pwdLastSet"].Value = 0;
			entry.CommitChanges();
		}

		/// <summary>
		/// Возвращает значение атрибута пользователя
		/// </summary>
		/// <param name="property">Имя атрибута</param>
		/// <returns>Значение атрибута</returns>
		public string GetProperty(string property)
		{
			if (property == "department")
				return xmlNode.Parent.Attribute("nameRU").Value;
			return xmlNode.Element(property).Value;
		}
		/// <summary>
		/// Удаляет пользователя из всех групп, ощитает поле руководителя и переносит в группу отключенных аккаунтов
		/// </summary>
		public void Remove()
		{
			foreach(string group in xmlNode.Element("memberOf").Elements()
					.Select(t => t.Value))
				RemoveGroup(group);

			entry.Properties["manager"].Clear();
			entry.CommitChanges();

			entry.MoveTo(new DirectoryEntry("LDAP://OU=Disabled Accounts,DC=nng,DC=kz"));
			xmlNode.Remove();
			xmlFile.Save(XmlFileLocation);
		}

    }
}
