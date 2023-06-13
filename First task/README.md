### _Ребят, не буду давать банальное задание на "Вывести в консоль Hello World!" - дам задачу на подумать и на погуглить_

Дана функция `GetIndexes` для поиска значений индексов в массиве, значения которых в сумме равны `target`

Например:

```csharp
nums = [2,7,11,15], target = 9

response = (first = 0, second = 1) // (т.е. сумма элементов на 0 и 1 позициях массива равны 9)
```

```csharp
nums = [3,2,4], target = 6

response = (first = 1, second = 2)
```

```csharp
nums = [3,3], target = 6

response = (first = 0, second = 1)
```

### Необходимо создать sln в котором будет два проекта:

- проект типа Class Library

```csharp
// в проекте содержится функция для поиска индексов. проект должен быть на фремворке .net 7

// функция должна иметь такой синтаксис:
public (int first, int second) GetIndexes(int[] nums, int target);
```

- проект типа xUnit Test Project

```csharp
// в проекте должен быть объявлен единственный тест (см. ниже). проект должен быть на .net 7 + xunit

// синтаксис теста:
[Theory()]
[InlineData(new int[] { 3, 2, 4 }, 6)]
[InlineData(new int[] { 2, 7, 11, 15 }, 9)]
[InlineData(new int[] { 3, 3 }, 6)]
[InlineData(new int[] { ? }, ?)] // ваш собственный пример для теста
public void Test(int[] nums, int expectedTarget)
{
    // arrange

    // act
    // где то тут будет вызываться наш метод GetIndexes

    // assert
    // где то тут будет проверятся что результат работы нашего метода равен expectedTarget
}
```
