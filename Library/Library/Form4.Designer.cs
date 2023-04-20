
namespace Library
{
    partial class Reader
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
            System.Windows.Forms.Label iD_ReaderLabel;
            System.Windows.Forms.Label fIO_ReaderLabel;
            System.Windows.Forms.Label address_ReaderLabel;
            System.Windows.Forms.Label phone_ReaderLabel;
            System.Windows.Forms.Label passport_number_ReaderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            this.bibliotecaDataSet = new Library.BibliotecaDataSet();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new Library.BibliotecaDataSetTableAdapters.ReaderTableAdapter();
            this.tableAdapterManager = new Library.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.readerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.readerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ReaderTextBox = new System.Windows.Forms.TextBox();
            this.fIO_ReaderTextBox = new System.Windows.Forms.TextBox();
            this.address_ReaderTextBox = new System.Windows.Forms.TextBox();
            this.phone_ReaderTextBox = new System.Windows.Forms.TextBox();
            this.passport_number_ReaderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_ReaderLabel = new System.Windows.Forms.Label();
            fIO_ReaderLabel = new System.Windows.Forms.Label();
            address_ReaderLabel = new System.Windows.Forms.Label();
            phone_ReaderLabel = new System.Windows.Forms.Label();
            passport_number_ReaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingNavigator)).BeginInit();
            this.readerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ReaderLabel
            // 
            iD_ReaderLabel.AutoSize = true;
            iD_ReaderLabel.BackColor = System.Drawing.Color.Transparent;
            iD_ReaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ReaderLabel.ForeColor = System.Drawing.Color.Black;
            iD_ReaderLabel.Location = new System.Drawing.Point(360, 398);
            iD_ReaderLabel.Name = "iD_ReaderLabel";
            iD_ReaderLabel.Size = new System.Drawing.Size(61, 38);
            iD_ReaderLabel.TabIndex = 1;
            iD_ReaderLabel.Text = "ID:";
            // 
            // fIO_ReaderLabel
            // 
            fIO_ReaderLabel.AutoSize = true;
            fIO_ReaderLabel.BackColor = System.Drawing.Color.Transparent;
            fIO_ReaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIO_ReaderLabel.ForeColor = System.Drawing.Color.Black;
            fIO_ReaderLabel.Location = new System.Drawing.Point(321, 465);
            fIO_ReaderLabel.Name = "fIO_ReaderLabel";
            fIO_ReaderLabel.Size = new System.Drawing.Size(108, 38);
            fIO_ReaderLabel.TabIndex = 3;
            fIO_ReaderLabel.Text = "ФИО:";
            // 
            // address_ReaderLabel
            // 
            address_ReaderLabel.AutoSize = true;
            address_ReaderLabel.BackColor = System.Drawing.Color.Transparent;
            address_ReaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            address_ReaderLabel.ForeColor = System.Drawing.Color.Black;
            address_ReaderLabel.Location = new System.Drawing.Point(306, 532);
            address_ReaderLabel.Name = "address_ReaderLabel";
            address_ReaderLabel.Size = new System.Drawing.Size(126, 38);
            address_ReaderLabel.TabIndex = 5;
            address_ReaderLabel.Text = "Адрес:";
            // 
            // phone_ReaderLabel
            // 
            phone_ReaderLabel.AutoSize = true;
            phone_ReaderLabel.BackColor = System.Drawing.Color.Transparent;
            phone_ReaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phone_ReaderLabel.ForeColor = System.Drawing.Color.Black;
            phone_ReaderLabel.Location = new System.Drawing.Point(267, 603);
            phone_ReaderLabel.Name = "phone_ReaderLabel";
            phone_ReaderLabel.Size = new System.Drawing.Size(172, 38);
            phone_ReaderLabel.TabIndex = 7;
            phone_ReaderLabel.Text = "Телефон:";
            // 
            // passport_number_ReaderLabel
            // 
            passport_number_ReaderLabel.AutoSize = true;
            passport_number_ReaderLabel.BackColor = System.Drawing.Color.Transparent;
            passport_number_ReaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_number_ReaderLabel.ForeColor = System.Drawing.Color.Black;
            passport_number_ReaderLabel.Location = new System.Drawing.Point(117, 682);
            passport_number_ReaderLabel.Name = "passport_number_ReaderLabel";
            passport_number_ReaderLabel.Size = new System.Drawing.Size(356, 38);
            passport_number_ReaderLabel.TabIndex = 9;
            passport_number_ReaderLabel.Text = "Паспортные данные:";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.ReaderTableAdapter = this.readerTableAdapter;
            this.tableAdapterManager.Taken_booksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // readerBindingNavigator
            // 
            this.readerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.readerBindingNavigator.BindingSource = this.readerBindingSource;
            this.readerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.readerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.readerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.readerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.readerBindingNavigatorSaveItem});
            this.readerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.readerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.readerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.readerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.readerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.readerBindingNavigator.Name = "readerBindingNavigator";
            this.readerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.readerBindingNavigator.Size = new System.Drawing.Size(1902, 27);
            this.readerBindingNavigator.TabIndex = 0;
            this.readerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // readerBindingNavigatorSaveItem
            // 
            this.readerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.readerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("readerBindingNavigatorSaveItem.Image")));
            this.readerBindingNavigatorSaveItem.Name = "readerBindingNavigatorSaveItem";
            this.readerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.readerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.readerBindingNavigatorSaveItem.Click += new System.EventHandler(this.readerBindingNavigatorSaveItem_Click_1);
            // 
            // iD_ReaderTextBox
            // 
            this.iD_ReaderTextBox.BackColor = System.Drawing.Color.White;
            this.iD_ReaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "ID_Reader", true));
            this.iD_ReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ReaderTextBox.Location = new System.Drawing.Point(485, 400);
            this.iD_ReaderTextBox.Name = "iD_ReaderTextBox";
            this.iD_ReaderTextBox.Size = new System.Drawing.Size(256, 38);
            this.iD_ReaderTextBox.TabIndex = 2;
            // 
            // fIO_ReaderTextBox
            // 
            this.fIO_ReaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "FIO_Reader", true));
            this.fIO_ReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIO_ReaderTextBox.Location = new System.Drawing.Point(485, 467);
            this.fIO_ReaderTextBox.Name = "fIO_ReaderTextBox";
            this.fIO_ReaderTextBox.Size = new System.Drawing.Size(488, 38);
            this.fIO_ReaderTextBox.TabIndex = 4;
            // 
            // address_ReaderTextBox
            // 
            this.address_ReaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "Address_Reader", true));
            this.address_ReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_ReaderTextBox.Location = new System.Drawing.Point(485, 534);
            this.address_ReaderTextBox.Name = "address_ReaderTextBox";
            this.address_ReaderTextBox.Size = new System.Drawing.Size(256, 38);
            this.address_ReaderTextBox.TabIndex = 6;
            // 
            // phone_ReaderTextBox
            // 
            this.phone_ReaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "Phone_Reader", true));
            this.phone_ReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_ReaderTextBox.Location = new System.Drawing.Point(485, 605);
            this.phone_ReaderTextBox.Name = "phone_ReaderTextBox";
            this.phone_ReaderTextBox.Size = new System.Drawing.Size(214, 38);
            this.phone_ReaderTextBox.TabIndex = 8;
            // 
            // passport_number_ReaderTextBox
            // 
            this.passport_number_ReaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readerBindingSource, "Passport_number_Reader", true));
            this.passport_number_ReaderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_number_ReaderTextBox.Location = new System.Drawing.Point(485, 684);
            this.passport_number_ReaderTextBox.Name = "passport_number_ReaderTextBox";
            this.passport_number_ReaderTextBox.Size = new System.Drawing.Size(214, 38);
            this.passport_number_ReaderTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(866, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "Читатели";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1223, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "+ Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1223, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "– Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1223, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1223, 603);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 65);
            this.button4.TabIndex = 15;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1223, 672);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(302, 65);
            this.button5.TabIndex = 16;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Reader
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
            this.Controls.Add(passport_number_ReaderLabel);
            this.Controls.Add(this.passport_number_ReaderTextBox);
            this.Controls.Add(phone_ReaderLabel);
            this.Controls.Add(this.phone_ReaderTextBox);
            this.Controls.Add(address_ReaderLabel);
            this.Controls.Add(this.address_ReaderTextBox);
            this.Controls.Add(fIO_ReaderLabel);
            this.Controls.Add(this.fIO_ReaderTextBox);
            this.Controls.Add(iD_ReaderLabel);
            this.Controls.Add(this.iD_ReaderTextBox);
            this.Controls.Add(this.readerBindingNavigator);
            this.Name = "Reader";
            this.Text = "Читатели";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingNavigator)).EndInit();
            this.readerBindingNavigator.ResumeLayout(false);
            this.readerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private BibliotecaDataSetTableAdapters.ReaderTableAdapter readerTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator readerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton readerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ReaderTextBox;
        private System.Windows.Forms.TextBox fIO_ReaderTextBox;
        private System.Windows.Forms.TextBox address_ReaderTextBox;
        private System.Windows.Forms.TextBox phone_ReaderTextBox;
        private System.Windows.Forms.TextBox passport_number_ReaderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}