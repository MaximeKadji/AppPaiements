﻿using AppPaiements;

CarteCredit achat1 = new CarteCredit(50.0, "Achat de livre", 123456789);
CarteCredit achat2 = new CarteCredit(150.0, "Achat de vêtements", 987654321);
CarteCredit achat3 = new CarteCredit(300.0, "Achat de téléphone", 586472159);

achat1.AfficherDetails();
achat2.AfficherDetails();
achat3.AfficherDetails();





Paypal paiement1 = new Paypal(35.7, "Achat en ligne", "example1@email.com");
Paypal paiement2 = new Paypal(91.3, "Service de streaming", "example2@email.com");


paiement1.AfficherDetails();
paiement2.AfficherDetails();




Utilisateur utilisateur = new Utilisateur("Maxime");


CarteCredit carteCredit = new CarteCredit(50.0, "Achat de livre", 123456789);
Paypal utilisateur1 = new Paypal(35.7, "Achat en ligne", "example1@email.com");
Paypal utilisateur2 = new Paypal(91.3, "Service de streaming", "example2@email.com");


utilisateur.AjouterPaiement(carteCredit);
utilisateur.AjouterPaiement(paiement1);
utilisateur.AjouterPaiement(paiement2);


utilisateur.AfficherInfos();
