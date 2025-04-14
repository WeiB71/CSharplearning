namespace CSharplearning
{
    partial class AddUserForm
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
            btnAdd = new Button();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRole = new TextBox();
            label4 = new Label();
            dtpCreatedAt = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(335, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(335, 74);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(216, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(335, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 74);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 110);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 143);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(335, 140);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(216, 27);
            txtRole.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 178);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 7;
            label4.Text = "Created At";
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.Location = new Point(335, 178);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(260, 27);
            dtpCreatedAt.TabIndex = 8;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpCreatedAt);
            Controls.Add(label4);
            Controls.Add(txtRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(btnAdd);
            Name = "AddUserForm";
            Text = "AddUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRole;
        private Label label4;
        private DateTimePicker dtpCreatedAt;
    }
}