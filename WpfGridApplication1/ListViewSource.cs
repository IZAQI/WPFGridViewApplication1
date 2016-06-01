using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGridApplication1
{
    public class BodyModel : INotifyPropertyChanged
    {

        private ListViewSource _listBody = new ListViewSource();
        public ListViewSource listBody
        {
            get { return _listBody; }
        }

        #region INotifyPropertyChanged メンバ

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion 
    }


    public class ListViewSource : ObservableCollection<ListViewModel>
    {
        public ListViewSource() : base()
        {
            for (int i = 0; i < 10000; i++)
            {
                var model = new ListViewModel(i);
                for(int j=0;j<10;j++)
                {
                    model.ChList.Add(Convert.ToString(j));
                }
                Add(model);

            }
        }
    }

    public class ListViewModel
    {

        public ListViewModel(int i)
        {
            s = Convert.ToString(i);
            _chList = new ObservableCollection<string>();
        }

        private string s;
        public string Name
        {
            get { return s; }
        }

        private string _descript = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890";
        public string Descript
        {
            //get { return _descript; }
            get { return Convert.ToString(new Random().Next()); }
        }

        private ObservableCollection<string> _chList = new ObservableCollection<string>();
        public ObservableCollection<string> ChList
        {
            get { return _chList; }
            set { _chList = value; }
        }
    }
}
