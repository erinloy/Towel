﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Towel;

namespace Towel_Testing
{
	[TestClass] public class Search_Testing
	{
		[TestMethod] public void Binary()
		{
			{ // [even] collection size [found]
				int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
				for (int i = 0; i < values.Length; i++)
				{
					var result = Search.Binary(values, a => Compare.Wrap(a.CompareTo(i)));
					Assert.IsTrue(result.Success);
					Assert.IsTrue(result.Index == i);
				}
			}
			{ // [odd] collection size [found]
				int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };
				for (int i = 0; i < values.Length; i++)
				{
					var result = Search.Binary(values, a => Compare.Wrap(a.CompareTo(i)));
					Assert.IsTrue(result.Success);
					Assert.IsTrue(result.Index == i);
				}
			}
			{ // [even] collection size [not found]
				int[] values = { -9, -7, -5, -3, -1, 1, 3, 5, 7, 9, };
				for (int i = 0, j = -10; j <= 10; i++, j += 2)
				{
					var result = Search.Binary(values, a => Compare.Wrap(a.CompareTo(j)));
					Assert.IsTrue(!result.Success);
					Assert.IsTrue(result.Index == i - 1);
				}
			}
			{ // [odd] collection size [not found]
				int[] values = { -9, -7, -5, -3, -1, 1, 3, 5, 7, };
				for (int i = 0, j = -10; j <= 8; i++, j += 2)
				{
					var result = Search.Binary(values, a => Compare.Wrap(a.CompareTo(j)));
					Assert.IsTrue(!result.Success);
					Assert.IsTrue(result.Index == i - 1);
				}
			}
		}
	}
}