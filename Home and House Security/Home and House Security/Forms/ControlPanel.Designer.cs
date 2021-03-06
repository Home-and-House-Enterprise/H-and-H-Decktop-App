﻿namespace Home_and_House_Security
{
    partial class ControlPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewfp = new System.Windows.Forms.Button();
            this.myAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contact = new System.Windows.Forms.Button();
            this.arm = new System.Windows.Forms.Button();
            this.cameras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home and House Control Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cameras);
            this.panel1.Controls.Add(this.viewfp);
            this.panel1.Controls.Add(this.myAccount);
            this.panel1.Location = new System.Drawing.Point(24, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 288);
            this.panel1.TabIndex = 2;
            // 
            // viewfp
            // 
            this.viewfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewfp.Location = new System.Drawing.Point(25, 77);
            this.viewfp.Name = "viewfp";
            this.viewfp.Size = new System.Drawing.Size(185, 35);
            this.viewfp.TabIndex = 0;
            this.viewfp.Text = "View Floor Plans";
            this.viewfp.UseVisualStyleBackColor = true;
            this.viewfp.Click += new System.EventHandler(this.viewfp_Click);
            // 
            // myAccount
            // 
            this.myAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAccount.Location = new System.Drawing.Point(24, 21);
            this.myAccount.Name = "myAccount";
            this.myAccount.Size = new System.Drawing.Size(185, 35);
            this.myAccount.TabIndex = 0;
            this.myAccount.Text = "My Account";
            this.myAccount.UseVisualStyleBackColor = true;
            this.myAccount.Click += new System.EventHandler(this.myAccount_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.contact);
            this.panel2.Controls.Add(this.arm);
            this.panel2.Location = new System.Drawing.Point(323, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 288);
            this.panel2.TabIndex = 3;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(26, 77);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(185, 35);
            this.contact.TabIndex = 1;
            this.contact.Text = "Contact Us";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // arm
            // 
            this.arm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arm.ForeColor = System.Drawing.Color.Red;
            this.arm.Location = new System.Drawing.Point(26, 21);
            this.arm.Name = "arm";
            this.arm.Size = new System.Drawing.Size(185, 35);
            this.arm.TabIndex = 0;
            this.arm.Text = "ARM SYSTEM!";
            this.arm.UseVisualStyleBackColor = true;
            this.arm.Click += new System.EventHandler(this.arm_Click);
            // 
            // cameras
            // 
            this.cameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameras.Location = new System.Drawing.Point(24, 134);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(185, 35);
            this.cameras.TabIndex = 1;
            this.cameras.Text = "View Cameras";
            this.cameras.UseVisualStyleBackColor = true;
            this.cameras.Click += new System.EventHandler(this.cameras_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button myAccount;
        private System.Windows.Forms.Button viewfp;
        private System.Windows.Forms.Button arm;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button cameras;
    }
}