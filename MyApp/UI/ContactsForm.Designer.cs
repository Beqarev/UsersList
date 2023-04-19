namespace MyApp
{
    partial class ContactsForm
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
            this.contactsGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearchPrivateNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchPrivateNumber = new System.Windows.Forms.Label();
            this.lblSearchPhone = new System.Windows.Forms.Label();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsGrid
            // 
            this.contactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGrid.Location = new System.Drawing.Point(13, 68);
            this.contactsGrid.Name = "contactsGrid";
            this.contactsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsGrid.Size = new System.Drawing.Size(776, 255);
            this.contactsGrid.TabIndex = 0;
            this.contactsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsGrid_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ახალი ჩანაწერი";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ძებნა";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSearchPrivateNumber
            // 
            this.txtSearchPrivateNumber.Location = new System.Drawing.Point(442, 24);
            this.txtSearchPrivateNumber.Name = "txtSearchPrivateNumber";
            this.txtSearchPrivateNumber.Size = new System.Drawing.Size(103, 20);
            this.txtSearchPrivateNumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearchPrivateNumber);
            this.groupBox1.Controls.Add(this.lblSearchPhone);
            this.groupBox1.Controls.Add(this.lblSearchEmail);
            this.groupBox1.Controls.Add(this.lblSearchLastName);
            this.groupBox1.Controls.Add(this.lblSearchFirstName);
            this.groupBox1.Controls.Add(this.txtSearchFirstName);
            this.groupBox1.Controls.Add(this.txtSearchLastName);
            this.groupBox1.Controls.Add(this.txtSearchEmail);
            this.groupBox1.Controls.Add(this.txtSearchPhone);
            this.groupBox1.Controls.Add(this.txtSearchPrivateNumber);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ძებნა";
            // 
            // lblSearchPrivateNumber
            // 
            this.lblSearchPrivateNumber.AutoSize = true;
            this.lblSearchPrivateNumber.Location = new System.Drawing.Point(454, 8);
            this.lblSearchPrivateNumber.Name = "lblSearchPrivateNumber";
            this.lblSearchPrivateNumber.Size = new System.Drawing.Size(91, 13);
            this.lblSearchPrivateNumber.TabIndex = 12;
            this.lblSearchPrivateNumber.Text = "პირადი ნომერი";
            // 
            // lblSearchPhone
            // 
            this.lblSearchPhone.AutoSize = true;
            this.lblSearchPhone.Location = new System.Drawing.Point(367, 9);
            this.lblSearchPhone.Name = "lblSearchPhone";
            this.lblSearchPhone.Size = new System.Drawing.Size(69, 13);
            this.lblSearchPhone.TabIndex = 11;
            this.lblSearchPhone.Text = "ტელეფონი";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(261, 8);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(66, 13);
            this.lblSearchEmail.TabIndex = 10;
            this.lblSearchEmail.Text = "ელ-ფოსტა";
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(183, 9);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(39, 13);
            this.lblSearchLastName.TabIndex = 9;
            this.lblSearchLastName.Text = "გვარი";
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(65, 9);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(49, 13);
            this.lblSearchFirstName.TabIndex = 8;
            this.lblSearchFirstName.Text = "სახელი";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(6, 25);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(103, 20);
            this.txtSearchFirstName.TabIndex = 7;
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(115, 25);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(103, 20);
            this.txtSearchLastName.TabIndex = 6;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(224, 25);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(103, 20);
            this.txtSearchEmail.TabIndex = 5;
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(333, 24);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(103, 20);
            this.txtSearchPhone.TabIndex = 4;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactsGrid);
            this.Name = "ContactsForm";
            this.Text = "Contacts Form";
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchPrivateNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearchPrivateNumber;
        private System.Windows.Forms.Label lblSearchPhone;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchPhone;
    }
}

