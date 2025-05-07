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
    PetPhoto VARBINARY(MAX), 
    IsAdopted BIT DEFAULT 0, 
    IsNeutered BIT DEFAULT 0,
    Exposure NVARCHAR(MAX),
    DateRegistered DATETIME DEFAULT GETDATE()
);
