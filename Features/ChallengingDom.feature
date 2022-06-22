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
   
Scenario: Verify Web page has three buttons
    Then three buttons should be visible on the webpage
    And the colour should be red,blue and green

Scenario: Verify that blue button is clickable and active
        When I navigate to the blue button and click
        Then the Blue ButtonID should change after clicking

Scenario: Verify that the three buttons are clickable
    When I click on the button
    Then I should see a the colors should change


Scenario: Verify that the button IDs change when red button is clicked
    Given I have clicked 'challenging DOM'
    And The buttons are present and IDs collected
    When The red button is clicked
    Then the blue, red and green button IDs also change

Scenario: Valid - Verify that edit is clickable
    When I click on edit
    Then I should redirected to edit page

#Scenario: Verify that the webpage has delete function

Scenario: Verify that the delete is clickable
    When I click on delete
    Then it should be clickable

Scenario: Verify that edit is not clickable
    When I click on edit 
    Then I should be not be redirected

#Scenario: Verify that the table has 7columns  and 10rows



    



