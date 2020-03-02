using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sistematica.application.Objetos;
using CoreSDK.ODB.DataBase;
using CoreSDK.Utils;
using CoreSDK.Entities.Base;
using CoreKonnector.Model;

namespace sistematica.application.Formularios
{
    public partial class frmEntidade : Form
    {
        public List<Tabela> prop = new List<Tabela>();
        string strcnn = "";
        frmCustomizacao frmAtivo;
        public frmEntidade(frmCustomizacao formulario)
        {
            InitializeComponent();
            frmAtivo = formulario;
        }

        #region metodos
        
        private void limparCampos()
        {
            fld_nome.Valor = string.Empty;
            fld_tamanho.Valor = string.Empty;
            fld_padrao.Valor = string.Empty;
            cbo_tipo.Indice = 0;
            cbo_aceitaNulo.Indice = 0;
            fld_comentario.Valor = string.Empty;
            chk_dataAtual.Visible = false;
            fld_nome.Focus();
        }
        
        private string montarScript()
        {
            string retorno = string.Empty;
            if (!existeTabela(lbl_internoEntidade.Text))
            {
                strcnn = "CREATE TABLE " + lbl_internoEntidade.Text + " (";
                if (sgd_campos.Quantidade() > 0)
                {
                    if (prop.Count > 0)
                        prop.Clear();

                    for (int indice = 0; indice < sgd_campos.Quantidade(); indice++)
                    {
                        string campo = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tipo"));
                        if (campo == "IDENTITY")
                        {
                            prop.Add(new Tabela()
                            {
                                Ordem = indice,
                                Nome = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Nome")),
                                Tipo = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tipo")),
                                Comentario = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Comentario"))
                            });
                        }
                        else if (sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Aceita")) == "")
                        {
                            prop.Add(new Tabela()
                            {
                                Ordem = indice,
                                Nome = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Nome")),
                                Tipo = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tipo")),
                                Comentario = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Comentario"))
                            });
                        }
                        else
                        {
                            string tamanho = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tamanho")).Replace(",", ".");
                            prop.Add(new Tabela()
                            {
                                Ordem = indice,
                                Nome = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Nome")),
                                Tipo = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tipo")),
                                Comentario = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Comentario")),
                                AceitaNulo = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Aceita")),
                                Tamanho = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Tamanho")),
                                Padrao = sgd_campos.Valor(indice, sgd_campos.PosicaoColuna("Padrao"))
                            }
                            );
                        }
                    }

                    for (int indice = 0; indice < sgd_campos.Quantidade(); indice++)
                    {
                        string tipoDado = prop[indice].Tipo;
                        
                        if (indice >= 1)
                            strcnn += ", ";

                        if (tipoDado == "IDENTITY")
                        {
                            strcnn += prop[indice].Nome + " int IDENTITY(1,1) NOT NULL";
                        }
                        else if ((tipoDado == "CHAR") | (tipoDado == "NUMERIC") | (tipoDado == "VARCHAR") | (tipoDado == "VARBINARY") | (tipoDado == "DECIMAL"))
                            strcnn += prop[indice].Nome + " " + prop[indice].Tipo + "(" + prop[indice].Tamanho + ")";
                        else
                            strcnn += prop[indice].Nome + " " + prop[indice].Tipo;

                        if (!string.IsNullOrEmpty(prop[indice].Padrao))
                        {
                            if ((tipoDado == "CHAR") | (tipoDado == "NUMERIC") | (tipoDado == "VARCHAR") | (tipoDado == "VARBINARY") | (tipoDado == "DECIMAL"))
                                strcnn += " default '" + prop[indice].Padrao + "'";
                            else
                                strcnn += " default " + prop[indice].Padrao;
                        }

                        if (!String.IsNullOrEmpty(prop[indice].Comentario))
                                strcnn += " /*" + prop[indice].Comentario + "*/";

                    }
                }
                strcnn += ")";
                retorno = strcnn;
            }
            else
            {
                MessageBox.Show("Tabela já existe na Base!");
                strcnn = string.Empty;
            }
            return strcnn;
        }

        private bool existeTabela(string nomeTabela)
        {
            bool retorno = false;
            int qtd = Acao<EntidadeSistema>.Contar("Nome = '" + nomeTabela + "'");
            if (qtd > 0)
                retorno = true;
            return retorno;
        }

        #endregion

        #region evento
        
        private void cap_aplicar_AoChamar(object sender, EventArgs e)
        {
            int executavel = 0;

            try
            {
                strcnn = string.Empty;
                strcnn = montarScript();
                if (!string.IsNullOrEmpty(strcnn))
                {
                    executavel = DB.ExecutaNonQuery(strcnn);
                    if (executavel == -1)
                    {
                        using (EntidadeSistema ent = new EntidadeSistema())
                        {
                            string baseConectada = frmAtivo.baseConectada;
                            ent.Catalogo = baseConectada.ToLower() + "_db";
                            ent.Proprietario = "dbo";
                            ent.Nome = lbl_internoEntidade.Text;
                            ent.Apelido = fld_displayEntidade.Valor;
                            ent.Display = fld_displayEntidade.Valor;
                            ent.Descricao = mmo_descricao.Valor;
                            ent.Tipo = "Tabela";
                            ent.TipoBanco = "BASE TABLE";
                            string escopo = string.Empty;
                            if (cbo_escopo.Valor == "Publica") escopo = "P"; else escopo = "R";
                            ent.Escopo = escopo;
                            ent.DataCriacao = Util.Genericos.ConvDataHoje();
                            string entidade = Acao<EntidadeSistema>.Inserir(ent);
                            if (entidade == "Registro Incluido com sucesso!")
                            {
                                frmAtivo.MostrarEntidades(baseConectada);
                                MessageBox.Show("Entidade " + lbl_internoEntidade.Text + " Executada com sucesso!");

                                this.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Não foi possível executar a construção da tabela!");
                }
                else
                    MessageBox.Show("Não é possível inserir a tabela!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cpt_sair_AoChamar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string[] coluna = new string[] { "Nome", "Ordem", "Tipo", "Tamanho", "Padrao", "Aceita","Comentario" };
            int linha = 0;
            linha = sgd_campos.Quantidade();
            if (!String.IsNullOrEmpty(fld_nome.Valor))
            {
                string tipoDado = cbo_tipo.Valor;

                if (tipoDado == "SMALLDATETIME")
                {
                    if (chk_dataAtual.Checked)
                        sgd_campos.AdicionarLinha(new object[] { fld_nome.Valor.Replace(" ", ""), linha + 1, cbo_tipo.Valor, fld_tamanho.Valor, "getdate()", cbo_aceitaNulo.Valor, fld_comentario.Valor }, coluna);
                    else
                        sgd_campos.AdicionarLinha(new object[] { fld_nome.Valor.Replace(" ", ""), linha + 1, cbo_tipo.Valor, fld_tamanho.Valor, fld_padrao.Valor, cbo_aceitaNulo.Valor, fld_comentario.Valor }, coluna);
                    limparCampos();
                }
                else if ((tipoDado == "CHAR") | (tipoDado == "NUMERIC") | (tipoDado == "VARCHAR") | (tipoDado == "VARBINARY") | (tipoDado == "DECIMAL"))
                {
                    if (!String.IsNullOrEmpty(fld_tamanho.Valor))
                    {
                        sgd_campos.AdicionarLinha(new object[] { fld_nome.Valor.Replace(" ", ""), linha + 1, cbo_tipo.Valor, fld_tamanho.Valor, fld_padrao.Valor, cbo_aceitaNulo.Valor, fld_comentario.Valor }, coluna);
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("O valor de Tamanho é Obrigatório!");
                        fld_tamanho.Focus();
                    }
                }
                else
                {
                    sgd_campos.AdicionarLinha(new object[] { fld_nome.Valor.Replace(" ", ""), linha + 1, cbo_tipo.Valor, fld_tamanho.Valor,"","Sim", fld_comentario.Valor }, coluna);
                    limparCampos();
                }
            }
            else
                MessageBox.Show("Existem campos que devem ser preenchidos!");
        }

        private void cbo_tipo_AoMudarIndice(object sender, EventArgs e)
        {
            string opcao = ((CoreFramework.Controles.Controle.ComboBoxExtends)(sender)).Valor;
            if (opcao == "IDENTITY")
            {
                fld_tamanho.Habilitar(false);
                fld_padrao.Habilitar(false);
                cbo_aceitaNulo.Valor = "Não";
            }
            else if (opcao == "SMALLDATETIME")
            {
                chk_dataAtual.Visible = true;
                fld_tamanho.Habilitar(false);
                fld_padrao.Habilitar(false);
            }
            else
            {
                chk_dataAtual.Visible = false;
                fld_tamanho.Habilitar(true);
                fld_padrao.Habilitar(true);                
                cbo_aceitaNulo.Valor = "Sim";
            }
            fld_padrao.Valor = string.Empty;
        }

        private void fld_nomeEntidade_AoPerderFoco(object sender, EventArgs e)
        {
            pnl_campos.Cabecalho = string.Empty;
            pnl_campos.Cabecalho = "Campos da Entidade " + fld_nomeEntidade.Valor;
            lbl_internoEntidade.Text = fld_nomeEntidade.Valor.Replace(" ", "");
        }        

        private void sgd_campos_AoClique(object sender, EventArgs e)
        {
            fld_nome.Valor = sgd_campos.Valor(sgd_campos.LinhaSelecionada(), 0);
            cbo_tipo.Valor = sgd_campos.Valor(this.sgd_campos.LinhaSelecionada(), this.sgd_campos.PosicaoColuna("Tipo"));
            fld_tamanho.Valor = sgd_campos.Valor(sgd_campos.LinhaSelecionada(), 3);
            fld_padrao.Valor = sgd_campos.Valor(sgd_campos.LinhaSelecionada(), 4);
            fld_comentario.Valor = sgd_campos.Valor(this.sgd_campos.LinhaSelecionada(), this.sgd_campos.PosicaoColuna("Comentario"));
            cbo_aceitaNulo.Valor = sgd_campos.Valor(this.sgd_campos.LinhaSelecionada(), this.sgd_campos.PosicaoColuna("Aceita"));
            if (fld_padrao.Valor == "getdate()")
                chk_dataAtual.Checked = true;
            else
                chk_dataAtual.Checked = false;
            btn_adicionar.Enabled = false;
        }        

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            int linha = this.sgd_campos.LinhaSelecionada();

            if (chk_dataAtual.Checked == true)
                this.fld_padrao.Valor = "getdate()";
            else
                this.fld_padrao.Valor = string.Empty;
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Nome"), fld_nome.Valor);
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Tipo"), cbo_tipo.Valor);
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Tamanho"), fld_tamanho.Valor);
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Padrao"), fld_padrao.Valor);
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Aceita"), cbo_aceitaNulo.Valor);
            this.sgd_campos.EditarValor(linha, sgd_campos.PosicaoColuna("Comentario"), fld_comentario.Valor);
            
            limparCampos();
            btn_adicionar.Enabled = true;
        }

        #endregion
    }
}
