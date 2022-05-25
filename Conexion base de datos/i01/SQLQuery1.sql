use i01;
GO

create table personas(
id int identity primary key,
nombre varchar(100) NOT NULL,
apellido varchar(100) NOT NULL
)


insert into personas (nombre, apellido) values ('Port', 'Wiburn');
insert into personas (nombre, apellido) values ('Oralla', 'Bertram');
insert into personas (nombre, apellido) values ('Seumas', 'Quartley');
insert into personas (nombre, apellido) values ('Guilbert', 'Lawn');
insert into personas (nombre, apellido) values ('Cathi', 'Arnold');
insert into personas (nombre, apellido) values ('Jacquie', 'Egginton');
insert into personas (nombre, apellido) values ('Martino', 'Hallgarth');
insert into personas (nombre, apellido) values ('Pen', 'Narbett');
insert into personas (nombre, apellido) values ('Nerti', 'Kimmons');
insert into personas (nombre, apellido) values ('Geno', 'Guilloton');
insert into personas (nombre, apellido) values ('Malvin', 'Bosma');
insert into personas (nombre, apellido) values ('Larry', 'Aveling');
insert into personas (nombre, apellido) values ('Stephan', 'Reyes');
insert into personas (nombre, apellido) values ('Leland', 'Hammand');
insert into personas (nombre, apellido) values ('Gaile', 'Deedes');
insert into personas (nombre, apellido) values ('Rickard', 'Milward');
insert into personas (nombre, apellido) values ('Donn', 'Beamond');
insert into personas (nombre, apellido) values ('Odey', 'Phetteplace');
insert into personas (nombre, apellido) values ('Adore', 'Lafond');
insert into personas (nombre, apellido) values ('Allin', 'Sanday');


select * from personas