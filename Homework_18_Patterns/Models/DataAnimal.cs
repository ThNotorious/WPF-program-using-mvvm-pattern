using Homework_18_Patterns.Data;
using System.Collections.Generic;
using System.Linq;

namespace Homework_18_Patterns.Models
{
    internal static class DataAnimal
    {
        #region Получение данных

        /// <summary>
        /// Получить все классы
        /// </summary>
        /// <returns></returns>
        internal static List<AnimalClass> GetAllClasses()
        {
            using (ApplicationContext db = new())
            {
                var result = db.AnimalClasses.ToList();
                return result;
            }
        }

        /// <summary>
        /// Получить все виды
        /// </summary>
        /// <returns></returns>
        internal static List<AnimalSpecies> GetAllSpecies()
        {
            using (ApplicationContext db = new())
            {
                var result = db.AnimalSpecieses.ToList();
                return result;
            }
        }

        /// <summary>
        /// Получить всех животных
        /// </summary>
        /// <returns></returns>
        internal static List<Animal> GetAllAnimals()
        {
            using (ApplicationContext db = new())
            {
                var result = db.Animals.ToList();
                return result;
            }
        }

        /// <summary>
        /// Получить вид животного
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static AnimalSpecies GetSpeciesById(int id)
        {
            using (ApplicationContext db = new())
            {
                AnimalSpecies animalSpecies = db.AnimalSpecieses.FirstOrDefault(p => p.Id == id);
                return animalSpecies;
            }
        }

        /// <summary>
        /// Получить класс животного
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static AnimalClass GetClassById(int id)
        {
            using (ApplicationContext db = new())
            {
                AnimalClass animalClass = db.AnimalClasses.FirstOrDefault(p => p.Id == id);
                return animalClass;
            }
        }

        /// <summary>
        /// Получение всех животных в конкретном виде по Id вида
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static List<Animal> GetAllAnimalsBySpeciesId(int id)
        {
            using (ApplicationContext db = new())
            {
                List<Animal> animals = (from animal in GetAllAnimals() where animal.Id == id select animal).ToList();
                return animals;
            }
        }

        /// <summary>
        /// Получение всех видов в конкретном классе по Id класса
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static List<AnimalSpecies> GetAllSpeciesesByClassId(int id)
        {
            using (ApplicationContext db = new())
            {
                List<AnimalSpecies> specieses = (from species in GetAllSpecies() where species.Id == id select species).ToList();
                return specieses;
            }
        }

        #endregion

        #region Создание данных

        /// <summary>
        /// Создать класс
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static string CreateClass(string name)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли класс
                bool checkIsExist = db.AnimalClasses.Any(c => c.Name == name);
                if (!checkIsExist)
                {
                    AnimalClass animalClass = new AnimalClass() { Name = name };
                    db.AnimalClasses.Add(animalClass);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }

        /// <summary>
        /// Создать вид
        /// </summary>
        /// <param name="name"></param>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        internal static string CreateSpecies(string name, AnimalClass animalClass)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли вид
                bool checkIsExist = db.AnimalSpecieses.Any(c => c.Name == name);
                if (!checkIsExist)
                {
                    AnimalSpecies animalSpecies = new AnimalSpecies() { Name = name, ClassId = animalClass.Id };
                    db.AnimalSpecieses.Add(animalSpecies);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }

        /// <summary>
        /// Создать животное
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="animalSpecies"></param>
        /// <returns></returns>
        internal static string CreateAnimal(string name, string color, int age, string gender, AnimalSpecies animalSpecies)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли вид
                bool checkIsExist = db.Animals.Any(c => c.Name == name && c.Color == color &&
                                                   c.Age == age && c.Species == animalSpecies);

                if (!checkIsExist)
                {
                    Animal animal = new Animal()
                    {
                        Name = name,
                        Color = color,
                        Age = age,
                        Gender = gender,
                        SpeciesId = animalSpecies.Id

                    };
                    db.Animals.Add(animal);
                    db.SaveChanges();
                    result = "Выполнено!";
                }
                return result;
            }
        }

        #endregion

        #region Удаление данных

        /// <summary>
        /// Удалить класс
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        internal static string DeleteClass(AnimalClass animalClass)
        {
            string result = "Такого класса не существует в базе";
            using (ApplicationContext db = new())
            {
                db.AnimalClasses.Remove(animalClass);
                db.SaveChanges();
                result = $"Выполнено! Класс {animalClass.Name} удален из базы!";
            }
            return result;
        }

        /// <summary>
        /// Удалить вид
        /// </summary>
        /// <param name="animalClass"></param>
        /// <returns></returns>
        internal static string DeleteSpecies(AnimalSpecies animalSpecies)
        {
            string result = "Такого вида не существует в базе";
            using (ApplicationContext db = new())
            {
                db.AnimalSpecieses.Remove(animalSpecies);
                db.SaveChanges();
                result = $"Выполнено! Вид {animalSpecies.Name} удален из базы!";
            }
            return result;
        }

        /// <summary>
        /// Удалить животное
        /// </summary>
        /// <param name="animalSpecies"></param>
        /// <returns></returns>
        internal static string DeleteAnimal(Animal animal)
        {
            string result = "Такого животного не существует в базе";
            using (ApplicationContext db = new())
            {
                db.Animals.Remove(animal);
                db.SaveChanges();
                result = $"Выполнено! Животное {animal.Name} удалено из базы!";
            }
            return result;
        }

        #endregion

        #region Редактирование данных

        /// <summary>
        /// Редактировать животное
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        internal static string ChangedAnimal(Animal oldAnimal, string newName, string newColor, int newAge)
        {
            string result = "Такого животного не существует в базе";
            using (ApplicationContext db = new())
            {
                Animal animal = db.Animals.FirstOrDefault(x => x.Id == oldAnimal.Id);
                animal.Name = newName;
                animal.Age = newAge;
                animal.Color = newColor;

                db.SaveChanges();
                result = $"Изменения проведены";
            }
            return result;
        }

        #endregion
    }
}

    
