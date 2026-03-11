using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace API.Models;

public class Photography{
    
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// nome associado à fotografia
    /// </summary>
    [StringLength(50)]
    [Display(Name = "Título")]
    [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
    public String Title { get; set; } = string.Empty;
    
    /// <summary>
    /// Descrição (opcional) da fotografia
    /// </summary>
    [StringLength(300)]
    [Display(Name = "Descrição")]
    public String? Description { get; set; }

    /// <summary>
    /// Nome do ficheiro que contém a fotografia
    /// </summary>
    public String File { get; set; } = ""; // <=> string.Empty;
    
    /// <summary>
    /// Data em que a fotografia foi tirada
    /// </summary>
    [Display(Name = "Data")]
    [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Preço da fotografia
    /// </summary>
    [Display(Name = "Preço")]
    public decimal Price { get; set; }
    
    /*
     * Relacionamentos 1-N
     */
    
    /// <summary>
    /// FK para a Categoria da fotografias
    /// </summary>
    [ForeignKey(nameof(Category))]
    [Display(Name = "Categoria")]
    public int CategoryFK { get; set; }

    /// <summary>
    /// FK para a Categoria das fotografias
    /// </summary>
    [ValidateNever]
    [Display(Name = "Categoria")]
    public Category Category { get; set; } = null!;
    /*
     * Relacionamentos M-N
     */
    
    /// <summary>
    /// Lista de compras associadas à fotografia
    /// </summary>
    public ICollection<Purchase> ListOfPurchases { get; set; }
}