using CoreEntity.Models;

namespace CoreEntity.Services;

public class TGroupService {
    public void AddGroup(TGroup group) {
        using var context = new DatabaseContext();
        context.TGroups.Add(group);
        context.SaveChanges();
    }

    public List<TGroup> GetAllGroups(string searchQuery) {
        using var context = new DatabaseContext();
        var groups = context.TGroups.ToList();
        // Если есть запрос на поиск, фильтруем группы
        if (!string.IsNullOrEmpty(searchQuery))
            groups = groups
                .Where(group => group.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                                group.Description.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                .ToList();

        return groups;
    }

    public TGroup GetGroupById(int id) {
        using var context = new DatabaseContext();
        return context.TGroups.Find(id)!;
    }

    public void UpdateGroup(TGroup group) {
        using var context = new DatabaseContext();
        var existingGroup = context.TGroups.Find(group.Id);
        if (existingGroup == null) return;
        existingGroup.Name = group.Name;
        existingGroup.Description = group.Description;
        context.SaveChanges();
    }

    public void DeleteGroup(int id) {
        using var context = new DatabaseContext();
        var group = context.TGroups.Find(id);
        if (group == null) return;
        context.TGroups.Remove(group);
        context.SaveChanges();
    }
}