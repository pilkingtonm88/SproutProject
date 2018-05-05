using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class webDriverUtilities
	{
		public static void main(string[] args)
		{

		}

	}

	public class Assert
	{
		public bool isTrue(bool value)
		{
			if (value == true)
			{
				return true;

			}
			else if (value == false)
			{
				return false;
			}
		}
	}
}
