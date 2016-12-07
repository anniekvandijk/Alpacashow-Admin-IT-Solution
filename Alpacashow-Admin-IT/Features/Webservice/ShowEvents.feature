#language: nl-NL
Functionaliteit: Showevents CRUD
	
   Als gebruiker moet ik showevents kunnen 
   opvragen, toevoegen wijzigen en verwijderen
   Wanneer het opgevraagde event niet bestaat of er gaat wat fout
   Dan verwacht ik een duidelijke foutcode 

Achtergrond: Aanwezige showevents
	Stel de volgende showevents zijn aanwezig
   | naam        | datum      | sluitingsdatum | locatie | jury          | show                   |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |

Scenario: Opvragen van alle showevents
   Als ik alles opvraag via webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
	Dan verwacht ik de volgende showevents als resultaat
   | naam        | datum      | sluitingsdatum | locatie | jury          | show                   |
   | Boekel 2017 | 2017-06-01 | 2017-05-01     | Boekel  | judge X       | Haltershow             |
   | Assen 2017  | 2017-05-01 | 2017-04-01     | Assen   | Rob Bettinson | Haltershow, Fleeceshow |

Scenario: Opvragen van een specifiek showevent
   Als ik key 'Boekel 2017_2017-06-01' opvraag van webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200

Scenario: Nieuw showevent opvoeren
   Als ik onderstaande opstuur naar webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "2017-03-01",
  "closeDate": "2017-02-15",
  "location": "Test",
  "judge": "judge Y",
  "participants": [],
  "show": [
    {
      "showType": "Haltershow"
    }
  ]
}
   """
Dan verwacht ik een status 'OK' met code 200

Scenario: Bestaand showevent wijzigen
   Als ik onderstaande wijziging opstuur voor key 'Test 2017_2017-03-01' naar webservice 'showevents'
   """
{
  "name": "Test 2017",
  "date": "2017-03-01",
  "closeDate": "2017-02-15",
  "location": "Test wijziging locatie",
  "judge": "judge Y",
  "participants": [],
  "show": [
    {
      "showType": "Haltershow"
    }
  ]
}
   """
Dan verwacht ik een status 'OK' met code 200

Scenario: Bestaande showevent verwijderen
   Als ik een verwijderverzoek opstuur voor key 'Test 2017_2017-03-01' naar webservice 'showevents'
   Dan verwacht ik een status 'OK' met code 200
