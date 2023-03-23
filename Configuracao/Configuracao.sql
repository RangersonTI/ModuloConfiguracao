CREATE DATABASE Configuracao;
USE Configuracao;

CREATE TABLE Usuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	NomeUsuario VARCHAR(50),
	Email VARCHAR(150),
	CPF VARCHAR(15),
	Ativo BIT,
	Senha VARCHAR(50)
)
GO

CREATE TABLE GrupoUsuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	NomeGrupo VARCHAR(150)
)
GO

CREATE TABLE Permissao
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(250)
)
GO

CREATE TABLE UsuarioGrupoUsuario
(
	IdUsuario INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_UsuarioGrupoUsuario PRIMARY KEY (IdUsuario, IdGrupoUsuario)
)
GO

CREATE TABLE PermissaoGrupoUsuario
(
	IdPermissao INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_PermissaoGrupoUsuario PRIMARY KEY (IdPermissao, IdGrupoUsuario)
)
GO

ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO

ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_Permissao
FOREIGN KEY (IdPermissao) REFERENCES Permissao(Id)

GO

ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO
select * from Usuario;
-- INSERT INTO Usuario ()VALUES()


INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permissão a um grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usuário a um usuário')

--UPDATE GrupoUsuario SET NomeGrupo = 'Vendedor' WHERE Id = 2;

INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Gerente')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Vendedor')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Estoquista')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Fiscal de caixa')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Operador de caixa')

INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,1)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,2)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,3)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,4)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,5)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,6)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,7)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,8)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,9)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario,IdPermissao)VALUES(1,10)

INSERT INTO UsuarioGrupoUsuario VALUES(3,1)
INSERT INTO UsuarioGrupoUsuario VALUES(2,2)
INSERT INTO UsuarioGrupoUsuario VALUES(1,3)
INSERT INTO UsuarioGrupoUsuario VALUES(2,5)
INSERT INTO UsuarioGrupoUsuario VALUES(3,4)

SELECT * FROM GrupoUsuario
SELECT * FROM Usuario
SELECT * FROM Permissao
SELECT * FROM PermissaoGrupoUsuario
SELECT * FROM UsuarioGrupoUsuario

--SELECT 1 FROM PermissaoGrupoUsuario
--INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
--WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao

--DECLARE @IdUsuario INT = 14
--DECLARE @IdPermissao INT = 10
