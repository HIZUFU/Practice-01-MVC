using System.ComponentModel.DataAnnotations;
namespace ProductCatalogApp.Models;

public class Equipment
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Введите название"), StringLength(100), Display(Name = "Название")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "Введите модель"), StringLength(100), Display(Name = "Модель")]
    public string Model { get; set; } = string.Empty;
    [Required(ErrorMessage = "Введите инвентарный номер"), StringLength(50), Display(Name = "Инвентарный номер")]
    public string InventoryNumber { get; set; } = string.Empty;
    [Range(1, int.MaxValue, ErrorMessage = "Выберите участок"), Display(Name = "Участок")]
    public int ProductionSiteId { get; set; }
    public ProductionSite? ProductionSite { get; set; }
}
