namespace ChatProgram
{
    partial class Form1
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
            this.connectButton1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hostnameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.portTextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton1
            // 
            this.connectButton1.Location = new System.Drawing.Point(195, 106);
            this.connectButton1.Name = "connectButton1";
            this.connectButton1.Size = new System.Drawing.Size(75, 23);
            this.connectButton1.TabIndex = 0;
            this.connectButton1.Text = "Connect";
            this.connectButton1.UseVisualStyleBackColor = true;
            this.connectButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 54);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(55, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Nickname";
            // 
            // hostnameTextBox1
            // 
            this.hostnameTextBox1.Location = new System.Drawing.Point(12, 25);
            this.hostnameTextBox1.Name = "hostnameTextBox1";
            this.hostnameTextBox1.Size = new System.Drawing.Size(177, 20);
            this.hostnameTextBox1.TabIndex = 5;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(73, 51);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(116, 20);
            this.nameTextBox2.TabIndex = 6;
            // 
            // portTextBox3
            // 
            this.portTextBox3.Location = new System.Drawing.Point(195, 25);
            this.portTextBox3.Name = "portTextBox3";
            this.portTextBox3.Size = new System.Drawing.Size(75, 20);
            this.portTextBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hostname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "TCPServer",
            "P2P",
            "Test"});
            this.checkedListBox1.Location = new System.Drawing.Point(195, 51);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(75, 49);
            this.checkedListBox1.TabIndex = 10;
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(12, 106);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(75, 23);
            this.listenButton.TabIndex = 11;
            this.listenButton.Text = "Listen(P2P)";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 136);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox3);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.hostnameTextBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectButton1);
            this.Name = "Form1";
            this.Text = "ChatProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox hostnameTextBox1;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.TextBox portTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button listenButton;
    }
}

