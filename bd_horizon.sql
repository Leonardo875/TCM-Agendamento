create database bd_horizon

create table tbl_funcionario(
         cd_func int primary key identity,
		 nm_func varchar(50) not null,
		 ds_login varchar(20) not null,
		 senha_login varchar(8)not null,
)

create table tbl_reserva(
        cd_reser int primary key identity,
		tipo_voo varchar(20) not null,
		local_orig varchar(20) not null,
		local_dest varchar(20) not null,
		adulto_reser varchar(2) not null,
		menor_reser varchar(2) null,
)

create table tbl_cliente(
       cd_cliente int primary key identity,
	   nm_cliente varchar(50),
	   sg_sexo char(1)not null check(sg_sexo in('M','F')),
	   no_cpf char(11) not null,
	   no_cep char(8) not null,
	   pais_orig varchar(20) not null,
	   dt_nasc char(8) not null,
	   ddd_tel char(3) null,
	   tel_cliente char(8) null,
	   nm_passaport char(8) not null,
)



create table tbl_pacote(
      cd_pacot int primary key identity,
	  local_hotel varchar(50) null,
	   quartos_hotel char(1) null,
	   categ_hotel char(1) null,
	   tipo_convenio varchar(20) null,
	   passeio_pacot varchar(20) null
)

create table tbl_agenda(
       cd_agenda int primary key identity,
	   dt_ida char(8) null,
	   dt_volta char(8) null,
	   diarias_agenda varchar(3) null,
)

create table tbl_pagamento(
     cd_paga int primary key identity,
	 preco_total decimal(10,2) not null,
	 forma_paga varchar(20) not null,
)

insert into tbl_pacote
(local_hotel,quartos_hotel,categ_hotel,tipo_convenio,passeio_pacot)
values('Maison Albar','3','5','Alimenta��o','Jardins de Monet')

insert into tbl_pacote
(local_hotel,quartos_hotel,categ_hotel,tipo_convenio,passeio_pacot)
values('Hotel Hiberia','2','3','Plano de Sa�de','Coliseu')

select * from tbl_pacote
