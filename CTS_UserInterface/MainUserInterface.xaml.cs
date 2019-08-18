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
using System.Windows.Shapes;

namespace CTS_UserInterface
{
    /// <summary>
    /// Interaction logic for MainUserInterface.xaml
    /// </summary>
    public partial class MainUserInterface : Window
    {
        private string _selectedUser;
        public MainUserInterface(string user)
        {
            InitializeComponent();
            this._selectedUser = user;
        }
    }
}
