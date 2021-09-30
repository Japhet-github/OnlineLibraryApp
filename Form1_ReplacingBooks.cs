using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * IMAGE REFERENCES
 * 
 * Form 1 - Replacing Book
 * link:https://wallpapersafari.com/w/OH2B19
 */

namespace OnlineLibraryApp
{
    public partial class Form1_ReplacingBooks : Form
    {
        private BookList BookList = new BookList();
        private static Random random = new Random();

        public Form1_ReplacingBooks()
        {
            InitializeComponent();
            RandomGenerator();
        }

        // Random Generator
        private void RandomGenerator()
        {
            for (int i = 0; i < 10; i++)
            {
                Books book = new Books // combine the random number and string
                {
                    CallNumber = Utilities.RandomDecimal(random).ToString("000.##") + " "
                    + Utilities.RandomString(3, random)
                };
                this.BookList.LibraryBooks.Add(book);
            }
            CallNumbers();
        }

        // populate the call number in the grid view
        private void CallNumbers()
        {
            if (BookList.LibraryBooks != null)
            {
                this.callNumberList.DataSource = BookList.LibraryBooks;
            }
        }

        /*
         * --- CODE ATTRIBUTION ---
         * Link: https://www.youtube.com/watch?v=e7nd1UpNXKA
         */

        // give a ID number to each book row
        private void callNumberList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.callNumberList.Rows[e.RowIndex].Cells["ID"].Value = (e.RowIndex + 1).ToString();
        }
        // sorting books
        private void btn_GenerateBooks_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            this.progressBar.Visible = true;
        }

        // time that takes to sort the books
        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            if (Convert.ToUInt32(this.progressBar.Value) == 100)
            {
                if (BookList.LibraryBooks != null)
                {
                    BookList.LibraryBooks = BookList.LibraryBooks.OrderBy(x => x.CallNumber).ToList();
                    CallNumbers();
                }
                this.timer.Stop();
                this.progressBar.Visible = false;
            }
        }
    }
}
