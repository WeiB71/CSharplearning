namespace CSharplearning
{
    partial class MainForm
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
            btnManageBooks = new Button();
            btnAddBook = new Button();
            btnManageUsers = new Button();
            btnVIewUserForm = new Button();
            SuspendLayout();
            // 
            // btnManageBooks
            // 
            btnManageBooks.Location = new Point(45, 30);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(168, 107);
            btnManageBooks.TabIndex = 0;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.UseVisualStyleBackColor = true;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(45, 184);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(137, 107);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add New Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += button2_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(270, 31);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(170, 106);
            btnManageUsers.TabIndex = 2;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnVIewUserForm
            // 
            btnVIewUserForm.Location = new Point(270, 184);
            btnVIewUserForm.Name = "btnVIewUserForm";
            btnVIewUserForm.Size = new Size(170, 107);
            btnVIewUserForm.TabIndex = 3;
            btnVIewUserForm.Text = "View User Form";
            btnVIewUserForm.UseVisualStyleBackColor = true;
            btnVIewUserForm.Click += btnVIewUserForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVIewUserForm);
            Controls.Add(btnManageUsers);
            Controls.Add(btnAddBook);
            Controls.Add(btnManageBooks);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageBooks;
        private Button btnAddBook;
        private Button btnManageUsers;
        private Button btnVIewUserForm;
    }
}