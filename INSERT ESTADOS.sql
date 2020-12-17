create table cidades (
  id_cidade int  primary key not null,
  nome varchar(120) default null,
  id_estado int default null,  
  constraint fk_id_estado_cidades foreign key (id_estado)
	references estados (id_estado)
)

create table estados (
  id_estado int primary key not null,
  nome varchar(120) default null,
  uf varchar(5) default null
)


INSERT INTO estados (id_estado, nome, uf) VALUES
(1, 'ACRE', 'AC'),
(2, 'ALAGOAS', 'AL'),
(3, 'AMAZONAS', 'AM'),
(4, 'AMAP�', 'AP'),
(5, 'BAHIA', 'BA'),
(6, 'CEAR�', 'CE'),
(7, 'DISTRITO FEDERAL', 'DF'),
(8, 'ESP�RITO SANTO', 'ES'),
(9, 'GOI�S', 'GO'),
(10, 'MARANH�O', 'MA'),
(11, 'MINAS GERAIS', 'MG'),
(12, 'MATO GROSSO DO SUL', 'MS'),
(13, 'MATO GROSSO', 'MT'),
(14, 'PAR�', 'PA'),
(15, 'PARA�BA', 'PB'),
(16, 'PERNAMBUCO', 'PE'),
(17, 'PIAU�', 'PI'),
(18, 'PARAN�', 'PR'),
(19, 'RIO DE JANEIRO', 'RJ'),
(20, 'RIO GRANDE DO NORTE', 'RN'),
(21, 'ROND�NIA', 'RO'),
(22, 'RORAIMA', 'RR'),
(23, 'RIO GRANDE DO SUL', 'RS'),
(24, 'SANTA CATARINA', 'SC'),
(25, 'SERGIPE', 'SE'),
(26, 'S�O PAULO', 'SP'),
(27, 'TOCANTINS', 'TO');