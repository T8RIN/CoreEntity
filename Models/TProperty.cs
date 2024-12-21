using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntity.Models;

public class TProperty {
    [Key] public int Id { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; }

    [Required] public string Value { get; set; }

    [ForeignKey("TGroup")] public int GroupId { get; set; }

    public virtual TGroup TGroup { get; set; }

    public override string ToString() {
        return $"ID: {Id}, Название: {Name}, Значение: {Value}, ID группы: {GroupId}";
    }
}

public class UpdateTProperty {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}