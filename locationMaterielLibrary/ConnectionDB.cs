using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace locationMateriel
{
    class ConnectionDB
    {
        private MySqlConnection connection;

        // Constructeur
        public ConnectionDB()
        {
            InitConnexion();
        }

        
        // Method to initialize connection
        private void InitConnexion()
        {
            // Création de la chaîne de connexion

            string connectionString = "SERVER=127.0.0.1; DATABASE=materialLocation; UID=root; PASSWORD=root";
            connection = new MySqlConnection(connectionString);

        }

        // Method to initialise the variable for the query
        public static MySqlCommand CreateQuery()
        {
            MySqlCommand cmd = connection.CreateCommand();

            return cmd;
        }

        // Method to execute the query received in parameter
        public static void ExecuteQuery(MySqlCommand command)
        {
            MySqlCommand cmd = command ;
            cmd.ExecuteNonQuery();
        }

        // Method to close the connection to database
        public static void CloseConnection()
        { 
            connection.Close();
        }

        // Méthode pour ajouter un contact
        public static void AddObject(Object newObject)
        {
            try
            {
                // Ouverture de la connexion SQL
                connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = connection.CreateCommand();
                /**
                // Requête SQL
                cmd.CommandText = "INSERT INTO objects (id, name, tel) VALUES (@id, @name, @tel)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", newObject.Id);
                cmd.Parameters.AddWithValue("@name", newObject.Name);
                cmd.Parameters.AddWithValue("@tel", newObject.Tel);
                */
                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                connection.Close();
            }
            catch (Exception exc)
            {

                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }


    }
}
