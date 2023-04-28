using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//agregamos las DataAnnotations
using System.ComponentModel.DataAnnotations;
namespace RegistroSistemas.Models
{
    public class Sistemas
    {
        //Indicamos que el atributo sera llave primaria con ayuda de las DataAnnotations
        [Key]
        public int SistemaId { get; set; }
        //indicamos que el nombre sera un campo requerido y obligatorio 
        public String? Nombre { get; set; }
    }
}