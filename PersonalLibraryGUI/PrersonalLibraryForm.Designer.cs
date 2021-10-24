///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         PrersonalLibraryForm.Designer.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:           Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PersonalLibraryGUI
{
    /// <summary>
    /// Defines the <see cref="PersonalLibraryForm" />.
    /// </summary>
    partial class PersonalLibraryForm
    {
        /// <summary>
        /// Required designer variable..
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InvalidLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.InvalidFirstName = new System.Windows.Forms.Label();
            this.InvalidPhone = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.InvalidLastName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.InvalidCity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InvalidAddress = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.InvalidState = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InvalidZip = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.InvalidENumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "EmailInput";
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(36, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.EmailInput_TextBoxChange);
            this.textBox1.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // label1
            // 
            this.label1.AccessibleName = "EmailLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.modifyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.showAllByAuthorToolStripMenuItem,
            this.quiteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // showAllByAuthorToolStripMenuItem
            // 
            this.showAllByAuthorToolStripMenuItem.Name = "showAllByAuthorToolStripMenuItem";
            this.showAllByAuthorToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.showAllByAuthorToolStripMenuItem.Text = "Show All by Author";
            // 
            // quiteToolStripMenuItem
            // 
            this.quiteToolStripMenuItem.Name = "quiteToolStripMenuItem";
            this.quiteToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.quiteToolStripMenuItem.Text = "Quite";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.updateOwnerToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // updateOwnerToolStripMenuItem
            // 
            this.updateOwnerToolStripMenuItem.Name = "updateOwnerToolStripMenuItem";
            this.updateOwnerToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.updateOwnerToolStripMenuItem.Text = "Update Owner";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // InvalidLabel
            // 
            this.InvalidLabel.AccessibleName = "InvalidEmail";
            this.InvalidLabel.AutoSize = true;
            this.InvalidLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidLabel.Location = new System.Drawing.Point(33, 91);
            this.InvalidLabel.Name = "InvalidLabel";
            this.InvalidLabel.Size = new System.Drawing.Size(101, 13);
            this.InvalidLabel.TabIndex = 5;
            this.InvalidLabel.Text = "Invalid Email Format";
            this.InvalidLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.AccessibleName = "FirstName";
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.Location = new System.Drawing.Point(36, 137);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(109, 20);
            this.FirstName.TabIndex = 11;
            this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
            // 
            // InvalidFirstName
            // 
            this.InvalidFirstName.AccessibleName = "InvalidFirstName";
            this.InvalidFirstName.AutoSize = true;
            this.InvalidFirstName.ForeColor = System.Drawing.Color.Red;
            this.InvalidFirstName.Location = new System.Drawing.Point(33, 160);
            this.InvalidFirstName.Name = "InvalidFirstName";
            this.InvalidFirstName.Size = new System.Drawing.Size(137, 13);
            this.InvalidFirstName.TabIndex = 12;
            this.InvalidFirstName.Text = "Please provide a first name.";
            this.InvalidFirstName.Visible = false;
            // 
            // InvalidPhone
            // 
            this.InvalidPhone.AccessibleName = "InvalidPhone";
            this.InvalidPhone.AutoSize = true;
            this.InvalidPhone.ForeColor = System.Drawing.Color.Red;
            this.InvalidPhone.Location = new System.Drawing.Point(33, 293);
            this.InvalidPhone.Name = "InvalidPhone";
            this.InvalidPhone.Size = new System.Drawing.Size(137, 13);
            this.InvalidPhone.TabIndex = 18;
            this.InvalidPhone.Text = "Please provide a first name.";
            this.InvalidPhone.Visible = false;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.AccessibleName = "PhoneNumberInput";
            this.PhoneNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberInput.Location = new System.Drawing.Point(36, 270);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(109, 20);
            this.PhoneNumberInput.TabIndex = 17;
            this.PhoneNumberInput.TextChanged += new System.EventHandler(this.AddDashesToNumber_TextChanged);
            this.PhoneNumberInput.Leave += new System.EventHandler(this.PhoneNumber_Leave);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AccessibleName = "PhoneNumber";
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(33, 254);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 16;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // InvalidLastName
            // 
            this.InvalidLastName.AccessibleName = "InvalidLastName";
            this.InvalidLastName.AutoSize = true;
            this.InvalidLastName.ForeColor = System.Drawing.Color.Red;
            this.InvalidLastName.Location = new System.Drawing.Point(33, 224);
            this.InvalidLastName.Name = "InvalidLastName";
            this.InvalidLastName.Size = new System.Drawing.Size(137, 13);
            this.InvalidLastName.TabIndex = 15;
            this.InvalidLastName.Text = "Please provide a last name.";
            this.InvalidLastName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.AccessibleName = "LastName";
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(33, 185);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "Last Name";
            // 
            // LastNameInput
            // 
            this.LastNameInput.AccessibleName = "LastNameInput";
            this.LastNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameInput.Location = new System.Drawing.Point(36, 201);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(109, 20);
            this.LastNameInput.TabIndex = 13;
            this.LastNameInput.Leave += new System.EventHandler(this.LastNameInput_Leave);
            // 
            // InvalidCity
            // 
            this.InvalidCity.AccessibleName = "InvalidCity";
            this.InvalidCity.AutoSize = true;
            this.InvalidCity.ForeColor = System.Drawing.Color.Red;
            this.InvalidCity.Location = new System.Drawing.Point(254, 192);
            this.InvalidCity.Name = "InvalidCity";
            this.InvalidCity.Size = new System.Drawing.Size(126, 13);
            this.InvalidCity.TabIndex = 30;
            this.InvalidCity.Text = "Please enter a city name.";
            this.InvalidCity.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "FirstName";
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(257, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Leave += new System.EventHandler(this.City_Leave);
            // 
            // label4
            // 
            this.label4.AccessibleName = "PhoneNumber";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "City";
            // 
            // label8
            // 
            this.label8.AccessibleName = "LastName";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "User Id";
            // 
            // UserId
            // 
            this.UserId.AccessibleName = "UserId";
            this.UserId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserId.Location = new System.Drawing.Point(592, 82);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(109, 20);
            this.UserId.TabIndex = 25;
            this.UserId.Text = "E00";
            this.UserId.Leave += new System.EventHandler(this.ENumber_Leave);
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "FirstName";
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(257, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(267, 20);
            this.textBox6.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Line Two (apt., unit, etc.)";
            // 
            // InvalidAddress
            // 
            this.InvalidAddress.AccessibleName = "InvalidAddress";
            this.InvalidAddress.AutoSize = true;
            this.InvalidAddress.ForeColor = System.Drawing.Color.Red;
            this.InvalidAddress.Location = new System.Drawing.Point(254, 128);
            this.InvalidAddress.Name = "InvalidAddress";
            this.InvalidAddress.Size = new System.Drawing.Size(134, 13);
            this.InvalidAddress.TabIndex = 21;
            this.InvalidAddress.Text = "Address format is incorrect.";
            this.InvalidAddress.Visible = false;
            // 
            // label13
            // 
            this.label13.AccessibleName = "EmailLabel";
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Street Address Line One";
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "EmailInput";
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(257, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(267, 20);
            this.textBox7.TabIndex = 19;
            this.textBox7.Leave += new System.EventHandler(this.Street_Leave);
            // 
            // InvalidState
            // 
            this.InvalidState.AccessibleName = "InvalidState";
            this.InvalidState.AutoSize = true;
            this.InvalidState.ForeColor = System.Drawing.Color.Red;
            this.InvalidState.Location = new System.Drawing.Point(403, 192);
            this.InvalidState.Name = "InvalidState";
            this.InvalidState.Size = new System.Drawing.Size(130, 13);
            this.InvalidState.TabIndex = 33;
            this.InvalidState.Text = "Please enter a state name";
            this.InvalidState.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "FirstName";
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(406, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 20);
            this.textBox5.TabIndex = 32;
            this.textBox5.Leave += new System.EventHandler(this.State_Leave);
            // 
            // label10
            // 
            this.label10.AccessibleName = "PhoneNumber";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "State";
            // 
            // InvalidZip
            // 
            this.InvalidZip.AccessibleName = "InvalidZip";
            this.InvalidZip.AutoSize = true;
            this.InvalidZip.ForeColor = System.Drawing.Color.Red;
            this.InvalidZip.Location = new System.Drawing.Point(254, 260);
            this.InvalidZip.Name = "InvalidZip";
            this.InvalidZip.Size = new System.Drawing.Size(157, 13);
            this.InvalidZip.TabIndex = 36;
            this.InvalidZip.Text = "Please provide a valid zip code.";
            this.InvalidZip.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "FirstName";
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(257, 237);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(128, 20);
            this.textBox8.TabIndex = 35;
            this.textBox8.Leave += new System.EventHandler(this.Zip_Leave);
            // 
            // label15
            // 
            this.label15.AccessibleName = "PhoneNumber";
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Zip";
            // 
            // InvalidENumber
            // 
            this.InvalidENumber.AccessibleName = "InvalidENumber";
            this.InvalidENumber.AutoSize = true;
            this.InvalidENumber.ForeColor = System.Drawing.Color.Red;
            this.InvalidENumber.Location = new System.Drawing.Point(589, 105);
            this.InvalidENumber.Name = "InvalidENumber";
            this.InvalidENumber.Size = new System.Drawing.Size(179, 13);
            this.InvalidENumber.TabIndex = 37;
            this.InvalidENumber.Text = "Please enter a valid ETSU ENumber";
            this.InvalidENumber.Visible = false;
            // 
            // PersonalLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 497);
            this.Controls.Add(this.InvalidENumber);
            this.Controls.Add(this.InvalidZip);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.InvalidState);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.InvalidCity);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InvalidAddress);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.InvalidPhone);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.InvalidLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.InvalidFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvalidLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonalLibraryForm";
            this.Text = "Project 2 Main Screen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the button1.
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Defines the textBox1.
        /// </summary>
        private System.Windows.Forms.TextBox textBox1;

        /// <summary>
        /// Defines the label1.
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Defines the menuStrip1.
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStrip1;

        /// <summary>
        /// Defines the toolStripMenuItem1.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        /// <summary>
        /// Defines the openToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

        /// <summary>
        /// Defines the saveToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        /// <summary>
        /// Defines the sortToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;

        /// <summary>
        /// Defines the showAllByAuthorToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem showAllByAuthorToolStripMenuItem;

        /// <summary>
        /// Defines the quiteToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem quiteToolStripMenuItem;

        /// <summary>
        /// Defines the modifyToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;

        /// <summary>
        /// Defines the addToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

        /// <summary>
        /// Defines the removeToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

        /// <summary>
        /// Defines the editToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        /// <summary>
        /// Defines the updateOwnerToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem updateOwnerToolStripMenuItem;

        /// <summary>
        /// Defines the helpToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        /// <summary>
        /// Defines the aboutToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        /// <summary>
        /// Defines the statusStrip1.
        /// </summary>
        private System.Windows.Forms.StatusStrip statusStrip1;

        /// <summary>
        /// Defines the toolStripStatusLabel1.
        /// </summary>
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        /// <summary>
        /// Defines the InvalidLabel.
        /// </summary>
        private System.Windows.Forms.Label InvalidLabel;

        /// <summary>
        /// Defines the label2.
        /// </summary>
        private System.Windows.Forms.Label label2;

        /// <summary>
        /// Defines the FirstName.
        /// </summary>
        private System.Windows.Forms.TextBox FirstName;

        /// <summary>
        /// Defines the InvalidFirstName.
        /// </summary>
        private System.Windows.Forms.Label InvalidFirstName;

        /// <summary>
        /// Defines the InvalidPhone.
        /// </summary>
        private System.Windows.Forms.Label InvalidPhone;

        /// <summary>
        /// Defines the PhoneNumberInput.
        /// </summary>
        private System.Windows.Forms.TextBox PhoneNumberInput;

        /// <summary>
        /// Defines the PhoneNumber.
        /// </summary>
        private System.Windows.Forms.Label PhoneNumber;

        /// <summary>
        /// Defines the InvalidLastName.
        /// </summary>
        private System.Windows.Forms.Label InvalidLastName;

        /// <summary>
        /// Defines the LastName.
        /// </summary>
        private System.Windows.Forms.Label LastName;

        /// <summary>
        /// Defines the LastNameInput.
        /// </summary>
        private System.Windows.Forms.TextBox LastNameInput;

        /// <summary>
        /// Defines the InvalidCity.
        /// </summary>
        private System.Windows.Forms.Label InvalidCity;

        /// <summary>
        /// Defines the textBox2.
        /// </summary>
        private System.Windows.Forms.TextBox textBox2;

        /// <summary>
        /// Defines the label4.
        /// </summary>
        private System.Windows.Forms.Label label4;

        /// <summary>
        /// Defines the label8.
        /// </summary>
        private System.Windows.Forms.Label label8;

        /// <summary>
        /// Defines the UserId.
        /// </summary>
        private System.Windows.Forms.TextBox UserId;

        /// <summary>
        /// Defines the textBox6.
        /// </summary>
        private System.Windows.Forms.TextBox textBox6;

        /// <summary>
        /// Defines the label11.
        /// </summary>
        private System.Windows.Forms.Label label11;

        /// <summary>
        /// Defines the InvalidAddress.
        /// </summary>
        private System.Windows.Forms.Label InvalidAddress;

        /// <summary>
        /// Defines the label13.
        /// </summary>
        private System.Windows.Forms.Label label13;

        /// <summary>
        /// Defines the textBox7.
        /// </summary>
        private System.Windows.Forms.TextBox textBox7;

        /// <summary>
        /// Defines the InvalidState.
        /// </summary>
        private System.Windows.Forms.Label InvalidState;

        /// <summary>
        /// Defines the textBox5.
        /// </summary>
        private System.Windows.Forms.TextBox textBox5;

        /// <summary>
        /// Defines the label10.
        /// </summary>
        private System.Windows.Forms.Label label10;

        /// <summary>
        /// Defines the InvalidZip.
        /// </summary>
        private System.Windows.Forms.Label InvalidZip;

        /// <summary>
        /// Defines the textBox8.
        /// </summary>
        private System.Windows.Forms.TextBox textBox8;

        /// <summary>
        /// Defines the label15.
        /// </summary>
        private System.Windows.Forms.Label label15;

        /// <summary>
        /// Defines the InvalidENumber.
        /// </summary>
        private System.Windows.Forms.Label InvalidENumber;
    }
}
