using solo.Data;
using System.ComponentModel.DataAnnotations;

namespace solo.Models
{
    public class Spese
    {
        [Key]
        public int IdSpesa { get; set; }
        public string Nome { get; set; } = "";
        public float Importo { get; set; }
        public string Nota { get; set; } = "";
        public CategoriaS Categoria { get; set; }
        

    }
}
