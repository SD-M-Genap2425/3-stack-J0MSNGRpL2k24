using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory

{
    public class Halaman
    {
        public string URL { get; private set; }


        public Halaman(string url)
        {
            URL = url;
        }
        public class Node
        {
            public Halaman Data { get; set; }
            public Node? Next { get; set; }

            public Node(Halaman data)
            {
                Data = data;
                Next = null;
            }
        }

        
    }
}
