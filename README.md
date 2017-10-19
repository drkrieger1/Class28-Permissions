# ![cf](http://i.imgur.com/7v5ASc8.png) Lab 28
## Identity Con't w/ Permissions


### Directions
1. Building off of what you've made from lab 27:
  1. Create a second registration page that will associate any users who use an "admin" (or w/e your equivalent for your applicaiton will be)
  2. Create a policy for your new "admin" role
  3. Parse through your site and label your pages as needed either as [AllowAnonymous] or [Authorize] (with restrictions of policies or roles as appropriate/needed)
  4. Your applicaiton, upon completion of this lab should contain the following pages/behavior: 
    - Regular user registration page
    - Registration page for your new user role
    - Login page for both of these roles
    - Redirect the user to a different page dependent on their role
    - One page specific to your "Admin"
    - one page specific to your "non-admin" Roles (Not Home)
    - Home Page
  5. Be sure that each controller and action has a permissiions attributes associated with it.
  6. One of your controllers should have both [AllowAnonymous] and a form of [Authorize].
    
 

### ReadMe
- Your readme should include the following information:
	- How long did it take you to complete this assignment?
	- What did you struggle with? Why? How did you solve?
	- What did you learn during this assignment?
    - What resources did you utilize for this assignment?
    

### To Submit this Assignment
- fork this repository
- write all of your code in a branch named `lab-#`; + `<your name>` **e.g.** `lab18-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas


### Rubric
- 2pts: Site contians all of the required pages specified above.
- 2pts: New role registration page & regular member registration page. Login Page redirect appropriately. 
- 2pts: Use of [AllowAnonymous] & [Authorize] used appropriatly
- 2pts: Claims correctly configured, and at least one policy configured and used
- 2pts: Readme included with answers to questions

