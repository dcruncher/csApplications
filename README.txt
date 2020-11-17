Details on Invoice Generation Application

User details:
The Application on Invoice Generation is made up of 3 Web Forms
The application is to be run from WebForm1.aspx for smooth execution

Functionality:
WebForm1.aspx - Login form: Currently only 2 users are allowed to login as sign up feature is not yet completed
Credentials for login :
Username: alice
Password: al123

Username: bob
Password: bo123

WebForm2.aspx: Ordering Form:
Out of the 3 products available, selection can be made using the add item button &
removed one by one using the Remove Item button. The Quantity selected is visible in the 
Quantity column.

The design is made such that the products selected cannot be greater than the available
inventory (predefined in the database)

After Selection: the generae invoice button is to be clicked.

WebForm3.aspx: Invoice page
In this form , the invoice is generated based on the selections made previously.
The total amount to be paid is also calculated and displayed

The signout button closes the session and redirects to the login page

Note: The updated inventory will be maintained even after signout. You can sign in again and check.

Technical details:

Sessions have been used for maintaining the login and signout

Database: Dictionaries have been used to implement database. 2 dictionaries are used:
1: login dictionary - contains username and password
2: Database dictionary - contains item name, quantity available, quantity by bob, quantity by alice and rate of item as columns

Database declarations and operations are done using a static class Class1.cs
