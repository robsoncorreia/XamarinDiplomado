using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinDiplomado.Model.Entrada
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler INotifyPropertyChanged = delegate
        {

        };
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
