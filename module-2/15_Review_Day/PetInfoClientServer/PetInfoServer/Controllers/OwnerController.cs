using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private IOwnerDAO ownerDAO;

        public OwnerController (IOwnerDAO ownerDAO)
        {
            this.ownerDAO = ownerDAO;
        }

        [HttpGet()]
        public ActionResult<List<Owner>> GetOwners()
        {
            List<Owner> owners = ownerDAO.GetOwners();

            if (owners == null)
            {
                return NotFound();
            }
            else
            {
                return owners;
            }
        }
    }
}
