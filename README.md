# ATM Console Application - Lab 02: Unit Testing

## Introduction
Welcome to the Lab 02 of the ATM Console Application! In this lab, we will be focusing on implementing unit tests for the functionality of the ATM application. The goal is to ensure that each method performs as expected and handles both valid and invalid inputs correctly.

## Prerequisites
Before starting the lab, make sure you have the following set up:
- Visual Studio or any other preferred development environment.
- XUnit testing framework installed.

## Getting Started
To get started with the lab, follow these steps:

1. Open your preferred development environment.
2. Create a new project for unit testing using the XUnit testing framework.
3. Add references to the ATM application project and the necessary dependencies.
4. Set up the project to run the tests.

## Writing Unit Tests
Now, let's write unit tests for the different methods in the ATM application. Here are the requirements for the unit tests:

1. Test every method that does not require user input.
   - For each method, create a test case that passes valid input and another test case that passes invalid input.
   - Ensure that the method behaves as expected for both cases.

2. Test each non-void method at least twice.
   - For example, test the `ViewBalance()` method with a valid input scenario and an invalid input scenario.
   - Repeat this for all other non-void methods such as `Withdraw()` and `Deposit()`.

3. Remember that a failing test is not a valid test, even if the failure is expected.
   - Ensure that the tests pass when they should and fail when they should.

4. Avoid testing console input/output.
   - Since we cannot directly test methods that read from or write to the console, focus on testing the core logic of the methods.

## Running the Unit Tests
Once you have written the unit tests, you can run them to verify the functionality of the ATM application. Here's how you can run the tests:

1. Open the test project in your development environment.
2. Build the test project to ensure all dependencies are resolved.
3. Run the unit tests using the testing framework's interface or commands.
4. Review the test results to see if any tests have failed.
5. If a test fails, investigate the failure and make any necessary adjustments to the code.

## Conclusion
Congratulations! You have completed Lab 02 of the ATM Console Application, which focused on implementing unit tests for the application's functionality. By writing comprehensive tests, you can ensure that the application behaves as expected and handles different scenarios correctly.