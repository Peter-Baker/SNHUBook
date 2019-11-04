create database SNHUBook;

use SNHUBook;

create table Accounts(ID mediumint not null auto_increment, FirstName varchar(30) not null, LastName varchar(30) not null, Email varchar(100) not null, Password varchar(50) not null, profImage_Path varchar(1024) not null, backgroundImage_path varchar(1024) not null, Primary Key(ID));

