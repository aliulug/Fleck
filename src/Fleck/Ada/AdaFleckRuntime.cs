using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fleck.Ada
{
	public class AdaFleckRuntime
	{
		public static IMessageCounter GetMessageCounter()
		{
			return MessageCounter.Create();
		}
	}
}
