USE master
CREATE DATABASE VideoGame
GO
USE VideoGame
GO

CREATE TABLE Category(
	CategoryId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CategoryName VARCHAR(255) NOT NULL,
	
);
CREATE TABLE Games(
	GameId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId),
	GameName VARCHAR(255) NOT NULL,
	Description VARCHAR(max) NOT NULL,
	Manufacturer VARCHAR(255) NOT NULL,
	PublishYear INT NOT NULL,
	Price DECIMAL(10,2) NOT NULL,
	ESRB VARCHAR(20) NOT NULL,
	
);



CREATE TABLE Employees(
	EmployeeId INT NOT NULL IDENTITY(10000,1) PRIMARY KEY,
	FirstName VARCHAR(40) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATETIME NOT NULL,
	Sin VARCHAR(11) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	PostalCode VARCHAR(7) NOT NULL,
	City VARCHAR(20) NOT NULL,
	PhoneNumber VARCHAR(14) NOT NULL
);

CREATE TABLE Orders(
	OrderId INT NOT NULL PRIMARY KEY,
	OrderDate DATETIME NOT NULL,
	Subtotal DECIMAL(10,2) NOT NULL,
	Tax DECIMAL(10,2) NOT NULL,
	Total DECIMAL(10,2) NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(EmployeeId)
);

CREATE TABLE GameOrders(
	GameId INT FOREIGN KEY REFERENCES Games(GameId),
	OrderId INT FOREIGN KEY REFERENCES Orders(OrderId),
	UnitPrice DECIMAL(10,2) NOT NULL,
	Quantity INT NOT NULL
);

CREATE TABLE Login(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	EmployeeId INT UNIQUE FOREIGN KEY REFERENCES Employees(EmployeeId),
	Password VARCHAR(255) NOT NULL
);



INSERT INTO Employees(FirstName, LastName, DateOfBirth, Sin, Address, PostalCode, City, PhoneNumber)
VALUES('Minh', 'Hoang', '2000-07-21', '568-896-451', '23 Main Street', 'E3A A2S', 'Moncton', '(506) 451 1231')

INSERT INTO Login(EmployeeId, Password)
VALUES(10000, 'Pa$$w0rd')


Insert into Category
(CategoryName)
VALUES
('Battle royale'),
('Action-adventure'),
('First-person shooter'),
('Action role-playing, hack and slash'),
('Dungeon crawler, hack and slash'),
('Role-playing'),
('Battle royale, first-person shooter')




Insert into Games
([CategoryId],GameName, [Description], Manufacturer, PublishYear,Price,ESRB)
VALUES
(1,'Player Unknown''s Battlegrounds','a player versus player shooter game in which up to one hundred players fight in a battle royale, a type of large-scale last man standing deathmatch where players fight to remain the last alive. Players can choose to enter the match solo, duo, or with a small team of up to four people.','PUBG Corporation, PUBG Corporation (PC,PS4),Microsoft Studios (Xbox One), Tencent Games (mobile)',2016 ,29.99 ,'13+'),
(2,'Grand Theft Auto V','an action-adventure game played from either a third-person or first-person perspective. Players complete missions—linear scenarios with set objectives—to progress through the story. Outside of the missions, players may freely roam the open world.','Rockstar Games',2013, 19.99,'17+'),
(3,'DOOM Eternal','a first-person shooter video game developed by id Software and published by Bethesda Softworks. ... Set some time after the events of the 2016 game, the story follows the Doom Slayer once again, on a mission to end Hell''s consumption of Earth and foil the alien Maykrs plans to exterminate humanity.','Bethesda Softworks',2020, 79.99,'17+'),
(4,'Diablo III','a hack-and-slash action role-playing game developed and published by Blizzard Entertainment as the third installment in the Diablo franchise','Blizzard Entertainment', 2012, 49.99,'17+'),
(5,'Minecraft Dungeons,Standard Edition',' takes the relatable and fun parts of the dungeon crawler genre - such as hunting for treasure chests, looting decent weapons, and cooperating to defeat a boss -- and simplifies them. The game, which includes fantasy violence, is rated for players age 10 and older','Xbox Game Studios', 2020,19.99 ,'10+'),
(5,'Minecraft Dungeons,Hero Edition',' takes the relatable and fun parts of the dungeon crawler genre - such as hunting for treasure chests, looting decent weapons, and cooperating to defeat a boss -- and simplifies them. The game, which includes fantasy violence, is rated for players age 10 and older','Xbox Game Studios', 2020,29.99 ,'10+'),
(6,'Cyberpunk 2077','the next big RPG from Witcher 3 developer CD Projekt RED, a sprawling sci-fi story about hackers, seedy criminals, and warring corporations. Originally, Cyberpunk was supposed to have released by now, but CD Projekt delayed it back in January','CD Projekt',2020 ,79.99 ,'17+'),
(7,'Call of Duty: Modern Warfare','it has been reworked for gameplay to be more tactical and introduces new features, such as a Realism mode that removes the HUD as well as a form of the Ground War mode that now supports 64 players.','Activision', 2019,59.99 ,'17+'),
(2,'Grand Theft Auto: San Andreas','Five years ago Carl Johnson escaped from the pressures of life in Los Santos, San Andreas... a city tearing itself apart with gang trouble, drugs and corruption. Where filmstars and millionaires do their best to avoid the dealers and gangbangers.','Rockstar Games', 2004, 16.94,'18+'),
(2,'Luigi''s Mansion 3','an action-adventure game, in which players control the character of Luigi from a fixed third-person perspective, as they capture ghosts across a large hotel setting.','Nintendo', 2019,79.96 ,'all ages')




