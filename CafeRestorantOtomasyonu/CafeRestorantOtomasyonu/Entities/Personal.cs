using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CafeRestorantOtomasyonu.Entities
{
    public class Personal
    {
        [Key]
        [StringLength(11,MinimumLength =11)]
        public string PersonelID { get; set; }
        public string PersonalName { get; set; }
        public string PersonalSurname { get; set; }
        public string PersonalCell { get; set; }
        public string PersonalRank { get; set; }

    }
}
