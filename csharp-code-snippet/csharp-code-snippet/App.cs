using csharp_code_snippet.Concurrent;
using csharp_code_snippet.DatetimeUtil;
using csharp_code_snippet.Quiz;
using csharp_code_snippet.simpleSocket;
using csharp_code_snippet.sort;
using Quiz;
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
        public object Password { get; private set; }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
          

          
        }

        private void btnPermutation_Click(object sender, EventArgs e)
        {
            Permutaion permutaion = new Permutaion();
            permutaion.Solve();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Solve();
        }

        private void btnCheckPair_Click(object sender, EventArgs e)
        {
            CheckPair pair = new CheckPair();
            pair.Solve();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            WordCompressor compressor = new WordCompressor();
            compressor.Solve();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            Ranking rank = new Ranking();
            rank.Solve();
        }

        private void btnSecOfDateTime_Click(object sender, EventArgs e)
        {
            DtUtil datetimeUtil = new DtUtil();
            datetimeUtil.GetSeconds();
            datetimeUtil.StringToDatetime();
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            ParallelTest parallel = new ParallelTest();
            parallel.Do();

        }

        private void btnMasking_Click(object sender, EventArgs e)
        {
            Masking masking  = new Masking();
            masking.MaskName("김경남");
            masking.MaskCard("1234=8764-0987-9878");
            masking.MaskRrn("730301-1193833");
           
        }

        private void btnCheckPairty_Click(object sender, EventArgs e)
        {
            CheckParity pairty = new CheckParity();
            pairty.Solve();
        }

        private void btnCheckPwd_Click(object sender, EventArgs e)
        {
            Password pwd = new Password();
            pwd.Solve();
        }

        private void btnThreadPool_Click(object sender, EventArgs e)
        {
            ThreadPool2 threadPool = new ThreadPool2();
            threadPool.Do();
        }
    }
}
    