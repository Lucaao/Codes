/* Interface IReproduzível:
Desenvolva uma interface IReproduzível com métodos como Reproduzir, Pausar e Parar.
Implemente a interface em classes como TocadorDeMúsica e TocadorDeVídeo. */

TocadorDeMúsica TDM1 = new TocadorDeMúsica();
TDM1.Reproduzir("Já já chega dezembro");
TDM1.Pausar("Já já chega dezembro");
TDM1.Parar("Já já chega dezembro");

TocadorDeVideo TDV = new TocadorDeVideo();
TDV.Reproduzir("A corrida maluca #2");
TDV.Pausar("A corrida maluca #2");
TDV.Parar("A corrida maluca #2");