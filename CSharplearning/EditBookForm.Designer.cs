namespace CSharplearning
{
    partial class EditBookForm
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
            btnSave = new Button();
            dtpDatepublished = new DateTimePicker();
            lblDatepublished = new Label();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(333, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Update";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpDatepublished
            // 
            dtpDatepublished.Location = new Point(333, 249);
            dtpDatepublished.Name = "dtpDatepublished";
            dtpDatepublished.Size = new Size(250, 27);
            dtpDatepublished.TabIndex = 16;
            // 
            // lblDatepublished
            // 
            lblDatepublished.AutoSize = true;
            lblDatepublished.Location = new Point(218, 254);
            lblDatepublished.Name = "lblDatepublished";
            lblDatepublished.Size = new Size(109, 20);
            lblDatepublished.TabIndex = 15;
            lblDatepublished.Text = "Date Published";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(273, 213);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 14;
            lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(333, 213);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(221, 27);
            txtAuthor.TabIndex = 13;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(242, 178);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(333, 173);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(221, 34);
            txtDescription.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(289, 143);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(333, 140);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(221, 27);
            txtTitle.TabIndex = 9;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dtpDatepublished);
            Controls.Add(lblDatepublished);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Name = "EditBookForm";
            Text = "Edit Book Form";
            Load += EditBookForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DateTimePicker dtpDatepublished;
        private Label lblDatepublished;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblTitle;
        private TextBox txtTitle;
    }
}