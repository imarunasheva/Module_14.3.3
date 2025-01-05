using System;

namespace Module_14._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>
            {
                // добавляем контакты
                new("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new("Сергей", "Брин", 799900000013, "serg@example.com"),
                new("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            while (true)
            {
                Console.Write("Введите номер страницы от 1 до 3: ");

                // Читаем введенный с консоли символ
                var input = Console.ReadKey().KeyChar;

                // проверяем, число ли это
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

                // если не соответствует критериям, показываем ошибку
                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                    Console.WriteLine();
                }
                // если соответствует, запускаем вывод
                else
                {
                    // сортируем контакты по имени, затем по фамилии
                    var sortContent = phoneBook.OrderBy(s => s.Name)
                        .ThenBy(s => s.LastName);

                    // пропускаем нужное количество элементов и берем 2 для показа на странице
                    var pageContent = sortContent.Skip((pageNumber - 1) * 2).Take(2);

                    Console.WriteLine();

                    // выводим результат
                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

                    Console.WriteLine();
                }
            }
        }
    }
}