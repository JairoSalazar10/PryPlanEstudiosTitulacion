using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("PLAN")]
    public class PLAN
    {
        [Key]
        public int PLA_ID { get; set; }
        [Display(Name = "Código")]
        [Required]
        public string PLA_CODIGO { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string PLA_NOMBRE { get; set; }

        [Display(Name = "ESTUDIANTE")]
        [Required]
        public int EST_ID { get; set; }

        public virtual ICollection<ESTUDIANTE> ESTUDIANTE { get; set; }
    }
}
