
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2023 11:23:35
-- Generated from EDMX file: C:\Users\Admin\Desktop\E_D_H_B\trabajo final POO\trabajo final POO\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HotelPOO];
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

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [User] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Bitacoras'
CREATE TABLE [dbo].[Bitacoras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] nvarchar(max)  NOT NULL,
    [Accion] nvarchar(max)  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Tipohabitaciones'
CREATE TABLE [dbo].[Tipohabitaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo_Tipo] nvarchar(max)  NOT NULL,
    [Nombre_Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Habitaciones'
CREATE TABLE [dbo].[Habitaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero_Hab] nvarchar(max)  NOT NULL,
    [Nombre_Hab] nvarchar(max)  NOT NULL,
    [Precio_Hab] nvarchar(max)  NOT NULL,
    [Foto] nvarchar(max)  NOT NULL,
    [TipohabitacionId] int  NOT NULL
);
GO

-- Creating table 'Reservaciones_Hab'
CREATE TABLE [dbo].[Reservaciones_Hab] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha_Entrada] nvarchar(max)  NOT NULL,
    [Dias_Ocupados] nvarchar(max)  NOT NULL,
    [Fechareal_salida] nvarchar(max)  NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [HabitacionId] int  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo_Clie] nvarchar(max)  NOT NULL,
    [Nombre_clie] nvarchar(max)  NOT NULL,
    [Ape1_clie] nvarchar(max)  NOT NULL,
    [Ape2_clie] nvarchar(max)  NOT NULL,
    [Numero_identificacion] nvarchar(max)  NOT NULL,
    [Tipo_ClienteId] int  NOT NULL
);
GO

-- Creating table 'Tipos_Clientes'
CREATE TABLE [dbo].[Tipos_Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre_tipo] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bitacoras'
ALTER TABLE [dbo].[Bitacoras]
ADD CONSTRAINT [PK_Bitacoras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipohabitaciones'
ALTER TABLE [dbo].[Tipohabitaciones]
ADD CONSTRAINT [PK_Tipohabitaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Habitaciones'
ALTER TABLE [dbo].[Habitaciones]
ADD CONSTRAINT [PK_Habitaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reservaciones_Hab'
ALTER TABLE [dbo].[Reservaciones_Hab]
ADD CONSTRAINT [PK_Reservaciones_Hab]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipos_Clientes'
ALTER TABLE [dbo].[Tipos_Clientes]
ADD CONSTRAINT [PK_Tipos_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId] in table 'Bitacoras'
ALTER TABLE [dbo].[Bitacoras]
ADD CONSTRAINT [FK_UsuarioBitacora]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioBitacora'
CREATE INDEX [IX_FK_UsuarioBitacora]
ON [dbo].[Bitacoras]
    ([UsuarioId]);
GO

-- Creating foreign key on [TipohabitacionId] in table 'Habitaciones'
ALTER TABLE [dbo].[Habitaciones]
ADD CONSTRAINT [FK_TipohabitacionHabitacion]
    FOREIGN KEY ([TipohabitacionId])
    REFERENCES [dbo].[Tipohabitaciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipohabitacionHabitacion'
CREATE INDEX [IX_FK_TipohabitacionHabitacion]
ON [dbo].[Habitaciones]
    ([TipohabitacionId]);
GO

-- Creating foreign key on [HabitacionId] in table 'Reservaciones_Hab'
ALTER TABLE [dbo].[Reservaciones_Hab]
ADD CONSTRAINT [FK_HabitacionReservacion_Hab]
    FOREIGN KEY ([HabitacionId])
    REFERENCES [dbo].[Habitaciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HabitacionReservacion_Hab'
CREATE INDEX [IX_FK_HabitacionReservacion_Hab]
ON [dbo].[Reservaciones_Hab]
    ([HabitacionId]);
GO

-- Creating foreign key on [ClienteId] in table 'Reservaciones_Hab'
ALTER TABLE [dbo].[Reservaciones_Hab]
ADD CONSTRAINT [FK_ClienteReservacion_Hab]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteReservacion_Hab'
CREATE INDEX [IX_FK_ClienteReservacion_Hab]
ON [dbo].[Reservaciones_Hab]
    ([ClienteId]);
GO

-- Creating foreign key on [Tipo_ClienteId] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_Tipo_ClienteCliente]
    FOREIGN KEY ([Tipo_ClienteId])
    REFERENCES [dbo].[Tipos_Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_ClienteCliente'
CREATE INDEX [IX_FK_Tipo_ClienteCliente]
ON [dbo].[Clientes]
    ([Tipo_ClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------