using StrategyPattern_Ducks.Behaviors;
using System;

namespace StrategyPattern_Ducks.Actions.Fly
{
	public class FlyNoWay : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Duck can't fly!");
		}
	}
}
