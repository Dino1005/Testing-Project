# TestingProject
 
 Ovaj projekt predstavlja okvir za automatsko testiranje web stranice Instar-Informatika.
 U projektu postoje tri klase za tri različite vrste testiranja: HomeTests(testiranje pretraživanja i odabiranja proizvoda), LoginTests(testiranje uspješnosti ili neuspješnosti logiranja na postojeći profil), te RegisterTests(testiranja uspješnosti ili neuspješnosti kreiranja novog profila).
 
 Za korištenje ovog okvira potrebno je kreirati novi NUnit C# projekt i dodati sve datoteke, te također instalirati potrebne NuGet Package: Selenium Webdriver, Selenium Support, PageObjects.Core, WebDriverManager i NewtonSoft Json.
 
 Selenium Webdriver i Support, te WebDriverManager korišteni su za automatsko testiranje kroz odabrani preglednik (preglednik se bira tako da se u config.json datoteku upiše chrome, firefox ili ie na odgovarajuće mjesto). PageObjects.Core korišten je za automatsko dohvaćanje potrebnih web elemenata pri pozivu konstruktora pojedine stranice. NewtonSoft Json korišten je za čitanje podataka iz json datoteka.
 
 Kako bi se testovi pokrenuli sa željenim parametrima potrebno je samo u testnim klasama izmijeniti odgovarajuće stringove.
 
 Izradio: Dino Radonjić
