namespace LaptopBuilder
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
            label1 = new Label();
            txtLaptopConfig = new TextBox();
            SuspendLayout();
            // 
            // comboBoxLaptopType
            // 
            comboBoxLaptopType.FormattingEnabled = true;
            comboBoxLaptopType.Items.AddRange(new object[] { "Gaming", "Business" });
            comboBoxLaptopType.Location = new Point(184, 103);
            comboBoxLaptopType.Name = "comboBoxLaptopType";
            comboBoxLaptopType.Size = new Size(121, 23);
            comboBoxLaptopType.TabIndex = 0;
            comboBoxLaptopType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnBuildLaptop
            // 
            btnBuildLaptop.Location = new Point(478, 102);
            btnBuildLaptop.Name = "btnBuildLaptop";
            btnBuildLaptop.Size = new Size(119, 23);
            btnBuildLaptop.TabIndex = 1;
            btnBuildLaptop.Text = "Build Laptop";
            btnBuildLaptop.UseVisualStyleBackColor = true;
            btnBuildLaptop.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(253, 200);
            label1.Name = "label1";
            label1.Size = new Size(286, 37);
            label1.TabIndex = 2;
            label1.Text = "Laptop Configuration:";
            // 
            // txtLaptopConfig
            // 
            txtLaptopConfig.Location = new Point(253, 257);
            txtLaptopConfig.Multiline = true;
            txtLaptopConfig.Name = "txtLaptopConfig";
            txtLaptopConfig.Size = new Size(277, 70);
            txtLaptopConfig.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLaptopConfig);
            Controls.Add(label1);
            Controls.Add(btnBuildLaptop);
            Controls.Add(comboBoxLaptopType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLaptopType;
        private Button btnBuildLaptop;
        private Label label1;
        private TextBox txtLaptopConfig;
    }
}
