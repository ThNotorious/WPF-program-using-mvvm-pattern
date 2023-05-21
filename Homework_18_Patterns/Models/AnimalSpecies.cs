using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_18_Patterns.Models
{
    internal class AnimalSpecies
    {
        /// <summary>
        /// ID вида
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование вида
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список животных
        /// </summary>
        public List<Animal> Animals { get; set; }

        /// <summary>
        /// Class вида
        /// </summary>
        public AnimalClass Class { get; set; }

        /// <summary>
        /// Id Класса
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Возврат имени класса, к которому привязан вид
        /// </summary>
        [NotMapped] 
        public AnimalClass SpeciesClass 
        {
            get
            {
               return DataAnimal.GetClassById(ClassId);
            }
        }

        /// <summary>
        /// Возврат количества всех животных принадлежащих кокретному виду
        /// </summary>
        [NotMapped] 
        public List<Animal> SpeciesAnimals
        {
            get
            {
                return DataAnimal.GetAllAnimalsBySpeciesId(Id);
            }
        }
    }
}
