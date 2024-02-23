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
using Image = System.Windows.Controls.Image;

namespace CE_UAA14WPF24_AjdiniSefedin
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tailleGrille = 1;
        int compteur = 1;
        Button[,] button = new Button[8, 8];
        ColumnDefinition[] coldef = new ColumnDefinition[8];
        RowDefinition[] rowdef = new RowDefinition[8];
        public MainWindow()
        {
            InitializeComponent();
            Valider.Click += new RoutedEventHandler(Button_Click);
            Reset.Click += new RoutedEventHandler(Reset_Click);
            TailleLigne.verif();
            TailleColonne.verif();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < tailleGrille; i++)
            {
                coldef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef[i]);
                rowdef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowdef[i]);
                if (Name == "Solitaire")
                {

                    for (i = 0; i < 9; i++)
                    {
                        for (int y = 0; y < 9; y++)
                        {
                            button[i, y] = new Button();
                            //BitmapImage imageButton = new BitmapImage();
                            //imageButton = new BitmapImage();
                            //imageButton.BeginInit();
                            switch (compteur)
                            {
                                case 3:
                                case 4:
                                case 5:
                                    button[i, y].Background = Brushes.Black;
                                    //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");
                                    break;

                                case 12:
                                case 14:
                                case 13:
                                    button[i, y].Background = Brushes.Black;
                                    //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                    break;

                                case 21:
                                case 22:
                                case 23:
                                    button[i, y].Background = Brushes.Black;
                                    //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                    break;
                            }
                            //imageButton.EndInit();
                            //Image imButton = new Image();
                            //imButton.Source = imageButton;
                            //imButton.Stretch = System.Windows.Media.Stretch.None;
                            //button[i, y].Content = imButton;

                            Grid.SetRow(button[i, y], i);
                            Grid.SetColumn(button[i, y], y);
                            grdMain.Children.Add(button[i, y]);
                            compteur++;
                        }
                    }
                }
                if (Name == "Marelle")
                {

                    for (i = 0; i < 7; i++)
                    {
                        for (int y = 0; y < 7; y++)
                        {
                            button[i, y] = new Button();
                            if (tailleGrille == 7)
                            {
                                //BitmapImage imageButton = new BitmapImage();
                                //imageButton = new BitmapImage();
                                //imageButton.BeginInit();
                                switch (compteur)
                                {
                                    case 1:
                                    case 4:
                                    case 7:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 9:
                                    case 11:
                                    case 13:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 17:
                                    case 18:
                                    case 19:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 22:
                                    case 23:
                                    case 24:
                                    case 26:
                                    case 27:
                                    case 28:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 31:
                                    case 32:
                                    case 33:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 37:
                                    case 39:
                                    case 41:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;

                                    case 43:
                                    case 46:
                                    case 49:
                                        button[i, y].Background = Brushes.Black;
                                        //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");

                                        break;
                                }
                                //imageButton.EndInit();
                                //Image imButton = new Image();
                                //imButton.Source = imageButton;
                                //imButton.Stretch = System.Windows.Media.Stretch.None;
                                //button[i, y].Content = imButton;

                            }
                            else
                            {
                                button[i, y].Background = Brushes.White;
                            }
                            Grid.SetRow(button[i, y], i);
                            Grid.SetColumn(button[i, y], y);
                            grdMain.Children.Add(button[i, y]);
                            compteur++;
                        }

                    }

                    if (Name == "Laterale")
                    {

                        for (i = 0; i < 5; i++)
                        {
                            for (int y = 0; y < 5; y++)
                            {
                                button[i, y] = new Button();
                                if (y % 2 == 0)
                                {
                                    button[i, y].Background = Brushes.White;
                                }
                                else
                                {
                                    button[i, y].Background = Brushes.Black;
                                }

                                if (i == 0 || i == 1 || i == 6 || i == 7)
                                {
                                    //BitmapImage imageButton = new BitmapImage();
                                    //imageButton = new BitmapImage();
                                    //imageButton.BeginInit();
                                    switch (compteur)
                                    {
                                        case 4:
                                        case 5:
                                        case 6:
                                            //imageButton.UriSource = new Uri("assets/petitCercleRouge.png");
                                            break;
                                    }
                                    //imageButton.EndInit();
                                    //Image imButton = new Image();
                                    //imButton.Source = imageButton;
                                    //imButton.Stretch = System.Windows.Media.Stretch.None;
                                    //button[i, y].Content = imButton;
                                }
                                Grid.SetRow(button[i, y], 2);
                                Grid.GetColumn(button[i, y]);
                                grdMain.Children.Add(button[i, y]);
                                compteur++;
                            }

                        }
                    }
                }
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            grdMain.RowDefinitions.Clear();
            grdMain.ColumnDefinitions.Clear();
        }

        private void verif(object sender, TextCompositionEventArgs e)
        {
            int entier;
            if (int.TryParse(e.Text, out entier))
            {
                MessageBox.Show("que du int accepter veuillez recommencer");
            }
        }
    }
}
