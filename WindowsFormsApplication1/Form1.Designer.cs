namespace WindowsFormsApplication1
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
            this.raton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raton
            // 
            this.raton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.raton.Location = new System.Drawing.Point(244, 190);
            this.raton.Name = "raton";
            this.raton.Size = new System.Drawing.Size(124, 59);
            this.raton.TabIndex = 0;
            this.raton.Text = "Ratón";
            this.raton.UseVisualStyleBackColor = true;            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.raton);
            this.Name = "Form1";
            this.Text = "Atrapa al ratón!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raton;
    }
}

