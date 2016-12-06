#language: nl-NL
Functionaliteit: Showevents CRUD
	
   Als gebruiker moet ik showevents kunnen 
   opvragen, toevoegen wijzigen en verwijderen
   Wanneer het opgevraagde event niet bestaat of er gaat wat fout
   Dan verwacht ik een duidelijke foutcode 

Scenario: Opvragen van alle showevents
	Stel de volgende 'showevents' zijn aanwezig
   | naam           | locatie | datum      | sluitingsdatum | jury   | shows      |
   | Show Leek 2016 | Leek    | 14-05-2016 | 31-03-2016     | Jury X | Haltershow |
   Als ik alle 'showevents' opvraag
	Dan verwacht ik de volgende 'showevents' als resultaat
   | naam           | locatie | datum      | sluitingsdatum | jury   | shows      |
   | Show Leek 2016 | Leek    | 14-05-2016 | 31-03-2016     | Jury X | Haltershow |
