using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.Models;
using Congo.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.Pages
{
    public class CheckoutModel : PageModel
    {
        private ICongoRepository repository;

        //Constructor
        public CheckoutModel(ICongoRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookID, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.BookID == bookID);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(book, 1);
            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookID, string returnUrl)
        {
            Cart.RemoveItem(Cart.Lines.First(p => p.Book.BookID == bookID).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
