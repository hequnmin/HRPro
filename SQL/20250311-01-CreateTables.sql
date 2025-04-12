----------------------------------------------------------------------------------------------------
-- HR PostgreSQL script.
----------------------------------------------------------------------------------------------------
-- Table: public.Company

DROP TABLE public.Company;

CREATE TABLE public.Company
(
    CompanyID serial NOT NULL,
    CompanyNO varchar(50) NOT NULL,
    CompanyName varchar(50) NOT NULL,
	CompanyNameEnglish varchar(50) NOT NULL,
    Address varchar(200),
	Website varchar(200),
	RegistrationNumber varchar(50),			-- 统一社会信用代码
	LegalRepresentativeName varchar(50),	-- 法定代表人
    Phone varchar(50),
	Email varchar(100),
	Founded date,							-- 创立日期
    Description varchar(500),				-- 公司简介
    CONSTRAINT Company_pkey PRIMARY KEY (CompanyID)
);

----------------------------------------------------------------------------------------------------

-- Table: public.Dept

DROP TABLE public.Dept;

CREATE TABLE public.Dept
(
    DeptID serial NOT NULL,
    DeptNO varchar(50),
    DeptName varchar(50),
	DeptFullName varchar(200),
	DeptPath varchar(200),
    CompanyID integer NOT NULL,
    ParentID integer,
    Disused boolean NOT NULL,
    SortNO varchar(50),
	SortPath varchar(200),
    Remark varchar(200),
    CONSTRAINT Dept_pkey PRIMARY KEY (DeptID)
);

----------------------------------------------------------------------------------------------------
-- Table: public.EmployeeBase
DROP TABLE public.EmployeeBase;

CREATE TABLE public.EmployeeBase
(
	EmployeeID serial NOT NULL,
	EmployeeNO varchar(50) NOT NULL,
	EmployeeName varchar(50) NOT NULL,
	EmployeeCard varchar(50) NOT NULL,
	CompanyID int NOT NULL,
	DeptID int NOT NULL,
	Sex varchar(10) NOT NULL,
	Birthday date,
	IDNumber varchar(50),
	IDValid date,
	HireDate
    CONSTRAINT EmployeeBase_pkey PRIMARY KEY (EmployeeID)
);

----------------------------------------------------------------------------------------------------
