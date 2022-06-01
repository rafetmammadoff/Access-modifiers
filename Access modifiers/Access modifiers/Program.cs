using System;

namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tapsiriq **********************************************************************************************
            //  Aşağıdakı memberlərdən ibarət User class yaradın
            //  - UserName - istifadəçinin istifadəçi adını ifadə edir
            //  - Password - İstifadəçinin şifrə dəyərini ifadə edir
            //  UserName dəyəri təyin olunmamış User obyekti yaradıla bilinməməlidir.UserName dəyərinin uzunluğu
            //  minimum 6, maksimum 25 ola bilər.
            //  Password dəyərinin uzunluğu minimum 8 , maksimum 25 ola bilər və içərisində mütlər ən az 1 böyük,
            //  1 kiçik hərf və 1 rəqəm olmalıdır.
            //  Daha sonra User type-da olan obyekt yaradın, bunun üçün username və password dəyərlərini console-dan
            //  qəbul edin.
            //  User classin icinde asagidaki metodlar da olsun:
            //  - HasDigit - parametr olaraq string dəyər qəbul edib o dəyərdə rəqəm varsa geriyə true yoxdusa false
            //  qaytaran metod
            //  - HasUpper -  parametr olaraq string dəyər qəbul edib o dəyərdə uppercase varsa geriyə true yoxdursa
            //  false qaytaran metod
            //  - HasLower - parametr olaraq string dəyər qəbul edib o dəyərdə lowercase varsa geriyə true yoxdursa
            //  false qaytaran metod


            Console.WriteLine("User Name daxil edin : ");   // UserName daxil edirik
            string userN = Console.ReadLine();

            Console.WriteLine("Password daxil edin : ");    // Password daxil edirik
            string passw= Console.ReadLine();

            User user1=new User(userN);

            
            Console.WriteLine("Sizin userName ***********************");
            if (user1.UserName==null)
            {
                Console.WriteLine("UserName tesdiqlenmedi");
            }
            else
            {
                Console.WriteLine(user1.UserName);
            }
            user1.Password =passw;

            Console.WriteLine("Sizin sifreniz ***********************");
            if (user1.Password == null)
            {
                Console.WriteLine("Sifre tesdiqlenmedi");
            }
            else
            {
                Console.WriteLine(user1.Password);
            }
            #endregion
        }
    }
}
