USE [ProyectoJuan]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conocimientos]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conocimientos](
	[id_conocimientos] [int] IDENTITY(1,1) NOT NULL,
	[conocimientos] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Conocimientos] PRIMARY KEY CLUSTERED 
(
	[id_conocimientos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[curso_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_curso] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[curso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Noticia]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Noticia](
	[id_noticia] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[copete] [varchar](50) NOT NULL,
	[texto] [text] NOT NULL,
	[orden] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[activa] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[foto] [varchar](50) NULL,
	[imagen] [varchar](1000) NULL,
 CONSTRAINT [PK_Noticia] PRIMARY KEY CLUSTERED 
(
	[id_noticia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](50) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [varchar](12) NULL,
	[email] [varchar](50) NULL,
	[id_pais] [int] NOT NULL,
	[curso_id] [int] NOT NULL,
	[fecha_nacimiento] [date] NULL,
	[conocimientos] [varchar](1000) NULL,
	[contraseña] [varchar](50) NULL,
	[confirmar_contraseña] [varchar](50) NULL,
	[perfil_id] [int] NULL,
	[otrosconocimientos] [varchar](1000) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id], [descripcion]) VALUES (1, N'Deportes')
INSERT [dbo].[Categoria] ([id], [descripcion]) VALUES (2, N'Politicas')
INSERT [dbo].[Categoria] ([id], [descripcion]) VALUES (3, N'Sociales')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Conocimientos] ON 

INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (1, N'.NET')
INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (2, N'SQL SERVER')
INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (3, N'JQUERY')
INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (4, N'HTML')
INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (5, N'CSS')
INSERT [dbo].[Conocimientos] ([id_conocimientos], [conocimientos]) VALUES (6, N'JAVASCRIPT')
SET IDENTITY_INSERT [dbo].[Conocimientos] OFF
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([curso_id], [nombre_curso]) VALUES (1, N'.NET      ')
INSERT [dbo].[Curso] ([curso_id], [nombre_curso]) VALUES (2, N'JAVA      ')
INSERT [dbo].[Curso] ([curso_id], [nombre_curso]) VALUES (5, N'DISEÑO UX ')
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[Noticia] ON 

INSERT [dbo].[Noticia] ([id_noticia], [titulo], [copete], [texto], [orden], [fecha], [activa], [id_categoria], [foto], [imagen]) VALUES (13, N'Noticia 5', N'Noticia', N'Noticia', 1, CAST(N'2010-02-10T00:00:00.000' AS DateTime), 1, 1, NULL, N'8210d11d-90a5-463f-9b89-3ae992d81ba2.jpg')
INSERT [dbo].[Noticia] ([id_noticia], [titulo], [copete], [texto], [orden], [fecha], [activa], [id_categoria], [foto], [imagen]) VALUES (14, N'Noticia 8', N'Noticia', N'Noti', 2, CAST(N'2001-09-20T00:00:00.000' AS DateTime), 1, 1, NULL, N'20573fc6-c06c-4462-a1bf-f3276076c6b2.jpg')
SET IDENTITY_INSERT [dbo].[Noticia] OFF
GO
SET IDENTITY_INSERT [dbo].[Pais] ON 

INSERT [dbo].[Pais] ([id_pais], [pais]) VALUES (1, N'Argentina')
INSERT [dbo].[Pais] ([id_pais], [pais]) VALUES (2, N'Uruguay')
INSERT [dbo].[Pais] ([id_pais], [pais]) VALUES (3, N'Brasil')
INSERT [dbo].[Pais] ([id_pais], [pais]) VALUES (4, N'Chile')
SET IDENTITY_INSERT [dbo].[Pais] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [nombre], [apellido], [dni], [email], [id_pais], [curso_id], [fecha_nacimiento], [conocimientos], [contraseña], [confirmar_contraseña], [perfil_id], [otrosconocimientos]) VALUES (11, N'Julian', N'Alvarez', N'3423', N'julian@gmail.com', 1, 2, CAST(N'2000-03-14' AS Date), N'', N'julian', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [nombre], [apellido], [dni], [email], [id_pais], [curso_id], [fecha_nacimiento], [conocimientos], [contraseña], [confirmar_contraseña], [perfil_id], [otrosconocimientos]) VALUES (12, N'Andres', N'Martinez', N'14848', N'andres@gmail.com', 1, 5, CAST(N'2000-03-22' AS Date), N'', N'andres', NULL, NULL, NULL)
INSERT [dbo].[Usuarios] ([id], [nombre], [apellido], [dni], [email], [id_pais], [curso_id], [fecha_nacimiento], [conocimientos], [contraseña], [confirmar_contraseña], [perfil_id], [otrosconocimientos]) VALUES (13, N'Juan', N'Catullo', N'44242162', N'juancatullo99@gmail.com', 1, 1, CAST(N'2002-10-06' AS Date), N'', N'Juaan123', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Noticia]  WITH CHECK ADD  CONSTRAINT [FK_Noticia_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id])
GO
ALTER TABLE [dbo].[Noticia] CHECK CONSTRAINT [FK_Noticia_Categoria]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK__Usuarios__curso___5AEE82B9] FOREIGN KEY([curso_id])
REFERENCES [dbo].[Curso] ([curso_id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK__Usuarios__curso___5AEE82B9]
GO
/****** Object:  StoredProcedure [dbo].[spActualizarNoticia]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spActualizarNoticia]
	@id as int,
	@titulo as varchar (50),
	@copete as varchar (50),
	@texto as text,
	@imagen as varchar (50),
	@orden as int,
	@fecha as date,
	@activo as int,
	@id_categoria as int
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Noticia
	Set 
	titulo = @titulo,
	copete = @copete,
	texto = @texto,
	imagen = @imagen,
	orden = @orden,
	fecha = @fecha,
	activa = @activo,
	id_categoria = @id_categoria
    where id_noticia = @id

	


END
GO
/****** Object:  StoredProcedure [dbo].[spActualizarUsuario]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spActualizarUsuario]
	-- Add the parameters for the stored procedure here
	@id as int,
	@nombre as varchar (50),
	@apellido as varchar (50),
	@dni as varchar (50),
	@email as varchar (50),
	@id_pais as int,
	@curso_id as int,
	@fecha_nacimiento as datetime,
	@conocimientos as varchar (50),
	@contraseña as varchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Usuarios
	Set nombre = @nombre,
	apellido = @apellido,
	dni = @dni,
	email = @email,
	id_pais = @id_pais,
	curso_id = @curso_id,
	fecha_nacimiento = @fecha_nacimiento,
	conocimientos = @conocimientos,
	contraseña = @contraseña
	Where id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[spCursos]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCursos] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP (100) PERCENT curso_id, nombre_curso
	FROM dbo.Curso
	ORDER BY Curso_id
END
GO
/****** Object:  StoredProcedure [dbo].[spEliminarNoticia]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarNoticia]
	@id_noticia int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Noticia WHERE id_noticia = @id_noticia
END
GO
/****** Object:  StoredProcedure [dbo].[spEliminarUsuario]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spEliminarUsuario]
	-- Add the parameters for the stored procedure here
@id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from usuarios WHERE id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarNoticia]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertarNoticia]

	@titulo as varchar (50),
	@copete as varchar (50),
	@texto text,
	@imagen as varchar (50),
	@orden as int,
	@fecha as datetime,
	@activo as int,
	@id_categoria as int
	






AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Noticia
	(
	titulo,
	copete,
	texto,
	imagen,
	orden,
	fecha,
	activa,
	id_categoria
	)
	Values 
	(
	@titulo,
	@copete,
	@texto,
	@imagen,
	@orden,
	@fecha,
	@activo,
	@id_categoria
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarUsuario]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertarUsuario]
	-- Add the parameters for the stored procedure her
	@nombre as varchar (50),
	@apellido as varchar (50),
	@dni as varchar (50),
	@email as varchar (50),
	@id_pais as int,
	@curso_id as int,
	@fecha_nacimiento as datetime,
	@conocimientos as varchar (50),
    @contraseña as varchar (50)




AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Usuarios
	(nombre, apellido, dni, id_pais, email, curso_id, fecha_nacimiento, conocimientos, contraseña)
	Values 
	(@nombre, @apellido, @dni, @id_pais, @email, @curso_id, @fecha_nacimiento, 	@conocimientos, @contraseña)
	

END
GO
/****** Object:  StoredProcedure [dbo].[spLoginUsuario]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spLoginUsuario]
@usuario as varchar (50),
@clave as varchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Usuarios where email = @usuario and contraseña = @clave
END

GO
/****** Object:  StoredProcedure [dbo].[spObtenerCategoriasNoticias]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spObtenerCategoriasNoticias]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Categoria order by descripcion asc
END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerConocimientos]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spObtenerConocimientos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP 100 PERCENT id, descripcion
	FROM dbo.SPConocimientos
	ORDER BY descripcion
END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerNoticia]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spObtenerNoticia]
@id as int

	AS
BEGIN

   

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id_noticia, titulo, copete, texto ,orden, fecha, activa, id_categoria, imagen from Noticia where id_noticia = @id 
END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerNoticias]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spObtenerNoticias]
 @activo as int = -1,
 @categoria_id as int = -1
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT noticia.*, Categoria.descripcion FROM noticia INNER JOIN categoria ON noticia.id_categoria = categoria.id
    where (@activo = -1 or @activo = activa) And (@categoria_id = -1 or @categoria_id = id_categoria)
    order by Orden asc, Fecha desc



END
GO
/****** Object:  StoredProcedure [dbo].[spObtenerUsuariosRegistrados]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spObtenerUsuariosRegistrados]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id, nombre, apellido, dni, email, id_pais, curso_id, fecha_nacimiento, conocimientos, contraseña,confirmar_contraseña, otrosconocimientos from Usuarios order by apellido asc
END
GO
/****** Object:  StoredProcedure [dbo].[spPaises]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spPaises] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP (100) PERCENT id_pais, pais
	FROM dbo.Pais
	ORDER BY id_pais
END
GO
/****** Object:  StoredProcedure [dbo].[spUsuarios]    Script Date: 16/5/2023 11:43:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarios]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP (100) PERCENT id, nombre, apellido, dni, email, pais_id, curso_id, fecha_nacimiento, conocimientos, contraseña
	FROM dbo.Usuarios
	ORDER BY id, nombre, apellido, dni, email, pais_id, curso_id, fecha_nacimiento, conocimientos, contraseña
END
GO
