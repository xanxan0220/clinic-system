CREATE TABLE Owners (
    OwnerID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50),   
    ContactNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    Gender NVARCHAR(10),
    Photo VARBINARY(MAX),
    DateRegistered DATETIME DEFAULT GETDATE()
);


CREATE TABLE Pets (
    PetID INT PRIMARY KEY IDENTITY(1,1),
    OwnerID INT FOREIGN KEY REFERENCES Owners(OwnerID),
    PetName NVARCHAR(100) NOT NULL,
    Species NVARCHAR(50),
    Breed NVARCHAR(100),
    Age INT,
    Gender NVARCHAR(10),
    Color NVARCHAR(50),
    BirthDate DATE,
    Photo VARBINARY(MAX),
    IsAdopted BIT DEFAULT 0,
    IsNeutered BIT DEFAULT 0,
    ExposureNotes NVARCHAR(MAX), 
    DateRegistered DATETIME DEFAULT GETDATE()
);

CREATE TABLE Vets (
    VetID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL,
    role NVARCHAR(100),
    Address NVARCHAR(255),
    ContactNumber NVARCHAR(20),
    Email NVARCHAR(100),
    DateJoined DATETIME DEFAULT GETDATE()
);
CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PetID INT FOREIGN KEY REFERENCES Pets(PetID),
    VetID INT FOREIGN KEY REFERENCES Vets(VetID),
    AppointmentDate DATETIME,
    Status NVARCHAR(50),          
    ServiceType NVARCHAR(100),
    Notes NVARCHAR(MAX),
    ActionDate DATETIME NULL,     
    ActionBy NVARCHAR(100) NULL,  
    DateBooked DATETIME DEFAULT GETDATE()
);
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    AppointmentID INT FOREIGN KEY REFERENCES Appointments(AppointmentID),
    Amount DECIMAL(10,2),
    PaymentMethod NVARCHAR(50),  -- Cash, Card, GCash, etc.
    Status NVARCHAR(50),         -- Paid, Pending, Failed
    PaymentDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE MembershipPlans (
    PlanID INT PRIMARY KEY IDENTITY(1,1),
    PlanName NVARCHAR(100) NOT NULL,      -- e.g., Basic, Premium, VIP
    Description NVARCHAR(255),
    PricePerMonth DECIMAL(10,2),
    DiscountRate DECIMAL(5,2),            -- e.g., 10 for 10%
    MaxPetsAllowed INT,
    IsActive BIT DEFAULT 1
);

CREATE TABLE OwnerMemberships (
    OwnerMembershipID INT PRIMARY KEY IDENTITY(1,1),
    OwnerID INT FOREIGN KEY REFERENCES Owners(OwnerID),
    PlanID INT FOREIGN KEY REFERENCES MembershipPlans(PlanID),
    StartDate DATE,
    EndDate DATE,
    Status NVARCHAR(50) -- Active, Expired, Canceled
);