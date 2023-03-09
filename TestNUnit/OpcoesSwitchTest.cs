using ConsoleNUnit.Servico.Interface;
using ConsoleNUnit.Servico;
using Moq;
using FluentAssertions;

namespace TestNUnit
{
    public class OpcoesSwitchTest
    {
        Mock<IServico> _servicoMock;
        private OpcoesSwitch _opcoesSwitch;

        [SetUp]
        public void Setup()
        {
            _servicoMock = new Mock<IServico>();
            _opcoesSwitch = new OpcoesSwitch(_servicoMock.Object);
        }

        [Test]
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        [TestCase("6")]
        public void Opcoes_Validas(string valor)
        {
            //Arrange

            //Act
           var act = () => _opcoesSwitch.Opcao(valor);

            //Assert

            act.Should().NotBeNull();
            act.Should().NotThrow();
            act.Target.Equals(valor);
            act.Should().NotBeNull(valor);
        }

        [Test]
        public void Opcao_Valida()
        {
            //Arrange
            string valor = "2";
            //Act
            var result = _opcoesSwitch.Opcao(valor);

            //Assert

            result.Should().Be("0");
            result.Should().NotBeNull();
            result.Should().NotBeNullOrEmpty();

        }

        [Test]
        [TestCase("")]
        public void Opcao_DefaultExcessao(string valor)
        {
            //Arrange

            //Act
            var act = () => _opcoesSwitch.Opcao(valor);

            //Assert

            act.Should().NotBeNull();
            act.Should().Throw<Exception>();
        }
        [Test]
        public void Opcao_DefaultExcessao()
        {
            //Arrange

            //Act
            Action act = () => _opcoesSwitch.Opcao(It.IsAny<string>());

            //Assert

            act.Should().NotBeNull();
            act.Should().Throw<Exception>();
        }
    }
}