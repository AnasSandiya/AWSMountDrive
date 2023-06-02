namespace AWSMountDrive.Forms
{
    partial class Dashboard
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
            this.lblbucketname = new System.Windows.Forms.Label();
            this.lblaccesskey = new System.Windows.Forms.Label();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBucket = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbucketname
            // 
            this.lblbucketname.AutoSize = true;
            this.lblbucketname.Location = new System.Drawing.Point(12, 345);
            this.lblbucketname.Name = "lblbucketname";
            this.lblbucketname.Size = new System.Drawing.Size(78, 15);
            this.lblbucketname.TabIndex = 0;
            this.lblbucketname.Text = "Bucket Name";
            this.lblbucketname.Visible = false;
            // 
            // lblaccesskey
            // 
            this.lblaccesskey.AutoSize = true;
            this.lblaccesskey.Location = new System.Drawing.Point(25, 386);
            this.lblaccesskey.Name = "lblaccesskey";
            this.lblaccesskey.Size = new System.Drawing.Size(65, 15);
            this.lblaccesskey.TabIndex = 1;
            this.lblaccesskey.Text = "Access Key";
            this.lblaccesskey.Visible = false;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(29, 426);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(61, 15);
            this.lblSecretKey.TabIndex = 2;
            this.lblSecretKey.Text = "Secret Key";
            this.lblSecretKey.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(115, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "AWS S3 Mount";
            // 
            // txtBucket
            // 
            this.txtBucket.Location = new System.Drawing.Point(117, 341);
            this.txtBucket.Name = "txtBucket";
            this.txtBucket.Size = new System.Drawing.Size(260, 23);
            this.txtBucket.TabIndex = 4;
            this.txtBucket.Text = "mybuckettest123999";
            this.txtBucket.Visible = false;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(117, 422);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(260, 23);
            this.txtSecretKey.TabIndex = 5;
            this.txtSecretKey.Text = "ntdPa4ItKUUEb68gJHmXfL6cBhxyTiZf2WVf7q14";
            this.txtSecretKey.Visible = false;
            // 
            // txtAccess
            // 
            this.txtAccess.Location = new System.Drawing.Point(117, 382);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(260, 23);
            this.txtAccess.TabIndex = 6;
            this.txtAccess.Text = "AKIA2XGB3RLR4YQX4T7M";
            this.txtAccess.Visible = false;
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInitialize.Location = new System.Drawing.Point(12, 44);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(378, 43);
            this.btnInitialize.TabIndex = 7;
            this.btnInitialize.Text = "Connect S3";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(12, 186);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(378, 43);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Folder";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(402, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(12, 125);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(378, 23);
            this.txtpath.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Folder name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.txtAccess);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.txtBucket);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSecretKey);
            this.Controls.Add(this.lblaccesskey);
            this.Controls.Add(this.lblbucketname);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblbucketname;
        private Label lblaccesskey;
        private Label lblSecretKey;
        private Label lblTitle;
        private TextBox txtBucket;
        private TextBox txtSecretKey;
        private TextBox txtAccess;
        private Button btnInitialize;
        private Button btnCreate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblStatus;
        private TextBox txtpath;
        private Label label1;
    }
}