namespace lab3gitv2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelBeverageVolume = new System.Windows.Forms.Label();
            this.labelPureAlcoholVolume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(15, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyświetl szczegóły";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(88, 21);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(92, 20);
            this.textBoxSize.TabIndex = 1;
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(200, 53);
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(92, 20);
            this.textBoxPercentage.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(134, 90);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(92, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelBeverageVolume
            // 
            this.labelBeverageVolume.AutoSize = true;
            this.labelBeverageVolume.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeverageVolume.Location = new System.Drawing.Point(12, 171);
            this.labelBeverageVolume.Name = "labelBeverageVolume";
            this.labelBeverageVolume.Size = new System.Drawing.Size(0, 15);
            this.labelBeverageVolume.TabIndex = 4;
            // 
            // labelPureAlcoholVolume
            // 
            this.labelPureAlcoholVolume.AutoSize = true;
            this.labelPureAlcoholVolume.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPureAlcoholVolume.Location = new System.Drawing.Point(12, 207);
            this.labelPureAlcoholVolume.Name = "labelPureAlcoholVolume";
            this.labelPureAlcoholVolume.Size = new System.Drawing.Size(0, 15);
            this.labelPureAlcoholVolume.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vessel size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Percentage of spirit in the drink:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity of vessels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPureAlcoholVolume);
            this.Controls.Add(this.labelBeverageVolume);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxPercentage);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelBeverageVolume;
        private System.Windows.Forms.Label labelPureAlcoholVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

