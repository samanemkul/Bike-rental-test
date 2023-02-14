create table clients_details(
FirstName varchar(255),
MiddleName varchar(255),
LastName varchar(255),
CompleteAddress varchar(255),
ContactNumber varchar(15),
EmailAddress varchar(255),
Gender varchar(255),
CivilStatus varchar(255),
Birthdate nvarchar,
Age varchar(255),
Username varchar(255),
Password varchar(255),
AccountStatus varchar(255),
);

use Petrolbikes
go
alter table clients_details drop column Birthdate;

ALTER TABLE clients_details
ADD Birthdate nvarchar(255);