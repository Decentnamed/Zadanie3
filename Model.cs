using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Model
    {
        public ObservableCollection<Album> ListaAlbumów { get; } = new ObservableCollection<Album>() {
            new Album() {Tytuł="Kompot", Autor="Paluch", Wydawca="BOR", Nośnik="Płyta CD", DataWydania=Convert.ToDateTime("2022.04.01")},
            new Album() {Tytuł="Fight Club", Autor="PRO8L3M", Wydawca="PRO8L3M", Nośnik="Płyta CD", DataWydania=Convert.ToDateTime("2021.03.19")},
            new Album() {Tytuł="Ghetto Playboy", Autor="Smolasty", Wydawca="Smolasty", Nośnik="Płyta CD", DataWydania=Convert.ToDateTime("2021.05.09")},
            new Album() {Tytuł="Chaos", Autor="Fukaj", Wydawca="Fukaj", Nośnik="Płyta CD", DataWydania=Convert.ToDateTime("2021.01.29")},
            new Album() {Tytuł="Ziomalski mixtape", Autor="Żabson", Wydawca="INTERNAZIOMALE", Nośnik="Płyta CD", DataWydania=Convert.ToDateTime("2021.05.13")},
        };

        internal Album Nowy()
        {
            Album nowy = new Album();
            ListaAlbumów.Add(nowy);
            return nowy;
        }

    }
}
