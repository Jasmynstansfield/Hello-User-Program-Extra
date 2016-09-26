namespace Hello_User_Program_Extra
{
    partial class frmGreetings
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
            this.btnSnareDrum = new System.Windows.Forms.Button();
            this.btnAmnesia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblJoke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSnareDrum
            // 
            this.btnSnareDrum.Location = new System.Drawing.Point(44, 56);
            this.btnSnareDrum.Name = "btnSnareDrum";
            this.btnSnareDrum.Size = new System.Drawing.Size(235, 23);
            this.btnSnareDrum.TabIndex = 0;
            this.btnSnareDrum.Text = "A snare drum and a symbol fell out of a tree...";
            this.btnSnareDrum.UseVisualStyleBackColor = true;
            this.btnSnareDrum.Click += new System.EventHandler(this.btnSnareDrum_Click);
            // 
            // btnAmnesia
            // 
            this.btnAmnesia.Location = new System.Drawing.Point(44, 105);
            this.btnAmnesia.Name = "btnAmnesia";
            this.btnAmnesia.Size = new System.Drawing.Size(235, 23);
            this.btnAmnesia.TabIndex = 1;
            this.btnAmnesia.Text = "Did you hear that joke about amnesia?";
            this.btnAmnesia.UseVisualStyleBackColor = true;
            this.btnAmnesia.Click += new System.EventHandler(this.btnAmnesia_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(41, 271);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(0, 13);
            this.lblJoke.TabIndex = 6;
            // 
            // frmGreetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 373);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAmnesia);
            this.Controls.Add(this.btnSnareDrum);
            this.Name = "frmGreetings";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnareDrum;
        private System.Windows.Forms.Button btnAmnesia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblJoke;
    }
}

