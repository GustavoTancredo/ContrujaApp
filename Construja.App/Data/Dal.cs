
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Construja.App.Data
{
    class Dal
    {
        private static SqlCeConnection objSqlCeConnection = null;
        private static Dal objSqlServerCeDAL = null;
        private static string connString = null;

        public Dal()
        {
            var mainPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var fullPath = mainPath + "\\Data\\Database.sdf";
            connString = string.Format("Data Source=\"{0}\"", fullPath);
            objSqlCeConnection = new SqlCeConnection(connString);
        }

        public static Dal GetInstance(string connString)
        {
            if (objSqlServerCeDAL == null)
            {
                objSqlServerCeDAL = new Dal();
            }

            return objSqlServerCeDAL;
        }

        public void Open()
        {
            try
            {
                if (objSqlCeConnection.State == ConnectionState.Closed)
                {
                    objSqlCeConnection.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            try
            {
                if (objSqlCeConnection.State != ConnectionState.Closed)
                {
                    objSqlCeConnection.Close();
                    objSqlCeConnection.Dispose();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Insert(Domain.Placa placa, string sql)
        {
            Dal objSqlCeServerDAL = Dal.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCeCommand dCmd = new SqlCeCommand(sql, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@DataHora", placa.DataHora);
                dCmd.Parameters.AddWithValue("@placa", placa.placa);
                dCmd.Parameters.AddWithValue("@qtdCaixaSaida", placa.qtdCaixaSaida);
                return dCmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }

        public int Update(Domain.Placa placa, string sql)
        {
            Dal objSqlCeServerDAL = Dal.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCeCommand dCmd = new SqlCeCommand(sql, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@QtdCaixaRetorno", placa.qtdCaixaRetorno);
                dCmd.Parameters.AddWithValue("@Observacao", placa.Observacao);
                dCmd.Parameters.AddWithValue("@Id", placa.Id);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }

        public Domain.Placa LoadOne(string placa, string sql)
        {
            Dal objSqlCeServerDAL = Dal.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCeDataAdapter dAd = new SqlCeDataAdapter(sql, objSqlCeConnection);
            dAd.SelectCommand.Parameters.AddWithValue("@placa", placa);
            dAd.SelectCommand.CommandType = CommandType.Text;
            DataSet dSet = new DataSet();
            try
            {
                
                dAd.Fill(dSet, "Placa");

               var placas = dSet.Tables["Placa"].AsEnumerable().Select(x => new Domain.Placa
                {
                    Id = x.Field<int>("Id"),
                    DataHora = x.Field<DateTime>("DataHora"),
                    qtdCaixaSaida = x.Field<int>("qtdCaixaSaida"),
                    Observacao = x.Field<string>("Observacao"),
                    placa = x.Field<string>("placa"),
                    qtdCaixaRetorno = x.Field<Nullable<int>>("qtdCaixaRetorno"),
                }).ToList();

               return placas.First();
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }


        public List<Domain.Placa> LoadMany(string sql)
        {
            Dal objSqlCeServerDAL = Dal.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCeDataAdapter dAd = new SqlCeDataAdapter(sql, objSqlCeConnection);
            dAd.SelectCommand.CommandType = CommandType.Text;
            DataSet dSet = new DataSet();
            try
            {

                dAd.Fill(dSet, "Placa");

                var placas = dSet.Tables["Placa"].AsEnumerable().Select(x => new Domain.Placa
                {
                    Id = x.Field<int>("Id"),
                    DataHora = x.Field<DateTime>("DataHora"),
                    qtdCaixaSaida = x.Field<int>("qtdCaixaSaida"),
                    Observacao = x.Field<string>("Observacao"),
                    placa = x.Field<string>("placa"),
                    qtdCaixaRetorno = x.Field<Nullable<int>>("qtdCaixaRetorno"),
                }).ToList();

                return placas;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }

    }
}