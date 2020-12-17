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
(4, 'AMAPÁ', 'AP'),
(5, 'BAHIA', 'BA'),
(6, 'CEARÁ', 'CE'),
(7, 'DISTRITO FEDERAL', 'DF'),
(8, 'ESPÍRITO SANTO', 'ES'),
(9, 'GOIÁS', 'GO'),
(10, 'MARANHÃO', 'MA'),
(11, 'MINAS GERAIS', 'MG'),
(12, 'MATO GROSSO DO SUL', 'MS'),
(13, 'MATO GROSSO', 'MT'),
(14, 'PARÁ', 'PA'),
(15, 'PARAÍBA', 'PB'),
(16, 'PERNAMBUCO', 'PE'),
(17, 'PIAUÍ', 'PI'),
(18, 'PARANÁ', 'PR'),
(19, 'RIO DE JANEIRO', 'RJ'),
(20, 'RIO GRANDE DO NORTE', 'RN'),
(21, 'RONDÔNIA', 'RO'),
(22, 'RORAIMA', 'RR'),
(23, 'RIO GRANDE DO SUL', 'RS'),
(24, 'SANTA CATARINA', 'SC'),
(25, 'SERGIPE', 'SE'),
(26, 'SÃO PAULO', 'SP'),
(27, 'TOCANTINS', 'TO');