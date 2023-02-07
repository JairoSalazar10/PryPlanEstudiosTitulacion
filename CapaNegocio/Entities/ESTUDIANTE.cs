using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("ESTUDIANTE")]
    public class ESTUDIANTE
    {
        [Key]
        public int EST_ID { get; set; }
        [Display(Name = "Cédula")]
        [Required]
        public string EST_CEDULA { get; set; }
        [Display(Name = "Nombres")]
        [Required]
        public string EST_NOMBRES { get; set; }
        [Display(Name = "Apellidos")]
        [Required]
        public string EST_APELLIDOS { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        [Required]
        public DateTime EST_FNACIMIENTO { get; set; }

        [Display(Name = "Plan de estudio")]
        [Required]
        public string EST_PLAN_ESTUDIO { get; set; }

        [Display(Name = "Plan")]
        [Required]
        public int PLA_ID { get; set; }

        [Display(Name = "Correo")]
        [Required]
        public string EST_EMAIL { get; set; }

        [Display(Name = "Teléfono Domicilio")]
        [Required]
        public string EST_TEL_DOMICILIO { get; set; }

        [Display(Name = "Teléfono Celular")]
        [Required]
        public string EST_TEL_CELULAR { get; set; }

        [Display(Name = "Dirección")]
        [Required]
        public string EST_DIRECCION { get; set; }


        public virtual ICollection<PLAN> PLAN { get; set; }
    }
}
