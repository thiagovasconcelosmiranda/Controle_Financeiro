using Controle_de_financia2.infrastructure;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class DebtorsDb
    {
       DbConection conn = new DbConection();

        public int adicionar(Debtor debtor)
        {

          try {
                NpgsqlCommand query = new NpgsqlCommand(
                "INSERT INTO public.\"Debtors_db\" (firstname, lastname, establishment, cpf, cnpj, price, userId, created_at, updated_at, date_operation, " +
                "status, month_reference, year_reference, parc, description, file) " +
                "Values (@firstname, @lastname, @establishment, @cpf, @cnpj, @price, @userId, @created_at, @updated_at, @date_operation, " +
                "@status, @month_reference, @year_reference, @parc, @description, @file) RETURNING id", conn.connection );

            conn.Open();

            query.Parameters.AddWithValue("@firstname", SqlDbType.VarChar).Value = debtor.firstname;
            query.Parameters.AddWithValue("@lastname", SqlDbType.VarChar).Value = debtor.lastname;
            query.Parameters.AddWithValue("@establishment", SqlDbType.VarChar).Value = debtor.establishment;
            query.Parameters.AddWithValue("@cpf", SqlDbType.VarChar).Value = debtor.cpf;
            query.Parameters.AddWithValue("@cnpj", SqlDbType.VarChar).Value = debtor.cnpj;
            query.Parameters.AddWithValue("@price", SqlDbType.Int).Value = debtor.price;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = debtor.userId;
            query.Parameters.AddWithValue("@created_at", SqlDbType.DateTime).Value = debtor.created_at;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = debtor.updated_at;
            query.Parameters.AddWithValue("@date_operation", SqlDbType.VarChar).Value = debtor.date_operation;
            query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = debtor.status;
            query.Parameters.AddWithValue("@month_reference", SqlDbType.Int).Value = debtor.mes_reference;
            query.Parameters.AddWithValue("@year_reference", SqlDbType.Int).Value = debtor.ano_reference;
            query.Parameters.AddWithValue("@parc", SqlDbType.Int).Value = debtor.parc;
            query.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = debtor.description;
            query.Parameters.AddWithValue("@file", SqlDbType.VarChar).Value = debtor.file;

            int novoId = (int)query.ExecuteScalar();

            if (novoId > 1)
            {
                conn.Close();
                return novoId;
            }
            
            }
            catch (SqlException e)
            {
                new FormAlertMessage($" Erro: {e.Message}", false).ShowDialog();
            }
            conn.Close();
            return 0;

        }

        public int update(Debtor debtor)
        {
          try
          {
            NpgsqlCommand query = new NpgsqlCommand(
                "UPDATE public.\"Debtors_db\" SET firstname=@firstname, lastname=@lastname, establishment=@establishment, " +
                "price=@price, updated_at=@updated_at, date_operation=@date_operation, status=@status, "+
                "year_reference=@ano, month_reference=@mes, parc=@parc, description=@description, file=@file " +
                "WHERE id=@id AND userId=@userId RETURNING id", conn.connection
            );
            conn.Open();

            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = debtor.id;
            query.Parameters.AddWithValue("@firstname", SqlDbType.VarChar).Value = debtor.firstname;
            query.Parameters.AddWithValue("@lastname", SqlDbType.VarChar).Value = debtor.lastname;
            query.Parameters.AddWithValue("@establishment", SqlDbType.VarChar).Value = debtor.establishment;
            query.Parameters.AddWithValue("@price", SqlDbType.Int).Value = debtor.price;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = debtor.userId;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = debtor.updated_at;
            query.Parameters.AddWithValue("@date_operation", SqlDbType.VarChar).Value = debtor.date_operation;
            query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = debtor.status;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = debtor.ano_reference;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = debtor.mes_reference;
            query.Parameters.AddWithValue("@parc", SqlDbType.Int).Value = debtor.parc;
            query.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = debtor.description;
            query.Parameters.AddWithValue("@file", SqlDbType.VarChar).Value = debtor.file;

                int novoId = (int)query.ExecuteScalar();

            if (novoId > 0)
            {
                    new FormAlertMessage("Alterardo com sucesso!", true).ShowDialog();
                    conn.Close();
                return 1;
            }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show($"Erro {e.Message}");
            }
            conn.Close();
            return 0;

        }

        public int excluir(int id,int userId)
        {
            try
            {
                NpgsqlCommand query = new NpgsqlCommand(
                    "DELETE FROM public.\"Debtors_db\" WHERE id=@id AND " +
                    "userId=@userId RETURNING id ", conn.connection
                    );

                conn.Open();
                query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

               int Id = (int)query.ExecuteScalar();

                if (Id > 0)
                {
                    conn.Close();
                    return 1;
                }
               
            }
             
            catch (NpgsqlException e)
            {
                new FormAlertMessage($" Erro {e.Message}", false).ShowDialog();
            }
            conn.Close();
            return 0;
        }

        public decimal getDbtorsStatusValor(int mes, int ano, string status, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
            "Select SUM(price) From public.\"Debtors_db\" Where " +
            "month_reference=@mes AND "+
            "year_reference=@ano AND userId=@userId AND status=@status;",
            conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            object result = query.ExecuteScalar();

            decimal valor = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            conn.Close();
            return valor;
        }

        public List<Debtor> GetDebtorsAll(int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
                "SELECT * FROM public.\"Debtors_db\" WHERE userId=@userId;"
                , conn.connection);
            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            using (var rs = query.ExecuteReader())
            {
                List<Debtor> list = new List<Debtor>();

                while (rs.Read())
                {
                    Debtor debtor = new Debtor()
                    {
                        id = (int)rs["id"],
                        firstname = (string)rs["firstname"],
                        lastname = (string)rs["lastname"],
                        establishment = (string)rs["establishment"],
                        cpf = (string)rs["cpf"],
                        cnpj = (string)rs["cnpj"],
                        price = (int)rs["price"],
                        date_operation = (string)rs["date_operation"],
                        status = (string)rs["status"],
                        parc = (int)rs["parc"],
                        description = (string)rs["description"],
                        file = (string)rs["file"]
                    };
                    list.Add(debtor);
                }
                conn.Close();
                return list;
            }
          
        }

        public List<Debtor> getSearchDbtors(string search, int ano, int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
                "SELECT * FROM public.\"Debtors_db\" WHERE userId=@userId AND " +
                "year_reference=@ano AND month_reference=@mes AND " +
                "(firstname LIKE @search OR lastname LIKE @search OR status LIKE @search)"
                , conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@search", "%" + search + "%");
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;

            using (var rs = query.ExecuteReader())
            {
                List<Debtor> list = new List<Debtor>();

                while (rs.Read())
                {
                    Debtor debtor = new Debtor()
                    {
                        id = (int)rs["id"],
                        firstname = (string)rs["firstname"],
                        lastname = (string)rs["lastname"],
                        establishment = (string)rs["establishment"],
                        cpf = (string)rs["cpf"],
                        cnpj = (string)rs["cnpj"],
                        price = (int)rs["price"],
                        date_operation = (string)rs["date_operation"],
                        status = (string)rs["status"],
                        mes_reference = (int)rs["month_reference"],
                        ano_reference = (int)rs["year_reference"],
                        parc = (int)rs["parc"],
                        description = (string)rs["description"],
                        file = (string)rs["file"]
                    };

                    list.Add(debtor);
                }
                conn.Close();
                return list;
            }
        }

        public Debtor GetDebtorId(int id , int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
               "SELECT * FROM public.\"Debtors_db\" WHERE userId=@userId AND id=@id",
               conn.connection
           );

           conn.Open();

            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            using (var rs = query.ExecuteReader())
            {
                if (rs.Read())
                {
                    Debtor debtor = new Debtor()
                    {
                        id = (int)rs["id"],
                        firstname = (string)rs["firstname"],
                        lastname = (string)rs["lastname"],
                        establishment = (string)rs["establishment"],
                        cpf = (string)rs["cpf"],
                        cnpj = (string)rs["cnpj"],
                        price = (int)rs["price"],
                        date_operation = (string)rs["date_operation"],
                        status = (string)rs["status"],
                        mes_reference = (int)rs["month_reference"],
                        userId = (int)rs["userId"],
                        ano_reference = (int)rs["year_reference"],
                        parc = (int)rs["parc"],
                        description = (string)rs["description"],
                        file = (string)rs["file"]
                    };
                    conn.Close();
                    return debtor;
                }

            }
            conn.Close();
            return null;
        }

        public List<Debtor> getSearchDebtorStatusPagos(string status, int ano, int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
               "SELECT * FROM public.\"Debtors_db\" WHERE userId=@userId AND year_reference=@ano" +
               " AND month_reference=@mes AND status=@status", conn.connection
           );

            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status;


            using (var rs = query.ExecuteReader())
            {
                List<Debtor> list = new List<Debtor>();

                while (rs.Read())
                {
                    Debtor debtor = new Debtor()
                    {
                        id = (int)rs["id"],
                        firstname = (string)rs["firstname"],
                        lastname = (string)rs["lastname"],
                        establishment = (string)rs["establishment"],
                        cpf = (string)rs["cpf"],
                        cnpj = (string)rs["cnpj"],
                        price = (int)rs["price"],
                        date_operation = (string)rs["date_operation"],
                        status = (string)rs["status"],
                        mes_reference = (int)rs["month_reference"],
                        ano_reference = (int)rs["year_reference"],
                        parc = (int)rs["parc"],
                        description = (string)rs["description"],
                        file = (string)rs["file"]

                    };

                    list.Add(debtor);
                }
                conn.Close();
                return list;
            }
        }

        public DataTable getRelatorioDebtor(int userId, int ano, int mes)
        {

            NpgsqlCommand query = new NpgsqlCommand(
             "Select * from public.\"Debtors_db\" " +
             "Where userId=@userId And year_reference=@ano And month_reference=@mes"
             , conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;


            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query);

            DataTable dt = new DataTable();
            da.Fill(dt);
            

            conn.Close();
            return dt;

        }
    }
}
