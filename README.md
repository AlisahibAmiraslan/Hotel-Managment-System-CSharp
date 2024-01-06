# HotelManagmentSystem

This project is developed with C# Winform. My first experience for reservation system. You can reserv rooms to database. You can also modify rooms, reservations and can check out rooms. Most amazing thing is you cannot book the same room for the same date. If you want you have to delete or check out first room. You can develop this project and I spend only 4 days for this project. I couldn't spend much time on this project due to other work. But Looks like it needs some improvement :))

# Create Database with Sql Server

My database is that

---- First create Database for example HotelManagmentSystem
---- second create tables for example CheckOutTbl, RegistrationTbl, RoomsTbl and UsersTbl

### CheckOutTbl is : 

CREATE TABLE [dbo].[CheckOutTbl] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [Phone]        VARCHAR (50) NOT NULL,
    [Country]      VARCHAR (50) NOT NULL,
    [PassportId]   VARCHAR (50) NOT NULL,
    [RoomNumber]   INT          NOT NULL,
    [CheckInTime]  DATETIME     NOT NULL,
    [CheckOutTime] DATETIME     NOT NULL,
    [RoomPrice]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

### RegistrationTbl is :
CREATE TABLE [dbo].[RegistrationTbl] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]        VARCHAR (50) NOT NULL,
    [LastName]         NCHAR (50)   NOT NULL,
    [Phone]            VARCHAR (50) NOT NULL,
    [Country]          VARCHAR (50) NOT NULL,
    [PassportId]       VARCHAR (50) NOT NULL,
    [RoomNumber]       INT          NOT NULL,
    [RoomAvailability] VARCHAR (50) NOT NULL,
    [CheckIn]          DATETIME     NOT NULL,
    [CheckOut]         DATETIME     NOT NULL,
    [RoomPrice]        INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

### RoomsTbl is :

CREATE TABLE [dbo].[RoomsTbl] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [RoomNumber]       INT          NOT NULL,
    [RoomAvailability] VARCHAR (50) NOT NULL,
    [RoomType]         NCHAR (50)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

### UsersTbl is :

CREATE TABLE [dbo].[UsersTbl] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

