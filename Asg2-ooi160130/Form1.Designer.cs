namespace CS6326Asg2
{
    partial class Form1
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
            this.recordList = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.midInitText = new System.Windows.Forms.TextBox();
            this.addrLine1Text = new System.Windows.Forms.TextBox();
            this.addrLine2Text = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.receiptYes = new System.Windows.Forms.RadioButton();
            this.receiptNo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordList
            // 
            this.recordList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.recordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName,
            this.colMI,
            this.colPhoneNumber});
            this.recordList.FullRowSelect = true;
            this.recordList.Location = new System.Drawing.Point(362, 36);
            this.recordList.Margin = new System.Windows.Forms.Padding(2);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(381, 510);
            this.recordList.TabIndex = 17;
            this.recordList.UseCompatibleStateImageBehavior = false;
            this.recordList.View = System.Windows.Forms.View.Details;
            this.recordList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 106;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 112;
            // 
            // colMI
            // 
            this.colMI.Text = "MI";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phone Number";
            this.colPhoneNumber.Width = 127;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(87, 36);
            this.firstNameText.MaxLength = 20;
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(187, 20);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address Line 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address Line 2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Zip Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-mail address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Proof of purchase attached";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date Received";
            // 
            // lastNameText
            // 
            this.lastNameText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lastNameText.Location = new System.Drawing.Point(87, 74);
            this.lastNameText.MaxLength = 20;
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(187, 20);
            this.lastNameText.TabIndex = 2;
            // 
            // midInitText
            // 
            this.midInitText.Location = new System.Drawing.Point(87, 109);
            this.midInitText.MaxLength = 1;
            this.midInitText.Name = "midInitText";
            this.midInitText.Size = new System.Drawing.Size(29, 20);
            this.midInitText.TabIndex = 3;
            this.midInitText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addrLine1Text
            // 
            this.addrLine1Text.Location = new System.Drawing.Point(95, 144);
            this.addrLine1Text.MaxLength = 35;
            this.addrLine1Text.Name = "addrLine1Text";
            this.addrLine1Text.Size = new System.Drawing.Size(224, 20);
            this.addrLine1Text.TabIndex = 4;
            // 
            // addrLine2Text
            // 
            this.addrLine2Text.Location = new System.Drawing.Point(95, 176);
            this.addrLine2Text.MaxLength = 35;
            this.addrLine2Text.Name = "addrLine2Text";
            this.addrLine2Text.Size = new System.Drawing.Size(224, 20);
            this.addrLine2Text.TabIndex = 5;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(42, 207);
            this.cityText.MaxLength = 25;
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(126, 20);
            this.cityText.TabIndex = 6;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(50, 244);
            this.stateText.MaxLength = 2;
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(27, 20);
            this.stateText.TabIndex = 7;
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(68, 280);
            this.zipCodeText.MaxLength = 9;
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(100, 20);
            this.zipCodeText.TabIndex = 8;
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(96, 314);
            this.phoneNumberText.MaxLength = 21;
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(146, 20);
            this.phoneNumberText.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(93, 347);
            this.emailText.MaxLength = 60;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(149, 20);
            this.emailText.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 405);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // receiptYes
            // 
            this.receiptYes.AutoSize = true;
            this.receiptYes.Location = new System.Drawing.Point(154, 376);
            this.receiptYes.Name = "receiptYes";
            this.receiptYes.Size = new System.Drawing.Size(43, 17);
            this.receiptYes.TabIndex = 11;
            this.receiptYes.Text = "Yes";
            this.receiptYes.UseVisualStyleBackColor = true;
            this.receiptYes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // receiptNo
            // 
            this.receiptNo.AutoSize = true;
            this.receiptNo.Location = new System.Drawing.Point(203, 376);
            this.receiptNo.Name = "receiptNo";
            this.receiptNo.Size = new System.Drawing.Size(39, 17);
            this.receiptNo.TabIndex = 12;
            this.receiptNo.Text = "No";
            this.receiptNo.UseVisualStyleBackColor = true;
            this.receiptNo.CheckedChanged += new System.EventHandler(this.receiptNo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "New Record";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiptNo);
            this.Controls.Add(this.receiptYes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.addrLine2Text);
            this.Controls.Add(this.addrLine1Text);
            this.Controls.Add(this.midInitText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.recordList);
            this.Name = "Form1";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recordList;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colMI;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox midInitText;
        private System.Windows.Forms.TextBox addrLine1Text;
        private System.Windows.Forms.TextBox addrLine2Text;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton receiptYes;
        private System.Windows.Forms.RadioButton receiptNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.Button button4;
    }
}

