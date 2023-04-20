
namespace Library
{
    partial class Book
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_BookLabel;
            System.Windows.Forms.Label name_BookLabel;
            System.Windows.Forms.Label author_BookLabel;
            System.Windows.Forms.Label annotation_BookLabel;
            System.Windows.Forms.Label number_of_pages_BookLabel;
            System.Windows.Forms.Label type_BookLabel;
            System.Windows.Forms.Label year_of_publishing_BookLabel;
            System.Windows.Forms.Label genre_BookLabel;
            System.Windows.Forms.Label publishing_house_BookLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.bibliotecaDataSet = new Library.BibliotecaDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.BibliotecaDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_BookTextBox = new System.Windows.Forms.TextBox();
            this.name_BookTextBox = new System.Windows.Forms.TextBox();
            this.author_BookTextBox = new System.Windows.Forms.TextBox();
            this.annotation_BookTextBox = new System.Windows.Forms.TextBox();
            this.number_of_pages_BookTextBox = new System.Windows.Forms.TextBox();
            this.type_BookTextBox = new System.Windows.Forms.TextBox();
            this.year_of_publishing_BookTextBox = new System.Windows.Forms.TextBox();
            this.genre_BookTextBox = new System.Windows.Forms.TextBox();
            this.publishing_house_BookTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_BookLabel = new System.Windows.Forms.Label();
            name_BookLabel = new System.Windows.Forms.Label();
            author_BookLabel = new System.Windows.Forms.Label();
            annotation_BookLabel = new System.Windows.Forms.Label();
            number_of_pages_BookLabel = new System.Windows.Forms.Label();
            type_BookLabel = new System.Windows.Forms.Label();
            year_of_publishing_BookLabel = new System.Windows.Forms.Label();
            genre_BookLabel = new System.Windows.Forms.Label();
            publishing_house_BookLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_BookLabel
            // 
            iD_BookLabel.AutoSize = true;
            iD_BookLabel.BackColor = System.Drawing.Color.Transparent;
            iD_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BookLabel.Location = new System.Drawing.Point(302, 229);
            iD_BookLabel.Name = "iD_BookLabel";
            iD_BookLabel.Size = new System.Drawing.Size(61, 38);
            iD_BookLabel.TabIndex = 1;
            iD_BookLabel.Text = "ID:";
            // 
            // name_BookLabel
            // 
            name_BookLabel.AutoSize = true;
            name_BookLabel.BackColor = System.Drawing.Color.Transparent;
            name_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_BookLabel.Location = new System.Drawing.Point(189, 287);
            name_BookLabel.Name = "name_BookLabel";
            name_BookLabel.Size = new System.Drawing.Size(184, 38);
            name_BookLabel.TabIndex = 3;
            name_BookLabel.Text = "Название:";
            // 
            // author_BookLabel
            // 
            author_BookLabel.AutoSize = true;
            author_BookLabel.BackColor = System.Drawing.Color.Transparent;
            author_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            author_BookLabel.Location = new System.Drawing.Point(239, 340);
            author_BookLabel.Name = "author_BookLabel";
            author_BookLabel.Size = new System.Drawing.Size(123, 38);
            author_BookLabel.TabIndex = 5;
            author_BookLabel.Text = "Автор:";
            // 
            // annotation_BookLabel
            // 
            annotation_BookLabel.AutoSize = true;
            annotation_BookLabel.BackColor = System.Drawing.Color.Transparent;
            annotation_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            annotation_BookLabel.Location = new System.Drawing.Point(171, 390);
            annotation_BookLabel.Name = "annotation_BookLabel";
            annotation_BookLabel.Size = new System.Drawing.Size(200, 38);
            annotation_BookLabel.TabIndex = 7;
            annotation_BookLabel.Text = "Аннотация:";
            // 
            // number_of_pages_BookLabel
            // 
            number_of_pages_BookLabel.AutoSize = true;
            number_of_pages_BookLabel.BackColor = System.Drawing.Color.Transparent;
            number_of_pages_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_pages_BookLabel.Location = new System.Drawing.Point(29, 702);
            number_of_pages_BookLabel.Name = "number_of_pages_BookLabel";
            number_of_pages_BookLabel.Size = new System.Drawing.Size(358, 38);
            number_of_pages_BookLabel.TabIndex = 9;
            number_of_pages_BookLabel.Text = "Количество страниц:";
            // 
            // type_BookLabel
            // 
            type_BookLabel.AutoSize = true;
            type_BookLabel.BackColor = System.Drawing.Color.Transparent;
            type_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_BookLabel.Location = new System.Drawing.Point(310, 753);
            type_BookLabel.Name = "type_BookLabel";
            type_BookLabel.Size = new System.Drawing.Size(86, 38);
            type_BookLabel.TabIndex = 11;
            type_BookLabel.Text = "Тип:";
            // 
            // year_of_publishing_BookLabel
            // 
            year_of_publishing_BookLabel.AutoSize = true;
            year_of_publishing_BookLabel.BackColor = System.Drawing.Color.Transparent;
            year_of_publishing_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            year_of_publishing_BookLabel.Location = new System.Drawing.Point(104, 804);
            year_of_publishing_BookLabel.Name = "year_of_publishing_BookLabel";
            year_of_publishing_BookLabel.Size = new System.Drawing.Size(287, 38);
            year_of_publishing_BookLabel.TabIndex = 13;
            year_of_publishing_BookLabel.Text = "Год публикации:";
            // 
            // genre_BookLabel
            // 
            genre_BookLabel.AutoSize = true;
            genre_BookLabel.BackColor = System.Drawing.Color.Transparent;
            genre_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genre_BookLabel.Location = new System.Drawing.Point(280, 855);
            genre_BookLabel.Name = "genre_BookLabel";
            genre_BookLabel.Size = new System.Drawing.Size(115, 38);
            genre_BookLabel.TabIndex = 15;
            genre_BookLabel.Text = "Жанр:";
            // 
            // publishing_house_BookLabel
            // 
            publishing_house_BookLabel.AutoSize = true;
            publishing_house_BookLabel.BackColor = System.Drawing.Color.Transparent;
            publishing_house_BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            publishing_house_BookLabel.Location = new System.Drawing.Point(137, 908);
            publishing_house_BookLabel.Name = "publishing_house_BookLabel";
            publishing_house_BookLabel.Size = new System.Drawing.Size(254, 38);
            publishing_house_BookLabel.TabIndex = 17;
            publishing_house_BookLabel.Text = "Издательство:";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.ReaderTableAdapter = null;
            this.tableAdapterManager.Taken_booksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(1902, 27);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.booksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // iD_BookTextBox
            // 
            this.iD_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ID_Book", true));
            this.iD_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_BookTextBox.Location = new System.Drawing.Point(419, 229);
            this.iD_BookTextBox.Name = "iD_BookTextBox";
            this.iD_BookTextBox.Size = new System.Drawing.Size(256, 45);
            this.iD_BookTextBox.TabIndex = 2;
            // 
            // name_BookTextBox
            // 
            this.name_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Name_Book", true));
            this.name_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_BookTextBox.Location = new System.Drawing.Point(419, 280);
            this.name_BookTextBox.Name = "name_BookTextBox";
            this.name_BookTextBox.Size = new System.Drawing.Size(523, 45);
            this.name_BookTextBox.TabIndex = 4;
            // 
            // author_BookTextBox
            // 
            this.author_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author_Book", true));
            this.author_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_BookTextBox.Location = new System.Drawing.Point(419, 333);
            this.author_BookTextBox.Name = "author_BookTextBox";
            this.author_BookTextBox.Size = new System.Drawing.Size(523, 45);
            this.author_BookTextBox.TabIndex = 6;
            // 
            // annotation_BookTextBox
            // 
            this.annotation_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Annotation_Book", true));
            this.annotation_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.annotation_BookTextBox.Location = new System.Drawing.Point(419, 390);
            this.annotation_BookTextBox.Multiline = true;
            this.annotation_BookTextBox.Name = "annotation_BookTextBox";
            this.annotation_BookTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.annotation_BookTextBox.Size = new System.Drawing.Size(655, 306);
            this.annotation_BookTextBox.TabIndex = 8;
            // 
            // number_of_pages_BookTextBox
            // 
            this.number_of_pages_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Number_of_pages_Book", true));
            this.number_of_pages_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_pages_BookTextBox.Location = new System.Drawing.Point(419, 702);
            this.number_of_pages_BookTextBox.Name = "number_of_pages_BookTextBox";
            this.number_of_pages_BookTextBox.Size = new System.Drawing.Size(256, 45);
            this.number_of_pages_BookTextBox.TabIndex = 10;
            // 
            // type_BookTextBox
            // 
            this.type_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Type_Book", true));
            this.type_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_BookTextBox.Location = new System.Drawing.Point(419, 753);
            this.type_BookTextBox.Name = "type_BookTextBox";
            this.type_BookTextBox.Size = new System.Drawing.Size(256, 45);
            this.type_BookTextBox.TabIndex = 12;
            // 
            // year_of_publishing_BookTextBox
            // 
            this.year_of_publishing_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Year_of_publishing_Book", true));
            this.year_of_publishing_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_of_publishing_BookTextBox.Location = new System.Drawing.Point(419, 804);
            this.year_of_publishing_BookTextBox.Name = "year_of_publishing_BookTextBox";
            this.year_of_publishing_BookTextBox.Size = new System.Drawing.Size(256, 45);
            this.year_of_publishing_BookTextBox.TabIndex = 14;
            // 
            // genre_BookTextBox
            // 
            this.genre_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Genre_Book", true));
            this.genre_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_BookTextBox.Location = new System.Drawing.Point(419, 855);
            this.genre_BookTextBox.Name = "genre_BookTextBox";
            this.genre_BookTextBox.Size = new System.Drawing.Size(256, 45);
            this.genre_BookTextBox.TabIndex = 16;
            // 
            // publishing_house_BookTextBox
            // 
            this.publishing_house_BookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publishing_house_Book", true));
            this.publishing_house_BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publishing_house_BookTextBox.Location = new System.Drawing.Point(419, 908);
            this.publishing_house_BookTextBox.Name = "publishing_house_BookTextBox";
            this.publishing_house_BookTextBox.Size = new System.Drawing.Size(523, 45);
            this.publishing_house_BookTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(989, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 69);
            this.label1.TabIndex = 19;
            this.label1.Text = "Книги";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1365, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 65);
            this.button1.TabIndex = 20;
            this.button1.Text = "+ Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1365, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 65);
            this.button2.TabIndex = 21;
            this.button2.Text = "– Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1365, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 65);
            this.button3.TabIndex = 22;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1365, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 65);
            this.button4.TabIndex = 23;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1365, 618);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(302, 65);
            this.button5.TabIndex = 24;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Library.Properties.Resources._1662067405_45_oir_mobi_p_fon_dlya_slaida_istoricheskii_pinterest_46;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(publishing_house_BookLabel);
            this.Controls.Add(this.publishing_house_BookTextBox);
            this.Controls.Add(genre_BookLabel);
            this.Controls.Add(this.genre_BookTextBox);
            this.Controls.Add(year_of_publishing_BookLabel);
            this.Controls.Add(this.year_of_publishing_BookTextBox);
            this.Controls.Add(type_BookLabel);
            this.Controls.Add(this.type_BookTextBox);
            this.Controls.Add(number_of_pages_BookLabel);
            this.Controls.Add(this.number_of_pages_BookTextBox);
            this.Controls.Add(annotation_BookLabel);
            this.Controls.Add(this.annotation_BookTextBox);
            this.Controls.Add(author_BookLabel);
            this.Controls.Add(this.author_BookTextBox);
            this.Controls.Add(name_BookLabel);
            this.Controls.Add(this.name_BookTextBox);
            this.Controls.Add(iD_BookLabel);
            this.Controls.Add(this.iD_BookTextBox);
            this.Controls.Add(this.booksBindingNavigator);
            this.Name = "Book";
            this.Text = "Книги";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BibliotecaDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_BookTextBox;
        private System.Windows.Forms.TextBox name_BookTextBox;
        private System.Windows.Forms.TextBox author_BookTextBox;
        private System.Windows.Forms.TextBox annotation_BookTextBox;
        private System.Windows.Forms.TextBox number_of_pages_BookTextBox;
        private System.Windows.Forms.TextBox type_BookTextBox;
        private System.Windows.Forms.TextBox year_of_publishing_BookTextBox;
        private System.Windows.Forms.TextBox genre_BookTextBox;
        private System.Windows.Forms.TextBox publishing_house_BookTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

