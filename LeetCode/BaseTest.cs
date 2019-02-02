using Xunit.Abstractions;

namespace LeetCode
{
    public class BaseTest
    {
        protected readonly ITestOutputHelper Output;

        public BaseTest(ITestOutputHelper tempOutput)
        {
            Output = tempOutput;
        }
    }
}
