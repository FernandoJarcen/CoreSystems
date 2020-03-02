using System.Collections;

namespace CoreKonnector.Model
{    
    public class Modularizacao : CollectionBase
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Executavel { get; set; }

        public Modularizacao(int p_id, string p_descricao, string p_executavel)
        {
            this.ID = p_id;
            this.Descricao = p_descricao;
            this.Executavel = p_executavel;
        }
    }
}
