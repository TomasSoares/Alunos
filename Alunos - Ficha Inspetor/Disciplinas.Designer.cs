
namespace Alunos___Ficha_Inspetor
{
    partial class Disciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disciplinas));
            System.Windows.Forms.Label numdiscLabel;
            System.Windows.Forms.Label disciplinaLabel;
            System.Windows.Forms.Label anoLabel;
            this.database1DataSet = new Alunos___Ficha_Inspetor.Database1DataSet();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinasTableAdapter = new Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.DisciplinasTableAdapter();
            this.tableAdapterManager = new Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.TableAdapterManager();
            this.disciplinasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.disciplinasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numdiscTextBox = new System.Windows.Forms.TextBox();
            this.disciplinaTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            numdiscLabel = new System.Windows.Forms.Label();
            disciplinaLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingNavigator)).BeginInit();
            this.disciplinasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplinasBindingSource
            // 
            this.disciplinasBindingSource.DataMember = "Disciplinas";
            this.disciplinasBindingSource.DataSource = this.database1DataSet;
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = this.disciplinasTableAdapter;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disciplinasBindingNavigator
            // 
            this.disciplinasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disciplinasBindingNavigator.BindingSource = this.disciplinasBindingSource;
            this.disciplinasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disciplinasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disciplinasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.disciplinasBindingNavigatorSaveItem});
            this.disciplinasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disciplinasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disciplinasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disciplinasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disciplinasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disciplinasBindingNavigator.Name = "disciplinasBindingNavigator";
            this.disciplinasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disciplinasBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.disciplinasBindingNavigator.TabIndex = 0;
            this.disciplinasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // disciplinasBindingNavigatorSaveItem
            // 
            this.disciplinasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disciplinasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disciplinasBindingNavigatorSaveItem.Image")));
            this.disciplinasBindingNavigatorSaveItem.Name = "disciplinasBindingNavigatorSaveItem";
            this.disciplinasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.disciplinasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.disciplinasBindingNavigatorSaveItem.Click += new System.EventHandler(this.disciplinasBindingNavigatorSaveItem_Click);
            // 
            // numdiscLabel
            // 
            numdiscLabel.AutoSize = true;
            numdiscLabel.Location = new System.Drawing.Point(37, 57);
            numdiscLabel.Name = "numdiscLabel";
            numdiscLabel.Size = new System.Drawing.Size(49, 13);
            numdiscLabel.TabIndex = 1;
            numdiscLabel.Text = "numdisc:";
            // 
            // numdiscTextBox
            // 
            this.numdiscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "numdisc", true));
            this.numdiscTextBox.Location = new System.Drawing.Point(108, 54);
            this.numdiscTextBox.Name = "numdiscTextBox";
            this.numdiscTextBox.Size = new System.Drawing.Size(100, 20);
            this.numdiscTextBox.TabIndex = 2;
            // 
            // disciplinaLabel
            // 
            disciplinaLabel.AutoSize = true;
            disciplinaLabel.Location = new System.Drawing.Point(37, 90);
            disciplinaLabel.Name = "disciplinaLabel";
            disciplinaLabel.Size = new System.Drawing.Size(53, 13);
            disciplinaLabel.TabIndex = 3;
            disciplinaLabel.Text = "disciplina:";
            // 
            // disciplinaTextBox
            // 
            this.disciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "disciplina", true));
            this.disciplinaTextBox.Location = new System.Drawing.Point(108, 87);
            this.disciplinaTextBox.Name = "disciplinaTextBox";
            this.disciplinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.disciplinaTextBox.TabIndex = 4;
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(37, 118);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(28, 13);
            anoLabel.TabIndex = 5;
            anoLabel.Text = "ano:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(108, 111);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 6;
            // 
            // Disciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 193);
            this.Controls.Add(numdiscLabel);
            this.Controls.Add(this.numdiscTextBox);
            this.Controls.Add(disciplinaLabel);
            this.Controls.Add(this.disciplinaTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.disciplinasBindingNavigator);
            this.Name = "Disciplinas";
            this.Text = "Disciplinas";
            this.Load += new System.EventHandler(this.Disciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingNavigator)).EndInit();
            this.disciplinasBindingNavigator.ResumeLayout(false);
            this.disciplinasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource disciplinasBindingSource;
        private Database1DataSetTableAdapters.DisciplinasTableAdapter disciplinasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disciplinasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton disciplinasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numdiscTextBox;
        private System.Windows.Forms.TextBox disciplinaTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
    }
}