namespace Home_and_House_Security.Forms
{
    partial class FindSensor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sensorid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sensorName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 46);
            this.panel1.TabIndex = 8;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(237, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(115, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(111, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add To Floor Plan";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(3, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sensor Setup";
            // 
            // sensorid
            // 
            this.sensorid.Location = new System.Drawing.Point(100, 56);
            this.sensorid.Name = "sensorid";
            this.sensorid.Size = new System.Drawing.Size(165, 20);
            this.sensorid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sensor ID";
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.BackColor = System.Drawing.Color.Red;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(283, 58);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(55, 18);
            this.display.TabIndex = 12;
            this.display.Text = "invalid";
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(211, 120);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(81, 20);
            this.xPos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "X Position On Floor Plan";
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(213, 159);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(81, 20);
            this.yPos.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y Position On Floor Plan";
            // 
            // sensorName
            // 
            this.sensorName.Location = new System.Drawing.Point(124, 91);
            this.sensorName.Name = "sensorName";
            this.sensorName.Size = new System.Drawing.Size(154, 20);
            this.sensorName.TabIndex = 18;
            this.sensorName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(9, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 18);
            this.name.TabIndex = 17;
            this.name.Text = "Sensor Name";
            this.name.Click += new System.EventHandler(this.label3_Click);
            // 
            // FindSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(364, 248);
            this.Controls.Add(this.sensorName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display);
            this.Controls.Add(this.sensorid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FindSensor";
            this.Text = "Find Sensor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sensorid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sensorName;
        private System.Windows.Forms.Label name;
    }
}