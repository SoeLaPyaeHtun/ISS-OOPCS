using System;
using System.Collections.Generic;

namespace Tour
{
	public class TourPackage : Tour
	{

		private List<Tour> ListOfTour;
		

		public TourPackage(string name, int cost, int duration) : base(name, cost, duration) { }

		public TourPackage(string name) : base(name) { }



		public void ConsistOf(Tour t)
		{
			ListOfTour.Add(t);
		}

		public override int Cost
		{
			get
			{

				foreach (var i in ListOfTour)
				{
					Cost += i.Cost;
				}
				return Cost * 9 / 10;
			}
		}
		public override int Duration
		{
			get
			{
				foreach (var i in ListOfTour)
				{
					Duration += i.Duration;
				}
				return Duration * 9 / 10;
			}
		}
	}
}

