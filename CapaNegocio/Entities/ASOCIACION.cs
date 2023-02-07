using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("ASOCIACION")]
    public class ASOCIACION
    {
        [Key]
        public int ASO_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string ASO_NOMBRE { get; set; }
        [Display(Name = "Estudiante")]
        [Required]
        public int EST_ID { get; set; }

        //public virtual ESTUDIANTE ESTUDIANTE { get; set; }
    }
}
