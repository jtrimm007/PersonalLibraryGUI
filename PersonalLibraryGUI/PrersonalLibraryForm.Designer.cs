///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         PrersonalLibraryForm.Designer.cs
//	Description:       Logic to display the Personal Library Form
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
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
            this.UpdateOwner = new System.Windows.Forms.Button();
            this.EmailInput = new System.Windows.Forms.TextBox();
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
            this.SortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberOfBooksStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.InvalidLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.InvalidFirstName = new System.Windows.Forms.Label();
            this.InvalidPhone = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.InvalidLastName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.InvalidCity = new System.Windows.Forms.Label();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UserIdInput = new System.Windows.Forms.TextBox();
            this.AddressLineTwoInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InvalidAddress = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StreetAddressLineOneInput = new System.Windows.Forms.TextBox();
            this.InvalidState = new System.Windows.Forms.Label();
            this.StateInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InvalidZip = new System.Windows.Forms.Label();
            this.ZipInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.InvalidENumber = new System.Windows.Forms.Label();
            this.LibraryOwnerBox = new System.Windows.Forms.GroupBox();
            this.CancelUpdateOwner = new System.Windows.Forms.Button();
            this.BookDetails = new System.Windows.Forms.GroupBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Coauthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BookType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BooksInLibrary = new System.Windows.Forms.ListBox();
            this.LibraryOwnerBottomBox = new System.Windows.Forms.GroupBox();
            this.LibraryOwnerEmailInput = new System.Windows.Forms.TextBox();
            this.OwnerEmailLabel = new System.Windows.Forms.Label();
            this.LibraryOwnerENumberInput = new System.Windows.Forms.TextBox();
            this.ENumberLabel = new System.Windows.Forms.Label();
            this.LibraryOwnerPhoneInput = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.LibraryOwnerNameInput = new System.Windows.Forms.TextBox();
            this.LibraryOwnerNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LibraryOwnerBox.SuspendLayout();
            this.BookDetails.SuspendLayout();
            this.LibraryOwnerBottomBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateOwner
            // 
            this.UpdateOwner.AccessibleName = "UpdateOwner";
            this.UpdateOwner.Location = new System.Drawing.Point(302, 328);
            this.UpdateOwner.Name = "UpdateOwner";
            this.UpdateOwner.Size = new System.Drawing.Size(75, 23);
            this.UpdateOwner.TabIndex = 0;
            this.UpdateOwner.Text = "Update";
            this.UpdateOwner.UseVisualStyleBackColor = true;
            this.UpdateOwner.Click += new System.EventHandler(this.UpdateOwner_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.AccessibleName = "EmailInput";
            this.EmailInput.Location = new System.Drawing.Point(27, 37);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(121, 20);
            this.EmailInput.TabIndex = 1;
            this.EmailInput.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // label1
            // 
            this.label1.AccessibleName = "EmailLabel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.modifyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(173, 28);
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // showAllByAuthorToolStripMenuItem
            // 
            this.showAllByAuthorToolStripMenuItem.Name = "showAllByAuthorToolStripMenuItem";
            this.showAllByAuthorToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.showAllByAuthorToolStripMenuItem.Text = "Show All by Author";
            this.showAllByAuthorToolStripMenuItem.Click += new System.EventHandler(this.showAllByAuthorToolStripMenuItem_Click);
            // 
            // quiteToolStripMenuItem
            // 
            this.quiteToolStripMenuItem.Name = "quiteToolStripMenuItem";
            this.quiteToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.quiteToolStripMenuItem.Text = "Quite";
            this.quiteToolStripMenuItem.Click += new System.EventHandler(this.quiteToolStripMenuItem_Click);
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
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // updateOwnerToolStripMenuItem
            // 
            this.updateOwnerToolStripMenuItem.Name = "updateOwnerToolStripMenuItem";
            this.updateOwnerToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.updateOwnerToolStripMenuItem.Text = "Update Owner";
            this.updateOwnerToolStripMenuItem.Click += new System.EventHandler(this.updateOwnerToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortStatus,
            this.SaveStatus,
            this.NumberOfBooksStatus,
            this.DateTimeStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(789, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SortStatus
            // 
            this.SortStatus.AccessibleName = "SortStatus";
            this.SortStatus.Name = "SortStatus";
            this.SortStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // SaveStatus
            // 
            this.SaveStatus.AccessibleName = "SaveStatus";
            this.SaveStatus.Name = "SaveStatus";
            this.SaveStatus.Size = new System.Drawing.Size(144, 20);
            this.SaveStatus.Text = "Save Status Unsaved";
            // 
            // NumberOfBooksStatus
            // 
            this.NumberOfBooksStatus.AccessibleName = "NumberOfBooksStatus";
            this.NumberOfBooksStatus.Name = "NumberOfBooksStatus";
            this.NumberOfBooksStatus.Size = new System.Drawing.Size(137, 20);
            this.NumberOfBooksStatus.Text = "Number of Books 0";
            // 
            // DateTimeStatus
            // 
            this.DateTimeStatus.AccessibleName = "DateTimeStatus";
            this.DateTimeStatus.Name = "DateTimeStatus";
            this.DateTimeStatus.Size = new System.Drawing.Size(93, 20);
            this.DateTimeStatus.Text = "Current Date";
            // 
            // InvalidLabel
            // 
            this.InvalidLabel.AccessibleName = "InvalidEmail";
            this.InvalidLabel.AutoSize = true;
            this.InvalidLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidLabel.Location = new System.Drawing.Point(23, 60);
            this.InvalidLabel.Name = "InvalidLabel";
            this.InvalidLabel.Size = new System.Drawing.Size(101, 13);
            this.InvalidLabel.TabIndex = 5;
            this.InvalidLabel.Text = "Invalid Email Format";
            this.InvalidLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.AccessibleName = "FirstNameInput";
            this.FirstNameInput.Location = new System.Drawing.Point(27, 106);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(121, 20);
            this.FirstNameInput.TabIndex = 11;
            this.FirstNameInput.Leave += new System.EventHandler(this.FirstName_Leave);
            // 
            // InvalidFirstName
            // 
            this.InvalidFirstName.AccessibleName = "InvalidFirstName";
            this.InvalidFirstName.AutoSize = true;
            this.InvalidFirstName.ForeColor = System.Drawing.Color.Red;
            this.InvalidFirstName.Location = new System.Drawing.Point(23, 129);
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
            this.InvalidPhone.Location = new System.Drawing.Point(23, 262);
            this.InvalidPhone.Name = "InvalidPhone";
            this.InvalidPhone.Size = new System.Drawing.Size(137, 13);
            this.InvalidPhone.TabIndex = 18;
            this.InvalidPhone.Text = "Please provide a first name.";
            this.InvalidPhone.Visible = false;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.AccessibleName = "PhoneNumberInput";
            this.PhoneNumberInput.Location = new System.Drawing.Point(27, 239);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(121, 20);
            this.PhoneNumberInput.TabIndex = 17;
            this.PhoneNumberInput.TextChanged += new System.EventHandler(this.AddDashesToNumber_TextChanged);
            this.PhoneNumberInput.Leave += new System.EventHandler(this.PhoneNumber_Leave);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AccessibleName = "PhoneNumber";
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(23, 223);
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
            this.InvalidLastName.Location = new System.Drawing.Point(23, 193);
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
            this.LastName.Location = new System.Drawing.Point(23, 154);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "Last Name";
            // 
            // LastNameInput
            // 
            this.LastNameInput.AccessibleName = "LastNameInput";
            this.LastNameInput.Location = new System.Drawing.Point(27, 170);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(121, 20);
            this.LastNameInput.TabIndex = 13;
            this.LastNameInput.Leave += new System.EventHandler(this.LastNameInput_Leave);
            // 
            // InvalidCity
            // 
            this.InvalidCity.AccessibleName = "InvalidCity";
            this.InvalidCity.AutoSize = true;
            this.InvalidCity.ForeColor = System.Drawing.Color.Red;
            this.InvalidCity.Location = new System.Drawing.Point(198, 161);
            this.InvalidCity.Name = "InvalidCity";
            this.InvalidCity.Size = new System.Drawing.Size(126, 13);
            this.InvalidCity.TabIndex = 30;
            this.InvalidCity.Text = "Please enter a city name.";
            this.InvalidCity.Visible = false;
            // 
            // CityInput
            // 
            this.CityInput.AccessibleName = "CityInput";
            this.CityInput.Location = new System.Drawing.Point(201, 138);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(140, 20);
            this.CityInput.TabIndex = 29;
            this.CityInput.Leave += new System.EventHandler(this.City_Leave);
            // 
            // label4
            // 
            this.label4.AccessibleName = "PhoneNumber";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "City";
            // 
            // label8
            // 
            this.label8.AccessibleName = "LastName";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "User Id";
            // 
            // UserIdInput
            // 
            this.UserIdInput.AccessibleName = "UserIdInput";
            this.UserIdInput.Location = new System.Drawing.Point(201, 275);
            this.UserIdInput.Name = "UserIdInput";
            this.UserIdInput.Size = new System.Drawing.Size(121, 20);
            this.UserIdInput.TabIndex = 25;
            this.UserIdInput.Text = "E00";
            this.UserIdInput.Leave += new System.EventHandler(this.ENumber_Leave);
            // 
            // AddressLineTwoInput
            // 
            this.AddressLineTwoInput.AccessibleName = "AddressLineTwoInput";
            this.AddressLineTwoInput.Location = new System.Drawing.Point(201, 74);
            this.AddressLineTwoInput.Name = "AddressLineTwoInput";
            this.AddressLineTwoInput.Size = new System.Drawing.Size(279, 20);
            this.AddressLineTwoInput.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 60);
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
            this.InvalidAddress.Location = new System.Drawing.Point(198, 97);
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
            this.label13.Location = new System.Drawing.Point(198, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Street Address Line One";
            // 
            // StreetAddressLineOneInput
            // 
            this.StreetAddressLineOneInput.AccessibleName = "StreetAddressLineOneInput";
            this.StreetAddressLineOneInput.Location = new System.Drawing.Point(201, 37);
            this.StreetAddressLineOneInput.Name = "StreetAddressLineOneInput";
            this.StreetAddressLineOneInput.Size = new System.Drawing.Size(279, 20);
            this.StreetAddressLineOneInput.TabIndex = 19;
            this.StreetAddressLineOneInput.Leave += new System.EventHandler(this.Street_Leave);
            // 
            // InvalidState
            // 
            this.InvalidState.AccessibleName = "InvalidState";
            this.InvalidState.AutoSize = true;
            this.InvalidState.ForeColor = System.Drawing.Color.Red;
            this.InvalidState.Location = new System.Drawing.Point(347, 161);
            this.InvalidState.Name = "InvalidState";
            this.InvalidState.Size = new System.Drawing.Size(130, 13);
            this.InvalidState.TabIndex = 33;
            this.InvalidState.Text = "Please enter a state name";
            this.InvalidState.Visible = false;
            // 
            // StateInput
            // 
            this.StateInput.AccessibleName = "StateInput";
            this.StateInput.Location = new System.Drawing.Point(350, 138);
            this.StateInput.Name = "StateInput";
            this.StateInput.Size = new System.Drawing.Size(130, 20);
            this.StateInput.TabIndex = 32;
            this.StateInput.Leave += new System.EventHandler(this.State_Leave);
            // 
            // label10
            // 
            this.label10.AccessibleName = "PhoneNumber";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 122);
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
            this.InvalidZip.Location = new System.Drawing.Point(198, 229);
            this.InvalidZip.Name = "InvalidZip";
            this.InvalidZip.Size = new System.Drawing.Size(157, 13);
            this.InvalidZip.TabIndex = 36;
            this.InvalidZip.Text = "Please provide a valid zip code.";
            this.InvalidZip.Visible = false;
            // 
            // ZipInput
            // 
            this.ZipInput.AccessibleName = "ZipInput";
            this.ZipInput.Location = new System.Drawing.Point(201, 206);
            this.ZipInput.Name = "ZipInput";
            this.ZipInput.Size = new System.Drawing.Size(140, 20);
            this.ZipInput.TabIndex = 35;
            this.ZipInput.Leave += new System.EventHandler(this.Zip_Leave);
            // 
            // label15
            // 
            this.label15.AccessibleName = "PhoneNumber";
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(198, 190);
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
            this.InvalidENumber.Location = new System.Drawing.Point(198, 298);
            this.InvalidENumber.Name = "InvalidENumber";
            this.InvalidENumber.Size = new System.Drawing.Size(179, 13);
            this.InvalidENumber.TabIndex = 37;
            this.InvalidENumber.Text = "Please enter a valid ETSU ENumber";
            this.InvalidENumber.Visible = false;
            // 
            // LibraryOwnerBox
            // 
            this.LibraryOwnerBox.AccessibleName = "LibraryOwnerBox";
            this.LibraryOwnerBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LibraryOwnerBox.Controls.Add(this.CancelUpdateOwner);
            this.LibraryOwnerBox.Controls.Add(this.FirstNameInput);
            this.LibraryOwnerBox.Controls.Add(this.InvalidENumber);
            this.LibraryOwnerBox.Controls.Add(this.UpdateOwner);
            this.LibraryOwnerBox.Controls.Add(this.EmailInput);
            this.LibraryOwnerBox.Controls.Add(this.InvalidZip);
            this.LibraryOwnerBox.Controls.Add(this.label1);
            this.LibraryOwnerBox.Controls.Add(this.ZipInput);
            this.LibraryOwnerBox.Controls.Add(this.InvalidLabel);
            this.LibraryOwnerBox.Controls.Add(this.label15);
            this.LibraryOwnerBox.Controls.Add(this.label2);
            this.LibraryOwnerBox.Controls.Add(this.InvalidState);
            this.LibraryOwnerBox.Controls.Add(this.InvalidFirstName);
            this.LibraryOwnerBox.Controls.Add(this.StateInput);
            this.LibraryOwnerBox.Controls.Add(this.LastNameInput);
            this.LibraryOwnerBox.Controls.Add(this.label10);
            this.LibraryOwnerBox.Controls.Add(this.LastName);
            this.LibraryOwnerBox.Controls.Add(this.InvalidCity);
            this.LibraryOwnerBox.Controls.Add(this.InvalidLastName);
            this.LibraryOwnerBox.Controls.Add(this.CityInput);
            this.LibraryOwnerBox.Controls.Add(this.PhoneNumber);
            this.LibraryOwnerBox.Controls.Add(this.label4);
            this.LibraryOwnerBox.Controls.Add(this.PhoneNumberInput);
            this.LibraryOwnerBox.Controls.Add(this.label8);
            this.LibraryOwnerBox.Controls.Add(this.InvalidPhone);
            this.LibraryOwnerBox.Controls.Add(this.UserIdInput);
            this.LibraryOwnerBox.Controls.Add(this.AddressLineTwoInput);
            this.LibraryOwnerBox.Controls.Add(this.StreetAddressLineOneInput);
            this.LibraryOwnerBox.Controls.Add(this.label11);
            this.LibraryOwnerBox.Controls.Add(this.label13);
            this.LibraryOwnerBox.Controls.Add(this.InvalidAddress);
            this.LibraryOwnerBox.Location = new System.Drawing.Point(234, 28);
            this.LibraryOwnerBox.Name = "LibraryOwnerBox";
            this.LibraryOwnerBox.Size = new System.Drawing.Size(548, 438);
            this.LibraryOwnerBox.TabIndex = 38;
            this.LibraryOwnerBox.TabStop = false;
            this.LibraryOwnerBox.Text = "Library Owner";
            this.LibraryOwnerBox.Visible = false;
            // 
            // CancelUpdateOwner
            // 
            this.CancelUpdateOwner.AccessibleName = "CancelUpdateOwner";
            this.CancelUpdateOwner.Location = new System.Drawing.Point(402, 328);
            this.CancelUpdateOwner.Name = "CancelUpdateOwner";
            this.CancelUpdateOwner.Size = new System.Drawing.Size(75, 23);
            this.CancelUpdateOwner.TabIndex = 40;
            this.CancelUpdateOwner.Text = "Cancel";
            this.CancelUpdateOwner.UseVisualStyleBackColor = true;
            this.CancelUpdateOwner.Click += new System.EventHandler(this.CancelUpdateOwner_Click);
            // 
            // BookDetails
            // 
            this.BookDetails.AccessibleName = "BookDetails";
            this.BookDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookDetails.Controls.Add(this.AddBookButton);
            this.BookDetails.Controls.Add(this.Update);
            this.BookDetails.Controls.Add(this.Price);
            this.BookDetails.Controls.Add(this.label12);
            this.BookDetails.Controls.Add(this.Category);
            this.BookDetails.Controls.Add(this.label9);
            this.BookDetails.Controls.Add(this.Coauthor);
            this.BookDetails.Controls.Add(this.label7);
            this.BookDetails.Controls.Add(this.Author);
            this.BookDetails.Controls.Add(this.label6);
            this.BookDetails.Controls.Add(this.Title);
            this.BookDetails.Controls.Add(this.label5);
            this.BookDetails.Controls.Add(this.BookType);
            this.BookDetails.Controls.Add(this.label3);
            this.BookDetails.Location = new System.Drawing.Point(236, 28);
            this.BookDetails.Name = "BookDetails";
            this.BookDetails.Size = new System.Drawing.Size(546, 417);
            this.BookDetails.TabIndex = 39;
            this.BookDetails.TabStop = false;
            this.BookDetails.Text = "Book Details";
            // 
            // AddBookButton
            // 
            this.AddBookButton.AccessibleName = "AddBookButton";
            this.AddBookButton.Location = new System.Drawing.Point(389, 275);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 13;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Visible = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // Update
            // 
            this.Update.AccessibleName = "Update";
            this.Update.Location = new System.Drawing.Point(387, 275);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Price
            // 
            this.Price.AccessibleName = "Price";
            this.Price.Location = new System.Drawing.Point(171, 145);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Price";
            // 
            // Category
            // 
            this.Category.AccessibleName = "Category";
            this.Category.Location = new System.Drawing.Point(170, 66);
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Size = new System.Drawing.Size(100, 20);
            this.Category.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Category";
            // 
            // Coauthor
            // 
            this.Coauthor.AccessibleName = "Coauthor";
            this.Coauthor.Location = new System.Drawing.Point(28, 275);
            this.Coauthor.Name = "Coauthor";
            this.Coauthor.ReadOnly = true;
            this.Coauthor.Size = new System.Drawing.Size(100, 20);
            this.Coauthor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Coauthor";
            // 
            // Author
            // 
            this.Author.AccessibleName = "Author";
            this.Author.Location = new System.Drawing.Point(27, 206);
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Size = new System.Drawing.Size(100, 20);
            this.Author.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Author";
            // 
            // Title
            // 
            this.Title.AccessibleName = "Title";
            this.Title.Location = new System.Drawing.Point(26, 138);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // BookType
            // 
            this.BookType.AccessibleName = "BookType";
            this.BookType.Location = new System.Drawing.Point(27, 67);
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            this.BookType.Size = new System.Drawing.Size(100, 20);
            this.BookType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Type";
            // 
            // BooksInLibrary
            // 
            this.BooksInLibrary.AccessibleName = "BooksInLibrary";
            this.BooksInLibrary.FormattingEnabled = true;
            this.BooksInLibrary.Location = new System.Drawing.Point(0, 28);
            this.BooksInLibrary.Name = "BooksInLibrary";
            this.BooksInLibrary.Size = new System.Drawing.Size(225, 524);
            this.BooksInLibrary.TabIndex = 40;
            this.BooksInLibrary.Click += new System.EventHandler(this.BooksInLibrary_Click);
            // 
            // LibraryOwnerBottomBox
            // 
            this.LibraryOwnerBottomBox.AccessibleName = "LibraryOwnerBottomBox";
            this.LibraryOwnerBottomBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryOwnerBottomBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LibraryOwnerBottomBox.Controls.Add(this.LibraryOwnerEmailInput);
            this.LibraryOwnerBottomBox.Controls.Add(this.OwnerEmailLabel);
            this.LibraryOwnerBottomBox.Controls.Add(this.LibraryOwnerENumberInput);
            this.LibraryOwnerBottomBox.Controls.Add(this.ENumberLabel);
            this.LibraryOwnerBottomBox.Controls.Add(this.LibraryOwnerPhoneInput);
            this.LibraryOwnerBottomBox.Controls.Add(this.PhoneNumberLabel);
            this.LibraryOwnerBottomBox.Controls.Add(this.LibraryOwnerNameInput);
            this.LibraryOwnerBottomBox.Controls.Add(this.LibraryOwnerNameLabel);
            this.LibraryOwnerBottomBox.Location = new System.Drawing.Point(236, 453);
            this.LibraryOwnerBottomBox.Name = "LibraryOwnerBottomBox";
            this.LibraryOwnerBottomBox.Size = new System.Drawing.Size(547, 100);
            this.LibraryOwnerBottomBox.TabIndex = 41;
            this.LibraryOwnerBottomBox.TabStop = false;
            this.LibraryOwnerBottomBox.Text = "Library Owner Info";
            // 
            // LibraryOwnerEmailInput
            // 
            this.LibraryOwnerEmailInput.AccessibleName = "LibraryOwnerEmailInput";
            this.LibraryOwnerEmailInput.Location = new System.Drawing.Point(412, 62);
            this.LibraryOwnerEmailInput.Name = "LibraryOwnerEmailInput";
            this.LibraryOwnerEmailInput.ReadOnly = true;
            this.LibraryOwnerEmailInput.Size = new System.Drawing.Size(115, 20);
            this.LibraryOwnerEmailInput.TabIndex = 7;
            // 
            // OwnerEmailLabel
            // 
            this.OwnerEmailLabel.AccessibleName = "OwnerEmailLabel";
            this.OwnerEmailLabel.AutoSize = true;
            this.OwnerEmailLabel.Location = new System.Drawing.Point(409, 34);
            this.OwnerEmailLabel.Name = "OwnerEmailLabel";
            this.OwnerEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.OwnerEmailLabel.TabIndex = 6;
            this.OwnerEmailLabel.Text = "Email";
            // 
            // LibraryOwnerENumberInput
            // 
            this.LibraryOwnerENumberInput.AccessibleName = "LibraryOwnerENumberInput";
            this.LibraryOwnerENumberInput.Location = new System.Drawing.Point(277, 62);
            this.LibraryOwnerENumberInput.Name = "LibraryOwnerENumberInput";
            this.LibraryOwnerENumberInput.ReadOnly = true;
            this.LibraryOwnerENumberInput.Size = new System.Drawing.Size(115, 20);
            this.LibraryOwnerENumberInput.TabIndex = 5;
            // 
            // ENumberLabel
            // 
            this.ENumberLabel.AccessibleName = "ENumberLabel";
            this.ENumberLabel.AutoSize = true;
            this.ENumberLabel.Location = new System.Drawing.Point(274, 34);
            this.ENumberLabel.Name = "ENumberLabel";
            this.ENumberLabel.Size = new System.Drawing.Size(54, 13);
            this.ENumberLabel.TabIndex = 4;
            this.ENumberLabel.Text = "E Number";
            // 
            // LibraryOwnerPhoneInput
            // 
            this.LibraryOwnerPhoneInput.AccessibleName = "LibraryOwnerPhoneInput";
            this.LibraryOwnerPhoneInput.Location = new System.Drawing.Point(139, 62);
            this.LibraryOwnerPhoneInput.Name = "LibraryOwnerPhoneInput";
            this.LibraryOwnerPhoneInput.ReadOnly = true;
            this.LibraryOwnerPhoneInput.Size = new System.Drawing.Size(115, 20);
            this.LibraryOwnerPhoneInput.TabIndex = 3;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AccessibleName = "PhoneNumberLabel";
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(136, 34);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // LibraryOwnerNameInput
            // 
            this.LibraryOwnerNameInput.AccessibleName = "LibraryOwnerNameInput";
            this.LibraryOwnerNameInput.Location = new System.Drawing.Point(9, 62);
            this.LibraryOwnerNameInput.Name = "LibraryOwnerNameInput";
            this.LibraryOwnerNameInput.ReadOnly = true;
            this.LibraryOwnerNameInput.Size = new System.Drawing.Size(115, 20);
            this.LibraryOwnerNameInput.TabIndex = 1;
            // 
            // LibraryOwnerNameLabel
            // 
            this.LibraryOwnerNameLabel.AccessibleName = "LibraryOwnerNameLabel";
            this.LibraryOwnerNameLabel.AutoSize = true;
            this.LibraryOwnerNameLabel.Location = new System.Drawing.Point(6, 34);
            this.LibraryOwnerNameLabel.Name = "LibraryOwnerNameLabel";
            this.LibraryOwnerNameLabel.Size = new System.Drawing.Size(103, 13);
            this.LibraryOwnerNameLabel.TabIndex = 0;
            this.LibraryOwnerNameLabel.Text = "Library Owner Name";
            // 
            // PersonalLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 581);
            this.Controls.Add(this.LibraryOwnerBottomBox);
            this.Controls.Add(this.BooksInLibrary);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BookDetails);
            this.Controls.Add(this.LibraryOwnerBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonalLibraryForm";
            this.Text = "Project 2 Main Screen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LibraryOwnerBox.ResumeLayout(false);
            this.LibraryOwnerBox.PerformLayout();
            this.BookDetails.ResumeLayout(false);
            this.BookDetails.PerformLayout();
            this.LibraryOwnerBottomBox.ResumeLayout(false);
            this.LibraryOwnerBottomBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the button1.
        /// </summary>
        private System.Windows.Forms.Button UpdateOwner;

        /// <summary>
        /// Defines the textBox1.
        /// </summary>
        private System.Windows.Forms.TextBox EmailInput;

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
        private System.Windows.Forms.ToolStripStatusLabel SortStatus;

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
        private System.Windows.Forms.TextBox FirstNameInput;

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
        private System.Windows.Forms.TextBox CityInput;

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
        private System.Windows.Forms.TextBox UserIdInput;

        /// <summary>
        /// Defines the textBox6.
        /// </summary>
        private System.Windows.Forms.TextBox AddressLineTwoInput;

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
        private System.Windows.Forms.TextBox StreetAddressLineOneInput;

        /// <summary>
        /// Defines the InvalidState.
        /// </summary>
        private System.Windows.Forms.Label InvalidState;

        /// <summary>
        /// Defines the textBox5.
        /// </summary>
        private System.Windows.Forms.TextBox StateInput;

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
        private System.Windows.Forms.TextBox ZipInput;

        /// <summary>
        /// Defines the label15.
        /// </summary>
        private System.Windows.Forms.Label label15;

        /// <summary>
        /// Defines the InvalidENumber.
        /// </summary>
        private System.Windows.Forms.Label InvalidENumber;
        private System.Windows.Forms.GroupBox LibraryOwnerBox;
        private System.Windows.Forms.GroupBox BookDetails;
        private System.Windows.Forms.ListBox BooksInLibrary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookType;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Coauthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button CancelUpdateOwner;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.GroupBox LibraryOwnerBottomBox;
        private System.Windows.Forms.TextBox LibraryOwnerEmailInput;
        private System.Windows.Forms.Label OwnerEmailLabel;
        private System.Windows.Forms.TextBox LibraryOwnerENumberInput;
        private System.Windows.Forms.Label ENumberLabel;
        private System.Windows.Forms.TextBox LibraryOwnerPhoneInput;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox LibraryOwnerNameInput;
        private System.Windows.Forms.Label LibraryOwnerNameLabel;
        private System.Windows.Forms.ToolStripStatusLabel SaveStatus;
        private System.Windows.Forms.ToolStripStatusLabel NumberOfBooksStatus;
        private System.Windows.Forms.ToolStripStatusLabel DateTimeStatus;
    }
}
