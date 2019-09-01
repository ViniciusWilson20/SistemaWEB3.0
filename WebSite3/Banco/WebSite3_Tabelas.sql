use bdWebSite3

create table tbUsuario(
idUsuario int identity (1,1),
nomeUsuario varchar (100) not null,
dataNascimento smalldatetime,
emailUsuario varchar (100) not null, 
loginUsuario varchar (100) not null,
senhaUsuario varchar (100) not null
)
-- alter table tbUsuario add primary key (idUsuario)
-- alter table tbUsuario alter column idUsuario int
-- alter table tbUsuario drop column idUsuario

create table tbProduto(
idProduto int identity(1,1),
descProduto varchar (100) not null,
categoriaProduto varchar(50) not null,
valorProduto float not null
)

-- alter table tbProduto add primary key (idProduto)



/*
create table tbPessoa(
nomePessoa varchar(100) not null, 
idUsuario int
) 

 -- alter table tbPessoa drop column idUsuario 
 -- alter table tbPessoa add idUsuario int constraint fk_pessoaUsuario foreign key (idUsuario) references tbUsuario (idUsuario)
 -- alter table tbPessoa add idUsuario int foreign key (idUsuario) references tbUsuario (idUsuario) 

*/

select * from tbProduto
select (categoriaProduto) from tbProduto 