using BookManager.Services.Interfaces;

namespace BookManager.Services
{
    public class BookManagerServices : IBookManagerServices
    {
        IBookManagerServices _ibookManagerServices;
        public BookManagerServices(IBookManagerServices ibookManagerServices) 
        
        {
            _ibookManagerServices = ibookManagerServices;
        }
        public void AddAuthor()
        {
            throw new System.NotImplementedException();
        }
    }
}
