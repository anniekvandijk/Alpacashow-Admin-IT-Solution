#language: nl-NL
Functionaliteit: Showevents CRUD
	
   Als gebruiker moet ik showevents kunnen 
   opvragen, toevoegen wijzigen en verwijderen
   Wanneer het opgevraagde event niet bestaat of er gaat wat fout
   Dan verwacht ik een duidelijke foutcode 

Achtergrond: Aanwezige showevents
	Stel de volgende showevents zijn aanwezig
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            |  
         
Scenario: Opvragen van exact alle showevents
   Als ik alles opvraag via webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
	En verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            |  
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |            |

  
Scenario: Opvragen van een specifiek showevent
   Als ik 'Boekel 2017_2017-06-01' opvraag van webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
   En verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            |  

Scenario: Nieuw showevent opvoeren
   Als ik onderstaande opstuur naar webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "2017-03-01",
  "closeDate": "2017-02-15",
  "location": "Test",
  "judge": "judge Y",
  "shows": [
    {
      "showType": "Male progeny show"
    }
  ]
}
   """
   Dan verwacht ik een status 'OK' met code 200
   Als ik alles opvraag via webservice 'showevents'
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            | 
   | Test 2017   | 2017-03-01 | 2017-02-15     | Test    | judge Y       | Male progeny show      |            |   

Scenario: Opvragen van alle showevents
   Als ik alles opvraag via webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
	En verwacht ik in ieder geval de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Test 2017   | 2017-03-01 | 2017-02-15     | Test    | judge Y       | Male progeny show      |            |   
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |            |
#  | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            |        

Scenario: Bestaand showevent wijzigen met tabel
   Als ik onderstaande wijziging stuur voor 'Test 2017_2017-03-01' naar webservice 'showevents'
   | parameter      | value             |
   | name           | Test 2017         |
   | date           | 2017-03-01        |
   | closeDate      | 2017-02-15        |
   | location       | Teslocatie        |
   | judge          | jury Z            |
   | shows.showType | Haltershow        |
   | shows.showType | Male progeny show |
   Dan verwacht ik een status 'OK' met code 200
   Als ik alles opvraag via webservice 'showevents'
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie     | jury          | shows                         | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen       | Rob Bettinson | Haltershow, Fleeceshow        |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel      | judge X       | Haltershow                    |            |
   | Test 2017   | 2017-03-01 | 2017-02-15     | Teslocatie  | jury Z        | Haltershow, Male progeny show |            |  


Scenario: Bestaand showevent wijzigen met file
   Als ik 'wijzigShowEvent' als wijziging stuur voor 'Test 2017_2017-03-01' naar webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
   Als ik alles opvraag via webservice 'showevents'
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie     | jury          | shows                         | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen       | Rob Bettinson | Haltershow, Fleeceshow        |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel      | judge X       | Haltershow                    |            |
   | Test 2017   | 2017-03-01 | 2017-01-15     | Test        | judge Y       | Haltershow                    |            |  

Scenario: Bestaand showevent wijzigen met multiline text
   Als ik onderstaande wijziging opstuur voor 'Test 2017_2017-03-01' naar webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "2017-03-01",
  "closeDate": "2017-02-15",
  "location": "Test wijziging locatie",
  "judge": "judge Y",
  "participants": [],
  "shows": [
    {
      "showType": "Haltershow"
    }
  ]
}
   """
   Dan verwacht ik een status 'OK' met code 200
   Als ik alles opvraag via webservice 'showevents'
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie                | jury          | shows                  | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen                  | Rob Bettinson | Haltershow, Fleeceshow |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel                 | judge X       | Haltershow             |            |
   | Test 2017   | 2017-03-01 | 2017-02-15     | Test wijziging locatie | judge Y       | Haltershow             |            |  

Scenario: Bestaande showevent verwijderen
   Als ik een verwijderverzoek opstuur voor 'Test 2017_2017-03-01' naar webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
   Als ik alles opvraag via webservice 'showevents'
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | shows                  | deelnemers |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |            |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |            | 

   