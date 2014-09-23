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
using inher.Classes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] vehicleTypes = new string[] { "Car", "Boat", "Bicycle" };
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private Vehicle underConstruction_Vehicle = new Vehicle();
        public MainWindow()
        {
            InitializeComponent();
            ComboBox.ItemsSource = vehicleTypes;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (e.AddedItems[0] as ComboBoxItem).Content as string;
            switch (text)
            {
                case "Car":
                {
                    
                   
                    break;
                }
                case "Boat":
                {
                    break;
                }
                case "Bicycle":
                {
                    break;
                }
            }

           
        }

        /*
                     * <TextBox x:Name="NameBox"  HorizontalAlignment="Left" 
                     * Grid.Column="1" Grid.Row="0" Height="23" Width="120" Margin="5,5,0,0" 
                     * TextWrapping="Wrap" Text="{Binding Name, FallbackValue='Name'}" VerticalAlignment="Top" />
                     */

        private void AddTextBox(string Name)
        {
            this.VehicleDefinitionGrid.RowDefinitions.Add(new RowDefinition());
            TextBox DynamicTextBox = new TextBox();
            DynamicTextBox.Name = Name;
            DynamicTextBox.Height = 23;
            DynamicTextBox.Width = 120;
            ///TODO: correctMargin
            //DynamicTextBox.Margin = Margin(5,5,0,0);
            DynamicTextBox.TextWrapping = TextWrapping.Wrap;

            Binding dynamicTextBoxbinding = new Binding();
            dynamicTextBoxbinding.Mode = BindingMode.TwoWay;
            dynamicTextBoxbinding.FallbackValue = Name;

            dynamicTextBoxbinding

        }

        

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            vehicleList.Add(underConstruction_Vehicle);
        }

       
    }
}
