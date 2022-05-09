# README

## Open Box Software - Graduate Recruitment

Our Open Box Software drinks fridge is running low and we need your help to restock it. Graduate Recruitment is a Console Application that loads CSV files containing data that allows us to track the stock in our drinks fridge. Help us to restock our drinks - using code - and you can win up to R10 000 in cash and 1 of 12 spots in our 2023 Graduate Programme!

## How do I get set up?

1. You will need a suitable IDE. For example:
   - Visual Studio Code
   - Visual Studio 2019 or later
2. Download the code in this repo as a zip file.
3. Create your own Github account if you do not already have one.
4. Create a repository on your Github account and push the code from the zipped file into this repository. 
5. Add the GitHub account "openboxsoftware" as a collaborator on your repository.
6. Create a branch called `graduate-recruitment-excercise`.
7. Write the code that will complete the below exercises and push to the `graduate-recruitment-excercise` branch.
8. Do NOT merge your code into your default branch (either `main` or `master`)
9. Create a pull request from your `graduate-recruitment-excercise` branch into your default branch. 
10. Once the openboxsoftware GitHub account has accepted your invitation to be a collaborator, you will be able to add the account as a reviewer on your pull request.

## Help us solve for the following:

1. What is the most popular drink, including the quantity, on a Wednesday?
2. What is the most popular drink, including the quantities, per day?
3. Which dates did we run out of Savanna Dry for the last recorded month?
4. How many Fanta Oranges do we need to order next week?
5. How much do we need to budget next month for Ceres Orange Juice?
6. How much do we need to budget for next month to restock the fridge?
7. We're planning a braai and expecting 100 people, how many of each drink should we order based on historical popularity of drinks?

## Things to consider

### Estimates

We base our estimates on the quantity of drinks taken from the fridge on a given day. To ensure we do not over order, take the current stock into consideration.

### Data

The data in the CSV files has been loaded into the `OpenBarRepository` which exposes a list of the following:

- All Inventory
  - List of all drinks we stock with associated prices.
- All Fridge Stock Takes
  - List of all quantites taken from the fridge or added to the fridge for a drink.
- All Open Bar Records
  - List of each date where fridge stock was recorded along with a count of people who were in the bar.

The CSV files will be updated regularly. Ensure your solutions are designed in a way that can handle dynamic data.

### Formatting

Consider that we located in South Africa when formatting data. If you are located in South Africa, you may use the current culture to achieve this.

#### **Dates**

Dates should be formatted as yyyy/MM/dd.

When working with weeks observe the following rules:

- The first week of the year starts on the first day of the year and ends before the following designated first day of the week.
- Sunday is the first day of the week.

#### **Currency**

Present your answers are Rands.

### Rounding

For accuracy, your solutions should not round any calculations until you present the final answer. We have provided the decimal extension `RoundToInt` to round a decimal to an int. Make use of this extension to ensure you apply the correct rounding rules.

### Unit Tests

Included in the solution is a unit tests project. Utilise this project to test your solutions with a smaller dataset where you can be certain of the expected results.

## What we're looking for

In addition to the correct answers we will look at the following:

- Readability and maintainability of the code
- Logical unit test coverage
- Application of SOLID and DRY principles

Running the console application should print out your final answers to the questions. There are formatting examples for the answers in the question methods provided in the `Program.cs` class.


## Happy coding!
