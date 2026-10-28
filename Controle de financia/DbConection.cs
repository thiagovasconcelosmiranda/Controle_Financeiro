using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;

namespace Controle_de_financia2.infrastructure
{
    public class DbConection
    {
        public NpgsqlConnection connection { get; set; }
        

        public DbConection()
        {

         string port = "";
         string dataBase = "";
         string username = "";
         string password = "";
         string host = "";


         string caminhoBase = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoBanco = Path.Combine(caminhoBase, "conexao.txt");
            if (File.Exists(caminhoBanco) && new FileInfo(caminhoBanco).Length > 0)
            {
                string[] linhas = File.ReadAllLines(caminhoBanco);

                List<string> listaLida = new List<string>(linhas);

                port = listaLida[0];
                dataBase = listaLida[1];
                username = listaLida[2];
                password = listaLida[3];
                host = listaLida[4];
        
            }
            else
            {
                new FormAddConection().ShowDialog();
            }

            connection = new NpgsqlConnection($"Host={host};Port={port};Username={username};Password={password};Database={dataBase};");
        
        }


        public void Open()
        {
            try
            {
               connection.Open();

            } catch (NpgsqlException e) {
                new FormAlertMessage($"Erro: {e.Message}",false).ShowDialog();
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
