namespace CS_3280_Assignment3_CWinkley
{
    partial class Assignment3
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
            this.ClientNametxtbx = new System.Windows.Forms.TextBox();
            this.ClientNamelbl = new System.Windows.Forms.Label();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.CompanyTxtBx = new System.Windows.Forms.TextBox();
            this.PositionLbl = new System.Windows.Forms.Label();
            this.ClientTab = new System.Windows.Forms.TabControl();
            this.Clients = new System.Windows.Forms.TabPage();
            this.PositionComboBx = new System.Windows.Forms.ComboBox();
            this.ClientListTxtBx = new System.Windows.Forms.TextBox();
            this.SubmitClientBtn = new System.Windows.Forms.Button();
            this.Addresses = new System.Windows.Forms.TabPage();
            this.KnownAddresstxtbx = new System.Windows.Forms.TextBox();
            this.Address_Submit_btn = new System.Windows.Forms.Button();
            this.CityLbl = new System.Windows.Forms.Label();
            this.CityTxtbx = new System.Windows.Forms.TextBox();
            this.ZipTxtBx = new System.Windows.Forms.TextBox();
            this.Statetxtbx = new System.Windows.Forms.TextBox();
            this.StreetTxtBx = new System.Windows.Forms.TextBox();
            this.ZipLbl = new System.Windows.Forms.Label();
            this.StateLbl = new System.Windows.Forms.Label();
            this.StreetLbl = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ClientTab.SuspendLayout();
            this.Clients.SuspendLayout();
            this.Addresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientNametxtbx
            // 
            this.ClientNametxtbx.Location = new System.Drawing.Point(88, 22);
            this.ClientNametxtbx.Name = "ClientNametxtbx";
            this.ClientNametxtbx.Size = new System.Drawing.Size(121, 20);
            this.ClientNametxtbx.TabIndex = 0;
            // 
            // ClientNamelbl
            // 
            this.ClientNamelbl.AutoSize = true;
            this.ClientNamelbl.Location = new System.Drawing.Point(18, 25);
            this.ClientNamelbl.Name = "ClientNamelbl";
            this.ClientNamelbl.Size = new System.Drawing.Size(64, 13);
            this.ClientNamelbl.TabIndex = 1;
            this.ClientNamelbl.Text = "Client Name";
            this.ClientNamelbl.Click += new System.EventHandler(this.Cli_Click);
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.AutoSize = true;
            this.CompanyLbl.Location = new System.Drawing.Point(21, 92);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(51, 13);
            this.CompanyLbl.TabIndex = 2;
            this.CompanyLbl.Text = "Company";
            // 
            // CompanyTxtBx
            // 
            this.CompanyTxtBx.Location = new System.Drawing.Point(88, 89);
            this.CompanyTxtBx.Name = "CompanyTxtBx";
            this.CompanyTxtBx.Size = new System.Drawing.Size(121, 20);
            this.CompanyTxtBx.TabIndex = 3;
            // 
            // PositionLbl
            // 
            this.PositionLbl.AutoSize = true;
            this.PositionLbl.Location = new System.Drawing.Point(21, 153);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(44, 13);
            this.PositionLbl.TabIndex = 4;
            this.PositionLbl.Text = "Position";
            this.PositionLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientTab
            // 
            this.ClientTab.Controls.Add(this.Clients);
            this.ClientTab.Controls.Add(this.Addresses);
            this.ClientTab.Location = new System.Drawing.Point(-6, 12);
            this.ClientTab.Name = "ClientTab";
            this.ClientTab.SelectedIndex = 0;
            this.ClientTab.Size = new System.Drawing.Size(1163, 525);
            this.ClientTab.TabIndex = 8;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.PositionComboBx);
            this.Clients.Controls.Add(this.ClientListTxtBx);
            this.Clients.Controls.Add(this.SubmitClientBtn);
            this.Clients.Controls.Add(this.ClientNamelbl);
            this.Clients.Controls.Add(this.ClientNametxtbx);
            this.Clients.Controls.Add(this.CompanyLbl);
            this.Clients.Controls.Add(this.CompanyTxtBx);
            this.Clients.Controls.Add(this.PositionLbl);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(1155, 499);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // PositionComboBx
            // 
            this.PositionComboBx.FormattingEnabled = true;
            this.PositionComboBx.Location = new System.Drawing.Point(88, 153);
            this.PositionComboBx.Name = "PositionComboBx";
            this.PositionComboBx.Size = new System.Drawing.Size(121, 21);
            this.PositionComboBx.TabIndex = 11;
            // 
            // ClientListTxtBx
            // 
            this.ClientListTxtBx.Location = new System.Drawing.Point(509, 21);
            this.ClientListTxtBx.Multiline = true;
            this.ClientListTxtBx.Name = "ClientListTxtBx";
            this.ClientListTxtBx.ReadOnly = true;
            this.ClientListTxtBx.Size = new System.Drawing.Size(244, 253);
            this.ClientListTxtBx.TabIndex = 10;
            this.ClientListTxtBx.TextChanged += new System.EventHandler(this.ClientListTxtBx_TextChanged);
            // 
            // SubmitClientBtn
            // 
            this.SubmitClientBtn.Location = new System.Drawing.Point(133, 251);
            this.SubmitClientBtn.Name = "SubmitClientBtn";
            this.SubmitClientBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitClientBtn.TabIndex = 9;
            this.SubmitClientBtn.Text = "Submit";
            this.SubmitClientBtn.UseVisualStyleBackColor = true;
            this.SubmitClientBtn.Click += new System.EventHandler(this.SubmitClientBtn_Click);
            // 
            // Addresses
            // 
            this.Addresses.Controls.Add(this.KnownAddresstxtbx);
            this.Addresses.Controls.Add(this.Address_Submit_btn);
            this.Addresses.Controls.Add(this.CityLbl);
            this.Addresses.Controls.Add(this.CityTxtbx);
            this.Addresses.Controls.Add(this.ZipTxtBx);
            this.Addresses.Controls.Add(this.Statetxtbx);
            this.Addresses.Controls.Add(this.StreetTxtBx);
            this.Addresses.Controls.Add(this.ZipLbl);
            this.Addresses.Controls.Add(this.StateLbl);
            this.Addresses.Controls.Add(this.StreetLbl);
            this.Addresses.Controls.Add(this.ClientListBox);
            this.Addresses.Location = new System.Drawing.Point(4, 22);
            this.Addresses.Name = "Addresses";
            this.Addresses.Padding = new System.Windows.Forms.Padding(3);
            this.Addresses.Size = new System.Drawing.Size(1155, 499);
            this.Addresses.TabIndex = 1;
            this.Addresses.Text = "Address";
            this.Addresses.UseVisualStyleBackColor = true;
            this.Addresses.Click += new System.EventHandler(this.Addresses_Click);
            // 
            // KnownAddresstxtbx
            // 
            this.KnownAddresstxtbx.Location = new System.Drawing.Point(311, 25);
            this.KnownAddresstxtbx.Multiline = true;
            this.KnownAddresstxtbx.Name = "KnownAddresstxtbx";
            this.KnownAddresstxtbx.ReadOnly = true;
            this.KnownAddresstxtbx.Size = new System.Drawing.Size(233, 145);
            this.KnownAddresstxtbx.TabIndex = 19;
            // 
            // Address_Submit_btn
            // 
            this.Address_Submit_btn.Location = new System.Drawing.Point(469, 367);
            this.Address_Submit_btn.Name = "Address_Submit_btn";
            this.Address_Submit_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Address_Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Address_Submit_btn.TabIndex = 18;
            this.Address_Submit_btn.Text = "Submit";
            this.Address_Submit_btn.UseVisualStyleBackColor = true;
            this.Address_Submit_btn.Click += new System.EventHandler(this.Address_Submit_btn_Click);
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Location = new System.Drawing.Point(272, 252);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(24, 13);
            this.CityLbl.TabIndex = 17;
            this.CityLbl.Text = "City";
            // 
            // CityTxtbx
            // 
            this.CityTxtbx.Location = new System.Drawing.Point(311, 252);
            this.CityTxtbx.Name = "CityTxtbx";
            this.CityTxtbx.Size = new System.Drawing.Size(233, 20);
            this.CityTxtbx.TabIndex = 16;
            // 
            // ZipTxtBx
            // 
            this.ZipTxtBx.Location = new System.Drawing.Point(311, 326);
            this.ZipTxtBx.Name = "ZipTxtBx";
            this.ZipTxtBx.Size = new System.Drawing.Size(233, 20);
            this.ZipTxtBx.TabIndex = 13;
            // 
            // Statetxtbx
            // 
            this.Statetxtbx.Location = new System.Drawing.Point(311, 285);
            this.Statetxtbx.Name = "Statetxtbx";
            this.Statetxtbx.Size = new System.Drawing.Size(233, 20);
            this.Statetxtbx.TabIndex = 12;
            // 
            // StreetTxtBx
            // 
            this.StreetTxtBx.Location = new System.Drawing.Point(311, 222);
            this.StreetTxtBx.Name = "StreetTxtBx";
            this.StreetTxtBx.Size = new System.Drawing.Size(233, 20);
            this.StreetTxtBx.TabIndex = 11;
            // 
            // ZipLbl
            // 
            this.ZipLbl.AutoSize = true;
            this.ZipLbl.Location = new System.Drawing.Point(272, 326);
            this.ZipLbl.Name = "ZipLbl";
            this.ZipLbl.Size = new System.Drawing.Size(22, 13);
            this.ZipLbl.TabIndex = 10;
            this.ZipLbl.Text = "Zip";
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Location = new System.Drawing.Point(269, 288);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(32, 13);
            this.StateLbl.TabIndex = 9;
            this.StateLbl.Text = "State";
            // 
            // StreetLbl
            // 
            this.StreetLbl.AutoSize = true;
            this.StreetLbl.Location = new System.Drawing.Point(229, 225);
            this.StreetLbl.Name = "StreetLbl";
            this.StreetLbl.Size = new System.Drawing.Size(76, 13);
            this.StreetLbl.TabIndex = 8;
            this.StreetLbl.Text = "Street Address";
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.Location = new System.Drawing.Point(14, 25);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(198, 355);
            this.ClientListBox.TabIndex = 7;
            // 
            // Assignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientTab);
            this.Name = "Assignment3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientTab.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            this.Addresses.ResumeLayout(false);
            this.Addresses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ClientNametxtbx;
        private System.Windows.Forms.Label ClientNamelbl;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.TextBox CompanyTxtBx;
        private System.Windows.Forms.Label PositionLbl;
        private System.Windows.Forms.TabControl ClientTab;
        private System.Windows.Forms.TabPage Clients;
        public System.Windows.Forms.TabPage Addresses;
        private System.Windows.Forms.TextBox ZipTxtBx;
        private System.Windows.Forms.TextBox Statetxtbx;
        private System.Windows.Forms.TextBox StreetTxtBx;
        private System.Windows.Forms.Label ZipLbl;
        private System.Windows.Forms.Label StateLbl;
        private System.Windows.Forms.Label StreetLbl;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.TextBox CityTxtbx;
        private System.Windows.Forms.Button Address_Submit_btn;
        private System.Windows.Forms.Button SubmitClientBtn;
        private System.Windows.Forms.TextBox ClientListTxtBx;
        private System.Windows.Forms.ComboBox PositionComboBx;
        private System.Windows.Forms.TextBox KnownAddresstxtbx;
    }
}

