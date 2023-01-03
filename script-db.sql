USE [db_Supermercados_Patitos_SA]
GO
/****** Object:  Table [dbo].[TbArticulo]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbArticulo](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](225) NULL,
	[PrecioVenta] [int] NULL,
	[PrecioCosto] [int] NULL,
	[Stock] [int] NULL,
	[IdTipo] [int] NULL,
	[IdProveedor] [int] NULL,
	[FechaIngreso] [date] NULL,
 CONSTRAINT [PK_TbArticulo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbArticuloAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbArticuloAuditoria](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](225) NULL,
	[PrecioVenta] [int] NULL,
	[PrecioCosto] [int] NULL,
	[Stock] [int] NULL,
	[IdTipo] [int] NULL,
	[IdProveedor] [int] NULL,
	[FechaIngreso] [date] NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbCajero]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCajero](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](25) NULL,
	[PrimerApellido] [varchar](25) NULL,
	[SegundoApellido] [varchar](25) NULL,
 CONSTRAINT [PK_TbCajero] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbCajeroAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCajeroAuditoria](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](25) NULL,
	[PrimerApellido] [varchar](25) NULL,
	[SegundoApellido] [varchar](25) NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbCliente]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCliente](
	[Cedula] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[PrimerApellido] [nvarchar](50) NOT NULL,
	[SegundoApellido] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TbCliente] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbClienteAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbClienteAuditoria](
	[Cedula] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[PrimerApellido] [nvarchar](50) NOT NULL,
	[SegundoApellido] [nvarchar](50) NOT NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbDetalleFactura]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbDetalleFactura](
	[NumeroFactura] [int] NULL,
	[CodigoArticulo] [int] NULL,
	[Cantidad] [int] NULL,
	[Total] [decimal](10, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmpresa]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmpresa](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[Direccion] [varchar](225) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_TbEmpresa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmpresaAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmpresaAuditoria](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[Direccion] [varchar](225) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbFactura]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbFactura](
	[NumeroFactura] [int] NOT NULL,
	[CedulaCliente] [int] NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[FechaFacturacion] [date] NULL,
	[IdPago] [int] NULL,
	[TotalFactura] [decimal](10, 0) NULL,
	[IVA] [decimal](10, 0) NULL,
	[IdCajero] [int] NULL,
	[Sucursal] [int] NULL,
 CONSTRAINT [PK_TbFactura] PRIMARY KEY CLUSTERED 
(
	[NumeroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbFacturaAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbFacturaAuditoria](
	[NumeroFactura] [int] NOT NULL,
	[CedulaCliente] [int] NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[FechaFacturacion] [date] NULL,
	[IdPago] [int] NULL,
	[TotalFactura] [decimal](10, 0) NULL,
	[IVA] [decimal](10, 0) NULL,
	[IdCajero] [int] NULL,
	[Sucursal] [int] NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbFormaPago]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbFormaPago](
	[ID] [int] NOT NULL,
	[Descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_TbFormaPago] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbInvetario]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbInvetario](
	[Articulo] [int] NOT NULL,
	[Bodega] [varchar](25) NOT NULL,
	[Estante] [varchar](25) NULL,
	[Maximo] [int] NULL,
	[Minimo] [int] NULL,
	[Movimiento] [int] NULL,
	[Rotacion] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbInvetarioAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbInvetarioAuditoria](
	[Articulo] [int] NOT NULL,
	[Bodega] [varchar](25) NOT NULL,
	[Estante] [varchar](25) NULL,
	[Maximo] [int] NULL,
	[Minimo] [int] NULL,
	[Movimiento] [int] NULL,
	[Rotacion] [int] NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbProveedor]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbProveedor](
	[ID] [int] NOT NULL,
	[Proveedor] [varchar](25) NULL,
	[Encargado] [varchar](25) NULL,
	[Direcion] [varchar](25) NULL,
	[Correo] [varchar](25) NULL,
	[Telefono] [varchar](25) NULL,
	[Articulo] [int] NULL,
 CONSTRAINT [PK_TbProveedor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbProveedorAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbProveedorAuditoria](
	[ID] [int] NOT NULL,
	[Proveedor] [varchar](25) NULL,
	[Encargado] [varchar](25) NULL,
	[Direcion] [varchar](25) NULL,
	[Correo] [varchar](25) NULL,
	[Telefono] [varchar](25) NULL,
	[Articulo] [int] NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbSucursal]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbSucursal](
	[Id] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[Direccion] [varchar](225) NOT NULL,
 CONSTRAINT [PK_TbSucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbSucursalAuditoria]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbSucursalAuditoria](
	[Id] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Telefono] [varchar](25) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[Direccion] [varchar](225) NOT NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[ModificadoEn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbTipoArticulo]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbTipoArticulo](
	[IdTipoArticulo] [int] NOT NULL,
	[Descripcion] [varchar](225) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbUsuarios]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbUsuarios](
	[Usuario] [varchar](50) NOT NULL,
	[Clave] [varchar](50) NULL,
	[TipoUsuarioRol] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TbArticulo]  WITH CHECK ADD  CONSTRAINT [FK_TbArticulo_TbProveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[TbProveedor] ([ID])
GO
ALTER TABLE [dbo].[TbArticulo] CHECK CONSTRAINT [FK_TbArticulo_TbProveedor]
GO
ALTER TABLE [dbo].[TbDetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbDetalleFactura_TbArticulo] FOREIGN KEY([CodigoArticulo])
REFERENCES [dbo].[TbArticulo] ([ID])
GO
ALTER TABLE [dbo].[TbDetalleFactura] CHECK CONSTRAINT [FK_TbDetalleFactura_TbArticulo]
GO
ALTER TABLE [dbo].[TbDetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbDetalleFactura_TbFactura] FOREIGN KEY([NumeroFactura])
REFERENCES [dbo].[TbFactura] ([NumeroFactura])
GO
ALTER TABLE [dbo].[TbDetalleFactura] CHECK CONSTRAINT [FK_TbDetalleFactura_TbFactura]
GO
ALTER TABLE [dbo].[TbFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbFactura_TbCajero] FOREIGN KEY([IdCajero])
REFERENCES [dbo].[TbCajero] ([Cedula])
GO
ALTER TABLE [dbo].[TbFactura] CHECK CONSTRAINT [FK_TbFactura_TbCajero]
GO
ALTER TABLE [dbo].[TbFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbFactura_TbCliente] FOREIGN KEY([CedulaCliente])
REFERENCES [dbo].[TbCliente] ([Cedula])
GO
ALTER TABLE [dbo].[TbFactura] CHECK CONSTRAINT [FK_TbFactura_TbCliente]
GO
ALTER TABLE [dbo].[TbFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbFactura_TbFormaPago] FOREIGN KEY([IdPago])
REFERENCES [dbo].[TbFormaPago] ([ID])
GO
ALTER TABLE [dbo].[TbFactura] CHECK CONSTRAINT [FK_TbFactura_TbFormaPago]
GO
ALTER TABLE [dbo].[TbFactura]  WITH CHECK ADD  CONSTRAINT [FK_TbFactura_TbSucursal] FOREIGN KEY([Sucursal])
REFERENCES [dbo].[TbSucursal] ([Id])
GO
ALTER TABLE [dbo].[TbFactura] CHECK CONSTRAINT [FK_TbFactura_TbSucursal]
GO
ALTER TABLE [dbo].[TbInvetario]  WITH CHECK ADD  CONSTRAINT [FK_TbInvetario_TbArticulo] FOREIGN KEY([Articulo])
REFERENCES [dbo].[TbArticulo] ([ID])
GO
ALTER TABLE [dbo].[TbInvetario] CHECK CONSTRAINT [FK_TbInvetario_TbArticulo]
GO
ALTER TABLE [dbo].[TbSucursal]  WITH CHECK ADD  CONSTRAINT [FK_TbSucursal_TbEmpresa] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[TbEmpresa] ([Id])
GO
ALTER TABLE [dbo].[TbSucursal] CHECK CONSTRAINT [FK_TbSucursal_TbEmpresa]
GO
ALTER TABLE [dbo].[TbTipoArticulo]  WITH CHECK ADD  CONSTRAINT [FK_TbTipoArticulo_TbArticulo] FOREIGN KEY([IdTipoArticulo])
REFERENCES [dbo].[TbArticulo] ([ID])
GO
ALTER TABLE [dbo].[TbTipoArticulo] CHECK CONSTRAINT [FK_TbTipoArticulo_TbArticulo]
GO
/****** Object:  StoredProcedure [dbo].[ListaClientes]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListaClientes]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Cedula,Nombre,PrimerApellido,SegundoApellido
	from dbo.TbCliente;
END
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoArticulo]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SptMantenimientoArticulo]

	@pCodigo int,
	@pDescripcion varchar(225) ,
	@pPrecioVenta int ,
	@pPrecioCosto int ,
	@pStock int ,
	@pIdTipo int ,
	@pIdProveedor int ,
	@pFechaIngreso date,
	@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbArticulo(ID,Descripcion,PrecioVenta,PrecioCosto,Stock,IdTipo,IdProveedor,FechaIngreso)
	VALUES(@pCodigo,@pDescripcion,@pPrecioVenta,@pPrecioCosto,@pStock,@pIdTipo,@pIdProveedor,@pFechaIngreso);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbArticulo
	set ID = @pCodigo,Descripcion = @pDescripcion,PrecioVenta = @pPrecioVenta,PrecioCosto = @pPrecioCosto,Stock = @pStock,IdTipo = @pIdTipo,IdProveedor = @pIdProveedor,FechaIngreso = @pFechaIngreso
	where ID = @pCodigo;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbArticulo
	where ID = @pCodigo;
end
	else if (@pAccion = 'S')
begin
	select ID,Descripcion,PrecioVenta,PrecioCosto,Stock,IdTipo,IdProveedor,FechaIngreso
	from dbo.TbArticulo;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoCliente]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SptMantenimientoCliente]

	@pCedula int,
	@pNombre nvarchar(50) ,
	@pPrimerApellido nvarchar(50) ,
	@pSegundoApellido nvarchar(50) ,
	@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbCliente(Cedula,Nombre,PrimerApellido,SegundoApellido)
	VALUES(@pCedula,@pNombre,@pPrimerApellido,@pSegundoApellido);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbCliente
	set  Nombre = @pNombre, PrimerApellido = @pPrimerApellido,SegundoApellido = @pSegundoApellido
	where Cedula = @pCedula;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbCliente
	where Cedula = @pCedula;
end
	else if (@pAccion = 'S')
begin
	select top 1000 Cedula,Nombre,PrimerApellido,SegundoApellido
	from dbo.TbCliente;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoFactura]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SptMantenimientoFactura]

@pNumeroFactura int,
@pCliente int,
@pNombreEmpleado varchar(50), 
@pFechaFacturacion date, 
@pIdPago	int,
@pTotalFactura decimal(10,0),
@pIVA int,
@pIdCajero int,
@pSucursal int,
@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbFactura(NumeroFactura,CedulaCliente,NombreEmpleado,FechaFacturacion,IdPago,TotalFactura,IVA,IdCajero,Sucursal)
	VALUES(@pNumeroFactura,@pCliente,@pNombreEmpleado,@pFechaFacturacion,@pIdPago,@pTotalFactura,@pIVA,@pIdCajero,@pSucursal);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbFactura
	set CedulaCliente = @pCliente,NombreEmpleado = @pNombreEmpleado,FechaFacturacion = @pFechaFacturacion,
	IdPago = @pIdPago,TotalFactura = @pTotalFactura,IVA = @pIVA,IdCajero = @pIdCajero,Sucursal = @pSucursal
	where NumeroFactura = @pNumeroFactura;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbFactura
	where NumeroFactura = @pNumeroFactura;
end
	else if (@pAccion = 'S')
begin
	select NumeroFactura,CedulaCliente,NombreEmpleado,FechaFacturacion,IdPago,TotalFactura,IVA,IdCajero,Sucursal
	from dbo.TbFactura;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoInventario]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SptMantenimientoInventario]

	@pIdArticulo int,
	@pBodega varchar(25),
	@pEstante varchar(25), 
	@pMaximo int, 
	@pMinimo int,
	@pMovimiento int,
	@pRotacion int,
	@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbInvetario(Articulo,Bodega,Estante,Maximo,Minimo,Movimiento,Rotacion)
	VALUES(@pIdArticulo,@pBodega,@pEstante,@pMaximo,@pMinimo,@pMovimiento,@pRotacion);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbInvetario
	set Bodega = @pBodega ,Estante=@pEstante,Maximo=@pMaximo,Minimo=@pMinimo,Movimiento=@pMovimiento,Rotacion=@pRotacion
	where Articulo = @pIdArticulo;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbInvetario
	where Articulo = @pIdArticulo;
end
	else if (@pAccion = 'S')
begin
	select Articulo,Bodega,Estante,Maximo,Minimo,Movimiento,Rotacion
	from dbo.TbInvetario;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoProveedor]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SptMantenimientoProveedor]

@pCodigo int,
@pProveedor varchar(25),
@pEncargado varchar(25), 
@pDireccion varchar(25), 
@pCorreo	varchar(25),
@pTelefono varchar(25),
@pArticulo int,
@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbProveedor(ID,Proveedor,Encargado,Direcion,Correo,Telefono,Articulo)
	VALUES(@pCodigo,@pProveedor,@pEncargado,@pDireccion,@pCorreo,@pTelefono,@pArticulo);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbProveedor
	set Proveedor = @pProveedor,Encargado = @pEncargado,Direcion = @pDireccion,Correo = @pCorreo,Telefono = @pTelefono,Articulo = @pArticulo
	where ID = @pCodigo;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbProveedor
	where ID = @pCodigo;
end
	else if (@pAccion = 'S')
begin
	select ID,Proveedor,Encargado,Direcion,Correo,Telefono,Articulo
	from dbo.TbProveedor;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[SptMantenimientoSucursal]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SptMantenimientoSucursal]

@pCodigo int,
@pIdEmpresa int,
@pNombre varchar(25), 
@pTelfono varchar(25), 
@pEmail	varchar(25),
@pDireccion varchar(50),
@pAccion varchar(1)
as
Begin
	if ( @pAccion = 'I')
Begin
	INSERT INTO dbo.TbSucursal(Id,IdEmpresa,Nombre,Telefono,Email,Direccion)
	VALUES(@pCodigo,@pIdEmpresa,@pNombre,@pTelfono,@pEmail,@pDireccion);
end
	else if (@pAccion = 'M')
begin
	update dbo.TbSucursal
	set IdEmpresa = @pIdEmpresa , Nombre = @pNombre, Telefono = @pTelfono, Email = @pEmail, Direccion = @pDireccion
	where Id = @pCodigo;
end
	else if (@pAccion = 'E')
begin
	delete
	from dbo.TbSucursal
	where Id = @pCodigo;
end
	else if (@pAccion = 'S')
begin
	select Id,IdEmpresa,Nombre,Telefono,Email,Direccion
	from dbo.TbSucursal;
end;


End;
GO
/****** Object:  StoredProcedure [dbo].[StpValidarUsuario]    Script Date: 11 nov. 2021 17:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StpValidarUsuario]
	-- Add the parameters for the stored procedure here
	@pUsuario varchar(50),
	@pClave varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Usuario, Clave, TipoUsuarioRol
	FROM TbUsuarios
	WHERE Usuario = @pUsuario AND Clave = @pClave
END
GO
