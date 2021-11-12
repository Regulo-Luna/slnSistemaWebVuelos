using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelo")]
    public class Vuelo
    {
        [Key]

        [DisplayName("Id Vuelo")]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "Este campo no puede superar los 50 caracteres")]

        [Column(TypeName = "varchar")]
        public string Destino { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]

        [MaxLength(50, ErrorMessage = "Este campo no puede superar los 50 caracteres")]
        [Column(TypeName = "varchar")]
        public string Origen { get; set; }

        [DisplayName("Matricula Vuelo")]
        [Range(100, 1000, ErrorMessage = "La Matrícula debe estar entre 100 y 1000")]
        public int Matricula { get; set; }

    }
}

