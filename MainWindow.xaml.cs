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

namespace KALKULATOR_MATERIAŁOWY
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

        private void ButtButton_Click_Licz_Plaskownik(object sender, RoutedEventArgs e)
        {
            string messageBoxText2 = "Podaj potrzebne dane";
            string caption2 = "UWAGA!";
            MessageBoxButton button2 = MessageBoxButton.OK;
            MessageBoxImage icon2 = MessageBoxImage.Warning;
            if (plaskownik_szerokosc.Text == "" || plaskownik_dlugosc.Text == "" || plaskownik_grubosc.Text == "") MessageBox.Show(messageBoxText2, caption2, button2, icon2);
            else
            {
                string messageBoxText = "Wybierz materiał z listy";
                string caption = "UWAGA!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                double wynik = 0;
                short pomoc = 1;
                double dl = Convert.ToDouble(plaskownik_dlugosc.Text);
                double szer = Convert.ToDouble(plaskownik_szerokosc.Text);
                double gr = Convert.ToDouble(plaskownik_grubosc.Text);
                wynik = (dl * szer * gr) / 1000000;
                if (plaskownik_material.SelectedItem == Alu_7075) wynik = wynik * 2.9;
                else if (plaskownik_material.SelectedItem == Alu_6063) wynik = wynik * 2.8;
                else if (plaskownik_material.SelectedItem == Alu_6082) wynik = wynik * 2.7;
                else if (plaskownik_material.SelectedItem == Stalczarna) wynik = wynik * 7.85;
                else if (plaskownik_material.SelectedItem == Cynk) wynik = wynik * 7.2;
                else if (plaskownik_material.SelectedItem == Braz || plaskownik_material.SelectedItem == Mosiadz) wynik = wynik * 8.5;
                else if (plaskownik_material.SelectedItem == Miedz) wynik = wynik * 8.9;
                else pomoc = 0;

                if (pomoc == 1) plaskownik_wyswietlanie.Content = wynik;
                else MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        private void Button_Click_Clear_Wysw_Wynik_Plaskownik(object sender, RoutedEventArgs e)
        {
            plaskownik_wyswietlanie.Content="";
        }

        private void Button_Click_Clear_Wysw_Dane_Plaskownik(object sender, RoutedEventArgs e)
        {
            plaskownik_grubosc.Text = "";
            plaskownik_szerokosc.Text = "";
            plaskownik_dlugosc.Text = "";
        }

        private void Button_Click_Licz_Profile(object sender, RoutedEventArgs e)
        {
            string messageBoxText2 = "Podaj potrzebne dane";
            string caption2 = "UWAGA!";
            MessageBoxButton button2 = MessageBoxButton.OK;
            MessageBoxImage icon2 = MessageBoxImage.Warning;
            if (profile_szerokosc.Text == "" || profile_wysokosc.Text == "" || profile_dlugosc.Text == "" || profile_grubosc.Text == "") MessageBox.Show(messageBoxText2, caption2, button2, icon2);
            else
            {
                string messageBoxText = "Wybierz materiał z listy";
                string caption = "UWAGA!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                double wynik = 0;
                short pomoc = 1;
                double dl = Convert.ToDouble(profile_dlugosc.Text);
                double wys = Convert.ToDouble(profile_wysokosc.Text);
                double szer = Convert.ToDouble(profile_szerokosc.Text);
                double gr = Convert.ToDouble(profile_grubosc.Text);
                wynik = ((wys * szer * dl) - (((wys - 2*gr) * (szer - 2*gr)) * dl)) / 1000000;
                if (profile_material.SelectedItem == Prof_Alu_7075) wynik = wynik * 2.9;
                else if (profile_material.SelectedItem == Prof_Alu_6063) wynik = wynik * 2.8;
                else if (profile_material.SelectedItem == Prof_Alu_6082) wynik = wynik * 2.7;
                else if (profile_material.SelectedItem == Prof_Stalczarna) wynik = wynik * 7.85;
                else if (profile_material.SelectedItem == Prof_Cynk) wynik = wynik * 7.2;
                else if (profile_material.SelectedItem == Prof_Braz || profile_material.SelectedItem == Prof_Mosiadz) wynik = wynik * 8.5;
                else if (profile_material.SelectedItem == Prof_Miedz) wynik = wynik * 8.9;
                else pomoc = 0;

                if (pomoc == 1) profile_wyswietlanie.Content = wynik;
                else MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }
                
        private void Button_Click_Clear_Wysw_Dane_Profile(object sender, RoutedEventArgs e)
        {
            profile_grubosc.Text = "";
            profile_wysokosc.Text = "";
            profile_szerokosc.Text = "";
            profile_dlugosc.Text = "";            
        }

        private void Button_Click_Clear_Wysw_Wynik_Profile(object sender, RoutedEventArgs e)
        {
            profile_wyswietlanie.Content = "";
        }

        private void Button_Click_Licz_Prety(object sender, RoutedEventArgs e)
        {
            string messageBoxText2 = "Podaj potrzebne dane";
            string caption2 = "UWAGA!";
            MessageBoxButton button2 = MessageBoxButton.OK;
            MessageBoxImage icon2 = MessageBoxImage.Warning;
            string messageBoxText = "Wybierz materiał z listy";
            string caption = "UWAGA!";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;            
            if (prety_srednica.Text == "" || prety_dlugosc.Text == "") MessageBox.Show(messageBoxText2, caption2, button2, icon2);
            else
            {
                double wynik = 0;
                short pomoc = 1;
                double sr = Convert.ToDouble(prety_srednica.Text);
                double dl = Convert.ToDouble(prety_dlugosc.Text);
                wynik = (3.14 * Math.Pow((sr / 2), 2) * dl) / 1000000;
                if (prety_material.SelectedItem == Pret_Alu_7075) wynik = wynik * 2.9;
                else if (prety_material.SelectedItem == Pret_Alu_6063) wynik = wynik * 2.8;
                else if (prety_material.SelectedItem == Pret_Alu_6082) wynik = wynik * 2.7;
                else if (prety_material.SelectedItem == Pret_Stalczarna) wynik = wynik * 7.85;
                else if (prety_material.SelectedItem == Pret_Cynk) wynik = wynik * 7.2;
                else if (prety_material.SelectedItem == Pret_Braz || prety_material.SelectedItem == Pret_Mosiadz) wynik = wynik * 8.5;
                else if (prety_material.SelectedItem == Pret_Miedz) wynik = wynik * 8.9;
                else pomoc = 0;

                if (pomoc == 1) prety_wyswietlanie.Content = wynik;
                else MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        private void Button_Click_Clear_Wysw_Dane_Prety(object sender, RoutedEventArgs e)
        {
            prety_srednica.Text = "";
            prety_dlugosc.Text = "";
        }

        private void Button_Click_Clear_Wysw_Wynik_Prety(object sender, RoutedEventArgs e)
        {
            prety_wyswietlanie.Content = "";
        }

        private void Button_Click_Licz_Rury(object sender, RoutedEventArgs e)
        {
                string messageBoxText2 = "Podaj potrzebne dane";
                string caption2 = "UWAGA!";
                MessageBoxButton button2 = MessageBoxButton.OK;
                MessageBoxImage icon2 = MessageBoxImage.Warning;
                string messageBoxText = "Wybierz materiał z listy";
                string caption = "UWAGA!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
            if (rury_srednica_zew.Text == "" || rury_srednica_zew.Text == "" || rury_dlugosc.Text == "") MessageBox.Show(messageBoxText2, caption2, button2, icon2);
            else
            {
                double wynik = 0;
                short pomoc = 1;
                double gr = Convert.ToDouble(rury_gr.Text);
                double sr_zew = Convert.ToDouble(rury_srednica_zew.Text);
                double dl = Convert.ToDouble(rury_dlugosc.Text);
                double sr_wew = sr_zew - (gr * 2);
                wynik = (3.14 * dl * (sr_zew - sr_wew)) / 1000000;
                if (rury_material.SelectedItem == Rur_Alu_7075) wynik = wynik * 2.9;
                else if (rury_material.SelectedItem == Rur_Alu_6063) wynik = wynik * 2.8;
                else if (rury_material.SelectedItem == Rur_Alu_6082) wynik = wynik * 2.7;
                else if (rury_material.SelectedItem == Rur_Stalczarna) wynik = wynik * 7.85;
                else if (rury_material.SelectedItem == Rur_Cynk) wynik = wynik * 7.2;
                else if (rury_material.SelectedItem == Rur_Braz || rury_material.SelectedItem == Rur_Mosiadz) wynik = wynik * 8.5;
                else if (rury_material.SelectedItem == Rur_Miedz) wynik = wynik * 8.9;
                else pomoc = 0;

                if (pomoc == 1) rury_wyswietlanie.Content = wynik;
                else MessageBox.Show(messageBoxText, caption, button, icon);
            }
        }

        private void Button_Click_Clear_Wysw_Dane_Rury(object sender, RoutedEventArgs e)
        {
            rury_gr.Text = "";
            rury_srednica_zew.Text = "";
            rury_dlugosc.Text = "";          
        }

        private void Button_Click_Clear_Wysw_Wynik_Rury(object sender, RoutedEventArgs e)
        {
            rury_wyswietlanie.Content = "";
        }
    }
}
