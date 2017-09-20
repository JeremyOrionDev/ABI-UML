
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2017 16:11:22
-- Generated from EDMX file: C:\Users\CDI14\Documents\Dev\ABIenCouche\ClassesDAO\lesCollaborateurs.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ABIenCouche];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CollaborateursContrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet] DROP CONSTRAINT [FK_CollaborateursContrats];
GO
IF OBJECT_ID(N'[dbo].[FK_CollaborateursAugmentations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AugmentationsSet] DROP CONSTRAINT [FK_CollaborateursAugmentations];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratsAvenant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AvenantSet] DROP CONSTRAINT [FK_ContratsAvenant];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratCDD_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_ContratCDD] DROP CONSTRAINT [FK_ContratCDD_inherits_Contrats];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratCDI_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_ContratCDI] DROP CONSTRAINT [FK_ContratCDI_inherits_Contrats];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratStage_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_ContratStage] DROP CONSTRAINT [FK_ContratStage_inherits_Contrats];
GO
IF OBJECT_ID(N'[dbo].[FK_ContratInterim_inherits_Contrats]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContratsSet_ContratInterim] DROP CONSTRAINT [FK_ContratInterim_inherits_Contrats];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CollaborateursSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CollaborateursSet];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet];
GO
IF OBJECT_ID(N'[dbo].[AugmentationsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AugmentationsSet];
GO
IF OBJECT_ID(N'[dbo].[AvenantSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvenantSet];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_ContratCDD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_ContratCDD];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_ContratCDI]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_ContratCDI];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_ContratStage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_ContratStage];
GO
IF OBJECT_ID(N'[dbo].[ContratsSet_ContratInterim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContratsSet_ContratInterim];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CollaborateursSet'
CREATE TABLE [dbo].[CollaborateursSet] (
    [matricule] int  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Civilite] nvarchar(4)  NOT NULL,
    [Rue] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] nchar(5)  NOT NULL,
    [Telephone] nchar(10)  NOT NULL,
    [SituationMaritale] nvarchar(max)  NOT NULL,
    [Archive] bit  NOT NULL
);
GO

-- Creating table 'ContratsSet'
CREATE TABLE [dbo].[ContratsSet] (
    [NumContrat] int  NOT NULL,
    [Statut] bit  NOT NULL,
    [Qualification] nvarchar(max)  NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [Fonction] nvarchar(max)  NOT NULL,
    [DateDebut] datetime  NOT NULL,
    [idContrat] int  NOT NULL,
    [Collaborateurs_matricule] int  NOT NULL
);
GO

-- Creating table 'AugmentationsSet'
CREATE TABLE [dbo].[AugmentationsSet] (
    [Date] datetime  NOT NULL,
    [Valeur] decimal(18,0)  NOT NULL,
    [Collaborateurs_matricule] int  NOT NULL
);
GO

-- Creating table 'AvenantSet'
CREATE TABLE [dbo].[AvenantSet] (
    [idAvenant] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [MotifAvenant] nvarchar(max)  NOT NULL,
    [numeroAvenant] int  NOT NULL,
    [Contrats_idContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_ContratCDD'
CREATE TABLE [dbo].[ContratsSet_ContratCDD] (
    [DateFin] datetime  NOT NULL,
    [Motif] nvarchar(max)  NOT NULL,
    [Salaire] float  NOT NULL,
    [idContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_ContratCDI'
CREATE TABLE [dbo].[ContratsSet_ContratCDI] (
    [Salaire] float  NOT NULL,
    [idContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_ContratStage'
CREATE TABLE [dbo].[ContratsSet_ContratStage] (
    [Ecole] nvarchar(max)  NOT NULL,
    [Motif] nvarchar(max)  NOT NULL,
    [Tuteur] nvarchar(max)  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [Mission] nvarchar(max)  NOT NULL,
    [idContrat] int  NOT NULL
);
GO

-- Creating table 'ContratsSet_ContratInterim'
CREATE TABLE [dbo].[ContratsSet_ContratInterim] (
    [Agence] nvarchar(max)  NOT NULL,
    [Salaire] float  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [Motif] nvarchar(max)  NOT NULL,
    [idContrat] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [matricule] in table 'CollaborateursSet'
ALTER TABLE [dbo].[CollaborateursSet]
ADD CONSTRAINT [PK_CollaborateursSet]
    PRIMARY KEY CLUSTERED ([matricule] ASC);
GO

-- Creating primary key on [idContrat] in table 'ContratsSet'
ALTER TABLE [dbo].[ContratsSet]
ADD CONSTRAINT [PK_ContratsSet]
    PRIMARY KEY CLUSTERED ([idContrat] ASC);
GO

-- Creating primary key on [Date] in table 'AugmentationsSet'
ALTER TABLE [dbo].[AugmentationsSet]
ADD CONSTRAINT [PK_AugmentationsSet]
    PRIMARY KEY CLUSTERED ([Date] ASC);
GO

-- Creating primary key on [idAvenant] in table 'AvenantSet'
ALTER TABLE [dbo].[AvenantSet]
ADD CONSTRAINT [PK_AvenantSet]
    PRIMARY KEY CLUSTERED ([idAvenant] ASC);
GO

-- Creating primary key on [idContrat] in table 'ContratsSet_ContratCDD'
ALTER TABLE [dbo].[ContratsSet_ContratCDD]
ADD CONSTRAINT [PK_ContratsSet_ContratCDD]
    PRIMARY KEY CLUSTERED ([idContrat] ASC);
GO

-- Creating primary key on [idContrat] in table 'ContratsSet_ContratCDI'
ALTER TABLE [dbo].[ContratsSet_ContratCDI]
ADD CONSTRAINT [PK_ContratsSet_ContratCDI]
    PRIMARY KEY CLUSTERED ([idContrat] ASC);
GO

-- Creating primary key on [idContrat] in table 'ContratsSet_ContratStage'
ALTER TABLE [dbo].[ContratsSet_ContratStage]
ADD CONSTRAINT [PK_ContratsSet_ContratStage]
    PRIMARY KEY CLUSTERED ([idContrat] ASC);
GO

-- Creating primary key on [idContrat] in table 'ContratsSet_ContratInterim'
ALTER TABLE [dbo].[ContratsSet_ContratInterim]
ADD CONSTRAINT [PK_ContratsSet_ContratInterim]
    PRIMARY KEY CLUSTERED ([idContrat] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Collaborateurs_matricule] in table 'ContratsSet'
ALTER TABLE [dbo].[ContratsSet]
ADD CONSTRAINT [FK_CollaborateursContrats]
    FOREIGN KEY ([Collaborateurs_matricule])
    REFERENCES [dbo].[CollaborateursSet]
        ([matricule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateursContrats'
CREATE INDEX [IX_FK_CollaborateursContrats]
ON [dbo].[ContratsSet]
    ([Collaborateurs_matricule]);
GO

-- Creating foreign key on [Collaborateurs_matricule] in table 'AugmentationsSet'
ALTER TABLE [dbo].[AugmentationsSet]
ADD CONSTRAINT [FK_CollaborateursAugmentations]
    FOREIGN KEY ([Collaborateurs_matricule])
    REFERENCES [dbo].[CollaborateursSet]
        ([matricule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateursAugmentations'
CREATE INDEX [IX_FK_CollaborateursAugmentations]
ON [dbo].[AugmentationsSet]
    ([Collaborateurs_matricule]);
GO

-- Creating foreign key on [Contrats_idContrat] in table 'AvenantSet'
ALTER TABLE [dbo].[AvenantSet]
ADD CONSTRAINT [FK_ContratsAvenant]
    FOREIGN KEY ([Contrats_idContrat])
    REFERENCES [dbo].[ContratsSet]
        ([idContrat])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContratsAvenant'
CREATE INDEX [IX_FK_ContratsAvenant]
ON [dbo].[AvenantSet]
    ([Contrats_idContrat]);
GO

-- Creating foreign key on [idContrat] in table 'ContratsSet_ContratCDD'
ALTER TABLE [dbo].[ContratsSet_ContratCDD]
ADD CONSTRAINT [FK_ContratCDD_inherits_Contrats]
    FOREIGN KEY ([idContrat])
    REFERENCES [dbo].[ContratsSet]
        ([idContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContrat] in table 'ContratsSet_ContratCDI'
ALTER TABLE [dbo].[ContratsSet_ContratCDI]
ADD CONSTRAINT [FK_ContratCDI_inherits_Contrats]
    FOREIGN KEY ([idContrat])
    REFERENCES [dbo].[ContratsSet]
        ([idContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContrat] in table 'ContratsSet_ContratStage'
ALTER TABLE [dbo].[ContratsSet_ContratStage]
ADD CONSTRAINT [FK_ContratStage_inherits_Contrats]
    FOREIGN KEY ([idContrat])
    REFERENCES [dbo].[ContratsSet]
        ([idContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idContrat] in table 'ContratsSet_ContratInterim'
ALTER TABLE [dbo].[ContratsSet_ContratInterim]
ADD CONSTRAINT [FK_ContratInterim_inherits_Contrats]
    FOREIGN KEY ([idContrat])
    REFERENCES [dbo].[ContratsSet]
        ([idContrat])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------