namespace Assignmnet5
{
    partial class MainMenu
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
            this.PlayGame = new System.Windows.Forms.Button();
            this.UserData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.Fuchsia;
            this.PlayGame.Enabled = false;
            this.PlayGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlayGame.FlatAppearance.BorderSize = 10;
            this.PlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.Location = new System.Drawing.Point(242, 251);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(197, 97);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "Play Game";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            this.PlayGame.MouseLeave += new System.EventHandler(this.PlayGame_MouseLeave);
            this.PlayGame.MouseHover += new System.EventHandler(this.PlayGame_MouseHover);
            // 
            // UserData
            // 
            this.UserData.BackColor = System.Drawing.Color.Red;
            this.UserData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserData.Location = new System.Drawing.Point(730, 251);
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(197, 97);
            this.UserData.TabIndex = 2;
            this.UserData.Text = "Enter Your Info";
            this.UserData.UseVisualStyleBackColor = false;
            this.UserData.Click += new System.EventHandler(this.UserData_Click);
            this.UserData.MouseLeave += new System.EventHandler(this.UserData_MouseLeave);
            this.UserData.MouseHover += new System.EventHandler(this.UserData_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To The Math Game";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignmnet5.Properties.Resources._65fa961e_8f22_4fe6_a420_3c3c26dd2953_jpg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserData);
            this.Controls.Add(this.PlayGame);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Button UserData;
        private System.Windows.Forms.Label label1;
    }
}

