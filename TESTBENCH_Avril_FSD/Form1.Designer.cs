namespace TESTBENCH_Avril_FSD
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
            this.launchServer = new System.Windows.Forms.Button();
            this.launcClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchServer
            // 
            this.launchServer.Location = new System.Drawing.Point(130, 363);
            this.launchServer.Name = "launchServer";
            this.launchServer.Size = new System.Drawing.Size(121, 23);
            this.launchServer.TabIndex = 0;
            this.launchServer.Text = "Launch Server";
            this.launchServer.UseVisualStyleBackColor = true;
            this.launchServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // launcClient
            // 
            this.launcClient.Location = new System.Drawing.Point(512, 363);
            this.launcClient.Name = "launcClient";
            this.launcClient.Size = new System.Drawing.Size(143, 23);
            this.launcClient.TabIndex = 1;
            this.launcClient.Text = "Launch Client";
            this.launcClient.UseVisualStyleBackColor = true;
            this.launcClient.Click += new System.EventHandler(this.launcClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.launcClient);
            this.Controls.Add(this.launchServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchServer;
        private System.Windows.Forms.Button launcClient;
    }
}

