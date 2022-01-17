using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos___Ficha_Inspetor
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Notas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Notas'. Você pode movê-la ou removê-la conforme necessário.
            this.notasTableAdapter.Fill(this.database1DataSet.Notas);

        }
    }
}
