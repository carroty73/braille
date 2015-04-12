using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BrailleApplication {

    public partial class Frame : Form {
        public const int DEBUG_MODE= 10;
        public const int NORMAL_MODE = 20;
        public int mode = DEBUG_MODE;

        public int lineCnt = 0;
        private int tick; // 타이머 이벤트를 위한 틱 카운트

        //BrailleApplication.BrailleManager brailleManager;
        BrailleDisplayForm brailleDisplayForm; 
        private System.Windows.Forms.FontDialog fontDialog1;
        TitleForm titleForm;

        public Frame() {
            InitializeComponent();
            titleForm = new TitleForm();
            CenterToScreen();
            titleForm.Visible= true;

            brailleDisplayForm = new BrailleDisplayForm();
            brailleDisplayForm.Visible = true;
            this.fontDialog1 = new System.Windows.Forms.FontDialog();

            langKorRadioButton.Checked = true;
            Braille.selectedLanguage = Braille.KOREAN;
            manualRadioButton.Checked = true;
            Braille.selectedConvOption = Braille.MANUAL_CONV;

            //brailleManager = new BrailleManager();
/*
            // 이미지를 하나 richTextBox에 등록하는 샘플 코드
            Image tmpImage;
            tmpImage = Properties.Resources.num_1;
            Clipboard.Clear();
            Clipboard.SetImage(tmpImage);
            richTextBox2.Paste();
*/
            // richTextBox1에서 글자가 입력되면 타이머 가동..
            timer1 = new Timer();
            timer1.Interval = 200; // 주기는 0.2sec
        }
        
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)  {
            if (e.KeyCode == Keys.Enter) {
                // text2braille(Braille.selectedLanguage,  richTextBox1.Text); qqq 아래 버튼 이벤트 함수로 대체하면 좋을듯
            }
        }

        private void brailleImageClick(object sender, EventArgs e) {
            string name = "";
            name = (sender as PictureBox).Name;
            Console.Write(name);
        }

        private void clearTextboxButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Font = fontDialog1.Font;
            }
        }
        // 텍스트를 점자로 바꿔주기
        private void extractButton_Click_1(object sender, EventArgs e) {
            richTextBox2.Clear();
            string text = richTextBox1.Text;
            text = text.Trim();
            // 아무 글자가 없을때 클릭하면 메세지 띄우기
            if ((text == null) || (text == "")) {
                MessageBox.Show("변환할 글자가 없습니다.");
                return;
            }
            // 영문으로 해놓고 한글을 타이핑한다거나, 
            // 한글로 해놓고 영문으로 타이핑할때 에러
            // 아무튼 뭔가 합당한 글자는 있다!
            else {
                ch2braille(text);
                richTextBox1.AppendText("\n");
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                richTextBox1.Clear();
            }
        }

        public void ch2braille(string text) {
            // 근데 한글이라면, 아래와 같이 변환
            if (Braille.selectedLanguage == Braille.KOREAN) {
                char[] extractedChArr = new char[3];
                /*
                setMessage(text);
                if (text == "가")
                {
                    Braille extBraille = new Braille(Braille.KOREAN, Braille.약어, Convert.ToChar('가'));
                    Clipboard.Clear();
                    brailleDisplayForm.add(extBraille);
                    Clipboard.SetImage(extBraille.getBmp()); 
                    richTextBox2.Paste(); // qqq bmp가 null이란다.
                    return;
                }
                    */
                if (text == "이건아니지")
                {
                }
                else
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        extractedChArr = Braille.extract(Convert.ToChar(text[i]));
                        Clipboard.Clear();
                        if (extractedChArr[0] != 4363)
                        {
                            Braille tmp1 = new Braille(Braille.KOREAN, Braille.첫소리자음, extractedChArr[0]);
                            brailleDisplayForm.add(tmp1);
                            Clipboard.SetImage(tmp1.getBmp());
                            richTextBox2.Paste();
                        }
                        Braille tmp2 = new Braille(Braille.KOREAN, Braille.기본모음, extractedChArr[1]);
                        brailleDisplayForm.add(tmp2);
                        Clipboard.SetImage(tmp2.getBmp());
                        richTextBox2.Paste();

                        if (extractedChArr[2] != 4519)
                        {
                            Braille tmp3 = new Braille(Braille.KOREAN, Braille.받침자음, extractedChArr[2]);
                            brailleDisplayForm.add(tmp3);
                            Clipboard.SetImage(tmp3.getBmp());
                            richTextBox2.Paste();
                        }
                    }
                }

            }
            // 한글이 아니고 영어라면 아래와 같이 변환
            else if (Braille.selectedLanguage == Braille.ENGLISH) {
                setMessage(text);
                Braille startBraille = new Braille(Braille.ENGLISH, Braille.START_ENGLISH_CODE);
                Clipboard.SetImage(startBraille.getBmp()); richTextBox2.Paste();
                for (int i = 0; i < text.Length; i++) {
                    char tmpChar = Convert.ToChar(text[i]);
                    Braille.engExtract(tmpChar);
                    Braille tmp1 = new Braille(Braille.ENGLISH, tmpChar);
                    brailleDisplayForm.add(tmp1);
                    Clipboard.SetImage(tmp1.getBmp()); richTextBox2.Paste();
                }
                Braille endBraille = new Braille(Braille.ENGLISH, Braille.END_ENGLISH_CODE);
                Clipboard.SetImage(endBraille.getBmp()); richTextBox2.Paste();
            }
        }
        /*
        private void 첫소리자음Button_Click(object sender, EventArgs e)
        {
            Braille braille1 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄱ'); Clipboard.SetImage(braille1.getBmp()); richTextBox2.Paste();
            Braille braille2 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄴ'); Clipboard.SetImage(braille2.getBmp()); richTextBox2.Paste();
            Braille braille3 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄷ'); Clipboard.SetImage(braille3.getBmp()); richTextBox2.Paste();
            Braille braille4 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄹ'); Clipboard.SetImage(braille4.getBmp()); richTextBox2.Paste();
            Braille braille5 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅁ'); Clipboard.SetImage(braille5.getBmp()); richTextBox2.Paste();
            Braille braille6 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅂ'); Clipboard.SetImage(braille6.getBmp()); richTextBox2.Paste();
            Braille braille7 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅅ'); Clipboard.SetImage(braille7.getBmp()); richTextBox2.Paste();
            Braille braille8 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅈ'); Clipboard.SetImage(braille8.getBmp()); richTextBox2.Paste();
            Braille braille9 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅊ'); Clipboard.SetImage(braille9.getBmp()); richTextBox2.Paste();
            Braille braille10 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅋ'); Clipboard.SetImage(braille10.getBmp()); richTextBox2.Paste();
            Braille braille11 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅌ'); Clipboard.SetImage(braille11.getBmp()); richTextBox2.Paste();
            Braille braille12 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅍ'); Clipboard.SetImage(braille12.getBmp()); richTextBox2.Paste();
            Braille braille13 = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅎ'); Clipboard.SetImage(braille13.getBmp()); richTextBox2.Paste();
        }

        private void 모음Button_Click(object sender, EventArgs e)
        {
        }

        private void 이중삼중모음Button_Click(object sender, EventArgs e)
        {


        }

        private void 받침자음Button_Click(object sender, EventArgs e)
        {
        }
        */


        private void 첫소리자음Button_Click(object sender, EventArgs e) {
            Braille braille1 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4352); Clipboard.SetImage(braille1.getBmp()); richTextBox2.Paste();
            Braille braille2 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4354); Clipboard.SetImage(braille2.getBmp()); richTextBox2.Paste();
            Braille braille3 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4355); Clipboard.SetImage(braille3.getBmp()); richTextBox2.Paste();
            Braille braille4 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4357); Clipboard.SetImage(braille4.getBmp()); richTextBox2.Paste();
            Braille braille5 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4358); Clipboard.SetImage(braille5.getBmp()); richTextBox2.Paste();
            Braille braille6 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4359); Clipboard.SetImage(braille6.getBmp()); richTextBox2.Paste();
            Braille braille7 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4361); Clipboard.SetImage(braille7.getBmp()); richTextBox2.Paste();
            Braille braille8 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4364); Clipboard.SetImage(braille8.getBmp()); richTextBox2.Paste();
            Braille braille9 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4366); Clipboard.SetImage(braille9.getBmp()); richTextBox2.Paste();
            Braille braille10 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4367); Clipboard.SetImage(braille10.getBmp()); richTextBox2.Paste();
            Braille braille11 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4368); Clipboard.SetImage(braille11.getBmp()); richTextBox2.Paste();
            Braille braille12 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4369); Clipboard.SetImage(braille12.getBmp()); richTextBox2.Paste();
            Braille braille13 = new Braille(Braille.KOREAN, Braille.첫소리자음, 4370); Clipboard.SetImage(braille13.getBmp()); richTextBox2.Paste();
        }

        private void 모음Button_Click(object sender, EventArgs e) {
            Braille braille1 = new Braille(Braille.KOREAN, Braille.기본모음, 4449); Clipboard.SetImage(braille1.getBmp()); richTextBox2.Paste();
            Braille braille2 = new Braille(Braille.KOREAN, Braille.기본모음, 4451); Clipboard.SetImage(braille2.getBmp()); richTextBox2.Paste();
            Braille braille3 = new Braille(Braille.KOREAN, Braille.기본모음, 4453); Clipboard.SetImage(braille3.getBmp()); richTextBox2.Paste();
            Braille braille4 = new Braille(Braille.KOREAN, Braille.기본모음, 4455); Clipboard.SetImage(braille4.getBmp()); richTextBox2.Paste();
            Braille braille5 = new Braille(Braille.KOREAN, Braille.기본모음, 4457); Clipboard.SetImage(braille5.getBmp()); richTextBox2.Paste();
            Braille braille6 = new Braille(Braille.KOREAN, Braille.기본모음, 4461); Clipboard.SetImage(braille6.getBmp()); richTextBox2.Paste();
            Braille braille7 = new Braille(Braille.KOREAN, Braille.기본모음, 4462); Clipboard.SetImage(braille7.getBmp()); richTextBox2.Paste();
            Braille braille8 = new Braille(Braille.KOREAN, Braille.기본모음, 4466); Clipboard.SetImage(braille8.getBmp()); richTextBox2.Paste();
            Braille braille9 = new Braille(Braille.KOREAN, Braille.기본모음, 4467); Clipboard.SetImage(braille9.getBmp()); richTextBox2.Paste();
            Braille braille10 = new Braille(Braille.KOREAN, Braille.기본모음, 4469); Clipboard.SetImage(braille10.getBmp()); richTextBox2.Paste();
        }

        private void 이중삼중모음Button_Click(object sender, EventArgs e) {
            Braille braille1 = new Braille(Braille.KOREAN, Braille.기본모음, 4450); Clipboard.SetImage(braille1.getBmp()); richTextBox2.Paste();
            Braille braille2 = new Braille(Braille.KOREAN, Braille.기본모음, 4452); Clipboard.SetImage(braille2.getBmp()); richTextBox2.Paste();
            Braille braille3 = new Braille(Braille.KOREAN, Braille.기본모음, 4454); Clipboard.SetImage(braille3.getBmp()); richTextBox2.Paste();
            Braille braille4 = new Braille(Braille.KOREAN, Braille.기본모음, 4456); Clipboard.SetImage(braille4.getBmp()); richTextBox2.Paste();
            Braille braille5 = new Braille(Braille.KOREAN, Braille.기본모음, 4458); Clipboard.SetImage(braille5.getBmp()); richTextBox2.Paste();
            Braille braille6 = new Braille(Braille.KOREAN, Braille.기본모음, 4459); Clipboard.SetImage(braille6.getBmp()); richTextBox2.Paste();
            Braille braille7 = new Braille(Braille.KOREAN, Braille.기본모음, 4460); Clipboard.SetImage(braille7.getBmp()); richTextBox2.Paste();
            Braille braille8 = new Braille(Braille.KOREAN, Braille.기본모음, 4463); Clipboard.SetImage(braille8.getBmp()); richTextBox2.Paste();
            Braille braille9 = new Braille(Braille.KOREAN, Braille.기본모음, 4464); Clipboard.SetImage(braille9.getBmp()); richTextBox2.Paste();
            Braille braille10 = new Braille(Braille.KOREAN, Braille.기본모음, 4465); Clipboard.SetImage(braille10.getBmp()); richTextBox2.Paste();
            Braille braille11 = new Braille(Braille.KOREAN, Braille.기본모음, 4468); Clipboard.SetImage(braille11.getBmp()); richTextBox2.Paste();
             
        }

        private void 받침자음Button_Click(object sender, EventArgs e) {
            Braille braille1 = new Braille(Braille.KOREAN, Braille.받침자음, 4520); Clipboard.SetImage(braille1.getBmp()); richTextBox2.Paste();
            Braille braille2 = new Braille(Braille.KOREAN, Braille.받침자음, 4523); Clipboard.SetImage(braille2.getBmp()); richTextBox2.Paste();
            Braille braille3 = new Braille(Braille.KOREAN, Braille.받침자음, 4526); Clipboard.SetImage(braille3.getBmp()); richTextBox2.Paste();
            Braille braille4 = new Braille(Braille.KOREAN, Braille.받침자음, 4527); Clipboard.SetImage(braille4.getBmp()); richTextBox2.Paste();
            Braille braille5 = new Braille(Braille.KOREAN, Braille.받침자음, 4535); Clipboard.SetImage(braille5.getBmp()); richTextBox2.Paste();
            Braille braille6 = new Braille(Braille.KOREAN, Braille.받침자음, 4536); Clipboard.SetImage(braille6.getBmp()); richTextBox2.Paste();
            Braille braille7 = new Braille(Braille.KOREAN, Braille.받침자음, 4538); Clipboard.SetImage(braille7.getBmp()); richTextBox2.Paste();
            Braille braille8 = new Braille(Braille.KOREAN, Braille.받침자음, 4540); Clipboard.SetImage(braille8.getBmp()); richTextBox2.Paste();
            Braille braille9 = new Braille(Braille.KOREAN, Braille.받침자음, 4541); Clipboard.SetImage(braille9.getBmp()); richTextBox2.Paste();
            Braille braille10 = new Braille(Braille.KOREAN, Braille.받침자음, 4542); Clipboard.SetImage(braille10.getBmp()); richTextBox2.Paste();
            Braille braille11 = new Braille(Braille.KOREAN, Braille.받침자음, 4543); Clipboard.SetImage(braille11.getBmp()); richTextBox2.Paste();
            Braille braille12 = new Braille(Braille.KOREAN, Braille.받침자음, 4544); Clipboard.SetImage(braille12.getBmp()); richTextBox2.Paste();
            Braille braille13 = new Braille(Braille.KOREAN, Braille.받침자음, 4545); Clipboard.SetImage(braille13.getBmp()); richTextBox2.Paste();
            Braille braille14 = new Braille(Braille.KOREAN, Braille.받침자음, 4546); Clipboard.SetImage(braille14.getBmp()); richTextBox2.Paste();
        }

        private void clearTextboxButton_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        // 디버그 모드일때 화면에 메시지를 뿌려주는 함수
        // 영어 선택하면 "영어가 선택되었습니다, 한글이면 한글이 선택되었어요 따위..
        public void setMessage(string message) {
            if (this.mode == DEBUG_MODE) {
                brailleDisplayForm.setMessage(message);
            }
            else if (this.mode == NORMAL_MODE) {
                // 아무 메시지를 출력하지 않는다.
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            richTextBox2.Clear();
            string text = richTextBox1.Text;
            text = text.Trim();

            // 아무 글자가 없을때 클릭하면 메세지 띄우기
            if ((text == null) || (text == ""))
            {
                timer1.Stop();
                //MessageBox.Show("변환할 글자가 없습니다.");
                return;
            }
            // 영문으로 해놓고 한글을 타이핑한다거나, 
            // 한글로 해놓고 영문으로 타이핑할때 에러
            // 아무튼 뭔가 합당한 글자는 있다!
            else
            {
                tick++;
                //setMessage(Convert.ToString(tick));
                if (tick == 5) {
                    tick = 0;
                    //timer1.Stop();
                    ch2braille(text);
                    richTextBox1.AppendText("\n");
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Clear();
                }
            }
        }

        private void manualRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (autoRadioButton.Checked)
            {
                Braille.selectedConvOption = Braille.AUTO_CONV;
                setMessage("자동 모드 전환\n");
                timer1.Start();
                //1초 있다 바꾸고 리플레쉬, 클리어
                timer1.Tick += new EventHandler(timer1_Tick);
            }
            else if (manualRadioButton.Checked) {
                Braille.selectedConvOption = Braille.MANUAL_CONV;
                setMessage("수동 모드 전환\n");
                timer1.Stop();
            }            
        }

        private void langEngRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (langEngRadioButton.Checked)
            {
                Braille.selectedLanguage = Braille.ENGLISH;
                setMessage("영어로 전환\n");
            }
            else if (langKorRadioButton.Checked)
            {
                Braille.selectedLanguage = Braille.KOREAN;
                setMessage("한국어로 전환\n");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Braille.selectedConvOption != Braille.MANUAL_CONV)
            {
                timer1.Start();
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox2.Clear();
                string text = richTextBox1.Text;
                text = text.Trim();
                // 아무 글자가 없을때 클릭하면 메세지 띄우기
                if ((text == null) || (text == ""))
                {
                    MessageBox.Show("변환할 글자가 없습니다.");
                    return;
                }
                // 영문으로 해놓고 한글을 타이핑한다거나, 
                // 한글로 해놓고 영문으로 타이핑할때 에러
                // 아무튼 뭔가 합당한 글자는 있다!
                else
                {
                    ch2braille(text);
                    richTextBox1.AppendText("\n");
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Clear();
                }
            }
        }

    }



}
