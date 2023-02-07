using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("MENSION")]
    public class MENSION
    {
        [Key]
        public int MEN_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string MEN_NOMBRE { get; set; }
        [Display(Name = "Estudiante")]
        [Required]
        public int EST_ID { get; set; }

        //public virtual ESTUDIANTE ESTUDIANTE { get; set; }
    }
}
