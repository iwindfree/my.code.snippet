using csharp_code_snippet.Quiz;
using csharp_code_snippet.simpleSocket;
using csharp_code_snippet.sort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_code_snippet
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnSortDictionary_Click(object sender, EventArgs e)
        {
            DictionarySort dicSort = new DictionarySort();
            dicSort.Sort1();
        }

        private void btnSortDictionary2_Click(object sender, EventArgs e)
        {
            DictionarySort dicSort = new DictionarySort();
            dicSort.Sort2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocketServer server = new SocketServer();
            server.Start();
        }

        private void simpleSockClient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ClientSocket sock = new ClientSocket();
                sock.Execute();
            }
         
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            PacketRestore packetRestore = new PacketRestore();
            packetRestore.Solve();
        }

        private void btnPatternMatch_Click(object sender, EventArgs e)
        {
            PatternMatch match = new PatternMatch();
            match.Solve();
        }

        private void btnAnagram_Click(object sender, EventArgs e)
        {
            Anagram anagram = new Anagram();
            anagram.Solve();
        }
    }
}
