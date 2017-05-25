namespace klient_TCP
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
            this.Info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.Polacz = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.myPort = new System.Windows.Forms.NumericUpDown();
            this.myAdress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_o_polaczeniu
            // 
            this.Info_o_polaczeniu.FormattingEnabled = true;
            this.Info_o_polaczeniu.Location = new System.Drawing.Point(30, 76);
            this.Info_o_polaczeniu.Name = "Info_o_polaczeniu";
            this.Info_o_polaczeniu.Size = new System.Drawing.Size(329, 199);
            this.Info_o_polaczeniu.TabIndex = 0;
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(165, 300);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(75, 23);
            this.Polacz.TabIndex = 3;
            this.Polacz.Text = "Połącz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.Polacz_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(273, 9);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 4;
            this.Port.Text = "Port";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(85, 9);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(37, 13);
            this.Adres.TabIndex = 5;
            this.Adres.Text = "Adres ";
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(225, 31);
            this.myPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(120, 20);
            this.myPort.TabIndex = 7;
            // 
            // myAdress
            // 
            this.myAdress.Location = new System.Drawing.Point(43, 31);
            this.myAdress.Name = "myAdress";
            this.myAdress.Size = new System.Drawing.Size(120, 20);
            this.myAdress.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 349);
            this.Controls.Add(this.myAdress);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Polacz);
            this.Controls.Add(this.Info_o_polaczeniu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Info_o_polaczeniu;
        private System.Windows.Forms.Button Polacz;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.NumericUpDown myPort;
        private System.Windows.Forms.TextBox myAdress;
    }
}

