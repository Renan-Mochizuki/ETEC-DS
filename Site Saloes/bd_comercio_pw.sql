create database bd_comercio_pw;

use bd_comercio_pw;

create table salao(
salao_id int primary key not null auto_increment,
salao_nome varchar(64) not null,
salao_endereco varchar(64) not null,
salao_telefone int not null,
salao_email varchar(64) not null
);

create table servico(
servico_id int primary key not null auto_increment,
servico_nome varchar(64) not null,
servico_valor varchar(12),
fk_salao_id int not null
);

alter table servico add constraint pk_salao_fk_servico
foreign key (fk_salao_id) references salao(salao_id);

insert into salao(
salao_nome,
salao_endereco,
salao_telefone,
salao_email
) values (
'Manicure boa unha',
'Rua Andradas, 18',
'1142233499',
'boaunha@gmail.com'
);
insert into salao(
salao_nome,
salao_endereco,
salao_telefone,
salao_email
) values (
'Cabelereiro na régua',
'Rua Jacinto Pinto, 34',
'1145556789',
'joaosilva@orkut.com'
);
insert into salao(
salao_nome,
salao_endereco,
salao_telefone,
salao_email
) values (
'Barbearia ciumenta',
'Rua Deide Costa, 50',
'1145236489',
'barbearia50@hotmail.com'
);

insert into servico(
servico_nome,
servico_valor,
fk_salao_id
) values (
'Remoção de cutículas',
'R$20,00',
'1'
);
insert into servico(
servico_nome,
servico_valor,
fk_salao_id
) values (
'Francesinha',
'R$23,50',
'1'
);
insert into servico(
servico_nome,
servico_valor,
fk_salao_id
) values (
'Corte masculino',
'R$30,00',
'2'
);
insert into servico(
servico_nome,
servico_valor,
fk_salao_id
) values (
'Cabelo blindado com ferro de passar',
'R$12.334,99',
'2'
);
insert into servico(
servico_nome,
servico_valor,
fk_salao_id
) values (
'Costeletas iradas',
'R$26,77',
'3'
);