using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
	public class TerminalExpression : AbstractExpression
	{
		public override void Interpret(Context context)
		{
			Console.WriteLine("TerminalExpression.Interpret()");
		}
	}
}
