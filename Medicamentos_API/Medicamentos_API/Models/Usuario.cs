using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Medicamentos_API.Models;

public partial class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Idusuario { get; set; }

    public string Nombre { get; set; }

    public DateTime? Fechacreacion { get; set; }

    public string Usuario1 { get; set; }

    public string Password { get; set; }

    public int? Idperfil { get; set; }

    public int? Estatus { get; set; }
}
