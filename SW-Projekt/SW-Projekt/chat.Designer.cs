
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
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_chat
            // 
            this.Text_chat.BackColor = System.Drawing.Color.White;
            this.Text_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_chat.Enabled = false;
            this.Text_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Text_chat.ForeColor = System.Drawing.Color.DarkGray;
            this.Text_chat.Location = new System.Drawing.Point(23, 333);
            this.Text_chat.Name = "Text_chat";
            this.Text_chat.Size = new System.Drawing.Size(437, 32);
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
            this.but_senden.Location = new System.Drawing.Point(245, 371);
            this.but_senden.Name = "but_senden";
            this.but_senden.Size = new System.Drawing.Size(215, 35);
            this.but_senden.TabIndex = 1;
            this.but_senden.Text = "Senden";
            this.but_senden.UseVisualStyleBackColor = true;
            this.but_senden.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatbox
            // 
            this.chatbox.Enabled = false;
            this.chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatbox.FormattingEnabled = true;
            this.chatbox.HorizontalScrollbar = true;
            this.chatbox.ItemHeight = 20;
            this.chatbox.Location = new System.Drawing.Point(23, 73);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(437, 264);
            this.chatbox.TabIndex = 3;
            // 
            // but_ver
            // 
            this.but_ver.Enabled = false;
            this.but_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_ver.ForeColor = System.Drawing.Color.White;
            this.but_ver.Location = new System.Drawing.Point(23, 371);
            this.but_ver.Name = "but_ver";
            this.but_ver.Size = new System.Drawing.Size(216, 35);
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
            this.lab_user.Location = new System.Drawing.Point(517, 53);
            this.lab_user.Name = "lab_user";
            this.lab_user.Size = new System.Drawing.Size(145, 24);
            this.lab_user.TabIndex = 5;
            this.lab_user.Text = "Aktive Benutzer:";
            // 
            // list_user
            // 
            this.list_user.BackColor = System.Drawing.Color.White;
            this.list_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.list_user.FormattingEnabled = true;
            this.list_user.ItemHeight = 29;
            this.list_user.Location = new System.Drawing.Point(514, 88);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(169, 234);
            this.list_user.TabIndex = 7;
            this.list_user.DoubleClick += new System.EventHandler(this.list_user_DoubleClick);
            // 
            // but_akt
            // 
            this.but_akt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_akt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.but_akt.ForeColor = System.Drawing.Color.White;
            this.but_akt.Location = new System.Drawing.Point(514, 331);
            this.but_akt.Name = "but_akt";
            this.but_akt.Size = new System.Drawing.Size(169, 34);
            this.but_akt.TabIndex = 8;
            this.but_akt.Text = "Aktualisieren";
            this.but_akt.UseVisualStyleBackColor = true;
            this.but_akt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(482, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 375);
            this.label1.TabIndex = 9;
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_status.ForeColor = System.Drawing.Color.White;
            this.lab_status.Location = new System.Drawing.Point(24, 41);
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
            this.but_auswahl.Location = new System.Drawing.Point(514, 372);
            this.but_auswahl.Name = "but_auswahl";
            this.but_auswahl.Size = new System.Drawing.Size(169, 34);
            this.but_auswahl.TabIndex = 11;
            this.but_auswahl.Text = "Auswählen";
            this.but_auswahl.UseVisualStyleBackColor = true;
            this.but_auswahl.Click += new System.EventHandler(this.but_auswahl_Click);
            // 
            // lab_auswahl
            // 
            this.lab_auswahl.AutoSize = true;
            this.lab_auswahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_auswahl.Location = new System.Drawing.Point(92, 41);
            this.lab_auswahl.Name = "lab_auswahl";
            this.lab_auswahl.Size = new System.Drawing.Size(0, 20);
            this.lab_auswahl.TabIndex = 12;
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateienToolStripMenuItem
            // 
            this.dateienToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dateienToolStripMenuItem.Name = "dateienToolStripMenuItem";
            this.dateienToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dateienToolStripMenuItem.Text = "Dateien";
            this.dateienToolStripMenuItem.Click += new System.EventHandler(this.dateienToolStripMenuItem_Click);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(703, 419);
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
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chat_FormClosing);
            this.Load += new System.EventHandler(this.chat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateienToolStripMenuItem;
    }
}