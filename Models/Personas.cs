using System.ComponentModel.DataAnnotations;

public class Personas
{
    [Key]
    public int PersonaId { get; set; }

    [Required(ErrorMessage = "Favor llenar este campo")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Favor llenar este campo")]
    public string Apellido { get; set; }
    [Required(ErrorMessage = "Favor llenar este campo")]
    public string Telefono { get; set; }
    [Required(ErrorMessage = "Favor llenar este campo")]
    public string Direccion { get; set; }

}