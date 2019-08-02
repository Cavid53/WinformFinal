using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class LibraryBooks : Form
    {
        private LibraryEntities _db;
        public LibraryBooks()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private async void BtnCreateBook_Click(object sender, EventArgs e)
        {
            int id = (cmbGenreList.SelectedItem as CMBBookClass).Id;
            string bookName = txbBookForm.Text.Trim();
            decimal bookPrice =decimal.Parse( txbBookPrice.Text.Trim());
            int bookCount =int.Parse(txbBookCount.Text.Trim());
            
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book book = new Book() { Name = bookName,Price=bookPrice,Count=bookCount,GenresID=id };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            txbBookForm.Text = null;
            txbBookCount.Text = null;
            txbBookPrice.Text = null;
            cmbGenreList.DataSource = null;
            RefreshDGV();

        }

        private void LibraryBooks_Load(object sender, EventArgs e)
        {
            cmbGenreList.Items.AddRange(_db.Genres.Where(g=>g.Deleted==false)
               .Select(g => new CMBBookClass { Id = g.Id, Name = g.Name}).ToArray());
            RefreshDGV();


        }

        private void RefreshDGV()
        {
            var books = _db.Books.Where(b => b.Deleted == false).Select(b => new
            {
                b.Id,
                b.Name,
                b.Count,
                b.Price,
                Genre = b.Genre.Name
            }).OrderByDescending(b => b.Id).ToList();

            dgvBookList.DataSource = books;
        }

        private void CmbGenreList_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
