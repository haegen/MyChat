namespace MyChat
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIpQuelle = new System.Windows.Forms.TextBox();
            this.tbPortQuelle = new System.Windows.Forms.TextBox();
            this.tbPortZiel = new System.Windows.Forms.TextBox();
            this.tbIpZiel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbChatFenster = new System.Windows.Forms.ListBox();
            this.tbNachricht = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port :";
            // 
            // tbIpQuelle
            // 
            this.tbIpQuelle.Location = new System.Drawing.Point(46, 12);
            this.tbIpQuelle.Name = "tbIpQuelle";
            this.tbIpQuelle.Size = new System.Drawing.Size(126, 20);
            this.tbIpQuelle.TabIndex = 2;
            // 
            // tbPortQuelle
            // 
            this.tbPortQuelle.Location = new System.Drawing.Point(46, 38);
            this.tbPortQuelle.Name = "tbPortQuelle";
            this.tbPortQuelle.Size = new System.Drawing.Size(126, 20);
            this.tbPortQuelle.TabIndex = 3;
            // 
            // tbPortZiel
            // 
            this.tbPortZiel.Location = new System.Drawing.Point(239, 38);
            this.tbPortZiel.Name = "tbPortZiel";
            this.tbPortZiel.Size = new System.Drawing.Size(126, 20);
            this.tbPortZiel.TabIndex = 7;
            // 
            // tbIpZiel
            // 
            this.tbIpZiel.Location = new System.Drawing.Point(239, 12);
            this.tbIpZiel.Name = "tbIpZiel";
            this.tbIpZiel.Size = new System.Drawing.Size(126, 20);
            this.tbIpZiel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(371, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 46);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbChatFenster
            // 
            this.lbChatFenster.FormattingEnabled = true;
            this.lbChatFenster.Location = new System.Drawing.Point(11, 64);
            this.lbChatFenster.Name = "lbChatFenster";
            this.lbChatFenster.Size = new System.Drawing.Size(434, 277);
            this.lbChatFenster.TabIndex = 9;
            // 
            // tbNachricht
            // 
            this.tbNachricht.Location = new System.Drawing.Point(11, 349);
            this.tbNachricht.Name = "tbNachricht";
            this.tbNachricht.Size = new System.Drawing.Size(353, 20);
            this.tbNachricht.TabIndex = 10;
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(370, 347);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 11;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.tbNachricht);
            this.Controls.Add(this.lbChatFenster);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbPortZiel);
            this.Controls.Add(this.tbIpZiel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPortQuelle);
            this.Controls.Add(this.tbIpQuelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIpQuelle;
        private System.Windows.Forms.TextBox tbPortQuelle;
        private System.Windows.Forms.TextBox tbPortZiel;
        private System.Windows.Forms.TextBox tbIpZiel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbChatFenster;
        private System.Windows.Forms.TextBox tbNachricht;
        private System.Windows.Forms.Button btnSenden;
    }
}

