using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace BrailleApplication
{
    public partial class Braille {
        public static int selectedLanguage= KOREAN; // 기본 설정, 한국어
        public static int selectedConvOption = MANUAL_CONV; // 수동 변환 (엔터 입력)

        public static int KOREAN= 10;
        public static int ENGLISH = 20;
        public static int BIG = 30; // 대문자
        public static int SMALL = 40; // 소문자

        public static int AUTO_CONV = 50;
        public static int MANUAL_CONV = 60;

        public const int 첫소리자음 = 10;
        public const int 기본모음 = 20;
        public const int 받침자음 = 30;
        public const int 약어 = 40;
        public const int 약자 = 50;

        public const int CHOSUNG_MAX = 19; // 초성수 
        public const int JUNGSUNG_MAX = 21; // 중성
        public const int JONGSUNG_MAX = 28; // 종성수

        // 유니코드체계에서 한글은 십진수로 44032 ∼ 55204이다.
        // 따라서 55204 - 44032 = 11172 글자이다.
        // 위츼 초성*중성*종성= 19*21*28= 11172 글자임을 알수 있다.
        public const int UNICODE_HANGUL_START_ADDR = 0xac00; // 44032
        public const int UNICODE_HANGUL_END_ADDR = 0xD7A3; // 55204

        public const int CHOSUNG_START_ADDR = 0x1100;
        public const int JUNGSUNG_START_ADDR = 0x1161;
        public const int JONGSUNG_START_ADDR = 0x11a7;

        Image[] pointImageArr;
        private Bitmap back;

        //private int choSung;
        //private int jungSung;
        //private int jongSung;
        //private int alphaCh; // 알파벳의 경우
        //private PictureBox pictureBox; // 이미지를 저장할 픽처박스

        //private bool isSingle; // 단일점자인가? dual 점자인가?
        //private bool isAcronym; // 약어인가?
        //private int language; //언어 종류는
        private int kind = 0; // 자음, 받침, 모음, 약자, 등..
        private int value = 0; // ㄱ,ㄴ,ㄷ,.. ㅏ,ㅑ,ㅓ,ㅕ...등


        private int error;
        private int ext;
       
        public void setKind(int kind)
        {
            this.kind = kind;
        }
        public int getKind()
        {
            return this.kind;
        }

        public void setValue(int value)
        {
            this.value= value;
        }
        public int getValue()
        {
            return this.value;
        }

        public int getError()
        {
            return this.error;
        }

        public void setExt(int ext) { this.ext = ext; }
        public int getExt() { return this.ext; }

        public void setBmp(Bitmap bitmap)
        {
            this.back = bitmap;
        }
        public Image getBmp()
        {
            return this.back;
        }

        public const int START_ENGLISH_CODE= 10;
        public const int END_ENGLISH_CODE = 11;

        // 영어는 초중종성이 필요없어 kind가 없다.
        public Braille(int lang, int value) {
            setValue(value);

            engExtract(Convert.ToChar(value));
            this.error = 0;
            this.ext = 0;

            switch (value)
            {
                case START_ENGLISH_CODE: setBrailleBmp(0x34); break;
                case END_ENGLISH_CODE: setBrailleBmp(0x32); break;

                case 'A': setBrailleBmp(0x01); break;
                case 'B': setBrailleBmp(0x03); break;
                case 'C': setBrailleBmp(0x09); break;
                case 'D': setBrailleBmp(0x19); break;
                case 'E': setBrailleBmp(0x11); break;
                case 'F': setBrailleBmp(0x0B); break;
                case 'G': setBrailleBmp(0x1B); break;
                case 'H': setBrailleBmp(0x13); break;
                case 'I': setBrailleBmp(0x0A); break;
                case 'J': setBrailleBmp(0x1A); break;
                case 'K': setBrailleBmp(0x05); break;
                case 'L': setBrailleBmp(0x07); break;
                case 'M': setBrailleBmp(0x0D); break;
                case 'N': setBrailleBmp(0x1D); break;
                case 'O': setBrailleBmp(0x15); break;
                case 'P': setBrailleBmp(0x0F); break;
                case 'Q': setBrailleBmp(0x1F); break;
                case 'R': setBrailleBmp(0x17); break;
                case 'S': setBrailleBmp(0x0E); break;
                case 'T': setBrailleBmp(0x1E); break;
                case 'U': setBrailleBmp(0x25); break;
                case 'V': setBrailleBmp(0x27); break;
                case 'W': setBrailleBmp(0x3A); break;
                case 'X': setBrailleBmp(0x2D); break;
                case 'Y': setBrailleBmp(0x3D); break;
                case 'Z': setBrailleBmp(0x35); break;

                case 'a': setBrailleBmp(0x01); break;
                case 'b': setBrailleBmp(0x03); break;
                case 'c': setBrailleBmp(0x09); break;
                case 'd': setBrailleBmp(0x19); break;
                case 'e': setBrailleBmp(0x11); break;
                case 'f': setBrailleBmp(0x0B); break;
                case 'g': setBrailleBmp(0x1B); break;
                case 'h': setBrailleBmp(0x13); break;
                case 'i': setBrailleBmp(0x0A); break;
                case 'j': setBrailleBmp(0x1A); break;
                case 'k': setBrailleBmp(0x05); break;
                case 'l': setBrailleBmp(0x07); break;
                case 'm': setBrailleBmp(0x0D); break;
                case 'n': setBrailleBmp(0x1D); break;
                case 'o': setBrailleBmp(0x15); break;
                case 'p': setBrailleBmp(0x0F); break;
                case 'q': setBrailleBmp(0x1F); break;
                case 'r': setBrailleBmp(0x17); break;
                case 's': setBrailleBmp(0x0E); break;
                case 't': setBrailleBmp(0x1E); break;
                case 'u': setBrailleBmp(0x25); break;
                case 'v': setBrailleBmp(0x27); break;
                case 'w': setBrailleBmp(0x3A); break;
                case 'x': setBrailleBmp(0x2D); break;
                case 'y': setBrailleBmp(0x3D); break;
                case 'z': setBrailleBmp(0x35); break;
                default: setBrailleBmp(0x00); break;
            }
        }

        // new Braille(Braille.KOREAN, Braille.첫소리자음, 'ㄱ');
        // new Braille(Braille.KOREAN, Braille.약어, '가');
/*        
        public Braille(int lang, int kind, char ch) { 
            //this.kind = kind;
            setValue(value);
            extract(Convert.ToChar(value));
            this.error = 0;
            //this.ext = 0;
            setExt(0); 
            setKind(kind);

            //if (getKind() == Braille.약어) {
            if (kind == 약어) {
                setExt(1); // qqq setExt(Braille.Ext);
                switch (ch)
                {
                    case '가': setBrailleBmp(0x2B); break;
                    default: setBrailleBmp(0x08); break;
                }
            }
        }
*/        
        
        public Braille(int lang, int kind, int value) { 
            setValue(value);
            extract(Convert.ToChar(value));
            this.error = 0;
            setExt(0); // 약어가 아님
            //this.ext = 0;
            setKind(kind);
            if (kind == 첫소리자음) {
                switch (value)
                {
                    case 4352: setBrailleBmp(0x08); break;
                    case 4354: setBrailleBmp(0x09); break;
                    case 4355: setBrailleBmp(0x0A); break;
                    case 4357: setBrailleBmp(0x10); break;
                    case 4358: setBrailleBmp(0x11); break;
                    case 4359: setBrailleBmp(0x18); break;
                    case 4361: setBrailleBmp(0x20); break;
                    case 4364: setBrailleBmp(0x28); break;
                    case 4366: setBrailleBmp(0x30); break;
                    case 4367: setBrailleBmp(0x0B); break;
                    case 4368: setBrailleBmp(0x13); break;
                    case 4369: setBrailleBmp(0x19); break;
                    case 4370: setBrailleBmp(0x1A); break;
                    default: setBrailleBmp(0x00); break;
                }

            }
            else if (kind == 기본모음)
            {
                switch (value)
                {
                    case 4449: setBrailleBmp(0x23); break;
                    case 4451: setBrailleBmp(0x1C); break;
                    case 4453: setBrailleBmp(0x0E); break;
                    case 4455: setBrailleBmp(0x31); break;
                    case 4457: setBrailleBmp(0x25); break;
                    case 4461: setBrailleBmp(0x2C); break;
                    case 4462: setBrailleBmp(0x0D); break;
                    case 4466: setBrailleBmp(0x29); break;
                    case 4467: setBrailleBmp(0x2A); break;
                    case 4469: setBrailleBmp(0x15); break;
                    // 이중 삼중모음
                    case 4450: setBrailleBmp(0x17); break;
                    case 4452: setBrailleBmp(0x1C); break; // setBrailleBmp(0x17); ㅒ
                    case 4454: setBrailleBmp(0x1D); break;
                    case 4456: setBrailleBmp(0x0C); break;
                    case 4458: setBrailleBmp(0x27); break;
                    case 4459: setBrailleBmp(0x27); break; // setBrailleBmp(0x17); ㅙ
                    case 4460: setBrailleBmp(0x3D); break;
                    case 4463: setBrailleBmp(0x0F); break;
                    case 4464: setBrailleBmp(0x0F); break; // setBrailleBmp(0x17); ㅞ
                    case 4465: setBrailleBmp(0x0D); break; // setBrailleBmp(0x17); ㅟ
                    case 4468: setBrailleBmp(0x3A); break;
                    default: setBrailleBmp(0x00); break;
                }
            }
            else if (kind == 받침자음)
            {
                switch (value)
                {
                    case 4520: setBrailleBmp(0x01); break;
                    case 4523: setBrailleBmp(0x12); break;
                    case 4526: setBrailleBmp(0x14); break;
                    case 4527: setBrailleBmp(0x02); break;
                    case 4535: setBrailleBmp(0x22); break;
                    case 4536: setBrailleBmp(0x03); break;
                    case 4538: setBrailleBmp(0x04); break;
                    case 4540: setBrailleBmp(0x36); break;
                    case 4541: setBrailleBmp(0x05); break;
                    case 4542: setBrailleBmp(0x06); break;
                    case 4543: setBrailleBmp(0x16); break;
                    case 4544: setBrailleBmp(0x26); break;
                    case 4545: setBrailleBmp(0x32); break;
                    case 4546: setBrailleBmp(0x34); break;
                    case 4519: setBrailleBmp(0x00); break;
                    default: setBrailleBmp(0x00); break;
                }
            }
        }

        public void setBrailleBmp(int value) {
            // 이미지 병합 예제 코드
            // http://stackoverflow.com/questions/6383123/merge-two-images-to-create-a-single-image-in-c-net
            Bitmap outputImage= null;
            Graphics graphics = null;

            pointImageArr = new Image[6];
            pointImageArr[0] = Properties.Resources.point_1;
            pointImageArr[1] = Properties.Resources.point_2;
            pointImageArr[2] = Properties.Resources.point_3;
            pointImageArr[3] = Properties.Resources.point_4;
            pointImageArr[4] = Properties.Resources.point_5;
            pointImageArr[5] = Properties.Resources.point_6;

            // ㅒ, ㅙ, , ㅞ ㅟ 인경우에만 이미지를 두개 병합한다.
            if ((value == 0x1C) || (value == 0x27) || (value == 0x0F) || (value == 0x0D)) {
                Bitmap bitmap = new Bitmap(Properties.Resources.back.Width*2, Properties.Resources.back.Height, PixelFormat.Format32bppArgb);
                outputImage = new Bitmap(Properties.Resources.back.Width*2, Properties.Resources.back.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                graphics= Graphics.FromImage(outputImage);
                for (int i = 0; i < 6; i++) {
                    if ((value & ((int)(Math.Pow(2, i)))) == (int)(Math.Pow(2, i))) {
                        graphics.DrawImage(pointImageArr[i], new Point(0, 0));
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    if ((0x17 & ((int)(Math.Pow(2, j)))) == (int)(Math.Pow(2, j)))
                    {
                        graphics.DrawImage(pointImageArr[j], new Point(30, 0));
                    }
                }
            }
            else {
                Bitmap bitmap = new Bitmap(Properties.Resources.back.Width, Properties.Resources.back.Height, PixelFormat.Format32bppArgb);
                outputImage = new Bitmap(Properties.Resources.back.Width, Properties.Resources.back.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                graphics = Graphics.FromImage(outputImage);

                for (int i = 0; i < 6; i++) {
                    if ((value & ((int)(Math.Pow(2, i)))) == (int)(Math.Pow(2, i))) {
                        graphics.DrawImage(pointImageArr[i], new Point(0, 0));
                    }
                }
            }

            setBmp(outputImage); // qqq

            pointImageArr[0].Dispose();
            pointImageArr[1].Dispose();
            pointImageArr[2].Dispose();
            pointImageArr[3].Dispose();
            pointImageArr[4].Dispose();
            pointImageArr[5].Dispose();

            graphics.Dispose();

            //return outputImage;
        }


        public string toString() {
            //return Convert.ToString(alphaCh);
            //return "110001 'ㅏ'";
            return Convert.ToString(getValue());
        }

        /// <summary>
        /// 한글인지 체크(문자열 전부 한글인지)
        /// </summary>
        /// <param name="한글"></param>
        /// <returns></returns>
        private static bool IsHangul(string hangul)
        {
            bool rtnval = false;
            for (int i = 0; i < hangul.Length; i++)
            {
                if (UNICODE_HANGUL_START_ADDR <= hangul[i] && hangul[i] <= UNICODE_HANGUL_END_ADDR)
                {
                    rtnval = true;
                }
                else
                {
                    rtnval = false;
                    break;
                }
            }
            return rtnval;
        }

        /// <summary>
        /// 한글인지 체크
        /// </summary>
        /// <param name="한글"></param>
        /// <returns></returns>
        private static bool IsHangul(char ch)
        {
            if (UNICODE_HANGUL_START_ADDR <= ch && ch <= UNICODE_HANGUL_END_ADDR)
            {
                return true;
            }
            return false;
        }

        /*
         * 문자를 점자로 변환해 주는 함수
         */
        public static char[] extract(char ch) {
            
            int tmpCh = 0;
            tmpCh = ch - UNICODE_HANGUL_START_ADDR;
            int chosung = tmpCh / (JUNGSUNG_MAX * JONGSUNG_MAX); // 0-18까지 초성이 나온다.
            int jungsung = (tmpCh % (JUNGSUNG_MAX * JONGSUNG_MAX) / JONGSUNG_MAX);
            int jongsung = (tmpCh % JONGSUNG_MAX);

            char[] charArr = new char[3]; // null;
            if (IsHangul(ch))
            {
                int x = ch - UNICODE_HANGUL_START_ADDR;
                charArr[0] = (char)(CHOSUNG_START_ADDR + x / (JUNGSUNG_MAX * JONGSUNG_MAX));
                charArr[1] = (char)(JUNGSUNG_START_ADDR + (x % (JUNGSUNG_MAX * JONGSUNG_MAX)) / JONGSUNG_MAX);
                charArr[2] = (char)(JONGSUNG_START_ADDR + x % JONGSUNG_MAX);
            }
            /*
            Console.WriteLine("");
            Console.WriteLine("초성 : " + rtnval[0] + Convert.ToInt32(rtnval[0]));
            Console.WriteLine("중성 : " + rtnval[1] + Convert.ToInt32(rtnval[1]));
            Console.WriteLine("종성 : " + rtnval[2] + Convert.ToInt32(rtnval[2]));
            */
            return charArr;
        }

        // 영어는 차암 편하구나..
        public static char engExtract(char ch) {
            return ch;
        }

        //private string chArr;
        //http://secr.tistory.com/207
        // 지역화 http://donggas90.blog.me/100167743753
        // http://thdwlgnsdl10.blog.me/40063114545
    }
}
