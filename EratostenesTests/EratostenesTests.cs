using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Eratostenes;

namespace EratostenesTests
{
    public class EratostenesTests
    {
        [TestFixture]
        public class Numero_Menor_Que_Dos {
            Eratostenes.IEratostenes SUT = new Eratostenes.Eratostenes();
            
            [Test]
            public void Debe_Devolver_Una_Excepcion() {
                var excepcion = Assert.Throws<ArgumentException>(() => SUT.Juego(1));
                Assert.That(excepcion, Has.Message.EqualTo("El num. pasado como parametro tiene que ser => 2"));
            }
        }

        [TestFixture]
        public class Pasamos_El_Numero_Dos {
            Eratostenes.IEratostenes SUT = new Eratostenes.Eratostenes();
            private List<int> resultado;

            [SetUp]
            public void Setup() {
                resultado = SUT.Juego(2);
            }

            [Test]
            public void Debe_Devolver_Una_Lista_Con_El_Valor_Dos() {
                Assert.AreEqual(resultado, new List<int> { 2 });
            }
        }

        [TestFixture]
        public class Pasamos_El_Numero_Tres
        {
            Eratostenes.IEratostenes SUT = new Eratostenes.Eratostenes();
            private List<int> resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Juego(3);
            }
            
            [Test]
            public void Debe_Devolver_Una_Lista_Con_El_Valor_Dos_Tres()
            {
                Assert.AreEqual(resultado, new List<int> { 2, 3 });
            }
        }

        [TestFixture]
        public class Pasamos_El_Numero_Cuatro
        {
            Eratostenes.IEratostenes SUT = new Eratostenes.Eratostenes();
            private List<int> resultado;

            [SetUp]
            public void Setup()
            {
                resultado = SUT.Juego(4);
            }
            
            [Test]
            public void Debe_Devolver_Una_Lista_Con_El_Valor_Dos_Tres()
            {
                Assert.AreEqual(resultado, new List<int> { 2, 3 });
            }
        }

        [TestFixture]
        public class Pasamos_El_Numero_Cinco
        {
            Eratostenes.Eratostenes SUT = new Eratostenes.Eratostenes();
            private List<int> resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.Juego(5);
            }
            [Test]
            public void Debe_Devolver_Una_Lista_Con_El_Valor_Dos_Tres_Cinco()
            {
                Assert.AreEqual(resultado, new List<int> { 2, 3, 5 });
            }
        }
    }
}
