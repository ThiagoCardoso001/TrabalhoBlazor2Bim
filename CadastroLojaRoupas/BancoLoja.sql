CREATE DATABASE loja;
USE loja;
CREATE TABLE loja (
    id VARCHAR(20) PRIMARY KEY,
    nome VARCHAR(50),
    fabricante VARCHAR (50),
    marca VARCHAR (50)
);

CREATE TABLE loja_record (
    id VARCHAR(20) PRIMARY KEY,
    descricao VARCHAR(50),
    data datetime,
    IdAtleta VARCHAR(50),
    FOREIGN KEY (IdLoja) REFERENCES loja(id) ON DELETE CASCADE
);