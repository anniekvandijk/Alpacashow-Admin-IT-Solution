Feature: ShowEvents CRUD 
	
   As a user I have to get, post, put and delete showevents
   from the webservice
   so I can use them in a frontend application

Background: The showevents that are present
	Given the following showevents are present
   | name        | date       | closeDate  | location    | judge         | showType          | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       | Rob Bettinson | Fleeceshow        |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X       | Haltershow        |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z        | Male progeny show |              | 
         
Scenario: Get exact all showevents
   When i perform a 'GET' on webservice 'showevents'
   Then i expect status 'OK' with code 200
   And i expect exact the following result of showevents
   | name        | date       | closeDate  | location    | judge         | showType          | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       | Rob Bettinson | Fleeceshow        |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X       | Haltershow        |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z        | Male progeny show |              |

Scenario: Get specific showevent
   When i perform a 'GET' for 'Boekel 2017_2017-06-01' on webservice 'showevents'
   Then i expect status 'OK' with code 200
   And i expect exact the following result of showevents
   | name        | date       | closeDate  | location | judge   | showType   | participants |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel   | judge X | Haltershow |              |  

Scenario: Get all showevents but at least one with all values
   When i perform a 'GET' on webservice 'showevents'
   Then i expect status 'OK' with code 200
	And i expect at least the following result of showevents
   | name       | date       | closeDate  | location | judge         | showType   | participants |
   | Assen 2017 | 2017-05-01 | 2017-04-01 | Assen    | Rob Bettinson | Fleeceshow |              |    

Scenario: Get all showevents with specific value
   When i perform a 'GET' on webservice 'showevents'
   Then i expect status 'OK' with code 200
	And i expect exact the following specific results of showevents
   | name        | date       | closeDate  | location    |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie |

Scenario: Get all showevents but at least one with specific value
   When i perform a 'GET' on webservice 'showevents'
   Then i expect status 'OK' with code 200
	And i expect at least the following specific results of showevents
   | location | judge         | showType   | participants |
   | Assen    | Rob Bettinson | Fleeceshow |              |  

Scenario: Post new showevent
   When i perform a 'POST' on webservice 'showevents'
   """
{
  "name": "Hapert 2018",
  "date": "2018-02-12",
  "closeDate": "2018-01-10",
  "location": "Hapert",
  "judge": "judge bla",
  "showType": "Female progeny show"
}
   """
   Then i expect status 'OK' with code 200
   When i perform a 'GET' on webservice 'showevents'
	Then i expect exact the following result of showevents
   | name        | date       | closeDate  | location    | judge         | showType            | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       | Rob Bettinson | Fleeceshow          |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X       | Haltershow          |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z        | Male progeny show   |              |
   | Hapert 2018 | 2018-02-12 | 2018-01-10 | Hapert      | judge bla     | Female progeny show |              | 



Scenario: Change excisting showevent with table
   When i perform a 'PUT' for the following change on 'Test 2017_2017-03-01' to webservice 'showevents'
   | parameter | value      |
   | name      | Test 2017  |
   | date      | 2017-03-01 |
   | closeDate | 2017-02-15 |
   | location  | Teslocatie |
   | judge     | jury Z     |
   | showType  | Haltershow |
   Then i expect status 'OK' with code 200
   When i perform a 'GET' on webservice 'showevents'
	Then i expect exact the following result of showevents
   | name        | date       | closeDate  | location   | judge         | showType   | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen      | Rob Bettinson | Fleeceshow |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel     | judge X       | Haltershow |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Teslocatie | jury Z        | Haltershow |              | 

Scenario: Change excisting showevent with file
   When i perform a 'PUT' with file 'wijzigShowEvent' on 'Test 2017_2017-03-01' to webservice 'showevents'
   Then i expect status 'OK' with code 200
   When i perform a 'GET' on webservice 'showevents'
	Then i expect exact the following result of showevents
   | name        | date       | closeDate  | location | judge         | showType   | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen    | Rob Bettinson | Fleeceshow |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel   | judge X       | Haltershow |              |
   | Test 2017   | 2017-03-01 | 2017-01-15 | Test     | judge Y       | Haltershow |              |  

Scenario: Change excisting showevent with multiline text
   When i perform a 'PUT' for the following Json change on 'Test 2017_2017-03-01' to webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "2017-03-01",
  "closeDate": "2017-02-15",
  "location": "Test wijziging locatie",
  "judge": "judge Y",
  "participants": [],
  "showType":  "Haltershow"
}
   """
   Then i expect status 'OK' with code 200
   When i perform a 'GET' on webservice 'showevents'
	Then i expect exact the following result of showevents
   | name        | date       | closeDate  | location               | judge         | showType   | participants |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen                  | Rob Bettinson | Fleeceshow |              |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel                 | judge X       | Haltershow |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Test wijziging locatie | judge Y       | Haltershow |              |  

Scenario: Delete an existing showevent
   When i perform a 'DELETE'  on  'Assen 2017_2017-05-01' to webservice 'showevents'
   Then i expect status 'OK' with code 200
   When i perform a 'GET' on webservice 'showevents'
	Then i expect exact the following result of showevents
   | name        | date       | closeDate  | location    | judge   | showType          | participants |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X | Haltershow        |              |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z  | Male progeny show |              |

Scenario: Get not existing showevent
   When i perform a 'GET' for 'Boekel 2018_2017-06-01' on webservice 'showevents'
   Then i expect status 'Not Found' with code 404

Scenario: Change non existing excisting showevent
   When i perform a 'PUT' with file 'wijzigShowEvent' on 'Test 2018_2017-03-01' to webservice 'showevents'
   Then i expect status 'Not Found' with code 404

Scenario: Delete non existing showevent
   When i perform a 'DELETE'  on  'Breda 2017_2017-05-01' to webservice 'showevents'
   Then i expect status 'Not Found' with code 404
   
Scenario: Post showevent with non excisting showtype
   When i perform a 'POST' on webservice 'showevents'
   """
{
  "name": "Hapert 2018",
  "date": "2018-02-12",
  "closeDate": "2018-01-10",
  "location": "Hapert",
  "judge": "judge bla",
  "showType": "Junior handler"
}
   """
   Then i expect status 'Bad Request' with code 400

Scenario: Change excisting showevent with wrong date format
   When i perform a 'PUT' for the following Json change on 'Test 2017_2017-03-01' to webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "01-03-2017",
  "closeDate": "2017-02-15",
  "location": "Test wijziging locatie",
  "judge": "judge Y",
  "participants": [],
  "showType": "Haltershow"
}
   """
   Then i expect status 'Bad Request' with code 400