﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Towel;
using static Towel.Statics;

namespace Towel_Testing
{
	[TestClass] public class Sort_Testing
	{
		public const int size = 10;
		public const int randomSeed = 7;

		public static bool IsLeastToGreatest<T>(T[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (Compare(array[i], array[i + 1]) is Greater)
				{
					return false;
				}
			}
			return true;
		}

		public static int[] watchArray;

		public static void TestAlgorithm(
			Action<int[], Func<int, int, CompareResult>> algorithm,
			Action<int[], int, int, Func<int, int, CompareResult>> algorithmPartial,
			int? sizeOverride = null)
		{
			void Test(int sizeAdjusted)
			{
				Random random = new Random(randomSeed);
				int[] array = new int[sizeAdjusted];
				Extensions.Iterate(sizeAdjusted, i => array[i] = i);
				Shuffle<int>(array, random);
				Assert.IsFalse(IsLeastToGreatest(array), "Test failed (invalid randomization).");
				algorithm(array, Compare);
				Assert.IsTrue(IsLeastToGreatest(array), "Sorting algorithm failed.");
			}

			Test(sizeOverride ?? size); // Even Data Set
			Test((sizeOverride ?? size) + 1); // Odd Data Set
			if (sizeOverride is null) Test(1000); // Large(er) Data Set

			{ // Partial Array Sort
				int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
				watchArray = array;
				algorithmPartial(array, 3, 7, Compare);
				int[] expected = { 9, 8, 7, /*|*/ 2, 3, 4, 5, 6, /*|*/ 1, 0 };
				for (int i = 0; i < size; i++)
				{
					Assert.IsTrue(array[i] == expected[i]);
				}
			}
		}

		[TestMethod] public void Shuffle_Testing()
		{
			Random random = new Random(randomSeed);
			int[] array = new int[size];
			Extensions.Iterate(size, i => array[i] = i);
			Shuffle<int>(array, random);
			Assert.IsFalse(IsLeastToGreatest(array));
		}

		[TestMethod] public void Bubble_Testing() => TestAlgorithm(
			(array, compare) => SortBubble<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortBubble<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Insertion_Testing() => TestAlgorithm(
			(array, compare) => SortInsertion<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortInsertion<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Selection_Testing() => TestAlgorithm(
			(array, compare) => SortSelection<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortSelection<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Merge_Testing() => TestAlgorithm(
			(array, compare) => SortMerge<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortMerge<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Quick_Testing() => TestAlgorithm(
			(array, compare) => SortQuick<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortQuick<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Heap_Testing() => TestAlgorithm(
			(array, compare) => SortHeap<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortHeap<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void OddEven_Testing() => TestAlgorithm(
			(array, compare) => SortOddEven<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortOddEven<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Slow_Testing() => TestAlgorithm(
			(array, compare) => SortSlow<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortSlow<int>(start, end, i => array[i], (i, v) => array[i] = v, compare),
			10);

		[TestMethod] public void Gnome_Testing() => TestAlgorithm(
			(array, compare) => SortGnome<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortGnome<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Comb_Testing() => TestAlgorithm(
			(array, compare) => SortComb<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortComb<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Shell_Testing() => TestAlgorithm(
			(array, compare) => SortShell<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortShell<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Cocktail_Testing() => TestAlgorithm(
			(array, compare) => SortCocktail<int>(0, array.Length - 1, i => array[i], (i, v) => array[i] = v, compare),
			(array, start, end, compare) => SortCocktail<int>(start, end, i => array[i], (i, v) => array[i] = v, compare));

		[TestMethod] public void Bogo_Testing() => TestAlgorithm(
			(array, compare) => SortBogo(array, compare),
			(array, start, end, compare) => SortBogo<int>(start, end, i => array[i], (i, v) => array[i] = v, compare),
			6);


		[TestMethod] public void BubbleSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortBubble<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void InsertionSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortInsertion<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void SelectionSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortInsertion<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void MergeSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortMerge<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void QuickSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortQuick<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void HeapSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortHeap<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void OddEvenSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortOddEven<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void SlowSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortSlow<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void GnomeSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortGnome<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void CombSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortComb<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void ShellSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortShell<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void CocktailSpan_Test()
		{
			Span<int> span = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			SortCocktail<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}

		[TestMethod] public void BogoSpan_Test()
		{
			Span<int> span = new[] { 5, 4, 3, 2, 1, 0 };
			SortBogo<int, CompareInt>(span);
			for (int i = 1; i < span.Length; i++)
			{
				Assert.IsTrue(span[i - 1] <= span[i]);
			}
		}
	}
}
