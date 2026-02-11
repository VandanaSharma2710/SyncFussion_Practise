using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.models.MasterData
{
    public class Programs
    {
        public int Id { get; set; }
        public string ProgramName { get; set; } = string.Empty;
        public string ProgramAbbreviation { get; set; } = string.Empty;
        public string ProgramTypeName { get; set; } = string.Empty;
        public string ProgramDescription { get; set; } = string.Empty;
        public bool Archive { get; set; }
    }
}
