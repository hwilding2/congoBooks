using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book pendingBook, int qty)
        {
            CartLine line = Lines.Where(b => b.Book.BookID == pendingBook.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = pendingBook,
                    Quantity = qty,
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book pendingBook) =>
            Lines.RemoveAll(x => x.Book.BookID == pendingBook.BookID);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotal() => (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);
   
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
