using Exercici31;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarPersonajePositivo()
        {
            string personatge = "Valido";
            bool result = Exercici31Proj.ValidarPersonatge(personatge);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidarPersonajeNegativo()
        {
            string personatge = "NombreInvalido";
            bool result = Exercici31Proj.ValidarPersonatge(personatge);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ValidarNombrePositivo()
        {
            int num = 50;
            string MsgIntroNombre = "Introdueix un nombre entre l'1 i 500:";
            bool result = Exercici31Proj.ValidarNombre(num, MsgIntroNombre);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidarNombreNegativo()
        {
            int num = 501;
            string MsgIntroNombre = "Introdueix un nombre entre l'1 i 500:";
            bool result = Exercici31Proj.ValidarNombre(num, MsgIntroNombre);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void RandomNumber()
        {
            int maxVar = 100;
            int minVar = 1;
            int result = Exercici31Proj.RandomNumber();
            Assert.IsTrue(result >= minVar && result <= maxVar);
        }
    }
}