namespace PROG7312_POE.Forms
{
    partial class ReplaceBooks_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooks_Form));
            this.replaceBooks_UserControl1 = new PROG7312_POE.SubForms.ReplaceBooks_UserControl();
            this.SuspendLayout();
            // 
            // replaceBooks_UserControl1
            // 
            this.replaceBooks_UserControl1.BackColor = System.Drawing.Color.Chartreuse;
            this.replaceBooks_UserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replaceBooks_UserControl1.BackgroundImage")));
            this.replaceBooks_UserControl1.Location = new System.Drawing.Point(-2, 0);
            this.replaceBooks_UserControl1.Name = "replaceBooks_UserControl1";
            this.replaceBooks_UserControl1.Size = new System.Drawing.Size(978, 593);
            this.replaceBooks_UserControl1.TabIndex = 0;
            // 
            // ReplaceBooks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 593);
            this.Controls.Add(this.replaceBooks_UserControl1);
            this.Name = "ReplaceBooks_Form";
            this.Text = "ReplaceBooks_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private SubForms.ReplaceBooks_UserControl replaceBooks_UserControl1;
    }
}