﻿using NUnit.Framework;
using SuccincT.Unions;
using SuccinctExamples;

namespace SuccincTTests.ExampleTests
{
    [TestFixture]
    class TreeUsingUnionsTests
    {
        [Test]
        public void SumTree_CorrectlyAddsUpTheValues()
        {
            var tip = new Tip();
            var myTree = new Node(0, new Node(1, new Node(2, tip, tip), new Node(3, tip, tip)), new Node(4, tip, tip));
            Assert.AreEqual(10, TreeUsingUnions.SumTree(new Union<Node, Tip>(myTree)));
        }
    }
}
