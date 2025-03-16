namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Location = new System.Drawing.Point(93, 58);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(525, 265);
            this.panelCanvas.TabIndex = 0;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(313, 369);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.panelCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);


        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btnUndo;
    }
}

