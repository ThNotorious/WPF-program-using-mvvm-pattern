using System.Collections.Generic;

namespace Homework_18_Patterns.Models
{
    internal class EnimalSpecies
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
        public EnimalClass Class { get; set; }

        /// <summary>
        /// Id Класса
        /// </summary>
        public int ClassId { get; set; }
    }
}
