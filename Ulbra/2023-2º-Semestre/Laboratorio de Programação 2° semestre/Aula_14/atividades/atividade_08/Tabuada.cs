class Tabuada {
    public int numeroBase;
    public void imprimirTabuada(){
        for(int i = 0; i<=10; i++){
            int tabuada = numeroBase * i;
            Console.WriteLine($"O número {numeroBase} * {i} é = {tabuada}.");
        }
    }
}