﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using locationMateriel;
using System.Linq;
using System.Threading.Tasks;

namespace locationMateriel
{
    public class RequestDB
    {
        MySqlCommand cmd;
        ConnectionDB connDB = new ConnectionDB();
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

        public string GetStateFromObject(int id)
        {
            string res = "";
            
            connDB.CreateQuery();
            cmd.CommandText = "SELECT objects.state FROM objects WHERE objects.id =@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader value = connDB.Select(cmd);
            if (value.Read())
            {
                res = value[0].ToString();
            }
            else
            {
                Controller.MethodToCall("cancel");
            }
            return res;
        }

        public int GetIDFromType(string name)
        {
            int res = 0 ;

            connDB.CreateQuery();
            cmd.CommandText = "SELECT types.id FROM types WHERE types.name = @name";
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader value = connDB.Select(cmd);
            if (value.Read()) {
                res = (int)value[0];
            }
            else 
            {
                Controller.MethodToCall("cancel");
            }
            return res;
        }

        public void AddObject(string name, string type, string description, int employeeNumber, string remark = "")
        {
            int typeID = GetIDFromType(type);

            connDB.CreateQuery();
            // the object has a remark associated to it
            if (remark != "")
            {
                cmd.CommandText = "INSERT INTO objects (name, type_id, adder_id, dateAdded, description, remark) VALUES (@name,  @type, @employeeNumber, @date, @description, @remark)";
            }
            // the object has no remark
            else
            {
                cmd.CommandText = "";
            }
            cmd.Parameters.AddWithValue("@date", DateTime.Today);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", typeID);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@remark", remark);
            cmd.Parameters.AddWithValue("@employeeNumber", employeeNumber);

            connDB.ExecuteQuery(cmd);
        }

    }
}