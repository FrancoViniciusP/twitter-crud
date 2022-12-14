USE master;
GO

DROP DATABASE IF EXISTS Tryitter;
GO

CREATE DATABASE Tryitter;
GO

USE Tryitter;

CREATE TABLE Students
(
    StudentId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Level VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
);
GO

CREATE TABLE Posts
(
    PostId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Text VARCHAR(300) NOT NULL,
    StudentId INT NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
);
GO

INSERT INTO Students(Name, Email, Level, Password) VALUES('Jorge Amado', 'jamado@email.com', 'Fundamentos', '123456');
INSERT INTO Students(Name, Email, Level, Password) VALUES('Luiz Gonzaga', 'lgonzaga@email.com', 'Front-End', '123456');
INSERT INTO Students(Name, Email, Level, Password) VALUES('Pedro Neto', 'pneto@email.com', 'Back-End', '123456');
INSERT INTO Students(Name, Email, Level, Password) VALUES('Carla Perez', 'cperez@email.com', 'Fundamentos', '123456');
INSERT INTO Students(Name, Email, Level, Password) VALUES('Gugu Liberato', 'gliberato@email.com', 'Ciência da Computação', '123456');
GO

INSERT INTO Posts(Text, StudentId) VALUES('Cansei de escrever, já dizia o estudante no enem', 1);
INSERT INTO Posts(Text, StudentId) VALUES('Pero que si. Pero que no. Isso nem existe em espanhol', 3);
INSERT INTO Posts(Text, StudentId) VALUES('Quando a luz dos olhos teus se apagarem saiba que nunca deixei de te amar', 2);
INSERT INTO Posts(Text, StudentId) VALUES('Metaverso é modinha', 4);
INSERT INTO Posts(Text, StudentId) VALUES('Dizem que Alok é melhor que David Guetta mas ele não toca música acima de 140 bpm', 2);
INSERT INTO Posts(Text, StudentId) VALUES('Pancake é a junção da palavra panela e bolo em inglês', 5);
INSERT INTO Posts(Text, StudentId) VALUES('Picles é pepino em conserva', 3);
;