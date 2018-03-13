using System;
using System.Windows.Forms;

namespace ChatProgram
{
    partial class ServerChatForm
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
            this.sendButton1 = new System.Windows.Forms.Button();
            this.msgInputTextBox1 = new System.Windows.Forms.TextBox();
            this.messageTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendButton1
            // 
            this.sendButton1.Location = new System.Drawing.Point(384, 301);
            this.sendButton1.Name = "sendButton1";
            this.sendButton1.Size = new System.Drawing.Size(75, 20);
            this.sendButton1.TabIndex = 1;
            this.sendButton1.Text = "Send";
            this.sendButton1.UseVisualStyleBackColor = true;
            this.sendButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgInputTextBox1
            // 
            this.msgInputTextBox1.Location = new System.Drawing.Point(12, 301);
            this.msgInputTextBox1.Name = "msgInputTextBox1";
            this.msgInputTextBox1.Size = new System.Drawing.Size(366, 20);
            this.msgInputTextBox1.TabIndex = 0;
            // 
            // messageTextBox1
            // 
            this.messageTextBox1.Location = new System.Drawing.Point(12, 12);
            this.messageTextBox1.Name = "messageTextBox1";
            this.messageTextBox1.ReadOnly = true;
            this.messageTextBox1.Size = new System.Drawing.Size(447, 281);
            this.messageTextBox1.TabIndex = 4;
            this.messageTextBox1.Text = "";
            // 
            // ServerChatForm
            // 
            this.AcceptButton = this.sendButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 334);
            this.Controls.Add(this.messageTextBox1);
            this.Controls.Add(this.msgInputTextBox1);
            this.Controls.Add(this.sendButton1);
            this.Name = "ServerChatForm";
            this.Text = "Chat Window";
            this.Load += new System.EventHandler(this.ServerChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton1;
        private System.Windows.Forms.TextBox msgInputTextBox1;
        private System.Windows.Forms.RichTextBox messageTextBox1;
    }
}