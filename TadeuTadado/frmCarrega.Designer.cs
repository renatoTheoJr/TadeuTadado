namespace TadeuTadado
{
    partial class frmCarrega
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
            this.components = new System.ComponentModel.Container();
            this.pbCarrega = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbCarrega
            // 
            this.pbCarrega.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pbCarrega.Location = new System.Drawing.Point(143, 271);
            this.pbCarrega.Name = "pbCarrega";
            this.pbCarrega.Size = new System.Drawing.Size(499, 55);
            this.pbCarrega.TabIndex = 0;
            this.pbCarrega.Click += new System.EventHandler(this.pbCarrega_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCarrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCarrega);
            this.Name = "frmCarrega";
            this.Text = "frmCarrega";
            this.Load += new System.EventHandler(this.frmCarrega_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbCarrega;
        private System.Windows.Forms.Timer timer1;
    }
}