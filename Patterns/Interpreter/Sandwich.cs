using System;
using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter
{
	// BNF:
	// <sandwhich> ::= <bread> <condimentList> <ingredientList> <condimentList> <bread>
	// <condimentList> ::= { <condiment> }
	// <ingredientList> ::= { <ingredient> }
	// <bread> ::= <whiteBread> | <wheatBread>
	// <condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
	// <ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>

	public class Sandwich : IExpression
	{
		private readonly IExpression _bottomCondiments;
		private readonly IBread _bread;
		private readonly IExpression _ingredients;
		private readonly IExpression _topCondiments;

		public Sandwich(IBread bread, IExpression topCondiments, IExpression ingredients,
			IExpression bottomCondiments)
		{
			_bread = bread;
			_topCondiments = topCondiments;
			_ingredients = ingredients;
			_bottomCondiments = bottomCondiments;
		}

		public void Interpret(Context context)
		{
			context.Output += "|";
			_bread.Interpret(context);
			context.Output += "|";
			context.Output += "<--";
			_topCondiments.Interpret(context);
			context.Output += "-";
			_ingredients.Interpret(context);
			context.Output += "-";
			_bottomCondiments.Interpret(context);
			context.Output += "-->";
			context.Output += "|";
			_bread.Interpret(context);
			context.Output += "|";
			Console.WriteLine(context.Output);
		}
	}
}