using Xunit;
using PhonePad;
namespace TestPhonePad
{
    public class UnitTest1
    {
        [Fact]
        public void Test_oldPhonePad_should_be_same()
        {
            Dictionary<string, string> testData =new Dictionary<string, string>();
            testData.Add("33#", "E");
            testData.Add("227*#", "B");
            testData.Add("4433555 555666#", "HELLO");
            testData.Add("8 88777444666*664#", "TURING");
            foreach (var aTestData in testData) {
                Assert.Equal(MainKeyPad.OldPhonePad(aTestData.Key), aTestData.Value);
            }
        }
    }
}