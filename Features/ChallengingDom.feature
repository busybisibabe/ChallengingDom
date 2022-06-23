Feature: Challenging Dom
As a user of https://the-internet.herokuapp.com/challenging_dom
I want to locate the element
so that I can automate the functionalities

Background: 
    Given that I navigate to "https://the-internet.herokuapp.com/challenging_dom"
    When the user is on the landing page

@testcase1
Scenario: Valid - Verify the URL direct user to Challenging DOM webpage
    Then I verify that Challenging DOM is displayed as the Web Page Title


@testcase2
Scenario: Valid - Verify that edit is clickable
    When I click on edit
    Then I should redirected to edit page

@testcase3
Scenario: Invalid - Verify that the edit is not clickable
    When I click on delete
    Then it should  be not clickable

@testcase4
Scenario: Valid - Verify that the delete is clickable
    When I click on delete
    Then it should be clickable

@testcase5
Scenario: Invalid - Verify that the delete is not clickable
    When I click on delete
    Then it should  be not clickable

@testcase6
Scenario: Verify Web page has three buttons
    Then three buttons should be visible on the webpage
    And the colour should be red,blue and green

@testcase7
Scenario: Valid - Verify that the table has 10rows
    When I count the numbers of rows
    Then I should see ten rows on the table
  
@testcase8
Scenario: Valid - Verify that the table has 7column
    When I count the numbers of column
    Then I should see seven column on the table

@testcase9
Scenario: Invalid - Verify that the table has no column
    When I count the numbers of column
    Then I should see seven column on the table


