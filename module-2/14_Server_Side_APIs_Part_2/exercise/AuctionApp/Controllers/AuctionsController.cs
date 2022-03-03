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

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction newAuction = dao.Create(auction);
            return Created("/auctions/id", dao.Create(auction));
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction auction, int id)
        {
            Auction chosenAuction = dao.Get(id);

            if (chosenAuction != null)
            {
                ActionResult<Auction> updated = dao.Update(id, auction);
                return updated;

            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Auction chosenAuction = dao.Get(id);

            if (chosenAuction != null)
            {
                if (dao.Delete(id))
                {
                    return StatusCode(204);
                }

            }
            return NotFound();
        }
    }
}
