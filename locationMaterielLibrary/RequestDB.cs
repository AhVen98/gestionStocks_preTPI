using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace locationMaterielLibrary
{
    public class RequestDB
    {
        MySqlCommand cmd;
        /**
                // Requête SQL
                cmd.CommandText = "INSERT INTO objects (id, name, tel) VALUES (@id, @name, @tel)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", newObject.Id);
                cmd.Parameters.AddWithValue("@name", newObject.Name);
                cmd.Parameters.AddWithValue("@tel", newObject.Tel);
         */
        public MySqlCommand ShowObject(int id, bool state)
        {
            // the object is available to rent (not rented)
            if (state == true)
            {
                cmd.CommandText = "SELECT objects.name, objects.state, persons.firstname persons.lastname, locations.endDateLocation, types.name FROM types, objects, locations, persons WHERE objects.id =@id AND locations.locator_id = persons.id AND types.id = objects.type_id";
            }
            // the object is unavailable to rent (already rented)
            else
            {
                cmd.CommandText = "SELECT objects.name, objects.state, types.name FROM types, objects, WHERE objects.id=@id AND types.id = objects.type_id";
            }
            cmd.Parameters.AddWithValue("@id", id);
            return cmd;
        }

        public MySqlCommand GetStateFromObject(int id)
        {
            cmd.CommandText = "SELECT objects.state FROM objects WHERE objects.id =@id";
            cmd.Parameters.AddWithValue("@id", id);
            return cmd;
        }
    }
}
