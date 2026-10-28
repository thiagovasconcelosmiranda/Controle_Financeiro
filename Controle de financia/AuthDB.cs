using Controle_de_financia2.infrastructure;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class AuthDB
    {
        DbConection conn = new DbConection();

        public int adicionar(Auth auth)
        {
          try {
           
           NpgsqlCommand query = new NpgsqlCommand(
             "INSERT INTO public.\"Auth_acess_db\" (email, password, question, response, created_at, updated_at) " +
             "VALUES (@email, @password, @question, @response, @created_at, @updated_at) RETURNING id", conn.connection);
           
            conn.Open();

            query.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = auth.email;
            query.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = auth.password;
            query.Parameters.AddWithValue("@question", SqlDbType.VarChar).Value = auth.question;
            query.Parameters.AddWithValue("@response", SqlDbType.VarChar).Value = auth.response;
            query.Parameters.AddWithValue("@created_at", SqlDbType.DateTime).Value= DateTime.Now;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = DateTime.Now;


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
            conn.Close();
            return 0;
        }

        public int excluir(int id)
        {
            try{
                NpgsqlCommand query = new NpgsqlCommand(
                 "Delete From public.\"Auth_acess_db\" WHERE id=@id;", conn.connection);
                
                conn.Open();
                query.Parameters.AddWithValue("@id", id);

                query.ExecuteNonQuery();
                conn.Close();
                return 1;
              
            }
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();

            }
            conn.Close();
            return 0;
        }

        public int update(Auth auth)
        {

            try
            {
                NpgsqlCommand query = new NpgsqlCommand(
              "Update public.\"Auth_acess_db\" set email=@email, password=@password, updated_at=@updated_at," +
              " question=@question,response=@response Where id=@id RETURNING id", conn.connection);

                conn.Open();

                query.Parameters.AddWithValue("@id", auth.id);
                query.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = auth.email;
                query.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = auth.password;
                query.Parameters.AddWithValue("@question", SqlDbType.VarChar).Value = auth.question;
                query.Parameters.AddWithValue("@response", SqlDbType.VarChar).Value = auth.response;
                query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = auth.updated_at;


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

        public Auth authlogin(Auth auth)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(
              "SELECT * FROM public.\"Auth_acess_db\" WHERE email=@email", conn.connection);
            
            conn.Open();

            cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = auth.email;
            try
            {

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read()) {
                    Auth a = new Auth()
                    {
                       id = (int)reader["id"],
                       email = (string)reader["email"],
                       password = (string)reader["password"],
                       question = (string)reader["question"],
                       response = (string)reader["response"]

                    };
                    conn.Close();
                    return a;
                     
                }
            }
            }
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();

            }
            conn.Close();
            return null;     
        }

        public Auth getSegret(string response, int id)
        {
            NpgsqlCommand query = new NpgsqlCommand(
              "SELECT * FROM public.\"Auth_acess_db\" WHERE id=@id AND response=@response",
            conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@response", SqlDbType.VarChar).Value = response;
            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;


            using (var reader = query.ExecuteReader())
            {
                if (reader.Read())
                {
                    Auth auth = new Auth()
                    {
                        id = (int)reader["id"],
                        response = (string)reader["response"]
                    };
                    conn.Close();
                    return auth;
                }
            }
            conn.Close();
             return null;
        }
    }
}
