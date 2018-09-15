using System;
using Xunit;
using Hackathon.Api;


namespace Hackathon.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(89,new int[]{44,45})]
        [InlineData(67,new int[]{33,34})]
        [InlineData(1234,new int[]{307,308,309,310})]
        public void ConsecutiveNumber(int N,int[] expected) {
            var cal = new Logic();  
            var numberConsecutive = cal.CalConsecutiveNumber(N);
            
              Assert.Equal(expected, numberConsecutive);
            
        }


        [Fact]
        public void Change() {
            var cal = new Logic();  
            var result = cal.Pay(326,2000);
            
            //1674
            var expected = new  CountMoney{
                countThousand= 1,
                countFiveHundred= 1,
                countHundred= 1,
                countFifty= 1,
                countTwenty= 1,
                countTenCoin= 0,
                countFiveCoin= 0,
                countOneCoin= 4,
                
            };         
            
            Assert.Equal(expected.countThousand, result.countThousand);
            Assert.Equal(expected.countFiveHundred, result.countFiveHundred);
            Assert.Equal(expected.countHundred, result.countHundred);
            Assert.Equal(expected.countFifty, result.countFifty);
            Assert.Equal(expected.countTwenty, result.countTwenty);
            Assert.Equal(expected.countTenCoin, result.countTenCoin);
            Assert.Equal(expected.countFiveCoin, result.countFiveCoin);
            Assert.Equal(expected.countOneCoin, result.countOneCoin);
            
        }
    }

   
}
