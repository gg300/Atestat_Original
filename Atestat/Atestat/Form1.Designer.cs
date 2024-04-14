namespace Atestat
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
            this.b_start = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.BackgroundImage = global::Atestat.Properties.Resources.images;
            this.b_start.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.b_start.Location = new System.Drawing.Point(335, 195);
            this.b_start.Margin = new System.Windows.Forms.Padding(4);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(272, 80);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_exit
            // 
            this.b_exit.BackgroundImage = global::Atestat.Properties.Resources.download;
            this.b_exit.Location = new System.Drawing.Point(314, 372);
            this.b_exit.Margin = new System.Windows.Forms.Padding(4);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(341, 128);
            this.b_exit.TabIndex = 1;
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.Dinosaur_Memory_Game;
            this.ClientSize = new System.Drawing.Size(982, 713);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Meniu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_exit;
    }
}

