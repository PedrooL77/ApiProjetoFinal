namespace Api.Models
{
    public class ObservacoesModel
    {
        public int ObservacaoId { get; set; }
        public string ObservacaoDescricao { get; set; } = string.Empty;
        public string ObservacaoLocal { get; set; } = string.Empty;
        public DateTime ObservacaoData { get; set; }
        public int ObjetoId { get; set; }
        public int UsuarioId { get; set; }
    }
}
