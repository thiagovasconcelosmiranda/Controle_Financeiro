using Controle_de_financia2.infrastructure;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Controle_de_financia2
{
    public class FluxoContaDb
    {
        DbConection conn = new DbConection();

        public int adicionar(FluxoConta fluxoConta)
        {
            try
            {
                NpgsqlCommand query = new NpgsqlCommand(
               "insert into public.\"Acount_flow_db\"" + "(estabelecimento, tipo_conta, date_venc, valor, status, year_reference," +
               " month_reference, userId, parc, description, created_at, updated_at, file)" +
               " values(@estabelecimento, @tipo_conta, @date_venc," +
               " @valor, @status, @year_reference, @month_reference, @userId, @parc, @description, @created_at," +
               " @updated_at, @file) RETURNING id", conn.connection);

                conn.Open();

                query.Parameters.AddWithValue("@estabelecimento", SqlDbType.VarChar).Value = fluxoConta.estabelecimento;
                query.Parameters.AddWithValue("@tipo_conta", SqlDbType.VarChar).Value = fluxoConta.tipo_conta;
                query.Parameters.AddWithValue("@date_venc", SqlDbType.VarChar).Value = fluxoConta.data_venc;
                query.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = fluxoConta.valor;
                query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = fluxoConta.userId;
                query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = "não pago";
                query.Parameters.AddWithValue("@file", SqlDbType.VarChar).Value = fluxoConta.file;
                query.Parameters.AddWithValue("@year_reference", SqlDbType.Int).Value = fluxoConta.ano_reference;
                query.Parameters.AddWithValue("@month_reference", SqlDbType.Int).Value = fluxoConta.mes_reference;
                query.Parameters.AddWithValue("@parc", SqlDbType.Int).Value = fluxoConta.parc;
                query.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = fluxoConta.description;
                query.Parameters.AddWithValue("@created_at", SqlDbType.DateTime).Value = fluxoConta.created_at;
                query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = fluxoConta.updated_at;

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

        public decimal GetSomaFluxoContasMes(int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
            "Select SUM(valor) From public.\"Acount_flow_db\" Where" +
            " month_reference=@mes AND userId=@userId",
            conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            object result = query.ExecuteScalar();

            decimal valor = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

            conn.Close();
            return valor;
        }

        public decimal GetSomaFluxoContasAno(int ano, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
            "Select SUM(valor) From public.\"Acount_flow_db\" Where " +
            "year_reference=@ano and userId=@userId", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            object result = query.ExecuteScalar();

            decimal total = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

            conn.Close();
            return total;
        }

     
        public int update(FluxoConta fluxoConta)
        {

         try { 
            NpgsqlCommand query = new NpgsqlCommand(
             "UPDATE public.\"Acount_flow_db\" SET estabelecimento=@estabelecimento, tipo_conta=@tipo_conta," +
             " date_venc=@date_venc, status=@status," +
             " year_reference=@ano, month_reference=@mes,"+ 
             " parc=@parc," +
             " description=@description," +
             " updated_at=@updated_at, valor=@valor, file=@file where id=@id RETURNING id", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = fluxoConta.id;
            query.Parameters.AddWithValue("@estabelecimento", SqlDbType.VarChar).Value = fluxoConta.estabelecimento;
            query.Parameters.AddWithValue("@tipo_conta", SqlDbType.VarChar).Value = fluxoConta.tipo_conta;
            query.Parameters.AddWithValue("@date_venc", SqlDbType.VarChar).Value = fluxoConta.data_venc;
            query.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = fluxoConta.valor;
            query.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = fluxoConta.status;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = fluxoConta.ano_reference;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = fluxoConta.mes_reference;
            query.Parameters.AddWithValue("@parc", SqlDbType.Int).Value = fluxoConta.parc;
            query.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = fluxoConta.description;
            query.Parameters.AddWithValue("@updated_at", SqlDbType.DateTime).Value = DateTime.Now;
            query.Parameters.AddWithValue("@file", SqlDbType.VarChar).Value = fluxoConta.file;

            object result = query.ExecuteScalar();

            if (result != null)
            {
                conn.Close();
                return 1;
            }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show($" Erro {e.Message}");
            }
            conn.Close();
            return 0;
        }


        public int excluir(int id)
        {
          try
          {
            NpgsqlCommand query = new NpgsqlCommand(
            "Delete From public.\"Acount_flow_db\" Where id=@id RETURNING id", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;

            int result = (int)query.ExecuteScalar();

            if (result > 0)
            {
                conn.Close();
                return 1;
            }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show($" Erro {e.Message}");
            }
            conn.Close();
            return 0;
        }

        public List<FluxoConta> getSearchFluxoContaStatusPagos(string status, int ano, int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
              "Select * from public.\"Acount_flow_db\" where " +
              "userId=@userId AND year_reference=@ano "+
              "AND month_reference=@mes AND status=@status;", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@status", status);
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;

            using (var rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {

                    List<FluxoConta> list = new List<FluxoConta>();

                    while (rs.Read())
                    {
                        FluxoConta fluxoConta = new FluxoConta()
                        {
                            id = (int)rs["id"],
                            estabelecimento = (string)rs["estabelecimento"],
                            tipo_conta = (string)rs["tipo_conta"],
                            data_venc = (string)rs["date_venc"],
                            valor = (int)rs["valor"],
                            userId = (int)rs["userId"],
                            created_at = (DateTime)rs["created_at"],
                            updated_at = (DateTime)rs["updated_at"],
                            status = (string)rs["status"],
                            mes_reference = (int)rs["month_reference"],
                            ano_reference = (int)rs["year_reference"],
                            parc = (int)rs["parc"],
                            description = (string)rs["description"],
                            file = (string)rs["file"]
                        };

                        list.Add(fluxoConta);

                    }
                    conn.Close();
                    return list;
                }
                conn.Close();
                return null;
            }
        }

        public List<FluxoConta> getSearchFluxoConta(string search, int ano, int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
              "Select * from public.\"Acount_flow_db\" " +
              "where userId=@userId and year_reference=@ano " +
              "and month_reference=@mes AND estabelecimento LIKE @search", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@search", "%" + search + "%");
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            using (var rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {

                    List<FluxoConta> list = new List<FluxoConta>();

                    while (rs.Read())
                    {
                        FluxoConta fluxoConta = new FluxoConta()
                        {
                            id = (int)rs["id"],
                            estabelecimento = (string)rs["estabelecimento"],
                            tipo_conta = (string)rs["tipo_conta"],
                            data_venc = (string)rs["date_venc"],
                            valor = (int)rs["valor"],
                            userId = (int)rs["userId"],
                            created_at = (DateTime)rs["created_at"],
                            updated_at = (DateTime)rs["updated_at"],
                            status = (string)rs["status"],
                            mes_reference = (int)rs["month_reference"],
                            ano_reference = (int)rs["year_reference"],
                            parc = (int)rs["parc"],
                            description = (string)rs["description"],
                            file = (string)rs["file"]
                        };

                        list.Add(fluxoConta);

                    }
                    conn.Close();
                    return list;
                }
                conn.Close();
                return null;
            }
        }

        public List<FluxoConta> getFluxoContaAll(int ano, int mes, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
              "Select * from public.\"Acount_flow_db\" " +
              "where userId=@userId and year_reference=@ano " +
              "and month_reference=@mes", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@ano", SqlDbType.Int).Value = ano;
            query.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            using (var rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {

                    List<FluxoConta> list = new List<FluxoConta>();

                    while (rs.Read())
                    {
                        FluxoConta fluxoConta = new FluxoConta()
                        {
                            id = (int)rs["id"],
                            estabelecimento = (string)rs["estabelecimento"],
                            tipo_conta = (string)rs["tipo_conta"],
                            data_venc = (string)rs["date_venc"],
                            valor = (int)rs["valor"],
                            userId = (int)rs["userId"],
                            created_at = (DateTime)rs["created_at"],
                            updated_at = (DateTime)rs["updated_at"],
                            status = (string)rs["status"],
                            mes_reference = (int)rs["month_reference"],
                            ano_reference = (int)rs["year_reference"],
                            parc = (int)rs["parc"],
                            description = (string)rs["description"],
                            file = (string)rs["file"]
                        };

                        list.Add(fluxoConta);

                    }
                    conn.Close();
                    return list;
                }
                conn.Close();
                return null;
            }
        }

        public FluxoConta GetFluxoContaId(int id, int userId)
        {
            NpgsqlCommand query = new NpgsqlCommand(
              "Select * from public.\"Acount_flow_db\" where id=@id AND userId=@userId;", conn.connection);

            conn.Open();

            query.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            using (var rs = query.ExecuteReader())
            {
                if (rs.Read())
                {
                    FluxoConta fluxoConta = new FluxoConta()
                    {
                        id = (int)rs["id"],
                        estabelecimento = (string)rs["estabelecimento"],
                        tipo_conta = (string)rs["tipo_conta"],
                        data_venc = (string)rs["date_venc"],
                        valor = (int)rs["valor"],
                        status = (string)rs["status"],
                        ano_reference = (int)rs["year_reference"],
                        mes_reference = (int)rs["month_reference"],
                        created_at = (DateTime)rs["created_at"],
                        updated_at = (DateTime)rs["updated_at"],
                        parc = (int)rs["parc"],
                        description = (string)rs["description"],
                        file = (string)rs["file"]
                    };
                    conn.Close();
                    return fluxoConta; 
                }
            }
            conn.Close();
            return null;
         }

        public DataTable getRelatorioFluxoContaAnual(int userId, int ano)
        {

            NpgsqlCommand query = new NpgsqlCommand(
             "Select * from public.\"Acount_flow_db\" Where userId=@userId AND" +
             " (ano_reference LIKE @ano_reference);");
            
            conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;
            query.Parameters.AddWithValue("@ano_reference", SqlDbType.Int).Value = ano;

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query);

            DataTable dt = new DataTable();
            
            da.Fill(dt);

            conn.Close();
            return dt;

        }

        public DataTable getRelatorioFluxoContaMensal(int userId, int ano, int mes)
        {

            NpgsqlCommand query = new NpgsqlCommand(
             "Select * from public.\"Acount_flow_db\" " +
             "Where userId=@userId and year_reference=@ano "+
             "and month_reference=@mes"
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

        public List<FluxoConta> listFluxoConta(int userId)
        {

            NpgsqlCommand query = new NpgsqlCommand(
            "Select * from public.\"Acount_flow_db\" where userId=@userId", conn.connection);

           conn.Open();

            query.Parameters.AddWithValue("@userId", SqlDbType.Int).Value = userId;

            using (var rs = query.ExecuteReader()) 
            {
                if (rs.HasRows)
                {

                    List<FluxoConta> list = new List<FluxoConta>();

                    while (rs.Read())
                    {
                        FluxoConta fluxoConta = new FluxoConta()
                        {
                            id = (int)rs["id"],
                            estabelecimento = (string)rs["estabelecimento"],
                            tipo_conta = (string)rs["tipo_conta"],
                            data_venc = (string)rs["date_venc"],
                            valor = (int)rs["valor"],
                            userId = (int)rs["userId"],
                            created_at = (DateTime)rs["created_at"],
                            updated_at = (DateTime)rs["updated_at"],
                            status = (string)rs["status"],
                            ano_reference = (int)rs["year_reference"],
                            mes_reference = (int)rs["month_reference"],
                            parc = (int)rs["parc"],
                            description = (string)rs["description"],
                            file = (string)rs["file"]
                        };

                        list.Add(fluxoConta);

                    }
                    conn.Close();
                    return list;
                }
                conn.Close();
                return null;
            }
        }
    }
}
