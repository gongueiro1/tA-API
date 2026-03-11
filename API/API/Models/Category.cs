using System.ComponentModel.DataAnnotations;

namespace API.Models;

/// <summary>
/// Possiveis Categorias associadas às fotografias
/// </summary>
public class Category{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Nome da categoria
    /// </summary>
    [StringLength(20)]
    [Display(Name ="Nome da Categoria")]
    [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
    public string Name { get; set; } = "";
    
    /*
     * Relacionamentos 1-N
     */

    /// <summary>
    /// Lista de fotografias que uma categoria tem
    /// </summary>
    public ICollection<Photography> ListOfPhotos { get; set; } = [];
}


