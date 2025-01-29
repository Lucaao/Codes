CREATE TABLE Produtos(
    Codigo int not null primary key,
    Descricao varchar(100),
    Data_Cadastro char(10),
    Valor_Unitario int,
    Codigo_Categoria int not null,
    Constraint Produto_tem_categoria
        Foreign key (Codigo_Categoria) references Categoria(Codigo)
);

CREATE TABLE Pede(
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

SELECT Descricao, Valor_unitario FROM Produtos
WHERE Codigo = 100