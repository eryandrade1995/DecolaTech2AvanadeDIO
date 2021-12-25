using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 20;
            var b = 10;
            var resCorreto = 30;
            var class1 = new Class1();

            var resFinal = class1.Soma(a, b);

            Assert.AreEqual(resCorreto, resFinal);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 20;
            var b = 10;
            var resCorreto = 10;
            var class1 = new Class1();

            var resFinal = class1.Subtracao(a, b);

            Assert.AreEqual(resCorreto, resFinal);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 20;
            var b = 10;
            var resCorreto = 2;
            var class1 = new Class1();

            var resFinal = class1.Divisao(a, b);

            Assert.AreEqual(resCorreto, resFinal);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 20;
            var b = 10;
            var resCorreto = 200;
            var class1 = new Class1();

            var resFinal = class1.Multiplicacao(a, b);

            Assert.AreEqual(resCorreto, resFinal);
        }
    }
}