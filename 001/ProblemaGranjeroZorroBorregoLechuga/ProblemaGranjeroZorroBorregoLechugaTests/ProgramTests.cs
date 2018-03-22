using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemaGranjeroZorroBorregoLechuga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGranjeroZorroBorregoLechuga.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        // empty
        [TestMethod()]
        public void Validate()
        {
            var expected = string.Empty;
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("");
            Assert.AreEqual(expected, actual);
        }

        // G
        // z
        // b
        // l
        [TestMethod()]
        [DataTestMethod]
        [DataRow("G")]
        [DataRow("z")]
        [DataRow("b")]
        [DataRow("l")]
        public void Validate_SingleCompanion_ReturnsEmptyString(string companion)
        {
            var expected = "";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate(companion);
            Assert.AreEqual(expected, actual);
        }

        // Gz
        // Gb
        // Gl
        [TestMethod()]
        [DataTestMethod]
        [DataRow("Gz")]
        [DataRow("Gb")]
        [DataRow("Gl")]
        public void Validate_GranjeroYCompanion_ReturnsEmptyString(string companion)
        {
            var expected = "";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("G" + companion);
            Assert.AreEqual(expected, actual);
        }

        // zb
        [TestMethod()]
        public void Validate_ZorraYBorrego_ReturnsZorraComeBorrego()
        {
            var expected = "Zorra come Borrego";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("zb");
            Assert.AreEqual(expected, actual);
        }

        // zl
        [TestMethod()]
        public void Validate_ZorraYLechuga_ReturnsEmptyString()
        {
            var expected = "";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("zl");
            Assert.AreEqual(expected, actual);
        }

        // bl
        [TestMethod()]
        public void Validate_BorregoYLechuga_ReturnsBorregoComeLechuga()
        {
            var expected = "Borrego come Lechuga";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("bl");
            Assert.AreEqual(expected, actual);
        }

        // Gzbl
        [TestMethod()]
        public void Validate_OneOfEach_ReturnsEmptyString()
        {
            var expected = "";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("Gzbl");
            Assert.AreEqual(expected, actual);
        }

        // Gbzzlz
        [TestMethod()]
        public void Validate_Gbzzlz_ReturnsZorraComeBorrego()
        {
            var expected = "Zorra come Borrego";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("Gbzzlz");
            Assert.AreEqual(expected, actual);
        }

        // GbGGzzGzzzlz
        [TestMethod()]
        public void Validate_GbGGzzGzzzlz_ReturnsZorraComeBorrego()
        {
            var expected = "Zorra come Borrego";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("GbGGzzGzzzlz");
            Assert.AreEqual(expected, actual);
        }

        // GGbbzzz
        [TestMethod()]
        public void Validate_GGbbzzz_ReturnsEmptyString()
        {
            var expected = "";
            var target = new ProblemaGranjeroZorroBorregoLechuga.Program();
            var actual = target.Validate("GGbbzzz");
            Assert.AreEqual(expected, actual);
        }
    }
}