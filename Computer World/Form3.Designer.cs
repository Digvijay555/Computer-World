namespace Computer_World
{
    partial class Form3
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
            this.btnScience = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btncomputer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-18, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Quiz Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScience
            // 
            this.btnScience.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScience.BackColor = System.Drawing.Color.Lime;
            this.btnScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScience.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnScience.Location = new System.Drawing.Point(611, 191);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(357, 75);
            this.btnScience.TabIndex = 2;
            this.btnScience.Text = "Science Quiz";
            this.btnScience.UseVisualStyleBackColor = false;
            this.btnScience.Click += new System.EventHandler(this.btnScience_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHistory.BackColor = System.Drawing.Color.Lime;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnHistory.Location = new System.Drawing.Point(329, 417);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(357, 75);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "General Quiz";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btncomputer
            // 
            this.btncomputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncomputer.BackColor = System.Drawing.Color.Lime;
            this.btncomputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomputer.ForeColor = System.Drawing.Color.MediumBlue;
            this.btncomputer.Location = new System.Drawing.Point(12, 191);
            this.btncomputer.Name = "btncomputer";
            this.btncomputer.Size = new System.Drawing.Size(357, 75);
            this.btncomputer.TabIndex = 1;
            this.btncomputer.Text = "Computer Quiz";
            this.btncomputer.UseVisualStyleBackColor = false;
            this.btncomputer.Click += new System.EventHandler(this.btncomputer_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(836, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 45);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Home";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Computer_World.Properties.Resources.IMG_8712;
            this.ClientSize = new System.Drawing.Size(980, 504);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnScience);
            this.Controls.Add(this.btncomputer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.Name = "Form3";
            this.Text = "Select Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScience;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btncomputer;
        private System.Windows.Forms.Button btnNext;
    }
}