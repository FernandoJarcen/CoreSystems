
namespace CoreKonnector.Services
{
    public static class ModuloApp
    {
        public static string ValidarAppBusiness(string nome, string pwd)
        {
            string retorno = string.Empty;
            if (nome == "Adm")
                if (pwd == "Master@db12")
                    retorno = "Sucesso!";
                else
                    retorno = "Falha!";
            else
                retorno = "Falha!";
            return retorno;
        }
    }
}
