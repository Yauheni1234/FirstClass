// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
using System.Text;

//Console.WriteLine("Hello, World!");

//Урок 5.
//Задание 1: Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все
//символы, являющиеся цифрами.

string word = "test";
word = word.Replace("test", "testing");
Console.WriteLine(word);

//Задание 2: Используя метод вывода значения в консоль, выполните конкатенацию слов и
//выведите на экран следующую фразу: Welcome to the TMS lesons.

string words = "Welcome";
string words2 = "to";
string words3 = "the";
string words4 = "TMS";
string words5 = "lesons";
string text = string.Concat(words, " ", words2, " ", words3, " ", words4, " ", words5);
Console.WriteLine(text);

//Задание 3: Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
//Необходимо найти в данной строке "abc", записав всё что до этих символов в первую
//переменную, а также всё, что после них во вторую. Результат вывести в консоль.

string longText = "teamwithsomeofexcersicesabcwanttomakeitbetter";
string firstText = "teamwithsomeofexcersices";
Console.WriteLine(firstText);
string secondText = longText.Substring(27);
Console.WriteLine(secondText);

//Задание 4: Дана строка: Плохой день.
//Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо
//используя команду insert создать строку со значением: Хороший день!!!!!!!!!. Заменить последний "!" на "?"

string text = "Плохой день";
text = text.Substring(6);
string text2 = text.Replace(" ", "Хороший ");
string text3 = text2.Insert(12, "!!!!!!");
Console.WriteLine(text3);
int ind = text3.Length - 1;
Console.WriteLine(text3);
string text4 = text3.Remove(ind);
Console.WriteLine(text4);
string text5 = text4.Insert(17, "?");
Console.WriteLine(text5);

//Задание 5: Написать программу со следующим функционалом:
//На вход передать строку (будем считать, что это номер документа).
//Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.

Console.WriteLine("Номер документа:");
string doc = "1990-qwe-0205-оgр-1п4К";
Console.WriteLine(doc);

//Вывести на экран в одну строку два первых блока по 4 цифры.
string[] masDoc = doc.Split('-');
Console.WriteLine(masDoc[0] + masDoc[2]);

//Вывести на экран номер документа, но блоки из трех букв заменить
// на *** (каждая буква заменятся на *).

Console.WriteLine(Regex.Replace(doc, @"[qwe, оgр]", "*"));

// Вывести на экран только одни буквы из номера документа в
// формате yyy/yyy/y/y в нижнем регистре.

Console.WriteLine(String.Join("/", masDoc.Where(a => char.IsLetter(a, 0))));

// Вывести на экран буквы из номера документа в формате
// "Letters:yyy/yyy/y/y" в верхнем регистре (реализовать с помощью класса StringBuilder).

var addWord = new StringBuilder("Letters: ");
foreach (var letter in masDoc.Where(c => char.IsLetter(c, 0)))
{
    addWord.Append(letter.ToUpper()).Append("/");
}
Console.WriteLine(text.ToString());

// Проверить содержит ли номер документа последовательность abc и вывести сообщение содержит или нет
// (причем, abc и ABC считается одинаковой последовательностью).

string textToFind = "abc";

if (doc.Contains(textToFind) || doc.Contains(textToFind.ToUpper()))
    Console.WriteLine("Содержит последовательность 'abc'");
else
    Console.WriteLine("Не содержит последовательность 'abc'");



// Проверить начинается ли номер документа с последовательности 555

string textToFind2 = "555";
if (masDoc[0] == "555")
    Console.WriteLine("Начинается с последовательности '555'");
     else
    Console.WriteLine("Не начинается с последовательности '555'");

//Проверить заканчивается ли номер документа на последовательность 1a2b

string textToFind3 = "1a2b";
if (masDoc[5] == "1a2b")
    Console.WriteLine("Заканчивается последовательностью '1a2b'");
else
    Console.WriteLine("Не заканчивается последовательностью '1a2b'");


