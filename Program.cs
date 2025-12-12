var library = new Library
{
    // Создаём массив из 5 книг
    books = new Book[5],
};

// Заполняем библиотеку книгами
library.books[0] = new Book { name = "test",      year = 1929, status = true };
library.books[1] = new Book { name = "testBook2", year = 1930, status = true };
library.books[2] = new Book { name = "testBook3", year = 1931, status = true };
library.books[3] = new Book { name = "testBook4", year = 1932, status = true };
library.books[4] = new Book { name = "testBook5", year = 1933, status = false };

// Вывод длины названия каждой книги
foreach (var b in library.books)
{
    Console.WriteLine(b.name.Length);
}

// Показ всех книг
library.ShowAllBook();

// Взять книгу
library.TakeBook("testBook3");
library.ShowAllBook();

// Показать занятые книги
library.BusyBook();

// Вернуть книгу
library.ReturnBook("testBook3");
library.
