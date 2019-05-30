using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Data.Entitys
{
    public partial class Usuarios : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(10)]
        public string Usuario { get; set; }
        [Required]
        [Column("contraseña")]
        [StringLength(10)]
        public string Contraseña { get; set; }
    }
}
