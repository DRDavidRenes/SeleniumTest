using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AppSelenium
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.Sleep(2000);
            Iniciar();
        }

        private void Iniciar() 
        {
            IWebDriver driver = new FirefoxDriver();    //crea un objeto para manejar el navegador
                                                        //ITakesScreenshot screenshot = new FirefoxDriver();



            //localizadores
            By Input = By.Id("welcome-page-search-form-autocomplete-input");     //input de busqueda
            By BtnSearch = By.Id("home-search-submit");     //botón buscar     
            By FirstLink = By.XPath("//*[@id=\"main\"]/div/div/div[2]/ul/li[1]/h2/a");   //primera busqueda de la nueva ventana
            By PlayVideo = By.XPath("/html/body/div[2]/div/section/div/div/main/div[3]/div[1]/div/div/div/div/div[4]/div");
            By FullScreen = By.XPath("/html/body/div[2]/div/section/div/div/main/div[3]/div[1]/div/div/div/div/div[4]/div");

            driver.Manage().Window.Maximize();      //abrimos una ventana en el navegador y la maximizamos
            driver.Navigate().GoToUrl("https://learn.microsoft.com/es-es/");
            Thread.Sleep(2000);     //espera 


            driver.FindElement(Input).SendKeys(".Net");  //seleccionamos el input donde se escribe lo que vas a buscar y escribimos lo que vayamos a buscar en el input
            Thread.Sleep(2000);


            driver.FindElement(BtnSearch).Click();      //pulsamos el botón
            Thread.Sleep(2000);


            driver.FindElement(FirstLink).Click();      //abrimos el primer resultado de la búsqueda
            Thread.Sleep(2000);

            driver.FindElement(PlayVideo).Click();
            Thread.Sleep(2000);

           

        }


    }
}

