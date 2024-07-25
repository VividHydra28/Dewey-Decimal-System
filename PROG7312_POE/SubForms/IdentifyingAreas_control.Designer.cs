namespace PROG7312_POE.SubForms
{
    partial class IdentifyingAreas_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerScoreNum = new System.Windows.Forms.Label();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.Select_btn = new System.Windows.Forms.Button();
            this.Social_btn = new System.Windows.Forms.Button();
            this.Menubtn = new System.Windows.Forms.Button();
            this.NextQuestionbtn = new System.Windows.Forms.Button();
            this.Check_Answerbtn = new System.Windows.Forms.Button();
            this.labelDisplayTimer = new System.Windows.Forms.Label();
            this.ListBoxDesc = new System.Windows.Forms.ListBox();
            this.ListBoxNum = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlayerScoreNum
            // 
            this.PlayerScoreNum.AutoSize = true;
            this.PlayerScoreNum.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayerScoreNum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScoreNum.Location = new System.Drawing.Point(565, 23);
            this.PlayerScoreNum.Name = "PlayerScoreNum";
            this.PlayerScoreNum.Size = new System.Drawing.Size(23, 25);
            this.PlayerScoreNum.TabIndex = 26;
            this.PlayerScoreNum.Text = "0";
            this.PlayerScoreNum.Click += new System.EventHandler(this.PlayerScoreNum_Click);
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScoreLabel.Location = new System.Drawing.Point(403, 23);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(130, 25);
            this.PlayerScoreLabel.TabIndex = 25;
            this.PlayerScoreLabel.Text = "PlayerScore";
            this.PlayerScoreLabel.Click += new System.EventHandler(this.PlayerScoreLabel_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.Location = new System.Drawing.Point(475, 499);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(90, 56);
            this.Select_btn.TabIndex = 24;
            this.Select_btn.Text = "Select";
            this.Select_btn.UseVisualStyleBackColor = true;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // Social_btn
            // 
            this.Social_btn.Location = new System.Drawing.Point(876, 485);
            this.Social_btn.Name = "Social_btn";
            this.Social_btn.Size = new System.Drawing.Size(94, 86);
            this.Social_btn.TabIndex = 23;
            this.Social_btn.Text = "LinkedIn";
            this.Social_btn.UseVisualStyleBackColor = true;
            this.Social_btn.Click += new System.EventHandler(this.Social_btn_Click);
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(52, 500);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(60, 56);
            this.Menubtn.TabIndex = 22;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // NextQuestionbtn
            // 
            this.NextQuestionbtn.Location = new System.Drawing.Point(590, 499);
            this.NextQuestionbtn.Name = "NextQuestionbtn";
            this.NextQuestionbtn.Size = new System.Drawing.Size(225, 56);
            this.NextQuestionbtn.TabIndex = 21;
            this.NextQuestionbtn.Text = "Next Question";
            this.NextQuestionbtn.UseVisualStyleBackColor = true;
            this.NextQuestionbtn.Click += new System.EventHandler(this.NextQuestionbtn_Click);
            // 
            // Check_Answerbtn
            // 
            this.Check_Answerbtn.Location = new System.Drawing.Point(165, 499);
            this.Check_Answerbtn.Name = "Check_Answerbtn";
            this.Check_Answerbtn.Size = new System.Drawing.Size(192, 56);
            this.Check_Answerbtn.TabIndex = 20;
            this.Check_Answerbtn.Text = "Check Answer";
            this.Check_Answerbtn.UseVisualStyleBackColor = true;
            this.Check_Answerbtn.Click += new System.EventHandler(this.Check_Answerbtn_Click);
            // 
            // labelDisplayTimer
            // 
            this.labelDisplayTimer.AutoSize = true;
            this.labelDisplayTimer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDisplayTimer.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayTimer.ForeColor = System.Drawing.Color.Black;
            this.labelDisplayTimer.Location = new System.Drawing.Point(620, 84);
            this.labelDisplayTimer.Name = "labelDisplayTimer";
            this.labelDisplayTimer.Size = new System.Drawing.Size(106, 43);
            this.labelDisplayTimer.TabIndex = 19;
            this.labelDisplayTimer.Text = "00:00";
            this.labelDisplayTimer.Click += new System.EventHandler(this.labelDisplayTimer_Click);
            // 
            // ListBoxDesc
            // 
            this.ListBoxDesc.FormattingEnabled = true;
            this.ListBoxDesc.ItemHeight = 16;
            this.ListBoxDesc.Location = new System.Drawing.Point(578, 144);
            this.ListBoxDesc.Name = "ListBoxDesc";
            this.ListBoxDesc.Size = new System.Drawing.Size(384, 292);
            this.ListBoxDesc.TabIndex = 18;
            this.ListBoxDesc.SelectedIndexChanged += new System.EventHandler(this.ListBoxDesc_SelectedIndexChanged);
            // 
            // ListBoxNum
            // 
            this.ListBoxNum.FormattingEnabled = true;
            this.ListBoxNum.ItemHeight = 16;
            this.ListBoxNum.Location = new System.Drawing.Point(156, 144);
            this.ListBoxNum.Name = "ListBoxNum";
            this.ListBoxNum.Size = new System.Drawing.Size(353, 292);
            this.ListBoxNum.TabIndex = 17;
            this.ListBoxNum.SelectedIndexChanged += new System.EventHandler(this.ListBoxNum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Timer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IdentifyingAreas_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_POE.Properties.Resources.Main_Menu_back;
            this.Controls.Add(this.PlayerScoreNum);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.Social_btn);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.NextQuestionbtn);
            this.Controls.Add(this.Check_Answerbtn);
            this.Controls.Add(this.labelDisplayTimer);
            this.Controls.Add(this.ListBoxDesc);
            this.Controls.Add(this.ListBoxNum);
            this.Controls.Add(this.label2);
            this.Name = "IdentifyingAreas_control";
            this.Size = new System.Drawing.Size(1022, 594);
            this.Load += new System.EventHandler(this.IdentifyingAreas_control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerScoreNum;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button Social_btn;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button NextQuestionbtn;
        private System.Windows.Forms.Button Check_Answerbtn;
        private System.Windows.Forms.Label labelDisplayTimer;
        private System.Windows.Forms.ListBox ListBoxDesc;
        private System.Windows.Forms.ListBox ListBoxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
