# Projet POO 20325 20194

Ce projet consiste en une realisation d'une simulation d'un reseau électrique. 



dossier repenant tous les documents lier au projet
## Diagrame de classe 
![diagrame](Documents/diagrame.png)



## Crée une nouvelle centrale 

Dans le fichier de classe update rajouter le nom à utilisé pour la centrale, dans la declaration des centrales(ligne 48); 
```csharp
Centrale e1, n1, a1;
```

definir un cout de production.
```csharp
Market market; 
```

Si cette centrale est influencer par la météo (vent, soleil, ...) crée aussi une nouvelle meteo, si le lieu est differents que celui ou ceux qui sont deja crée, 
```csharp
Meteo bruxelles;
```

Ensuite definir quel sont les parametres de la dite centrale, des couts de production et des parametres de meteo max à un endroit donner. 
```csharp
//exemple de creation d'une eolienne.
e1 = new Eolien(2000, 1, "e1", market, bruxelles); 
//puissance max de la centrale, co2 produit, nom de l'eolienne, couts de production, lieu ou est placer l'eolienne en question.

//exemple de creation d'une centrale nucleaire.
n1 = new Nucleaire(5000, 10, "n1", market);
//puissance max de la centrale, co2 produit, nom de l'eolienne, couts de production.

//exemple de creation de different couts.
market = new Market(10, 10, 10, 10); //nucleaire, eolienne, achat, vente

//exemple de creation d'une meteo a Bruxelles.
bruxelles = new Meteo(30, 30, 60); //wind, temp, sun
```

ensuite créé une ligne qui reliera la centrale au noeux.
```csharp
// a nouveau rajouter le nom de la ligne en parametre. 
Ligne l1, l2, l3, l4, l5, l6, l7, l8;

//puis lui donner des caractéristiques
l1 = new Ligne(2000, "l1"); //eolien vers prod
// puissance max de la ligne, nom de la ligne. 
```

si la centrale peut etre eteindre utiliser cette structure ci 
```csharp
if (status == true){
        double Eo1 = e1.Get_prod();
        Eo1 = l1.Ligne_in(Eo1);
        prod_tot += Eo1;
        if (Eo1 == 0)
        {
            erreurs += DateTime.Now.ToString();
            erreurs += errors.Line_Overload(l1);
            erreurs += "\n";
        }
        prix_eolien = e1.Get_prix();
        co2_eolien = e1.Get_co2();
        prod_eolien = Eo1;
}
else
{
        erreurs += DateTime.Now.ToString();
        erreurs += errors.Deactivate(e1);
        erreurs += "\n";
}
```

sinon
```csharp
double Nu1 = n1.Get_prod();
Nu1 = l2.Ligne_in(Nu1);
prod_tot += Nu1;
if (Nu1 == 0)
{
        erreurs += DateTime.Now.ToString();
        erreurs += errors.Line_Overload(l2);
        erreurs += "\n";
}
prix_nucleaire = n1.Get_prix();
co2_nucleaire = n1.Get_co2();
prod_nucleaire = Nu1;```
