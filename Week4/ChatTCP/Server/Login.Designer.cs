namespace ChatTCP
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.butserver = new System.Windows.Forms.Button();
            this.butclient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(214, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP Chat-app";
            // 
            // butserver
            // 
            this.butserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butserver.ForeColor = System.Drawing.Color.BurlyWood;
            this.butserver.Location = new System.Drawing.Point(77, 172);
            this.butserver.Name = "butserver";
            this.butserver.Size = new System.Drawing.Size(210, 77);
            this.butserver.TabIndex = 1;
            this.butserver.Text = "Server";
            this.butserver.UseVisualStyleBackColor = true;
            this.butserver.Click += new System.EventHandler(this.butserver_Click);
            // 
            // butclient
            // 
            this.butclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclient.ForeColor = System.Drawing.Color.Tan;
            this.butclient.Location = new System.Drawing.Point(425, 172);
            this.butclient.Name = "butclient";
            this.butclient.Size = new System.Drawing.Size(223, 77);
            this.butclient.TabIndex = 2;
            this.butclient.Text = "Client";
            this.butclient.UseVisualStyleBackColor = true;
            this.butclient.Click += new System.EventHandler(this.butclient_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(723, 327);
            this.Controls.Add(this.butclient);
            this.Controls.Add(this.butserver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butserver;
        private System.Windows.Forms.Button butclient;
    }
}