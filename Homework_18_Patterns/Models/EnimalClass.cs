using System.Collections.Generic;

namespace Homework_18_Patterns.Models
{
    internal class EnimalClass
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
        public List<EnimalSpecies> Species { get; set; }
    }
}
