using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookManagement.DataAccess.Models;
using BookManagement.DAO;
using BookApi.ViewModels;
namespace BookApi.Controllers
{
    [RoutePrefix("api/v1/Book")]
    public class BookController : ApiController
    {
        [HttpPost, HttpGet]
        [Route("Books")]
        public IHttpActionResult GetBook()
        {
            BookDAO dao = new BookDAO();
            List<Book> books = dao.ListBook();
            List<BookViewModel> viewmodels = new List<BookViewModel>();
            foreach(Book book in books){
                BookViewModel model = new BookViewModel(book);
                viewmodels.Add(model);
            }
            return Json(new
            {
                status = true,
                list = viewmodels
            });
        }
    }
}
