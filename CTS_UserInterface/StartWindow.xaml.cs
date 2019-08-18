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

namespace CTS_UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        //private void EnableDisableBtnCurrentUser()
        //{
        //    btnSelectCurrentUser.IsEnabled = false;
        //    if (cboCurrentUser.SelectedItem != null)
        //    {
        //        btnSelectCurrentUser.IsEnabled = true;
        //    }
        //}

        private void BtnSelectCurrentUser_Click(object sender, RoutedEventArgs e)
        {
            
            if (cboCurrentUser.SelectedIndex > -1)
            {
                
                MainUserInterface mainUserInterface = new MainUserInterface(cboCurrentUser.Text);

                mainUserInterface.Show();

                this.Close();
               
            }

            MessageBox.Show("Please select a user from the dropdown menu or add a new user");
   
        }

        private void BtnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            CreateNewUser createNewUserWindow = new CreateNewUser();

            createNewUserWindow.Show();

            this.Close();

        }
    }
}
