﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string courriel)
            : base(montant, description)
        {
            this.Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Paypal - Montant: {Montant}, Description: {Description}, Courriel: {Courriel}");
        }
    }
}
