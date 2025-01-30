namespace EBookProxyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrevPage = new Button();
            btnSearch = new Button();
            btnNextPage = new Button();
            txtSearch = new TextBox();
            txtPageContent = new TextBox();
            SuspendLayout();
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(98, 209);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(110, 23);
            btnPrevPage.TabIndex = 0;
            btnPrevPage.Text = "Предыдущая";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(235, 209);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(341, 209);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(103, 23);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Следующая";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(98, 249);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(346, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPageContent
            // 
            txtPageContent.Location = new Point(98, 29);
            txtPageContent.Multiline = true;
            txtPageContent.Name = "txtPageContent";
            txtPageContent.ReadOnly = true;
            txtPageContent.ScrollBars = ScrollBars.Vertical;
            txtPageContent.Size = new Size(346, 158);
            txtPageContent.TabIndex = 4;
            txtPageContent.TextChanged += txtPageContent_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 315);
            Controls.Add(txtPageContent);
            Controls.Add(txtSearch);
            Controls.Add(btnNextPage);
            Controls.Add(btnSearch);
            Controls.Add(btnPrevPage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevPage;
        private Button btnSearch;
        private Button btnNextPage;
        private TextBox txtSearch;
        private TextBox txtPageContent;
    }
}
