-- Asmaa El Sayed
-- Create
---------------------------------------------
------------- Create Database -------------
Create database SemSem
use SemSem
------------- Create Tables -------------
---------------------------------
Create Table Employees
(
-- identity(start,step)
Id int primary key identity(1,1),
FName varchar(20) not null,
LName varchar(10) not null,
[Address] varchar(20) default 'Cairo',
Salary decimal(5,1),
Gender char(1),
BirthDate date,
DepartmentNumber int, -- not created
-- references --> take id in employee table 
Super_Id int references Employees(Id),
)
---------------------------------
Create Table Department
(
DNumber int primary key identity(1,1),
DName varchar(50) not null,
[Hiring Date] date,
ManagerId int not null unique,
  Constraint FK_Department_Employees
  foreign key ( ManagerId ) references Employees(Id)
)
---------------------------------
Create Table [ Department Loction ]
(
DNumber int references Department(DNumber),
[Location] varchar(30),
   -- coposite key 
   --(2 primary key as compsite key )
primary key(DNumber,[location])
)
---------------------------------
Create Table Projects
(
PNumber int primary key identity(1,1),
PName varchar(20) not null,
[Location] varchar(30),
City varchar(30),
DNumber int not null references Department(DNumber),
)
---------------------------------
Create Table [Dependent]
(
DName varchar(20) not null,
BirthDate date,
Gender char(1),
Emp_Id int references Employees(Id),
primary key (DName,Emp_Id)
)
---------------------------------
Create Table [Employee Projects]
(
Emp_Id int references Employees(Id),
ProjectNo int references Projects(PNumber),
Working_Hours int,
primary key (Emp_Id,Working_Hours)
)

-- Alter 
---------------------------------------------
------------- Alter Database -------------
Alter Database SemSem
Modify Name = SamSomaCompany
------------- Alter Tables ---------------
-------------------- Alter to Add

------ Add Columns 
Alter Table Employees 
Add NetSalary int 

------ Add Conatrains 
ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Department FOREIGN KEY (DepartmentNumber)
REFERENCES Department (DNumber);

------------------- Alter to Alter

------ Alter Columns DataTypes
ALTER TABLE Employees
Alter Column NetSalary Bigint

------------------- Alter to Drop 

------ Alter to Drop Columns 
Alter Table Employees
Drop Column NetSalary

------ Alter to Drop Constrains 

-- Drop 
---------------------------------------------
------------- Drop Tables -------------
Drop Table Employees

------------- Drop Database -------------
Drop database SamSomaCompany

