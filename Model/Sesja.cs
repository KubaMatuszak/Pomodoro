using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.Model
{
    public class Sesja
    {
     
        private string Sesje;

		public string sesje
		{
			get { return Sesje; }
			set { Sesje = value; }
		}
		private DateTime Data;

		public DateTime data
		{
			get { return Data; }
			set { Data = value; }
		}


	}
}
