using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrailleApplication
{
    public partial class BrailleDisplayForm : Form
    {
        int count = 0;

        public BrailleDisplayForm()
        {
            InitializeComponent();
            init();
            //sample();
        }

        public void init() {
            brailleListView.View= View.Details;
            brailleListView.Columns.Add("번호", 40, HorizontalAlignment.Right);
            brailleListView.Columns.Add("유니코드", 60, HorizontalAlignment.Right);
            brailleListView.Columns.Add("값", 45, HorizontalAlignment.Center);

            brailleListView.Columns.Add("분류",     80, HorizontalAlignment.Center);
            brailleListView.Columns.Add("에러",     45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("약어(자)", 80, HorizontalAlignment.Center);
            brailleListView.Columns.Add("5", 45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("4", 45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("3", 45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("2", 45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("1", 45, HorizontalAlignment.Center);
            brailleListView.Columns.Add("0", 45, HorizontalAlignment.Center);
        }

        public void add(Braille braille) {
            
            brailleListView.Items.Add(Convert.ToString(count+1));
            brailleListView.Items[count].SubItems.Add(Convert.ToString(braille.getValue()));
            //brailleListView.Items[count].SubItems.Add(Convert.ToString(braille.getChar()));
            brailleListView.Items[count].SubItems.Add(Convert.ToString(Convert.ToChar(braille.getValue())));

            string tmpKindString=" ";
            switch(braille.getKind()) {
                case Braille.첫소리자음 : tmpKindString="첫소리자음"; break;
                case Braille.기본모음   : tmpKindString="기본모음"; break;
                case Braille.받침자음   : tmpKindString="받침자음"; break;
                //case Braille.이중삼중모음 : tmpKindString = "이중삼중모음"; break;
            }
            brailleListView.Items[count].SubItems.Add(Convert.ToString(tmpKindString));
            brailleListView.Items[count].SubItems.Add(Convert.ToString(braille.getError()));
            brailleListView.Items[count].SubItems.Add(Convert.ToString(braille.getExt()));
            count++;
        }

        public void sample() {
            brailleListView.Items.Add("1");
            brailleListView.Items[0].SubItems.Add("1100");
            brailleListView.Items[0].SubItems.Add("ㄱ");
            brailleListView.Items[0].SubItems.Add("첫소리자음");
            brailleListView.Items[0].SubItems.Add(" ");
            brailleListView.Items[0].SubItems.Add(" ");
            brailleListView.Items[0].SubItems.Add("0");
            brailleListView.Items[0].SubItems.Add("0");
            brailleListView.Items[0].SubItems.Add("1");
            brailleListView.Items[0].SubItems.Add("0");
            brailleListView.Items[0].SubItems.Add("0");
            brailleListView.Items[0].SubItems.Add("0");

            brailleListView.Items.Add("2");
            brailleListView.Items[1].SubItems.Add("1102");
            brailleListView.Items[1].SubItems.Add("ㄴ");
            brailleListView.Items[1].SubItems.Add("첫소리자음");
            brailleListView.Items[1].SubItems.Add(" ");
            brailleListView.Items[1].SubItems.Add(" ");
            brailleListView.Items[1].SubItems.Add("0");
            brailleListView.Items[1].SubItems.Add("0");
            brailleListView.Items[1].SubItems.Add("1");
            brailleListView.Items[1].SubItems.Add("0");
            brailleListView.Items[1].SubItems.Add("0");
            brailleListView.Items[1].SubItems.Add("1");
        }
        /*
        private void clearButton_Click(object sender, EventArgs e)
        {
            brailleListView.Clear();
            count = 0;
            init();
            
        }
*/
        public void setMessage(string message)
        { 
            logRichTextBox.AppendText(message);
            logRichTextBox.SelectionStart = logRichTextBox.Text.Length;
            logRichTextBox.ScrollToCaret();
        }
    }
}
