using Domain;
using HighSchoolLesson.DataAccess;
using System;
using System.Collections.Generic;

namespace LibraryAdoNet
{
	/*
	Курс: «Технология доступа к базам данных ADO.NET»
	Тема: Введение в Entity Framework
	Создайте базу данных для библиотеки. В ней будет храниться информация о зарегистрированных 
		посетителях библиотеки, какие книги на руках у посетителя; является ли посетитель должником. 
	Книга может иметь несколько авторов, а один автор может быть автором нескольких книг.
	Выполните к созданной структуре таблиц следующие задачи:
		1) Выведите список должников.
		2) Выведите список авторов книги №3 (по порядку из таблицы ‘Book’).
		3) Выведите список книг, которые доступны в данный момент.
		4) Вывести список книг, которые на руках у пользователя №2.
		5) Обнулите задолженности всех должников.
	*/
	class Program
	{
		static void Main(string[] args)
		{

			//CreateDb();
		}

		private static void CreateDb()
		{
			using (var context = new LibraryContext())
			{
				var book1 = new Book
				{
					Title = "Martin Eden"
				};
				var book2 = new Book
				{
					Title = "Sea Wolf"
				};
				var book3 = new Book
				{
					Title = "Some book"
				};
				var book4 = new Book
				{
					Title = "Another book"
				};

				var author1 = new Author
				{
					FullName = "Jack London"
				};
				var author2 = new Author
				{
					FullName = "Creig Drake"
				};

				var booksAuthors1 = new BooksAuthors
				{
					Author = author1,
					Book = book1
				};

				var booksAuthors2 = new BooksAuthors
				{
					Author = author1,
					Book = book2
				};

				var booksAuthors3 = new BooksAuthors
				{
					Author = author2,
					Book = book3
				};

				var booksAuthors4 = new BooksAuthors
				{
					Author = author2,
					Book = book4
				};

				var visitor = new Visitor
				{
					FullName = "Alex Frad",
					Debtor = false	
				};

				context.Add(book1);
				context.Add(book2);
				context.Add(book3);
				context.Add(book4);
				context.Add(author1);
				context.Add(author2);
				context.Add(booksAuthors1);
				context.Add(booksAuthors2);
				context.Add(booksAuthors3);
				context.Add(booksAuthors4);
				context.Add(visitor);

				context.SaveChanges();
			}
		}
	}
}
