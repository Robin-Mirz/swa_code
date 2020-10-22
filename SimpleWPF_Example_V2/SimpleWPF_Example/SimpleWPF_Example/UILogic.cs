using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SimpleWPF_Example
{
    public class UILogic : INotifyPropertyChanged
    {
        public ObservableCollection<Transportation> WaitingList { get; set; }
        public ObservableCollection<Transportation> ReadyList { get; set; }
        public ObservableCollection<CargoItem> SelectedCargo { get; set; }
        public RelayCommand DetailBtnClickedCmd { get; set; }
      
        public Transportation SelectedReadyEntry //Property
        {
            get { return selectedReadyEntry; }
            set
            {
                selectedReadyEntry = value;
                ////write details to property
                //SelectedCargo = selectedReadyEntry.Cargo;
                //NotifyPropertyChanged("SelectedCargo");

            }
        }

        #region VARIABLES
        private Transportation selectedReadyEntry; //variable | class member
        DispatcherTimer timer;
        public event PropertyChangedEventHandler PropertyChanged;
        //Delegate of Type Informer (own defined Delegate) used to point to CounterEllapsed Method
        Informer CounterEllapsedInformer;

        #endregion

        public UILogic()
        {
            WaitingList = new ObservableCollection<Transportation>();
            ReadyList = new ObservableCollection<Transportation>();

            CounterEllapsedInformer = new Informer(CounterEllapsed); //create instance of Informer and point to specific method which is called if informer is evaluated
                                                                     // DetailBtnClickedCmd = new RelayCommand(DetailsBtnClicked, CanExecuteShowDetailsBtn);
            DetailBtnClickedCmd = new RelayCommand(new Action(DetailsBtnClicked),
                () => { if (selectedReadyEntry == null) return false; else return true; });
            GenerateDemoEntries();
        }

        //private bool CanExecuteShowDetailsBtn()
        //{
        //    if (selectedReadyEntry == null)
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        private void DetailsBtnClicked()
        {
            //write details to property
            SelectedCargo = selectedReadyEntry.Cargo;
            NotifyPropertyChanged("SelectedCargo");
        }

        private void CounterEllapsed(Transportation source)
        {
            ReadyList.Add(source);
            WaitingList.Remove(source);
        }

        private void GenerateDemoEntries()
        {
            WaitingList.Add(new Transportation(CounterEllapsedInformer) //constructur used to provide instance of Informer delegate to Transportation object
            {
                Countdown = 10,
                Destination = "Vienna",
                Source = "Linz",
                Cargo = new ObservableCollection<CargoItem>()
                {
                    new CargoItem()
                    {
                        Description = "Manna Schnitten",
                        Amount=1000,
                        Weight=2
                    },
                    new CargoItem()
                    {
                        Description = "Auer Torten Ecken",
                        Amount=2000,
                        Weight=3
                    }
                }
            });
            WaitingList.Last().StartCountDown();


            WaitingList.Add(new Transportation(CounterEllapsedInformer)
            {
                Countdown = 7,
                Destination = "Innsbruck",
                Source = "bregenz",
                Cargo = new ObservableCollection<CargoItem>()
                {
                    new CargoItem()
                    {
                        Description = "Käse ecken",
                        Amount=1000,
                        Weight=2
                    },
                    new CargoItem()
                    {
                        Description = "Mozartkugeln",
                        Amount=3000,
                        Weight=500
                    }
                }
            });
            WaitingList.Last().StartCountDown();

        }

        private void NotifyPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
