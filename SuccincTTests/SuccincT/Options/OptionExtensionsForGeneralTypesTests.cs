﻿using NUnit.Framework;
using SuccincT.Options;

namespace SuccincTTests.SuccincT.Options
{
    [TestFixture]
    public sealed class OptionExtensionsForGeneralTypesTests
    {
        [Test]
        public void WhenObjectIsNotNull_ToOptionReturnsValue()
        {
            var obj = 10;
            var opt = obj.ToOption();
            Assert.IsNotNull(opt);
            Assert.IsTrue(opt.HasValue);
            Assert.AreEqual(10, opt.Value);
        }

        [Test]
        public void WhenObjectIsNull_ToOptionReturnsNone()
        {
            var opt = ((object)null).ToOption();
            Assert.IsNotNull(opt);
            Assert.IsFalse(opt.HasValue);
        }

        [Test]
        public void WhenNullableStructHasValue_ToOptionReturnsValue()
        {
            int? obj = 15;
            var option = obj.ToOption();
            Assert.IsNotNull(option);
            Assert.IsTrue(option.HasValue);
            Assert.AreEqual(15, option.Value);
        }

        [Test]
        public void WhenNullableStructHasNoValue_ToOptionReturnsNone()
        {
            var option = ((int?) null).ToOption();
            Assert.IsNotNull(option);
            Assert.IsFalse(option.HasValue);
        }

        [Test]
        public void WhenOptionHasValue_AsNullableReturnsThatValue()
        {
            var opt = Option<int>.Some(400);
            var val = opt.AsNullable();
            Assert.IsNotNull(val);
            Assert.AreEqual(400, val.Value);
        }

        [Test]
        public void WhenOptionHasNoValue_AsNullableReturnsNull()
        {
            var opt = Option<bool>.None();
            var val = opt.AsNullable();
            Assert.IsNull(val);
        }
    }
}