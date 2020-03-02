using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreEntities.Domain.Model.Sistema;
using CoreEntities.Base;

namespace CoreBusiness.Entities.Global
{
    public static class UnidadeNegocio
    {
        public static string SalvarUnidadeNegocios(CoreEntities.Domain.Model.Sistema.UnidadeNegocio unidade)
        {
            string retorno = string.Empty;

            if (ValidarUnidade(unidade))
                retorno = salvarUnidade(unidade);
            return retorno;
        }

        public static bool ValidarUnidade(CoreEntities.Domain.Model.Sistema.UnidadeNegocio unidade)
        {
            bool retorno = false;
            if (unidade.ConsolidadoraID > 0)
                if (unidade.NegocioID > 0)
                    if (unidade.UnidadeRelacionadaID > 0)
                        if (unidade.PadraoID > 0)
                            if (unidade.MunicipioID > 0)
                                retorno = true;
            return retorno;
        }

        private static string salvarUnidade(CoreEntities.Domain.Model.Sistema.UnidadeNegocio unidade)
        {
            string retorno = string.Empty;
            retorno = Acao<CoreEntities.Domain.Model.Sistema.UnidadeNegocio>.Inserir(unidade);
            return retorno;
        }
    }
}
