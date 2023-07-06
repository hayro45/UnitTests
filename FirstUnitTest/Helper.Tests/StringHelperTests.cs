using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void girilen_ifadenin_icindeki_fazla_bosluklar_silinecek()
        {
            //Arrange
            string ifade = " Hayrettin   Dal";
            string beklenen = "Hayrettin Dal";


            //Act
            var gerceklesen = StringHelper.BosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }
        [TestMethod]
        public void girilen_ifadenin_basindaki_ve_sonundaki_bosluklar_silinecek()
        {
            //Arrange
            string ifade = "      Hayrettin     Dal     ";
            string beklenen = "Hayrettin Dal";


            //Act
            var gerceklesen = StringHelper.BosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
