using Pomodoro.Model;
using Pomodoro.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Pomodoro.ViewModel
{
    public class MainWindowViewModel:ViewModelBase
    {
		public ObservableCollection<Sesja> mainList {  get; set; }

		public RelayCommand Minutnik => new RelayCommand(execute => Time(), canExecute => exc);

        public MainWindowViewModel()
        {
		 mainList = new ObservableCollection<Sesja>();
        }

		private string  SessionCounter;

		public string  sessionCounter
		{
			get { return SessionCounter; }
			set { SessionCounter = value; OnPopertyChenged(); }
		}

		


        bool exc = true;
		private string Stany;
		public string stany
		{
			get { return Stany; }
			set { Stany = value; OnPopertyChenged(); }
		}
		


		private int Sec;
		public int sec
		{
			get { return Sec; }
			set { Sec = value; OnPopertyChenged(); }
		}

		private int Min;

		public int min
		{
			get { return Min; }
			set { Min = value; OnPopertyChenged(); }
		}
		
		
		private void AddSesja()
		{
			
			mainList.Add(new Sesja { sesje = "Sesja wykonana:", data= DateTime.Now});
			
		}
		

		public async void Time()
		{
			int counter = Int32.Parse(sessionCounter);
			for (int i = 0; i < counter; i++)
			{

				exc = false;
				stany = "Pracuj!";
				sec = 0;
				min = 0;
				while (min < 25)
				{
					sec = sec + 1;
					if (sec == 60)
					{
						sec = 60;
						min = min + 1;
					}

					await Task.Delay(1000);

				}


				stany = "Przerwa!";
				sec = 60; min = 4;
				while (min >= 0)
				{
					sec = sec - 1;
					if (sec == 0)
					{
						sec = 60;
						min = min - 1;
					}

					if (min >= 0)
					{
						await Task.Delay(1000);
					}



				}
				sec = 0; min = 0;

				AddSesja();
			}
			stany = "Koniec nauki!";
			exc = true;
            


        }

		





	}
}
