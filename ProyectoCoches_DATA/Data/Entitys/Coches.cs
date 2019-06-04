using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCoches_DATA.Data.Entitys
{
    public partial class Coches : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("marca")]
        [StringLength(50)]
        public string Marca { get; set; }
        [Required]
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]
        [Column("color")]
        [StringLength(50)]
        public string Color { get; set; }
        [Column("año", TypeName = "numeric(18, 0)")]
        public decimal Año { get; set; }
        [Column("km", TypeName = "numeric(18, 0)")]
        public decimal Km { get; set; }
        [Required]
        [Column("combustible")]
        [StringLength(50)]
        public string Combustible { get; set; }
        [Column("tracccion")]
        [StringLength(50)]
        public string Tracccion { get; set; }
        public bool Itv { get; set; }
        [Column("precio", TypeName = "numeric(18, 0)")]
        public decimal Precio { get; set; }
        [Column("descrpcion")]
        [StringLength(500)]
        public string Descrpcion { get; set; }
        [Required]
        [Column("imagen")]
        [StringLength(100)]
        public string Imagen { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Coches")]
        public Datosusuario IdNavigation { get; set; }
    }
}
