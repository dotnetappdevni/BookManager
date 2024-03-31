
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
        public IActionResult Checkout(int customerId, int bookId,string barCode, int returnDateInterval)
        {
            
            var checkoutProcess= _ibookManagerServices.CheckOut(customerId, bookId, barCode, returnDateInterval);
            if (checkoutProcess.Succeeded)
            {
                return Ok(JsonSerializer.Serialize(checkoutProcess.Messages));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Serialize(checkoutProcess.Errors));
            }
        }

        [HttpPost("CheckIn")]
        public IActionResult CheckIn(int customerId, int bookId, string barCode, DateTime returnDate)
        {

            var checkInProcess = _ibookManagerServices.CheckIn(customerId, bookId, barCode, returnDate);
            if (checkInProcess.Succeeded)
            {
                return Ok(JsonSerializer.Serialize(checkInProcess.Messages));
            }
            else
            {
                return StatusCode(400, JsonSerializer.Serialize(checkInProcess.Errors));
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

        [HttpDelete("UpdateBook")]
        public IActionResult UpdateBook(Book book)
        {
            var bookToUpdate = _ibookManagerServices.UpdateBook(book);
            if (bookToUpdate.Succeeded)
            {
                return Ok();
            }else
            {
                return StatusCode(StatusCodes.Status400BadRequest, bookToUpdate.Errors);
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
