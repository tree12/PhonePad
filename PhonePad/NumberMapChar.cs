using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePad
{
    public class NumberMapChar
    {
        public char key { get; set; }
        public char[] chars { get; set; }
    }
    public class NumberMapCharList
    {

        public static List<NumberMapChar> list => numberMapChars();

        public static List<NumberMapChar> numberMapChars()
        {
            return new List<NumberMapChar>() {
                    new NumberMapChar(){
                        key = '0',
                        chars = new char[1]{' ' }
                    },
                    new NumberMapChar(){
                        key = '1',
                        chars = new char[3]{'&','\'','(' }
                    },
                    new NumberMapChar(){
                        key = '2',
                        chars = new char[3]{'A','B','C' }
                    },
                    new NumberMapChar(){
                        key = '3',
                        chars = new char[3]{'D','E','F' }
                    },
                    new NumberMapChar(){
                        key = '4',
                        chars = new char[3]{'G','H','I' }
                    },
                    new NumberMapChar(){
                        key = '5',
                        chars = new char[3]{'J','K','L' }
                    },
                    new NumberMapChar(){
                        key = '6',
                        chars = new char[3]{'M','N','O' }
                    },
                    new NumberMapChar(){
                        key = '7',
                        chars = new char[4]{'P','Q','R','S' }
                    },
                    new NumberMapChar(){
                        key = '8',
                        chars = new char[3]{'T','U','V' }
                    },
                    new NumberMapChar(){
                        key = '9',
                        chars = new char[4]{'W','X','Y','Z' }
                    }
            };


        }
    }
}
