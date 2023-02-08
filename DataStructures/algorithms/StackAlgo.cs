using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.algorithms
{
    internal class StackAlgo
    {
        // define algorithms functions of stack
        // balanced parantheses algorithm using stack :
        static private bool _IsPaired(char?a, char b) {
            if(a == '(' && b == ')') return true;
            else if(a == '{' && b == '}') return true;
            else if(a == '[' && b == ']') return true;
            return false;
        }

        static public bool IsBalancedParanthases(string s)
        {
            // define a stack to push openning parantheses in
            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if(c == '(' || c== '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if(c == ')' || c == '}' || c == ']')
                {
                    if(stack.Count ==0 || !_IsPaired(stack.Peek() , c)) return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        // infix and prefix and postfix
        // expression evaluation
        // 5 + 2 compiled as 5 2 + and so on as a postfix
        // used stack to make the evaluation
        // see it later when you study
    }
}
