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

namespace MasterDetails_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EventsTrackingDataSet eventsTracking;

        EventsTrackingDataSetTableAdapters.tbl_locationTableAdapter location =
            new EventsTrackingDataSetTableAdapters.tbl_locationTableAdapter();
        EventsTrackingDataSetTableAdapters.tbl_eventTableAdapter events=
        new EventsTrackingDataSetTableAdapters.tbl_eventTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            eventsTracking = new EventsTrackingDataSet();
            location.Fill(eventsTracking.tbl_location);
            events.Fill(eventsTracking.tbl_event);
            this.DataContext = eventsTracking.tbl_location;




        }
    }
}
