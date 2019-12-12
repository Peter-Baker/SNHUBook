create database SNHUBook;

use SNHUBook;

create table Accounts(ID mediumint not null auto_increment, FirstName varchar(30) not null, LastName varchar(30) not null, Email varchar(100) not null, Password varchar(50) not null, profImage_Path varchar(1024) not null, backgroundImage_path varchar(1024) not null, Bio varchar(100), Home varchar(20), Primary Key(ID));

create table Posts(AccountID mediumint not null, ID int not null, value TEXT(1000), date varchar(10) not null, primary key (AccountID, ID), Foreign Key (AccountID) references accounts(ID) on delete cascade on update cascade);

create table Friends(AccountID mediumint not null, ID int not null, value varchar(50), primary key(AccountID, ID), Foreign Key (AccountID) references accounts(ID) on delete cascade on update cascade);