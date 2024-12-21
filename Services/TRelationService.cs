using CoreEntity.Models;

namespace CoreEntity.Services;

public class TRelationService {
    public void AddRelation(TRelation relation) {
        using var context = new DatabaseContext();
        context.TRelations.Add(relation);
        context.SaveChanges();
    }

    public List<TRelation> GetAllRelations() {
        using var context = new DatabaseContext();
        return context.TRelations.Include("Group").ToList();
    }

    public TRelation GetRelationById(int id) {
        using var context = new DatabaseContext();
        return context.TRelations.Find(id)!;
    }

    public void UpdateRelation(UpdateTRelation relation) {
        using var context = new DatabaseContext();
        var existingRelation = context.TRelations.Find(relation.Id);
        if (existingRelation == null) return;
        existingRelation.RelationName = relation.RelationName;
        context.SaveChanges();
    }

    public void DeleteRelation(int id) {
        using var context = new DatabaseContext();
        var relation = context.TRelations.Find(id);
        if (relation == null) return;
        context.TRelations.Remove(relation);
        context.SaveChanges();
    }
}