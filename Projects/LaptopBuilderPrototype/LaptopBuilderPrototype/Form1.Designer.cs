namespace LaptopBuilderPrototype
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
            comboBoxLaptopType = new ComboBox();
            btnBuildLaptop = new Button();
            btnCloneLaptop = new Button();
            txtLaptopConfig = new TextBox();
            SuspendLayout();
            // 
            // comboBoxLaptopType
            // 
            comboBoxLaptopType.FormattingEnabled = true;
            comboBoxLaptopType.Items.AddRange(new object[] { "Gaming", "Business" });
            comboBoxLaptopType.Location = new Point(291, 138);
            comboBoxLaptopType.Name = "comboBoxLaptopType";
            comboBoxLaptopType.Size = new Size(180, 23);
            comboBoxLaptopType.TabIndex = 0;
            // 
            // btnBuildLaptop
            // 
            btnBuildLaptop.Location = new Point(185, 207);
            btnBuildLaptop.Name = "btnBuildLaptop";
            btnBuildLaptop.Size = new Size(125, 23);
            btnBuildLaptop.TabIndex = 1;
            btnBuildLaptop.Text = "Build Laptop";
            btnBuildLaptop.UseVisualStyleBackColor = true;
            btnBuildLaptop.Click += btnBuildLaptop_Click;
            // 
            // btnCloneLaptop
            // 
            btnCloneLaptop.Location = new Point(453, 207);
            btnCloneLaptop.Name = "btnCloneLaptop";
            btnCloneLaptop.Size = new Size(115, 23);
            btnCloneLaptop.TabIndex = 2;
            btnCloneLaptop.Text = "Clone Laptop";
            btnCloneLaptop.UseVisualStyleBackColor = true;
            btnCloneLaptop.Click += btnCloneLaptop_Click;
            // 
            // txtLaptopConfig
            // 
            txtLaptopConfig.Location = new Point(185, 273);
            txtLaptopConfig.Multiline = true;
            txtLaptopConfig.Name = "txtLaptopConfig";
            txtLaptopConfig.ReadOnly = true;
            txtLaptopConfig.Size = new Size(383, 23);
            txtLaptopConfig.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLaptopConfig);
            Controls.Add(btnCloneLaptop);
            Controls.Add(btnBuildLaptop);
            Controls.Add(comboBoxLaptopType);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLaptopType;
        private Button btnBuildLaptop;
        private Button btnCloneLaptop;
        private TextBox txtLaptopConfig;
    }
}
