using StrategyPattern_Ducks.Behaviors;
using System;

namespace StrategyPattern_Ducks.Actions.Quack
{
	public class MuteQuack : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("[....]");
		}
	}
}
