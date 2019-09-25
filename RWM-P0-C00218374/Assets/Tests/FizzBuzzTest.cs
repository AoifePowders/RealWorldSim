using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FizzBuzzTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void FizzBuzzTestSimplePasses()
        {
            // Use the Assert class to test conditions
            int[] input = { 4, 3, 6, 30, 10, 12};
            int[] output = FizzBuzzFilter.fizzBuzzFunc(input);
            int[] expected = { 4, 3, 3, 0, 5, 3 };

            CollectionAssert.AreEqual(expected, output);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator FizzBuzzTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
