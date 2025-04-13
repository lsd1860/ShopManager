USE [SHOPMANAGER]
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_SELECT_MEMBER_ID]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오후 12:17:56
	실행   : SELECT * FROM TB_WORK
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_SELECT_MEMBER_ID]
	@MEMBER_ID	int

AS

BEGIN

	SELECT 
		WORK_ID,
		WORK_DT,
		WORK_AMT
	FROM TB_WORK
	WHERE	MEMBER_ID	=	@MEMBER_ID
	ORDER BY WORK_DT DESC

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-28 오전 9:50:58
	실행   : SELECT * FROM TB_WORK
	참조   : 1)USP_TB_WORK_SELECT 0
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_SELECT]
	@WORK_ID	int
AS

BEGIN

	SELECT 		
		WORK_DT,
		WORK_AMT
	FROM TB_WORK
	WHERE	WORK_ID=@WORK_ID

	SELECT
		CLINIC_NAME,
		PRICE,
		QTY,
		PRICE*QTY as AMT
	--SELECT *
	FROM [dbo].[TB_WORK_CLINIC]
	WHERE WORK_ID = @WORK_ID
	ORDER BY CLINIC_NAME


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_SAVE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-28 오후 1:07:33
	실행   : SELECT * FROM TB_WORK
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_SAVE]
	@WORK_ID	int,
	@MEMBER_ID	int,
	@WORK_DT		char(10),
	@WORK_AMT	int

AS

BEGIN

	IF EXISTS (
		SELECT * FROM TB_WORK
		WHERE	WORK_ID	=	@WORK_ID

	)
	BEGIN
		UPDATE TB_WORK SET 
			WORK_DT		=	@WORK_DT,
			WORK_AMT	=	@WORK_AMT
		WHERE	WORK_ID	=	@WORK_ID

	END
	ELSE
	BEGIN
		INSERT INTO TB_WORK (
			MEMBER_ID,
			WORK_DT,
			WORK_AMT
		) VALUES ( 
			@MEMBER_ID,
			@WORK_DT,
			@WORK_AMT
		) 
		SET @WORK_ID= @@IDENTITY
	END
		

	SELECT @WORK_ID AS WORK_ID
END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-28 오후 2:14:26
	실행   : SELECT * FROM TB_WORK
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_DELETE]
	@WORK_ID	int

AS

BEGIN

	DELETE FROM TB_WORK
	WHERE	WORK_ID	=	@WORK_ID


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_CLINIC_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오후 12:47:45
	실행   : SELECT * FROM TB_WORK_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_CLINIC_SELECT]
	@WORK_ID	int

AS

BEGIN

	SELECT 
		WORK_ID,
		CLINIC_NAME,
		PRICE,
		QTY,
		PRICE*QTY as AMT
	FROM TB_WORK_CLINIC
	WHERE	WORK_ID	=	@WORK_ID


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_CLINIC_INSERT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-28 오후 1:53:11
	실행   : SELECT * FROM TB_WORK_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_CLINIC_INSERT]
	@WORK_ID	int,
	@CLINIC_NAME	varchar(50),
	@PRICE	int,
	@QTY	int
AS

BEGIN

	INSERT INTO TB_WORK_CLINIC (
		WORK_ID,
		CLINIC_NAME,
		PRICE,
		QTY
	) VALUES ( 
		@WORK_ID,
		@CLINIC_NAME,
		@PRICE,
		@QTY
	) 


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_WORK_CLINIC_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-28 오후 1:01:18
	실행   : SELECT * FROM TB_WORK_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_WORK_CLINIC_DELETE]
	@WORK_ID	int

AS

BEGIN

	DELETE FROM TB_WORK_CLINIC
	WHERE	WORK_ID	=	@WORK_ID


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_SELECT_MEMBER_ID]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오후 5:24:40
	실행   : SELECT * FROM TB_SALE
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_SELECT_MEMBER_ID]
	@MEMBER_ID	int

AS

BEGIN

	SELECT 
		SALE_ID,
		SALE_DT,
		SALE_AMT
	FROM TB_SALE
	WHERE	MEMBER_ID	=	@MEMBER_ID
	ORDER BY SALE_DT DESC

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오전 10:27:43
	실행   : SELECT * FROM TB_SALE
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_SELECT]
	@SALE_ID	int

AS

BEGIN

	SELECT 
		SALE_DT,
		SALE_AMT
	FROM TB_SALE
	WHERE	SALE_ID	=	@SALE_ID

	SELECT
		PRODUCT_NAME,
		PRICE,
		QTY,
		PRICE * QTY as AMT
	--SELECT *
	FROM [dbo].[TB_SALE_PRODUCT]
	WHERE SALE_ID	=	@SALE_ID
	ORDER BY PRODUCT_NAME

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_SAVE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오전 10:47:40
	실행   : SELECT * FROM TB_SALE
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_SAVE]
	@SALE_ID	int,
	@MEMBER_ID	int,
	@SALE_DT	char(10),
	@SALE_AMT	int

AS

BEGIN

	IF EXISTS (
		SELECT * FROM TB_SALE
		WHERE	SALE_ID	=	@SALE_ID

	)
	BEGIN
		UPDATE TB_SALE SET 
			MEMBER_ID	=	@MEMBER_ID,
			SALE_DT	=	@SALE_DT,
			SALE_AMT	=	@SALE_AMT
		WHERE	SALE_ID	=	@SALE_ID


	END
	ELSE
	BEGIN
		INSERT INTO TB_SALE (
			MEMBER_ID,
			SALE_DT,
			SALE_AMT
		) VALUES ( 
			@MEMBER_ID,
			@SALE_DT,
			@SALE_AMT
		) 
		SET @SALE_ID= @@IDENTITY
	END
	SELECT @SALE_ID AS SALE_ID
END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_PRODUCT_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오후 5:27:01
	실행   : SELECT * FROM TB_SALE_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_PRODUCT_SELECT]
	@SALE_ID	int

AS

BEGIN

	SELECT 
		SALE_ID,
		PRODUCT_NAME,
		PRICE,
		QTY,
		PRICE*QTY as AMT
	FROM TB_SALE_PRODUCT
	WHERE	SALE_ID	=	@SALE_ID


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_PRODUCT_INSERT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오전 10:52:39
	실행   : SELECT * FROM TB_SALE_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_PRODUCT_INSERT]
	@SALE_ID	int,
	@PRODUCT_NAME	varchar(50),
	@PRICE	int,
	@QTY int

AS

BEGIN

	INSERT INTO TB_SALE_PRODUCT (
		SALE_ID,
		PRODUCT_NAME,
		PRICE,
		QTY
	) VALUES ( 
		@SALE_ID,
		@PRODUCT_NAME,
		@PRICE,
		@QTY
	) 

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_PRODUCT_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오전 10:51:49
	실행   : SELECT * FROM TB_SALE_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_SALE_PRODUCT_DELETE]
	@SALE_ID	int

AS

BEGIN

	DELETE FROM TB_SALE_PRODUCT
	WHERE	SALE_ID	=	@SALE_ID


END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_SALE_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오전 10:53:50
	실행   : SELECT * FROM TB_SALE
	참조   : 1)
	       : 2)
===================================================================================
*/

create PROCEDURE [dbo].[USP_TB_SALE_DELETE]
	@SALE_ID	int

AS

BEGIN

	DELETE FROM TB_SALE
	WHERE	SALE_ID	=	@SALE_ID

	DELETE FROM [dbo].[TB_SALE_PRODUCT]
	WHERE	SALE_ID	=	@SALE_ID

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_PRODUCT_SELECT_AVAIL]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:22:47
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

create PROCEDURE [dbo].[USP_TB_PRODUCT_SELECT_AVAIL]


AS

BEGIN

	SELECT 
		PRODUCT_NAME,
		PRICE
	FROM TB_PRODUCT
	where USE_YN = 1
	ORDER BY	PRODUCT_NAME


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_PRODUCT_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:41:27
	실행   : SELECT * FROM TB_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_PRODUCT_SELECT]
	

AS

BEGIN

	SELECT 
		PRODUCT_ID,
		PRODUCT_NAME,
		PRICE,
		USE_YN
	FROM TB_PRODUCT
	ORDER BY PRODUCT_NAME


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_PRODUCT_SAVE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:42:09
	실행   : SELECT * FROM TB_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_PRODUCT_SAVE]
	@PRODUCT_ID	int,
	@PRODUCT_NAME	varchar(50),
	@PRICE	int,
	@USE_YN	bit

AS

BEGIN

	IF @PRODUCT_ID > 0
	BEGIN
		UPDATE TB_PRODUCT SET 
			PRODUCT_NAME	=	@PRODUCT_NAME,
			PRICE	=	@PRICE,
			USE_YN	=	@USE_YN
		WHERE	PRODUCT_ID	=	@PRODUCT_ID


	END
	ELSE
	BEGIN
		INSERT INTO TB_PRODUCT (
			PRODUCT_NAME,
			PRICE,
			USE_YN
		) VALUES ( 
			@PRODUCT_NAME,
			@PRICE,
			@USE_YN
		) 

		SET @PRODUCT_ID = @@IDENTITY

	END

	SELECT @PRODUCT_ID AS PRODUCT_ID

END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_PRODUCT_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:44:47
	실행   : SELECT * FROM TB_PRODUCT
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_PRODUCT_DELETE]
	@PRODUCT_ID	int

AS

BEGIN

	DELETE FROM TB_PRODUCT
	WHERE	PRODUCT_ID	=	@PRODUCT_ID


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_MEMBER_SELECT_TODAY]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
===================================================================================
	개요   : 
	작성자 : 홍길동
	작성일 : 2024-08-29 오후 3:00:59
	실행   : SELECT * FROM TB_MEMBER
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_MEMBER_SELECT_TODAY]
	@AOM_DT	CHAR(10)

AS

BEGIN

	SELECT 
		MEMBER_ID,
		MEMBER_NAME,
		TELNO
	FROM TB_MEMBER
	WHERE MEMBER_ID IN (
		SELECT MEMBER_ID FROM [dbo].[TB_WORK]
		where WORK_DT = @AOM_DT
	)

END
GO

/****** Object:  StoredProcedure [dbo].[USP_TB_MEMBER_SELECT_ALL]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:40:30
	실행   : SELECT * FROM TB_MEMBER
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_MEMBER_SELECT_ALL]

AS

BEGIN

	SELECT 
		MEMBER_ID,
		MEMBER_NAME,
		TELNO
	FROM TB_MEMBER
	ORDER BY MEMBER_NAME

END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_MEMBER_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:40:30
	실행   : SELECT * FROM TB_MEMBER
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_MEMBER_SELECT]
	@MEMBER_ID	int
AS

BEGIN

	SELECT 
		MEMBER_ID,
		MEMBER_NAME,
		TELNO,
		ADDRESS,
		ETC
	FROM TB_MEMBER
	WHERE MEMBER_ID = @MEMBER_ID

END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_MEMBER_SAVE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:41:29
	실행   : SELECT * FROM TB_MEMBER
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_MEMBER_SAVE]
	@MEMBER_ID		int,
	@MEMBER_NAME	varchar(50),
	@TELNO	varchar(50),
	@ADDRESS	varchar(250),
	@ETC	varchar(max)

AS

BEGIN

	IF @MEMBER_ID > 0
	BEGIN
		UPDATE TB_MEMBER SET 
			MEMBER_NAME	=	@MEMBER_NAME,
			TELNO	=	@TELNO,
			ADDRESS	=	@ADDRESS,
			ETC	=	@ETC
		WHERE	MEMBER_ID	=	@MEMBER_ID
	END
	ELSE
	BEGIN
		INSERT INTO TB_MEMBER (
			MEMBER_NAME,
			TELNO,
			ADDRESS,
			ETC
		) VALUES ( 
			@MEMBER_NAME,
			@TELNO,
			@ADDRESS,
			@ETC
		) 
		
		SET @MEMBER_ID = @@IDENTITY

	END

	SELECT @MEMBER_ID AS MEMBER_ID

END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_MEMBER_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:55:41
	실행   : SELECT * FROM TB_MEMBER
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_MEMBER_DELETE]
	@MEMBER_ID	int

AS

BEGIN

	DELETE FROM TB_MEMBER
	WHERE	MEMBER_ID	=	@MEMBER_ID

	DELETE FROM [dbo].[TB_WORK_CLINIC]
	WHERE WORK_ID iN (
		SELECT WORK_ID
		FROM [dbo].[TB_WORK]
		WHERE MEMBER_ID	=	@MEMBER_ID
	)
	
	DELETE FROM [dbo].[TB_WORK]
	WHERE MEMBER_ID	=	@MEMBER_ID

	DELETE FROM [dbo].[TB_SALE_PRODUCT]
	WHERE SALE_ID iN (
		SELECT SALE_ID
		FROM [dbo].[TB_SALE]
		WHERE MEMBER_ID	=	@MEMBER_ID
	)

	DELETE FROM [dbo].[TB_SALE]
	WHERE MEMBER_ID	=	@MEMBER_ID


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_CLINIC_SELECT_COMBO]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:22:47
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_CLINIC_SELECT_COMBO]


AS

BEGIN

	SELECT 
		'' AS CLINIC_NAME
	
	UNION ALL

	SELECT 
		CLINIC_NAME
	FROM TB_CLINIC
	where USE_YN = 1


	ORDER BY	CLINIC_NAME


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_CLINIC_SELECT_AVAIL]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:22:47
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_CLINIC_SELECT_AVAIL]


AS

BEGIN

	SELECT 
		CLINIC_NAME,
		PRICE
	FROM TB_CLINIC
	where USE_YN = 1
	ORDER BY	CLINIC_NAME


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_CLINIC_SELECT]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 8:22:47
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_CLINIC_SELECT]


AS

BEGIN

	SELECT *
	FROM TB_CLINIC
	ORDER BY	CLINIC_NAME


END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_CLINIC_SAVE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:37:09
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_CLINIC_SAVE]
	@CLINIC_ID	int,
	@CLINIC_NAME	varchar(50),
	@PRICE	int,
	@USE_YN	bit

AS

BEGIN

	IF @CLINIC_ID > 0
	BEGIN
		UPDATE TB_CLINIC SET 
			CLINIC_NAME	=	@CLINIC_NAME,
			PRICE	=	@PRICE,
			USE_YN	=	@USE_YN
		WHERE	CLINIC_ID	=	@CLINIC_ID


	END
	ELSE
	BEGIN
		INSERT INTO TB_CLINIC (
			CLINIC_NAME,
			PRICE,
			USE_YN
		) VALUES ( 
			@CLINIC_NAME,
			@PRICE,
			@USE_YN
		) 

		SET @CLINIC_ID = @@IDENTITY

	END


	SELECT @CLINIC_ID AS CLINIC_ID
END

GO

/****** Object:  StoredProcedure [dbo].[USP_TB_CLINIC_DELETE]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*
===================================================================================
	개요   : 
	작성자 : 이상덕[lsd2572395@naver.com]
	작성일 : 2024-08-27 오후 9:37:24
	실행   : SELECT * FROM TB_CLINIC
	참조   : 1)
	       : 2)
===================================================================================
*/

CREATE PROCEDURE [dbo].[USP_TB_CLINIC_DELETE]
	@CLINIC_ID	int

AS

BEGIN

	DELETE FROM TB_CLINIC
	WHERE	CLINIC_ID	=	@CLINIC_ID


END

GO

/****** Object:  StoredProcedure [dbo].[USP_GETDATA2222]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
USP_GETDATA '2024-08-01', '2024-08-31','','클리닉3'
*/
CREATE PROCEDURE [dbo].[USP_GETDATA2222]
	@FRDATE		CHAR(10),
	@TODATE		CHAR(10),
	@KEYWORD	VARCHAR(20),
	@KEYWORD2	VARCHAR(20)
AS

select
	AA.AOM_DT,
	AA.MEMBER_ID,
	BB.MEMBER_NAME,
	BB.TELNO,
	AA.AOM_ID,
	aa.KUBUN,
	AA.SNAME,
	AA.AMT
INTO #TEMP
from
(
	select 
		TA.WORK_DT AS AOM_DT,
		TA.MEMBER_ID,
		TA.WORK_ID AS AOM_ID,
		'클리닉' AS KUBUN,
		tb.CLINIC_NAME AS SNAME,
		ta.WORK_AMT AS AMT
	from [dbo].[TB_WORK] TA
	inner JOIN (
		select WORK_ID,
			case when count(*)=1
			then min(CLINIC_NAME)
			else min(CLINIC_NAME)+'외 '+convert(varchar(10),count(*)-1)+'건'
			end as CLINIC_NAME
		from [dbo].[TB_WORK_CLINIC]
		where CLINIC_NAME like '%'+@KEYWORD2+'%' or @KEYWORD2 = ''
		group by WORK_ID
	) TB
	ON TB.WORK_ID = TA.WORK_ID
	LEFT JOIN [dbo].[TB_MEMBER] TC
	ON TC.MEMBER_ID = TA.MEMBER_ID
	WHERE WORK_DT BETWEEN @FRDATE AND @TODATE
	
) aa
left join [dbo].[TB_MEMBER] bb
on bb.MEMBER_ID = AA.MEMBER_ID
WHERE BB.MEMBER_NAME LIKE '%'+@KEYWORD +'%'
OR BB.TELNO LIKE '%'+@KEYWORD +'%'
OR @KEYWORD = ''

SELECT * FROM #TEMP
SELECT SUM(AMT) AS TOT FROM #TEMP
GO

/****** Object:  StoredProcedure [dbo].[USP_GETDATA_test]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
USP_GETDATA '2024-08-01', '2024-08-31','','클리닉3'
*/
CREATE PROCEDURE [dbo].[USP_GETDATA_test]
	@FRDATE		CHAR(10),
	@TODATE		CHAR(10),
	@KEYWORD	VARCHAR(20),
	@KEYWORD2	VARCHAR(20)
AS

select
	AA.AOM_DT,
	AA.MEMBER_ID,
	BB.MEMBER_NAME,
	BB.TELNO,
	AA.AOM_ID,
	aa.KUBUN,
	AA.SNAME,
	AA.AMT
INTO #TEMP
from
(
	select 
		TA.WORK_DT AS AOM_DT,
		TA.MEMBER_ID,
		TA.WORK_ID AS AOM_ID,
		'클리닉' AS KUBUN,
		tb.CLINIC_NAME AS SNAME,
		ta.WORK_AMT AS AMT
	from [dbo].[TB_WORK] TA
	inner JOIN (
		select WORK_ID,
			STUFF(CLINIC_NAME, 1, CHARINDEX(',', CLINIC_NAME + ','), '')
			as CLINIC_NAME
		from [dbo].[TB_WORK_CLINIC]
		where CLINIC_NAME like '%'+@KEYWORD2+'%' or @KEYWORD2 = ''
		
	) TB
	ON TB.WORK_ID = TA.WORK_ID
	LEFT JOIN [dbo].[TB_MEMBER] TC
	ON TC.MEMBER_ID = TA.MEMBER_ID
	WHERE WORK_DT BETWEEN @FRDATE AND @TODATE
	
) aa
left join [dbo].[TB_MEMBER] bb
on bb.MEMBER_ID = AA.MEMBER_ID
WHERE BB.MEMBER_NAME LIKE '%'+@KEYWORD +'%'
OR BB.TELNO LIKE '%'+@KEYWORD +'%'
OR @KEYWORD = ''

SELECT * FROM #TEMP
SELECT SUM(AMT) AS TOT FROM #TEMP
GO

/****** Object:  StoredProcedure [dbo].[USP_GETDATA]    Script Date: 2024-09-02 오후 2:45:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
USP_GETDATA '2024-08-01', '2024-08-31','',''
*/
CREATE PROCEDURE [dbo].[USP_GETDATA]
	@FRDATE		CHAR(10),
	@TODATE		CHAR(10),
	@KEYWORD	VARCHAR(20),
	@KEYWORD2	VARCHAR(20)
AS


select
	AA.AOM_DT,
	AA.MEMBER_ID,
	BB.MEMBER_NAME,
	BB.TELNO,
	AA.AOM_ID,
	AA.SNAME,
	AA.AMT
INTO #TEMP
from
(
	select 
		TA.WORK_DT AS AOM_DT,
		TA.MEMBER_ID,
		TA.WORK_ID AS AOM_ID,
		(
			SELECT STUFF(
				(
					SELECT ','+ CLINIC_NAME FROM TB_WORK_CLINIC CC
					WHERE CC.WORK_ID = TA.WORK_ID
					FOR XML PATH ('')
				),1,1,'')
		) AS SNAME,
		ta.WORK_AMT AS AMT
	from [dbo].[TB_WORK] TA
	LEFT JOIN [dbo].[TB_MEMBER] TC
	ON TC.MEMBER_ID = TA.MEMBER_ID
	WHERE WORK_DT BETWEEN @FRDATE AND @TODATE
	AND 	WORK_ID IN (
		select WORK_ID
		from [dbo].[TB_WORK_CLINIC]
		where CLINIC_NAME like '%'+@KEYWORD2+'%' or @KEYWORD2 = ''
	)
) aa
left join [dbo].[TB_MEMBER] bb
on bb.MEMBER_ID = AA.MEMBER_ID
WHERE BB.MEMBER_NAME LIKE '%'+@KEYWORD +'%'
OR BB.TELNO LIKE '%'+@KEYWORD +'%'
OR @KEYWORD = ''

SELECT * FROM #TEMP
SELECT SUM(AMT) AS TOT FROM #TEMP
GO

