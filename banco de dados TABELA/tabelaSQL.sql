
use BdsTabela;
go
Create table Pessoa( 
  PESID int not null identity(1,1) primary key,
  NOME varchar (100) not null
  )
  go
Create table Tarefa( 
  TARID int not null identity(1,1) primary key,
  TARDESCRICAO varchar (200) not null,
  TARDATA datetime not null default getdate(),
  TARFEITO BIT not null default 0,
  PESID int not null,
  FOREIGN KEY (PESID) REFERENCES Pessoa(PESID)
  )

  --DML--
  Select * from pessoa
  Select * from tarefa

  Insert Pessoa values ('Menino Feio')
  Insert Pessoa values ('Menina Disney')
  Insert Tarefa values ('Dormir', '2022-06-01',1,1)
  Insert Tarefa (TARDESCRICAO,PESID) values ('Wake up',1)

  select t.*, p.NOME from tarefa t
  join pessoa p on t.PESID=p.PESID

  select p.nome, t.tardescricao, t.tardata, t.tarfeito
  from tarefa t join pessoa p on t.PESID=p.PESID

  select p.nome as 'Nome', t.tardescricao 'Tarefa',
  t.tardata 'Data', t.tarfeito 'Feito'
  from tarefa t join pessoa p on t.PESID=p.PESID


  Select * from tarefa
  WHERE tarid=2 or tarid=4

  Select * from tarefa
  WHERE tarid in(2,4)

  Delete from tarefa
  WHERE tarid in(2,4)

  Select * from Pessoa
  WHERE PESID=1 and PESID=2

  Delete from Pessoa
  WHERE PESID in(1,2)

  Select * from pessoa
  Select * from tarefa

  Insert Pessoa values ('Reginaldo')
  Insert Pessoa values ('David')
  Insert Pessoa values ('Marcus')
  Insert Tarefa values ('dar aula', '2022-06-01',1,1)
  Insert Tarefa values ('ver aula', '2022-06-01',1,1)
  Insert Tarefa values ('matar aula', '2022-06-01',1,1)

  Delete from tarefa
  WHERE PESID in(2,4)