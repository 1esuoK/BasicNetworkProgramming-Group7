namespace Week6
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
            this.btGet = new System.Windows.Forms.Button();
            this.tbTDL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.Location = new System.Drawing.Point(30, 37);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(124, 52);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "GET";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbTDL
            // 
            this.tbTDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTDL.Location = new System.Drawing.Point(186, 37);
            this.tbTDL.Multiline = true;
            this.tbTDL.Name = "tbTDL";
            this.tbTDL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTDL.Size = new System.Drawing.Size(582, 378);
            this.tbTDL.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTDL);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbTDL;
    }
}

