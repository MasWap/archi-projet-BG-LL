# Rapport de projet : API de gestion hôtelière en C# .NET 7

make by baptisteguillaume (@yso8) && lilianlayrac (@maswap)

## Introduction
Ce rapport présente l'architecture et les fonctionnalités d'une API de gestion hôtelière développée en C# .NET 7. L'objectif principal de cette API est de fournir une solution complète pour la gestion des réservations, des clients, des employés et des chambres d'un hôtel.

## Récupération et lancement de la solution

Pour récupérer et lancer la solution, suivez les étapes suivantes :

### 1. Récupération du code source : 
Récupérez le code source de l'API en clonant le dépôt Git associé ou en téléchargeant le code source compressé.

### 2. Installation des dépendances : 
Ouvrez le projet dans Visual Studio et restaurez les dépendances en utilisant NuGet Package Manager. Vous pouvez le faire en cliquant sur le menu "Projet" > "Gérer les paquets NuGet pour la solution..." > "Restaurer".

### 3. Configuration de la base de données : 
Configurez la connexion à la base de données SQL Server en modifiant les chaînes de connexion dans les fichiers "appsettings.json" et "appsettings.Development.json" situés dans le dossier "Utilities". Assurez-vous d'avoir une instance de SQL Server en cours d'exécution et accessible.

### 4. Migration de la base de données : 
Appliquez les migrations de la base de données en utilisant Entity Framework Core. Vous pouvez le faire en utilisant la Console du gestionnaire de paquets (PMC) en exécutant la commande "Update-Database".

### 5. Lancement de l'API : 
Démarrez l'API en appuyant sur le bouton "Démarrer" ou en appuyant sur "F5". L'API devrait maintenant être en cours d'exécution et accessible à l'adresse "https://localhost:5001" par défaut.

## Architecture de la solution
L'architecture de la solution est organisée de la manière suivante :

### 1. <b> GestionHotel.Apis </b> : Ce projet contient l'API principale et ses contrôleurs, services, références et configurations.

- <b> Connected Services </b> : Contient les références aux services externes utilisés par l'API.

- <b> Dépendances </b> : Contient les dépendances nécessaires au fonctionnement de l'API.

- <b> Properties </b> : Contient les propriétés et les configurations du projet.

- <b> Controllers </b> : Contient les contrôleurs de l'API, chacun étant responsable d'une partie spécifique de la gestion de l'hôtel.

  - <b> AuthentificationManagement </b> : Contrôleur responsable de l'authentification.
  - <b> BookingManagement </b> : Contrôleur responsable de la gestion des réservations.
  - <b> CustomerManagement </b> : Contrôleur responsable de la gestion des clients.
  - <b> EmployeeManagement </b> : Contrôleur responsable de la gestion des employés.
  - <b> RoomManagement </b> : Contrôleur responsable de la gestion des chambres.

- <b> Data </b> : Contient les configurations de la base de données et le contexte de la base de données.

   - <b> ModelConfiguration </b> : Contient les configurations des modèles de données.
   - <b> HotelDbContext.cs </b> : Contient le contexte de la base de données.

- <b> Domain </b> : Contient les modèles de données et les interfaces des services.

- <b> Filters </b> : Contient les filtres utilisés pour la sécurité et la validation des requêtes.

- <b> HTTPRequests </b> : Contient les requêtes HTTP utilisées pour la communication avec l'API.

- <b> Migrations </b> : Contient les migrations de la base de données.

- <b> Persistence </b> : Contient les interfaces des référentiels utilisés pour l'accès aux données.

- <b> Services </b> : Contient les implémentations des services utilisés pour la logique métier.

- <b> Utilities </b> : Contient les fichiers de configuration et les utilitaires.

## Modèles de données
L'API utilise quatre modèles de données principaux :

### 1. Booking : Représente une réservation. Il contient les informations suivantes :

<b> "Id" </b> : Identifiant unique de la réservation. 

<b> "RoomId" </b> : Identifiant de la chambre réservée. 

<b> "CustomerId" </b> : Identifiant du client ayant effectué la réservation. 

<b> "StartDate" </b> : Date de début de la réservation. 

<b> "EndDate" </b> : Date de fin de la réservation. 

<b> "PaymentMethod" </b> : Méthode de paiement utilisée. 

<b> "PaymentStatus" </b> : Statut du paiement. 

<b> "CancellationStatus" </b> : Statut de l'annulation. 

<b> "CancellationRefund" </b> : Indique si un remboursement a été effectué en cas d'annulation. 

### 2. Customer : Représente un client. Il contient les informations suivantes : 

<b> "Id" </b> : Identifiant unique du client.

<b> "FirstName" </b> : Prénom du client.

<b> "LastName" </b> : Nom du client.

<b> "Email" </b> : Adresse e-mail du client.

<b> "PhoneNumber" </b> : Numéro de téléphone du client.

### 3. Employee : Représente un employé. Il contient les informations suivantes :

<b> "Id" </b> : Identifiant unique de l'employé.

<b> "FirstName" </b> : Prénom de l'employé.

<b> "LastName" </b> : Nom de l'employé.

<b> "Role" </b> : Rôle de l'employé.

### 3. Room : Représente une chambre. Il contient les informations suivantes :

<b> "Id" </b> : Identifiant unique de la chambre.

<b> "Type" </b> : Type de la chambre.

<b> "Capacity" </b> : Capacité de la chambre.

<b> "Price" </b> : Prix de la chambre.

<b> "Status" </b> : Statut de la chambre.

## Base de données
L'API utilise Entity Framework Core pour générer et interagir avec une base de données SQL Server. Les configurations des modèles de données et le contexte de la base de données se trouvent dans le dossier Data.

## Interfaces des services
Les interfaces des services définissent les méthodes utilisées pour la logique métier de l'API.

Voici les interfaces des services principaux :

### 1. IBookingService : Contient les méthodes suivantes :

<b> GetBookings() </b> : Récupère toutes les réservations.

<b> GetBookingById(int id) </b> : Récupère une réservation par son identifiant.

<b> GetBookingsByCustomerId(int customerId) </b> : Récupère les réservations d'un client par son identifiant.

<b> GetBookingsByRoomId(int roomId) </b> : Récupère les réservations d'une chambre par son identifiant.

### 2. ICustomerService : Contient les méthodes suivantes :

<b> RemoveCustomer(Customer customer) </b> : Supprime un client.

<b> CreateCustomer(Customer customer) </b> : Crée un nouveau client.

<b> UpdateCustomer(Customer customer) </b> : Met à jour les informations d'un client.

<b> GetCustomerById(int id) </b> : Récupère un client par son identifiant.

### 3. IRoomService : Contient les méthodes suivantes :

<b> GetRoomById(int id) </b> : Récupère une chambre par son identifiant.

<b> GetAvailableRooms(DateTime startDate, DateTime endDate) </b> : Récupère les chambres disponibles entre deux dates.

<b> AddRoom(Room room) </b> : Ajoute une nouvelle chambre.

<b> UpdateRoom(Room room) </b> : Met à jour les informations d'une chambre.

<b> RemoveRoom(Room room) </b> : Supprime une chambre.

<b> RemoveRoomById(int id) </b> : Supprime une chambre par son identifiant.

### 4. IEmployeeService : Contient les méthodes suivantes :

<b> GetEmployeeById(int id) </b> : Récupère un employé par son identifiant.

<b> GetEmployeesByRole(string role) </b> : Récupère les employés en fonction de leur rôle.

## Conclusion

Ce rapport présente une vue d'ensemble de l'architecture et des fonctionnalités de l'API de gestion hôtelière développée en C# .NET 7. L'API fournit une solution complète pour la gestion des réservations, des clients, des employés et des chambres d'un hôtel. Elle utilise Entity Framework Core pour interagir avec une base de données SQL Server et implémente une architecture modulaire et évolutive.