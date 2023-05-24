using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_18_Patterns.Models
{
    internal class AnimalClass
    {
        /// <summary>
        /// ID класса
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование класса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список видов
        /// </summary>
        public List<AnimalSpecies> Species { get; set; }
    }
}
