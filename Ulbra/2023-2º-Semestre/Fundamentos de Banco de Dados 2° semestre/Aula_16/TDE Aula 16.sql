CREATE TABLE Professores(
    Id int not null primary key,
    Nome char(20),
    Especializacao char(20),
    Idade int
);

CREATE TABLE Disciplinas(
    Id_Disc int not null primary key,
    Disciplina char(15),
    Carga_Horaria int
);

CREATE TABLE Softwares(
    Id int not null primary key,
    Nome char(20),
    Tipo char(20)
);

CREATE TABLE Leciona (
    Id int not null primary key,
    Professor_Id int not null,
    Constraint Professor_ensina
        foreign key (Professor_Id) references Professores(Id),
    Disciplina_Id int not null,
    Constraint Disciplina_lecionada
        foreign key (Disciplina_Id) references Disciplinas(Id_Disc)
);

CREATE TABLE Utiliza(
    Id int not null primary key,
    Disciplina_Id int not null,
    Constraint Disciplina_utiliza_software
        foreign key (Disciplina_Id) references Disciplinas(Id_Disc),
    Software_Id int not null,
    Constraint Software_tem_disciplina
        foreign key (Software_Id) references Softwares(Id)
);