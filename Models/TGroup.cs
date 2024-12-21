using System.ComponentModel.DataAnnotations;

namespace CoreEntity.Models;

public class TGroup {
    [Key] public int Id { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; }

    public string Description { get; set; }
    public virtual ICollection<TProperty> TProperties { get; set; }

    public override string ToString() {
        return $"ID: {Id}, Название: {Name}, Описание: {Description}";
    }
}