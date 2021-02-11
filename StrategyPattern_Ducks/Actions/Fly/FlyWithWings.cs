using StrategyPattern_Ducks.Behaviors;
using System;

namespace StrategyPattern_Ducks.Actions.Fly
{
	public class FlyWithWings : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Duck is flying with wings!");
		}
	}
}
