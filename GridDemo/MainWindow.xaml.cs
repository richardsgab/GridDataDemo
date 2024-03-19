using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       /* List<Person> personlist = new List<Person>();*/
       ObservableCollection<Person> personlist = new ObservableCollection<Person>();//In plaats van List
        List<Land> landlist = new List<Land>();
        public MainWindow()
        {
            InitializeComponent();
            BindLanden();
            BindGrid();
        }

        private void BindGrid()
        {
            personlist.Add(new Person("Rik", 28, "Man", "Duitsland"));
            personlist.Add(new Person("Zak", 20, "Man", "Spanje"));
            personlist.Add(new Person("Evelien", 21, "Vrouw", "Frankrijk"));
            personlist.Add(new Person("Salvatore", 29, "Man", "Belgie"));
            personlist.Add(new Person("Gabriela", 30, "Vrouw", "Duitsland"));
            personlist.Add(new Person("Hugo", 22, "Man", "Frankrijk"));
            personlist.Add(new Person("Olesia", 24, "Vrouw", "Spanje"));
            personlist.Add(new Person("Santiago", 32, "Man", "Belgie"));
            personlist.Add(new Person("Dritan", 33, "Man", "Frankrijk"));

            dataGrid.ItemsSource = personlist;
        }
        private void BindLanden()
        {
            landlist.Add(new Land("Belgie"));
            landlist.Add(new Land("Duitsland"));
            landlist.Add(new Land("Frankrijk"));
            landlist.Add(new Land("Spanje"));

            cmbLand.ItemsSource = landlist;
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text;
            int leefftijd = int.Parse(txtLeeftijd.Text);
            string geslacht = txtGeslacht.Text;
           
            string? land = cmbLand.SelectedValue.ToString(); //Eliminar prop Id from Land

            Person person = new(naam, leefftijd, geslacht, land);
            personlist.Add(person);
           /* dataGrid.Items.Refresh();*///Shows the new added op the list, but with ObservableCollection, it's not useful.
        }

        public void Search(string searchFor)
        {            
            var result = personlist.Where(p => p.Land.Equals(searchFor)).ToList();//lambda expression
            dataGrid.ItemsSource = result;
        }

        private void cmbLand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search(cmbLand.SelectedValue.ToString());
        }
    }
}