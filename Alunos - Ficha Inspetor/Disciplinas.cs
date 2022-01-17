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
    public partial class Disciplinas : Form
    {
        public Disciplinas()
        {
            InitializeComponent();
        }

        private void disciplinasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Disciplinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
            this.disciplinasTableAdapter.Fill(this.database1DataSet.Disciplinas);

        }
    }
}
