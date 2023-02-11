using LanguageExt.TypeClasses;
using meow1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace meow1
{
    class Program
    {
        static void Main(string[] args)
        {
           yıldızlıPramid();
            // yıldızlıPramid2();
            string name = "ahmet -PAMDÖĞASOFT";
            // BeniTersCevirPakize(name);
            // Ort();
            // SayiNegetifMi();
            // HangiSayıKücük();
            // VizeAndFinal();
            // EkranaYazdirBaba();
            // Yarıcap();
            // ücgenHesaplama();
            // NToplam();
            // nFaktoriyel();
            // BanaDereceVerAbi();
            // TekMiCiftMi();
            // MutlakDeğerHesaplarımBen();
            // SayıTamBölünüyorMu();
            // TekSayıCoklayıcı();             //bitmedi


            // EnBüyükSayıBul();
            // TekMiCiftMis();
            // GirilebSayının2KatınınBirFazlasınıAlıp5EBölümüneBakarım();
            // StringCaculate();
            // MiniÜniCalculator();
            // EnBüyükSayı2();
            //TamSayıFaktöriel();

            // ciftSayıToplamı();
            // ücgenBulucu();
            // To50Calculator();
            // And90();
            // Tekrarla();
            //to80AndOrt();


            //BeniBulGardas();
            // BeniBulGardas2();
            //isimVeNo();
            //isimVeNoTekcift();



            //FahneraytToC();
            //RabiaKocabas();
            // Addition();
            //Addition5();
            // YasHesabı();
            //Eksilt();
            //CalculatorBasic(); 

            //DogukanIncirbolen();
            // Calculate();
            // CalculateFiveNumbers();
            //MinusFunction();
            //Eksilt();
            Calculator3();

        }

        void Main2(string[] args)
        {

        }

        private static void yıldızlıPramid()
        {
            int space = 4;
            int star = 1;

            for (int i = 0; i < 5; i++)
            {
                string text = "";

                for (int j = 0; j < space; j++)
                {
                    text += " ";
                }

                for (int k = 0; k < star; k++)
                {
                    text += "*";
                }
                Console.WriteLine(text);

                space--;
                star = star + 2;
            }
        }

        private static void yıldızlıPramid2()
        {
            int space = 4;
            int star = 1;

            for (int i = 0; i < 5; i++)
            {
                string text = "";

                text += new string(Enumerable.Repeat(' ', space).ToArray());
                text += new string(Enumerable.Repeat('*', star).ToArray());

                Console.WriteLine(text);

                space--;
                star = star + 2;
            }
        }

        private static void BeniTersCevirPakize(string name)
        {

            string text = new string(name.Reverse().ToArray());
            Console.WriteLine(text);
            GC.Collect();
        }

        private void ornek2()
        {
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 7 == 0)
                {
                    Console.WriteLine("you can divided by 7");
                }
                else
                {
                    Console.WriteLine("you can not divided by 7");
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num % 7 == 0 ? "you can divided by 7" : "you can not divided by 7");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(int.Parse(Console.ReadLine()) % 7 == 0 ? "you can divided by 7" : "you can not divided by 7");
            }
        }

        private void x()
        {
            string name; // string variable name  
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine(); // takes an input from the user  
            Console.WriteLine("Hi! " + name + " Welcome to the meow"); // print the output  
        }

        private static void find()
        {
            Console.WriteLine("Enter a number");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine(num);

            Console.WriteLine("Enter a number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            float num3 = float.Parse(Console.ReadLine());

            if (num % 7 == 0)
            {
                Console.WriteLine("this number can divided by 7");
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("this number can not divided by 7");
                Console.WriteLine(num);
            }

            if (num2 % 7 == 0)
            {
                Console.WriteLine("this number can divided by 7");
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("this number can not divided by 7");
                Console.WriteLine(num2);
            }

            if (num3 % 7 == 0)
            {
                Console.WriteLine("this number can divided by 7");
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine("this number can not divided by 7");
                Console.WriteLine(num3);
            }
        }

        static void arrTry(int[] arr)
        {
            Console.WriteLine("\n\nElements of array are:\n");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
        }
        static void findVersion2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
            }

        }

        static void Ort()
        {
            Console.WriteLine("girdiğiniz 2 sayının ortalamasını hesaplayan program");

            int ort;

            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            ort = (num + num2) / 2;
            Console.WriteLine(ort);

        }

        static void SayiNegetifMi()
        {
            Console.WriteLine("girdiğiniz sayının pozitif mi negatif mi olduğunu hesaplayan program");

            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("0 pozitif yada negatif değildir, lütfen başka bir sayı giriniz");
            }
            else if (num > 0)
            {
                Console.WriteLine("girdiğiniz sayı pozitifdir");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı negatifdir");
            }
        }

        static void HangiSayıKücük()
        {
            Console.WriteLine("girdiğiniz sayıdan küçük olanı bulmanızı sağlayan program");

            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num < num2)
            {
                Console.WriteLine("girdiğiniz 2. sayı, 1. sayıdan büyüktür.");
            }
            else
            {
                Console.WriteLine("girdiğiniz 1 sayı ,2. sayıdan büyüktür");
            }
        }

        static void VizeAndFinal()
        {
            Console.WriteLine("girilen vize ve final notlarını hesaplayan program");

            Console.WriteLine("Vize notunuzu giriniz: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Final notunuzu giriniz: ");
            int num2 = int.Parse(Console.ReadLine());

            float vize;
            float final;

            vize = (float)(num * 0.3);
            final = (float)(num * 0.7);

            float total;

            total = (vize + final);

            Console.WriteLine(total);
        }

        static void EkranaYazdirBaba()
        {
            int num;
            num = 0;
            for (int i = 1; i < 1001; i++)
            {
                num++;
                Console.WriteLine(num);

                Console.WriteLine(i);
            }
        }
        static void Yarıcap()
        {
            Console.WriteLine("dairenin yarı çapını giriniz: ");
            int num = int.Parse(Console.ReadLine());

            float pi = 3.14f;
            float cevre;
            float alan;

            cevre = (num * pi);
            alan = pi * (num * 2);

            Console.WriteLine("dairenin alanı:" + alan);
            Console.WriteLine("dairenin çevresi: " + cevre);
        }

        static void ücgenHesaplama()
        {
            Console.WriteLine("üçgenin yüksekliğini girin: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("üçgenin tabanını girin");
            int taban = int.Parse(Console.ReadLine());

            int alan = (h * taban) / 2;

            Console.WriteLine("üçgenin alanı:" + alan);

        }

        static void NToplam()
        {
            Console.WriteLine("verdiğin sayıları toplarım ben babüş :)");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int a = 0;

            while (n > a)
            {
                total += ++a;
            }
            Console.WriteLine(total + "\n");
        }

        static void nFaktoriyel()
        {
            Console.WriteLine("ben faktoriyel hesaplarım :)");
            int faktoriyel = int.Parse(Console.ReadLine());
            int total;
            int atama;


            while (faktoriyel > 0)
            {
                atama = faktoriyel;
                --faktoriyel;
                total = faktoriyel * atama;
                Console.WriteLine("faktoriyel sonucu: " + total);
            }
        }

        static void BanaDereceVerAbi()
        {
            Console.WriteLine("bana derece var abi sana Radyan ve Drad verim.");
            int derece = int.Parse(Console.ReadLine());

            float pi = 3.14f;
            float radyan;
            float grad;

            radyan = (pi * derece) / 180;
            grad = (pi * derece) / 200;

            Console.WriteLine("Radyan: " + radyan);
            Console.WriteLine("Grad: " + grad);
        }

        static void TekMiCiftMi()
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("giediğiniz sayı tekdir");
            }
        }
        static void MutlakDeğerHesaplarımBen()
        {
            Console.WriteLine("bana verdiğin sayının mutlak değerini hesaplarım ben");

            int num = int.Parse(Console.ReadLine());
            int total;

            if (num > 0)
            {
                Console.WriteLine("Mutlak değer: " + num);
            }
            else
            {
                total = num * (-1);
                Console.WriteLine("Mutlak değer " + total);
            }
        }

        static void SayıTamBölünüyorMu()
        {
            Console.WriteLine("girdiğiniz sayıların birbirine tam bölünüp bölünmediğini hesaplarım.");
            Console.WriteLine("1. sayıyı giriniz: ");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            int numB = int.Parse(Console.ReadLine());

            int division;

            if (numA % numB == 0)
            {
                Console.WriteLine("girdiğiniz 1. sayı, 2. sayıya tam bölünebilir");

                division = numA / numB;
                Console.WriteLine("bölüm sonucu" + division);
            }
            else
            {
                Console.WriteLine("girdiğiniz 1. sayı, 2. sayıya tam bölünemez");
            }
        }

        static void TekSayıCoklayıcı()
        {
            Console.WriteLine("verdiğin sayının tek katlarını toplarım :)");

            int num = int.Parse(Console.ReadLine());

            int total = 0;


            if (num % 2 == 0)
            {
                --num;
            }


            while (num >= 0)
            {
                total += num;
                num -= 2;
                Console.WriteLine("tek katlarının toplamı " + num);
            }
        }

        // diğer site
        // // http://bilisimokulu.blogspot.com/2013/10/algoritma-ornekleri-ve-yaziliya.html

        static void PlasAndMinus10()
        {
            Console.WriteLine("giriğiniz sayının 10 eklenmiş ve 10 çıkarılmış halini veririm");
            int num = Convert.ToInt32(Console.ReadLine());

            int numMinus;
            int numPlas;

            numPlas = num + 10;
            numMinus = num - 10;

            Console.WriteLine("num+10: " + numPlas);
            Console.WriteLine("num-10: " + numMinus);

            //or

            Console.WriteLine("num +10: " + (num + 10) + "num-10: " + (num - 10));
        }

        static void AlanHesapla()
        {
            Console.WriteLine("bana verdiğiniz dirtdörtgenin alanını hesaplarım");

            bool calculate;
            Console.WriteLine("a kenarını giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b kenarını giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int alan;

            if (a > 0 && b > 0)
            {
                calculate = true;
            }
            else
            {
                calculate = false;
            }

            if (calculate == true)
            {
                alan = a * b;
                Console.WriteLine("dirtdörtgenin alanı: " + alan);
            }
            else
            {
                Console.WriteLine("değerleri (-) eksi girmeyiniz.");
            }
        }

        static void HipotenusCalculator() // örn3  tamamlanmadı
        {
            Console.WriteLine("bana verdiğiniz a ve b değerleriyle üçgen oluşturup onun hipotenüsünü hesaplarım");
            Console.WriteLine("a kenarını giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b kenarını giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hip = (a * a) + (b * b);
            int kök;
        }

        static void KareVeKüpCalculator()
        {
            Console.WriteLine("girdiğiniz sayının karesini ve küpünü hesaplarım.");

            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                int kare = (num * num);
                int küp = (num * num * num);

                Console.WriteLine("Girdiğiniz sayının karesi: " + kare);
                Console.WriteLine("girdiğiniz sayının küpü: " + küp);

                //or

                Console.WriteLine("Girdiğiniz sayının karesi: " + kare + "girdiğiniz sayının küpü: " + küp);

                //or

                Console.WriteLine("girdiğiniz sayının karesi:" + (num * num) + "girdiğiniz sayının küpü: " + (num * num * num));
            }
            else
            {
                Console.WriteLine("lütfen pozitif bir tamsayı giriniz.");
            }
        }

        static void OrtCalculator()
        {
            Console.WriteLine("1. sınav sonucunuzu giriniz: ");
            int sonuc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sınav sonucunuzu giriniz: ");
            int sonuc2 = Convert.ToInt32(Console.ReadLine());

            int ort = ((sonuc + sonuc2) / 2);

            if (ort >= 45)
            {
                Console.WriteLine("ortalamanız: " + ort + "dersi geçtiniz.");
            }
            else
            {
                Console.WriteLine("orlamanız: " + ort + "dersten kaldınız.");
            }
        }

        static void AracParkCalculator()
        {
            Console.WriteLine("aracınız kaç saat park alanında kalacak? Tek seferde en fazla 24 saat park edebilirsiniz");
            int parkSüresi = Convert.ToInt32(Console.ReadLine());

            if (parkSüresi > 24 || parkSüresi < 0)
            {
                Console.WriteLine("lütfen park sistemi kurallarına uyunuz.");
            }
            else
            {
                if (parkSüresi <= 2)
                {
                    Console.WriteLine("borcunuz 200TL");
                }
                else if (parkSüresi > 2 && parkSüresi < 8)
                {
                    Console.WriteLine("borcunuz 500TL");
                }
                else
                {
                    Console.WriteLine("borcunuz 800 TL");
                }
            }
        }

        static void SayıToplamıVeOrtCalculator()
        {
            Console.WriteLine("bana verdiğiniz 5 sayıyı toplarım ve orlalamasını yazdırırım");

            Console.WriteLine("1. sayıyı giriniz: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı giriniz: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("4. sayıyı giriniz: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("5. sayıyı giriniz: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int toplam = (num1 + num2 + num3 + num4 + num5);
            int ort = (toplam) / 2;

            Console.WriteLine("sayıların toplamı: " + toplam + " sayıların ortalaması" + ort);
        }

        static void EnBüyükSayıBul()
        {
            Console.WriteLine("girilen 3 sayıdan büyük olanı bulurum.");

            Console.WriteLine("1. sayıyı giriniz: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("girdiğiniz en büyük sayı: " + num1);
                }
                else if (num3 > num1)
                {
                    Console.WriteLine("girdiğiniz en büyük sayı: " + num3);
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("girdiğiniz en büyük sayı: " + num2);
                }
                else if (num3 > num2)
                {
                    Console.WriteLine("girdiğiniz en büyük sayı: " + num3);
                }
            }
        }

        static void TekMiCiftMis() //meow
        {
            Console.WriteLine("girdiğiniz sayı tek mi çift mi onu bulurum.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı tekdir.");
            }
        }

        static void GirilebSayının2KatınınBirFazlasınıAlıp5EBölümüneBakarım()
        {
            int sayac = 0;

            for (int i = 0; i < 101; i++)
            {
                if (((i * 2) + 1) % 5 == 0)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
        }


        static void StringCaculate()
        {
            string text = "2+8 * (8*3) / 4";

            DataTable dt = new DataTable();
            var asd = dt.Compute(text, "");
        }

        static void MiniÜniCalculator()
        {
            Console.WriteLine("yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("öğrenci no giriniz: ");
            int öNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adınızı giriniz: ");
            string öIsim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soy adınızı giriniz: ");
            string öSoyIsim = Convert.ToString(Console.ReadLine());

            Console.WriteLine("1. sınav sonucunuzu giriniz: ");
            int sonuc1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sınav sonucunuzu giriniz: ");
            int sonuc2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sınav sonucunuzu giriniz: ");
            int sonuc3 = Convert.ToInt32(Console.ReadLine());

            int ort = (sonuc1 + sonuc2 + sonuc3) / 3;

            if (ort >= 50)
            {
                Console.WriteLine(öIsim + " " + öSoyIsim + " " + yas + " " + öNo + " " + "isimli ve nolu öğrenci: " + ort + " ile geçmiştir");
            }
            else
            {
                Console.WriteLine(öIsim + " " + öSoyIsim + " " + yas + " " + öNo + " " + "isimli ve nolu öğrenci: " + ort + " ile geçememiştir");
            }
        }

        static void EnBüyükSayı2()
        {
            Console.WriteLine("Girilen sayılardan en büyük olanı bulurum.");

            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num > num2)
            {
                Console.WriteLine("Büyük sayı: " + num);
            }
            else
            {
                Console.WriteLine("Büyük sayı: " + num2);
            }
        }

        static int fak2(int num)
        {
            return num * (--num > 0 ? fak2(num) : 1);
        }
        //5 * (4 * (3 * (2 * (1 * (1)))))
        static void TamSayıFaktöriel()
        {
            int num = Convert.ToInt32(Console.ReadLine()); //5x4x3x2x1 = 5! = 240      //bitmedi

            int fak = 1;

            for (int i = 1; i <= num; i++)
                fak *= i;

            Console.WriteLine(fak);
            Console.WriteLine(fak2(num));

            //int total = 0;
            //int total2 = 0;
            //
            //
            //
            //for (int i = 0; i < num; i++)
            //{
            //    total += (num * (num - 1)); //20 - 4*3 =12 +20= 32 // 20*3
            //    num = num - 2;
            //
            //    total2 += total * num;
            //    num--;
            //
            //    //totalMax += total * (num - 1);
            //
            //    Console.WriteLine(total2);
            //}
        }

        static void AddStudentAndScore() //bitmedi
        {
            Univ üniv;
            Univ univ = new Univ();

            string isim;
            string Soyisim;



            //   List<List> ögrenciler = new List<List>();

        }

        static void ücgenBulucu()
        {
            Console.WriteLine("a kenarını giriniz: ");
            int kenarA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b kenarını giriniz: ");
            int kenarB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c kenarını giriniz: ");
            int kenarC = Convert.ToInt32(Console.ReadLine());

            if (kenarA > 0 && kenarB > 0 && kenarC > 0)
            {
                if (kenarA == kenarB && kenarB == kenarC)
                {
                    Console.WriteLine("Bu bir eşkenar üçgendir.");
                }
                else if (kenarA == kenarB || kenarB == kenarC)
                {
                    Console.WriteLine("bu bir ikiz kenar üçgendir.");
                }
                else if (kenarA != kenarB && kenarB != kenarC)
                {
                    Console.WriteLine("bu normal bir üçgendir.");
                }
            }
            else
            {
                Console.WriteLine("üçgenin kenarları negatif olamaz.");
            }

        }

        static void To50Calculator()
        {
            int min = 20;
            int total = 0;

            for (int i = 0; i < 30; i++)
            {
                total += min;
                min++;
                Console.WriteLine(total);
            }
            Console.WriteLine(total);
        }

        static void And90()
        {
            int num = 30;
            int total = 0;

            for (int i = 0; i < 61; i++)
            {
                num++;

                if (num % 2 == 1)
                {
                    total += num;
                }
            }
            Console.WriteLine(total);
        }

        static void to80AndOrt()
        {
            int num = 40;
            int total = 0;
            int ort;

            for (int i = 0; i < 41; i++)
            {
                num++;

                if (num % 2 == 1)
                {
                    total += num;
                    Console.WriteLine(total);
                }
            }
            ort = total / 20;

            Console.WriteLine("total is:" + total + " ort is: " + ort);
        }

        static void Write0()   //bitmedi
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("yeni sayıyı giriniz.");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("programı kapatmak için 0 a basınız: ");
            }

            // if (num == 0)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

        }

        static void BeniBulGardas()
        {
            int total = 0;
            int a = 0;
            int b = 0;

            int[] arrayMeow = new int[] { 3, 15, 7, 10 };

            for (int i = 0; i < arrayMeow.Length; i++)
            {
                total = arrayMeow[b] + arrayMeow[a];

                if (arrayMeow[b] != 10)
                {
                    b++;
                }

                if (arrayMeow[a] != 7)
                {
                    a++;
                }

                if (total == 17)
                {
                    Console.WriteLine(arrayMeow[b] + arrayMeow[a] + " " + b + " " + a);
                }
            }
        }
        static void BeniBulGardas2()
        {
            int a = 0;
            int b = 0;

            int[] arrayMeow = new int[] { 3, 7, 15, 10 };

            for (int i = 0; i < arrayMeow.Length - 1; i++)
            {
                if (arrayMeow[a] + arrayMeow[b] != 17)
                {
                    b++;
                }
                Console.WriteLine(arrayMeow[a] + arrayMeow[b]);
            }

        }

        static void FahneraytToC()
        {
            Console.WriteLine("fahrenayt değer girmek için 1'e, celsius değer girmek için 2 ye basınız.");

            double chose = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            double f = 0;


            if (chose == 1) //sesyuls
            {
                Console.WriteLine("değeri giriniz: ");
                double ch = Convert.ToDouble(Console.ReadLine());

                c = ch;
                f = (c * 1.8) + 32;
                Console.WriteLine("c: " + c + "  " + " f: " + f);
            }
            else if (chose == 2)//fah
            {
                Console.WriteLine("değeri giriniz: ");
                int fh = Convert.ToInt32(Console.ReadLine());

                f = fh;
                c = (f - 32) * 9 / 5;
                Console.WriteLine("c: " + c + "  " + " f: " + f);

            }
            else if (chose != 1 || chose != 2)
            {
                Console.WriteLine("seçim kurallarına uyunuz!!!");
            }

        }

        //work
        static void Tekrarla()
        {
            Console.WriteLine("isminizi giriniz: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("soy isminizi giriniz: ");
            string surname = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name + " " + surname);
            }
        }

        static void isimVeNo()
        {
            int num = 0;
            string name = "FatihMehmet";
            string surname = "Duyar";

            for (int i = 0; i < 10; i++)
            {
                ++num;
                Console.WriteLine(num + " " + name + " " + surname);
            }
        }

        static void isimVeNoTekcift()
        {
            int num = 0;
            int totalPlas = 0;
            int totalMinüs = 0;

            string name = "FatihMehmet";
            string surname = "Duyar";

            for (int i = 0; i < 10; i++)
            {
                ++num;
                //Console.WriteLine(num + " " + name + " " + surname);

                if (num % 2 == 0)
                {
                    Console.WriteLine("Bu sayı çifttir" + " " + num + " " + name + " " + surname);
                    totalPlas += num;
                }
                else
                {
                    Console.WriteLine("Bu sayı tektir" + " " + num + " " + name + " " + surname);
                    totalMinüs += num;
                }
            }
            Console.WriteLine("tek sayıların toplamı: " + " " + totalMinüs + "   " + " toplamı: " + totalPlas);

            Console.WriteLine("tüm sayıların toplamı: " + (totalPlas + totalMinüs)); // içine bir sitring girdi o yüzden çift parantez aldık
        }

        static void ciftSayıToplamı()
        {
            int num = 0;
            int total = 0;
            for (int i = 0; i < 101; i++)
            {
                num++;
                if (num % 2 == 0)
                {
                    total += num;
                }
            }
            Console.WriteLine(total);
        }

        static void RabiaKocabas()
        {
            string name = ("Rabia Kocabas");
            int num = 0;

            double telNo = 05358318493;

            int tek = 0;
            int cift = 0;
            int total;

            for (int i = 0; i < 100; i++)
            {
                ++num;
                //Console.WriteLine(num+" "+name);
                //  num++;

                if (num % 2 == 0)
                {
                    // Console.WriteLine(num + " " + name);
                    Console.WriteLine(num + " " + name + "     bu sayı çifttir");

                    Console.WriteLine("tel no: " + telNo);

                    cift += num;

                    Console.WriteLine("çift sayıların toplamı: " + cift);
                }
                else
                {
                    Console.WriteLine(num + " " + name + "     bu sayı tektir");

                    tek += num;
                    Console.WriteLine("tek sayıların toplamı: " + tek);
                }

                total = cift + tek;
                Console.WriteLine("total: " + total);

                if (num % 2 == 1)
                {
                    //Console.WriteLine(num + " " + name);
                }
            }
        }

        static void Addition()
        {
            int total;
            int max;

            Console.WriteLine("toplmaka için 2 sayı giriniz!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("total is:" + (num1 + num2));

            total = num1 + num2;
            Console.WriteLine("total is: " + total);

            max = (total * 2) + 1;

            if (max % 7 == 0)
            {
                Console.WriteLine("bu sayı 7 ye tam bölünür!!!");
            }

            if (max % 5 == 0)
            {
                Console.WriteLine("bu sayı 5 e tam bölünür!!!");
            }
        }

        static void Addition5()
        {
            int tek = 0;
            int cift = 0;
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    cift += num;
                }
                else
                {
                    tek += num;
                }

                total += num;
                Console.WriteLine("total is: " + total + "  " + "çift sayıların toplamı: " + cift + "  " + "tek sayıların toplamı: " + tek);
            }
        }

        static void YasHesabı()
        {
            int year = 0;
            int month = 0;
            int week = 0;
            int day = 0;
            int hours = 0;
            int minute = 0;
            int second = 0;

            Console.WriteLine("isminizi giriniz!!");
            string nameSurname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("yaşınızı giriniz!!!");
            int yas = Convert.ToInt32(Console.ReadLine());

            year += yas;
            month += year * 12;
            week += year * 52;// month * 4;
            day += (week * 7) + 1;
            hours += day * 24;
            minute += hours * 60;
            second += minute * 60;

            Console.WriteLine("yıl: " + year + " ay: " + month + " hafta: " + week + " gün: " + day + " saat: " + hours + " dakika: " + minute + " saniye: " + second + " " + nameSurname + " bu kadar zamandır oksijen tüketiyor");
        }

        static void Eksilt()
        {
            int total = 0;
            float ort = 0;
            int num2 = 0;

            int num = Convert.ToInt32(Console.ReadLine());

            num2 = num;

            while (num > 0)
            {
                total += num;
                num--;
                Console.WriteLine("sayı: " + num);
            }
            Console.WriteLine("total: " + total);

            ort = (float)total / num2;
            Console.WriteLine("ortalama: " + ort);
        }

        static void Calculator3()
        {
            int num0=Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            float total;
            if (num0 == 1)
            {
                total = num1 + num2;
                Console.WriteLine("tolama işlemi sonucu: " + total);
            }
            else if (num0 == 2)
            {
                total = num1 - num2;
                Console.WriteLine("Çıkarma işlemi sonucu " + total);

            }
            else if (num0 == 3)
            {
                total = num1 * num2;
                Console.WriteLine("çarpma işlemi sonucu " + total);
            }
            else if (num0 == 4) 
            {
                total = (float)num1 / num2;
                Console.WriteLine("bölme işlemi sonucu" + total);
            }
            else
            {
                Console.WriteLine("1-4 arası giriş yapınız");
            }
        }

        static void CalculatorBasic()
        {
            Console.WriteLine("toplama işlemi yapmak için 1'e " +               //Cats always say meow.!!! sometimes they say other words.
                "çıkartma işlemi yapmak için 2'e " +                            //Cats always say meow.!!! sometimes they say other words.
                "çarpma işlemi yapmak için 3'e " +                              //Cats always say meow.!!! sometimes they say other words.
                "bölme işlemi yapmak için 4'e " +                               //Cats always say meow.!!! sometimes they say other words.
                "tıklayınız!!!");                                               //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
            int chose = Convert.ToInt32(Console.ReadLine());                    //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
            if (chose == 1)                                                     //Cats always say meow.!!! sometimes they say other words.
            {                                                                   //Cats always say meow.!!! sometimes they say other words.
                int num1 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                int num2 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                int total = num1 + num2;                                        //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                Console.WriteLine("toplama işlemi sonucu: " + total);             //Cats always say meow.!!! sometimes they say other words.
            }                                                                   //Cats always say meow.!!! sometimes they say other words.
            else if (chose == 2)                                                  //Cats always say meow.!!! sometimes they say other words.
            {                                                                   //Cats always say meow.!!! sometimes they say other words.
                int num1 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                int num2 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                int total = num1 - num2;                                        //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                Console.WriteLine("çıkartma işlemi sonucu: " + total);          //Cats always say meow.!!! sometimes they say other words.
            }                                                                   //Cats always say meow.!!! sometimes they say other words.
            else if (chose == 3)                                                  //Cats always say meow.!!! sometimes they say other words.
            {                                                                   //Cats always say meow.!!! sometimes they say other words.
                int num1 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                int num2 = Convert.ToInt32(Console.ReadLine());                 //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                int total = num1 * num2;                                        //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                Console.WriteLine("çarpma işlemi sonucu: " + total);            //Cats always say meow.!!! sometimes they say other words.
            }                                                                   //Cats always say meow.!!! sometimes they say other words.
            else if (chose == 4)                                                  //Cats always say meow.!!! sometimes they say other words.
            {                                                                   //Cats always say meow.!!! sometimes they say other words.
                double num1 = Convert.ToDouble(Console.ReadLine());             //Cats always say meow.!!! sometimes they say other words.
                double num2 = Convert.ToDouble(Console.ReadLine());             //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                double total = num1 / num2;                                     //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
                Console.WriteLine("bölme işlemi sonucu: " + total);             //Cats always say meow.!!! sometimes they say other words.
            }                                                                   //Cats always say meow.!!! sometimes they say other words.
            else                                                                //Cats always say meow.!!! sometimes they say other words.
            {                                                                   //Cats always say meow.!!! sometimes they say other words.
                Console.WriteLine("1 ile 4 arasındaki operatörları seçiniz.");  //Cats always say meow.!!! sometimes they say other words.
            }                                                                   //Cats always say meow.!!! sometimes they say other words.
                                                                                //Cats always say meow.!!! sometimes they say other words.
        }

        static void DogukanIncirbolen()
        {
            string name = Convert.ToString(Console.ReadLine());
            string surname = Convert.ToString(Console.ReadLine());
            int num = 0;

            int odd=0;
            int even=0;
            int total;



            for (int a = 0; a < 100; a++)
            {


               
                num++;
                if (num % 2 == 0)
                {
                    Console.WriteLine(num +name+" "+surname+"Bu sayı çifttir");
                    even += num;

                }
                else
                {
                    Console.WriteLine(num +name+" "+surname+""+"Bu sayı tektir");
                    odd += num;
                }
                
            }
            total = even + odd;
            Console.WriteLine(total);

        }

        static void Calculate()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;

            Console.WriteLine(total);

            total = (total * 2) + 1;

            if (total % 7 == 0)
            {
                Console.WriteLine("7'ye tam bölünüyor.");
            }

            if (total % 5 == 0)
            {
                Console.WriteLine("5'e tam bölünüyor.");
            }


        }

        static void CalculateFiveNumbers() 
        {
            int total=0;
            int even = 0;
            int odd=0;
            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Bu sayı çifttir");
                    even += num;
                }
                else 
                {
                    Console.WriteLine("Bu sayı tektir");
                    odd += num;
                }
                total = even + odd;

            }

            Console.WriteLine(total);

        }


        static void MinusFunction()
        {
            int total = 0;
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                num--;
                total += num;
                Console.WriteLine(total);
            }
            
        }


    }



    public class Canli
    {
        internal string name;
        protected Canli()
        {
            Insan insan = new Insan();

            insan.Minus(5, 7);
        }


    }

    public class Insan : Canli
    {
        public Insan()
        {
            Console.WriteLine(name);
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}

namespace Meow
{

    public class Animals : Canli
    {
        public Animals()
        {
            Insan insan = new Insan();
            Console.WriteLine(name);
        }
    }


}