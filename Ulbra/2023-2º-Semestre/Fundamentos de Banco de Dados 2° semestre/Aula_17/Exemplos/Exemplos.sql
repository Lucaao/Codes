CREATE TABLE Clientes(
    Id int Not Null Primary key,
    Nome char(100)
);

CREATE TABLE Enderecos(
    Id int Not Null Primary Key,
    Logradouro varchar (100),
    Numero int,
    Bairro varchar (50),
    Cidade varchar(20),
    Estado char(2),
    Clientes_Id int Not Null,
    Constraint Clientes_tem_Enderecos
        Foreign Key (Clientes_Id) references Clientes(Id)
);

/* Alterando/adicionando colunas */
ALTER TABLE Enderecos add column Email varchar(50);

/* Apagando colunas */
ALTER TABLE Enderecos drop column Email;

/* Apagando o relacionamento/Constraint */
ALTER TABLE Enderecos drop
    Constraint Clientes_tem_Enderecos;

/* Adicionando novamente a chave estrangeira */
ALTER TABLE Enderecos 
    add Constraint Nova
    Foreign Key (Clientes_Id)
    references Clientes(Id);

/* Inserindo dados na tabela Clientes*/
INSERT INTO Clientes(Id, Nome) 
values (100, 'Mari')

/* Inserindo dados na tabela Clientes*/
INSERT INTO Clientes(Id, Nome) 
values (200, 'Lucas')

/* Inserindo dados na tabela Clientes*/
INSERT INTO Clientes(Id, Nome) 
values (300, 'Bruna')

/* Inserindo dados na tabela Enderecos*/
INSERT INTO Enderecos (Id, Logradouro, Numero, Bairro, Cidade, Estado, Clientes_Id)
values (100, 'Rua Julio de Castilhos', 365, 'Centro', 'Torres', 'RS', 200);

/* Inserindo dados na tabela Enderecos*/
INSERT INTO Enderecos (Id, Logradouro, Numero, Bairro, Cidade, Estado, Clientes_Id)
values (200, 'Rua das Tirivas', 36, 'Vila São João', 'Torres', 'RS', 100);

/* Select para poder visualizar os campos da tabela */
SELECT Id, Nome FROM Clientes

/* Select para visualizar a tabela toda */
SELECT * FROM Clientes

/* Atualizando dados/tipo de dado */
UPDATE Enderecos SET Numero = '369' WHERE Id = 100

/* Atualizando dados/tipo de dado */
UPDATE Clientes SET Nome = 'Lucao' WHERE Id = 200

/* INSERT, UPDATE E DELETE SÃO DML */

/* CREATE, ALTER E DROP SÃO DDL */