using Controle_de_financia2.infrastructure;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class WorkDb
    {
        DbConection conn = new DbConection();

        public Work getWorkAuthId(int id)
        {
            NpgsqlCommand query = new NpgsqlCommand(
               "Select * From public.\"Work_db\" where authId=@authId;"
            , conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = id;

            using (var reader = query.ExecuteReader())
            {

                if (reader.Read())
                {
                    Work work = new Work();
                    work.id = (int)reader["id"];
                    work.establishment = (string)reader["establishment"];
                    work.position = (string)reader["position"];
                    work.wage = (int)reader["wage"];
                    work.situation = (string)reader["situation"];
                    work.created_at = (DateTime)reader["created_at"];
                    work.updated_at = (DateTime)reader["updated_at"];

                    conn.Close();
                    return work;

                }
            }
           
            return null;
        }

        public int delete(int id)
        {
          try
          {
            
            NpgsqlCommand query = new NpgsqlCommand(
            "Delete From public.\"Work_db\" where authId=@authId RETURNING id"
            , conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = id;

            object result = query.ExecuteScalar();

            if (result != null)
            {
                conn.Close();
                return 1;
            }
            }
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
            }
            conn.Close();
            return 0;
        }

        public int update(Work work)
        {
            try
            {
                NpgsqlCommand query = new NpgsqlCommand(
                 "Update public.\"Work_db\" Set establishment=@establishment, wage=@wage, situation=@situation,  " +
                  "updated_at=@updated_at, position=@position " +
                  "Where authId=@authId RETURNING id", conn.connection);

                  conn.Open();

                query.Parameters.AddWithValue("@establishment", SqlDbType.VarChar).Value = work.establishment;
                query.Parameters.AddWithValue("@wage", SqlDbType.Int).Value = work.wage;
                query.Parameters.AddWithValue("@situation", SqlDbType.VarChar).Value = work.situation;
                query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = work.updated_at;
                query.Parameters.AddWithValue("@position", SqlDbType.VarChar).Value = work.position;
                query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = work.authId;



                int id = (int)query.ExecuteScalar();

                if (id > 0)
                {
                    conn.Close();
                    return id;
                }
                
            }
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
            }
            return 0;
        }

        public int adicionar(Work work)
        {
            try
            {

           NpgsqlCommand query = new NpgsqlCommand(
            "INSERT INTO public.\"Work_db\" (establishment, wage, situation, authId, created_at, updated_at, position)" +
            " VALUES (@establishment, @wage, @situation, @authId, @created_at, @updated_at, @position) RETURNING id", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@establishment", SqlDbType.VarChar).Value = work.establishment;
            query.Parameters.AddWithValue("@wage", SqlDbType.Int).Value = work.wage;
            query.Parameters.AddWithValue("@situation", SqlDbType.VarChar).Value = work.situation;
            query.Parameters.AddWithValue("@created_at", SqlDbType.DateTime).Value = work.created_at;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = work.updated_at;
            query.Parameters.AddWithValue("@position", SqlDbType.VarChar).Value = work.position;
            query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = work.authId;


            int novoId = (int)query.ExecuteScalar();

              if (novoId > 0)
              {
                    conn.Close();
                    return novoId;
              }
            }
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
            }
            
            return 0;
        }
    }
}
