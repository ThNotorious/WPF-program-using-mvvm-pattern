using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_18_Patterns.Models
{
    internal class Animal
    {
        /// <summary>
        /// ID животного
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Кличка животного
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Окрас животного
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возраст животного
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Гендер животного
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Вид животного
        /// </summary>
        public AnimalSpecies Species { get; set; }

        /// <summary>
        /// Id вида животного
        /// </summary>
        public int SpeciesId { get; set; }

        /// <summary>
        /// Возврат имени вида, к которому привязано животное
        /// </summary>
        [NotMapped]
        public AnimalSpecies AnimalSpecies
        {
            get
            {
                return DataAnimal.GetSpeciesById(SpeciesId);
            }
        }
    }
}
