using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarData_Click(object sender, EventArgs e)
        {
            textBoxInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtInicialAuto.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtFinalAuto.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txtAtualAuto.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("Você está lendo uma mensagem.","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
