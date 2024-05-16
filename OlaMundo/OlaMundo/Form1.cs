using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class frmOlaMundo : Form
    {
        public frmOlaMundo()
        {
            InitializeComponent();
        }

        private void btnOlaMundo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!","Título", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            string nome = "Victor Osorio";
            int idade = 23;

            MessageBox.Show("Olá "+ nome+", sua idade é "+ idade+" anos.",
                "Nome e Idade", MessageBoxButtons.OK,
                MessageBoxIcon.Information );

            string mensagem = nome + ", sua UC12 começou!";

            MessageBox.Show(mensagem, "Unidade Curricular", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
