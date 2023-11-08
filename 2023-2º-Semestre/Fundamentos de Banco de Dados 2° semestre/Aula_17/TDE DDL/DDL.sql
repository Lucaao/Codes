CREATE TABLE Fornecedor(
    Codigo int not null primary key,
    Nome varchar(50)
);

CREATE TABLE Categoria(
    Codigo int not null primary key,
    Nome varchar(20)
);

CREATE TABLE Produtos(
    Codigo int not null primary key,
    Descricao varchar(100),
    Data_Cadastro char(10),
    Valor_Unitario int,
    Codigo_Categoria int not null,
    Constraint Produto_tem_categoria
        Foreign key (Codigo_Categoria) references Categoria(Codigo)
);

CREATE TABLE Pedido(
    Quantidade int not null primary key,
    Valor_Unitario int,
    Data_Pedido char(10),
    Codigo_Produto int not null,
    Codigo_Fornecedor int not null,
    Constraint Pedido_tem_produto
        Foreign key (Codigo_Produto) references Produtos(Codigo),
    Constraint Pedido_tem_fornecedor
        Foreign key (Codigo_Fornecedor) references Fornecedor(Codigo)
);

/* Inserts na tabela FORNECEDOR */
INSERT INTO Fornecedor (Codigo, Nome)
values (100, 'Valdecir')

INSERT INTO Fornecedor (Codigo, Nome)
values (200, 'Valmor')

INSERT INTO Fornecedor (Codigo, Nome)
values (300, 'Claudio')
/* Inserts na tabela FORNECEDOR */


/* Inserts na tabela CATEGORIA */
INSERT INTO Categoria (Codigo, Nome)
values (100, 'Eletrodomesticos')

INSERT INTO Categoria (Codigo, Nome)
values (200, 'Comida')

INSERT INTO Categoria (Codigo, Nome)
values (300, 'Ferramentas')
/* Inserts na tabela CATEGORIA */


/* Inserts na tabela Produtos */
INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (100, 'Ferramenta Phillips de precisão para uso profissional', '06/11/2023', 10, 300)

INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (200, 'Saco de Arroz parbolizado 1KG', '10/11/2023', 3, 200)

INSERT INTO Produtos(Codigo, Descricao, Data_Cadastro, Valor_Unitario, Codigo_Categoria)
values (300, 'Geladeira Brastemp PRETA COLD FREEZING', '12/11/2023', 2400, 100)
/* Inserts na tabela Produtos */


/* Inserts na tabela Pedido */
INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (10, 2400, '15/11/2023', 300, 300)

INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (25, 3, '23/11/2023', 200, 100)

INSERT INTO Pedido (Quantidade, Valor_Unitario, Data_Pedido, Codigo_Produto, Codigo_Fornecedor)
values (30, 10, '27/11/2023', 100, 200)
/* Inserts na tabela Pedido */

/* Comando para listar todos produtos cadastrados */
SELECT * FROM Produtos
/* Comando para listar todos produtos cadastrados */

/* Comando para consultar os pedidos feitos no mês de outubro */
SELECT Data_Pedido FROM Pedidos
WHERE CONTAINS (Data_Pedido,'10')
/* Comando para consultar os pedidos feitos no mês de outubro */

/* Comando para consultar os produtos que tem "palavra" no nome */
SELECT Descricao FROM Produtos
WHERE CONTAINS (Descricao, 'Palavra')
/* Comando para consultar os produtos que tem "palavra" no nome */