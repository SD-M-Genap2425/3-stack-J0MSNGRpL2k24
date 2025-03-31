using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    


    public class Node
    {
        public char Data { get; set; }
        public Node? Next { get; set; }

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    public class BracketValidator
    {
        private Node? top;

        public BracketValidator()
        {
            top = null;
        }

        private void Push(char data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        private char Pop()
        {
            if (top == null)
                return '\0';

            char data = top.Data;
            top = top.Next;
            return data;
        }

        private bool IsEmpty()
        {
            return top == null;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char popped = Pop();
                    if ((ch == ')' && popped != '(') ||
                        (ch == '}' && popped != '{') ||
                        (ch == ']' && popped != '['))
                    {
                        return false;
                    }
                }
            }
            return IsEmpty();
        }
    }
}