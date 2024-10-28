using createPlanet.cs;
bool f2 = false;
string name;
double area;
bool f = false;
    Console.WriteLine("1.Country menu\r\n2.Planet menu\r\n0.Cixis");
Console.WriteLine("secim edin");
string operation = Console.ReadLine();
do
{
    switch (operation)
    {
        case "0":
            f = true;
            break;
        case "1":
            Console.Clear();
           
            Console.WriteLine("COUNTRY MENYU ACILIR");
            do
            {
                Console.WriteLine("1.planet yarat\r\n2.Butun Planetleri gor\r\n3.Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");
                string operation2 = Console.ReadLine();
                object AppDbContext = null;
                switch (operation2)
                {
                    case "0":
                        f2 = true;
                        break;
                    case "1":
                        Planet planet = new Planet();
                        Console.WriteLine("teze quracagimiz planete ad verin");
                        name = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("ne qede erazi isgal olunsun?");
                            f2 = double.TryParse(Console.ReadLine(), out area);

                        } while (!f2);
                    
                        break;
                    case "2":
                        List<Planet> planets = AppDbContext.getAll
                        foreach (var item in planets)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }


            } while (!f);
            break;






        default:
            break;





    }



} while (!f);
