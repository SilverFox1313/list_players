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

namespace lista_jugadores
{
    public partial class UpdatePlayer : Form
    {
        public UpdatePlayer(string id, string name, string lastname, string position)
        {
            InitializeComponent();
            name_txb.Text = name;
            lastname_txb.Text = lastname;
            position_txb.Text = position;
            hiddenId = id;
        }

        private void UpdatePlayer_Load(object sender, EventArgs e)
        {

        }
        private string hiddenId;

        private void update_btn_Click(object sender, EventArgs e)
        {
            Players playerManager = new Players();
            playerManager.updatePlayer(name_txb, lastname_txb, position_txb, hiddenId);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este jugador?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Players playerManager = new Players();
                playerManager.deletePlayer(hiddenId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
