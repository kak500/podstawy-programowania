namespace winforms2
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
            this.liczba1 = new System.Windows.Forms.TextBox();
            this.liczba2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.output1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liczba1
            // 
            this.liczba1.Location = new System.Drawing.Point(357, 188);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(100, 20);
            this.liczba1.TabIndex = 0;
            // 
            // liczba2
            // 
            this.liczba2.Location = new System.Drawing.Point(357, 162);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(100, 20);
            this.liczba2.TabIndex = 0;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(422, 260);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(240, 185);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "button1";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Enabled = false;
            this.output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output1.Location = new System.Drawing.Point(387, 235);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(70, 25);
            this.output1.TabIndex = 4;
            this.output1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox liczba1;
        private System.Windows.Forms.TextBox liczba2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label output1;
    }
}

