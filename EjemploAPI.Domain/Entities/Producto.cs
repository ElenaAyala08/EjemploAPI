using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAPI.Domain.Entities
{
    [Table("t_Producto")]
    public class Producto
    {
        [Key]
        [Column("IdProducto")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(200)]
        [Required]
        public string Descripcion { get; set; }

        [Column("precio")]
        [Required]
        public string Precio { get; set; }

        [Column("stock")]
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Estado { get; set; }


    }
}
