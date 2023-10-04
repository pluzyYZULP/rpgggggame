using System;
using System.Diagnostics;

namespace kak_sbejatb //Название программы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя игрока"); //Вывод на экран
            Console.ReadLine();  //Вввод имени
            int trysmir = 0; //счетчик для побега
            bool cikl = false; //цикл второй локации
            int schet = 0; //счетчик для начала 3 цикла
            bool koridor = false; //цикл третьей локации
            int smirn = 0; //если 1,то у тебя есть док-во ,что смирнов тебя отпустил
            int curator = 0; // если 1 ,то у тебя есть док-во,что МИ тебя отпустила
            bool cabinet = false; // цикл первой локации
            int r = 0; // переменная для артефактов
            int n = 0; //нож
            int v = 0;//вейп

            Console.WriteLine("Ты оказался на паре у Смирнова. Он объявляет ,что на этой паре тебя ждёт проверочная работа.");
            Console.WriteLine("Входная дверь в колледж закрыта,в будущем тебе могут понадобиться некоторые артефакты");
            Console.WriteLine("У тебя есть выбор действий.");
            Console.WriteLine("1.Открыть шкаф.2.Посмотреть под стол.3.Попросить что-то у одногруппника.");
            while (!cabinet)
            {
                Console.WriteLine("Выберите Действие");
                int art = Convert.ToInt32(Console.ReadLine()); //art переменная для выбора Действия
                if (art < 1 || art > 3) //условие
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз."); // Если ввод меньше 1 или больше 3 отмена
                    continue;
                }
                if (art == 1)
                {
                    Console.WriteLine("Вы открыли шкаф,в кафу вы видите нож");
                    Console.WriteLine("1.Взять.2.Не брать");
                    int nozh = Convert.ToInt32(Console.ReadLine()); //Взятие ножа
                    if (nozh < 1 || nozh > 2) //условие
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте еще раз."); // Если ввод меньше 1 или больше 2 отмена
                        continue;
                    }
                    if (nozh == 1)
                    {
                        n++;
                        Console.WriteLine("Вы взяли нож и убрали его в карман");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы не стали брать нож");
                        break;
                    }
                }
                if (art == 2)
                {
                    Console.WriteLine("Вы посмотрели под стол,под столом вы увидели протекшую ручку.");
                    Console.WriteLine("1.Брать.2.Не брать.");
                    int ruchka = Convert.ToInt32(Console.ReadLine()); //Взятие ручки
                    if (ruchka < 1 || ruchka > 2) //условие
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте еще раз."); // Если ввод меньше 1 или больше 2 отмена
                        continue;
                    }
                    if (ruchka == 1)
                    {
                        r++;
                        Console.WriteLine("Вы взяли ручку и положили на стол");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы не стали брать ручку");
                        break;
                    }
                }
                if (art == 3)
                {
                    Console.WriteLine("Вы окликнули одногруппника,одногруппник предложил вам электронную сигарету.");
                    Console.WriteLine("1.Согласиться.2.Не соглашаться");
                    int vape = Convert.ToInt32(Console.ReadLine()); //Взятие вейпа
                    if (vape < 1 || vape > 3) //условие
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте еще раз."); // Если ввод меньше 1 или больше 2 отмена
                        continue;
                    }
                    if (vape == 1)
                    {
                        v++;
                        Console.WriteLine("Вы взяли курилку и убрали ее в карман");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Красавчик");
                        break;
                    }
                }

            }
            Console.WriteLine("1.Отпроситься у Смирнова. 2. Написать Куратору. 3.Попытаться незаметно сбежать.4.Выйти в окно"); //Действия
            while (!cikl)
            {
                Console.WriteLine("Выберите действие"); //вывод на экран

                int action = Convert.ToInt32(Console.ReadLine()); //ввод действий


                if (action < 1 || action > 4) //условие
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз."); // Если ввод меньше 1 или больше 4 отмена
                    continue;
                }

                if (action == 1) //Условие для 1 действия
                {
                    if (r == 1)
                    {
                        Console.WriteLine("Вы можете испачкать свои руки в ручке.");
                        Console.WriteLine("1.Воспользоваться.2.Постараться просто выйти");
                        int ruki = Convert.ToInt32(Console.ReadLine());
                        if (trysmir == 4 || ruki == 1)
                        {
                            schet++; //счетчик +1
                            smirn++;
                            Console.WriteLine("Смирнов открыл дверь"); //правильное условие
                        }
                        else
                        {
                            trysmir++;//счетчик +1
                            Console.WriteLine("Смирнов послал вас");
                        }
                    }
                }
                if (action == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Напишите сообщение куратору");
                        string soob = Console.ReadLine();
                        if (soob.Contains("пожалуйста") || soob.Contains("Пожалуйста") || soob.Contains("прошу") || soob.Contains("Прошу")) //если в сообщении есть пожалуйста то выводит
                        {
                            schet++; //счетчик +1
                            curator++;
                            Console.WriteLine("Куратор просит передать Смирнову,что она тебя отпускает");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("С куратором нужно быть повежлевее");
                        }
                    }
                }
                if (action == 3)
                {
                    Random xalyava = new Random(); //рандомайзер
                    int chance = xalyava.Next(1, 5);
                    int vezen = 2;
                    if (vezen == chance)
                    {
                        schet++;
                        Console.WriteLine("Вы смогли выйти из кабинета");
                    }
                    else
                    {
                        Console.WriteLine("Вас заметил Смирнов");
                        break;
                    }
                }
                if (action == 4)
                {
                    Console.WriteLine("Проигрыш");
                    break;
                }
                if (schet == 1)
                {
                    cikl = true;
                    Console.WriteLine("Вы смогли выйти в коридор");
                    Console.WriteLine("В дали коридора вы видите Тамашонок");
                    Console.WriteLine("1.Спрятаться в туалете. 2.Убежать в сторону спортивного зала. 3. Дождаться пока она подойдёт к тебе.");
                    while (!koridor)
                    {
                        Console.WriteLine("Выберите действие");

                        int action1 = Convert.ToInt32(Console.ReadLine());


                        if (action1 < 1 || action1 > 3)
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                            continue;
                        }

                        if (action1 == 1) //Спрятаться в туалете
                        {
                            Random tam = new Random(); //рандом
                            int tyt = tam.Next(1, 4);
                            int tit = 2;
                            if (tyt == tit) //сравнение
                            {
                                Console.WriteLine("Тамошонок прошла мимо");
                                Console.WriteLine("Урааа,тебе очень повезло,ты сбежал.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Тамошонок заметила вас");
                                Console.WriteLine("1.Показать сообщение от куратора. 2.Сказать, что болит живот. 3.Сказать,что тебя отпустил Смирнов.");
                                int action2 = Convert.ToInt32(Console.ReadLine());
                                if (action2 == 1) //Показываем сообщение куратора
                                {
                                    if (curator == 1) //проверяем из 1 цикла писали ли мы куратору
                                    {
                                        Console.WriteLine("Тамашонок,увидев сообщение,отпустила тебя.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Плохо врать тьютору.");
                                        break;
                                    }
                                }
                                if (action2 == 2)
                                {
                                    Console.WriteLine("Ей всё равно,поэтому тебя ждёт совет профилактики");
                                    break;
                                }
                                if (action2 == 3)
                                {
                                    if (smirn == 1)
                                    {
                                        Console.WriteLine("Тамашонок поверила тебе на слово и отпустила");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Тамашонок пошла к Смирнову и тебе пипец.");
                                        break;
                                    }


                                }



                            }
                        }
                        if (action1 == 2) //Побег
                        {
                            Console.WriteLine("Вы убежали в сторону спортивного зала");
                            Console.WriteLine("1.Отсидеться в тренажёрном зале. 2.Добежать до выхода.");
                            int action3 = Convert.ToInt32(Console.ReadLine());
                            if (action3 == 2)
                            {
                                if (n == 1)
                                {
                                    Console.WriteLine("Вы смогли вскрыть замок");
                                    Console.WriteLine("Вы успешно сбежали с пары Смирновa.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Дверь закрыта");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы успешно прогуляли пару ,но потеряли 50 минут.");
                                break;

                            }
                        }
                        if (action1 == 3)
                        {
                            Console.WriteLine("Тамошонок подошла к вам");
                            Console.WriteLine("1.Рассказать шутку.2.Сказать,что Тебя отпустил Смирнов.3.Показать сообщение куратора.");
                            int action4 = Convert.ToInt32(Console.ReadLine());
                            if (action4 < 1 || action4 > 3)
                            {
                                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                                continue;
                            }
                            if (action4 == 1)
                            {
                                Console.WriteLine("По секрету ей нравятся шутки про клоунов и шутки про Зама кафедры");
                                Console.WriteLine("Введите шутку");

                                string shut = Console.ReadLine();

                                if (shut.Contains("клоун") || shut.Contains("клоуны") || shut.Contains("Смирнов") || shut.Contains("Евгений") || shut.Contains("смирнов"))
                                {
                                    Console.WriteLine("Ей понравилась твоя шутка.Она сделала вид,что не видела тебя.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Твоя шутка ей не порнравилась,Проигрыш.");
                                    break;
                                }
                            }
                            if (action4 == 2)
                            {
                                if (smirn == 1)
                                {
                                    Console.WriteLine("Тамашонок отпустила тебя.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Тамашонок пошла к Смирнову и тебя не отпустили.");
                                    break;
                                }
                            }
                            if (action4 == 3)
                            {
                                if (curator == 1)
                                {
                                    Console.WriteLine("Тамашонок,увидев сообщение,отпустила тебя.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Смерть...");
                                    break;
                                }

                            }



                        }
                    }


                }
            }
           
        }

    }
}


