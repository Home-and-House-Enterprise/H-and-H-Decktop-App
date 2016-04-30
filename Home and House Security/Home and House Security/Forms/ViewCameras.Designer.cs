namespace Home_and_House_Security.Forms
{
    partial class ViewCameras
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
            this.camImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoomOut = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.selectCam = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.camlist = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.camImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cameras";
            // 
            // camImage
            // 
            this.camImage.Location = new System.Drawing.Point(195, 62);
            this.camImage.Name = "camImage";
            this.camImage.Size = new System.Drawing.Size(237, 211);
            this.camImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camImage.TabIndex = 5;
            this.camImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.zoomOut);
            this.panel1.Controls.Add(this.zoomIn);
            this.panel1.Controls.Add(this.selectCam);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Location = new System.Drawing.Point(23, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 41);
            this.panel1.TabIndex = 6;
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(213, 9);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(99, 23);
            this.zoomOut.TabIndex = 3;
            this.zoomOut.Text = "Zoom Out";
            this.zoomOut.UseVisualStyleBackColor = true;
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(108, 9);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(99, 23);
            this.zoomIn.TabIndex = 2;
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.UseVisualStyleBackColor = true;
            // 
            // selectCam
            // 
            this.selectCam.Location = new System.Drawing.Point(3, 9);
            this.selectCam.Name = "selectCam";
            this.selectCam.Size = new System.Drawing.Size(99, 23);
            this.selectCam.TabIndex = 1;
            this.selectCam.Text = "Select Camera";
            this.selectCam.UseVisualStyleBackColor = true;
            this.selectCam.Click += new System.EventHandler(this.selectfp_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(316, 9);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // camlist
            // 
            this.camlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camlist.FormattingEnabled = true;
            this.camlist.ItemHeight = 20;
            this.camlist.Location = new System.Drawing.Point(28, 87);
            this.camlist.Name = "camlist";
            this.camlist.Size = new System.Drawing.Size(148, 184);
            this.camlist.TabIndex = 30;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(48, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 18);
            this.name.TabIndex = 31;
            this.name.Text = "Camera List";
            // 
            // ViewCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(459, 346);
            this.Controls.Add(this.name);
            this.Controls.Add(this.camlist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.camImage);
            this.Controls.Add(this.label1);
            this.Name = "ViewCameras";
            this.Text = "View Cameras";
            ((System.ComponentModel.ISupportInitialize)(this.camImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox camImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectCam;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.ListBox camlist;
        private System.Windows.Forms.Label name;
    }
}