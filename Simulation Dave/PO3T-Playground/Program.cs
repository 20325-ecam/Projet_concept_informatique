﻿using System;
using System.Collections.Generic;
using System.Threading;//dave delay

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{

			double prod_tot = 0;
			double conso_tot = 0;
			double trou_energie = 0; // si + -> manque E ; si + -> surplus E
			double abs_trou = 0;

			//création des consommateurs et producteurs
			Centrale e1 = new Eolien(6000);
			Centrale n1 = new Nucléaire(20000);
			Consommateur ville = new Consommateur_random(1000);
			Consommateur entreprise = new Consommateur_statique(8000);

			//ensemble des producteurs
			List<Centrale> centrales = new List<Centrale>();
			centrales.Add(e1);
			centrales.Add(n1);
			foreach (var centrale in centrales)
            {
				prod_tot += centrale.Get_prod();
            }
			Console.WriteLine("prod est de " + prod_tot +" W");

			//ensemble des consommateurs
			List<Consommateur> consommateurs = new List<Consommateur>();
			consommateurs.Add(ville);
			consommateurs.Add(entreprise);
			foreach (var consommateur in consommateurs)
			{
				conso_tot += consommateur.Get_conso();
			}
			Console.WriteLine("conso est de " + conso_tot+ " W");

			//Gestion manque & surplus E
			trou_energie = conso_tot - prod_tot;
			abs_trou = Math.Abs(trou_energie);
			Console.WriteLine("trou est de " + trou_energie + " W");
			if (trou_energie > 0)
            {
				Console.WriteLine("il manque "+ abs_trou + " W");
			}
			else if (trou_energie < 0)
            {
				Console.WriteLine("il y a en trop "+ abs_trou + " W");				
			}



		}
	}
}