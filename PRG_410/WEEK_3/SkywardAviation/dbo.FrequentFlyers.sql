CREATE TABLE [dbo].[FrequentFlyers] (
    [flyerID]      SMALLINT     IDENTITY (100, 1) NOT NULL,
    [last]         VARCHAR (50) NULL,
    [first]        VARCHAR (50) NULL,
    [phone]        VARCHAR (15) NULL,
    [email]        VARCHAR (50) NULL,
    [password]     VARCHAR (12) NULL,
    [cardType]     VARCHAR (50) NULL,
    [expireMonth]  VARCHAR (2)  NULL,
    [expireYear]   VARCHAR (4)  NULL,
    [cardNumber]   VARCHAR (50) NULL,
    [cardholder]   VARCHAR (50) NULL,
    [address]      VARCHAR (50) NULL,
    [city]         VARCHAR (50) NULL,
    [state]        VARCHAR (25) NULL,
    [zip]          VARCHAR (10) NULL,
    [travelerType] VARCHAR (20) NULL,
    [homeAirport]  VARCHAR (50) NULL,
    [class]        VARCHAR (50) NULL,
    [seat]         VARCHAR (10) NULL,
    [meal]         VARCHAR (15) NULL, 
    CONSTRAINT [PK_FrequentFlyers] PRIMARY KEY ([flyerID])
);

