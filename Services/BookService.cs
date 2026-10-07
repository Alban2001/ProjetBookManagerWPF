using BookManagerWPF.Data;
using BookManagerWPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerWPF.Services
{
    public class BookService
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddBookAsync(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveBookAsync(int id)
        {   
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateBookAsync(Book updatedBook)
        {
            if (updatedBook == null)
                throw new ArgumentNullException(nameof(updatedBook));
            var book = await _context.Books.FindAsync(updatedBook.Id);
            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.PublicationDate = updatedBook.PublicationDate;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.AsNoTracking().ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

    }
}
