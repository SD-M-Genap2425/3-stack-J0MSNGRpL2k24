using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Solution.BrowserHistory
{
    public class HistoryManager
    {
        private class Node
        {
            public Halaman Data { get; set; }
            public Node? Next { get; set; }

            public Node(Halaman data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? top;

        public HistoryManager()
        {
            top = null;
        }

        public void KunjungiHalaman(string url)
        {
            Node newNode = new Node(new Halaman(url));
            newNode.Next = top;
            top = newNode;
            
        }

        public string Kembali()
        {
            if (top == null || top.Next == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            top = top.Next;
            return LihatHalamanSaatIni();
        }

        public string LihatHalamanSaatIni()
        {
            return top != null ? top.Data.URL : "Tidak ada halaman yang dikunjungi.";
        }

        public void TampilkanHistory()
        {
            Node? current = top;
            Stack<string> historyStack = new Stack<string>();

            while (current != null)
            {
                historyStack.Push(current.Data.URL);
                current = current.Next;
            }

            while (historyStack.Count > 0)
            {
                Console.WriteLine(historyStack.Pop());
            }
        }


    }
}
