using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public string RegNum { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // collection navigation
        public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
    }
}
