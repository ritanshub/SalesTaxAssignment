# SalesTaxAssignment
Sales Tax Assignment 
CODING EXERCISE - .NET
Evaluation Guidelines
What we are looking for
You will be evaluated on how you reach the solution, keeping in mind that the correctness of the
solution will also be taken into consideration.
Your focus should be on these elements of code quality:
- Code easy to read and to maintain and conforms to .Net standards (i.e. Clean code)
- Object-oriented design
- Unit testing
- Expandable design
- SOLID principles
What you should aim to deliver
A simple console application does the job. You do not need to implement any input mechanism, any UI
nor data store. It is important to keep in mind that we are looking for code quality and attention to
details, not quantity of code.
You may use frameworks and/or tools that are in general usage for the target technology stack (for
example your preferred unit testing framework).
However, the central problem of the coding exercise should be performed entirely by your own code.
Please note that, according to the information collected from the candidates, they usually spend
between 4 to 12 hours on this coding exercise.
Writing in .NET/ C#
The code must be written using Visual Studio. Visual Studio Community is available free on the Internet.
Once the code is written send me the source code only and not the executable or libraries (.Exe or .dll).
Problem: Sales Taxes
Basic sales tax is applicable at a rate of 10% on all goods, except books, food, and medical products that
are exempt. Import duty is an additional sales tax applicable on all imported goods at a rate of 5%, with
no exemptions.
When I purchase items, I receive a receipt which lists the name of all the items and their price (including
tax), finishing with the total cost of the items, and the total amounts of sales taxes paid. The rounding
rules for sales tax are that for a tax rate of n%, a shelf price of p contains (np/100 rounded up to the
nearest 0.05) amount of sales tax.
Write an application that prints out the receipt details for these shopping baskets...
INPUT:
Input 1:
• 1 book at 12.49
• 1 music CD at 14.99
• 1 chocolate bar at 0.85
Input 2:
• 1 imported box of chocolates at 10.00
• 1 imported bottle of perfume at 47.50
Input 3:
• 1 imported bottle of perfume at 27.99
• 1 bottle of perfume at 18.99
• 1 packet of headache pills at 9.75
• 1 box of imported chocolates at 11.25
OUTPUT:
Output 1:
• 1 book: 12.49
• 1 music CD: 16.49
• 1 chocolate bar: 0.85
• Sales Taxes: 1.50 Total: 29.83
Output 2:
• 1 imported box of chocolates: 10.50
• 1 imported bottle of perfume: 54.65
• Sales Taxes: 7.65 Total: 65.15
Output 3:
• 1 imported bottle of perfume: 32.19
• 1 bottle of perfume: 20.89
• 1 packet of headache pills: 9.75
• 1 imported box of chocolates: 11.85
• Sales Taxes: 6.70 Total: 74.68
