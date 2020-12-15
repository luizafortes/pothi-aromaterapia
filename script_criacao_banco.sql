use pothiAromaterapia_db

CREATE TABLE Pessoa (
  PessoaId int NOT NULL IDENTITY
, Cpf nvarchar(11) NOT NULL
, Nome nvarchar(100) NOT NULL
, Tel nvarchar(100) NULL
, Email nvarchar(100) NULL
, Sexo int NULL
, EstadoCivil int NULL
, Filhos bit NULL
, Animais bit NULL
, Fumante bit NULL
);
GO
ALTER TABLE Pessoa ADD CONSTRAINT PK_Pessoa PRIMARY KEY (PessoaId);
GO

CREATE TABLE Endereco (
  EnderecoId int NOT NULL IDENTITY
, TipoLogradouro nvarchar(100) NULL
, Logradouro nvarchar(100) NULL
, Numero nvarchar(100) NULL
, Complemento nvarchar(100) NULL
, Cep nvarchar(8) NULL
, Cidade int NULL
, Estado int NULL
, PessoaId int NOT NULL
);
GO
ALTER TABLE Endereco ADD CONSTRAINT PK_Endereco PRIMARY KEY (EnderecoId);
GO
ALTER TABLE Endereco ADD CONSTRAINT FK_Pessoa_Endereco FOREIGN KEY (PessoaId) REFERENCES Pessoa(PessoaId) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

CREATE TABLE Oleo (
  OleoId int NOT NULL IDENTITY
, Nome nvarchar(11) NOT NULL
, Descricao nvarchar(100) NOT NULL
, Sintomas nvarchar(MAX) NULL
);
GO
ALTER TABLE Oleo ADD CONSTRAINT PK_Oleo PRIMARY KEY (OleoId);
GO

CREATE TABLE Sintoma (
  SintomaId int NOT NULL IDENTITY
, Nome nvarchar(11) NOT NULL
, Descricao nvarchar(100) NOT NULL
, Oleos nvarchar(MAX) NULL
);
GO
ALTER TABLE Sintoma ADD CONSTRAINT PK_Sintoma PRIMARY KEY (SintomaId);
GO
CREATE TABLE Oleo_Sintoma (
  Oleo_Sintoma_Id int IDENTITY
, OleoId int NOT NULL
, SintomaId int NOT NULL
);
GO
ALTER TABLE Oleo_Sintoma ADD CONSTRAINT PK_Oleo_Sintoma PRIMARY KEY (OleoId, SintomaId);
GO
ALTER TABLE Oleo_Sintoma ADD CONSTRAINT FK_Oleo_Oleo_Sintoma FOREIGN KEY (OleoId) REFERENCES Oleo(OleoId) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE Oleo_Sintoma ADD CONSTRAINT FK_Sintoma_Oleo_Sintoma FOREIGN KEY (SintomaId) REFERENCES Sintoma(SintomaId) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

drop table Oleo_Sintoma
drop table Sintoma
drop table Oleo
drop table Endereco
drop table Pessoa





