# Introduction

Bienvenue dans notre simulation de zoo ! Gérez votre parc animalier et développez-le au fil du temps.

## Fonctionnalités principales

**Gérer vos animaux et habitats**
- Achetez des animaux : poules, aigles et tigres
- Construisez des habitats adaptés à chaque espèce
- Achetez des graines et de la viande et nourrissez vos animaux pour qu'ils restent en bonne santé

**Développer votre zoo**
- Accumulez des revenus grâce aux visiteurs
- Ajoutez à vos bénéfices l'argent généré par la vente d'animaux, d'habitats ou de nourriture
- Augmentez progressivement la taille et la qualité de votre zoo

**Gérer le temps**
- Passez un mois pour faire un tour, ou passez l'année pour faire 12 tours d'un coup, et observez l'évolution de votre zoo
- Gérez les cycles de vie des animaux et leur reproduction

**Consulter vos statistiques**
- Suivez le nombre total d'habitats et d'animaux
- Consultez les détails de chaque animal (combien d'animaux, leur nom, leur âge, et comment s'en occuper en bas de la liste)
- Vérifiez votre solde bancaire et votre stock de nourriture pour ne pas manquer de donner à vos animaux, surtout quand vous passez une année entière!

**Evenements**
- Attention aux maladies qui peuvent infecter vos animaux et les empêcher de se reproduire
- Attention aux voleurs qui peuvent à tout moment vous voler n'importe quel animal de votre zoo!
- Attention aux feux qui peuvent brûler de manière aléatoire n'importe lequel de vos habitat
- Attention à votre viande qui peut pourrir et vous faire perdre du stock...
- Attention aux indésirables qui peuvent vous faire perdre pas mal de vos graines...

## Comment démarrer

1. Lancez le programme avec "dotnet run" dans la console
2. Explorez le menu principal pour acheter vos premiers animaux et habitats (choix a rentrer manuelleent en chiffre dans la console ou parfois on vous demandera d'écrire "yes" ou "no" pour répondre à la question)
3. Nourrissez régulièrement vos animaux
4. Passez les mois ou les années pour voir votre zoo se développer

Bonne partie!


## Côté dev

- Certaines fonctionnalités présentes sur le tableau ont été modifiées, des fois pour des raisons de mauvaise architecture, de difficulté ou par manque de temps. Cela-dit nous tenions a avoir le plus de fonctionnalités possible quitte à y laisser une partie de ces dernières.

- Nous avons pas mal bossé en Live Share ou présentiel directement

- Nous voulions une expérience de jeu un peu plus immersive que seulement une console et du texte blanc. C'est pourquoi nous avons décidé d'ajouter des SFX et de la musique de fond. Sur Linux, ce sytème fonctionne bien et sans latence. Nous avons quand même remarqué que sur Windows (10 et +) cela compile tout pareil mais les sons ont l'air d'avoir un peu de latence, sûrement à cause de l'utilisation de powershell pour jouer les sons en background.
