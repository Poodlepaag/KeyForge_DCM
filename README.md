Keyforge Deck Collection Manager
--------------------------------

There are several purposes with creating this application. First of the application will serve as a library that stores and organizes the information about the users owned
decks in this card game. The user can browse a list complete list of all it's decks or search by name or id. A second purpose is to create a fucntion that lets the user randomize two decks so that if the user has a guest who wants to play a game, they will both get random decks and in that way the best possible conditions for a fair game will be set.

It would also be nice if there was a way to keep track of how the user, with the use of as few decks as possible, can get a full set. This means that you have to break a number of decks to get all the cards in that set. Since all decks are randomized and they only contain 36 cards this makes up for a fun collecting game to even though thats not it's main intension.
--------------------------------

Road map / Plans
--------------------------------
// Version 1.0 //
* Add decks
* Remove decks
* Add cards to deck
* Remove cards from deck

// Version 1.1 //
* Randomize two decks
* Set favorite decks
* Set favorite cards 
--------------------------------

Database structure
--------------------------------
Microsoft SQL Databas
DB = KeyForgeDCM

Tables
Decks
* DeckID (PK)
* DeckName

Cards
* DeckID (FK)
* CardID
* CardName
* CardType
* CardText

Might add user details later in development
--------------------------------



ASP.NET RESTful API
Detta API hanterar kopplingen till databasen.


Client side
Till att börja med fungerar en console applikation men eftersom API används kan man skapa ett GUI i framtiden.
