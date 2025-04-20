using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lista_jugadores.Clases;
using MySql.Data.MySqlClient;

namespace lista_jugadores.Class
{
    internal class Players
    {
        // function to get all players from the database
        public void getPlayers(DataGridView list_players)
        {
            try
            {
                DBconnection newConnection = new DBconnection();
                String query = "select * from jugadores order by id desc";
                list_players.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, newConnection.setConnection());
                DataTable data_table = new DataTable();
                adapter.Fill(data_table);
                list_players.DataSource = data_table;
                newConnection.dropConnection();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar la data", ex.Message );
            }
        }

        // function to add a new player to the database
        public void addPlayer(TextBox name_txb, TextBox lastname_txb, TextBox position_txb) 
        { 
            try
            {
                DBconnection newConnection = new DBconnection();
                String query = "insert into jugadores (nombre, apellido, posicion)"+"values('"+name_txb.Text+"','"+lastname_txb.Text+ "','"+position_txb.Text+"');";
                MySqlCommand newCommand = new MySqlCommand(query, newConnection.setConnection());
                MySqlDataReader reader = newCommand.ExecuteReader();
                while (reader.Read()) { }
                newConnection.dropConnection();
                MessageBox.Show("Jugador agregado correctamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar el jugador: " + ex.Message);
            }
        }

        // function to update a player from the database
        public void updatePlayer(TextBox name_txb, TextBox lastname_txb, TextBox position_txb, string playerId)
        {
            try
            {
                DBconnection newConnection = new DBconnection();
                string query = "UPDATE jugadores SET nombre = '" + name_txb.Text + "', apellido = '" + lastname_txb.Text + "', posicion = '" + position_txb.Text + "' WHERE id = '" + playerId + "';";

                MySqlCommand newCommand = new MySqlCommand(query, newConnection.setConnection());
                MySqlDataReader reader = newCommand.ExecuteReader();
                while (reader.Read()) { }

                newConnection.dropConnection();
                MessageBox.Show("Jugador actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar jugador: " + ex.Message);
            }
        }

        // function to delete a player from the database
        public void deletePlayer(string playerId)
        {
            try
            {
                DBconnection newConnection = new DBconnection();

                // La consulta DELETE para eliminar el jugador con el ID especificado
                string query = "DELETE FROM jugadores WHERE id = '" + playerId + "';";

                MySqlCommand newCommand = new MySqlCommand(query, newConnection.setConnection());
                MySqlDataReader reader = newCommand.ExecuteReader();

                // Opcional: Si deseas hacer algo con los datos, lo puedes hacer aquí.
                while (reader.Read()) { }

                newConnection.dropConnection();
                MessageBox.Show("Jugador eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar jugador: " + ex.Message);
            }
        }

        internal void getPlayers(object list_players)
        {
            throw new NotImplementedException();
        }
    }
}
