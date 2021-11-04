
namespace SW_Projekt
{
    partial class chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.Text_chat = new System.Windows.Forms.TextBox();
            this.but_senden = new System.Windows.Forms.Button();
            this.chatbox = new System.Windows.Forms.ListBox();
            this.but_ver = new System.Windows.Forms.Button();
            this.lab_user = new System.Windows.Forms.Label();
            this.list_user = new System.Windows.Forms.ListBox();
            this.but_akt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_status = new System.Windows.Forms.Label();
            this.but_auswahl = new System.Windows.Forms.Button();
            this.lab_auswahl = new System.Windows.Forms.Label();
            this.dateien = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Text_chat
            // 
            this.Text_chat.BackColor = System.Drawing.Color.White;
            this.Text_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_chat.Enabled = false;
            this.Text_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Text_chat.ForeColor = System.Drawing.Color.DarkGray;
            this.Text_chat.Location = new System.Drawing.Point(22, 259);
            this.Text_chat.Name = "Text_chat";
            this.Text_chat.Size = new System.Drawing.Size(247, 29);
            this.Text_chat.TabIndex = 0;
            this.Text_chat.Text = "Nachricht";
            this.Text_chat.Enter += new System.EventHandler(this.Text_chat_Enter);
            this.Text_chat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_chat_KeyDown);
            this.Text_chat.Leave += new System.EventHandler(this.Text_chat_Leave);
            // 
            // but_senden
            // 
            this.but_senden.Enabled = false;
            this.but_senden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_senden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_senden.ForeColor = System.Drawing.Color.White;
            this.but_senden.Location = new System.Drawing.Point(302, 248);
            this.but_senden.Name = "but_senden";
            this.but_senden.Size = new System.Drawing.Size(111, 45);
            this.but_senden.TabIndex = 1;
            this.but_senden.Text = "Senden";
            this.but_senden.UseVisualStyleBackColor = true;
            this.but_senden.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatbox
            // 
            this.chatbox.Enabled = false;
            this.chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chatbox.FormattingEnabled = true;
            this.chatbox.HorizontalScrollbar = true;
            this.chatbox.ItemHeight = 16;
            this.chatbox.Location = new System.Drawing.Point(22, 45);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(247, 164);
            this.chatbox.TabIndex = 3;
            // 
            // but_ver
            // 
            this.but_ver.Enabled = false;
            this.but_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.but_ver.ForeColor = System.Drawing.Color.White;
            this.but_ver.Location = new System.Drawing.Point(22, 215);
            this.but_ver.Name = "but_ver";
            this.but_ver.Size = new System.Drawing.Size(247, 29);
            this.but_ver.TabIndex = 4;
            this.but_ver.Text = "Verlauf löschen";
            this.but_ver.UseVisualStyleBackColor = true;
            this.but_ver.Click += new System.EventHandler(this.but_ver_Click);
            // 
            // lab_user
            // 
            this.lab_user.AutoSize = true;
            this.lab_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lab_user.ForeColor = System.Drawing.Color.White;
            this.lab_user.Location = new System.Drawing.Point(481, 10);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(145, 24);
            this.lab_user.TabIndex = 5;
            this.lab_user.Text = "Aktive Benutzer:";
            // 
            // list_user
            // 
            this.list_user.BackColor = System.Drawing.Color.White;
            this.list_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.list_user.FormattingEnabled = true;
            this.list_user.ItemHeight = 24;
            this.list_user.Location = new System.Drawing.Point(485, 45);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(141, 170);
            this.list_user.TabIndex = 7;
            // 
            // but_akt
            // 
            this.but_akt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_akt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_akt.ForeColor = System.Drawing.Color.White;
            this.but_akt.Location = new System.Drawing.Point(485, 221);
            this.but_akt.Name = "but_akt";
            this.but_akt.Size = new System.Drawing.Size(141, 33);
            this.but_akt.TabIndex = 8;
            this.but_akt.Text = "Aktualisieren";
            this.but_akt.UseVisualStyleBackColor = true;
            this.but_akt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(446, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 280);
            this.label1.TabIndex = 9;
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_status.ForeColor = System.Drawing.Color.White;
            this.lab_status.Location = new System.Drawing.Point(23, 13);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(246, 20);
            this.lab_status.TabIndex = 10;
            this.lab_status.Text = "Online aber kein Chat ausgewählt";
            // 
            // but_auswahl
            // 
            this.but_auswahl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_auswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_auswahl.ForeColor = System.Drawing.Color.White;
            this.but_auswahl.Location = new System.Drawing.Point(485, 260);
            this.but_auswahl.Name = "but_auswahl";
            this.but_auswahl.Size = new System.Drawing.Size(141, 33);
            this.but_auswahl.TabIndex = 11;
            this.but_auswahl.Text = "Auswählen";
            this.but_auswahl.UseVisualStyleBackColor = true;
            this.but_auswahl.Click += new System.EventHandler(this.but_auswahl_Click);
            // 
            // lab_auswahl
            // 
            this.lab_auswahl.AutoSize = true;
            this.lab_auswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_auswahl.Location = new System.Drawing.Point(91, 13);
            this.lab_auswahl.Name = "lab_auswahl";
            this.lab_auswahl.Size = new System.Drawing.Size(0, 20);
            this.lab_auswahl.TabIndex = 12;
            // 
            // dateien
            // 
            this.dateien.Enabled = false;
            this.dateien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateien.ForeColor = System.Drawing.Color.White;
            this.dateien.Location = new System.Drawing.Point(302, 110);
            this.dateien.Name = "dateien";
            this.dateien.Size = new System.Drawing.Size(111, 45);
            this.dateien.TabIndex = 13;
            this.dateien.Text = "Dateien";
            this.dateien.UseVisualStyleBackColor = true;
            this.dateien.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(657, 312);
            this.Controls.Add(this.dateien);
            this.Controls.Add(this.lab_auswahl);
            this.Controls.Add(this.but_auswahl);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_akt);
            this.Controls.Add(this.list_user);
            this.Controls.Add(this.lab_user);
            this.Controls.Add(this.but_ver);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.but_senden);
            this.Controls.Add(this.Text_chat);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chat_FormClosing);
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_chat;
        private System.Windows.Forms.Button but_senden;
        private System.Windows.Forms.ListBox chatbox;
        private System.Windows.Forms.Button but_ver;
        private System.Windows.Forms.Label lab_user;
        private System.Windows.Forms.ListBox list_user;
        private System.Windows.Forms.Button but_akt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.Button but_auswahl;
        private System.Windows.Forms.Label lab_auswahl;
        private System.Windows.Forms.Button dateien;
        private System.Windows.Forms.OpenFileDialog file1;
    }
}