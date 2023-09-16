using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISyncAssessmentContactApplication.DTOs
{
    public class EditCategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int isActive { get; set; }
    }
}
