//1. feladat: Készítsen konzolos alkalmazást a következő feladatok megoldására, amelynek projektjét karacsonyCLI néven mentse el! 
namespace karacsonyCLI
{
    internal class Program
    {
        /*2. feladat: Forráskódjába tegye elérhetővé a java.txt vagy a csharp.txt állományból a
            NapiMunka osztályt definiáló kódrészletet! A beillesztett osztály tetszés szerint bővíthető
            további tagokkal, melyek a feladatok megoldása során felhasználhatók! Az osztály
            NapiBevetel() metódusa felhasználható arra, hogy megállapítsa az aktuális nap
            bevételét. Ezt a metódust a későbbiekben kell felhasználnia.*/
        class NapiMunka
        {
            public static int KeszultDb { get; private set; }
            public int Nap { get; private set; }
            public int HarangKesz { get; private set; }
            public int HarangEladott { get; private set; }
            public int AngyalkaKesz { get; private set; }
            public int AngyalkaEladott { get; private set; }
            public int FenyofaKesz { get; private set; }
            public int FenyofaEladott { get; private set; }

            public NapiMunka(string sor)
            {
                string[] s = sor.Split(';');
                Nap = Convert.ToInt32(s[0]);
                HarangKesz = Convert.ToInt32(s[1]);
                HarangEladott = Convert.ToInt32(s[2]);
                AngyalkaKesz = Convert.ToInt32(s[3]);
                AngyalkaEladott = Convert.ToInt32(s[4]);
                FenyofaKesz = Convert.ToInt32(s[5]);
                FenyofaEladott = Convert.ToInt32(s[6]);

                NapiMunka.KeszultDb += HarangKesz + AngyalkaKesz + FenyofaKesz;
            }

            public int NapiBevetel()
            {
                return -(HarangEladott * 1000 + AngyalkaEladott * 1350 + FenyofaEladott * 1500);
            }
        }
        static List<NapiMunka> crmsList = new();
        static void Main(string[] args)
        {
            /*3. feladat: Olvassa be a diszek.txt állományban lévő adatokat, és tárolja el egy olyan
                adatszerkezetben, ami a további feladatok megoldására alkalmas!*/
            StreamReader sr = new("diszek.txt");
            while (!sr.EndOfStream)
            {
                NapiMunka data = new NapiMunka(sr.ReadLine());
                crmsList.Add(data);
            }
            sr.Close();

            /*4. feladat: Határozza meg és írja ki a képernyőre a minta szerint, hogy összesen hány karácsonyi díszt
                készített a hölgy!*/
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.\n");

            /*5. feladat: Állapítsa meg, hogy volt-e olyan nap, amikor a hölgy egyetlen díszt sem készített!
                A keresést ne folytassa, ha választ meg tudja adni! A megállapítását írja a képernyőre!*/
            bool ans = false;
            for (int i = 0; i < crmsList.Count; i++)
            {
                if (crmsList[i].HarangEladott == 0 && crmsList[i].AngyalkaEladott == 0 && crmsList[i].FenyofaEladott == 0)
                {
                    ans = true;
                    break;
                }
            }
            if (ans)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.\n");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor ne készült volna dísz.\n");
            }

            /*6. feladat: Kérjen be a felhasználótól egy 1 és 40 közé eső számot (a határokat is beleértve)! Ismételje
                addig a nap számának bekérését, míg érvényes értéket nem ad meg a felhasználó! Ha nem
                tudta megoldani az adatbevitelt, akkor a feladat további részében dolgozzon a 15-ös
                számmal! Határozza meg, és írja a képernyőre, hogy az adott nap végén melyik díszből
                hány maradt készleten!*/
            int userInput;
            do
            {
                Console.Write("6.feladat:\n Adja meg a kereset napot [1 ... 40]:");
                userInput = int.Parse(Console.ReadLine());
            } while (userInput < 1 || userInput > 40);

            int angelsLeft = 0;
            int bellsLeft = 0;
            int pineLeft = 0;
            for (int i = 0; i < userInput; i++)
            {
                angelsLeft += crmsList[i].AngyalkaKesz + crmsList[i].AngyalkaEladott;
                bellsLeft += crmsList[i].HarangKesz + crmsList[i].HarangEladott;
                pineLeft += crmsList[i].FenyofaKesz + crmsList[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {userInput}. nap végén {bellsLeft}, {angelsLeft} angyalka és {pineLeft} fenyőfa maradt készleten.\n");

            /*7. feladat: Határozza meg, és írja a képernyőre, hogy a 40 nap alatt melyik díszből sikerült eladni
                a legtöbbet! Az eladott mennyiséget is jelenítse meg! Ha több díszből is egyformán
                a legtöbb lett eladva, akkor mindegyiket jelenítse meg!*/
            int angelsSum = 0;
            int bellsSum = 0;
            int pineSum = 0;
            for (int i = 0; i < crmsList.Count; i++)
            {
                angelsSum -= crmsList[i].AngyalkaEladott;
                bellsSum -= crmsList[i].HarangEladott;
                pineSum -= crmsList[i].FenyofaEladott;
            }

            int max = Math.Max(angelsSum, Math.Max(bellsSum, pineSum));
            Console.WriteLine($"7.feladat: A legtöbbet eladott dísz: {max} darab");
            List<string> mostSold = new();
            if (max == angelsSum)
            {
                mostSold.Add("Angyalka");
            }
            if (max == bellsSum)
            {
                mostSold.Add("Csengő");
            }
            if (max == pineSum)
            {
                mostSold.Add("Fenyő");
            }
            for (int i = 0; i < mostSold.Count; i++)
            {
                Console.WriteLine("\t" + mostSold[i]);
            }

            /*8. feladat: A NapiMunka osztály NapiBevetel() metódusának felhasználásával válogassa ki és írja
                ki a bevetel.txt fájlba azokat a napi bevételeket, melyek elérték a 10 000 forintot!
                Minden sorban jelenjen meg a nap száma és az aznapi bevétel egymástól kettősponttal
                elválasztva. A fájl utolsó sorában jelenítse meg, hogy hány olyan nap volt, amikor a bevétel
                elérte a 10 000 forintot! „X napon volt legalább 10000 Ft a bevétel.”*/
            int day = 0;
            StreamWriter sw = new("bevetel.txt");
            for (int i = 0; i < crmsList.Count; i++)
            {
                if (crmsList[i].NapiBevetel() >= 10000)
                {
                    sw.WriteLine(crmsList[i].Nap + ":" + crmsList[i].NapiBevetel());
                    day++;
                }
            }
            sw.WriteLine($"{day} napon volt legalább 10000 Ft a bevétel.");
            sw.Close();

            Console.ReadKey();
        }
    }
}