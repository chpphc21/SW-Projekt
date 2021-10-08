
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
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
            this.text_anm.Location = new System.Drawing.Point(25, 110);
            this.text_anm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_anm.Name = "text_anm";
            this.text_anm.Size = new System.Drawing.Size(231, 38);
            this.text_anm.TabIndex = 1;
            this.text_anm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_anm_KeyDown);
            // 
            // text_reg
            // 
            this.text_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_reg.Location = new System.Drawing.Point(359, 110);
            this.text_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_reg.Name = "text_reg";
            this.text_reg.Size = new System.Drawing.Size(231, 38);
            this.text_reg.TabIndex = 2;
            this.text_reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_reg_KeyDown);
            // 
            // lab_anm
            // 
            this.lab_anm.AutoSize = true;
            this.lab_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_anm.ForeColor = System.Drawing.Color.White;
            this.lab_anm.Location = new System.Drawing.Point(69, 55);
            this.lab_anm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_anm.Name = "lab_anm";
            this.lab_anm.Size = new System.Drawing.Size(135, 31);
            this.lab_anm.TabIndex = 3;
            this.lab_anm.Text = "Anmelden";
            // 
            // lab_reg
            // 
            this.lab_reg.AutoSize = true;
            this.lab_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab_reg.ForeColor = System.Drawing.Color.White;
            this.lab_reg.Location = new System.Drawing.Point(389, 55);
            this.lab_reg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_reg.Name = "lab_reg";
            this.lab_reg.Size = new System.Drawing.Size(161, 31);
            this.lab_reg.TabIndex = 4;
            this.lab_reg.Text = "Registrieren";
            // 
            // but_anm
            // 
            this.but_anm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_anm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_anm.ForeColor = System.Drawing.Color.White;
            this.but_anm.Location = new System.Drawing.Point(47, 178);
            this.but_anm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_anm.Name = "but_anm";
            this.but_anm.Size = new System.Drawing.Size(171, 48);
            this.but_anm.TabIndex = 5;
            this.but_anm.Text = "Anmelden";
            this.but_anm.UseVisualStyleBackColor = true;
            this.but_anm.Click += new System.EventHandler(this.but_anm_Click);
            // 
            // but_reg
            // 
            this.but_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_reg.ForeColor = System.Drawing.Color.White;
            this.but_reg.Location = new System.Drawing.Point(376, 178);
            this.but_reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_reg.Name = "but_reg";
            this.but_reg.Size = new System.Drawing.Size(200, 48);
            this.but_reg.TabIndex = 6;
            this.but_reg.Text = "Registrieren";
            this.but_reg.UseVisualStyleBackColor = true;
            this.but_reg.Click += new System.EventHandler(this.but_reg_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(307, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 222);
            this.label1.TabIndex = 10;
            // 
            // farbe
            // 
            this.farbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.farbe.Location = new System.Drawing.Point(1, 0);
            this.farbe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.farbe.Name = "farbe";
            this.farbe.Size = new System.Drawing.Size(617, 6);
            this.farbe.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(245, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Verbunden";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(617, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.farbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_reg);
            this.Controls.Add(this.but_anm);
            this.Controls.Add(this.lab_reg);
            this.Controls.Add(this.lab_anm);
            this.Controls.Add(this.text_reg);
            this.Controls.Add(this.text_anm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_anm;
        private System.Windows.Forms.Label lab_reg;
        private System.Windows.Forms.Button but_anm;
        private System.Windows.Forms.Button but_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label farbe;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox text_anm;
        public System.Windows.Forms.TextBox text_reg;
    }
}

