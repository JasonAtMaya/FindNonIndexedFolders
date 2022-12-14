
namespace FindNonIndexedFolders
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnTestQRY = new System.Windows.Forms.Button();
            this.txtQry = new System.Windows.Forms.TextBox();
            this.txtVault = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(675, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(12, 459);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(776, 0);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vault";
            this.label1.Visible = false;
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(15, 157);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(773, 156);
            this.txtResults.TabIndex = 5;
            // 
            // btnTestQRY
            // 
            this.btnTestQRY.Location = new System.Drawing.Point(496, 331);
            this.btnTestQRY.Name = "btnTestQRY";
            this.btnTestQRY.Size = new System.Drawing.Size(136, 31);
            this.btnTestQRY.TabIndex = 6;
            this.btnTestQRY.Text = "Test QRY";
            this.btnTestQRY.UseVisualStyleBackColor = true;
            this.btnTestQRY.Click += new System.EventHandler(this.btnTestQRY_Click);
            // 
            // txtQry
            // 
            this.txtQry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FindNonIndexedFolders.Properties.Settings.Default, "QRY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtQry.Location = new System.Drawing.Point(15, 33);
            this.txtQry.Multiline = true;
            this.txtQry.Name = "txtQry";
            this.txtQry.Size = new System.Drawing.Size(773, 118);
            this.txtQry.TabIndex = 4;
            this.txtQry.Text = global::FindNonIndexedFolders.Properties.Settings.Default.QRY;
            // 
            // txtVault
            // 
            this.txtVault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVault.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FindNonIndexedFolders.Properties.Settings.Default, "vault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVault.Location = new System.Drawing.Point(64, 422);
            this.txtVault.Name = "txtVault";
            this.txtVault.Size = new System.Drawing.Size(724, 22);
            this.txtVault.TabIndex = 2;
            this.txtVault.Text = global::FindNonIndexedFolders.Properties.Settings.Default.vault;
            this.txtVault.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.btnTestQRY);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtQry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVault);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BIDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtVault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQry;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnTestQRY;
    }
}

