namespace PROG7312_POE
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceBooks_btn = new System.Windows.Forms.Button();
            this.IdentifyingAreas = new System.Windows.Forms.Button();
            this.FindingCallNumbers_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dewey\'s pokedex library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReplaceBooks_btn
            // 
            this.ReplaceBooks_btn.BackColor = System.Drawing.Color.SlateGray;
            this.ReplaceBooks_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceBooks_btn.Location = new System.Drawing.Point(267, 198);
            this.ReplaceBooks_btn.Name = "ReplaceBooks_btn";
            this.ReplaceBooks_btn.Size = new System.Drawing.Size(494, 45);
            this.ReplaceBooks_btn.TabIndex = 6;
            this.ReplaceBooks_btn.Text = "Replacing Books";
            this.ReplaceBooks_btn.UseVisualStyleBackColor = false;
            this.ReplaceBooks_btn.Click += new System.EventHandler(this.ReplaceBooks_btn_Click);
            // 
            // IdentifyingAreas
            // 
            this.IdentifyingAreas.BackColor = System.Drawing.Color.SlateGray;
            this.IdentifyingAreas.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentifyingAreas.Location = new System.Drawing.Point(267, 306);
            this.IdentifyingAreas.Name = "IdentifyingAreas";
            this.IdentifyingAreas.Size = new System.Drawing.Size(494, 45);
            this.IdentifyingAreas.TabIndex = 7;
            this.IdentifyingAreas.Text = "Identifying areas";
            this.IdentifyingAreas.UseVisualStyleBackColor = false;
            this.IdentifyingAreas.Click += new System.EventHandler(this.IdentifyingAreas_Click);
            // 
            // FindingCallNumbers_btn
            // 
            this.FindingCallNumbers_btn.BackColor = System.Drawing.Color.SlateGray;
            this.FindingCallNumbers_btn.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindingCallNumbers_btn.Location = new System.Drawing.Point(267, 422);
            this.FindingCallNumbers_btn.Name = "FindingCallNumbers_btn";
            this.FindingCallNumbers_btn.Size = new System.Drawing.Size(494, 45);
            this.FindingCallNumbers_btn.TabIndex = 8;
            this.FindingCallNumbers_btn.Text = "Finding call numbers";
            this.FindingCallNumbers_btn.UseVisualStyleBackColor = false;
            this.FindingCallNumbers_btn.Click += new System.EventHandler(this.FindingCallNumbers_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_POE.Properties.Resources.Main_Menu_back;
            this.ClientSize = new System.Drawing.Size(1025, 608);
            this.Controls.Add(this.FindingCallNumbers_btn);
            this.Controls.Add(this.IdentifyingAreas);
            this.Controls.Add(this.ReplaceBooks_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplaceBooks_btn;
        private System.Windows.Forms.Button IdentifyingAreas;
        private System.Windows.Forms.Button FindingCallNumbers_btn;
    }
}

