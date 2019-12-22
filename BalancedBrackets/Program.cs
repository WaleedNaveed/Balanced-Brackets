using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        public string[] isBracketsBalanced(string[] values)
        {
            string[] result = new string[values.Length];
            int resultIndex = 0;

            Stack<char> s = new Stack<char>();
            for(int i = 0; i < values.Length; i++)
            {
                string testString = values[i];
                for(int j = 0; j < testString.Length; j++)
                {
                    if(testString[j] == '(' || testString[j] == '{' || testString[j] == '[')
                    {
                        s.Push(testString[j]);
            //            continue;
                    }

                    else if(testString[j] == ')')
                    {
                        if (s.Pop() == '(')
                        {

                        }
              //              continue;
                        else
                        {
                            result[resultIndex] = "No";
                            resultIndex--;
                            break;
                        }
                    }
                    else if (testString[j] == '}')
                    {
                        if (s.Pop() == '{')
                        {

                        }
                            //continue;
                        else
                        {
                            result[resultIndex] = "No";
                            resultIndex--;
                            break;
                        }
                    }
                    else if (testString[j] == ']')
                    {
                        if (s.Pop() == '[')
                        {

                        }
                            //continue;
                        else
                        {
                            result[resultIndex] = "No";
                            resultIndex--;
                            break;
                        }
                    }
                    if(j == testString.Length - 1)
                    {
                        result[resultIndex] = "Yes";
                        resultIndex++;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            string[] testSting = new string[] {"(){}[]({[]})({{[[]]}})", "[{}({})}" };
            string[] resultString = obj.isBracketsBalanced(testSting);
            foreach (var item in resultString)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
