using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Album : INotifyPropertyChanged
    {

        static private readonly Dictionary<string, string[]> powiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Tytuł"] = new string[] { "Format"/*, "Format"*/},
                ["Autor"] = new string[] { "Format"/*, "Format"*/},
                ["Wydawca"] = new string[] { "Format"/*, "Format"*/},
                ["Nośnik"] = new string[] { "Format"/*, "Format"*/},
                ["DataWydania"] = new string[] { "Format" },
            };
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(
            [CallerMemberName] string właściwość = null,
            HashSet<string> załatwioneWłaściwości = null
            )
        {
            if (załatwioneWłaściwości == null)
                załatwioneWłaściwości = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(właściwość));
            załatwioneWłaściwości.Add(właściwość);
            if (powiązaneWłaściwości.ContainsKey(właściwość))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                    if (!załatwioneWłaściwości.Contains(powiązanaWłaściwość))
                        OnPropertyChanged(powiązanaWłaściwość, załatwioneWłaściwości);
        }

        string tytuł;
        string autor;
        string wydawca;
        string nośnik;
        DateTime? dataWydania;

        public string Tytuł {
            get => tytuł;
            set
            {
                tytuł = value;
                OnPropertyChanged();
            }
        }

        public string Autor
        {
            get => autor;
            set
            {
                autor = value;
                OnPropertyChanged();
            }
        }

        public string Wydawca
        {
            get => wydawca;
            set
            {
                wydawca = value;
                OnPropertyChanged();
            }
        }

        public string Nośnik
        {
            get => nośnik;
            set
            {
                nośnik = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"Tytuł: {Tytuł}, Autor: {Autor}";
        }

        public string Format
        {
            get => $"Tytuł: {Tytuł}, Autor: {Autor}";
        }
    }
}
