using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopleService.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Email{ get; set; }
    }
}
