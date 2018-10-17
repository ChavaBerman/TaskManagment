using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BOL
{
    class Worker
    {
        [Key]
        public int IdWorker { get; set; }

        [DefaultValue(0)]
        public int TotalHours { get; set; }

        [ForeignKey("Status")]
        public int IdStatus { get; set; }

        [ForeignKey("User")]
        public int TeamHeadId { get; set; }
    }
}
