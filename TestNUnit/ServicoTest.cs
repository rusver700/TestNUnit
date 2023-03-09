using ConsoleNUnit.Modelo;
using ConsoleNUnit.Servico;

namespace TestNUnit
{
    public class ServicoTest
    {
        private ValorEntrada _valorEntrada;
        private Servico _servico;

        [SetUp]
        public void Setup()
        {
            _valorEntrada= new ValorEntrada() {Numero1 = 100, Numero2 = 40 };
            _servico = new Servico(_valorEntrada);
        }

        [Test]
        public void Soma_Sucesso()
        {
            //Arrange

            //Act
            var result = _servico.Somar();

            //Assert
            Assert.That(result, Is.EqualTo(140));
            Assert.IsNotEmpty(result.ToString());
            Assert.NotNull(result);
        }

        [Test]
        public void Subtrair_Sucesso()
        {
            //Arrange

            //Act
            var result = _servico.Subtarir();

            //Assert
            Assert.That(result, Is.EqualTo(60));
            Assert.IsNotEmpty(result.ToString());
            Assert.NotNull(result);
        }

        [Test]
        public void Dividir_Sucesso()
        {
            //Arrange

            //Act
            var result = _servico.Dividir();

            //Assert
            Assert.That(result, Is.EqualTo(2.5));
            Assert.IsNotEmpty(result.ToString());
            Assert.NotNull(result);
        }

        [Test]
        public void Multiplicar_Sucesso()
        {
            //Arrange

            //Act
            var result = _servico.Multiplicar();

            //Assert
            Assert.That(result, Is.EqualTo(4000));
            Assert.IsNotEmpty(result.ToString());
            Assert.NotNull(result);
        }

        [Test]
        public void Media_Sucesso()
        {
            //Arrange

            //Act
            var result = _servico.Media();

            //Assert
            Assert.That(result, Is.EqualTo(70));
            Assert.IsNotEmpty(result.ToString());
            Assert.NotNull(result);
        }
    }
}
