# Design Patterns

Un **Design Pattern** est un schéma d'objets qui répond à des questions complexes. Chaque pattern inclut :

- **Nom**
- **Description**
- **Exemple UML**
- **Structure Générique du Pattern**
- **Cas d'Utilisation**
- **Exemple de Code (C#)**
- **Lien de Référence**

---

## Abstract Factory Pattern

### **But**
Créer des familles d’objets liés (par exemple, meubles : `Chaise`, `Sofa`, `TableBasse`) sans spécifier leurs classes concrètes.

### **Problème**
Garantir la cohérence entre objets (ex. meubles d’un même style) tout en permettant l’ajout de nouvelles variantes sans modifier le code existant.

### **Solution**

- **Produits Abstraits** : Interfaces pour chaque type d’objet (ex. `IChaise`, `ISofa`).
- **Produits Concrets** : Implémentations pour chaque style (ex. `ChaiseModerne`, `SofaVictorien`).
- **Fabrique Abstraite** : Interface définissant les méthodes de création.
- **Fabriques Concrètes** : Classes concrètes créant des produits spécifiques à une variante (ex. `FabriqueMeubleModerne`).

### **Avantages**

- **Cohérence** : Garantit l’harmonie entre objets liés.
- **Extensibilité** : Permet d’ajouter de nouvelles variantes facilement.

### **Inconvénients**

- **Complexité** : Augmente le nombre de classes nécessaires.
- **Rigidité** : Ajouter de nouveaux types de produits implique de modifier les interfaces existantes.

### **Exemple UML**

```
FabriqueAbstraite --------> ProduitAbstrait1
    |                          |
    |                          +--> ProduitConcret1
    |
    +--------> ProduitAbstrait2
                               |
                               +--> ProduitConcret2
```

### **Cas d'Utilisation**
Un simulateur de magasin de meubles peut utiliser une fabrique abstraite pour garantir des ensembles harmonieux (par exemple, `MeublesModernes` ou `MeublesVictoriens`).

### **Exemple de Code (C#)**

```csharp
// Interfaces pour les produits
public interface IChaise
{
    void AfficherDetails();
}

public interface ISofa
{
    void AfficherDetails();
}

// Implémentations concrètes des produits
public class ChaiseModerne : IChaise
{
    public void AfficherDetails()
    {
        Console.WriteLine("Chaise moderne");
    }
}

public class SofaVictorien : ISofa
{
    public void AfficherDetails()
    {
        Console.WriteLine("Sofa victorien");
    }
}

// Interface de la fabrique
public interface IFabriqueMeuble
{
    IChaise CreerChaise();
    ISofa CreerSofa();
}

// Fabrique concrète
public class FabriqueMeubleModerne : IFabriqueMeuble
{
    public IChaise CreerChaise()
    {
        return new ChaiseModerne();
    }

    public ISofa CreerSofa()
    {
        return new SofaVictorien();
    }
}

// Utilisation
class Program
{
    static void Main()
    {
        IFabriqueMeuble fabrique = new FabriqueMeubleModerne();
        IChaise chaise = fabrique.CreerChaise();
        ISofa sofa = fabrique.CreerSofa();

        chaise.AfficherDetails();
        sofa.AfficherDetails();
    }
}
```

### **Lien de Référence**
[Documentation sur le Pattern Abstract Factory](https://refactoring.guru/design-patterns/abstract-factory)

---

## Singleton Pattern

### **But**
Garantir qu'une classe n'a qu'une seule instance et fournir un point d'accès global à cette instance.

### **Problème**
Certaines ressources, comme une connexion à une base de données ou un gestionnaire de configuration, doivent être uniques pour éviter des incohérences ou des surcharges.

### **Solution**
1. **Constructeur privé** : Empêche la création directe d'instances depuis l'extérieur de la classe.
2. **Méthode statique** : Fournit un point d'accès global à l'instance unique.
3. **Instance statique** : Stocke l'unique instance de la classe.

### **Structure**
- **Classe Singleton** :
  - Attribut statique privé pour l'instance unique.
  - Constructeur privé.
  - Méthode publique et statique pour obtenir l'instance.

### **Avantages**
- **Contrôle d'accès** : Garantit un accès contrôlé à l'unique instance.
- **Économie de ressources** : Évite la création multiple d'objets coûteux.
- **Cohérence** : Assure un état global uniforme.

### **Inconvénients**
- **Testabilité réduite** : Difficile à tester en raison de l'état global.
- **Dépendances cachées** : Peut introduire des dépendances non évidentes.
- **Problèmes en environnement multithread** : Nécessite des précautions pour éviter des conditions de concurrence.

### **Exemple en PHP**

```php
class Singleton {
    private static $instance = null;

    private function __construct() {
        // Code d'initialisation
    }

    public static function getInstance() {
        if (self::$instance === null) {
            self::$instance = new Singleton();
        }
        return self::$instance;
    }
}
```

Dans cet exemple :
- Le constructeur est privé pour empêcher l'instanciation directe.
- La méthode `getInstance()` vérifie si l'instance existe déjà ; sinon, elle la crée.
- Cette méthode fournit un accès global à l'unique instance de la classe.

---

## Prototype Pattern

### **But**
Permettre la création de nouveaux objets en copiant un objet existant (prototype), sans passer par leur constructeur.

### **Problème**
Créer des objets coûteux ou complexes à initialiser à partir de zéro à chaque fois peut être inefficace ou non adapté. Certains objets nécessitent des configurations précises qui doivent être reproduites.

### **Solution**
1. **Prototype** : Déclarer une interface ou une méthode pour copier l’objet (`clone`).
2. **Implémentations concrètes** : Les classes implémentent la méthode de clonage pour retourner une copie de leurs instances.
3. **Client** : Utilise la méthode de clonage au lieu d’instancier directement un nouvel objet.

### **Structure**
- **Prototype** : Interface ou classe définissant une méthode `clone`.
- **Prototypes Concrets** : Classes implémentant la méthode `clone`.
- **Client** : Copie des objets en appelant `clone` sur des prototypes existants.

### **Avantages**
- **Réduction des coûts** : Évite de recréer des objets coûteux.
- **Flexibilité** : Permet de cloner des objets avec des états initiaux personnalisés.
- **Simplification** : Réduit la complexité associée à la création d'objets.

### **Inconvénients**
- **Complexité cachée** : La copie d’objets complexes peut nécessiter une attention particulière (copie superficielle ou profonde).
- **Maintenance accrue** : Chaque classe doit gérer correctement sa méthode de clonage.

### **Exemple en PHP**

```php
class Prototype {
    public $property;

    public function __clone() {
        // Implémentation de la copie profonde ou modifications spécifiques
    }
}

$original = new Prototype();
$original->property = "Valeur initiale";

$clone = clone $original;
$clone->property = "Valeur modifiée";

echo $original->property; // "Valeur initiale"
echo $clone->property;    // "Valeur modifiée"
```

Dans cet exemple :
- `__clone()` permet de personnaliser la copie de l’objet.
- Le client utilise l’opérateur `clone` pour copier un objet existant.
- Les propriétés modifiées après clonage sont indépendantes.

---

## Adapter Pattern

### **But**
Permettre à des objets avec des interfaces incompatibles de travailler ensemble en fournissant une interface intermédiaire (adaptateur).

### **Problème**
Un système existant nécessite d’intégrer des classes ou des services externes avec des interfaces différentes ou incompatibles.

### **Solution**
1. **Cible (Target)** : Interface que le client utilise ou attend.
2. **Adapté (Adaptee)** : Classe ou service existant avec une interface incompatible.
3. **Adaptateur (Adapter)** : Implémente la cible et traduit les appels entre le client et l’adapté.

### **Structure**
- **Client** : Code qui utilise la cible.
- **Cible (Target)** : Interface prévue.
- **Adapté (Adaptee)** : Interface incompatible.
- **Adaptateur (Adapter)** : Convertit les appels du client pour qu’ils soient compréhensibles par l’adapté.

### **Avantages**
- **Réutilisation** : Intègre des classes ou services existants sans modification.
- **Flexibilité** : Facilite la collaboration entre des systèmes avec des interfaces incompatibles.

### **Inconvénients**
- **Complexité ajoutée** : Ajoute une couche supplémentaire qui peut rendre le système plus difficile à comprendre et à maintenir.
- **Dépendance** : L’adaptateur dépend à la fois de la cible et de l’adapté.

### **Exemple en PHP**

```php
// Cible
interface Target {
    public function request(): string;
}

// Adapté
class Adaptee {
    public function specificRequest(): string {
        return "Réponse spécifique de l'adapté";
    }
}

// Adaptateur
class Adapter implements Target {
    private $adaptee;

    public function __construct(Adaptee $adaptee) {
        $this->adaptee = $adaptee;
    }

    public function request(): string {
        return $this->adaptee->specificRequest();
    }
}

// Utilisation
$adaptee = new Adaptee();
$adapter = new Adapter($adaptee);

echo $adapter->request(); // "Réponse spécifique de l'adapté"
```

Dans cet exemple :
- Le client interagit uniquement avec l’interface `Target`.
- L’`Adapter` traduit l’appel de `request()` en `specificRequest()` pour l’adapté.

---

## Bridge Pattern

### **But**
Séparer une abstraction de son implémentation afin qu'elles puissent évoluer indépendamment.

### **Problème**
Un système doit gérer des abstractions et des implémentations qui évoluent indépendamment, entraînant une multiplication des sous-classes si elles sont directement liées.

### **Solution**
1. **Abstraction** : Définit une interface ou une classe abstraite pour les fonctionnalités haut niveau.
2. **Implémentation** : Fournit une interface pour les implémentations spécifiques.
3. **Pont (Bridge)** : Associe l’abstraction à une implémentation via une composition.

### **Structure**
- **Abstraction** : Interface ou classe abstraite définissant les opérations de base.
- **Réfined Abstraction** : Extension de l’abstraction avec des comportements spécifiques.
- **Implémentation** : Interface pour les implémentations concrètes.
- **Implémentations concrètes** : Fournissent des comportements spécifiques à l’interface d’implémentation.

### **Avantages**
- **Évolutivité** : Les abstractions et implémentations peuvent être modifiées indépendamment.
- **Réduction de la complexité** : Diminue la multiplication des sous-classes.

### **Inconvénients**
- **Complexité accrue** : Nécessite des couches supplémentaires pour implémenter le pont.

### **Exemple en PHP**

```php
// Interface d'implémentation
interface Implementation {
    public function operationImplementation(): string;
}

// Implémentations concrètes
class ConcreteImplementationA implements Implementation {
    public function operationImplementation(): string {
        return "Implementation A";
    }
}

class ConcreteImplementationB implements Implementation {
    public function operationImplementation(): string {
        return "Implementation B";
    }
}

// Abstraction
abstract class Abstraction {
    protected $implementation;

    public function __construct(Implementation $implementation) {
        $this->implementation = $implementation;
    }

    abstract public function operation(): string;
}

// Réfined Abstraction
class ExtendedAbstraction extends Abstraction {
    public function operation(): string {
        return "ExtendedAbstraction: " . $this->implementation->operationImplementation();
    }
}

// Utilisation
$implementationA = new ConcreteImplementationA();
$abstractionA = new ExtendedAbstraction($implementationA);
echo $abstractionA->operation(); // "ExtendedAbstraction: Implementation A"

$implementationB = new ConcreteImplementationB();
$abstractionB = new ExtendedAbstraction($implementationB);
echo $abstractionB->operation(); // "ExtendedAbstraction: Implementation B"
```

Dans cet exemple :
- L’abstraction utilise la composition pour déléguer le travail à une implémentation.
- Les implémentations concrètes peuvent être modifiées ou étendues sans changer l’abstraction.

---