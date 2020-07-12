create database  gestion_livraison
use gestion_livraison

select idclpar,nom,prenom,dtn,adresse,tel,v.nom_ville,email,mdp from client_par c inner join ville v on  c.id_ville=v.id
select* from agence inner join livreur on agence.id_agence=livreur.id_agence


select * from client_par c inner join ville v on  c.id_ville = v.id

select * from client_par
select * from ville
create table ville
(
id int primary key identity(1,1	) , 
nom_ville varchar(20)
)

insert into ville values ('Aklim');
insert into ville values ('Ain Dorij');
insert into ville values ('Ain Jemaa');
insert into ville values ('Ait Benhaddou');
insert into ville values ('Ain Bni Mathar');
insert into ville values ('Ain Cheggag');
insert into ville values ('Ain Defali');
insert into ville values ('Ain El Aouda');
insert into ville values ('Ain Erreggada');
insert into ville values ('Ain Taoujdate');
insert into ville values ('Ait Boubidmane');
insert into ville values ('Ait Bouhlal');
insert into ville values ('Ait Daoud');
insert into ville values ('Ait Iaaza');
insert into ville values ('Ait Ourir');
insert into ville values ('Ajdir');
insert into ville values ('Al Aaroui');
insert into ville values ('Al-Hoceima');
insert into ville values ('Amalou Ighriben');
insert into ville values ('Amgala');
insert into ville values ('Amizmiz');
insert into ville values ('Aoufous');
insert into ville values ('Arbaoua');
insert into ville values ('Arfoud (Erfoud)');
insert into ville values ('Asilah');
insert into ville values ('Assahrij');
insert into ville values ('Bab Berred');
insert into ville values ('Bab Taza');
insert into ville values ('Ben Ahmed');
insert into ville values ('Beni Chiker');
insert into ville values ('Beni Ansar');
insert into ville values ('Beni Mellal');
insert into ville values ('Ben Slimane');
insert into ville values ('Ben Taieb');
insert into ville values ('Ben Yakhlef');
insert into ville values ('Berkane');
insert into ville values ('Berrechid');
insert into ville values ('Bhalil');
insert into ville values ('Bir GanBirdus');
insert into ville values ('Bir Lehlou');
insert into ville values ('Bni Bouayach');
insert into ville values ('Bni Drar');
insert into ville values ('Bni Hadifa');
insert into ville values ('Bni Tadjite');
insert into ville values ('Bouarfa');
insert into ville values ('Bou Craa');
insert into ville values ('Bouanane');
insert into ville values ('Boudnib');
insert into ville values ('Boufakrane');
insert into ville values ('Bouguedra');
insert into ville values ('Bouizakarne');
insert into ville values ('Boujad');
insert into ville values ('Boujdour');
insert into ville values ('Bouknadel');
insert into ville values ('Boulemane');
insert into ville values ('Bouskoura');
insert into ville values ('Bouznika');
insert into ville values ('Bradia');
insert into ville values ('Brikcha');
insert into ville values ('Casablanca');
insert into ville values ('Chefchaouen');
insert into ville values ('Chemaia');
insert into ville values ('Chichaoua');
insert into ville values ('Dakhla');
insert into ville values ('Dar Gueddari');
insert into ville values ('Dar Kebdani');
insert into ville values ('Demnate');
insert into ville values ('Douar Bel Aguide');
insert into ville values ('Driouch');
insert into ville values ('El Aioun Sidi Mellouk');
insert into ville values ('El Guerdane');
insert into ville values ('El Hajeb');
insert into ville values ('El Hanchane');
insert into ville values ('El Jadida');
insert into ville values ('Elkbab');
insert into ville values ('El Menzel');
insert into ville values ('El Ouatia');
insert into ville values ('Erfoud (o Arfoud)');
insert into ville values ('Errachidia (Ksar es-Souk)');
insert into ville values ('Essaouira ( Mogador)');
insert into ville values ('Farcia');
insert into ville values ('Fès');
insert into ville values ('Figuig');
insert into ville values ('Fnideq');
insert into ville values ('Fquih Ben Salah');
insert into ville values ('Er-Rich');
insert into ville values ('Guelmim');
insert into ville values ('Goulmima');
insert into ville values ('Guelta Zemmour');
insert into ville values ('Guerguerat');
insert into ville values ('Guisser');
insert into ville values ('Guercif');
insert into ville values ('Had Kourt');
insert into ville values ('Hagunia');
insert into ville values ('Haj Kaddour');
insert into ville values ('Harhoura');
insert into ville values ('Ihddaden');
insert into ville values ('Ifrane');
insert into ville values ('Imilchil');
insert into ville values ('Imilili');
insert into ville values ('Imintanoute');
insert into ville values ('Imouzzer Kandar');
insert into ville values ('Immouzer Marmoucha');
insert into ville values ('Inezgane');
insert into ville values ('jerada');
insert into ville values ('Jorf');
insert into ville values ('Jorf El Melha');
insert into ville values ('Jemâa Sahim');
insert into ville values ('Kassita');
insert into ville values ('Kattara');
insert into ville values ('Kénitra ( Port-Lyautey)');
insert into ville values ('Kehf Nsour');
insert into ville values ('Khémisset');
insert into ville values ('Khemis Sahel');
insert into ville values ('Khemis Zemamra (Doukkala)');
insert into ville values ('Khenichet');
insert into ville values ('Khénifra');
insert into ville values ('Khouribga');
insert into ville values ('Ksar el-Kébir');
insert into ville values ('Laayoune (El Aaiún)');
insert into ville values ('Lagouira ( Cabo Blanco)');
insert into ville values ('Lalla Mimouna');
insert into ville values ('Larache');
insert into ville values ('Lixus');
insert into ville values ('Lqliâa');
insert into ville values ('Madagh');
insert into ville values ('Riad Heritage');
insert into ville values ('Marrakech');
insert into ville values ('Martil');
insert into ville values ('Mechra Bel Ksiri');
insert into ville values ('Mediek');
insert into ville values ('Mediouna');
insert into ville values ('Mehdia');
insert into ville values ('Meknès');
insert into ville values ('Melloussa');
insert into ville values ('Midelt');
insert into ville values ('Mirleft');
insert into ville values ('Mohammédia ( Fédala)');
insert into ville values ('Moqrisset');
insert into ville values ('Moulay Ali Cherif');
insert into ville values ('Moulay Bousselham');
insert into ville values ('Moulay Idriss Zerhoun');
insert into ville values ('Mrirt');
insert into ville values ('nador');
insert into ville values ('nhima');
insert into ville values ('Ouarzazate');
insert into ville values ('Oualidia');
insert into ville values ('Ouezzane');
insert into ville values ('Oujda');
insert into ville values ('Oukaimeden');
insert into ville values ('Oulad Amrane');
insert into ville values ('Oulad Ayad');
insert into ville values ('Oulad Berhil');
insert into ville values ('Oulad Frej');
insert into ville values ('Oulad Ghadbane');
insert into ville values ('Oulad H Riz Sahel');
insert into ville values ('Oulad MRah');
insert into ville values ('Oulad M Barek');
insert into ville values ('Oulad Teïma');
insert into ville values ('Oulad Zbair');
insert into ville values ('Ouled Tayeb');
insert into ville values ('Ouled Youssef');
insert into ville values ('Oulmès');
insert into ville values ('Ounagha');
insert into ville values ('');
insert into ville values ('');
insert into ville values ('Rabat (Ribat al-Fath)Ras El Ain');
insert into ville values ('Ras El Ma');
insert into ville values ('Ribate El Kheir');
insert into ville values ('Rissani  Sijilmassa)');
insert into ville values ('Sabaa Aiyoun');
insert into ville values ('Safi');
insert into ville values ('Saidia');
insert into ville values ('Salé');
insert into ville values ('Sebt El Maârif');
insert into ville values ('Sebt Gzoula');
insert into ville values ('Sebt Jahjouh');
insert into ville values ('Sefrou');
insert into ville values ('Settat ( Chaouia )');
insert into ville values ('Sid Zouin');
insert into ville values ('Sidi Abdallah Ghiat');
insert into ville values ('Sidi Addi');
insert into ville values ('Sidi Ali Ban Hamdouche');
insert into ville values ('Sidi Allal El Bahraoui');
insert into ville values ('Sidi Allal Tazi');
insert into ville values ('Sidi Bou Othmane');
insert into ville values ('Sidi Boubker');
insert into ville values ('Sidi Jaber');
insert into ville values ('Sidi Kacem ( Chérarda )');
insert into ville values ('Sidi Lyamani');
insert into ville values ('Sidi Rahhal');
insert into ville values ('Sidi Slimane');
insert into ville values ('Sidi Smaïl');
insert into ville values ('Sidi Taibi');
insert into ville values ('Sidi Yahya el Gharb');
insert into ville values ('Skhirat');
insert into ville values ('Smara (Semara)');
insert into ville values ('Souq Larba al Gharb');
insert into ville values ('Taddert');
insert into ville values ('Tafetachte');
insert into ville values ('Tafrisset');
insert into ville values ('Taghjijt');
insert into ville values ('Tahala');
insert into ville values ('Tahannaout');
insert into ville values ('Tainaste');
insert into ville values ('Taliouine');
insert into ville values ('Talmest');
insert into ville values ('Talssint');
insert into ville values ('Tanger ( Tangerois )');
insert into ville values ('Tan-Tan');
insert into ville values ('Tamallalt');
insert into ville values ('Tamanar');
insert into ville values ('Tameslouht');
insert into ville values ('Taourirte');
insert into ville values ('Tarfaya (Cabo Juby)');
insert into ville values ('Taroudannt');
insert into ville values ('Tata');
insert into ville values ('Taza');
insert into ville values ('Taznakht');
insert into ville values ('Télouet');
insert into ville values ('Temara');
insert into ville values ('Temsia');
insert into ville values ('Tétouan');
insert into ville values ('Thar Es-Souk');
insert into ville values ('Tichla');
insert into ville values ('Tidass');
insert into ville values ('Tifariti');
insert into ville values ('Tiflet');
insert into ville values ('Tingdad');
insert into ville values ('Tinghir');
insert into ville values ('Tinmel');
insert into ville values ('Tiznit');
insert into ville values ('Tiztoutine');
insert into ville values ('Torres de Alcala');
insert into ville values ('Tifelt');
insert into ville values ('Volubilis ( Oualili)');
insert into ville values ('Youssoufia');
insert into ville values ('Zagora');
insert into ville values ('Zaio');



create  table superadmin
(
id int primary key not null identity(1,1),
fullname varchar(100)
email varchar(20),
mdp varchar(20)
)

insert into superadmin values('sohaibex','1234')


create table client_pro
(
id_clientpro int primary key identity(1,1) , 
nom varchar(20),
prenom varchar(20),
dtn date,
adresse varchar(30),
tel varchar(30) not null,
id_ville int foreign key references ville (id) not null,
mdp varchar(20),
commande_a_livrer varchar(100),
Tel_wtsp varchar(20),
nom_entreprise varchar(20),
site_web varchar(20),
email varchar(20),
secteur_activite varchar(20),
rc  varchar(20),
--rc pour les entreprise 
cin  varchar(20),
--//si il est un client pro mais il n apas de societe 
tp varchar(20), 
ice varchar(20)

)


insert into client_pro values ('ziad','ziad','12/12/2010','adresse','18238',1,'1234','book','19274','beekom','site web','email','secteur','rc','cin','tp','ice')

insert into client_pro values ('sohaib','el','12/12/2012','adresse','18238',2,'1234','play','19274','beekom','site web','email','secteur','rc','cin','tp','ice')
create  table client_par
(
idclpar int primary key  not null identity (1,1),
nom varchar(20),
prenom varchar(20),
dtn date,
adresse varchar(30),
tel varchar(30) not null,
id_ville int foreign key references ville (id) not null,
Email varchar(40),
mdp varchar(20),
commande_a_livrer varchar(100),
Tel_wtsp varchar(20)
)

insert into client_par values('jalil','heggour','12/12/2019','adr','07163',1,'email','mdp','pc','0283')
insert into client_par values('anass','salah','12/12/2019','adr','07163',1,'email','mdp','maneta','0283')




create table agence 
(
id_agence int primary key identity (1,1), 
nom varchar(20),
id_responsable int foreign key references responsable(id_responsable),
adresse varchar(30),
tel varchar(30),
id_ville int foreign key references ville (id) not null,
Email varchar(50),
mdp  varchar(100),
moyens float,
id_superadmin int foreign key references superadmin(id)
)

insert into agence values('beekom',1,'sidi yahya','0616091794',1,'SS','1234',12.5,1)
insert into agence values('algo',2,'sidi yahya','061609186',2,'SS','1234',20.5,1)

select * from agence


create table responsable
(
id_responsable int primary key identity(1,1) ,
nom_responsable varchar(20),
prenom_responsable varchar(20),
login_responsable varchar(20),
mdp_responsable varchar(20),
ville int foreign key references ville (id)
)

insert into responsable values ('sohaib','el mediouni','SS','1234',1)
insert into responsable values ('ziad','el mediouni','ZZ','1234',2)


create table livreur 
(
id_livreur int primary key identity(1,1),
nom_livreur varchar(20),
prenom_livreur varchar(20),
adresse varchar(100) , 
tel varchar(30) , 
email varchar(20) ,
mdp  varchar(20),
id_ville int  foreign key references ville(id),
vehicule varchar(20),
permis varchar(20) ,
id_agence int foreign key references agence (id_agence)
)

insert into livreur values('anass','idrissi','dfj','0717372','ff','1234',1,'MOTO','B',1)
insert into livreur values('oussim','banana','dfj','0717372','mm','1234',1,'MOTO','B',1)
insert into livreur values('amine','mouhidine','dfj','0717372','ll','1234',1,'MOTO','B',1)
insert into livreur values('ziad','el mediouni','dfj','0717372','uu','1234',2,'MOTO','B',2)

create table commande 
(
id_commande int primary key identity(1,1) , 
id_clientpar int foreign key references client_par (idclpar),
id_clientpro int foreign key references client_pro(id_clientpro),
categorie varchar(50),
produit varchar(30), 
date_saisie date,
date_livraison date, 
statue varchar(20),
ville_sortie varchar(20),
ville_ramassage varchar(20),
prix float , 
id_agence int foreign key references agence (id_agence),
id_livreur int foreign key references livreur (id_livreur)
)
select * from client_par

insert into commande values (2,1,'chi haja','pc','12/12/2020','12/12/2021','non livrer','OUJDA','100.50',1,1)