using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovit
{
    class Masina
    {
        enum MARCA
        {
            alfa_romeo,
            aro,
            aston_martin,
            audi,
            bentley,
            bmw,
            bugatti,
            chevrolet,
            dacia,
            dodge,
            ferrari,
            fiat,
            ford,
            honda,
            hyundai,
            jaguar,
            jeep,
            kia,
            lamborghini,
            land_rover,
            lexus,
            maserati,
            mazda,
            mercedes_benz,
            mitsubishi,
            mini,
            nissan,
            opel,
            peugeot,
            porsche,
            range_rover,
            renault,
            rolls_royce,
            rover,
            skoda,
            smart,
            suzuki,
            tesla,
            toyota,
            volkswagen,
volvo,
            UNDEFINED,
        }
        enum COMBUSTIBIL
        {
            diesel,
            benzina,
            electric,
            hibrid,
            NOTDEFINED,
        }

        private MARCA marca = MARCA.UNDEFINED;
        private String model = "";
        private int an = 0;
        private long km = 0;
        private COMBUSTIBIL combustibil = COMBUSTIBIL.NOTDEFINED;
        private long pret = 0;
        private String localitate = "";
        private String dateProprietar = "";
        //private String 

        public String Marca
        {
            get { return marca.ToString().Replace('_', ' '); }
            set
            {
                if (Enum.IsDefined(typeof(MARCA), value.ToLower()))
                    marca = (MARCA)Enum.Parse(typeof(MARCA), value.ToLower());
                else
                {
                    MessageBox.Show("Marca nu exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    marca.Equals(MARCA.UNDEFINED);
                }
            }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public int An
        {
            get { return an; }
            set { an = value; }
        }

        public long Km
        {
            get { return km; }
            set { km = value; }
        }

        public String Combustibil
        {
            get { return combustibil.ToString().Replace('_', ' '); }
            set
            {
                if (Enum.IsDefined(typeof(COMBUSTIBIL), value.ToLower()))
                    combustibil = (COMBUSTIBIL)Enum.Parse(typeof(COMBUSTIBIL), value.ToLower());
                else
                {
                    MessageBox.Show("Combustibilul nu exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    combustibil.Equals(COMBUSTIBIL.NOTDEFINED);
                }
            }
        }

        public long Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public String Localitate
        {
            get { return localitate; }
            set { localitate = value; }
        }

        public String DateProprietar
        {
            get { return dateProprietar; }
            set { dateProprietar = value; }
        }
    }
}
