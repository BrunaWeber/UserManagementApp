
namespace UserManagementApp
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.labelUserManagement = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxURLImage = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserManagement
            // 
            this.labelUserManagement.AutoSize = true;
            this.labelUserManagement.Font = new System.Drawing.Font("Arial Nova Cond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserManagement.ForeColor = System.Drawing.Color.White;
            this.labelUserManagement.Location = new System.Drawing.Point(211, 20);
            this.labelUserManagement.Name = "labelUserManagement";
            this.labelUserManagement.Size = new System.Drawing.Size(361, 33);
            this.labelUserManagement.TabIndex = 1;
            this.labelUserManagement.Text = "User Management Application";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(170, 454);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 34);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGroup.Location = new System.Drawing.Point(29, 289);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(70, 25);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Group:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(29, 204);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 25);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdministrator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdministrator.Location = new System.Drawing.Point(29, 165);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(136, 25);
            this.labelAdministrator.TabIndex = 6;
            this.labelAdministrator.Text = "Administrator:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPhoneNumber.Location = new System.Drawing.Point(29, 126);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(146, 25);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImage.Location = new System.Drawing.Point(29, 87);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(109, 25);
            this.labelImage.TabIndex = 23;
            this.labelImage.Text = "URL Image:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(29, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmailAddress.Location = new System.Drawing.Point(29, 8);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(136, 25);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "Email Address:";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(198, 8);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(266, 31);
            this.textBoxEmailAddress.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(198, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(266, 31);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxURLImage
            // 
            this.textBoxURLImage.Location = new System.Drawing.Point(198, 88);
            this.textBoxURLImage.Name = "textBoxURLImage";
            this.textBoxURLImage.Size = new System.Drawing.Size(266, 31);
            this.textBoxURLImage.TabIndex = 24;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(198, 128);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(266, 31);
            this.textBoxPhoneNumber.TabIndex = 10;
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(198, 168);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAdministrator.TabIndex = 22;
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(198, 198);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(266, 31);
            this.textBoxPassword.TabIndex = 12;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Sales",
            "Marketing",
            "Human Resources",
            "I.T. | Development",
            "Quality Assurance",
            "Accounts",
            "Operations"});
            this.comboBoxGroup.Location = new System.Drawing.Point(198, 286);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(266, 33);
            this.comboBoxGroup.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(60, 454);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 34);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.textBoxPassword2);
            this.panel1.Controls.Add(this.labelPassword2);
            this.panel1.Controls.Add(this.textBoxURLImage);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.checkBoxAdministrator);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxEmailAddress);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelAdministrator);
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Controls.Add(this.labelEmailAddress);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelGroup);
            this.panel1.Controls.Add(this.comboBoxGroup);
            this.panel1.Location = new System.Drawing.Point(61, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 355);
            this.panel1.TabIndex = 28;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(197, 243);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(266, 31);
            this.textBoxPassword2.TabIndex = 26;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword2.Location = new System.Drawing.Point(28, 244);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(162, 25);
            this.labelPassword2.TabIndex = 25;
            this.labelPassword2.Text = "Password Reapet:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(814, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelUserManagement);
            this.Name = "EditForm";
            this.Text = "EditAddForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUserManagement;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxURLImage;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label labelPassword2;
    }
}