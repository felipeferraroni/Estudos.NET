namespace Basic.Views
{
    partial class FrmTranbalhandoXml
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(848, 234);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filmes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTranbalhandoXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 616);
            this.Controls.Add(this.button1);
            this.Name = "FrmTranbalhandoXml";
            this.Text = "FrmTranbalhandoXml";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}