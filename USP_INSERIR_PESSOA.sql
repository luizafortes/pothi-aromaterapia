USE [pothiAromaterapia_db]
IF EXISTS (select 1 from sys.procedures where name = 'USP_INSERIR_PESSOA')

DROP PROCEDURE USP_INSERIR_PESSOA

GO

create PROCEDURE USP_INSERIR_PESSOA
(
 @Cpf nvarchar(11) NULL
, @Nome nvarchar(100) NULL
, @Tel nvarchar(100) NULL
, @Email nvarchar(100) NULL
, @Sexo int NULL
, @EstadoCivil int NULL
, @Filhos int NULL
, @Animais int NULL
, @Fumante int NULL
)
AS
DECLARE @INSERTED TABLE (PessoaId INT);
begin
INSERT INTO Pessoa
(Cpf, Nome, Tel, Email, Sexo, EstadoCivil, Filhos, Animais, Fumante) 
OUTPUT inserted.PessoaId INTO @INSERTED
VALUES 
(@Cpf, @Nome, @Tel, @Email, @Sexo, @EstadoCivil, @Filhos, @Animais, @Fumante)
end
-- // Retorna o ID da Pessoa inserida
	SELECT PessoaId FROM @INSERTED;

GO