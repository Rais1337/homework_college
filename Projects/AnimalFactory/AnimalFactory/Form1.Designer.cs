namespace AnimalFactory
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
            factoryComboBox = new ComboBox();
            createAnimalsButton = new Button();
            mammalLabel = new Label();
            birdLabel = new Label();
            reptileLabel = new Label();
            SuspendLayout();
            // 
            // factoryComboBox
            // 
            factoryComboBox.FormattingEnabled = true;
            factoryComboBox.Items.AddRange(new object[] { "Савана", "Джунглі", "Пустеля" });
            factoryComboBox.Location = new Point(37, 13);
            factoryComboBox.Name = "factoryComboBox";
            factoryComboBox.Size = new Size(121, 23);
            factoryComboBox.TabIndex = 0;
            factoryComboBox.SelectedIndexChanged += factoryComboBox_SelectedIndexChanged;
            // 
            // createAnimalsButton
            // 
            createAnimalsButton.Location = new Point(242, 12);
            createAnimalsButton.Name = "createAnimalsButton";
            createAnimalsButton.Size = new Size(121, 23);
            createAnimalsButton.TabIndex = 1;
            createAnimalsButton.Text = "Створити тварин";
            createAnimalsButton.UseVisualStyleBackColor = true;
            createAnimalsButton.Click += createAnimalsButton_Click;
            // 
            // mammalLabel
            // 
            mammalLabel.AutoSize = true;
            mammalLabel.Location = new Point(212, 115);
            mammalLabel.Name = "mammalLabel";
            mammalLabel.Size = new Size(43, 15);
            mammalLabel.TabIndex = 2;
            mammalLabel.Text = "Ссавці";
            // 
            // birdLabel
            // 
            birdLabel.AutoSize = true;
            birdLabel.Location = new Point(54, 231);
            birdLabel.Name = "birdLabel";
            birdLabel.Size = new Size(40, 15);
            birdLabel.TabIndex = 3;
            birdLabel.Text = "Птахи";
            // 
            // reptileLabel
            // 
            reptileLabel.AutoSize = true;
            reptileLabel.Location = new Point(212, 344);
            reptileLabel.Name = "reptileLabel";
            reptileLabel.Size = new Size(52, 15);
            reptileLabel.TabIndex = 4;
            reptileLabel.Text = "Рептилії";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(reptileLabel);
            Controls.Add(birdLabel);
            Controls.Add(mammalLabel);
            Controls.Add(createAnimalsButton);
            Controls.Add(factoryComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox factoryComboBox;
        private Button createAnimalsButton;
        private Label mammalLabel;
        private Label birdLabel;
        private Label reptileLabel;
    }
}
