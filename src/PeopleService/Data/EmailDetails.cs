using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleService.Data
{
    public class EmailDetails
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
