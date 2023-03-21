DELETE FROM PermissaoGrupoUsuario
GO
DELETE FROM Permissao
GO

INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permiss�o a um grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usu�rio a um usu�rio')

SELECT * FROM GrupoUsuario
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Vendedor')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Gerente')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Estoquista')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Fiscal de caixa')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Operador de caixa')

SELECT * FROM GrupoUsuario
SELECT * FROM Usuario
SELECT * FROM PermissaoGrupoUsuario
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

SELECT * FROM UsuarioGrupoUsuario
SELECT * FROM Permissao
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('')

DECLARE @IdUsuario INT = 14
DECLARE @IdPermissao INT = 10

	SELECT 1 FROM PermissaoGrupoUsuario
	INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
	WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao