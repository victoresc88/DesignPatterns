using StrategyPattern_Ducks.Behaviors;
using System;

namespace StrategyPattern_Ducks.Actions.Fly
{
	public class FlyRocketPowered : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Duck flying with a rocket!");
		}
	}
}
