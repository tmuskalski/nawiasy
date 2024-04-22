using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSONS.Ex01
{
    public static class Bracets
    {
        private static List<char> startbracets =new List<char>();
        private static List<char> endbracets = new List<char>();
        private static string xpr;
        private static void fillBracets(int mode)
        {
            switch (mode)
            {
                case 0:
                    startbracets.Add('{');
                    startbracets.Add('(');
                    startbracets.Add('[');
                    break;
                case 1:
                    endbracets.Add('}');
                    endbracets.Add(')');
                    endbracets.Add(']');
                    break ;
                default:
                    break;
            }
            
        }

        public static void CheckBracetsInString(string expr)
        {
            fillList();
            xpr = expr;
            if (validateBrackets())
            {
                Console.WriteLine($"Wyreażenie {xpr} jest ok!");

            }
            else
            {
                Console.WriteLine($"Wyreażenie {xpr} nie jest ok!");
                
            }
            Console.ReadLine();
        }

        private static bool validateBrackets()
        {
            Stack<int> stack = new Stack<int>();
            foreach (char c in xpr)
            {
                if (startbracets.Contains(c))
                {
                    stack.Push(1);
                }
                else if(endbracets.Contains(c))
                {
                    if(stack.Count == 0) { return false; }
                    stack.Pop();
                }
                
            }

            if (stack.Count == 0)
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            }
        }

        private static void fillList()
        {
            fillBracets(0);
            fillBracets(1);
        }
    }
}
