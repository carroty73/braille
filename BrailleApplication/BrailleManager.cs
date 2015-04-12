using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace BrailleApplication
{
    class BrailleManagerOld {

        public const int ENGLISH = 10;
        public const int KOREAN = 20;
        public const int NUMBER = 30;

        public const int ALPHABET_MAX= 26;
        public const int NUMBER_MAX= 10;
        //private int length;

        /*
        public int getLength() {
            return this.length;
        }
        */
        //ArrayList brailleArrayList; // 이미 갖고 있는 점자 체계
        //ArrayList translatedBrailleArrayList; // 변환된 돌려줄 점자 체계

        //Braille[] braille_point;
        Braille[] 첫소리자음배열; // 위의 6개의 점자 포인트를 기반으로 점자 일람표(ㄱ,ㄴ,ㄷ...) 배열
        Braille[] 받침자음배열;
        Braille[] 기본모음배열;
        Braille[] 이중삼중모음배열;

        public BrailleManagerOld() {
            /*
            braille_point = new Braille[6];
            braille_point[0] = new Braille(0, 0x80);
            braille_point[1] = new Braille(0, 0x80);
            braille_point[2] = new Braille(0, 0x80);
            braille_point[3] = new Braille(0, 0x80);
            braille_point[4] = new Braille(0, 0x80);
            braille_point[5] = new Braille(0, 0x80);

            braille_point[0].setCode(5);
            braille_point[0].setCode(4);
            braille_point[0].setCode(3);
            braille_point[0].setCode(2);
            braille_point[0].setCode(1);
            braille_point[0].setCode(0);

            ((Braille)(braille_point[0])).setImage(Properties.Resources.point_1);
            ((Braille)(braille_point[1])).setImage(Properties.Resources.point_2);
            ((Braille)(braille_point[2])).setImage(Properties.Resources.point_3);
            ((Braille)(braille_point[3])).setImage(Properties.Resources.point_4);
            ((Braille)(braille_point[4])).setImage(Properties.Resources.point_5);
            ((Braille)(braille_point[5])).setImage(Properties.Resources.point_6);
            */

            첫소리자음배열   = new Braille[14];
            받침자음배열     = new Braille[14];
            기본모음배열     = new Braille[10];
            이중삼중모음배열 = new Braille[11];
            /*
            첫소리자음배열[0]  = new Braille(Braille.첫소리자음, 'ㄱ');
            첫소리자음배열[1] = new Braille(Braille.첫소리자음, 'ㄴ');
            첫소리자음배열[2] = new Braille(Braille.첫소리자음, 'ㄷ');
            첫소리자음배열[3] = new Braille(Braille.첫소리자음, 'ㄹ');
            첫소리자음배열[4] = new Braille(Braille.첫소리자음, 'ㅁ');
            첫소리자음배열[5] = new Braille(Braille.첫소리자음, 'ㅂ');
            첫소리자음배열[6] = new Braille(Braille.첫소리자음, 'ㅅ');
            첫소리자음배열[7] = new Braille(Braille.첫소리자음, 'ㅇ');
            첫소리자음배열[8] = new Braille(Braille.첫소리자음, 'ㅈ');
            첫소리자음배열[9] = new Braille(Braille.첫소리자음, 'ㅊ');
            첫소리자음배열[10] = new Braille(Braille.첫소리자음, 'ㅋ');
            첫소리자음배열[11] = new Braille(Braille.첫소리자음, 'ㅌ');
            첫소리자음배열[12] = new Braille(Braille.첫소리자음, 'ㅍ');
            첫소리자음배열[13] = new Braille(Braille.첫소리자음, 'ㅎ');
            */
            /*
            BrailleApplication.BrailleDisplayForm.add
            Form1
            brailleDisplayForm.add(첫소리자음배열[0]);
            brailleDisplayForm.add(첫소리자음배열[1]);
            brailleDisplayForm.add(첫소리자음배열[2]);
            brailleDisplayForm.add(첫소리자음배열[3]);
            brailleDisplayForm.add(첫소리자음배열[4]);
             * */
        }

        // 점자를 문자로 바꾸어주는 함수, 아직 못만듦
        public string braille2text(Braille[] brailleArr)
        {
            return null;
        }
/*
        // 들어오는 문자하나(정수형)를 Braille 하나로 만들어줌
        public Braille createBraille(int index) {
            //int index= Convert.ToInt32(brailleStr);
            //return numBrailleArr[index];
            if (index > 48) { index = index - 39; }
            //return (Braille)(brailleArrayList[index]);
            return (Braille)(braille_point[0]); // qqq
        }
*/
        public Braille create(int kind, int value) {
            Braille tmpBraille;//= new Braille(첫소리자음, 'ㄴ');
            if (kind == 0)
            {
                switch (value)
                {
                    case 'ㄱ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄱ'); break; //.setValue(0x08); break;
                    case 'ㄴ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄴ'); break; //tmpBraille.setCode(0x09); break;
                    case 'ㄷ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄷ'); break; //tmpBraille.setCode(0x0A); break;
                    case 'ㄹ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄹ'); break; //tmpBraille.setCode(0x10); break;
                    case 'ㅁ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅁ'); break; //tmpBraille.setCode(0x11); break;
                    case 'ㅂ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅂ'); break; //tmpBraille.setCode(0x18); break;
                    case 'ㅅ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅅ'); break; //tmpBraille.setCode(0x20); break;
                    case 'ㅇ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅇ'); break; //tmpBraille.setCode(0x1B); break;
                    case 'ㅈ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅈ'); break; //tmpBraille.setCode(0x28); break;
                    case 'ㅊ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅊ'); break; //tmpBraille.setCode(0x30); break;
                    case 'ㅋ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅋ'); break; //tmpBraille.setCode(0x23); break;
                    case 'ㅌ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅌ'); break; //tmpBraille.setCode(0x13); break;
                    case 'ㅍ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅍ'); break; //tmpBraille.setCode(0x19); break;
                    case 'ㅎ': tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㅎ'); break; //tmpBraille.setCode(0x1A); break;
                    default: tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄱ'); break; //tmpBraille.setCode(0x80); break;
                }
            }
            else
            {
                tmpBraille = new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄱ');
            }
            return tmpBraille;
        }

/*        
        // 들어오는 문자를 점자로 바꾸어줌
        public ArrayList text2braille(string strArr) {
            this.length= strArr.Length;
            char[] charArr = (strArr.Trim()).ToCharArray();
            ArrayList translatedBrailleArrayList = new ArrayList();
            //int index = Convert.ToInt32(charArr[0])-48;

            for (int i = 0; i < strArr.Length; i++) { // 요긴 나중에 좀 고쳐야 함, 영문은 문자1개=점자1개인데, 한글은 한문자=6점자일수도 있어서..
                //Console.WriteLine("new Braille : " + charArr[i]);
                //numBrailleArr[i] = getBraille(Convert.ToString(i));
                //brailleArrayList[i] = getBraille(Convert.ToString(i));
                //brailleArrayList.Add(getBraille(Convert.ToString(i)));
                //translatedBrailleArrayList.Add(getBraille(index++));
                //translatedBrailleArrayList.Add(createBraille(0, charArr[i]-48));
                translatedBrailleArrayList.Add(new Braille(Braille.첫소리자음, 'ㄱ'));
            }
            translatedBrailleArrayList.TrimToSize();
            return translatedBrailleArrayList;
        }
*/        




    }
}
