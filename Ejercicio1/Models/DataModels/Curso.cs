using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string PublicObjective { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;

        [Required, EnumDataType(typeof(LevelEnum))]
        public int Level { get; set; }

        public enum LevelEnum
        {
            Basico = 1,
            Intermedio= 2,
            Avanzado = 3
        }

    }
}
