

/*create table tbFornecedor(
codFornecedor int primary key identity (1,1),
nomeFantasia varchar (100) not null
)*/

create table tbProduto(
codProduto int primary key identity (1,1), 
descProduto varchar(100) not null, 
categoriaProduto varchar(100) not null,
valorUnit float not null
) 



create table tbUsuario(
codUsuario int primary key identity (1,1), 
nomeUsuario varchar (100) not null,
dataNascimento smalldatetime,
emailUsuario varchar(100) not null, 
loginUsuario varchar(100) not null, 
senhaUsuario varchar(100) not null 
)


select * from tbUsuario
/*	insert into tbFornecedor (nomeFantasia) values ('Brastemp')
	insert into tbFornecedor (nomeFantasia) values ('Ipê')
	insert into tbFornecedor (nomeFantasia) values ('Pepsico')
	insert into tbFornecedor (nomeFantasia) values ('Samsung')
	insert into tbFornecedor (nomeFantasia) values ('Natura')	*/

	select descProduto as Produto from tbProduto
