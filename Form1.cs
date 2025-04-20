using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lista_jugadores.Class;
using MySql.Data.MySqlClient;

namespace lista_jugadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Players players = new Players();
            players.getPlayers(list_players);
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Players players = new Players();
            players.addPlayer(name_txb, lastname_txb, position_txb);
            players.getPlayers(list_players);

            // clear fields after saving
            name_txb.Text = "";
            lastname_txb.Text = "";
            position_txb.Text = "";
        }

        private void list_players_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = list_players.Rows[e.RowIndex];

                // get data selected from the database
                string id = row.Cells["id"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido = row.Cells["apellido"].Value.ToString();
                string posicion = row.Cells["posicion"].Value.ToString();

                UpdatePlayer updateForm = new UpdatePlayer(id, nombre, apellido, posicion);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    Players players = new Players();
                    players.getPlayers(list_players);
                }
            }
        }
    }
}
