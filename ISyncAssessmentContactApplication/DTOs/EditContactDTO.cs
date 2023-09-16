using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISyncAssessmentContactApplication.DTOs
{
    public class EditContactDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
    }
}
