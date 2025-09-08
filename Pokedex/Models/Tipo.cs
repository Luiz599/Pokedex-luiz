using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Erro grave")]
        public string Nome { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Erro grave")]
        public string Cor { get; set; }

        public List<PokemonTipo> Pokemons { get; set; }
    }
}