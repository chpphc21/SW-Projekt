﻿
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
            this.text_anm = new System.Windows.Forms.TextBox();
            this.text_reg = new System.Windows.Forms.TextBox();
            this.lab_anm = new System.Windows.Forms.Label();
            this.lab_reg = new System.Windows.Forms.Label();
            this.but_anm = new System.Windows.Forms.Button();
            this.but_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.farbe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_anm
            // 
            this.text_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_anm.Location = new System.Drawing.Point(19, 89);
            this.text_anm.Name = "text_anm";
            this.text_anm.Size = new System.Drawing.Size(174, 32);
            this.text_anm.TabIndex = 1;
            this.text_anm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_anm_KeyDown);
            // 
            // text_reg
            // 
            this.text_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_reg.Location = new System.Drawing.Point(269, 89);
            this.text_reg.Name = "text_reg";
            this.text_reg.Size = new System.Drawing.Size(174, 32);
            this.text_reg.TabIndex = 2;
            this.text_reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_reg_KeyDown);
            // 
            // lab_anm
            // 
            this.lab_anm.AutoSize = true;
            this.lab_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_anm.Location = new System.Drawing.Point(52, 45);
            this.lab_anm.Name = "lab_anm";
            this.lab_anm.Size = new System.Drawing.Size(111, 26);
            this.lab_anm.TabIndex = 3;
            this.lab_anm.Text = "Anmelden";
            // 
            // lab_reg
            // 
            this.lab_reg.AutoSize = true;
            this.lab_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_reg.Location = new System.Drawing.Point(292, 45);
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
            this.but_anm.Location = new System.Drawing.Point(35, 145);
            this.but_anm.Name = "but_anm";
            this.but_anm.Size = new System.Drawing.Size(128, 39);
            this.but_anm.TabIndex = 5;
            this.but_anm.Text = "Anmelden";
            this.but_anm.UseVisualStyleBackColor = true;
            this.but_anm.Click += new System.EventHandler(this.but_anm_Click);
            // 
            // but_reg
            // 
            this.but_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_reg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_reg.Location = new System.Drawing.Point(282, 145);
            this.but_reg.Name = "but_reg";
            this.but_reg.Size = new System.Drawing.Size(150, 39);
            this.but_reg.TabIndex = 6;
            this.but_reg.Text = "Registrieren";
            this.but_reg.UseVisualStyleBackColor = true;
            this.but_reg.Click += new System.EventHandler(this.but_reg_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(230, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 180);
            this.label1.TabIndex = 10;
            // 
            // farbe
            // 
            this.farbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.farbe.Location = new System.Drawing.Point(1, 0);
            this.farbe.Name = "farbe";
            this.farbe.Size = new System.Drawing.Size(463, 5);
            this.farbe.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(184, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Verbunden";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.farbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_reg);
            this.Controls.Add(this.but_anm);
            this.Controls.Add(this.lab_reg);
            this.Controls.Add(this.lab_anm);
            this.Controls.Add(this.text_reg);
            this.Controls.Add(this.text_anm);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_anm;
        private System.Windows.Forms.TextBox text_reg;
        private System.Windows.Forms.Label lab_anm;
        private System.Windows.Forms.Label lab_reg;
        private System.Windows.Forms.Button but_anm;
        private System.Windows.Forms.Button but_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label farbe;
        private System.Windows.Forms.Label label2;
    }
}

