# Projet POO 20325 20194

Ce projet consiste en une realisation d'une simulation d'un reseau électrique. 



dossier repenant tous les documents lier au projet
## Diagrame de classe 
![diagrame](Documents/diagrame.png)


## Creation d’une nouvelle classe pour une centrale 

Dans le cas de la création d’une nouvelle Eolienne 
Premièrement il faut savoir que toutes les centrales sont reliées à la classe Centrale. Donc pour connaitre les différentes méthodes déjà utilisables il suffit de parcourir la classe Centrale, et dans le cas ou aucune méthode ne convient il faudra d’abord la crée dans la Classe centrale.  
Toutes les centrales ont une déclaration de base qui est similaire.
```csharp
public class Nom_centrale : Centrale  //classe pour créer/gérer une source d'énergie 
{
public double price;
   	public Nom_centrale (double max_prod, double co2, string name, Market market) : base(max_prod, co2, name)
       {
            this.price = market.Get_n_price();  //récupération du prix KWh du marché
        }
        public override double Get_prod() // production
        {
            return max_prod;
        }
        public override double Get_prix() // prix pour produire l'énergie nucléaire
        {
            return price * this.Get_prod();
        }
        public override double Get_co2() // CO2
        {
            return base.Get_co2();
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
```
Dans le cas d’une centrale nucléaire il n’y a pas besoin de plus, cependant si cette centrale est influencée par la météo, par exemple, il faudra rajouter des méthodes. 
1.	Le cas où la méthode existe déjà. 
Si la méthode est déjà présente dans la classe centrale il suffit simplement de la rajouter dans la nouvelle classe et de rajouter les paramètres qui y sont lier. 
Par exemple pour avoir une valeur de vent il faut rajouter la méthode Get_vent() pour cela il faut rajouter plusieurs chose. 
Une variable globale à la classe.
```csharp
Float wind = 0 ;
```
Ensuite dans la déclaration de la classe il faut rajouter l’appel de la classe Meteo car c’est a cette endroit la que l’on récupèrera notre variable de vent.  Puis il faut ajouter le methode Get_wind() de Meteo et l’assigner a notre variable globale crée plus tôt. Cela nous donne.
```csharp
public Nom_centrale (double max_prod, int co2, string name, Market market , Meteo meteo) : base(max_prod, co2, name)
        {

            this.wind = meteo.Get_wind();   //récupération de la vitesse du vent depuis la classe météo
            this.price = market.Get_e_price();  //récupération du prix KWh du marché
        }
```
Ensuite il nous suffit simplement de rajouter la methode Get_vent().
```csharp
public override float Get_vent(Meteo meteo)
{
            wind = meteo.Get_wind();
            return wind;
        }
```

