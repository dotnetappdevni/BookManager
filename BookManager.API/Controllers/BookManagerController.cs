
using BookManager.Models;
using BookManager.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookManager.Services.Interfaces;
using System.Text.Json;
namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookManagerController : ControllerBase
    {
        private readonly ILogger<BookManagerController> _logger;
        IBookManagerServices _ibookManagerServices;
        public BookManagerController(ILogger<BookManagerController> logger, IBookManagerServices ibookManagerServices)
        {
            _logger = logger;
            _ibookManagerServices = ibookManagerServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ibookManagerServices.GetAll());
            
        }

        [HttpPost]
        public IActionResult Checkout(int CustomerId, Book book, int returnDateInterval)
        {
            
           var checkoutProcess= _ibookManagerServices.CheckOut(CustomerId, book, returnDateInterval);
            if (checkoutProcess.Succeeded)
            {
                return Ok(JsonSerializer.Serialize(checkoutProcess.Messages));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Serialize(checkoutProcess.Errors));
            }


        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            var bookToAdd = _ibookManagerServices.Add(book);
            if (bookToAdd.Succeeded)
            {
                return Ok();

            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, bookToAdd.Errors);
            }            
        }

        [HttpDelete]
        public IActionResult Delete(Book book)
        {
            var bookTodelete = _ibookManagerServices.Delete(book);
            if (bookTodelete.Succeeded)
            {
                return Ok();

            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, bookTodelete.Errors);
            }

        }
    }
}
