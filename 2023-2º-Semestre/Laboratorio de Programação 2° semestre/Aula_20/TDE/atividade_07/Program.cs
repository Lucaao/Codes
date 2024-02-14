/* Armazenamento de Dados:
Defina uma interface IRepositórioDeDados com métodos como Salvar e Carregar.
Implemente a interface em classes como ArmazenamentoEmArquivo e ArmazenamentoEmBancoDeDados. */

ArmazenamentoBD ABD = new ArmazenamentoBD();
ABD.Salvar("Batata");
ABD.Carregar();

ArmazenamentoEmArquivos AEA = new ArmazenamentoEmArquivos();
AEA.Salvar("Pão");
AEA.Carregar();
