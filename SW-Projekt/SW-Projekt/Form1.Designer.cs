
namespace SW_Projekt
{
    partial class form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.verbinden = new System.Windows.Forms.Button();
            this.text_anm = new System.Windows.Forms.TextBox();
            this.text_reg = new System.Windows.Forms.TextBox();
            this.lab_anm = new System.Windows.Forms.Label();
            this.lab_reg = new System.Windows.Forms.Label();
            this.but_anm = new System.Windows.Forms.Button();
            this.but_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verbinden
            // 
            this.verbinden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbinden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.verbinden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verbinden.Location = new System.Drawing.Point(183, 229);
            this.verbinden.Name = "verbinden";
            this.verbinden.Size = new System.Drawing.Size(158, 64);
            this.verbinden.TabIndex = 0;
            this.verbinden.Text = "Verbinden";
            this.verbinden.UseVisualStyleBackColor = true;
            // 
            // text_anm
            // 
            this.text_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_anm.Location = new System.Drawing.Point(22, 77);
            this.text_anm.Name = "text_anm";
            this.text_anm.Size = new System.Drawing.Size(174, 32);
            this.text_anm.TabIndex = 1;
            // 
            // text_reg
            // 
            this.text_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_reg.Location = new System.Drawing.Point(334, 77);
            this.text_reg.Name = "text_reg";
            this.text_reg.Size = new System.Drawing.Size(174, 32);
            this.text_reg.TabIndex = 2;
            // 
            // lab_anm
            // 
            this.lab_anm.AutoSize = true;
            this.lab_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_anm.Location = new System.Drawing.Point(55, 33);
            this.lab_anm.Name = "lab_anm";
            this.lab_anm.Size = new System.Drawing.Size(111, 26);
            this.lab_anm.TabIndex = 3;
            this.lab_anm.Text = "Anmelden";
            // 
            // lab_reg
            // 
            this.lab_reg.AutoSize = true;
            this.lab_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_reg.Location = new System.Drawing.Point(357, 33);
            this.lab_reg.Name = "lab_reg";
            this.lab_reg.Size = new System.Drawing.Size(129, 26);
            this.lab_reg.TabIndex = 4;
            this.lab_reg.Text = "Registrieren";
            // 
            // but_anm
            // 
            this.but_anm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_anm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_anm.Location = new System.Drawing.Point(38, 133);
            this.but_anm.Name = "but_anm";
            this.but_anm.Size = new System.Drawing.Size(128, 39);
            this.but_anm.TabIndex = 5;
            this.but_anm.Text = "Anmelden";
            this.but_anm.UseVisualStyleBackColor = true;
            // 
            // but_reg
            // 
            this.but_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_reg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_reg.Location = new System.Drawing.Point(347, 133);
            this.but_reg.Name = "but_reg";
            this.but_reg.Size = new System.Drawing.Size(150, 39);
            this.but_reg.TabIndex = 6;
            this.but_reg.Text = "Registrieren";
            this.but_reg.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(538, 305);
            this.Controls.Add(this.but_reg);
            this.Controls.Add(this.but_anm);
            this.Controls.Add(this.lab_reg);
            this.Controls.Add(this.lab_anm);
            this.Controls.Add(this.text_reg);
            this.Controls.Add(this.text_anm);
            this.Controls.Add(this.verbinden);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verbinden;
        private System.Windows.Forms.TextBox text_anm;
        private System.Windows.Forms.TextBox text_reg;
        private System.Windows.Forms.Label lab_anm;
        private System.Windows.Forms.Label lab_reg;
        private System.Windows.Forms.Button but_anm;
        private System.Windows.Forms.Button but_reg;
    }
}

