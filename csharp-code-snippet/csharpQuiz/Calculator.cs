using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQuiz
{
    /*
    *  계산기를 만드는 것의 핵심은 주어진 식을 후행식으로 표현하고 
    *  후행식 을 계산하는 법을 구현하면 된다. 
    * 
    * 후행식 : 2 + 3 * 7 : 237*+ 
    *         (1 + 2 * 3 ) / 7 = 12*3*7/
    * 피연산자와 연산자는 공백으로 구분되어있다고 생각.
    */
    class Calculator
    {
        private List<string> tokenList = new List<string>();
        private Stack<string> opStack = new Stack<string>();
        private Stack<double> numStack = new Stack<double>();
        private List<char> tempList = new List<char>();
        private List<string> postNotaionList = new List<string>();
         
        public static void Main(string[] args)
        {
            Console.Write("input");
            string expr = Console.ReadLine();
            Calculator calc = new Calculator();
            calc.Solve(expr);
            Console.ReadLine();
        }

        public void Solve(string expr)
        {
            Tokenize(expr);
            PostNotation();
            Calc();
        }

        private void Calc()
        {
            for (int i = 0; i < postNotaionList.Count; i++)
            {
                double n;
                if (Double.TryParse(postNotaionList[i], out n) == false)
                {
                    double num2 = numStack.Pop();
                    double num1 = numStack.Pop();
                    switch (postNotaionList[i])
                    {
                        case "+":
                            numStack.Push(num1 + num2);
                            break;
                        case "-":
                            numStack.Push(num1 - num2);
                            break;
                        case "*":
                            numStack.Push(num1 * num2);
                            break;
                        case "/":
                            numStack.Push(num1 / num2);
                            break;
                    }
                } else
                {
                    numStack.Push(Double.Parse(postNotaionList[i]));
                }
            }
            Console.Out.WriteLine("The result : " + numStack.Pop());
        }
        

        private void PostNotation()
        {
            for(int i = 0; i < tokenList.Count; i++)
            {
                double num = 0.0;
                if(Double.TryParse(tokenList[i],out num))
                {
                    postNotaionList.Add(tokenList[i]);
                } else
                {
                    if(opStack.Count == 0)
                    {
                        opStack.Push(tokenList[i]);
                    } else
                    {
                        if (tokenList[i].Equals(")"))
                        {
                            while(opStack.Count > 0 )
                            {
                                if (!opStack.Peek().Equals("("))
                                {
                                    postNotaionList.Add(opStack.Pop());
                                } else
                                {
                                    opStack.Pop();
                                }
                            }
                        } else if (tokenList[i].Equals("("))
                        {
                            opStack.Push(tokenList[i]);
                        }
                        else
                        {
                            int checkResult = CheckLevel(tokenList[i], opStack.Peek());
                            if (checkResult == 1)
                            {
                                opStack.Push(tokenList[i]);
                            } else
                            {
                                while(opStack.Count > 0 &&  (checkResult == -1 || checkResult == 0))
                                {
                                    postNotaionList.Add(opStack.Pop());
                                }
                                opStack.Push(tokenList[i]);
                            }
                        }
                    }
                }
            }

            while(opStack.Count > 0)
            {
                postNotaionList.Add(opStack.Pop());
            }
            int x = 0;
        }


        private int CheckLevel(string op1, string op2 )
        {
            if(GetLevel(op1) > GetLevel(op2))
            {
                return 1;
            } else if(GetLevel(op1) < GetLevel(op2))
            {
                return -1;
            } else
            {
                return 0;
            }

        }

        private int GetLevel(string s)
        {
            switch(s)
            {
                case "(":
                    return 1;
                    break;
                case "+":
                    return 2;
                    break;
                case "-":
                    return 2;
                    break;
                case "*":
                    return 3;
                    break;
                case "/":
                    return 3;
                    break;
                default:
                    return 1;
                    break;
            }
        }

        private void Tokenize(string expr)
        {
            expr = expr.Replace(" ", "");

            foreach (char ch in expr)
            {
                if (ch == '('){
                    tokenList.Add(ch.ToString());
                } else
                {
                    if (isOperand(ch) || ch==')')
                    {
                        AddTokenList();
                        tokenList.Add(ch.ToString());
                    } else
                    {
                        tempList.Add(ch);
                    }
                }
            }
            AddTokenList();
            
        }

        private bool isOperand(char ch)
        {
            if(ch== '/'||  ch == '*'  || ch == '+' || ch == '-')
            {
                return true;
            }
            return false;
        }

        private void AddTokenList()
        {
            if (tempList.Count > 0)
            {
                char[] tempCharArr = new char[tempList.Count];
                for (int i = 0; i < tempList.Count; i++)
                {
                    tempCharArr[i] = tempList[i];
                }
                tempList.Clear();
                string s = new string(tempCharArr);
                tokenList.Add(s);
            }
            
            
        }
            
    }
}
