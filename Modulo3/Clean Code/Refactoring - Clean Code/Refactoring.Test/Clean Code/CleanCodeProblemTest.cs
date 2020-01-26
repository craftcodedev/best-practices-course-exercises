using Moq;
using NUnit.Framework;
using Refactoring.Clean_Code;
using TecnicasRefactoring.Clean_Code.NoCleanCode;

namespace Refactoring.Test.Clean_Code
{
    [TestFixture]
    public class CleanCodeProblemTest
    {
        [TestCase("SOMEPATH\\file.doc", "DocToPDF")]
        [TestCase("SOMEPATH\\file.xlsx", "ExcelToPDF")]
        [TestCase("SOMEPATH\\file.jpeg", "ImgToPDF")]
        [TestCase("SOMEPATH\\file.txt", "TxtToPDF")]
        public void ItShouldReturnConverterWhenExecuteExtension(string path, string expected)
        {
            //Arrange
            var mockDocument = new Mock<IDocumentType>();
            ExampleCleanCode ncc = new ExampleCleanCode();

            mockDocument.Setup(s => s.ConvertToPDF(path)).Returns(expected);

            //Act
            var actual = ncc.ExecuteConverter(path);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }        
    }
}
