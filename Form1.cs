using CoreEntity.Models;
using CoreEntity.Services;

namespace CoreEntity;

public partial class Form1 : Form
{
    private const string ErrorCaption = "Ошибка";
    private const string InfoCaption = "Информация";
    private const string WarningCaption = "Внимание";

    private const string WrongFormat = "Неверный формат данных, проверьте ввод";

    private static void ShowError(
        string label,
        Exception? exception = null
    )
    {
        var text = exception != null ? $@"{label}: {exception.Message}" : label;

        MessageBox.Show(
            text: text,
            caption: ErrorCaption,
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Error
        );
    }

    private static void ShowWarning(
        string label
    )
    {
        MessageBox.Show(
            text: label,
            caption: WarningCaption,
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Warning
        );
    }

    private static void ShowInfo(
        string label
    )
    {
        MessageBox.Show(
            text: label,
            caption: InfoCaption,
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Information
        );
    }

    public Form1()
    {
        InitializeComponent();
        hideAll();
    }

    private void DropDataBaseClick(object sender, EventArgs e)
    {
        using var context = new DatabaseContext();
        context.Database.Delete();
    }

    //TGroup
    private void get_groups_Click(object sender, EventArgs e)
    {
        try
        {
            var groupService = new TGroupService();
            var propertyService = new TPropertyService();

            var searchQuery = textBoxSearch.Text.Trim();

            var groups = groupService.GetAllGroups(searchQuery);

            treeViewGroups.Nodes.Clear();

            foreach (var group in groups)
            {
                var groupNode = new TreeNode($"Группа: {group.Name}, ID: {group.Id}");
                var properties = propertyService.GetPropertiesByGroupId(group.Id);

                foreach (var propertyNode in properties
                             .Select(property =>
                                 $"Свойство: {property.Name}, Значение: {property.Value}, ID: {property.Id}")
                             .Select(propertyText => new TreeNode(propertyText)))
                {
                    groupNode.Nodes.Add(propertyNode);
                }

                treeViewGroups.Nodes.Add(groupNode);
            }

            MessageBox.Show(groups.Count == 0 ? "Группы не найдены" : "Группы загружены");
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при загрузке групп", ex);
        }
    }

    private void getByGroupId_Click(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(textBoxGroupId.Text, out var groupId))
            {
                var groupService = new TGroupService();

                var group = groupService.GetGroupById(groupId);

                ShowInfo(group.ToString());
            }
            else
            {
                ShowWarning(WrongFormat);
            }
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при поиске группы", ex);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var groupService = new TGroupService();
            if (groupNameTextBox.Text == "" || groupDescriptionTextBox.Text == "")
            {
                ShowWarning(WrongFormat);
            }
            else
            {
                var group = new TGroup
                {
                    Name = groupNameTextBox.Text,
                    Description = groupDescriptionTextBox.Text
                };

                groupService.AddGroup(group);

                ShowInfo("Группа добавлена");
            }
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при добавлении группы", ex);
        }
    }

    private void updateGroup_Click(object sender, EventArgs e)
    {
        try
        {
            if (treeViewGroups.SelectedNode == null)
            {
                ShowWarning("Выберите группу для обновления");
                return;
            }

            var selectedItem = treeViewGroups.SelectedNode.ToString()!;

            var idStartIndex = selectedItem.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedItem.IndexOf(',', idStartIndex);
            var idString = selectedItem[idStartIndex..idEndIndex];
            var groupId = int.Parse(idString);

            if (string.IsNullOrWhiteSpace(groupNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(groupDescriptionTextBox.Text))
            {
                ShowWarning("Введите новое имя и описание группы");
                return;
            }

            var groupService = new TGroupService();

            var updatedGroup = new TGroup
            {
                Id = groupId,
                Name = groupNameTextBox.Text.Trim(),
                Description = groupDescriptionTextBox.Text.Trim()
            };

            groupService.UpdateGroup(updatedGroup);

            ShowInfo("Группа обновлена");

            groupNameTextBox.Clear();
            groupDescriptionTextBox.Clear();

            get_groups_Click(sender, e);
        }
        catch (FormatException)
        {
            ShowWarning(WrongFormat);
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при обновлении группы", ex);
        }
    }

    private void deleteGroupButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (treeViewGroups.SelectedNode != null)
            {
                var selectedText = treeViewGroups.SelectedNode.ToString();

                if (selectedText == null) return;

                var idStartIndex = selectedText.IndexOf("ID: ", StringComparison.Ordinal) + 4;
                var idEndIndex = selectedText.IndexOf(",", idStartIndex, StringComparison.Ordinal);
                var idString = selectedText.Substring(idStartIndex, idEndIndex - idStartIndex);

                if (int.TryParse(idString, out var groupId))
                {
                    var groupService = new TGroupService();

                    groupService.DeleteGroup(groupId);

                    get_groups_Click(sender, e);

                    ShowInfo("Группа удалена");
                }
                else
                {
                    ShowWarning("Не удалось определить ID выбранной группы");
                }
            }
            else
            {
                ShowWarning("Пожалуйста, выберите группу для удаления");
            }
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при удалении группы", ex);
        }
    }


    private void listGroups_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (treeViewGroups.SelectedNode != null)
        {
            ShowInfo($"Вы выбрали: {treeViewGroups.SelectedNode}");
        }
    }


    //TRelations
    private void getAllRelations_Click(object sender, EventArgs e)
    {
        try
        {
            var relationService = new TRelationService();

            var relations = relationService.GetAllRelations();

            listBoxRelations.Items.Clear();

            foreach (var relation in relations)
            {
                listBoxRelations.Items.Add(relation.ToString());
            }

            ShowInfo(relations.Count == 0 ? "Отношения не найдены" : "Отношения загружены");
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при загрузке отношений", ex);
        }
    }

    private void addRelation_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(relationNameTextBox.Text))
            {
                relationNameTextBox.Text = @"Введите корректные данные";
                return;
            }

            var selectedText = treeViewGroups.SelectedNode.ToString()!;

            var idStartIndex = selectedText.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedText.IndexOf(",", idStartIndex, StringComparison.Ordinal);
            var idString = selectedText.Substring(idStartIndex, idEndIndex - idStartIndex);
            if (!int.TryParse(idString, out var groupId)) return;
            var newRelation = new TRelation
            {
                RelationName = relationNameTextBox.Text.Trim(),
                GroupId = groupId
            };

            var relationService = new TRelationService();

            relationService.AddRelation(newRelation);

            getAllRelations_Click(sender, e);

            ShowInfo("Отношение добавлено");
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при добавлении отношения", ex);
        }
    }

    private void updateRelation_Click(object sender, EventArgs e)
    {
        try
        {
            if (listBoxRelations.SelectedItem == null)
            {
                ShowWarning("Выберите отношение для обновления");
                return;
            }

            var selectedItem = listBoxRelations.SelectedItem.ToString()!;

            var idStartIndex = selectedItem.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedItem.IndexOf(',', idStartIndex);
            var idString = selectedItem.Substring(idStartIndex, idEndIndex - idStartIndex);
            var relationId = int.Parse(idString);

            if (string.IsNullOrWhiteSpace(relationNameTextBox.Text))
            {
                ShowWarning("Введите новые ID группы и связанной группы");
                return;
            }

            var relationService = new TRelationService();

            var updatedRelation = new UpdateTRelation
            {
                Id = relationId,
                RelationName = relationNameTextBox.Text
            };

            relationService.UpdateRelation(updatedRelation);

            ShowInfo("Отношение обновлено");

            getAllRelations_Click(sender, e);
        }
        catch (FormatException)
        {
            ShowError(WrongFormat);
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при обновлении отношения", ex);
        }
    }

    private void deleteRelation_Click(object sender, EventArgs e)
    {
        try
        {
            if (listBoxRelations.SelectedItem != null)
            {
                var selectedText = listBoxRelations.SelectedItem.ToString()!;

                var idStartIndex = selectedText.IndexOf("ID: ", StringComparison.Ordinal) + 4;
                var idEndIndex = selectedText.IndexOf(",", idStartIndex, StringComparison.Ordinal);
                var idString = selectedText.Substring(idStartIndex, idEndIndex - idStartIndex);
                if (!int.TryParse(idString, out var relationId)) return;
                if (relationId != -1)
                {
                    var relationService = new TRelationService();

                    relationService.DeleteRelation(relationId);


                    getAllRelations_Click(sender, e);

                    ShowInfo($"Отношение с ID {relationId} удалено");
                }
                else
                {
                    ShowError("Не удалось извлечь ID из выбранного элемента");
                }
            }
            else
            {
                ShowWarning("Выберите отношение для удаления");
            }
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при удалении отношения", ex);
        }
    }


    //TProperties
    private void getAllProperties_Click_1(object sender, EventArgs e)
    {
        try
        {
            var propertyService = new TPropertyService();

            var properties = propertyService.GetAllProperties();

            listBoxProperties.Items.Clear();

            foreach (var property in properties)
            {
                listBoxProperties.Items.Add(property.ToString());
            }

            ShowInfo(properties.Count == 0 ? "Свойства не найдены" : "Свойства загружены");
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при загрузке свойств", ex);
        }
    }

    private void addProperty_Click(object sender, EventArgs e)
    {
        try
        {
            var propertyService = new TPropertyService();

            var selectedText = treeViewGroups.SelectedNode.ToString()!;

            var idStartIndex = selectedText.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedText.IndexOf(",", idStartIndex, StringComparison.Ordinal);
            var idString = selectedText.Substring(idStartIndex, idEndIndex - idStartIndex);
            if (int.TryParse(idString, out var groupId))
            {
                var property = new TProperty
                {
                    Name = properyNameTextBox.Text.Trim(),
                    Value = textBoxPropertyValue.Text.Trim(),
                    GroupId = groupId
                };
                propertyService.AddProperty(property);

                ShowInfo("Свойство добавлено");

                properyNameTextBox.Clear();
                textBoxPropertyValue.Clear();
                textBoxGroupId.Clear();

                getAllProperties_Click_1(sender, e);
            }
            else
            {
                ShowWarning(WrongFormat);
            }
        }
        catch (FormatException)
        {
            ShowWarning(WrongFormat);
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при добавлении свойства", ex);
        }
    }

    private void updateProperty_Click(object sender, EventArgs e)
    {
        try
        {
            if (listBoxProperties.SelectedItem == null)
            {
                ShowWarning("Выберите свойство для обновления");
                return;
            }

            var selectedItem = listBoxProperties.SelectedItem.ToString()!;

            var idStartIndex = selectedItem.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedItem.IndexOf(',', idStartIndex);
            var idString = selectedItem.Substring(idStartIndex, idEndIndex - idStartIndex);
            var propertyId = int.Parse(idString);

            if (string.IsNullOrWhiteSpace(properyNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(textBoxPropertyValue.Text))
            {
                ShowWarning("Введите имя, значение и ID группы для обновления");
                return;
            }

            var propertyService = new TPropertyService();

            var updatedProperty = new UpdateTProperty
            {
                Id = propertyId,
                Name = properyNameTextBox.Text.Trim(),
                Value = textBoxPropertyValue.Text.Trim()
            };

            propertyService.UpdateProperty(updatedProperty);

            ShowInfo("Свойство обновлено");

            properyNameTextBox.Clear();
            textBoxPropertyValue.Clear();

            getAllProperties_Click_1(sender, e);
        }
        catch (FormatException)
        {
            ShowWarning(WrongFormat);
        }
        catch (Exception ex)
        {
            ShowError($"Ошибка при обновлении свойства", ex);
        }
    }


    private void deleteProperty_Click(object sender, EventArgs e)
    {
        try
        {
            if (listBoxProperties.SelectedItem == null)
            {
                ShowWarning("Выберите свойство для удаления");
                return;
            }

            var selectedItem = listBoxProperties.SelectedItem.ToString()!;

            var idStartIndex = selectedItem.IndexOf("ID: ", StringComparison.Ordinal) + 4;
            var idEndIndex = selectedItem.IndexOf(',', idStartIndex);
            var idString = selectedItem.Substring(idStartIndex, idEndIndex - idStartIndex);
            var propertyId = int.Parse(idString);

            var propertyService = new TPropertyService();

            propertyService.DeleteProperty(propertyId);

            ShowInfo("Свойство удалено");

            getAllProperties_Click_1(sender, e);
        }
        catch (FormatException)
        {
            ShowWarning(WrongFormat);
        }
        catch (Exception ex)
        {
            ShowError("Ошибка при удалении свойства", ex);
        }
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void hideAll()
    {
        addGroup.Hide();
        updateGroup.Hide();
        groupNameTextBox.Hide();
        groupNameLabel.Hide();
        groupDescriptionTextBox.Hide();
        groupDescriptionLabel.Hide();

        addProperty.Hide();
        updateProperty.Hide();
        properyNameTextBox.Hide();
        getPropertiesNameLabel.Hide();
        textBoxPropertyValue.Hide();
        getProperyValueLabel.Hide();

        addRelation.Hide();
        updateRelation.Hide();
        relationNameTextBox.Hide();
        getGroupsNameLabel.Hide();

        deleteGroup.Hide();
        deleteProperty.Hide();
        deleteRelation.Hide();

        dropDataBase.Hide();
    }

    private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        addGroup.Show();
        groupNameTextBox.Show();
        groupNameLabel.Show();
        groupDescriptionTextBox.Show();
        groupDescriptionLabel.Show();
    }

    private void newPropertyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        addProperty.Show();
        properyNameTextBox.Show();
        getPropertiesNameLabel.Show();
        textBoxPropertyValue.Show();
        getProperyValueLabel.Show();
    }

    private void newRelationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        addRelation.Show();
        relationNameTextBox.Show();
        getGroupsNameLabel.Show();
    }

    private void groupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        updateGroup.Show();
        groupNameTextBox.Show();
        groupNameLabel.Show();
        groupDescriptionTextBox.Show();
        groupDescriptionLabel.Show();
    }

    private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        updateProperty.Show();
        properyNameTextBox.Show();
        getPropertiesNameLabel.Show();
        textBoxPropertyValue.Show();
        getProperyValueLabel.Show();
    }

    private void relationToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        hideAll();

        updateRelation.Show();
        relationNameTextBox.Show();
        getGroupsNameLabel.Show();
    }

    private void groupToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        hideAll();

        deleteGroup.Show();
    }

    private void propertyToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        hideAll();

        deleteProperty.Show();
    }

    private void relationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        deleteRelation.Show();
    }

    private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();

        dropDataBase.Show();
    }

    private void hideActionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        hideAll();
    }
}