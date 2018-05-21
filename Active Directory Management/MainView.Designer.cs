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
            this.internetLabel = new System.Windows.Forms.Label();
            this.internetCombo = new System.Windows.Forms.ComboBox();
            this.cloudCheck = new System.Windows.Forms.CheckBox();
            this.usbDeviceCheck = new System.Windows.Forms.CheckBox();
            this.usbDiskCheck = new System.Windows.Forms.CheckBox();
            this.cdCheck = new System.Windows.Forms.CheckBox();
            this.detailBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.searchBoxPlaceholder = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(239, 20);
            this.searchBox.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(257, 10);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(405, 12);
            this.firstBox.Name = "firstBox";
            this.firstBox.ReadOnly = true;
            this.firstBox.Size = new System.Drawing.Size(100, 20);
            this.firstBox.TabIndex = 3;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(533, 12);
            this.lastBox.Name = "lastBox";
            this.lastBox.ReadOnly = true;
            this.lastBox.Size = new System.Drawing.Size(100, 20);
            this.lastBox.TabIndex = 4;
            // 
            // internetLabel
            // 
            this.internetLabel.AutoSize = true;
            this.internetLabel.Enabled = false;
            this.internetLabel.Location = new System.Drawing.Point(402, 268);
            this.internetLabel.Name = "internetLabel";
            this.internetLabel.Size = new System.Drawing.Size(104, 13);
            this.internetLabel.TabIndex = 11;
            this.internetLabel.Text = "Доступ в Интернет";
            // 
            // internetCombo
            // 
            this.internetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.internetCombo.Enabled = false;
            this.internetCombo.FormattingEnabled = true;
            this.internetCombo.Items.AddRange(new object[] {
            "Отсутствует",
            "Ограниченный",
            "Полный"});
            this.internetCombo.Location = new System.Drawing.Point(512, 265);
            this.internetCombo.Name = "internetCombo";
            this.internetCombo.Size = new System.Drawing.Size(121, 21);
            this.internetCombo.TabIndex = 10;
            // 
            // cloudCheck
            // 
            this.cloudCheck.AutoSize = true;
            this.cloudCheck.Enabled = false;
            this.cloudCheck.Location = new System.Drawing.Point(405, 203);
            this.cloudCheck.Name = "cloudCheck";
            this.cloudCheck.Size = new System.Drawing.Size(150, 17);
            this.cloudCheck.TabIndex = 9;
            this.cloudCheck.Text = "Личная папка (Диск K:\\)";
            this.cloudCheck.UseVisualStyleBackColor = true;
            // 
            // usbDeviceCheck
            // 
            this.usbDeviceCheck.AutoSize = true;
            this.usbDeviceCheck.Enabled = false;
            this.usbDeviceCheck.Location = new System.Drawing.Point(405, 180);
            this.usbDeviceCheck.Name = "usbDeviceCheck";
            this.usbDeviceCheck.Size = new System.Drawing.Size(165, 17);
            this.usbDeviceCheck.TabIndex = 8;
            this.usbDeviceCheck.Text = "Доступ к USB устройствам";
            this.usbDeviceCheck.UseVisualStyleBackColor = true;
            // 
            // usbDiskCheck
            // 
            this.usbDiskCheck.AutoSize = true;
            this.usbDiskCheck.Enabled = false;
            this.usbDiskCheck.Location = new System.Drawing.Point(405, 157);
            this.usbDiskCheck.Name = "usbDiskCheck";
            this.usbDiskCheck.Size = new System.Drawing.Size(138, 17);
            this.usbDiskCheck.TabIndex = 7;
            this.usbDiskCheck.Text = "Доступ к USB дискам";
            this.usbDiskCheck.UseVisualStyleBackColor = true;
            // 
            // cdCheck
            // 
            this.cdCheck.AutoSize = true;
            this.cdCheck.Enabled = false;
            this.cdCheck.Location = new System.Drawing.Point(405, 134);
            this.cdCheck.Name = "cdCheck";
            this.cdCheck.Size = new System.Drawing.Size(118, 17);
            this.cdCheck.TabIndex = 6;
            this.cdCheck.Text = "Доступ к CD/DVD";
            this.cdCheck.UseVisualStyleBackColor = true;
            // 
            // detailBtn
            // 
            this.detailBtn.Enabled = false;
            this.detailBtn.Location = new System.Drawing.Point(405, 333);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(100, 38);
            this.detailBtn.TabIndex = 12;
            this.detailBtn.Text = "Полное редактирование";
            this.detailBtn.UseVisualStyleBackColor = true;
            this.detailBtn.Click += new System.EventHandler(this.DetailBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(558, 341);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // searchBoxPlaceholder
            // 
            this.searchBoxPlaceholder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchBoxPlaceholder.AutoSize = true;
            this.searchBoxPlaceholder.BackColor = System.Drawing.SystemColors.Window;
            this.searchBoxPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBoxPlaceholder.Location = new System.Drawing.Point(16, 15);
            this.searchBoxPlaceholder.Name = "searchBoxPlaceholder";
            this.searchBoxPlaceholder.Size = new System.Drawing.Size(48, 13);
            this.searchBoxPlaceholder.TabIndex = 15;
            this.searchBoxPlaceholder.Text = "Поиск...";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Items.AddRange(new object[] {
            "abacaba",
            "param 1",
            "param 2",
            "test "});
            this.listBox.Location = new System.Drawing.Point(12, 38);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(320, 407);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 16;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.searchBoxPlaceholder);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.internetLabel);
            this.Controls.Add(this.internetCombo);
            this.Controls.Add(this.cloudCheck);
            this.Controls.Add(this.usbDeviceCheck);
            this.Controls.Add(this.usbDiskCheck);
            this.Controls.Add(this.cdCheck);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.searchBox);
            this.Name = "MainView";
            this.Text = "Active Directory ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Label internetLabel;
        private System.Windows.Forms.ComboBox internetCombo;
        private System.Windows.Forms.CheckBox cloudCheck;
        private System.Windows.Forms.CheckBox usbDeviceCheck;
        private System.Windows.Forms.CheckBox usbDiskCheck;
        private System.Windows.Forms.CheckBox cdCheck;
        private System.Windows.Forms.Button detailBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label searchBoxPlaceholder;
        private System.Windows.Forms.ListBox listBox;
    }
}