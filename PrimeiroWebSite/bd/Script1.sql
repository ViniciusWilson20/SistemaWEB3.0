
create table tbUsuario (
idUsuario int primary key identity (1,1),
nomeUsuario varchar(100) not null,
dataNascimento smalldatetime,
emailUsuario varchar(100) not null, 
loginUsuario varchar (100) not null,
senhaUsuario varchar (100) not null
)