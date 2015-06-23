
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/23/2015 17:15:38
-- Generated from EDMX file: F:\bestanden\LamaGaan\LamaGaan\LamaGaanModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LamaGaanDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Werkrooster'
CREATE TABLE [dbo].[Werkrooster] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersoonId] int  NOT NULL,
    [Datum] datetime  NOT NULL,
    [BeginTijd] time  NOT NULL,
    [EindTijd] time  NOT NULL,
    [TaakId] int  NOT NULL,
    [Persoon_Id] int  NOT NULL,
    [Taak_Id] int  NOT NULL
);
GO

-- Creating table 'Taak'
CREATE TABLE [dbo].[Taak] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [DierId] int  NOT NULL,
    [Dier_Id] int  NOT NULL
);
GO

-- Creating table 'Dier'
CREATE TABLE [dbo].[Dier] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DierNaam] nvarchar(max)  NOT NULL,
    [DierSoort] nvarchar(max)  NOT NULL,
    [GeboorteDatum] datetime  NOT NULL,
    [VoerProductId] int  NOT NULL,
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
    [InkoopWinkel] nvarchar(max)  NOT NULL
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

-- Creating table 'VerkoopOrderSet'
CREATE TABLE [dbo].[VerkoopOrderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [ProductId] int  NOT NULL,
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

-- Creating primary key on [Id] in table 'VerkoopOrderSet'
ALTER TABLE [dbo].[VerkoopOrderSet]
ADD CONSTRAINT [PK_VerkoopOrderSet]
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

-- Creating foreign key on [Product_Id] in table 'VerkoopOrderSet'
ALTER TABLE [dbo].[VerkoopOrderSet]
ADD CONSTRAINT [FK_ProductVerkoopOrder]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductVerkoopOrder'
CREATE INDEX [IX_FK_ProductVerkoopOrder]
ON [dbo].[VerkoopOrderSet]
    ([Product_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------