            Etapas de uma modelagem
            
        Entidade = Objeto do mundo real 
        Relacionamento = ligação entre os objetos do mundo real
        Modelo Conceitual > Desenhar, Diagramar (ER)
            (ER) = Entidade [] e relacionamento -<>-
            
            ○ Atributo = Colunas do banco
            • Atributo identificador = primary key (pk) 
            
        []1,1  -<>-  1,n[]  > O lado que tem N recebe a chave primaria do outro lado do relacionamento e transforma PK(Primary key) em FK(Foreign Key)
            
        []1,n  -<>-  1,n[]  > Criamos mais uma tabela com uma chave PK, puxando as 2 PK das outras tabelas e transformando em FK.
            
        []1,1  -<>-  1,1[]  > Fazemos a fusão das 2 tabelas, juntando todos atributos em uma só tabela
            
        Modeo Lógico > Como vai funcionar e como deve funcionar.
            Entidade
            (Id int not null primary key).
            (Id_Entidade int not null)
            Constraint Entidade_Tem_Id
                Foreign Key (Id_Entidade) references Entidade (Id_Entidade)
            
            
            •○