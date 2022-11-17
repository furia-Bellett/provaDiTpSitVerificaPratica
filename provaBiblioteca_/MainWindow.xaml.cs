using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace provaBiblioteca_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object Editore { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        

            //commento di prova per consegna finale compito


        private void creaLibro_Click(object sender, RoutedEventArgs e)
        {

            Biblioteca biblioteca = new();
            Libro libro = new(Autore, Titolo AnnoDiPubblicazione, Editore, NumeroDiPagine);

            libro.Autore = autoretxt.Text;
            libro.Titolo = titolotxt.Text;
            libro.AnnoDiPubblicazione = annPubtxt.Text;
            libro.Editore = editoretxt.Text;
            libro.NumeroDiPagine = Convert.ToDouble(numpagtxt.Text);


            string infoLibro = libro.toString();
            infoLibtxt.Text = infoLibro;


            double tempDiLettur = libro.readingTime();
            if (tempDiLettur == 1 )
            {
                templettxt.Text = "1h di lettura per il libro ";
            } else if(tempDiLettur == 2)
            {
                templettxt.Text = "2h di lettura per il libro";
            } else
            {
                templettxt.Text = "Tempo di lettura superiore a 2h";           
            }          
            
            biblioteca.BibliotecaList.Add()

        
        
        
        
        }

        private void creaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new();
            Libro libro = new();

            biblioteca.Nome = nomeBibliotecatxt.Text;
            biblioteca.Indirizzo = indirizzoBibliotecatxt.Text;
            
        
        
        
        
        
        
        }
    }
}
