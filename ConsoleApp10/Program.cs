using ConsoleApp10.Helper.Enums;
using ConsoleApp10.Helper.Exceptions;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3

            bool stop = true;
            string secim;

            do
            {
                Console.WriteLine("\n1-Sisteme giris\r\n0-Cixis\n");
                secim = Console.ReadLine();

                switch (secim) 
                {
                    case "1":
                        Console.WriteLine("\n1-Hotel yarat \r\n2-Butun Hotelleri gor\r\n3-Hotel sec \r\n0-Exit\n");
                        secim= Console.ReadLine();

                        switch (secim)
                        {
                            case "1":
                                
                                break;
                        }

                        break;

                    case "0":
                        stop = false;
                        break;
                    default:
                        Console.WriteLine("secim duzgun deyil");
                        break;
                }

            }
            while (stop);
            /*
             ******Menu******
1.Sisteme giris
0.Cixis

Sisteme giris oldugu zaman
1.Hotel yarat (Hotel yarat secdikden sonra bir otel yaradirsiz. eyni adda hotel ola bilmez :D)
2.Butun Hotelleri gor
3.Hotel sec (hotelin adini daxil ederek secilecek)
0.Exit

Hotel secildikden sonra
1.Room yarat
2.Roomlari gor
3.Rezervasya et(eger hec bir otaq yoxdursa rezervasya xidmeti islemir)
4.Evvelki menuya qayit.
0.Exit
             */























            ////1
            //Person person = new Person();
            //try
            //{
            //    person.Fullname = Console.ReadLine();
            //    person.Age = byte.Parse(Console.ReadLine());
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine("salammmmmm " + ex.Message);
            //}


            //2
            //Store BazarStore = new Store();

            //bool stop = true;
            //string secim;
            //do
            //{

            //    Console.WriteLine("\nAddProduct-1\nFilterProductsByType-2\nFilterProductByName-3\nGetProduct-4\nRemoveProduct-5\nExit-0\n");
            //    secim = Console.ReadLine();

            //    switch (secim)
            //    {
            //        case "1":
            //            Console.WriteLine("\nmehsul adi daxil edin");
            //            string name = Console.ReadLine();

            //            Console.WriteLine("\nqiymet teyyin edin");
            //            float price = float.Parse(Console.ReadLine());

            //            Console.WriteLine("mehsulun tipini secin \n\n  Baker- 1\n  Drink- 2\n  Meat - 3\n  Diary- 4\n");
            //            secim = Console.ReadLine();

            //            switch (secim)
            //            {
            //                case "1":
            //                    BazarStore.AddProduct(new Product(name, ProductType.Baker, price));
            //                    Console.WriteLine("product add olundu");
            //                    break;

            //                case "2":
            //                    BazarStore.AddProduct(new Product(name, ProductType.Drink, price)); break;
            //                    Console.WriteLine("product add olundu");
            //                    break;

            //                case "3":
            //                    BazarStore.AddProduct(new Product(name, ProductType.Meat, price)); break;
            //                    Console.WriteLine("product add olundu");
            //                    break;

            //                case "4":
            //                    BazarStore.AddProduct(new Product(name, ProductType.Diary, price)); break;
            //                    Console.WriteLine("product add olundu");
            //                    break;

            //                default:
            //                    Console.WriteLine("xeta!!! proses tamamlanmadi");
            //                    break;
            //            }
            //            break;

            //        case "2":
            //            Console.WriteLine("axtardiginiz mehsulun tipini secin \n\n  Baker- 1\n  Drink- 2\n  Meat - 3\n  Diary- 4\n");
            //            secim = Console.ReadLine();
            //            switch (secim)
            //            {
            //                case "1":
            //                    BazarStore.FilterProductsByType(ProductType.Baker);
            //                    break;

            //                case "2":
            //                    BazarStore.FilterProductsByType(ProductType.Drink);
            //                    break;

            //                case "3":
            //                    BazarStore.FilterProductsByType(ProductType.Meat);
            //                    break;

            //                case "4":
            //                    BazarStore.FilterProductsByType(ProductType.Diary);
            //                    break;

            //                default:
            //                    Console.WriteLine("xeta!!! secim duzgun deyil");
            //                    break;
            //            }
            //            break;

            //        case "3":
            //            Console.WriteLine("axtardiginiz mehsulun adini daxil edin");
            //            string namee = Console.ReadLine();
            //            BazarStore.FilterProductByName(namee);
            //            break;

            //        case "4":
            //            Console.WriteLine("product no daxil edin");
            //            int? noo = int.Parse(Console.ReadLine());
            //            BazarStore.GetProduct(noo);
            //            break;

            //        case "5":
            //            Console.WriteLine("remove etmek isdediyiniz product a uygun no daxil edin");
            //            int? no = int.Parse(Console.ReadLine());
            //            BazarStore.RemoveProduct(no);
            //            break;

            //        case "0":
            //            stop = false;
            //            break;
            //        default:
            //            Console.WriteLine("secim duzgun deyil");
            //            break;
            //    }
            //}
            //while (stop);




































        }

    }
}
