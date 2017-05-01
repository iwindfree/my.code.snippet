using csharp_code_snippet.sort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
