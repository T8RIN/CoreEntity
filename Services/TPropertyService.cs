using CoreEntity.Models;

namespace CoreEntity.Services;

public class TPropertyService {
    public void AddProperty(TProperty property) {
        using var context = new DatabaseContext();
        context.TProperties.Add(property);
        context.SaveChanges();
    }

    public List<TProperty> GetAllProperties() {
        using var context = new DatabaseContext();
        return context.TProperties.ToList();
    }


    public TProperty GetPropertyById(int id) {
        using var context = new DatabaseContext();
        return context.TProperties.FirstOrDefault(p => p.Id == id)!;
    }


    public void UpdateProperty(UpdateTProperty property) {
        using var context = new DatabaseContext();
        var existingProperty = context.TProperties.FirstOrDefault(p => p.Id == property.Id);
        if (existingProperty == null) return;
        existingProperty.Name = property.Name;
        existingProperty.Value = property.Value;

        context.SaveChanges();
    }

    public void DeleteProperty(int id) {
        using var context = new DatabaseContext();
        var property = context.TProperties.FirstOrDefault(p => p.Id == id);
        if (property == null) return;
        context.TProperties.Remove(property);
        context.SaveChanges();
    }
}