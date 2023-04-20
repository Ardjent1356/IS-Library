
namespace Library
{
    partial class Taken_books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_Taken_booksLabel;
            System.Windows.Forms.Label date_of_issue_Taken_booksLabel;
            System.Windows.Forms.Label return_date_Taken_booksLabel;
            System.Windows.Forms.Label returned_or_not_Taken_booksLabel;
            System.Windows.Forms.Label iD_BookLabel1;
            System.Windows.Forms.Label iD_ReaderLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taken_books));
            this.bibliotecaDataSet = new Library.BibliotecaDataSet();
            this.taken_booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taken_booksTableAdapter = new Library.BibliotecaDataSetTableAdapters.Taken_booksTableAdapter();
            this.tableAdapterManager = new Library.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.taken_booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.taken_booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_Taken_booksTextBox = new System.Windows.Forms.TextBox();
            this.date_of_issue_Taken_booksDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.return_date_Taken_booksDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returned_or_not_Taken_booksCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_BookListBox = new System.Windows.Forms.ListBox();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.BibliotecaDataSetTableAdapters.BooksTableAdapter();
            this.iD_ReaderListBox = new System.Windows.Forms.ListBox();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new Library.BibliotecaDataSetTableAdapters.ReaderTableAdapter();
            iD_Taken_booksLabel = new System.Windows.Forms.Label();
            date_of_issue_Taken_booksLabel = new System.Windows.Forms.Label();
            return_date_Taken_booksLabel = new System.Windows.Forms.Label();
            returned_or_not_Taken_booksLabel = new System.Windows.Forms.Label();
            iD_BookLabel1 = new System.Windows.Forms.Label();
            iD_ReaderLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_booksBindingNavigator)).BeginInit();
            this.taken_booksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Taken_booksLabel
            // 
            iD_Taken_booksLabel.AutoSize = true;
            iD_Taken_booksLabel.BackColor = System.Drawing.Color.Transparent;
            iD_Taken_booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_Taken_booksLabel.Location = new System.Drawing.Point(405, 286);
            iD_Taken_booksLabel.Name = "iD_Taken_booksLabel";
            iD_Taken_booksLabel.Size = new System.Drawing.Size(61, 38);
            iD_Taken_booksLabel.TabIndex = 1;
            iD_Taken_booksLabel.Text = "ID:";
            // 
            // date_of_issue_Taken_booksLabel
            // 
            date_of_issue_Taken_booksLabel.AutoSize = true;
            date_of_issue_Taken_booksLabel.BackColor = System.Drawing.Color.Transparent;
            date_of_issue_Taken_booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_issue_Taken_booksLabel.Location = new System.Drawing.Point(230, 714);
            date_of_issue_Taken_booksLabel.Name = "date_of_issue_Taken_booksLabel";
            date_of_issue_Taken_booksLabel.Size = new System.Drawing.Size(239, 38);
            date_of_issue_Taken_booksLabel.TabIndex = 7;
            date_of_issue_Taken_booksLabel.Text = "Дата выдачи:";
            // 
            // return_date_Taken_booksLabel
            // 
            return_date_Taken_booksLabel.AutoSize = true;
            return_date_Taken_booksLabel.BackColor = System.Drawing.Color.Transparent;
            return_date_Taken_booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            return_date_Taken_booksLabel.Location = new System.Drawing.Point(201, 776);
            return_date_Taken_booksLabel.Name = "return_date_Taken_booksLabel";
            return_date_Taken_booksLabel.Size = new System.Drawing.Size(266, 38);
            return_date_Taken_booksLabel.TabIndex = 9;
            return_date_Taken_booksLabel.Text = "Дата возврата:";
            // 
            // returned_or_not_Taken_booksLabel
            // 
            returned_or_not_Taken_booksLabel.AutoSize = true;
            returned_or_not_Taken_booksLabel.BackColor = System.Drawing.Color.Transparent;
            returned_or_not_Taken_booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            returned_or_not_Taken_booksLabel.Location = new System.Drawing.Point(163, 839);
            returned_or_not_Taken_booksLabel.Name = "returned_or_not_Taken_booksLabel";
            returned_or_not_Taken_booksLabel.Size = new System.Drawing.Size(296, 38);
            returned_or_not_Taken_booksLabel.TabIndex = 11;
            returned_or_not_Taken_booksLabel.Text = "Вернули или нет:";
            // 
            // iD_BookLabel1
            // 
            iD_BookLabel1.AutoSize = true;
            iD_BookLabel1.BackColor = System.Drawing.Color.Transparent;
            iD_BookLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_BookLabel1.Location = new System.Drawing.Point(297, 402);
            iD_BookLabel1.Name = "iD_BookLabel1";
            iD_BookLabel1.Size = new System.Drawing.Size(165, 38);
            iD_BookLabel1.TabIndex = 19;
            iD_BookLabel1.Text = "ID Книги:";
            // 
            // iD_ReaderLabel1
            // 
            iD_ReaderLabel1.AutoSize = true;
            iD_ReaderLabel1.BackColor = System.Drawing.Color.Transparent;
            iD_ReaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ReaderLabel1.Location = new System.Drawing.Point(237, 569);
            iD_ReaderLabel1.Name = "iD_ReaderLabel1";
            iD_ReaderLabel1.Size = new System.Drawing.Size(223, 38);
            iD_ReaderLabel1.TabIndex = 20;
            iD_ReaderLabel1.Text = "ID Читатели:";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taken_booksBindingSource
            // 
            this.taken_booksBindingSource.DataMember = "Taken books";
            this.taken_booksBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // taken_booksTableAdapter
            // 
            this.taken_booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.ReaderTableAdapter = null;
            this.tableAdapterManager.Taken_booksTableAdapter = this.taken_booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taken_booksBindingNavigator
            // 
            this.taken_booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.taken_booksBindingNavigator.BindingSource = this.taken_booksBindingSource;
            this.taken_booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.taken_booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.taken_booksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.taken_booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.taken_booksBindingNavigatorSaveItem});
            this.taken_booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.taken_booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.taken_booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.taken_booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.taken_booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.taken_booksBindingNavigator.Name = "taken_booksBindingNavigator";
            this.taken_booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.taken_booksBindingNavigator.Size = new System.Drawing.Size(1902, 31);
            this.taken_booksBindingNavigator.TabIndex = 0;
            this.taken_booksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // taken_booksBindingNavigatorSaveItem
            // 
            this.taken_booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.taken_booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("taken_booksBindingNavigatorSaveItem.Image")));
            this.taken_booksBindingNavigatorSaveItem.Name = "taken_booksBindingNavigatorSaveItem";
            this.taken_booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.taken_booksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.taken_booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.taken_booksBindingNavigatorSaveItem_Click);
            // 
            // iD_Taken_booksTextBox
            // 
            this.iD_Taken_booksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taken_booksBindingSource, "ID_Taken_books", true));
            this.iD_Taken_booksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_Taken_booksTextBox.Location = new System.Drawing.Point(537, 283);
            this.iD_Taken_booksTextBox.Name = "iD_Taken_booksTextBox";
            this.iD_Taken_booksTextBox.Size = new System.Drawing.Size(289, 45);
            this.iD_Taken_booksTextBox.TabIndex = 2;
            // 
            // date_of_issue_Taken_booksDateTimePicker
            // 
            this.date_of_issue_Taken_booksDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_of_issue_Taken_booksDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taken_booksBindingSource, "Date_of_issue_Taken_books", true));
            this.date_of_issue_Taken_booksDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_of_issue_Taken_booksDateTimePicker.Location = new System.Drawing.Point(544, 714);
            this.date_of_issue_Taken_booksDateTimePicker.Name = "date_of_issue_Taken_booksDateTimePicker";
            this.date_of_issue_Taken_booksDateTimePicker.Size = new System.Drawing.Size(289, 45);
            this.date_of_issue_Taken_booksDateTimePicker.TabIndex = 8;
            // 
            // return_date_Taken_booksDateTimePicker
            // 
            this.return_date_Taken_booksDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taken_booksBindingSource, "Return_date_Taken_books", true));
            this.return_date_Taken_booksDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_date_Taken_booksDateTimePicker.Location = new System.Drawing.Point(544, 770);
            this.return_date_Taken_booksDateTimePicker.Name = "return_date_Taken_booksDateTimePicker";
            this.return_date_Taken_booksDateTimePicker.Size = new System.Drawing.Size(289, 45);
            this.return_date_Taken_booksDateTimePicker.TabIndex = 10;
            // 
            // returned_or_not_Taken_booksCheckBox
            // 
            this.returned_or_not_Taken_booksCheckBox.AutoSize = true;
            this.returned_or_not_Taken_booksCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returned_or_not_Taken_booksCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.taken_booksBindingSource, "Returned_or_not_Taken_books", true));
            this.returned_or_not_Taken_booksCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returned_or_not_Taken_booksCheckBox.Location = new System.Drawing.Point(639, 849);
            this.returned_or_not_Taken_booksCheckBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.returned_or_not_Taken_booksCheckBox.Name = "returned_or_not_Taken_booksCheckBox";
            this.returned_or_not_Taken_booksCheckBox.Size = new System.Drawing.Size(18, 17);
            this.returned_or_not_Taken_booksCheckBox.TabIndex = 12;
            this.returned_or_not_Taken_booksCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(989, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 69);
            this.label1.TabIndex = 13;
            this.label1.Text = "Взятые книги";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1304, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "+ Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1304, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 65);
            this.button2.TabIndex = 15;
            this.button2.Text = "– Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1304, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 65);
            this.button3.TabIndex = 16;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1304, 537);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 65);
            this.button4.TabIndex = 17;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1304, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(302, 65);
            this.button5.TabIndex = 18;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // iD_BookListBox
            // 
            this.iD_BookListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taken_booksBindingSource, "ID_Book", true));
            this.iD_BookListBox.DataSource = this.booksBindingSource1;
            this.iD_BookListBox.DisplayMember = "Name_Book";
            this.iD_BookListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_BookListBox.FormattingEnabled = true;
            this.iD_BookListBox.ItemHeight = 38;
            this.iD_BookListBox.Location = new System.Drawing.Point(537, 349);
            this.iD_BookListBox.Name = "iD_BookListBox";
            this.iD_BookListBox.Size = new System.Drawing.Size(532, 156);
            this.iD_BookListBox.TabIndex = 20;
            this.iD_BookListBox.ValueMember = "ID_Book";
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.bibliotecaDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // iD_ReaderListBox
            // 
            this.iD_ReaderListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taken_booksBindingSource, "ID_Reader", true));
            this.iD_ReaderListBox.DataSource = this.readerBindingSource;
            this.iD_ReaderListBox.DisplayMember = "FIO_Reader";
            this.iD_ReaderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ReaderListBox.FormattingEnabled = true;
            this.iD_ReaderListBox.ItemHeight = 38;
            this.iD_ReaderListBox.Location = new System.Drawing.Point(537, 530);
            this.iD_ReaderListBox.Name = "iD_ReaderListBox";
            this.iD_ReaderListBox.Size = new System.Drawing.Size(532, 156);
            this.iD_ReaderListBox.TabIndex = 21;
            this.iD_ReaderListBox.ValueMember = "ID_Reader";
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "Reader";
            this.readerBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // Taken_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Library.Properties.Resources._1662067405_45_oir_mobi_p_fon_dlya_slaida_istoricheskii_pinterest_46;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(iD_ReaderLabel1);
            this.Controls.Add(this.iD_ReaderListBox);
            this.Controls.Add(iD_BookLabel1);
            this.Controls.Add(this.iD_BookListBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(returned_or_not_Taken_booksLabel);
            this.Controls.Add(this.returned_or_not_Taken_booksCheckBox);
            this.Controls.Add(return_date_Taken_booksLabel);
            this.Controls.Add(this.return_date_Taken_booksDateTimePicker);
            this.Controls.Add(date_of_issue_Taken_booksLabel);
            this.Controls.Add(this.date_of_issue_Taken_booksDateTimePicker);
            this.Controls.Add(iD_Taken_booksLabel);
            this.Controls.Add(this.iD_Taken_booksTextBox);
            this.Controls.Add(this.taken_booksBindingNavigator);
            this.Name = "Taken_books";
            this.Text = "Взятые книги";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_booksBindingNavigator)).EndInit();
            this.taken_booksBindingNavigator.ResumeLayout(false);
            this.taken_booksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource taken_booksBindingSource;
        private BibliotecaDataSetTableAdapters.Taken_booksTableAdapter taken_booksTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator taken_booksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton taken_booksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_Taken_booksTextBox;
        private System.Windows.Forms.DateTimePicker date_of_issue_Taken_booksDateTimePicker;
        private System.Windows.Forms.DateTimePicker return_date_Taken_booksDateTimePicker;
        private System.Windows.Forms.CheckBox returned_or_not_Taken_booksCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.ListBox iD_BookListBox;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private BibliotecaDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.ListBox iD_ReaderListBox;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private BibliotecaDataSetTableAdapters.ReaderTableAdapter readerTableAdapter;
    }
}