namespace ProjectTennis.Models 
{
    public class tennis
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Nome do tênis
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tamanho do tênis 
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Cor do tênis 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Marca do tênis 
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Indicação do tênis 
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Epessura do solado 
        /// </summary>
        public string Drop { get; set; }
        /// <summary>
        /// Peso do Tênis
        /// </summary>
        public string TennisWeight { get; set; }  // procurar o nome correto para "peso do tenis"
        /// <summary>
        /// Tipo da entressola 
        /// </summary>
        public string MidSole { get; set; }
        /// <summary>
        /// Finalidade do tênis/ Treino de explosão-Corrida-Caminhada
        /// </summary>
        public string Categorie { get; set; }
        /// <summary>
        /// Masculino ou Feminino 
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Material do tênis
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// Nível de Amortecimento
        /// </summary>
        public string DampingLevel { get; set; }
        /// <summary>
        /// Recomendações gerais
        /// </summary>
        public string Recomendation { get; set; }
        /// <summary>
        /// Link para resenha no YouTube
        /// </summary>
        public string YoutubeLink { get; set; }
        /// <summary>
        ///  Link da Loja 
        /// </summary>
        public string StoreLink { get; set; }
        /// <summary>
        /// Produto exclusivo
        /// </summary>
        public string Exclusive { get; set; }
        /// <summary>
        /// Proteção de dados
        /// </summary>
        public string? Secret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsComplete { get; internal set; }
    }
}
