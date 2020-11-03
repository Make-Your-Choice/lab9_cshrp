﻿using System;

namespace lab9_app {
	class special {
		public int bonus_num; //число бонусов
		public int continuation; //длительность в днях
		public special() { //конструктор без параметров
			this.bonus_num = 5;
		}
		public special(int a) { //конструктор с параметром для создания массива
			this.bonus_num = a;
			this.continuation = 1;
		}
		public void output() { //вывод
			Console.WriteLine($"Number of bonuses: {bonus_num}\nContinuation: {continuation}");
		}
		public void reduce_bonus() { //сокращение числа бонусов
			Console.WriteLine("\nDecreasing number of bonuses");
			this.bonus_num = bonus_num - 2;
			Console.WriteLine("Number of bonuses decreased on 2");
		}
		public void set_default() { //установка значений по умолчанию
			this.bonus_num = 5;
		}
		public static special operator + (special spec_offer, int a) { //перегрузка + постфиксная
			special spec_offer1;
			spec_offer1 = new special();
			spec_offer1.bonus_num = spec_offer.bonus_num + a;
			return spec_offer1;
		}
		public static special operator + (int a, special spec_offer) { //перегрузка + префиксная
			special spec_offer1;
			spec_offer1 = new special();
			spec_offer1.bonus_num = a + spec_offer.bonus_num;
			return spec_offer1;
		}
		public static special operator ++ (special spec_offer) { //перегрузка ++ постфиксная и префиксная
			++ spec_offer.bonus_num;
			return spec_offer;
		}
	}
	class book_store {
		special[] spec_offer = new special[10]; //бонусы
		int n=0;
		String title; //название
		String author; //автор
		String genre; //основной жанр
		int price=0; //цена
		int num_stock=0; //количество в магазине
		int popularity=0; //популярность
		public static int space_left; //статическое поле отавшееся в магазине место
		static public int title_len(book_store book) { //статический метод вычисления длины названия
			return book.title.Length;
		}
		public book_store(special[] spec_offer){ //конструктор с параметром
			n = 0;
			for (int i=0; i<n; i++)
			{
				this.spec_offer[i] = spec_offer[i];
			}
			Console.WriteLine("\nEmpty book created\n");
		}
		public String Title { //получение названия
			get { return title; }
			set { title = value; }
		}
	
		public String Author { //получение автора
			get { return author; }
			set { author = value; }
		}
	
		public String Genre { //получение жанра
			get { return genre; }
			set { genre = value; }
		}
	
		public int Price { //получение цены
			get { return price; }
			set { price = value; }
		}
	
		public int Num_stock { //получение количества в магазине
			get { return num_stock; }
			set { num_stock = value; }
		}
	
		public int Popularity { //получение популярности
			get { return popularity; }
			set { popularity = value; }
		}
	
		public book_store(String str1, String str2, String str3, int a, int b, int c, int d, special[] spec_offer) { //конструктор с параметрами
			this.title = str1;
			this.author = str2;
			this.genre = str3;
			this.price = a;
			this.num_stock = b;
			this.popularity = c;
			this.n = d;
			for (int i = 0; i < n; i++)
			{
				this.spec_offer[i] = spec_offer[i];
			}
		}
		public void input(String str1, String str2, String str3, int a, int b, int c, int d) { //ввод
			title = str1;
			author = str2;
			genre = str3;
			price = a;
			num_stock = b;
			popularity = c;
			n = d;
		}
		public void output() { //вывод
			Console.WriteLine("\nYour book");
			Console.Write($"\nTitle: {title}\nAuthor: {author}\nGenre: {genre}\nPrice: {price}\nNumber in stock: {num_stock}\nPopularity: {popularity}");
			Console.Write("\nNumber of bonuses: ");
			for(int i = 0; i < n; i++)
			{
				Console.Write($"{spec_offer[i].bonus_num} ");
			}
			Console.Write("\n");
			}
		public void sell() { //продажа
			Console.WriteLine("\nPutting book on sale");
			num_stock = num_stock - 1;
			popularity = popularity + 5;
			Console.WriteLine("Ony copy sold, popularity increased on 5");
		}
		public void price_rise() { //повышение цены
			Console.WriteLine("\nRising the price");
			price = price + 50;
			Console.WriteLine("Price risen on 50");
		}
		public void rearrange() { //перестановка
			Console.WriteLine("\nRearranging books");
			popularity = popularity + 10;
			Console.WriteLine("Books rearranged, popularity increased on 10");
		}
		public void archivate() { //отправка на склад
			Console.WriteLine("\nSending 4 books to the archive");
			num_stock = num_stock - 4;
			Console.WriteLine("4 books now stored in archive");
		}
		public int predictable_profit(out int a) { //возврат значения через out
			return a = num_stock * price;
		}
		public int predictable_popularity(ref int a) { //возврат значения через ref
			return a = num_stock * 5 + popularity;
		}
		public int summarize(book_store book) { //сложение количества двух книг
			return this.num_stock + book.num_stock;
		}
		public void reduce_bonus() { //уменьшение числа бонусов
			for( int i = 0; i < n; i++)
			{
				this.spec_offer[i].reduce_bonus();
			}
		}
	}
	class lab9 {
		static void Main(string[] args) {
			int x, y, z, n, profit, popularity = 1; //переменные
			String s1, s2, s3; //строки
			Console.WriteLine("Input information about the 1 book\n"); //ввод информации о книге
			Console.WriteLine("Input number of specials: ");
			n = Convert.ToInt32(Console.ReadLine());
			special[] spec_offer1 = new special[10];
			special[] spec_offer2 = new special[10];
			for(int i = 0; i < n; i++)
			{
				spec_offer1[i] = new special();
				spec_offer2[i] = new special();
			}
			Console.WriteLine("Input title: ");
			s1 = Console.ReadLine();
			Console.WriteLine("Input author: ");
			s2 = Console.ReadLine();
			Console.WriteLine("Input genre: ");
			s3 = Console.ReadLine();
			Console.WriteLine("Input price: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input number in stock: ");
			y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input popularity: ");
			z = Convert.ToInt32(Console.ReadLine());
			book_store book1 = new book_store(s1, s2, s3, x, y, z, n, spec_offer1);
			book1.output();
			book_store book2 = new book_store(spec_offer2);
			book2.Title = "www"; //установка значений с помощью сеттера
			book2.Author = "sss";
			book2.Genre = "xxx";
			book2.Price = 200;
			book2.Num_stock = 20;
			book2.Popularity = 25;
			Console.WriteLine("\nSecond book (setter used)");
			book2.output();
			Console.WriteLine("\nNumber in stock of 1 and 2: {0}", book1.summarize(book2)); //сложение количетва двух книг
			String book_genre = book1.Genre; //получение значения геттером
			Console.WriteLine("First book genre is {0}, str length of genre is {1}", book_genre, book_genre.Length); //вычисление длины строки жанр
			Console.WriteLine("\nFirst book");
			book1.output(); //вывод
			book1.sell(); //продажа
			book1.output();
			book1.price_rise(); //повышение цены
			book1.output();
			book1.rearrange(); //перестановка
			book1.output();
			book1.archivate(); //отправка на склад
			book1.output();
			book1.reduce_bonus(); //уменьшение количества бонусов
			book1.output();
			book1.predictable_profit(out profit); //подсчет ожидаемой прибыли через out
			Console.WriteLine("\nPredictable profit: {0}", profit);
			book1.predictable_popularity(ref popularity); //подсчет ожидаемой популярности через ref
			Console.WriteLine("Predictable popularity: {0}", popularity);
			Console.WriteLine("First book title length is {0}",book_store.title_len(book1)); //вывод значения длины строки названия
			book_store.space_left = 50; //установка значения оставшегося места
			Console.WriteLine("Space left in the store {0}",book_store.space_left);
			special[] spec_offer0 = new special[1];
			special[] spec_offer3 = new special[1];
			spec_offer0[0] = new special();
			spec_offer3[0] = new special();
			Console.WriteLine($"\nDefault value of special offer = {spec_offer0[0].bonus_num}");
			spec_offer3[0] = spec_offer0[0] + 5; //перегрузка + постфиксная
			Console.WriteLine($"\nSpecial offer + 5 = {spec_offer3[0].bonus_num}");
			spec_offer3[0] = 10 + spec_offer0[0]; //перегрузка + префиксная
			Console.WriteLine($"10 + Special offer = {spec_offer3[0].bonus_num}");
			spec_offer3[0] = spec_offer0[0] ++; //перегрузка ++ постфиксная
			Console.WriteLine($"Special offer ++ = {spec_offer3[0].bonus_num}");
			spec_offer3[0].set_default();
			spec_offer3[0] = ++ spec_offer0[0]; //перегрузка ++ префиксная
			Console.WriteLine($"++ Special offer = {spec_offer3[0].bonus_num}");
			Console.WriteLine("\nMassive using constructor with a single parameter");
			special[] spec_offer4 = new special[2];
			for(int i = 0; i < 2; i ++)
			{
				spec_offer4[i] = new special(10); //вызов конструктора с одним параметром для создания массива
			}
			Console.WriteLine("\nSpecial offers\n");
			for(int i = 0; i < 2; i ++)
			{
				spec_offer4[i].output();
			}
		}
	}
}