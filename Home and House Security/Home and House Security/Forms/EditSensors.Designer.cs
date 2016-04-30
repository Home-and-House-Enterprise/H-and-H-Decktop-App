namespace Home_and_House_Security.Forms
{
    partial class EditSensors
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
            this.sensorName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.yPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enabled = new System.Windows.Forms.RadioButton();
            this.slist = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sensorName
            // 
            this.sensorName.Location = new System.Drawing.Point(124, 65);
            this.sensorName.Name = "sensorName";
            this.sensorName.Size = new System.Drawing.Size(168, 20);
            this.sensorName.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(9, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 18);
            this.name.TabIndex = 23;
            this.name.Text = "Sensor Name";
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(213, 133);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(81, 20);
            this.yPos.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Y Position On Floor Plan";
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(211, 94);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(81, 20);
            this.xPos.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "X Position On Floor Plan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.select);
            this.panel1.Location = new System.Drawing.Point(12, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 46);
            this.panel1.TabIndex = 25;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(189, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(81, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(90, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(93, 23);
            this.update.TabIndex = 1;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(3, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(81, 23);
            this.select.TabIndex = 1;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sensor Setup";
            // 
            // enabled
            // 
            this.enabled.AutoSize = true;
            this.enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled.ForeColor = System.Drawing.Color.White;
            this.enabled.Location = new System.Drawing.Point(15, 162);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(138, 22);
            this.enabled.TabIndex = 28;
            this.enabled.TabStop = true;
            this.enabled.Text = "Enable/Disable";
            this.enabled.UseVisualStyleBackColor = true;
            // 
            // slist
            // 
            this.slist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slist.FormattingEnabled = true;
            this.slist.ItemHeight = 20;
            this.slist.Location = new System.Drawing.Point(315, 65);
            this.slist.Name = "slist";
            this.slist.Size = new System.Drawing.Size(182, 184);
            this.slist.TabIndex = 29;
            // 
            // EditSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(525, 258);
            this.Controls.Add(this.slist);
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sensorName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.label4);
            this.Name = "EditSensors";
            this.Text = "Edit Sensors";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sensorName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton enabled;
        private System.Windows.Forms.ListBox slist;
    }
}