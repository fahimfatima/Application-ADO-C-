--creation base de donnee
create database PROJET_INVONTAIRE_LP
use PROJET_INVONTAIRE_LP
--creation des tables
--*****************Table Compte***************--
create table Compte(num_compte int primary key identity,
					nom varchar(50),
					prenom varchar(50),
                    email varchar(50),
				    mot_passe varchar(50),
				    confirmer_passe varchar(50),
					date_creation date
				   )

select *from Compte

--*****************Table Marque***************--
create table Marque(reference varchar(50) primary key,
					Marque varchar(50),
					Model varchar(50) 
				   )

select *from Marque

--*****************Table Catégorie***************--
create table Catégorie(code_Catégorie varchar(50) primary key,
					nom_Catégorie varchar(50)
				   )

select *from Catégorie

--*****************Table Founisseur***************--
create table Founisseur(code_fer varchar(50) primary key,
					Nom_fer varchar(50),
					Prénom_fer varchar(50),
					Civillite varchar(50),
					Telephone int,
                    Adresse varchar(50))
select *from Founisseur

--*****************Table achat***************--
create table Achat(reference varchar(50) primary key,
					  date_Achat date,
					  code_barre varchar(50) foreign key references Article(code_barre),
					  article varchar(50),
					  marque varchar(50),
					  code_founisseur varchar(50) foreign key references Founisseur(code_fer),
					  prixunitare int,
					  quantite int,
					  num_bin_livrision varchar(50),
					  num_facture varchar(50),
					  montant int,
					  observation varchar(50))
select *from Achat
select Founisseur.code_fer,Founisseur.Nom_fer,Founisseur.Prénom_fer,sum(quantite)as'Qté achat du Founisseur'from Founisseur inner join Achat on Achat.code_founisseur=Founisseur.code_fer
group by Founisseur.code_fer,Founisseur.Nom_fer,Founisseur.Prénom_fer
--*****************Table Technicien***************--
create table Technicien(code_tech varchar(50) primary key,
					Nom_tech varchar(50),
					Prénom_tech varchar(50),
					Civillite varchar(50),
					Telephone int,
                    Adresse varchar(50)
					)
select Technicien.*from Technicien
select Nom_tech,Prénom_tech from Technicien


--*****************Table Commande***************--
create table Commande(reference varchar(50) primary key,
					  date_commande date,
					  code_barre varchar(50) foreign key references Article(code_barre),
					  article varchar(50),
					  marque varchar(50),
					  code_technicien varchar(50) foreign key references Technicien(code_tech),
					  prixunitare int,
					  quantite int,
					  montant int,
					  observation varchar(50))
select *from Commande

select Commande.quantite*Article.TTC from Commande inner join Article on Commande.article=Article.code_barre

select Technicien.code_tech,Technicien.Nom_tech,Technicien.Prénom_tech,sum(quantite)as'Qté commande du technicien'
from Technicien inner join Commande on Technicien.code_tech=Commande.code_technicien
group by Technicien.code_tech,Technicien.Nom_tech,Technicien.Prénom_tech

--*****************Table Article***************--
create table Article(code_barre varchar(50) primary key,
					libelle varchar(50),
					prix_unitaire int,
                    TVA int,
				    TTC int,
				    nom_Catégorie varchar(50),
					marque varchar(50),
					model varchar(50),
					Garantie int ,
					Observation varchar(50),
					Description varchar(50))
select *from Article
delete from Article
/*SELECT COUNT(libelle) from Article where libelle='pc' and marque='old'*/
--*****************Table Stock***************--
create table Stock(code_barre varchar(50) foreign key references Article(code_barre),
					reference_commande varchar(50) foreign key references Commande(reference),
					reference_Achat varchar(50) foreign key references Achat(reference))
			

select  Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie, SUM( Commande.quantite) as'quantite Commande' 
from  Article inner join Commande on Article.code_barre=Commande.code_barre
group by Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie
			
select  Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie,SUM( Achat.quantite) as'quantite achat'  
from  Article inner join Achat on Article.code_barre=Achat.code_barre
group by Article.code_barre,Article.libelle,Article.marque,Article.model,Article.nom_Catégorie
			