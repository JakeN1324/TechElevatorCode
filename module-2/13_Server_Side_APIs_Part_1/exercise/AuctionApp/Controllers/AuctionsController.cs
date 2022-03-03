using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("ready")]
        public string Ready()
        {
            return "Server ready.";
        }

        //[HttpGet()]
        //public List<Auction> ListAuctions()
        //{
        //    return dao.List();
        //}

        [HttpGet("{id}")]
        public ActionResult<Auction> GetAuction(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }
            else
            {
                return null;
            }
        }

        [HttpPost()]
        public ActionResult<Auction> AddAuction(Auction auction)
        {
            Auction result = dao.Create(auction);
            if (result == null)
            {
                return StatusCode(500);
            }
            else
            {
                return result;
            }
        }

        [HttpGet()]
        public List<Auction> FilterAuctionsByTitle(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "" && currentBid_lte > 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            else if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            


            return dao.List();

            



        }



    }
}
