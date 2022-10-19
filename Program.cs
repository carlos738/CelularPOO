using CelularPOO.Models;

Smartphone Nokia = new Nokia("3442141","N098",64,"LG");
Smartphone Iphone = new Iphone("32234444","12 pro", 128,"APPLE");

Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");
Nokia.MostrarNumero();
Nokia.MostrarMarca();
Nokia.Numero = "21332434235";
Nokia.MostrarNumero();

Iphone.InstalarAplicativo("facebook");
Iphone.ReceberLigacao();
Iphone.MostrarNumero();