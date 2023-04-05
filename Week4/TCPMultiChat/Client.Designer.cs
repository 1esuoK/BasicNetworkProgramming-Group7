namespace TCPMultiChat
{
    partial class Client
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
            this.lstMess = new System.Windows.Forms.ListBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMess
            // 
            this.lstMess.FormattingEnabled = true;
            this.lstMess.ItemHeight = 16;
            this.lstMess.Location = new System.Drawing.Point(5, 146);
            this.lstMess.Name = "lstMess";
            this.lstMess.Size = new System.Drawing.Size(878, 292);
            this.lstMess.TabIndex = 21;
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(5, 76);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(139, 38);
            this.clrBtn.TabIndex = 20;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(674, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(209, 38);
            this.txtPort.TabIndex = 19;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(594, 10);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(74, 32);
            this.portLabel.TabIndex = 18;
            this.portLabel.Text = "Port:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(196, 80);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(108, 32);
            this.userLabel.TabIndex = 17;
            this.userLabel.Text = "UserID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(352, 77);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(209, 38);
            this.txtUserID.TabIndex = 16;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(196, 11);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(126, 32);
            this.addressLabel.TabIndex = 15;
            this.addressLabel.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(352, 7);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 38);
            this.txtAddress.TabIndex = 14;
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(5, 7);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(139, 38);
            this.connectBtn.TabIndex = 13;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(744, 464);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(139, 38);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(5, 464);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(704, 38);
            this.txtSend.TabIndex = 11;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 508);
            this.Controls.Add(this.lstMess);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtSend);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMess;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox txtSend;
    }
}