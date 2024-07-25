using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public class UserInputBox_class
    {

        public static DialogResult ShowDialog(string promptText, string caption, ref string value)
        {

            Form form = new Form();


            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();


            form.Text = caption;
            label.Text = promptText;
            textBox.Text = value;
            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;


            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20); //These set the posistions 
            buttonOk.SetBounds(309, 72, 75, 23);


            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;


            form.ClientSize = new Size(396, 107); //This object sets the size of the form


            form.Controls.AddRange(new Control[] { label, textBox, buttonOk }); //imports the conrol for the form


            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);


            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();


            value = textBox.Text;

            return dialogResult;
        }


    }
}
