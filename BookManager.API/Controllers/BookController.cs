
using BookManager.Models;
using BookManager.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookManager.Services.Interfaces;
using System.Text.Json;
using NLog;
using Microsoft.AspNetCore.Authorization;
namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookManagerServices _ibookManagerServices;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public BookController(IBookManagerServices ibookManagerServices)
        {
            _ibookManagerServices = ibookManagerServices;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_ibookManagerServices.GetAll());
            
        }

        [HttpGet("GetBookById")]
        public IActionResult GetBookById(int id)
        {
            return Ok(_ibookManagerServices.GetById(id));
        }

        [HttpPost("Checkout")]
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

        
        [HttpPost("AddBook")]
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
        
        [HttpDelete("DeleteBook")]
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
