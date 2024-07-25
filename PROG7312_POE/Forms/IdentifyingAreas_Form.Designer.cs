namespace PROG7312_POE.Forms
{
    partial class IdentifyingAreas_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyingAreas_Form));
            this.identifyingAreas_control1 = new PROG7312_POE.SubForms.IdentifyingAreas_control();
            this.SuspendLayout();
            // 
            // identifyingAreas_control1
            // 
            this.identifyingAreas_control1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("identifyingAreas_control1.BackgroundImage")));
            this.identifyingAreas_control1.Location = new System.Drawing.Point(-3, 0);
            this.identifyingAreas_control1.Name = "identifyingAreas_control1";
            this.identifyingAreas_control1.Size = new System.Drawing.Size(1022, 594);
            this.identifyingAreas_control1.TabIndex = 0;
            // 
            // IdentifyingAreas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 592);
            this.Controls.Add(this.identifyingAreas_control1);
            this.Name = "IdentifyingAreas_Form";
            this.Text = "IdentifyingAreas_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private SubForms.IdentifyingAreas_control identifyingAreas_control1;
    }
}