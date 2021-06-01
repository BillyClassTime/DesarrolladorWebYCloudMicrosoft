USE [master]
GO
CREATE USER [billy] FOR LOGIN [billy]
GO
ALTER LOGIN [billy] WITH PASSWORD=N'1234', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
Go
/*USE [ZooDb2020v20]*/
GO
/*GRANT CONNECT to [billy]  Conectarse con el usuario de la BD (billy)*/
GO
ALTER ROLE [db_datareader] ADD MEMBER [billy]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [billy]
GO
ALTER ROLE [db_owner] ADD MEMBER [billy]
GO
select db_name() as [database_name], r.[name] as [role], p.[name] as [member] from  
    sys.database_role_members m 
join 
    sys.database_principals r on m.role_principal_id = r.principal_id 
join 
    sys.database_principals p on m.member_principal_id = p.principal_id 
where 
    r.name = 'db_owner'

grant create table to [billy]

grant control on user::sa to billy

Alter login sa enable;

Alter login sa with password = '1234'