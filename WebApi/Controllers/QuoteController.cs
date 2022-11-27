using Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotesController
    {
        private QuoteService _quotesService;

        public QuotesController()
        {
            _quotesService = new QuoteService();
        }


        [HttpGet("GetInfo")]
        public List<QuoteDto> GetQuotes()
        {
            return _quotesService.GetInfoQuotes();
        }
          [HttpGet("GetRandom")]
        public List<QuoteDto> GetRandom()
        {
            return _quotesService.GetRandomQuotes();
        }

        [HttpPost("Insert")]
        public int InsertQuotes(QuoteDto quotes)
        {
            return _quotesService.InsertQuotes(quotes);
        }

        [HttpPut("Update")]
        public int UpdateQuotes(QuoteDto quotes)
        {
            return _quotesService.UpdateQuotes(quotes);
        }

        [HttpDelete("Delete")]
        public int DeleteQuotes(int id)
        {
            return _quotesService.DeleteQuotes(id);
        }         
                  [HttpGet("GetById")]
        public List<QuoteDto> GetById(int id)
        {
            return _quotesService.GetQuotesByCategory(id);
        }    
        
    }

}