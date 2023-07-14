using ASPLabb3_DataAcces.Models;
using ASPLabb3_DataAcces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPLabb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonInterestController : ControllerBase
    {
        PersonService personService = new();

        [HttpGet("api/PersonInterest/GetAllPersons")]
        public List<PersonDTO> GetAllPersons()
        {
            return personService.GetAllpersons();
        }

        [HttpGet("api/PersonInterest/GetPersonInterests/{personId}")]
        public List<InterestDTO> GetPersonInterests(int personId)
        {
            
            return personService.GetPersonInterests(personId); ;
        }

        [HttpGet("api/PersonInterest/GetPersonLinks/{personId}")]
        public List<LinkDTO> GetPersonLinks(int personId)
        {

            return personService.GetPersonLinks(personId);
        }

        [HttpPost("api/PersonInterest/CreateInterest")]
        public void Post(int personId, string title, string description)
        {
            personService.CreateNewInterest(personId, title, description);
        }

        [HttpPost("api/PersonInterest/CreateLink")]
        public void Post(int interestId, string linkAdress )
        {
            personService.CreateNewLink(interestId, linkAdress);
        }
    }
}
