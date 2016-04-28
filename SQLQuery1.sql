Create Table tblPackages(
 fldPackageID INT IDENTITY (1, 1) NOT NULL,
    fldPackageType VARCHAR (50)   NOT NULL,
    fldPackageCost DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([fldPackageID] ASC)
	);
	
Print 'tblPackages created';

Create Table tblCustomer(
CustomerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
CustomerName varchar(50) NOT NULL,
CustomerSSN varchar(10) NOT NULL,
CustomerEmail varchar(50) NOT NULL,
CustomerPhone varchar(50) NOT NULL,
CustomerActive bit);
Print 'tblCustomer created';

