using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
	public abstract class AbstractExpression
	{
		public abstract void Interpret(Context context);
	}
}
