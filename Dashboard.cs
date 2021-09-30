using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * IMAGE REFERENCES
 * 
 * Dashboard
 * link:https://wallpapersafari.com/w/vGUjog
 */

namespace OnlineLibraryApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // Open Replacing Books Form
        private void btn_ReplacingBooks_Click(object sender, EventArgs e)
        {
            Form1_ReplacingBooks replacingBooks = new Form1_ReplacingBooks();
            replacingBooks.ShowDialog();
        }
    }
}
