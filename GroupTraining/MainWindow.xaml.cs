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

namespace GroupTraining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User[] users = new User[]
        {
            new User("Petr", "Russia", 20),
            new User("Petr1", "America", 21),
            new User("Petr2", "Russia", 21),
            new User("Petr3", "America", 20),
            new User("Petr4", "Russia", 20),
            new User("Petr5", "Russia", 25),
            new User("Petr6", "Brazil", 25),
            new User("Petr7", "Brazil", 20)
        };

        public MainWindow()
        {
            InitializeComponent();

            ListViewDataUsers.ItemsSource = users;
            ComboBoxGroup.ItemsSource = new string[] { "None", "Country", "Age" };
        }

        public void GroupList()
        {
            ListViewDataUsers.Items.GroupDescriptions.Clear();
            var property = ComboBoxGroup.SelectedItem as string;

            if (property == "None")
            {
                return;
            }

            ListViewDataUsers.Items.GroupDescriptions.Add(new PropertyGroupDescription(property));
        }

        private void ComboBoxGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GroupList();
        }
    }
}
