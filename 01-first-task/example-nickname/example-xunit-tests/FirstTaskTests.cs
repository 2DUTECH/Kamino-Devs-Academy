using example_class_library;

namespace example_xunit_tests;

public class FirstTaskTests
{
    [Theory, MemberData(nameof(TestData))]
    internal void Test(int[] nums, int target, (int first, int second) indexes)
    {
        // arrange

        var calculator = new FirstTask();
        
        // act
        // где то тут будет вызываться наш метод GetIndexes

        var result = calculator.GetIndexes(nums, target);

        // assert
        // где то тут будет проверятся что результат работы нашего метода равен expectedTarget
    }
    
    public static IEnumerable<object[]> TestData => 
        new List<object[]>
        {
            new object[] { new[] { 3, 2, 4 }, 6, (1, 2) },
            new object[] { new[] { 2, 7, 11, 15 }, 9, (0, 1) },
            new object[] { new[] { 3, 3 }, 6, (0, 1) }
        };
}