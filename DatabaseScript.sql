-- EventEase Database Script for Part 1

CREATE DATABASE EventEaseDB;
GO

USE EventEaseDB;
GO

-- Venue Table
CREATE TABLE Venues (
    VenueID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Location NVARCHAR(200) NOT NULL,
    Capacity INT NOT NULL,
    ImageURL NVARCHAR(MAX) -- Placeholder for image URLs in Part 1
);

-- Event Table
CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    ImageURL NVARCHAR(MAX) -- Placeholder for image URLs in Part 1
);

-- Booking Table
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    VenueID INT NOT NULL,
    EventID INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) DEFAULT 'Confirmed',
    CONSTRAINT FK_Booking_Venue FOREIGN KEY (VenueID) REFERENCES Venues(VenueID),
    CONSTRAINT FK_Booking_Event FOREIGN KEY (EventID) REFERENCES Events(EventID)
);
GO
