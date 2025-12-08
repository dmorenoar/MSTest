# Tools - Utility Library

A simple and efficient C# utility library with common helper methods for mathematical operations, string manipulation, and validation.

## 📋 Description

The `Utils` class provides a collection of static methods designed to simplify common programming tasks. All methods are well-documented with XML comments and handle edge cases appropriately.

## 🚀 Methods Reference

### 1. Add
```csharp
public static int Add(int a, int b)
```

**Description**: Adds two integers and returns the result.

**Parameters**:
- `a` (int): First number
- `b` (int): Second number

**Returns**: The sum of `a` and `b`.

**Examples**:
```csharp
int result = Utils.Add(5, 3);        // Returns: 8
int result = Utils.Add(-2, 2);       // Returns: 0
int result = Utils.Add(0, 0);        // Returns: 0
```

---

### 2. IsEven
```csharp
public static bool IsEven(int num)
```

**Description**: Determines if a number is even.

**Parameters**:
- `num` (int): The number to evaluate

**Returns**: `true` if `num` is even; otherwise, `false`.

**Examples**:
```csharp
bool result = Utils.IsEven(4);       // Returns: true
bool result = Utils.IsEven(7);       // Returns: false
bool result = Utils.IsEven(0);       // Returns: true
bool result = Utils.IsEven(-2);      // Returns: true
```

---

### 3. Max
```csharp
public static int Max(int a, int b)
```

**Description**: Returns the maximum value between two integers.

**Parameters**:
- `a` (int): First number
- `b` (int): Second number

**Returns**: The higher value between `a` and `b`.

**Examples**:
```csharp
int result = Utils.Max(5, 3);        // Returns: 5
int result = Utils.Max(2, 8);        // Returns: 8
int result = Utils.Max(6, 6);        // Returns: 6
int result = Utils.Max(-5, -10);     // Returns: -5
```

---

### 4. Reverse
```csharp
public static string Reverse(string text)
```

**Description**: Reverses the characters in a string.

**Parameters**:
- `text` (string): The text to reverse. Can be `null`.

**Returns**: A new string with the characters reversed, or `null` if `text` is `null`.

**Examples**:
```csharp
string result = Utils.Reverse("hello");     // Returns: "olleh"
string result = Utils.Reverse("Tools");     // Returns: "slooT"
string result = Utils.Reverse("");          // Returns: ""
string result = Utils.Reverse(null);        // Returns: null
string result = Utils.Reverse("a");         // Returns: "a"
```

**Implementation Details**:
- Converts the string to a character array
- Uses `Array.Reverse()` to reverse the array
- Constructs a new string from the reversed array

---

### 5. IsValidGrade
```csharp
public static bool IsValidGrade(int grade)
```

**Description**: Determines whether a grade is valid (between 0 and 10, inclusive).

**Parameters**:
- `grade` (int): The grade to validate

**Returns**: `true` if `grade` is between 0 and 10 (inclusive), otherwise `false`.

**Examples**:
```csharp
bool result = Utils.IsValidGrade(7);        // Returns: true
bool result = Utils.IsValidGrade(0);        // Returns: true
bool result = Utils.IsValidGrade(10);       // Returns: true
bool result = Utils.IsValidGrade(-1);       // Returns: false
bool result = Utils.IsValidGrade(11);       // Returns: false
```

**Use Case**: Useful for validating academic grades or scores in a 0-10 scale system.

---

### 6. CountVowels
```csharp
public static int CountVowels(string text)
```

**Description**: Counts the number of vowels (a, e, i, o, u) in a given text, case-insensitive.

**Parameters**:
- `text` (string): The text to analyze. Can be empty or `null`.

**Returns**: The number of vowels found in `text`.

**Examples**:
```csharp
int result = Utils.CountVowels("hello");           // Returns: 2 (e, o)
int result = Utils.CountVowels("AEIOU");           // Returns: 5
int result = Utils.CountVowels("xyz");             // Returns: 0
int result = Utils.CountVowels("");                // Returns: 0
int result = Utils.CountVowels(null);              // Returns: 0
int result = Utils.CountVowels("Beautiful");       // Returns: 5 (e, a, u, i, u)
```

**Implementation Details**:
- Recognizes both uppercase and lowercase vowels
- Returns 0 for null or empty strings
- Vowels counted: a, e, i, o, u (case-insensitive)

---

## 📦 Installation

### Prerequisites

- .NET SDK (6.0 or higher recommended)
- Visual Studio 2019+ or VS Code with C# extension

### Clone the repository

```bash
git clone https://github.com/yourusername/tools-library.git
cd tools-library
```

### Build the project

```bash
dotnet build
```

## 💻 Complete Usage Example

```csharp
using Tools;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mathematical operations
            int sum = Utils.Add(10, 20);                    // 30
            int maximum = Utils.Max(15, 25);                // 25
            
            // Number validation
            bool isEven = Utils.IsEven(8);                  // true
            bool validGrade = Utils.IsValidGrade(8);        // true
            
            // String operations
            string reversed = Utils.Reverse("Hello World"); // "dlroW olleH"
            int vowels = Utils.CountVowels("Education");    // 5
            
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {maximum}");
            Console.WriteLine($"Is 8 even? {isEven}");
            Console.WriteLine($"Is 8 a valid grade? {validGrade}");
            Console.WriteLine($"Reversed: {reversed}");
            Console.WriteLine($"Vowel count: {vowels}");
        }
    }
}
```

## 🎯 Method Categories

### Mathematical Operations
- `Add(int, int)` - Addition
- `Max(int, int)` - Maximum value

### Validation Methods
- `IsEven(int)` - Even number check
- `IsValidGrade(int)` - Grade validation

### String Operations
- `Reverse(string)` - String reversal
- `CountVowels(string)` - Vowel counting

## ✅ Features

- ✨ Simple and intuitive API
- 📝 Comprehensive XML documentation
- 🛡️ Null-safe implementations
- 🎯 Edge case handling
- ⚡ High performance with static methods
- 🧪 Fully unit tested

## 📁 Project Structure

```
Tools/
├── Utils.cs              # Main utility class with all methods
└── Tools.Tests/
    └── UtilsTests.cs     # Comprehensive unit tests
```

## 🛠️ Technologies

- Language: C#
- Framework: .NET
- Testing: MSTest

### Code Style Guidelines
- Use XML documentation comments for all public methods
- Include parameter descriptions and return value documentation
- Handle edge cases (null, empty, boundary values)
- Use descriptive parameter names
- Keep methods focused on a single responsibility

# Tools.Tests - Unit Testing Documentation

Comprehensive test suite for the Tools utility library using MSTest framework.

## 📋 Overview

This test project demonstrates best practices in C# unit testing, including both traditional and data-driven testing approaches using MSTest attributes and the Arrange-Act-Assert (AAA) pattern.

## 🧪 Test Structure

### Test Categories

- **UtilsTests**: General utility methods (Add, IsEven, Reverse)
- **NumbersTests**: Numeric operations (Max, IsValidGrade)

## 📊 Test Coverage

### Add Method Tests

**Test: `Add_ShouldReturnCorrectSum`**
- Tests basic addition with single values
- Input: 3 + 5
- Expected: 8

**Test: `Add_ShouldReturnCorrectSum_DataDriven`**
- Data-driven test with multiple scenarios
- Test cases:
  - 3 + 5 = 8 (positive numbers)
  - -2 + 2 = 0 (negative + positive)
  - 0 + 0 = 0 (zero handling)

### IsEven Method Tests

**Test: `IsEven_ShouldReturnExpectedResult_DataDriven`**
- Test cases:
  - 4 → true (even number)
  - 7 → false (odd number)

**Test: `IsEven_ShouldReturnIsFalseForOddNumbers`**
- Validates odd number detection
- Input: 5
- Expected: false

**Test: `IsEven_ShouldReturnTrueForEvenNumbers`**
- Validates even number detection
- Input: 4
- Expected: true

### Max Method Tests

**Test: `Max_ShouldReturnExpectedResult_DataDriven`**
- Test cases:
  - Max(2, 4) = 4 (first < second)
  - Max(5, 3) = 5 (first > second)
  - Max(6, 6) = 6 (equal values)

### IsValidGrade Method Tests

**Test: `IsValidGrade_ShouldValidateCorrectly`**
- Test cases:
  - 3 → true (valid grade)
  - 0 → true (minimum valid)
  - 10 → true (maximum valid)
  - -1 → false (below range)

### Reverse Method Tests

**Test: `Reverse_ShouldReturnNull_WhenInputIsNull`**
- Validates null handling
- Input: null
- Expected: null

**Test: `Reverse_ShouldReturnReversedString_DataDriven`**
- Test cases:
  - "hello" → "olleh"
  - "Tools" → "slooT"
  - "" → "" (empty string)

**Test: `Reverse_ShouldNotReturnSameString_DataDriven`**
- Verifies string is actually reversed
- Test cases: "hello", "Tools", "abcd"

**Test: `Reverse_ShouldNotReturnSameString`**
- Single case verification
- Input: "example"
- Validates output differs from input

## 🎯 Testing Patterns Used

### 1. Arrange-Act-Assert (AAA)
```csharp
// Arrange
int a = 3;
int b = 5;

// Act
int result = Utils.Add(a, b);

// Assert
Assert.AreEqual(8, result);
```

### 2. Data-Driven Testing
```csharp
[DataTestMethod]
[DataRow(3, 5, 8)]
[DataRow(-2, 2, 0)]
[DataRow(0, 0, 0)]
public void Add_ShouldReturnCorrectSum_DataDriven(int a, int b, int expected)
{
    int result = Utils.Add(a, b);
    Assert.AreEqual(expected, result);
}
```

### 3. Test Categorization
```csharp
[TestCategory("UtilsTests")]
[TestCategory("NumbersTests")]
```

## 🚀 Running Tests

### Run all tests
```bash
dotnet test
```

### Run by category
```bash
# Run only UtilsTests
dotnet test --filter TestCategory=UtilsTests

# Run only NumbersTests
dotnet test --filter TestCategory=NumbersTests
```

### Run specific test
```bash
dotnet test --filter "FullyQualifiedName~Add_ShouldReturnCorrectSum"
```

### Run with detailed output
```bash
dotnet test --verbosity detailed
```

## 📈 Test Statistics

| Method | Total Tests | Data-Driven | Standard |
|--------|-------------|-------------|----------|
| Add | 2 | 1 | 1 |
| IsEven | 3 | 1 | 2 |
| Max | 1 | 1 | 0 |
| IsValidGrade | 1 | 1 | 0 |
| Reverse | 4 | 2 | 2 |

**Total: 11 test methods covering 5 utility methods**

## 🔍 Edge Cases Tested

- ✅ Null values (Reverse method)
- ✅ Empty strings (Reverse method)
- ✅ Zero values (Add method)
- ✅ Negative numbers (Add, IsValidGrade)
- ✅ Boundary values (IsValidGrade: 0, 10)
- ✅ Equal values (Max method)

## 🛠️ Test Configuration

### Test Framework
- MSTest (Microsoft.VisualStudio.TestTools.UnitTesting)

### Assertions Used
- `Assert.AreEqual()` - Value equality
- `Assert.AreNotEqual()` - Value inequality
- `Assert.IsTrue()` - Boolean true
- `Assert.IsFalse()` - Boolean false
- `Assert.IsNull()` - Null check

## 📝 Best Practices Demonstrated

1. **Clear naming conventions**: `MethodName_ExpectedBehavior_Condition`
2. **AAA pattern**: Consistent structure across tests
3. **Data-driven tests**: Reduces code duplication
4. **Test categorization**: Enables selective test execution
5. **Edge case coverage**: Null, empty, boundary values
6. **Both positive and negative tests**: Validates expected behavior and failure cases

## 🎓 Learning Points

- Using `[DataTestMethod]` with `[DataRow]` for parameterized tests
- Organizing tests with `[TestCategory]`
- Testing both expected and unexpected behaviors
- Proper null handling verification
- Testing boundary conditions

## 📦 Requirements

- .NET SDK
- MSTest framework
- Tools library (project under test)

**Note**: This test suite serves as both validation for the Tools library and as a reference for unit testing best practices in C#.
