using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearch.Models
{
    public class SeedData
    {
        private PersonContext _context;

        public SeedData(PersonContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Person.Any())
            {
                var obj1 = new Person()
                {
                    FullName = "Liz Parker",
                    Address = "123 S St, Roswell NM 88202",
                    Age = 25,
                    Interests = "Aliens, Japanese language and culture",
                };
                _context.Person.Add(obj1);

                var obj2 = new Person()
                {
                    FullName = "Max Evans",
                    Address = "456 S St, Roswell NM 88203",
                    Age = 27,
                    Interests = "Science and Astronomy",
                };
                _context.Person.Add(obj2);

                var obj3 = new Person()
                {
                    FullName = "Maria Deluca",
                    Address = "789 S St, Roswell NM 88203",
                    Age = 26,
                    Interests = "English Literature",
                };
                _context.Person.Add(obj3);

                await _context.SaveChangesAsync();
            }
        }
    }
}
