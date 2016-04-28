namespace Home_and_House_Security.Forms
{
    partial class FloorPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloorPlans));
            this.pfView = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.selectfp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pfView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pfView
            // 
            this.pfView.Image = ((System.Drawing.Image)(resources.GetObject("pfView.Image")));
            this.pfView.Location = new System.Drawing.Point(56, 48);
            this.pfView.Name = "pfView";
            this.pfView.Size = new System.Drawing.Size(377, 267);
            this.pfView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfView.TabIndex = 0;
            this.pfView.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(331, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // selectfp
            // 
            this.selectfp.Location = new System.Drawing.Point(16, 3);
            this.selectfp.Name = "selectfp";
            this.selectfp.Size = new System.Drawing.Size(99, 23);
            this.selectfp.TabIndex = 1;
            this.selectfp.Text = "Select Floor Plan";
            this.selectfp.UseVisualStyleBackColor = true;
            this.selectfp.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Sensor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add Camera";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.selectfp);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Location = new System.Drawing.Point(12, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 51);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(130, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Floor Plan";
            // 
            // FloorPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(474, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pfView);
            this.Name = "FloorPlans";
            this.Text = "Floor Plans";
            ((System.ComponentModel.ISupportInitialize)(this.pfView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pfView;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button selectfp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}