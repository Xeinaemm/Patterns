using System.Collections.Generic;
using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Implementation;
using Patterns.Interpreter.Implementation.Bread;
using Patterns.Interpreter.Implementation.Condiments;
using Patterns.Interpreter.Implementation.Ingredients;
using Patterns.Interpreter.Models;

// ReSharper disable UnusedMember.Local

namespace Patterns.Interpreter.Util
{
	public class Util
	{
		private static void JustUtil()
		{
			var sandwich = new Sandwich(
				new WheatBread(),
				new CondimentList(
					new List<ICondiment> {new MayoCondiment(), new MustardCondiment()}),
				new IngredientList(
					new List<IIngredient> {new LettuceIngredient(), new ChickenIngredient()}),
				new CondimentList(new List<ICondiment> {new KetchupCondiment()}));

			sandwich.Interpret(new Context());
		}
	}
}