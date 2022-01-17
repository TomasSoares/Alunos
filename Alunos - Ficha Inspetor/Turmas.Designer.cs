
namespace Alunos___Ficha_Inspetor
{
    partial class Turmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turmas));
            System.Windows.Forms.Label numturmaLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label diretorturmaLabel;
            this.database1DataSet = new Alunos___Ficha_Inspetor.Database1DataSet();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasTableAdapter = new Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.tableAdapterManager = new Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.TableAdapterManager();
            this.turmasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.turmasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numturmaTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.diretorturmaTextBox = new System.Windows.Forms.TextBox();
            numturmaLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            diretorturmaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingNavigator)).BeginInit();
            this.turmasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.database1DataSet;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = this.turmasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Alunos___Ficha_Inspetor.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // turmasBindingNavigator
            // 
            this.turmasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.turmasBindingNavigator.BindingSource = this.turmasBindingSource;
            this.turmasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.turmasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.turmasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.turmasBindingNavigatorSaveItem});
            this.turmasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.turmasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.turmasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.turmasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.turmasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.turmasBindingNavigator.Name = "turmasBindingNavigator";
            this.turmasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.turmasBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.turmasBindingNavigator.TabIndex = 0;
            this.turmasBindingNavigator.Text = "bindingNavigator1";
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
            // turmasBindingNavigatorSaveItem
            // 
            this.turmasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.turmasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("turmasBindingNavigatorSaveItem.Image")));
            this.turmasBindingNavigatorSaveItem.Name = "turmasBindingNavigatorSaveItem";
            this.turmasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.turmasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.turmasBindingNavigatorSaveItem.Click += new System.EventHandler(this.turmasBindingNavigatorSaveItem_Click);
            // 
            // numturmaLabel
            // 
            numturmaLabel.AutoSize = true;
            numturmaLabel.Location = new System.Drawing.Point(12, 42);
            numturmaLabel.Name = "numturmaLabel";
            numturmaLabel.Size = new System.Drawing.Size(56, 13);
            numturmaLabel.TabIndex = 1;
            numturmaLabel.Text = "numturma:";
            // 
            // numturmaTextBox
            // 
            this.numturmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "numturma", true));
            this.numturmaTextBox.Location = new System.Drawing.Point(83, 39);
            this.numturmaTextBox.Name = "numturmaTextBox";
            this.numturmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numturmaTextBox.TabIndex = 2;
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(12, 68);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(36, 13);
            cursoLabel.TabIndex = 3;
            cursoLabel.Text = "curso:";
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(83, 65);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cursoTextBox.TabIndex = 4;
            // 
            // diretorturmaLabel
            // 
            diretorturmaLabel.AutoSize = true;
            diretorturmaLabel.Location = new System.Drawing.Point(12, 94);
            diretorturmaLabel.Name = "diretorturmaLabel";
            diretorturmaLabel.Size = new System.Drawing.Size(65, 13);
            diretorturmaLabel.TabIndex = 5;
            diretorturmaLabel.Text = "diretorturma:";
            // 
            // diretorturmaTextBox
            // 
            this.diretorturmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.turmasBindingSource, "diretorturma", true));
            this.diretorturmaTextBox.Location = new System.Drawing.Point(83, 91);
            this.diretorturmaTextBox.Name = "diretorturmaTextBox";
            this.diretorturmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.diretorturmaTextBox.TabIndex = 6;
            // 
            // Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 138);
            this.Controls.Add(numturmaLabel);
            this.Controls.Add(this.numturmaTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(diretorturmaLabel);
            this.Controls.Add(this.diretorturmaTextBox);
            this.Controls.Add(this.turmasBindingNavigator);
            this.Name = "Turmas";
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.Turmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingNavigator)).EndInit();
            this.turmasBindingNavigator.ResumeLayout(false);
            this.turmasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private Database1DataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator turmasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton turmasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numturmaTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox diretorturmaTextBox;
    }
}