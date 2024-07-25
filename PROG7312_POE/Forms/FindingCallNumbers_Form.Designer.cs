namespace PROG7312_POE.Forms
{
    partial class FindingCallNumbers_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingCallNumbers_Form));
            this.fIndingCallNumbers_UserControl1 = new PROG7312_POE.SubForms.FIndingCallNumbers_UserControl();
            this.SuspendLayout();
            // 
            // fIndingCallNumbers_UserControl1
            // 
            this.fIndingCallNumbers_UserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fIndingCallNumbers_UserControl1.BackgroundImage")));
            this.fIndingCallNumbers_UserControl1.Location = new System.Drawing.Point(0, -3);
            this.fIndingCallNumbers_UserControl1.Name = "fIndingCallNumbers_UserControl1";
            this.fIndingCallNumbers_UserControl1.Size = new System.Drawing.Size(998, 643);
            this.fIndingCallNumbers_UserControl1.TabIndex = 0;
            // 
            // FindingCallNumbers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 641);
            this.Controls.Add(this.fIndingCallNumbers_UserControl1);
            this.Name = "FindingCallNumbers_Form";
            this.Text = "FindingCallNumbers_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private SubForms.FIndingCallNumbers_UserControl fIndingCallNumbers_UserControl1;
    }
}