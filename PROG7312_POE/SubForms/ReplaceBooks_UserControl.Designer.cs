namespace PROG7312_POE.SubForms
{
    partial class ReplaceBooks_UserControl
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
            this.Check_Order = new System.Windows.Forms.Button();
            this.SubMenu_btn = new System.Windows.Forms.Button();
            this.Generate_Numbers_Btn = new System.Windows.Forms.Button();
            this.User_Display_Timer = new System.Windows.Forms.Label();
            this.BookShelf = new System.Windows.Forms.ListBox();
            this.Move_Down_Btn = new System.Windows.Forms.Button();
            this.Move_Up_btn = new System.Windows.Forms.Button();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Check_Order
            // 
            this.Check_Order.Location = new System.Drawing.Point(695, 446);
            this.Check_Order.Name = "Check_Order";
            this.Check_Order.Size = new System.Drawing.Size(120, 55);
            this.Check_Order.TabIndex = 17;
            this.Check_Order.Text = "Check";
            this.Check_Order.UseVisualStyleBackColor = true;
            this.Check_Order.Click += new System.EventHandler(this.Check_Order_Click);
            // 
            // SubMenu_btn
            // 
            this.SubMenu_btn.Location = new System.Drawing.Point(521, 446);
            this.SubMenu_btn.Name = "SubMenu_btn";
            this.SubMenu_btn.Size = new System.Drawing.Size(120, 55);
            this.SubMenu_btn.TabIndex = 16;
            this.SubMenu_btn.Text = "SubMenu";
            this.SubMenu_btn.UseVisualStyleBackColor = true;
            this.SubMenu_btn.Click += new System.EventHandler(this.SubMenu_btn_Click);
            // 
            // Generate_Numbers_Btn
            // 
            this.Generate_Numbers_Btn.Location = new System.Drawing.Point(348, 446);
            this.Generate_Numbers_Btn.Name = "Generate_Numbers_Btn";
            this.Generate_Numbers_Btn.Size = new System.Drawing.Size(120, 55);
            this.Generate_Numbers_Btn.TabIndex = 15;
            this.Generate_Numbers_Btn.Text = "Generate Numbers";
            this.Generate_Numbers_Btn.UseVisualStyleBackColor = true;
            this.Generate_Numbers_Btn.Click += new System.EventHandler(this.Generate_Numbers_Btn_Click);
            // 
            // User_Display_Timer
            // 
            this.User_Display_Timer.AutoSize = true;
            this.User_Display_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Display_Timer.Location = new System.Drawing.Point(337, 363);
            this.User_Display_Timer.Name = "User_Display_Timer";
            this.User_Display_Timer.Size = new System.Drawing.Size(131, 25);
            this.User_Display_Timer.TabIndex = 14;
            this.User_Display_Timer.Text = "Timer Display";
            this.User_Display_Timer.Click += new System.EventHandler(this.User_Display_Timer_Click);
            // 
            // BookShelf
            // 
            this.BookShelf.FormattingEnabled = true;
            this.BookShelf.ItemHeight = 16;
            this.BookShelf.Location = new System.Drawing.Point(342, 113);
            this.BookShelf.Name = "BookShelf";
            this.BookShelf.Size = new System.Drawing.Size(400, 180);
            this.BookShelf.TabIndex = 13;
            this.BookShelf.SelectedIndexChanged += new System.EventHandler(this.BookShelf_SelectedIndexChanged);
            // 
            // Move_Down_Btn
            // 
            this.Move_Down_Btn.Location = new System.Drawing.Point(112, 263);
            this.Move_Down_Btn.Name = "Move_Down_Btn";
            this.Move_Down_Btn.Size = new System.Drawing.Size(120, 55);
            this.Move_Down_Btn.TabIndex = 12;
            this.Move_Down_Btn.Text = "Down";
            this.Move_Down_Btn.UseVisualStyleBackColor = true;
            this.Move_Down_Btn.Click += new System.EventHandler(this.Move_Down_Btn_Click);
            // 
            // Move_Up_btn
            // 
            this.Move_Up_btn.Location = new System.Drawing.Point(112, 57);
            this.Move_Up_btn.Name = "Move_Up_btn";
            this.Move_Up_btn.Size = new System.Drawing.Size(120, 55);
            this.Move_Up_btn.TabIndex = 11;
            this.Move_Up_btn.Text = "Up";
            this.Move_Up_btn.UseVisualStyleBackColor = true;
            this.Move_Up_btn.Click += new System.EventHandler(this.Move_Up_btn_Click);
            // 
            // ReplaceBooks_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::PROG7312_POE.Properties.Resources.Main_Menu_back;
            this.Controls.Add(this.Check_Order);
            this.Controls.Add(this.SubMenu_btn);
            this.Controls.Add(this.Generate_Numbers_Btn);
            this.Controls.Add(this.User_Display_Timer);
            this.Controls.Add(this.BookShelf);
            this.Controls.Add(this.Move_Down_Btn);
            this.Controls.Add(this.Move_Up_btn);
            this.Name = "ReplaceBooks_UserControl";
            this.Size = new System.Drawing.Size(978, 593);
            this.Load += new System.EventHandler(this.ReplaceBooks_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check_Order;
        private System.Windows.Forms.Button SubMenu_btn;
        private System.Windows.Forms.Button Generate_Numbers_Btn;
        private System.Windows.Forms.Label User_Display_Timer;
        private System.Windows.Forms.ListBox BookShelf;
        private System.Windows.Forms.Button Move_Down_Btn;
        private System.Windows.Forms.Button Move_Up_btn;
        private System.Windows.Forms.Timer TimerClock;
    }
}
