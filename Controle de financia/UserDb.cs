using Controle_de_financia2.infrastructure;
using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class UserDb
    {
        DbConection conn = new DbConection();
        public int excluir(int authId)
        {
          try
          {
              NpgsqlCommand query = new NpgsqlCommand(
                "Delete From public.\"User_db\" Where authId=@authId RETURNING id", conn.connection);

                conn.Open();

                query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = authId;

                int result = (int)query.ExecuteScalar();

                if (result > 0)
                {
                    conn.Close();
                    return result;
                }
           }
           catch (NpgsqlException e)
          {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
          }
          conn.Close();
          return 0;
        }
        public int update(User user)
        {
            try
            {
                NpgsqlCommand query = new NpgsqlCommand(
               "Update public.\"User_db\"" +
               " Set firstname=@firstname, lastname=@lastname, birth=@birth, sex=@sex, updated_at=@updated_at" +
               " Where authId=@authId RETURNING id", conn.connection);

                conn.Open();

                query.Parameters.AddWithValue("@firstname", SqlDbType.VarChar).Value = user.firstname;
                query.Parameters.AddWithValue("@lastname", SqlDbType.VarChar).Value = user.lastname;
                query.Parameters.AddWithValue("@birth", SqlDbType.VarChar).Value = user.birst;
                query.Parameters.AddWithValue("@sex", SqlDbType.VarChar).Value = user.sex;
                query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = user.authId;
                query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = user.updated_at;

                int id = (int)query.ExecuteScalar();

                if (id > 0)
                {
                    conn.Close();
                    return id;
                } 
            }

            catch (SqlException e)
            {
                conn.Close();
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
            }
            conn.Close();
            return 0;
        }
       
        public User getUserAuthId(int id)
        {
            NpgsqlCommand query = new NpgsqlCommand(
            "SELECT * FROM public.\"User_db\"" +
            " JOIN public.\"Auth_acess_db\"" +
            " ON public.\"Auth_acess_db\".id=public.\"User_db\".AuthId" +
            " WHERE public.\"User_db\".AuthId=@authId", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = id;

            using (var reader = query.ExecuteReader())
            {
                if (reader.Read())
                {
                    User user = new User()
                    {
                        id = Convert.ToInt32(reader["Id"]),
                        firstname = reader["firstname"].ToString(),
                        lastname = reader["lastname"].ToString(),
                        birst = reader["birth"].ToString(),
                        sex = reader["sex"].ToString(),
                        cpf = reader["cpf"].ToString(),
                        email = reader["email"].ToString(),
                        password = reader["password"].ToString(),
                        question = reader["question"].ToString(),
                        response = reader["response"].ToString()

                    };
                    conn.Close();
                    return user;
                }
            }
            conn.Close();
            return null;
        }

        public int adicionar(User user)
        {
          try
          {

            NpgsqlCommand query = new NpgsqlCommand(
            "INSERT INTO public.\"User_db\" (firstname, lastname, cpf, cnpj, sex," +
            " birth, authId, created_at, updated_at)" +
            "values(@firstname, @lastname, @cpf, @cnpj, @sex, @birth, @authId,"+
            " @created_at, @updated_at) RETURNING id", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@firstname", SqlDbType.VarChar).Value = user.firstname;
            query.Parameters.AddWithValue("@lastname", SqlDbType.VarChar).Value = user.lastname;
            query.Parameters.AddWithValue("@cpf", SqlDbType.VarChar).Value = user.cpf;
            query.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = user.cnpj;
            query.Parameters.AddWithValue("@birth", SqlDbType.VarChar).Value = user.birst;
            query.Parameters.AddWithValue("@sex", SqlDbType.VarChar).Value = user.sex;
            query.Parameters.AddWithValue("@authId", SqlDbType.Int).Value = user.authId;
            query.Parameters.AddWithValue("@created_at", SqlDbType.DateTime).Value = user.created_at;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = user.updated_at;

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


    }
}
