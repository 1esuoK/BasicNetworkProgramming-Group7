namespace TCPChatServerClients
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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.lstMess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(67, 487);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(704, 38);
            this.txtSend.TabIndex = 0;
            
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(806, 487);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(139, 38);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(67, 30);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(139, 38);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(414, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 38);
            this.txtAddress.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(258, 34);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(126, 32);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(414, 100);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(209, 38);
            this.txtUserID.TabIndex = 5;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(258, 103);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(108, 32);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "UserID:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(656, 33);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(74, 32);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(736, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(209, 38);
            this.txtPort.TabIndex = 8;
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(67, 99);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(139, 38);
            this.clrBtn.TabIndex = 9;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            // 
            // lstMess
            // 
            this.lstMess.FormattingEnabled = true;
            this.lstMess.ItemHeight = 16;
            this.lstMess.Location = new System.Drawing.Point(67, 169);
            this.lstMess.Name = "lstMess";
            this.lstMess.Size = new System.Drawing.Size(878, 292);
            this.lstMess.TabIndex = 10;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 569);
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
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ListBox lstMess;
    }
}

