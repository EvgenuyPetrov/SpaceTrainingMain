using System;
using SpaceTrainingMain.Core;

namespace SpaceTrainingMain.MVVM.ViewMidel
{
    class MainViewModel: ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand TheoryViewCommand { get; set; }



        public HomeViewModel HomeVm { get; set; }

        public TheoryViewModel TheoryVm { get; set; }




        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            TheoryVm = new TheoryViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o=>
            {
                    CurrentView = HomeVm;
            });

            TheoryViewCommand = new RelayCommand(o =>
            {
                CurrentView = TheoryVm;
            });

        }

    }
}
