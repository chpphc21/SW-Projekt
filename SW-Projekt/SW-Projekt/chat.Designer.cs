
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
            this.Text_chat = new System.Windows.Forms.TextBox();
            this.but_senden = new System.Windows.Forms.Button();
            this.chatbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Text_chat
            // 
            this.Text_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Text_chat.ForeColor = System.Drawing.Color.Silver;
            this.Text_chat.Location = new System.Drawing.Point(51, 223);
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
            this.but_senden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_senden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.but_senden.Location = new System.Drawing.Point(331, 215);
            this.but_senden.Name = "but_senden";
            this.but_senden.Size = new System.Drawing.Size(111, 45);
            this.but_senden.TabIndex = 1;
            this.but_senden.Text = "Senden";
            this.but_senden.UseVisualStyleBackColor = true;
            this.but_senden.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatbox
            // 
            this.chatbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chatbox.FormattingEnabled = true;
            this.chatbox.ItemHeight = 16;
            this.chatbox.Location = new System.Drawing.Point(51, 39);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(247, 164);
            this.chatbox.TabIndex = 3;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(537, 283);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.but_senden);
            this.Controls.Add(this.Text_chat);
            this.MaximizeBox = false;
            this.Name = "chat";
            this.ShowIcon = false;
            this.Text = "Chat - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_chat;
        private System.Windows.Forms.Button but_senden;
        private System.Windows.Forms.ListBox chatbox;
    }
}