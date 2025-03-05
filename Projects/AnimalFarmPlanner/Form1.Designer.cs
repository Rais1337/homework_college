namespace AnimalFarmPlanner
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
            this.cmbAnimals = new System.Windows.Forms.ComboBox();
            this.btnPlan = new System.Windows.Forms.Button();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbAnimals
            // 
            this.cmbAnimals.FormattingEnabled = true;
            this.cmbAnimals.Location = new System.Drawing.Point(192, 170);
            this.cmbAnimals.Name = "cmbAnimals";
            this.cmbAnimals.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimals.TabIndex = 0;
            this.cmbAnimals.SelectedIndexChanged += new System.EventHandler(this.cmbAnimals_SelectedIndexChanged);
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(192, 235);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(121, 23);
            this.btnPlan.TabIndex = 1;
            this.btnPlan.Text = "Сформувати план";
            this.btnPlan.UseVisualStyleBackColor = true;
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(123, 111);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.ReadOnly = true;
            this.txtPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlan.Size = new System.Drawing.Size(267, 20);
            this.txtPlan.TabIndex = 2;
            this.txtPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 359);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.cmbAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnimals;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.TextBox txtPlan;
    }
}

