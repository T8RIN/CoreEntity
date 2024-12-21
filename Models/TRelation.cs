namespace CoreEntity.Models;

public class TRelation {
    public int Id { get; set; }
    public int GroupId { get; set; }
    public string RelationName { get; set; }

    public virtual TGroup Group { get; set; }

    public override string ToString() {
        return $"ID: {Id}, Название: {RelationName}, ID группы: {GroupId}";
    }
}

public class UpdateTRelation {
    public int Id { get; set; }
    public string RelationName { get; set; }
}