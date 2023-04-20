// See https://aka.ms/new-console-template for more information
using C__Shop_2;

Console.WriteLine("Hello, World!");

// DEFINISCO IL MIO SHOP

Shop alimentari1 = new Shop("Di tutto e di più", "Palermo", "Via Roma", 89, "Alimentare");

// DEFINISCO I PRODOTTI CHE IL MIO SHOP TRATTA
Prodotto insalata = new Prodotto("Insalata");
Prodotto pollo = new Prodotto("Pollo");

// DEFINISCO LE CATEGOIRE PER I MIEI PRODOTTO
Category verdura = new Category("Verdura", "Insalata verde");
Category carne = new Category("Carne", "Pollo allevato a terra");
Category bevanda = new Category("Acqua","Bottiglia frizzante");

// ASSOCIO I PRODOTTI CON LE LORO CATEGORIE
insalata.addCategory(verdura);
pollo.addCategory(carne);

alimentari1.addItem(insalata);
alimentari1.addItem(pollo);


/*Console.WriteLine(negozio.InfoShop());*/


Acqua acqua = new Acqua("Lete", 18, 5, "Napoli");
Console.WriteLine(acqua.GetLitri());

Console.WriteLine(acqua.GetLitri());

Console.WriteLine(acqua.GetLitri());

acqua.addCategory(bevanda);

alimentari1.addItem(acqua);
Console.WriteLine(alimentari1.InfoShop());
/*
Dalla classe Prodotto dello Shop,creare le sottoclassi opportune di  prodotti

    Acqua (massimo 1.5L)
    Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
    Elettrodomestico
    Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)

Per ognuno dei seguenti prodotti più specifici ( partiamo dai primi due intanto) vi si chiede di identificare quali potrebbero essere i loro attributi 
e metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi generici dalla classe Prodotto creata nell’esercizio precedente già definiva.
Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:

    attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
    attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
    attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
    ... ecc ecc
    metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
    metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
    metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
    metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo 
anche nella classe prodotto è si occupa di stampare il “codice - nome”,l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, 
anche la sua sorgente, il ph e i litri contenuti.

Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato dei vostri oggetti (ad esempio non posso bere più 
dei litri contenuti nella bottiglia, o non posso riempire più di tot litri una bottiglia!).
E così via per tutti gli altri elementi qui sopra riportati, provate a pensare attributi e metodi che potrebbero servire ai vostri 
prodotti specializzati Acqua, sacchetto di frutta a pezzi, elettrodomestici e cibo in scatola.Al solito usate opportunamente i livelli di
accesso (public, private, protected, internal ecc ecc), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità”.
Pensate anche se avete bisogno di eventuali override e overload di metodi come visto per Acqua.Una volta finite più o meno le
vostre classi ( o comunque le prime 2 intanto), nel Program.cs, provate a testare un pò i vostri prodotti specializzati, osservando come 
i metodi della classe generica prodotto e quelli più specifici vengono richiamati e 
siano disponibili nel vostro programma
*/

