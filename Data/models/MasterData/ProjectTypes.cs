using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.models.MasterData
{
    public class ProjectTypes
    {

        public int Id { get; set; }
        public string ProjectType { get; set; } = string.Empty;
        public string ProjectTypeAbbreviation { get; set; } = string.Empty;
        public string ProjectTypeDescription { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
        public string ModifiedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
        public bool Archive { get; set; }
    }
}
