namespace LoggerApp
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
            textBoxLog = new TextBox();
            buttonFileLogger = new Button();
            buttonConsoleLogger = new Button();
            buttonTextBoxLogger = new Button();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(185, 89);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(412, 23);
            textBoxLog.TabIndex = 4;
            // 
            // buttonFileLogger
            // 
            buttonFileLogger.Location = new Point(185, 161);
            buttonFileLogger.Name = "buttonFileLogger";
            buttonFileLogger.Size = new Size(75, 23);
            buttonFileLogger.TabIndex = 1;
            buttonFileLogger.Text = "button1";
            buttonFileLogger.UseVisualStyleBackColor = true;
            // buttonConsoleLogger
            // 
            buttonConsoleLogger.Location = new Point(354, 161);
            buttonConsoleLogger.Name = "buttonConsoleLogger";
            buttonConsoleLogger.Size = new Size(75, 23);
            buttonConsoleLogger.TabIndex = 2;
            buttonConsoleLogger.Text = "button2";
            buttonConsoleLogger.UseVisualStyleBackColor = true;
            // 
            // buttonTextBoxLogger
            // 
            buttonTextBoxLogger.Location = new Point(522, 161);
            buttonTextBoxLogger.Name = "buttonTextBoxLogger";
            buttonTextBoxLogger.Size = new Size(75, 23);
            buttonTextBoxLogger.TabIndex = 3;
            buttonTextBoxLogger.Text = "button3";
            buttonTextBoxLogger.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTextBoxLogger);
            Controls.Add(buttonConsoleLogger);
            Controls.Add(buttonFileLogger);
            Controls.Add(textBoxLog);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLog;
        private Button buttonFileLogger;
        private Button buttonConsoleLogger;
        private Button buttonTextBoxLogger;
    }
}
