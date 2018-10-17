using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _02_BOL.Model
{
    class Task
    {
        [Key]
        public int IdTask { get; set; }
        
        public int ReservingHours { get; set; }

        public int GivenHours { get; set; }

        [ForeignKey("Project")]
        public int IdProject { get; set; }

        [ForeignKey("Worker")]
        public int IdWorker { get; set; }
    }
}
