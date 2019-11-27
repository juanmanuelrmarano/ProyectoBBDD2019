CREATE TABLE cliente (
N_Clie int,
Nombre_Apellido varchar(30),
Direccion varchar(30),
Tel varchar(30),
E_Mail varchar(30),
constraint pk_cliente primary key (N_Clie)
);

CREATE TABLE destino (
ID_Dest int,
Nombre_Localidad varchar(30),
Plazas int,
constraint pk_destino primary key (ID_Dest)
);

CREATE TABLE transporte (
ID_Trans int,
Medio varchar(30),
ID_Dest int,
Descripcion varchar(70),
Empresa varchar(30),
Precio int,
Plazas int,
constraint pk_transporte primary key (ID_Trans),
constraint fk_transporte_destino foreign key (ID_Dest) references destino(ID_Dest)
);

CREATE TABLE excursion (
ID_Excur int,
ID_Dest int,
Actividad varchar(30),
Duracion varchar(30),
Precio int,
Plazas int,
Fecha_Realizacion date,
constraint pk_excursion primary key (ID_Excur),
constraint fk_excursion_destino foreign key (ID_Dest) references destino(ID_Dest)
);

CREATE TABLE hotel (
ID_Hotel int,
Nombre varchar(30),
Tipo_Hotel varchar(30),
ID_Dest int,
Precio int,
Plazas int,
Categoria int,
Descripcion varchar(70),
constraint pk_hotel primary key (ID_hotel),
constraint fk_hotel foreign key (ID_Dest) references destino(ID_Dest)
);

CREATE TABLE paquete (
ID_Paq int,
ID_Dest int,
ID_Hotel int,
ID_Transp int,
Fecha_Sal date,
Fecha_Llegada date,
constraint pk_paquete primary key (ID_Paq),
constraint fk_paquete_destino foreign key (ID_Dest) references destino(ID_Dest),
constraint fk_paquete_hotel foreign key (ID_Hotel) references hotel(ID_Hotel),
constraint fk_paquete_transporte foreign key (ID_Transp) references transporte(ID_Trans)
);

CREATE TABLE paq_exc(
ID int,
ID_Paq int,
ID_Excur int,
constraint pk_paq primary key (ID),
constraint fk_paq_exc foreign key (ID_paq) references paquete(ID_paq),
constraint fk_exc_paq foreign key (ID_Excur) references excursion(ID_Excur)
);


CREATE TABLE presupuesto (
N_Pres int,
N_Clie int,
ID_Paq int,
F_Emision date,
Vigencia date,
Costo int,
constraint pk_presupuesto primary key (N_pres),
constraint fk_presupuesto_cliente foreign key (N_Clie) references cliente(N_Clie),
constraint fk_presupuesto_paquete foreign key (ID_Paq) references paquete(ID_Paq)
);
 
CREATE TABLE reserva (
Cod_Res int,
N_Pres int,
Sena int,
Total int,
Fecha_Reserva date,
constraint pk_reserva primary key (Cod_Res),
constraint fk_reserva_presupuesto foreign key (N_Pres) references presupuesto(N_Pres),
);

CREATE TABLE comprobante (
Cod_Res int,
ID_Paq int,
N_Clie int,
constraint pk_comprobante primary key (Cod_res,ID_Paq,N_Clie),
constraint fk_comprobante_reserva foreign key (Cod_Res) references reserva(Cod_Res),
constraint fk_comprobante_destino foreign key (ID_paq) references paquete(ID_paq),
constraint fk_comprobante_cliente foreign key (N_Clie) references cliente(N_Clie)
);

CREATE TABLE usuario (
ID int,
Nombre_Apellido varchar(30),
Contrasena varchar(30),
Permiso varchar(30),
constraint pk_usuario primary key (ID)
);

INSERT INTO usuario VALUES(0,'A','A','Dueño'); 
INSERT INTO usuario VALUES(1,'Juan','juan','empleado'); 

INSERT INTO cliente VALUES(0,'Juan Rodriguez','Lope de Vega 1304','48896234','juan@gmail.com'); 
INSERT INTO cliente VALUES(1,'Marcos Picasso','Argerich 1465','49872865','marcos@gmail.com'); 
INSERT INTO cliente VALUES(2,'Silvina Arquimedes','Juan A. Garcia 5148','46598752','silvina@gmail.com'); 
INSERT INTO cliente VALUES(3,'Alejandro Nietzsche','Angel Carranza 5154','42653967','ale@gmail.com'); 
INSERT INTO cliente VALUES(4,'Mariana Frondisi','Nazca 2148','45619276','mary@gmail.com'); 
INSERT INTO cliente VALUES(5,'Ruben Sarmiento','Cuenca 5465','46951623','ruben@gmail.com'); 

INSERT INTO destino VALUES(0,'Miami',10); 
INSERT INTO destino VALUES(1,'Moscu',20); 
INSERT INTO destino VALUES(2,'Rio de Janeiro',0); 
INSERT INTO destino VALUES(3,'Punta del Este',10); 
INSERT INTO destino VALUES(4,'Mar del Plata',15); 
INSERT INTO destino VALUES(5,'Bariloche',0); 

INSERT INTO transporte VALUES(0,'Avion',1,'Primera','Aerolineas Arg',1400,40); 
INSERT INTO transporte VALUES(1,'Micro',5,'SemiCama','FlechaBus',500,20); 
INSERT INTO transporte VALUES(2,'Micro',5,'Cama','Plusmar',600,40); 
INSERT INTO transporte VALUES(3,'Avion',0,'Primera','LAN',1200,30); 
INSERT INTO transporte VALUES(4,'Avion',0,'Ejecutivo','Aerolineas Arg',150,40); 
INSERT INTO transporte VALUES(5,'Micro',4,'Cama','Empresa Arg',400,10); 

INSERT INTO excursion VALUES(0,2,'Buceo','2 horas',500,40,2015-09-20);
INSERT INTO excursion VALUES(1,5,'Ski','3 horas',500,40,2015-09-21);
INSERT INTO excursion VALUES(2,4,'Golf','4 horas',600,40,2015-09-25);
INSERT INTO excursion VALUES(3,4,'Teatro','2 horas',500,40,2015-09-22);
INSERT INTO excursion VALUES(4,3,'Playa','2 horas',700,40,2015-09-24);
INSERT INTO excursion VALUES(5,3,'Futbol','2 horas',800,40,2015-09-30);
INSERT INTO excursion VALUES(6,3,'Paseo de la ciudad','2 horas',900,40,2015-09-22);

INSERT INTO hotel VALUES(0,'Sheratono','Apart',0,1900,40,5,'Alto Lujo');
INSERT INTO hotel VALUES(1,'Holton','Apart',2,500,15,5,'Alto Lujo');
INSERT INTO hotel VALUES(2,'Costa Gelato','All inclusive',2,1000,45,5,'Alto Lujo');
INSERT INTO hotel VALUES(3,'El Argentino','Apart',3,800,30,5,'Alto Lujo');
INSERT INTO hotel VALUES(4,'El Lobby','Hostel',3,300,40,5,'Alto Lujo');
INSERT INTO hotel VALUES(5,'Des Reyes','Apart y Spa',3,1500,40,5,'Alto Lujo');