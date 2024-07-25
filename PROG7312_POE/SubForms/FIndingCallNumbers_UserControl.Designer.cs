namespace PROG7312_POE.SubForms
{
    partial class FIndingCallNumbers_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Select_btn = new System.Windows.Forms.Button();
            this.Finish_btn = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.ListBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Finding Call Numbers Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Username:";
            // 
            // UserName_txt
            // 
            this.UserName_txt.BackColor = System.Drawing.Color.Silver;
            this.UserName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_txt.Location = new System.Drawing.Point(309, 160);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(309, 34);
            this.UserName_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question:";
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.Silver;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.Location = new System.Drawing.Point(309, 219);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(309, 34);
            this.QuestionBox.TabIndex = 10;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(100, 373);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(93, 58);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.Location = new System.Drawing.Point(792, 361);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(99, 70);
            this.Select_btn.TabIndex = 12;
            this.Select_btn.Text = "Select";
            this.Select_btn.UseVisualStyleBackColor = true;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // Finish_btn
            // 
            this.Finish_btn.Location = new System.Drawing.Point(585, 552);
            this.Finish_btn.Name = "Finish_btn";
            this.Finish_btn.Size = new System.Drawing.Size(116, 55);
            this.Finish_btn.TabIndex = 13;
            this.Finish_btn.Text = "Finish";
            this.Finish_btn.UseVisualStyleBackColor = true;
            // 
            // AnswerBox
            // 
            this.AnswerBox.FormattingEnabled = true;
            this.AnswerBox.ItemHeight = 16;
            this.AnswerBox.Location = new System.Drawing.Point(255, 311);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(467, 180);
            this.AnswerBox.TabIndex = 14;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(271, 552);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(132, 55);
            this.Back_btn.TabIndex = 15;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // FIndingCallNumbers_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312_POE.Properties.Resources.Main_Menu_back;
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.Finish_btn);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FIndingCallNumbers_UserControl";
            this.Size = new System.Drawing.Size(998, 643);
            this.Load += new System.EventHandler(this.FIndingCallNumbers_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button Finish_btn;
        private System.Windows.Forms.ListBox AnswerBox;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button Back_btn;
    }
}
