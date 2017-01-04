#language:nl

Functionaliteit: Overzicht van alle showevents
	
	Als gebruiker wil ik een overzicht hebben van alle showevents
	zodat ik showevents kan wijzigen en verwijderen

Scenario: Toon alle aanwezige showevents
	Stel de volgende showevents zijn aanwezig
   | naam        | datum      | sluitdatum | locatie     | jury          | showtypen                     |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       | Rob Bettinson | Fleeceshow				     |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X       | Haltershow                    |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z        | Male progeny show             | 
   Als ik naar de pagina 'showevents' ga
   Dan verwacht ik de volgende showevents         
   | naam        | datum      | sluitdatum | locatie     | jury          | showtypen                     |
   | Assen 2017  | 2017-05-01 | 2017-04-01 | Assen       | Rob Bettinson | Fleeceshow				     |
   | Boekel 2017 | 2017-06-01 | 2017-05-01 | Boekel      | judge X       | Haltershow                    |
   | Test 2017   | 2017-03-01 | 2017-02-15 | Testlocatie | jury Z        | Male progeny show             | 