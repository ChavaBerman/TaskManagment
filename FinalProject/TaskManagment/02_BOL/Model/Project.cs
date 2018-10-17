using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BOL.Model
{
    class Project
    {
        [Key]
        public int IdProject { get; set; }

        [Required]
        public string Name { get; set; }

        public string CustomerName { get; set; }

        [DefaultValue(0)]
        public int QAHours { get; set; }

        [DefaultValue(0)]
        public int UIUXHours { get; set; }

        [DefaultValue(0)]
        public int DEVHours { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey("User")]
        public int TeamHeadId { get; set; }
    }
}
