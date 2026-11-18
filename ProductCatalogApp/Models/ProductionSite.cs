using System.ComponentModel.DataAnnotations;
namespace ProductCatalogApp.Models;

public class ProductionSite
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Введите название"), StringLength(100), Display(Name = "Название")]
    public string Name { get; set; } = string.Empty;
    [StringLength(1000), Display(Name = "Описание")]
    public string Description { get; set; } = string.Empty;
    public List<Equipment> EquipmentItems { get; set; } = new();
}
