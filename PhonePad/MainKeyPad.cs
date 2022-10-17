using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePad
{
    public class MainKeyPad
    {
        public static String OldPhonePad(string inputString)
        {

            char[] arr = inputString.ToCharArray(0, inputString.Length);
            List<char> resultCh = new List<char>();
            var charList = NumberMapCharList.list;
            NumberMapChar numberMap = null;

            int countChar = 0;
            char currentCh = ' ';
            char previousCh = ' ';
            foreach (char c in arr)
            {
                currentCh = c;
                if (c == '#')
                {

                    /***For the last character***/
                    if (countChar != 0 && previousCh != '*')
                    {
                        assignValue();
                    }
                    break;
                }
                else if (currentCh == '*')
                {
                    //Assign last value if exist.
                    assignValue();
                    if (resultCh.Any())
                    {
                        resultCh.RemoveAt(resultCh.Count - 1);
                        previousCh = currentCh;
                    }
                    else
                    {
                        //initial state
                        countChar = 0;
                        previousCh = ' ';
                    }
                    continue;
                }
                else
                {
                    if (previousCh == ' ')
                    {
                        previousCh = currentCh;
                    }

                    if (previousCh != ' ' && previousCh == currentCh)
                        ++countChar;
                    else
                    {
                        assignValue();
                        previousCh = currentCh;
                        /***Initial state everytime when we recieve empty value***/
                        countChar = previousCh == ' ' ? 0 : 1;

                    }

                }



            }

            return string.Join("", resultCh);


            void assignValue()
            {
                numberMap = charList.FirstOrDefault(x => x.key == previousCh);
                if (numberMap != null)
                {
                    /***If user press more than maximium of possible value, find the value by iterative retrieve ***/
                    int indexCh = countChar % numberMap.chars.Length;
                    resultCh.Add(numberMap.chars[indexCh == 0 ? numberMap.chars.Length - 1 : indexCh - 1]);
                }
            }
        }
    }
}
