namespace Assignmnet5
{
    partial class PlayerInfo
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitInfo = new System.Windows.Forms.Button();
            this.alertAgeLabel = new System.Windows.Forms.Label();
            this.alertResonableAge = new System.Windows.Forms.Label();
            this.alertName = new System.Windows.Forms.Label();
            this.alertLastName = new System.Windows.Forms.Label();
            this.alertNoAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(217, 113);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(133, 25);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "First Name:";
            // 
            // UserLastName
            // 
            this.UserLastName.AutoSize = true;
            this.UserLastName.BackColor = System.Drawing.Color.Fuchsia;
            this.UserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLastName.Location = new System.Drawing.Point(220, 167);
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Size = new System.Drawing.Size(131, 25);
            this.UserLastName.TabIndex = 1;
            this.UserLastName.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(356, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(357, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(357, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 31);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player Information";
            // 
            // submitInfo
            // 
            this.submitInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submitInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInfo.Location = new System.Drawing.Point(389, 310);
            this.submitInfo.Name = "submitInfo";
            this.submitInfo.Size = new System.Drawing.Size(153, 54);
            this.submitInfo.TabIndex = 7;
            this.submitInfo.Text = "Submit";
            this.submitInfo.UseVisualStyleBackColor = false;
            this.submitInfo.Click += new System.EventHandler(this.submitInfo_Click);
            // 
            // alertAgeLabel
            // 
            this.alertAgeLabel.AutoSize = true;
            this.alertAgeLabel.BackColor = System.Drawing.Color.Maroon;
            this.alertAgeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.alertAgeLabel.Location = new System.Drawing.Point(634, 220);
            this.alertAgeLabel.Name = "alertAgeLabel";
            this.alertAgeLabel.Size = new System.Drawing.Size(82, 13);
            this.alertAgeLabel.TabIndex = 8;
            this.alertAgeLabel.Text = "Enter an integer";
            this.alertAgeLabel.Visible = false;
            // 
            // alertResonableAge
            // 
            this.alertResonableAge.AutoSize = true;
            this.alertResonableAge.BackColor = System.Drawing.Color.Maroon;
            this.alertResonableAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.alertResonableAge.Location = new System.Drawing.Point(634, 235);
            this.alertResonableAge.Name = "alertResonableAge";
            this.alertResonableAge.Size = new System.Drawing.Size(212, 13);
            this.alertResonableAge.TabIndex = 9;
            this.alertResonableAge.Text = "Enter age greater then 0 and less then 115!";
            this.alertResonableAge.Visible = false;
            // 
            // alertName
            // 
            this.alertName.AutoSize = true;
            this.alertName.BackColor = System.Drawing.Color.Maroon;
            this.alertName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.alertName.Location = new System.Drawing.Point(634, 113);
            this.alertName.Name = "alertName";
            this.alertName.Size = new System.Drawing.Size(106, 13);
            this.alertName.TabIndex = 10;
            this.alertName.Text = "Enter your last name.";
            this.alertName.Visible = false;
            // 
            // alertLastName
            // 
            this.alertLastName.AutoSize = true;
            this.alertLastName.BackColor = System.Drawing.Color.Maroon;
            this.alertLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.alertLastName.Location = new System.Drawing.Point(634, 167);
            this.alertLastName.Name = "alertLastName";
            this.alertLastName.Size = new System.Drawing.Size(103, 13);
            this.alertLastName.TabIndex = 11;
            this.alertLastName.Text = "Enter your last name";
            this.alertLastName.Visible = false;
            // 
            // alertNoAge
            // 
            this.alertNoAge.AutoSize = true;
            this.alertNoAge.BackColor = System.Drawing.Color.Maroon;
            this.alertNoAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.alertNoAge.Location = new System.Drawing.Point(634, 207);
            this.alertNoAge.Name = "alertNoAge";
            this.alertNoAge.Size = new System.Drawing.Size(69, 13);
            this.alertNoAge.TabIndex = 12;
            this.alertNoAge.Text = "Enter an Age";
            this.alertNoAge.Visible = false;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignmnet5.Properties.Resources.imageedit_2_9398540887;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.alertNoAge);
            this.Controls.Add(this.alertLastName);
            this.Controls.Add(this.alertName);
            this.Controls.Add(this.alertResonableAge);
            this.Controls.Add(this.alertAgeLabel);
            this.Controls.Add(this.submitInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserLastName);
            this.Controls.Add(this.UserName);
            this.Name = "PlayerInfo";
            this.Text = "Player Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitInfo;
        private System.Windows.Forms.Label alertAgeLabel;
        private System.Windows.Forms.Label alertResonableAge;
        private System.Windows.Forms.Label alertName;
        private System.Windows.Forms.Label alertLastName;
        private System.Windows.Forms.Label alertNoAge;
    }
}