using solo.Data;

namespace solo.Models
{
    public class Entrate
    {
        public int IdEntrata { get; set; }
        public string Nome { get; set; } = "";
        public int Importo { get; set; }
        public string Nota { get; set; } = "";
        public CategoriaE Categoria { get; set; }
    }
}
