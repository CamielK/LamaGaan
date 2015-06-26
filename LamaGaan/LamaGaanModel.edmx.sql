
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/26/2015 20:30:44
-- Generated from EDMX file: F:\bestanden\LamaGaan\LamaGaan\LamaGaanModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LamaGaanDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersoonWerkrooster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Werkrooster] DROP CONSTRAINT [FK_PersoonWerkrooster];
GO
IF OBJECT_ID(N'[dbo].[FK_TaakWerkrooster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Werkrooster] DROP CONSTRAINT [FK_TaakWerkrooster];
GO
IF OBJECT_ID(N'[dbo].[FK_DierTaak]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Taak] DROP CONSTRAINT [FK_DierTaak];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductDier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dier] DROP CONSTRAINT [FK_ProductDier];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductVerkoopOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VerkoopOrder] DROP CONSTRAINT [FK_ProductVerkoopOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ReserveringVerkoopOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VerkoopOrder] DROP CONSTRAINT [FK_ReserveringVerkoopOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_EvenementReservering]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservering] DROP CONSTRAINT [FK_EvenementReservering];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductInkoopOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InkoopOrder] DROP CONSTRAINT [FK_ProductInkoopOrder];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Werkrooster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Werkrooster];
GO
IF OBJECT_ID(N'[dbo].[Taak]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Taak];
GO
IF OBJECT_ID(N'[dbo].[Dier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dier];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[Persoon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persoon];
GO
IF OBJECT_ID(N'[dbo].[VerkoopOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VerkoopOrder];
GO
IF OBJECT_ID(N'[dbo].[Evenement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evenement];
GO
IF OBJECT_ID(N'[dbo].[Reservering]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservering];
GO
IF OBJECT_ID(N'[dbo].[InkoopOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InkoopOrder];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Werkrooster'
CREATE TABLE [dbo].[Werkrooster] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [BeginTijd] time  NOT NULL,
    [EindTijd] time  NOT NULL,
    [Persoon_Id] int  NOT NULL,
    [Taak_Id] int  NOT NULL
);
GO

-- Creating table 'Taak'
CREATE TABLE [dbo].[Taak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Dier_Id] int  NOT NULL
);
GO

-- Creating table 'Dier'
CREATE TABLE [dbo].[Dier] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DierNaam] nvarchar(max)  NOT NULL,
    [DierSoort] nvarchar(max)  NOT NULL,
    [GeboorteDatum] datetime  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [MaxVoorraad] int  NULL,
    [HuidigeVoorraad] int  NULL,
    [VerkoopPrijs] int  NULL,
    [InkoopPrijs] int  NULL,
    [MinVoorraad] int  NULL,
    [InkoopWinkel] nvarchar(max)  NULL
);
GO

-- Creating table 'Persoon'
CREATE TABLE [dbo].[Persoon] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Wachtwoord] nvarchar(max)  NOT NULL,
    [Telefoonnummer] nvarchar(max)  NOT NULL,
    [Woonplaats] nvarchar(max)  NOT NULL,
    [Postcode] nvarchar(max)  NOT NULL,
    [Straatnaam] nvarchar(max)  NOT NULL,
    [Huisnummer] nvarchar(max)  NOT NULL,
    [Startdatum] datetime  NOT NULL,
    [Vergoeding] int  NOT NULL,
    [Functie] nvarchar(max)  NOT NULL,
    [GeboorteDatum] datetime  NOT NULL
);
GO

-- Creating table 'VerkoopOrder'
CREATE TABLE [dbo].[VerkoopOrder] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [Aantal] int  NOT NULL,
    [TotaalPrijs] int  NOT NULL,
    [Product_Id] int  NOT NULL,
    [Reservering_Id] int  NULL
);
GO

-- Creating table 'Evenement'
CREATE TABLE [dbo].[Evenement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Soort] nvarchar(max)  NOT NULL,
    [Datum] datetime  NOT NULL,
    [MaxAantalPersonen] int  NOT NULL,
    [Korting] int  NOT NULL
);
GO

-- Creating table 'Reservering'
CREATE TABLE [dbo].[Reservering] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Datum] datetime  NOT NULL,
    [Evenement_Id] int  NULL
);
GO

-- Creating table 'InkoopOrder'
CREATE TABLE [dbo].[InkoopOrder] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [Aantal] int  NOT NULL,
    [TotaalPrijs] int  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Werkrooster'
ALTER TABLE [dbo].[Werkrooster]
ADD CONSTRAINT [PK_Werkrooster]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Taak'
ALTER TABLE [dbo].[Taak]
ADD CONSTRAINT [PK_Taak]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Dier'
ALTER TABLE [dbo].[Dier]
ADD CONSTRAINT [PK_Dier]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persoon'
ALTER TABLE [dbo].[Persoon]
ADD CONSTRAINT [PK_Persoon]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VerkoopOrder'
ALTER TABLE [dbo].[VerkoopOrder]
ADD CONSTRAINT [PK_VerkoopOrder]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Evenement'
ALTER TABLE [dbo].[Evenement]
ADD CONSTRAINT [PK_Evenement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reservering'
ALTER TABLE [dbo].[Reservering]
ADD CONSTRAINT [PK_Reservering]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InkoopOrder'
ALTER TABLE [dbo].[InkoopOrder]
ADD CONSTRAINT [PK_InkoopOrder]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Persoon_Id] in table 'Werkrooster'
ALTER TABLE [dbo].[Werkrooster]
ADD CONSTRAINT [FK_PersoonWerkrooster]
    FOREIGN KEY ([Persoon_Id])
    REFERENCES [dbo].[Persoon]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersoonWerkrooster'
CREATE INDEX [IX_FK_PersoonWerkrooster]
ON [dbo].[Werkrooster]
    ([Persoon_Id]);
GO

-- Creating foreign key on [Taak_Id] in table 'Werkrooster'
ALTER TABLE [dbo].[Werkrooster]
ADD CONSTRAINT [FK_TaakWerkrooster]
    FOREIGN KEY ([Taak_Id])
    REFERENCES [dbo].[Taak]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TaakWerkrooster'
CREATE INDEX [IX_FK_TaakWerkrooster]
ON [dbo].[Werkrooster]
    ([Taak_Id]);
GO

-- Creating foreign key on [Dier_Id] in table 'Taak'
ALTER TABLE [dbo].[Taak]
ADD CONSTRAINT [FK_DierTaak]
    FOREIGN KEY ([Dier_Id])
    REFERENCES [dbo].[Dier]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DierTaak'
CREATE INDEX [IX_FK_DierTaak]
ON [dbo].[Taak]
    ([Dier_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'Dier'
ALTER TABLE [dbo].[Dier]
ADD CONSTRAINT [FK_ProductDier]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductDier'
CREATE INDEX [IX_FK_ProductDier]
ON [dbo].[Dier]
    ([Product_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'VerkoopOrder'
ALTER TABLE [dbo].[VerkoopOrder]
ADD CONSTRAINT [FK_ProductVerkoopOrder]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductVerkoopOrder'
CREATE INDEX [IX_FK_ProductVerkoopOrder]
ON [dbo].[VerkoopOrder]
    ([Product_Id]);
GO

-- Creating foreign key on [Reservering_Id] in table 'VerkoopOrder'
ALTER TABLE [dbo].[VerkoopOrder]
ADD CONSTRAINT [FK_ReserveringVerkoopOrder]
    FOREIGN KEY ([Reservering_Id])
    REFERENCES [dbo].[Reservering]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReserveringVerkoopOrder'
CREATE INDEX [IX_FK_ReserveringVerkoopOrder]
ON [dbo].[VerkoopOrder]
    ([Reservering_Id]);
GO

-- Creating foreign key on [Evenement_Id] in table 'Reservering'
ALTER TABLE [dbo].[Reservering]
ADD CONSTRAINT [FK_EvenementReservering]
    FOREIGN KEY ([Evenement_Id])
    REFERENCES [dbo].[Evenement]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvenementReservering'
CREATE INDEX [IX_FK_EvenementReservering]
ON [dbo].[Reservering]
    ([Evenement_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'InkoopOrder'
ALTER TABLE [dbo].[InkoopOrder]
ADD CONSTRAINT [FK_ProductInkoopOrder]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductInkoopOrder'
CREATE INDEX [IX_FK_ProductInkoopOrder]
ON [dbo].[InkoopOrder]
    ([Product_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------