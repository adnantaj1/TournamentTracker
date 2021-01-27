
namespace TrackerUI
{
    partial class TournamentViewrForm
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
            this.headerLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLable.Location = new System.Drawing.Point(284, 172);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(644, 149);
            this.headerLable.TabIndex = 0;
            this.headerLable.Text = "Tournament:";
            this.headerLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentViewrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 86F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1777, 1188);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewrForm";
            this.Text = "Tornament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
    }
}

