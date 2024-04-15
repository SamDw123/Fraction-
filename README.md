# Fraction app
Author : Sam De Wispelaere
## project description 
1. Demontration app
    - This is a quick test to check if the fraction library works in the terminal.
2. Fractions library 
    - This is the library that is used everywhere in the solution to calculate the fractions.
3. WPF
    - In the wpf there are 2 different windows there is the main window where u can calculate the fractions and there is also a second window about with some information on. There is also some code behinde these 2 windows.

## Setup and usage
To simply use the app without downloading any app follow this step by step guid.
1. Download everythinh in the WPFFractions map
2. Go to WPFFractions > bin > Debug > net6.0-windows 
3. Once u are in the net6.0-windows file u need to open the WpfFractions.exe

If u want the full code ect. Follow these steps.
### Step-by-Step Guide to Utilize the Solution and Perform Unit Tests

#### Install Visual Studio:

1. Follow [this link](https://visualstudio.microsoft.com/vs/community/) for a detailed guide on installing Visual Studio Community edition.

#### Open the Project Solution:

1. After installation, open Visual Studio.
2. Navigate to **File > Open > Project/Solution**.
3. Choose the `FractionsApp.sln` file and open it.

#### Build the Solution:

1. Once the solution is loaded, build it to ensure all dependencies are resolved.
2. Right-click on `FractionsConsoleApp` in the Solution Explorer.
3. Select **Build** or **Rebuild** to compile the solution.

#### Configure Startup Projects:

1. Right-click on the solution in the Solution Explorer.
2. Go to **Set Startup Projects**.
3. Choose either single or multiple startup projects based on your requirements:
   - **Single startup project**: Run either the Console Application or the Windows Application.
   - **Multiple startup projects**: Run both the Console Application and the Windows Application simultaneously.

#### Run xUnit Tests:

1. Locate the `FractionsUnitTest` project in the Solution Explorer.
2. Right-click on it.
3. Select **Run Tests** to execute the unit tests.


## Unit test 
- TestAdd: Tests the addition operation between two fractions.
- TestSubtract: Tests the subtraction operation between two - fractions.
- TestMultiply: Tests the multiplication operation between two fractions.
- TestDivide: Tests the division operation between two fractions.
- TestReciProcal: Tests the calculation of the reciprocal of a fraction.
- TestInvert: Tests the inversion of the sign of a fraction.
- TestSimplify: Tests the simplification of a fraction to its simplest form.
- TestResult: Tests the method that calculates the decimal representation of a fraction.
- TestToString: Tests the overridden ToString method to ensure it returns the correct string representation of a fraction.
- TestAdd_WithNegativeFraction: Tests addition with a negative fraction.
- TestSubtract_WithNegativeResult: Tests subtraction resulting in a negative fraction.
- TestMultiply_ByZero: Tests multiplication by zero.
- TestDivide_ByZero: Tests division by zero.
- TestSimplify_WithNegativeFraction: Tests simplification of a negative fraction.

### how to run it 
1. Make sure your project references the your library namespace containing ur class.
2. Add the xUnit testing framework to your project.
3. Build your project to ensure that all necessary dependencies are resolved.
4. Now to run the unit tests click here. 

![alt text](image.png)



## Fraction Class

A simple C# class to represent fractions.

### Attributes

- `-numerator: int`: Private attribute representing the numerator of the fraction.
- `-denominator: int`: Private attribute representing the denominator of the fraction.

### Properties

- `+ <<get/set>> Numerator: int`: Public property to access and modify the numerator attribute.
- `+ <<get/set>> Denominator: int`: Public property to access and modify the denominator attribute. It automatically changes to 1 if set to 0.

### Constructors

- `+ Fraction()`: Default constructor initializing the fraction to 0/0.
- `+ Fraction(numerator: int, denominator: int)`: Parameterized constructor setting the fraction to the provided numerator and denominator.

### Methods

- `+ Add(right: Fraction): Fraction`: Adds the given fraction to the current fraction.
- `+ Subtract(right: Fraction): Fraction`: Subtracts the given fraction from the current fraction.
- `+ Multiply(right: Fraction): Fraction`: Multiplies the current fraction by the given fraction.
- `+ Divide(right: Fraction): Fraction`: Divides the current fraction by the given fraction. If the given fraction numerator automatically changes to 1 if set to 0.
- `+ Reciprocal(): Fraction`: Returns the reciprocal of the current fraction.
- `+ Invert(): Fraction`: Returns the current fraction with its sign inverted.
- `+ Simplify(): Fraction`: Simplifies the current fraction to its simplest form.
- `+ Result(): string`: Returns the decimal representation of the fraction.
- `+ ToString(): string`: Overrides the default `ToString` method to return a string representation of the fraction.



## Screenshots
Opening app:
![alt text](image-1.png)
Add:
![alt text](image-2.png)
Change to number:
![alt text](image-3.png)
Multiply:
![alt text](image-4.png)
Simplify:
![alt text](image-5.png)
About window: 
![alt text](image-6.png)

## Future inprovments 
1. I could add other calculation and not only the fractions.
2. Maybe some quality of live changes but i would need some feedback first what other people think could be better ect.