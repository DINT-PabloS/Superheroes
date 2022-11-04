using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistasModelo
{
    class MainWindowVN : INotifyPropertyChanged
    {
        private Superheroe personaje;

        public Superheroe Personaje
        {
            get { return personaje; }
            set 
            { 
                personaje = value;
                this.NotifyPropertyChanged("Personaje");
            }
        }

        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set 
            { 
                posicion = value;
                this.NotifyPropertyChanged("Posicion");
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set 
            { 
                total = value;
                this.NotifyPropertyChanged("Total");
            }
        }

        private List<Superheroe> listaSuperheroes = Superheroe.GetSamples();

        public MainWindowVN() 
        {
            this.personaje = listaSuperheroes[0];
            this.posicion = 1;
            this.total = listaSuperheroes.Count;
        }

        public void Avanzar()
        {
            if(Posicion < Total) 
            {
                //IMPORTANTE usar la propiedad (en mayuscula la primera), para que el setter con el notify salte
                Posicion++;
                Personaje = listaSuperheroes[Posicion - 1];
            }
            
        }
        public void Retroceder()
        {
            if(Posicion > 1)
            {
                Posicion--;
                Personaje = listaSuperheroes[Posicion - 1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
