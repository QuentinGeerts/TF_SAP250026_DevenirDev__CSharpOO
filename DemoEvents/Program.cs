using DemoEvents.Models;

Displayer displayer = new Displayer();
Counter counter = new Counter(10);


// Abonnement de la méthode d'affichage
counter.ThresholdReached += displayer.DisplayCounter;

// Incrémentation pour atteindre la valeur
counter.Increment(5);
counter.Increment(5); // Affichage de la valeur du seuil

// Désabonnement de la méthode d'affichage
counter.ThresholdReached -= displayer.DisplayCounter;

// counter.ThresholdReached.Invoke(12, 10); // Impossible de le déclencher depuis l'extérieure de la classe où il a été déclaré

counter.Increment(5);