using Egz3kons;

namespace testpesel
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("80072909146", 'K')]
        [InlineData("81100216357", 'M')]
        public void Test1(string pesel, char expectedResult)
        {
            char result = Methods.CheckSex(pesel);


            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("55030101193", true)]
        [InlineData("12345678901", false)]

        public void Test2(string pesel, bool expectedResult)
        {
            bool result = Methods.ControlNumberCheck(pesel);

            Assert.Equal(expectedResult, result);
        }
    }
}