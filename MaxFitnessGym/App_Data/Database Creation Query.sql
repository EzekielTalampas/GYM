DROP TABLE IF EXISTS Transactions;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Subscription;

CREATE TABLE Customer(
	ID INT NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100),
	PhoneNumber BIGINT
);

CREATE TABLE Subscription(
	ID INT NOT NULL PRIMARY KEY,
	SubscriptionName NVARCHAR(100) NOT NULL,
	Payment MONEY NOT NULL,
	Duration INT NOT NULL
);

CREATE TABLE Transactions(
	ID NVARCHAR(5) NOT NULL PRIMARY KEY,
	Customer INT NOT NULL,
	Subscription INT NOT NULL,
	DateOfPurchase DATE NOT NULL,
	FOREIGN KEY (Customer) REFERENCES Customer(ID),
	FOREIGN KEY (Subscription) REFERENCES Subscription(ID)
);

INSERT INTO Customer(ID, FirstName, LastName, PhoneNumber) VALUES
	(0001, 'Dummy Account', 'LastName', 0284410396),
	(0002, 'Angelo Justine', 'Kamachi', 0919686606);