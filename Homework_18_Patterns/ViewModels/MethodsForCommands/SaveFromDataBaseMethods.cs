using Homework_18_Patterns.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework_18_Patterns.ViewModels.MethodsForCommands
{
    internal class SaveFromDataBaseMethods
    {
        /// <summary>
       /// Сохранение в формате World
       /// </summary>
        internal static void SaveDataToDOC()
        {
            SaveData("DataAnimal.DOC");
        }

        /// <summary>
        /// Сохранение в формате TXT
        /// </summary>
        internal static void SaveDataToTXT()
        {
            SaveData("DataAnimal.txt");
        }

        /// <summary>
        /// Сохранение в формате Excel
        /// </summary>
        internal static void SaveDataToExcel()
        {
            SaveData("DataAnimal.csv");
        }


        /// <summary>
        /// Сохранение данных 
        /// </summary>
        /// <param name="nameFile"></param>
        private static void SaveData(string nameFile)
        {
            using var context = new ApplicationContext();
            var animals = context.Animals.ToList();

            using FileStream fileStream = new(nameFile, FileMode.Create);
            using StreamWriter writer = new(fileStream, Encoding.Unicode);
            
            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

    }
}
