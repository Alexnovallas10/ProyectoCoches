using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCoches_DATA.Data.Entitys
{
    [Table("datosusuario")]
    public partial class Datosusuario : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(25)]
        public string Nombre { get; set; }
        [Required]
        [Column("apellido1")]
        [StringLength(25)]
        public string Apellido1 { get; set; }
        [Required]
        [Column("apellido2")]
        [StringLength(25)]
        public string Apellido2 { get; set; }
        [Required]
        [Column("email")]
        [StringLength(25)]
        public string Email { get; set; }
        [Column("telefono", TypeName = "numeric(9, 0)")]
        public decimal Telefono { get; set; }

        [InverseProperty("IdNavigation")]
        public Coches Coches { get; set; }
    }
}
