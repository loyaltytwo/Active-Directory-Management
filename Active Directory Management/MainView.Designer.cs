﻿namespace Active_Directory_Management
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.searchBox = new System.Windows.Forms.TextBox();
			this.createBtn = new System.Windows.Forms.Button();
			this.firstBox = new System.Windows.Forms.TextBox();
			this.lastBox = new System.Windows.Forms.TextBox();
			this.detailBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.treeView = new System.Windows.Forms.TreeView();
			this.switchPanel = new System.Windows.Forms.Panel();
			this.cdCheck = new System.Windows.Forms.CheckBox();
			this.usbDiskCheck = new System.Windows.Forms.CheckBox();
			this.usbDeviceCheck = new System.Windows.Forms.CheckBox();
			this.cloudCheck = new System.Windows.Forms.CheckBox();
			this.internetCombo = new System.Windows.Forms.ComboBox();
			this.internetLabel = new System.Windows.Forms.Label();
			this.disableBtn = new System.Windows.Forms.Button();
			this.updBtn = new System.Windows.Forms.Button();
			this.disableReason = new System.Windows.Forms.Label();
			this.citySelector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.switchPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(57, 44);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(349, 20);
			this.searchBox.TabIndex = 0;
			this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(779, 12);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(134, 58);
			this.createBtn.TabIndex = 2;
			this.createBtn.Text = "Создать";
			this.createBtn.UseVisualStyleBackColor = true;
			this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
			// 
			// firstBox
			// 
			this.firstBox.Location = new System.Drawing.Point(619, 12);
			this.firstBox.Name = "firstBox";
			this.firstBox.ReadOnly = true;
			this.firstBox.Size = new System.Drawing.Size(100, 20);
			this.firstBox.TabIndex = 3;
			// 
			// lastBox
			// 
			this.lastBox.Location = new System.Drawing.Point(513, 12);
			this.lastBox.Name = "lastBox";
			this.lastBox.ReadOnly = true;
			this.lastBox.Size = new System.Drawing.Size(100, 20);
			this.lastBox.TabIndex = 4;
			// 
			// detailBtn
			// 
			this.detailBtn.Location = new System.Drawing.Point(67, 235);
			this.detailBtn.Name = "detailBtn";
			this.detailBtn.Size = new System.Drawing.Size(100, 38);
			this.detailBtn.TabIndex = 12;
			this.detailBtn.Text = "Полное редактирование";
			this.detailBtn.UseVisualStyleBackColor = true;
			this.detailBtn.Click += new System.EventHandler(this.DetailBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(779, 113);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(134, 58);
			this.saveBtn.TabIndex = 13;
			this.saveBtn.Text = "Сохранить";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// treeView
			// 
			this.treeView.Location = new System.Drawing.Point(12, 70);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(394, 368);
			this.treeView.TabIndex = 17;
			this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
			this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
			// 
			// switchPanel
			// 
			this.switchPanel.Controls.Add(this.cdCheck);
			this.switchPanel.Controls.Add(this.usbDiskCheck);
			this.switchPanel.Controls.Add(this.usbDeviceCheck);
			this.switchPanel.Controls.Add(this.cloudCheck);
			this.switchPanel.Controls.Add(this.internetCombo);
			this.switchPanel.Controls.Add(this.detailBtn);
			this.switchPanel.Controls.Add(this.internetLabel);
			this.switchPanel.Enabled = false;
			this.switchPanel.Location = new System.Drawing.Point(446, 38);
			this.switchPanel.Name = "switchPanel";
			this.switchPanel.Size = new System.Drawing.Size(357, 280);
			this.switchPanel.TabIndex = 19;
			// 
			// cdCheck
			// 
			this.cdCheck.Location = new System.Drawing.Point(67, 14);
			this.cdCheck.Name = "cdCheck";
			this.cdCheck.Size = new System.Drawing.Size(168, 28);
			this.cdCheck.TabIndex = 6;
			this.cdCheck.Text = "Доступ к CD/DVD";
			this.cdCheck.UseVisualStyleBackColor = true;
			// 
			// usbDiskCheck
			// 
			this.usbDiskCheck.Location = new System.Drawing.Point(67, 48);
			this.usbDiskCheck.Name = "usbDiskCheck";
			this.usbDiskCheck.Size = new System.Drawing.Size(168, 28);
			this.usbDiskCheck.TabIndex = 7;
			this.usbDiskCheck.Text = "Доступ к USB дискам";
			this.usbDiskCheck.UseVisualStyleBackColor = true;
			// 
			// usbDeviceCheck
			// 
			this.usbDeviceCheck.Location = new System.Drawing.Point(67, 82);
			this.usbDeviceCheck.Name = "usbDeviceCheck";
			this.usbDeviceCheck.Size = new System.Drawing.Size(168, 28);
			this.usbDeviceCheck.TabIndex = 8;
			this.usbDeviceCheck.Text = "Доступ к USB устройствам";
			this.usbDeviceCheck.UseVisualStyleBackColor = true;
			// 
			// cloudCheck
			// 
			this.cloudCheck.Enabled = false;
			this.cloudCheck.Location = new System.Drawing.Point(67, 116);
			this.cloudCheck.Name = "cloudCheck";
			this.cloudCheck.Size = new System.Drawing.Size(168, 28);
			this.cloudCheck.TabIndex = 9;
			this.cloudCheck.Text = "Личная папка (Диск K:\\)";
			this.cloudCheck.UseVisualStyleBackColor = true;
			// 
			// internetCombo
			// 
			this.internetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.internetCombo.FormattingEnabled = true;
			this.internetCombo.Items.AddRange(new object[] {
            "Отсутствует",
            "Ограниченный",
            "Полный"});
			this.internetCombo.Location = new System.Drawing.Point(174, 167);
			this.internetCombo.Name = "internetCombo";
			this.internetCombo.Size = new System.Drawing.Size(121, 21);
			this.internetCombo.TabIndex = 10;
			// 
			// internetLabel
			// 
			this.internetLabel.AutoSize = true;
			this.internetLabel.Location = new System.Drawing.Point(64, 170);
			this.internetLabel.Name = "internetLabel";
			this.internetLabel.Size = new System.Drawing.Size(104, 13);
			this.internetLabel.TabIndex = 11;
			this.internetLabel.Text = "Доступ в Интернет";
			// 
			// disableBtn
			// 
			this.disableBtn.Enabled = false;
			this.disableBtn.Location = new System.Drawing.Point(641, 273);
			this.disableBtn.Name = "disableBtn";
			this.disableBtn.Size = new System.Drawing.Size(100, 38);
			this.disableBtn.TabIndex = 14;
			this.disableBtn.Text = "Отключить аккаунт";
			this.disableBtn.UseVisualStyleBackColor = true;
			this.disableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
			// 
			// updBtn
			// 
			this.updBtn.Location = new System.Drawing.Point(331, 10);
			this.updBtn.Name = "updBtn";
			this.updBtn.Size = new System.Drawing.Size(75, 23);
			this.updBtn.TabIndex = 20;
			this.updBtn.Text = "Обновить";
			this.updBtn.UseVisualStyleBackColor = true;
			this.updBtn.Click += new System.EventHandler(this.UpdBtn_Click);
			// 
			// disableReason
			// 
			this.disableReason.AutoSize = true;
			this.disableReason.Location = new System.Drawing.Point(513, 317);
			this.disableReason.MaximumSize = new System.Drawing.Size(100, 200);
			this.disableReason.Name = "disableReason";
			this.disableReason.Size = new System.Drawing.Size(44, 13);
			this.disableReason.TabIndex = 21;
			this.disableReason.Text = "Reason";
			this.disableReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.disableReason.Visible = false;
			// 
			// citySelector
			// 
			this.citySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.citySelector.FormattingEnabled = true;
			this.citySelector.Location = new System.Drawing.Point(57, 12);
			this.citySelector.Name = "citySelector";
			this.citySelector.Size = new System.Drawing.Size(268, 21);
			this.citySelector.TabIndex = 22;
			this.citySelector.SelectedIndexChanged += new System.EventHandler(this.citySelector_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Поиск";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Город";
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 450);
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.citySelector);
			this.Controls.Add(this.disableReason);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.disableBtn);
			this.Controls.Add(this.switchPanel);
			this.Controls.Add(this.updBtn);
			this.Controls.Add(this.treeView);
			this.Controls.Add(this.lastBox);
			this.Controls.Add(this.firstBox);
			this.Controls.Add(this.searchBox);
			this.Name = "MainView";
			this.Text = "Active Directory ";
			this.switchPanel.ResumeLayout(false);
			this.switchPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel switchPanel;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button disableBtn;
		private System.Windows.Forms.CheckBox cdCheck;
		private System.Windows.Forms.CheckBox usbDiskCheck;
		private System.Windows.Forms.CheckBox usbDeviceCheck;
		private System.Windows.Forms.CheckBox cloudCheck;
		private System.Windows.Forms.ComboBox internetCombo;
		private System.Windows.Forms.Label internetLabel;
		private System.Windows.Forms.Label disableReason;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.ComboBox citySelector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}