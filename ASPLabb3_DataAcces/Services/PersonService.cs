using ASPLabb3_DataAcces.Data;
using ASPLabb3_DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLabb3_DataAcces.Services
{
    public class PersonService
    {
        DataContext _context = new();

        public List<PersonDTO> GetAllpersons()
        {
            var personList = _context.Persons.ToList();
            var personDTOs = personList.Select(p => new PersonDTO
            {
                Id = p.Id,
                Name = p.Name,
                TelephoneNumber = p.TelephoneNumber
            }).ToList();

            return personDTOs;
        }

        public List<InterestDTO> GetPersonInterests(int personId)
        {
            var interestList = _context.Interests.Where(i => i.PersonId == personId).ToList();
            var interestDTOs = interestList.Select(i => new InterestDTO
            {
                Id = i.Id,
                Title = i.Title,
                Description = i.Description,
                PersonId = i.PersonId
            }).ToList();
            return interestDTOs;
        }

        public List<LinkDTO> GetPersonLinks(int personId)
        {
            var interestList = _context.Interests.Where(i => i.PersonId == personId).Select(i => i.Id);
            var linkList = _context.Links.Where(l => interestList.Contains(l.InterestId)).ToList();
            var linkDTOs = linkList.Select(l => new LinkDTO
            {
                Id = l.Id,
                LinkAdress = l.LinkAdress,
                InterestId = l.InterestId
            }).ToList();

            return linkDTOs;
        }

        public void CreateNewInterest(int personId, string interestTitle, string interestDescription)
        {
            var newInterest = new Interest
            {
                Title = interestTitle,
                Description = interestDescription,
                PersonId = personId
            };

            _context.Interests.Add(newInterest);
            _context.SaveChanges();
        }

        public void CreateNewLink(int interestId, string linkAdress)
        {
            var newLink = new Link
            {
                InterestId = interestId,
                LinkAdress = linkAdress
            };

            _context.Links.Add(newLink);
            _context.SaveChanges();
        }
    }
}
