

-- Tabela usuários
CREATE TABLE Usuario
(
    Id INT IDENTITY(1,1) PRIMARY KEY,

    Nome NVARCHAR(150) NOT NULL,

    Login NVARCHAR(50) NOT NULL UNIQUE,

    Senha NVARCHAR(255) NOT NULL,

    Perfil NVARCHAR(20) NOT NULL DEFAULT 'Cliente',

    Ativo BIT NOT NULL DEFAULT 1

);

-- Tabela Conta
CREATE TABLE Conta
(
    NumeroConta INT IDENTITY(1001,1) PRIMARY KEY,

    NomeTitular NVARCHAR(150) NOT NULL,

    CPF NVARCHAR(14) NOT NULL UNIQUE,

    Agencia NVARCHAR(10) NOT NULL,

    TipoConta NVARCHAR(20) NOT NULL,

    Saldo DECIMAL(18,2) NOT NULL DEFAULT 0,

    SenhaConta NVARCHAR(255) NOT NULL,

    DataCriacao DATETIME NOT NULL DEFAULT(GETDATE()),

    StatusConta NVARCHAR(20) NOT NULL DEFAULT 'Ativa'
);


-- Tabela Extrato
CREATE TABLE Extrato
(
    Id INT IDENTITY(1,1) PRIMARY KEY,

    NumeroConta INT NOT NULL,

    Tipo NVARCHAR(30) NOT NULL,

    Valor DECIMAL(18,2) NOT NULL,

    Saldo DECIMAL(18,2) NOT NULL,

    Descricao NVARCHAR(200),

    DataOperacao DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT FK_Extrato_Conta
        FOREIGN KEY (NumeroConta)
        REFERENCES Conta(NumeroConta)
);


