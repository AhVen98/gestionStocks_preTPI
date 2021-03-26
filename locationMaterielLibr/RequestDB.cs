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
        ConnectionDB connDB = new ConnectionDB();
        
        public MySqlCommand ShowObject(int id, bool state)
        {
            MySqlCommand cmd = connDB.CreateQuery();
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

        public string ReqGetStateFromObject(int id)
        {
            string res = "";
            MySqlCommand cmd = connDB.CreateQuery();

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
                res = "valeur incorrecte récupérée";
            }
            return res;
        }

        public int ReqGetIDFromType(string name)
        {
            connDB.OpenConnection();
            int res = -1 ;
            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT types.id FROM types WHERE types.name = @name";
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader value = connDB.Select(cmd);
            if (value.Read()) {
                res = (int)value[0];
            }
            else 
            {
                // si aucune valeur n'est détectée, le type "divers" est récupéré pour l'objet
                res = 21;
            }
            value.Dispose();
            connDB.CloseConnection();
            return res;
        }

        public int ReqGetIDFromName(string name)
        {
            connDB.OpenConnection();

            int res = -1;
            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT objects.id FROM types WHERE objects.name = @name";
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader value = connDB.Select(cmd);
            if (value.Read())
            {
                res = (int)value[0];
            }                       
            value.Dispose();
            connDB.CloseConnection();
            return res;
        }

        public void ReqAddObject(string name, int typeID, string description, int employeeNumber, string remark = "")
        {
            connDB.OpenConnection();

            MySqlCommand cmd = connDB.CreateQuery();
            // the object has no remark associated to it
            if (remark == "")
            {
                cmd.CommandText = "INSERT INTO objects (name, type_id, adder_id, dateAdded, description) VALUES (@name,  @type, @employeeNumber, @date, @description)";
            }
            // the object has a remark associated
            else
            {
                cmd.CommandText = "INSERT INTO objects (name, type_id, adder_id, dateAdded, description, remark) VALUES (@name,  @type, @employeeNumber, @date, @description, @remark)";
            }
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@date", DateTime.Today);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", typeID);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@remark", remark);
            cmd.Parameters.AddWithValue("@employeeNumber", employeeNumber);

            connDB.ExecuteQuery(cmd);
            connDB.CloseConnection();
        }


        public void ReqRentObject(int objectID, int locator_id, int adder_id, DateTime endRentingTime)
        {
            connDB.OpenConnection();
            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "INSERT INTO locations (object_id, locator_id, adder_id, beginRent, endRent) VALUES (@objID,  @locatorNumber, @employeeNumber, @beginDate, @endDate)";
            
            cmd.Parameters.AddWithValue("@beginDate", DateTime.Today);
            cmd.Parameters.AddWithValue("@objID", objectID);
            cmd.Parameters.AddWithValue("@locatorNumber", locator_id);
            cmd.Parameters.AddWithValue("@employeeNumber", adder_id);
            cmd.Parameters.AddWithValue("@beginDate", DateTime.Today);
            cmd.Parameters.AddWithValue("@endDate", endRentingTime);

            connDB.ExecuteQuery(cmd);
            connDB.CloseConnection();

        }

        public List<Objects> getObjects()
        {
            List<Objects> lstAll = new List<Objects>();
            string state;
            string name;
            
            connDB.OpenConnection();

            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT objects.id, objects.name, types.name AS type, objects.state, persons.firstname, locations.endDateLocation " +
                "FROM " +
                "objects " +
                "LEFT JOIN locations ON objects.id = locations.object_id" +
                " LEFT JOIN persons ON locations.locator_id = persons.id " +
                "INNER JOIN types ON objects.type_id = types.id";
                            
            MySqlDataReader value = connDB.Select(cmd);
            
            while (value.Read())
            {
                name = value[1].ToString();
                state = value[3].ToString();
                Objects obj = new Objects(name, state);
                lstAll.Add(obj);
            }
            return lstAll;
        }

        public void ReqResearchBy(string researchText)
        {
            //List lstObject =[];

            //return lstObject;
        }

        public int ReqPDF(string state)
        {
            int res = -1;
            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT objects.id FROM types WHERE objects.name = @name";
            cmd.Parameters.AddWithValue("@name", state);
            MySqlDataReader value = connDB.Select(cmd);
            if (value.Read())
            {
                res = (int)value[0];
            }
            value.Dispose();
            return res;
        }
    }
}
