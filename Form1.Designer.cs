namespace CoreEntity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            getGroups = new Button();
            addGroup = new Button();
            listBoxGroups = new ListBox();
            deleteGroup = new Button();
            textBoxGroupId = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            getByGroupId = new Button();
            groupNameTextBox = new TextBox();
            groupDescriptionTextBox = new TextBox();
            groupNameLabel = new Label();
            groupDescriptionLabel = new Label();
            listBoxRelations = new ListBox();
            getAllRelations = new Button();
            addRelation = new Button();
            getGroupsNameLabel = new Label();
            relationNameTextBox = new TextBox();
            deleteRelation = new Button();
            dropDataBase = new Button();
            getGroupsIdLabel = new Label();
            textBoxSearch = new TextBox();
            listBoxProperties = new ListBox();
            getAllProperties = new Button();
            getPropertiesNameLabel = new Label();
            properyNameTextBox = new TextBox();
            addProperty = new Button();
            getProperyValueLabel = new Label();
            textBoxPropertyValue = new TextBox();
            deleteProperty = new Button();
            updateGroup = new Button();
            updateRelation = new Button();
            updateProperty = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Indigo;
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 94);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 20;
            label5.Text = "Имя:";
            // 
            // getGroups
            // 
            getGroups.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            getGroups.FlatAppearance.BorderSize = 5;
            getGroups.FlatStyle = FlatStyle.Flat;
            getGroups.ForeColor = Color.Black;
            getGroups.Image = (Image)resources.GetObject("getGroups.Image");
            getGroups.Location = new Point(22, 29);
            getGroups.Name = "getGroups";
            getGroups.Size = new Size(181, 59);
            getGroups.TabIndex = 0;
            getGroups.Text = "Получить группы по имени";
            getGroups.UseVisualStyleBackColor = false;
            getGroups.Click += get_groups_Click;
            // 
            // addGroup
            // 
            addGroup.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            addGroup.FlatAppearance.BorderSize = 5;
            addGroup.FlatStyle = FlatStyle.Flat;
            addGroup.ForeColor = Color.Black;
            addGroup.Image = (Image)resources.GetObject("addGroup.Image");
            addGroup.Location = new Point(276, 221);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(125, 73);
            addGroup.TabIndex = 1;
            addGroup.Text = "Добавить группу";
            addGroup.UseVisualStyleBackColor = false;
            addGroup.Click += button1_Click;
            // 
            // listBoxGroups
            // 
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.ItemHeight = 20;
            listBoxGroups.Location = new Point(12, 387);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(389, 224);
            listBoxGroups.TabIndex = 2;
            listBoxGroups.SelectedIndexChanged += listGroups_SelectedIndexChanged;
            // 
            // deleteGroup
            // 
            deleteGroup.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            deleteGroup.FlatAppearance.BorderSize = 5;
            deleteGroup.FlatStyle = FlatStyle.Flat;
            deleteGroup.ForeColor = Color.Black;
            deleteGroup.Image = (Image)resources.GetObject("deleteGroup.Image");
            deleteGroup.Location = new Point(28, 626);
            deleteGroup.Name = "deleteGroup";
            deleteGroup.Size = new Size(368, 79);
            deleteGroup.TabIndex = 3;
            deleteGroup.Text = "Удалить выбранную группу";
            deleteGroup.UseVisualStyleBackColor = false;
            deleteGroup.Click += deleteGroupButton_Click;
            // 
            // textBoxGroupId
            // 
            textBoxGroupId.Location = new Point(245, 97);
            textBoxGroupId.Name = "textBoxGroupId";
            textBoxGroupId.Size = new Size(156, 27);
            textBoxGroupId.TabIndex = 4;
            // 
            // getByGroupId
            // 
            getByGroupId.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            getByGroupId.FlatAppearance.BorderSize = 5;
            getByGroupId.FlatStyle = FlatStyle.Flat;
            getByGroupId.ForeColor = Color.Black;
            getByGroupId.Image = (Image)resources.GetObject("getByGroupId.Image");
            getByGroupId.Location = new Point(209, 29);
            getByGroupId.Name = "getByGroupId";
            getByGroupId.Size = new Size(192, 62);
            getByGroupId.TabIndex = 7;
            getByGroupId.Text = "Получить группы по ID";
            getByGroupId.UseVisualStyleBackColor = false;
            getByGroupId.Click += getByGroupId_Click;
            // 
            // groupNameTextBox
            // 
            groupNameTextBox.Location = new Point(79, 280);
            groupNameTextBox.Name = "groupNameTextBox";
            groupNameTextBox.Size = new Size(166, 27);
            groupNameTextBox.TabIndex = 8;
            // 
            // groupDescriptionTextBox
            // 
            groupDescriptionTextBox.Location = new Point(120, 316);
            groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            groupDescriptionTextBox.Size = new Size(125, 27);
            groupDescriptionTextBox.TabIndex = 9;
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.BackColor = Color.Indigo;
            groupNameLabel.ForeColor = Color.White;
            groupNameLabel.Location = new Point(29, 280);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new Size(42, 20);
            groupNameLabel.TabIndex = 10;
            groupNameLabel.Text = "Имя:";
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.BackColor = Color.Indigo;
            groupDescriptionLabel.ForeColor = Color.White;
            groupDescriptionLabel.Location = new Point(29, 319);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new Size(82, 20);
            groupDescriptionLabel.TabIndex = 11;
            groupDescriptionLabel.Text = "Описание:";
            // 
            // listBoxRelations
            // 
            listBoxRelations.FormattingEnabled = true;
            listBoxRelations.ItemHeight = 20;
            listBoxRelations.Location = new Point(518, 307);
            listBoxRelations.Name = "listBoxRelations";
            listBoxRelations.Size = new Size(366, 304);
            listBoxRelations.TabIndex = 12;
            // 
            // getAllRelations
            // 
            getAllRelations.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            getAllRelations.FlatAppearance.BorderSize = 5;
            getAllRelations.FlatStyle = FlatStyle.Flat;
            getAllRelations.ForeColor = Color.Black;
            getAllRelations.Image = (Image)resources.GetObject("getAllRelations.Image");
            getAllRelations.Location = new Point(518, 29);
            getAllRelations.Name = "getAllRelations";
            getAllRelations.Size = new Size(366, 59);
            getAllRelations.TabIndex = 13;
            getAllRelations.Text = "Получить связи";
            getAllRelations.UseVisualStyleBackColor = false;
            getAllRelations.Click += getAllRelations_Click;
            // 
            // addRelation
            // 
            addRelation.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            addRelation.FlatAppearance.BorderSize = 5;
            addRelation.FlatStyle = FlatStyle.Flat;
            addRelation.ForeColor = Color.Black;
            addRelation.Image = (Image)resources.GetObject("addRelation.Image");
            addRelation.Location = new Point(518, 237);
            addRelation.Name = "addRelation";
            addRelation.Size = new Size(183, 63);
            addRelation.TabIndex = 14;
            addRelation.Text = "Добавить связь с выбранной группой";
            addRelation.UseVisualStyleBackColor = false;
            addRelation.Click += addRelation_Click;
            // 
            // getGroupsNameLabel
            // 
            getGroupsNameLabel.AutoSize = true;
            getGroupsNameLabel.BackColor = Color.Indigo;
            getGroupsNameLabel.ForeColor = Color.White;
            getGroupsNameLabel.Location = new Point(518, 200);
            getGroupsNameLabel.Name = "getGroupsNameLabel";
            getGroupsNameLabel.Size = new Size(42, 20);
            getGroupsNameLabel.TabIndex = 15;
            getGroupsNameLabel.Text = "Имя:";
            // 
            // relationNameTextBox
            // 
            relationNameTextBox.Location = new Point(566, 197);
            relationNameTextBox.Name = "relationNameTextBox";
            relationNameTextBox.Size = new Size(318, 27);
            relationNameTextBox.TabIndex = 16;
            // 
            // deleteRelation
            // 
            deleteRelation.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            deleteRelation.FlatAppearance.BorderSize = 5;
            deleteRelation.FlatStyle = FlatStyle.Flat;
            deleteRelation.ForeColor = Color.Black;
            deleteRelation.Image = (Image)resources.GetObject("deleteRelation.Image");
            deleteRelation.Location = new Point(518, 626);
            deleteRelation.Name = "deleteRelation";
            deleteRelation.Size = new Size(366, 79);
            deleteRelation.TabIndex = 17;
            deleteRelation.Text = "Удалить выбранную связь";
            deleteRelation.UseVisualStyleBackColor = false;
            deleteRelation.Click += deleteRelation_Click;
            // 
            // dropDataBase
            // 
            dropDataBase.FlatAppearance.BorderColor = Color.Crimson;
            dropDataBase.FlatAppearance.BorderSize = 10;
            dropDataBase.FlatStyle = FlatStyle.Flat;
            dropDataBase.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dropDataBase.ForeColor = Color.Black;
            dropDataBase.Image = (Image)resources.GetObject("dropDataBase.Image");
            dropDataBase.Location = new Point(1356, 8);
            dropDataBase.Name = "dropDataBase";
            dropDataBase.Size = new Size(115, 125);
            dropDataBase.TabIndex = 18;
            dropDataBase.Text = "Удалить базу данных";
            dropDataBase.UseVisualStyleBackColor = false;
            dropDataBase.Click += DropDataBaseClick;
            // 
            // getGroupsIdLabel
            // 
            getGroupsIdLabel.AutoSize = true;
            getGroupsIdLabel.BackColor = Color.Indigo;
            getGroupsIdLabel.ForeColor = Color.White;
            getGroupsIdLabel.Location = new Point(212, 97);
            getGroupsIdLabel.Name = "getGroupsIdLabel";
            getGroupsIdLabel.Size = new Size(27, 20);
            getGroupsIdLabel.TabIndex = 19;
            getGroupsIdLabel.Text = "ID:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(67, 94);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(136, 27);
            textBoxSearch.TabIndex = 21;
            // 
            // listBoxProperties
            // 
            listBoxProperties.FormattingEnabled = true;
            listBoxProperties.ItemHeight = 20;
            listBoxProperties.Location = new Point(1005, 307);
            listBoxProperties.Name = "listBoxProperties";
            listBoxProperties.Size = new Size(335, 304);
            listBoxProperties.TabIndex = 23;
            // 
            // getAllProperties
            // 
            getAllProperties.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            getAllProperties.FlatAppearance.BorderSize = 5;
            getAllProperties.FlatStyle = FlatStyle.Flat;
            getAllProperties.ForeColor = Color.Black;
            getAllProperties.Image = (Image)resources.GetObject("getAllProperties.Image");
            getAllProperties.Location = new Point(1048, 29);
            getAllProperties.Name = "getAllProperties";
            getAllProperties.Size = new Size(280, 59);
            getAllProperties.TabIndex = 24;
            getAllProperties.Text = "Получить свойства";
            getAllProperties.UseVisualStyleBackColor = false;
            getAllProperties.Click += getAllProperties_Click_1;
            // 
            // getPropertiesNameLabel
            // 
            getPropertiesNameLabel.AutoSize = true;
            getPropertiesNameLabel.BackColor = Color.Indigo;
            getPropertiesNameLabel.ForeColor = Color.White;
            getPropertiesNameLabel.Location = new Point(1003, 201);
            getPropertiesNameLabel.Name = "getPropertiesNameLabel";
            getPropertiesNameLabel.Size = new Size(42, 20);
            getPropertiesNameLabel.TabIndex = 25;
            getPropertiesNameLabel.Text = "Имя:";
            // 
            // properyNameTextBox
            // 
            properyNameTextBox.Location = new Point(1058, 198);
            properyNameTextBox.Name = "properyNameTextBox";
            properyNameTextBox.Size = new Size(148, 27);
            properyNameTextBox.TabIndex = 26;
            // 
            // addProperty
            // 
            addProperty.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            addProperty.FlatAppearance.BorderSize = 5;
            addProperty.FlatStyle = FlatStyle.Flat;
            addProperty.ForeColor = Color.Black;
            addProperty.Image = (Image)resources.GetObject("addProperty.Image");
            addProperty.Location = new Point(1229, 167);
            addProperty.Name = "addProperty";
            addProperty.Size = new Size(111, 64);
            addProperty.TabIndex = 27;
            addProperty.Text = "Добавить свойство";
            addProperty.UseVisualStyleBackColor = false;
            addProperty.Click += addProperty_Click;
            // 
            // getProperyValueLabel
            // 
            getProperyValueLabel.AutoSize = true;
            getProperyValueLabel.BackColor = Color.Indigo;
            getProperyValueLabel.ForeColor = Color.White;
            getProperyValueLabel.Location = new Point(1003, 240);
            getProperyValueLabel.Name = "getProperyValueLabel";
            getProperyValueLabel.Size = new Size(45, 20);
            getProperyValueLabel.TabIndex = 28;
            getProperyValueLabel.Text = "Знач:";
            // 
            // textBoxPropertyValue
            // 
            textBoxPropertyValue.Location = new Point(1058, 237);
            textBoxPropertyValue.Name = "textBoxPropertyValue";
            textBoxPropertyValue.Size = new Size(148, 27);
            textBoxPropertyValue.TabIndex = 29;
            // 
            // deleteProperty
            // 
            deleteProperty.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            deleteProperty.FlatAppearance.BorderSize = 5;
            deleteProperty.FlatStyle = FlatStyle.Flat;
            deleteProperty.ForeColor = Color.Black;
            deleteProperty.Image = (Image)resources.GetObject("deleteProperty.Image");
            deleteProperty.Location = new Point(1005, 624);
            deleteProperty.Name = "deleteProperty";
            deleteProperty.Size = new Size(335, 73);
            deleteProperty.TabIndex = 30;
            deleteProperty.Text = "Удалить выбранное свойство";
            deleteProperty.UseVisualStyleBackColor = false;
            deleteProperty.Click += deleteProperty_Click;
            // 
            // updateGroup
            // 
            updateGroup.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            updateGroup.FlatAppearance.BorderSize = 5;
            updateGroup.FlatStyle = FlatStyle.Flat;
            updateGroup.ForeColor = Color.Black;
            updateGroup.Image = (Image)resources.GetObject("updateGroup.Image");
            updateGroup.Location = new Point(276, 300);
            updateGroup.Name = "updateGroup";
            updateGroup.Size = new Size(125, 81);
            updateGroup.TabIndex = 31;
            updateGroup.Text = "Обновить выбранную группу";
            updateGroup.UseVisualStyleBackColor = false;
            updateGroup.Click += updateGroup_Click;
            // 
            // updateRelation
            // 
            updateRelation.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            updateRelation.FlatAppearance.BorderSize = 5;
            updateRelation.FlatStyle = FlatStyle.Flat;
            updateRelation.ForeColor = Color.Black;
            updateRelation.Image = (Image)resources.GetObject("updateRelation.Image");
            updateRelation.Location = new Point(707, 237);
            updateRelation.Name = "updateRelation";
            updateRelation.Size = new Size(177, 64);
            updateRelation.TabIndex = 32;
            updateRelation.Text = "Обновить связь с выбранной группой";
            updateRelation.UseVisualStyleBackColor = false;
            updateRelation.Click += updateRelation_Click;
            // 
            // updateProperty
            // 
            updateProperty.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            updateProperty.FlatAppearance.BorderSize = 5;
            updateProperty.FlatStyle = FlatStyle.Flat;
            updateProperty.ForeColor = Color.Black;
            updateProperty.Image = (Image)resources.GetObject("updateProperty.Image");
            updateProperty.Location = new Point(1229, 237);
            updateProperty.Name = "updateProperty";
            updateProperty.Size = new Size(111, 64);
            updateProperty.TabIndex = 33;
            updateProperty.Text = "Обновить свойство";
            updateProperty.UseVisualStyleBackColor = false;
            updateProperty.Click += updateProperty_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, -331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 1075);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, -73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 1075);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-75, -224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(302, 1075);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(750, -206);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(302, 1075);
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(969, -177);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(302, 1075);
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1266, -177);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(302, 1075);
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1473, 727);
            Controls.Add(updateProperty);
            Controls.Add(updateRelation);
            Controls.Add(updateGroup);
            Controls.Add(deleteProperty);
            Controls.Add(textBoxPropertyValue);
            Controls.Add(getProperyValueLabel);
            Controls.Add(addProperty);
            Controls.Add(properyNameTextBox);
            Controls.Add(getPropertiesNameLabel);
            Controls.Add(getAllProperties);
            Controls.Add(listBoxProperties);
            Controls.Add(textBoxSearch);
            Controls.Add(label5);
            Controls.Add(getGroupsIdLabel);
            Controls.Add(dropDataBase);
            Controls.Add(deleteRelation);
            Controls.Add(relationNameTextBox);
            Controls.Add(getGroupsNameLabel);
            Controls.Add(addRelation);
            Controls.Add(getAllRelations);
            Controls.Add(listBoxRelations);
            Controls.Add(groupDescriptionLabel);
            Controls.Add(groupNameLabel);
            Controls.Add(groupDescriptionTextBox);
            Controls.Add(groupNameTextBox);
            Controls.Add(getByGroupId);
            Controls.Add(textBoxGroupId);
            Controls.Add(deleteGroup);
            Controls.Add(listBoxGroups);
            Controls.Add(addGroup);
            Controls.Add(getGroups);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система групп и связей";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button getGroups;
        private Button addGroup;
        private ListBox listBoxGroups;
        private Button deleteGroup;
        private TextBox textBoxGroupId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button getByGroupId;
        private TextBox groupNameTextBox;
        private TextBox groupDescriptionTextBox;
        private Label groupNameLabel;
        private Label groupDescriptionLabel;
        private ListBox listBoxRelations;
        private Button getAllRelations;
        private Button addRelation;
        private Label getGroupsNameLabel;
        private TextBox relationNameTextBox;
        private Button deleteRelation;
        private Button dropDataBase;
        private Label getGroupsIdLabel;
        private TextBox textBoxSearch;
        private ListBox listBoxProperties;
        private Button getAllProperties;
        private Label getPropertiesNameLabel;
        private TextBox properyNameTextBox;
        private Button addProperty;
        private Label getProperyValueLabel;
        private TextBox textBoxPropertyValue;
        private Button deleteProperty;
        private Button updateGroup;
        private Button updateRelation;
        private Button updateProperty;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}