use bdsenaitds
go
Create table Turno
(
 TURID int identity (1,1) primary key,
 TURDESCRICAO varchar (100)
 )
 go
 Create table PROFESSOR
 (
 PROFID int identity (1,1) primary key,
 PROFNOME varchar (100),
 TURID int
 )

 ALTER TABLE PROFESSOR 
 ADD FOREIGN KEY (TURID) REFERENCES Turno (TURID); 
 --DML- Linguagem de manipu��o de dados 
 --inserindo dados iniciais para teste --
 Select * from professor
 go
 Insert professor values ('REGINALDO',null)
 go
 Insert professor (PROFNOME) values ('Santana')
 go
 Insert Turno values ('Manh�')
 Insert Turno values ('Tarde')
 Insert Turno values ('Noite')
 Insert Turno values ('Manh�/Tarde')
 go
 select * from Turno
insert professor values ('REGINALDO', 3)