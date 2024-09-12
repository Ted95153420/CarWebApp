CREATE LOGIN edmilne WITH PASSWORD = 'Pru55iaRichard';
CREATE USER edmilne FOR LOGIN edmilne;
USE VehicleIntelDb;
ALTER ROLE db_datareader ADD MEMBER edmilne;
ALTER ROLE db_datawriter ADD MEMBER edmilne;