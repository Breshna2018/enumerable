using Microsoft.Win32;
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

namespace enumerable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filepath;
      //  enum firstname{cold,hot,warm,freezing };

       // enum AccountTyppe { saving, checking, invvestment };
        public MainWindow()
        {
            InitializeComponent();
            nameone();

            PixelFormats.Rgba64;
            //Account.AccountTyppe.checking

           // weather givename = new weather(weather.firstname.warm);
         
            //Account bnamim=new Account(Account.AccountTyppe.checking,"will",2000);
           // Account mustafa = new Account("ccecking account", "Asma waheed", 20000);

        }
       /* public class weather
        {
           public enum firstname { cold, hot, warm, freezing }
            firstname _whatisgame;

            public weather(firstname whatisgame)
            {
                _whatisgame = whatisgame;
            }*/
       // }

        public void nameone()
        {
            combox.Items.Add("whasah");
            combox.Items.Add("jbdvjbdvjdv");
            combox.Items.Add("ndjcndjcej");
            combox.SelectedIndex = 0;
        }

        private void noname_Click(object sender, RoutedEventArgs e)
        {
            string fullname = name.Name;
            decimal baba = decimal.Parse(balance.Text);
            Abcc account = new Abcc(fullname,baba,filepath);

            listbox.Items.Add(account.ToString());

        }

        private void image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog givename=new OpenFileDialog();
            if(givename.ShowDialog()== true)
            {
                filepath = givename.FileName;

                image1.Text = filepath;
                Uri uri = new Uri(filepath);
                BitmapImage bitmapImage = new BitmapImage(uri);
               // bitmapImage.BeginInit();
                //bitmapImage.EndInit();
                imageshow.Source= bitmapImage;




            }
        }
    }
}
