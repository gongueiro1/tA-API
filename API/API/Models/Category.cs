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
    
    public string Name { get; set; }
    
    /*
     * Relacionamentos 1-N
     */
    
    /// <summary>
    /// Lista de fotografias que uma categoria tem
    /// </summary>
    public ICollection<Photography> ListOfPhotos { get; set; }
}


