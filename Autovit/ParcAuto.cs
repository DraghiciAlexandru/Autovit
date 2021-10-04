using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovit
{
    class ParcAuto
    {
        ArrayList Masini = new ArrayList();

        public ParcAuto()
        {
            openFile();
        }
       
        public void openFile()
        {
            try
            {
                String path = Application.StartupPath;
                StreamReader read = new StreamReader(path + @"/ddb/Masini.txt");
                String linie = "";
                while ((linie = read.ReadLine()) != null)
                {
                    Masina x = new Masina();
                    String[] aux = linie.Split(',');
                    x.Marca = aux[0];
                    x.Model = aux[1];
                    x.An = int.Parse(aux[2]);
                    x.Km = long.Parse(aux[3]);
                    x.Combustibil = aux[4];
                    x.Pret = long.Parse(aux[5]);
                    x.Localitate = aux[6];
                    x.DateProprietar = aux[7];
                    Masini.Add(x);
                }
                read.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error");
            }
        }

        public void saveFile()
        {
            String path = Application.StartupPath;
            StreamWriter write = new StreamWriter(path + @"/ddb/Masini.txt");
            foreach (Masina x in Masini)
            {
                write.Write(x.Marca + ",");
                write.Write(x.Model + ",");
                write.Write(x.An + ",");
                write.Write(x.Km + ",");
                write.Write(x.Combustibil + ",");
                write.Write(x.Pret + ",");
                write.Write(x.Localitate + ",");
                write.Write(x.DateProprietar + Environment.NewLine);
            }
            write.Close();
        }

        public bool isMasina(Masina m)
        {
            foreach(Masina x in Masini)
                if (x == m)
                    return true;
            MessageBox.Show("Masina nu exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void delete(Masina m)
        {
            if(isMasina(m))
                for (int i = 0; i < Masini.Count; i++)
                    if (Masini[i] == m)
                        Masini.RemoveAt(i);
        }

        public void add(Masina m)
        {
            Masini.Add(m);
        }

        public void uploadView(ListView view)
        {
            view.Clear();
            view.Columns.Add("Marca", 70, HorizontalAlignment.Left);
            view.Columns.Add("Model", 70, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 70, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                ListViewItem x = new ListViewItem();
                x.Text = y.Marca;
                x.SubItems.Add(y.Model);
                x.SubItems.Add(y.An.ToString());
                x.SubItems.Add(y.Km.ToString());
                x.SubItems.Add(y.Combustibil);
                x.SubItems.Add(y.Pret.ToString() + " euro");
                x.SubItems.Add(y.Localitate);
                x.SubItems.Add(y.DateProprietar);
                view.Items.Add(x);
            }
        }

        public bool isValid(TextBox textBox)
        {
            Regex x = new Regex(@"^[A-z]{3}[A-z]*\s?\w*$");
            if (x.IsMatch(textBox.Text))
                return true;
            return false;
        }

        public bool isMarca(String marca)
        {
            foreach (Masina x in Masini)
                if (x.Marca == marca)
                    return true;
            return false;
        }

        public void marcaView(ListView view, String marca)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.Marca == marca)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public bool isModel(String model)
        {
            foreach (Masina x in Masini)
                if (x.Model == model)
                    return true;
            return false;
        }

        public void modelView(ListView view, String model)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.Model == model)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public bool isAn(String box)
        {
            Regex x = new Regex(@"^[12][90][2109]\d$");
            if (x.IsMatch(box))
                if (int.Parse(box) >= 1990 && int.Parse(box) < 2021)
                    return true;
            return false;
        }

        public void anView(ListView view, int primul, int ultimul)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.An >= primul && y.An <= ultimul)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public bool isKm(String text)
        {
            Regex x = new Regex(@"^\d+$");
            if (x.IsMatch(text))
                if (long.Parse(text) < 400000)
                    return true;
            return false;
        }

        public void kmView(ListView view, long mic, long mare)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.Km >= mic && y.Km <= mare)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public bool isCombustibil(String Comb)
        {
            foreach (Masina x in Masini)
                if (x.Combustibil == Comb)
                    return true;
            return false;
        }

        public void combView(ListView view, String comb)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.Combustibil == comb)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public bool isPret(String nr)
        {
            Regex x = new Regex(@"^\d+$");
            if (x.IsMatch(nr))
                if (long.Parse(nr) <= 800000)
                    return true;
            return false;
        }

        public void pretView(ListView view, long mic, long mare)
        {
            view.Clear();
            view.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            view.Columns.Add("Model", 100, HorizontalAlignment.Left);
            view.Columns.Add("Ani", 100, HorizontalAlignment.Left);
            view.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            view.Columns.Add("Combustibil", 100, HorizontalAlignment.Left);
            view.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            view.Columns.Add("Localitate", 200, HorizontalAlignment.Left);
            view.Columns.Add("Date vanzator", 150, HorizontalAlignment.Left);
            foreach (Masina y in Masini)
            {
                if (y.Pret >= mic && y.Pret <= mare)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = y.Marca;
                    x.SubItems.Add(y.Model);
                    x.SubItems.Add(y.An.ToString());
                    x.SubItems.Add(y.Km.ToString());
                    x.SubItems.Add(y.Combustibil);
                    x.SubItems.Add(y.Pret.ToString() + " euro");
                    x.SubItems.Add(y.Localitate);
                    x.SubItems.Add(y.DateProprietar);
                    view.Items.Add(x);
                }
            }
        }

        public ArrayList filtruPret(ArrayList lista , long pretMin , long pretMax)
        {
            ArrayList preturi = new ArrayList();
            foreach(Masina x in lista)
            {
                if (x.Pret >= pretMin && x.Pret <= pretMax)
                    preturi.Add(x);
            }
            return preturi;
        }

        public ArrayList filtruKm(ArrayList lista, long kmMin, long kmMax)
        {
            ArrayList kilometri = new ArrayList();
            foreach (Masina x in lista)
                if (x.Km >= kmMin && x.Km <= kmMax)
                    kilometri.Add(x);
            return kilometri;
        }

        public ArrayList filtruAni(ArrayList lista, int primAn, int ultimAn)
        {
            ArrayList ani = new ArrayList();
            foreach (Masina x in lista)
                if (x.An >= primAn && x.An <= ultimAn)
                    ani.Add(x);
            return ani;
        }

    }
}
