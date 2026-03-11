using System.ComponentModel.DataAnnotations;

namespace API.Models;
/// <summary>
/// Dados do cliente
/// </summary>
public class MyUser{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Nome do Cliente
    /// </summary>
    
    public string Name { get; set; }
    
    /// <summary>
    /// Morada do Cliente
    /// </summary>
    
    public string Address { get; set; }
    
    /// <summary>
    /// Código postal da morada do cliente
    /// </summary>
    
    public string PostalCode { get; set; }
    
    /// <summary>
    /// País da morada do cliente
    /// </summary>
    
    public string Country { get; set; }
    
    /// <summary>
    /// Número de contribuinte
    /// </summary>

    public string TaxNumber { get; set; }
    
    /// <summary>
    /// Telemóvel do cliente
    /// </summary>

    public string CellPhone { get; set; }
    
    /*
     * Relacionamentos 1-N
     */
    
    /// <summary>
    /// Lista das fotografias
    /// </summary>
    public ICollection<Purchase> ListOfPurchase { get; set; }
}