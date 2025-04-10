namespace CSharplearning
{
    partial class AddBookForm
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
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            lblDatepublished = new Label();
            dtpDatepublished = new DateTimePicker();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(251, 97);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(221, 27);
            txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(207, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(251, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(221, 34);
            txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(160, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(251, 170);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(221, 27);
            txtAuthor.TabIndex = 4;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(191, 170);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author";
            // 
            // lblDatepublished
            // 
            lblDatepublished.AutoSize = true;
            lblDatepublished.Location = new Point(136, 211);
            lblDatepublished.Name = "lblDatepublished";
            lblDatepublished.Size = new Size(109, 20);
            lblDatepublished.TabIndex = 6;
            lblDatepublished.Text = "Date Published";
            // 
            // dtpDatepublished
            // 
            dtpDatepublished.Location = new Point(251, 206);
            dtpDatepublished.Name = "dtpDatepublished";
            dtpDatepublished.Size = new Size(250, 27);
            dtpDatepublished.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(251, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 423);
            Controls.Add(btnAdd);
            Controls.Add(dtpDatepublished);
            Controls.Add(lblDatepublished);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Name = "AddBookForm";
            Text = "Add Book Form";
            Load += AddBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Label lblDatepublished;
        private DateTimePicker dtpDatepublished;
        private Button btnAdd;
    }
}