use carrosTesla;
go
Create table Veiculo( 
  CODIGO int not null identity(1,1) primary key,
  DESCRICAO varchar (200) not null,
  VALOR int not null,
  CODIGMODELO int not null
  )

  go
Create table Modelo( 
  ANO int not null,
  DESCRICAO varchar (200) not null,
  CODIGO int not null,
  FOREIGN KEY (CODIGO) REFERENCES Veiculo(CODIGO)
  )