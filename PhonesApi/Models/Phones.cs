using System.ComponentModel.DataAnnotations;
namespace PhonesApi.Models
{
public class Phones
    {
    public int Id { get; set; }
    public string? Title { get; set; }
    
    public DateTime ReleaseDate { get; set; }
  
    public decimal Price { get; set; }
    }
}