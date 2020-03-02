using CoreSDK.Enums;
using System.Data;
using CoreSDK.Objetos;
using System.Data.Common;

namespace CoreSDK.ODB.Domain
{
    public class Parametros
    {
        public string nome { get; set; }
        public object valor { get; set; }
        public BancoDados.TipoDados tipo { get; set; }
        public ParameterDirection direcao { get; set; }

        public Parametros(string pnome, object pvalor, BancoDados.TipoDados ptipo, ParameterDirection pdirecao)
        {
            nome = pnome;
            valor = pvalor;
            tipo = ptipo;
            direcao = pdirecao;
        }

        public Parametros(string pnome, BancoDados.TipoDados ptipo, ParameterDirection pdirecao)
        {
            nome = pnome;
            tipo = ptipo;
            direcao = pdirecao;
        }

        public Parametros()
        {
            // TODO: Complete member initialization
        }       
    }

    public static class ParametroAtivo
    {
        public static IDataParameter IniciarParametro(DbParameter p_parametro, IDbCommand pcomando, string pnome, object pvalor, BancoDados.TipoDados ptipo = BancoDados.TipoDados.Nenhum, ParameterDirection pdirecao = System.Data.ParameterDirection.Input, int ptamanho = 0, string psourcecolumn = "")
        {
            //DbParameter p_parametro;

            switch (ptipo)
            {
                case BancoDados.TipoDados.Nenhum:
                    break;
                case BancoDados.TipoDados.Data:
                    p_parametro.DbType = DbType.Date;
                    break;
                case BancoDados.TipoDados.DataHora:
                    p_parametro.DbType = DbType.DateTime2;
                    break;
                case BancoDados.TipoDados.Hora:
                    p_parametro.DbType = DbType.Time;
                    break;
                case BancoDados.TipoDados.Inteiro:
                    p_parametro.DbType = DbType.Int32;
                    break;
                case BancoDados.TipoDados.Longo:
                    p_parametro.DbType = DbType.Int64;
                    break;
                case BancoDados.TipoDados.Real:
                    p_parametro.DbType = DbType.Decimal;
                    break;
                case BancoDados.TipoDados.Moeda:
                    p_parametro.DbType = DbType.Currency;
                    break;
                case BancoDados.TipoDados.Booleano:
                    p_parametro.DbType = DbType.Boolean;
                    break;
                case BancoDados.TipoDados.Texto:
                    p_parametro.DbType = DbType.String;
                    p_parametro.Size = ptamanho;
                    break;
                case BancoDados.TipoDados.Caracter:
                    p_parametro.DbType = DbType.String;
                    p_parametro.Size = ptamanho;
                    break;
                case BancoDados.TipoDados.TextoLongo:
                    p_parametro.DbType = DbType.String;
                    break;
                case BancoDados.TipoDados.Imagem:
                    p_parametro.DbType = DbType.Object;
                    break;
            }
            p_parametro.Direction = pdirecao;
            p_parametro.ParameterName = pnome;
            p_parametro.Value = pvalor;
            p_parametro.SourceColumn = psourcecolumn;
            
            return p_parametro;
        }
    }
}
