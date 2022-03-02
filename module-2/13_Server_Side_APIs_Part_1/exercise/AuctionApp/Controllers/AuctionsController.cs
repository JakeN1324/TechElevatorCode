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

        [HttpGet()]
        public List<Auction> ListAuctions()
        {
            return dao.List();
        }

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

        [HttpGet("filter")]

        public ActionResult<List<Auction>> GetAuctionByTitle(string title_like = "")
        {
            List<Auction> auctions = ListAuctions();
            List<Auction> result = new List<Auction>();
            foreach (Auction auction in auctions)
            {
                if (title_like != null)
                {
                    if (auction.Title == title_like)
                    {
                        auctions.Add(auction);
                    }
                }
                
            }
            return result;
        }
    }
}
