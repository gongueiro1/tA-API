using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public class Photography{
    
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    public String Title { get; set; }
    
    public String Description { get; set; }
    
    public String File { get; set; }
    
    /// <summary>
    /// Data em que a fotografia foi tirada
    /// </summary>
    
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Preço da fotografia
    /// </summary>
    
    public decimal Price { get; set; }
    
    /*
     * Relacionamentos 1-N
     */
    
    /// <summary>
    /// FK para a Categoria da fotografias
    /// </summary>
    [ForeignKey(nameof(Category))]
    public int CategoryFK { get; set; }
    /// <summary>
    /// FK para a Categoria das fotografias
    /// </summary>
    public Category Category { get; set; }
    /*
     * Relacionamentos M-N
     */
    
    /// <summary>
    /// Lista de compras associadas à fotografia
    /// </summary>
    public ICollection<Purchase> ListOfPhotos { get; set; }
}