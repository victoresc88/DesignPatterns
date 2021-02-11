using StrategyPattern_Ducks.Behaviors;
using System;

namespace StrategyPattern_Ducks.Actions.Quack
{
	public class Quack : IQuackBehavior
	{
		void IQuackBehavior.Quack()
		{
			Console.WriteLine("Quack quack!!");
		}
	}
}
