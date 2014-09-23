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
        private Vehicle underConstruction_Vehicle;
        //detect which type is selected
        bool selCar;
        bool selbike;
        bool selboat;
        string name;
        float speed;
        string manufacturer;
        bool isMotorized;
        int gears;
        string color;

        public MainWindow()
        {
            InitializeComponent();
            NameBox.Visibility = Visibility.Collapsed;
            SpeedBox.Visibility = Visibility.Collapsed;
            ManufacturerBox.Visibility = Visibility.Collapsed;
            MotorizedLabel.Visibility = Visibility.Collapsed;
            MotorizedCheck.Visibility = Visibility.Collapsed;
            GearsSlider.Visibility = Visibility.Collapsed;
            ColourBox.Visibility = Visibility.Collapsed;            
        }

        

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            name = NameBox.Text;
            try
            {
                speed = float.Parse(SpeedBox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert a number.");
            }

            if (selbike)
            {

                gears = (int)GearsSlider.Value;
                color = ColourBox.Text;
                underConstruction_Vehicle = new Bicycle(name, speed, gears, color);
            }
            else if (selCar)
            {
                manufacturer = ManufacturerBox.Text;
                underConstruction_Vehicle = new Car(name, speed, manufacturer);
            }
            else if (selboat)
            {

                if (MotorizedCheck.IsChecked != true)
                    isMotorized = false;
                else
                    isMotorized = true;
                underConstruction_Vehicle = new Boat(name, speed, isMotorized);
            }           
            vehicleList.Add(underConstruction_Vehicle);
            if(underConstruction_Vehicle is Car)
            {
                MessageBox.Show("Car successfully added");
            }
            else if (underConstruction_Vehicle is Bicycle)
            {
                MessageBox.Show("Bicycle successfully added");
            }
            else if (underConstruction_Vehicle is Boat)
            {
                MessageBox.Show("Boat successfully added");
            }
            else
            MessageBox.Show("unknown vehicle successfully added");
                
        }

       


        private void CarButton_Checked(object sender, RoutedEventArgs e)
        {
            NameBox.Visibility = Visibility.Visible;
            SpeedBox.Visibility = Visibility.Visible;
            ManufacturerBox.Visibility = Visibility.Visible;
            MotorizedLabel.Visibility = Visibility.Collapsed;
            MotorizedCheck.Visibility = Visibility.Collapsed;
            GearsSlider.Visibility = Visibility.Collapsed;
            ColourBox.Visibility = Visibility.Collapsed;
            selCar = true;
            selboat = false;
            selbike = false;
        }

        private void BoatButton_Checked(object sender, RoutedEventArgs e)
        {
            NameBox.Visibility = Visibility.Visible;
            SpeedBox.Visibility = Visibility.Visible;
            ManufacturerBox.Visibility = Visibility.Collapsed;
            MotorizedLabel.Visibility = Visibility.Visible;
            MotorizedCheck.Visibility = Visibility.Visible;
            GearsSlider.Visibility = Visibility.Collapsed;
            ColourBox.Visibility = Visibility.Collapsed;
            selCar = false;
            selboat = true;
            selbike = false;
        }

        private void BicycleButton_Checked(object sender, RoutedEventArgs e)
        {
            NameBox.Visibility = Visibility.Visible;
            SpeedBox.Visibility = Visibility.Visible;
            ManufacturerBox.Visibility = Visibility.Collapsed;
            MotorizedLabel.Visibility = Visibility.Collapsed;
            MotorizedCheck.Visibility = Visibility.Collapsed;
            GearsSlider.Visibility = Visibility.Visible;
            ColourBox.Visibility = Visibility.Visible;
            selCar = false;
            selboat = false;
            selbike = true;
        }

        private void Race_Click(object sender, RoutedEventArgs e)
        {
            foreach (Vehicle vehicle in vehicleList)
            {
                MessageBox.Show(vehicle.Start());
            }
        }

       
    }
}
