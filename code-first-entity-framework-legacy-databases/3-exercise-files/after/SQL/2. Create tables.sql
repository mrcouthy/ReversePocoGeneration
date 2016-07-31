USE efdemofilter
GO

CREATE TABLE company ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), company_name VARCHAR(100) NOT NULL );
CREATE TABLE company_billing_annual ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), some_date DATETIME NOT NULL, amount MONEY, company_id INT NOT NULL );
CREATE TABLE company_billing_ledger ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), some_date DATETIME NOT NULL, amount MONEY, company_id INT NOT NULL );
CREATE TABLE company_reports ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), report_name VARCHAR(100) NOT NULL, some_data VARCHAR(255) NULL );
CREATE TABLE company_events ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), event_name VARCHAR(100) );
CREATE TABLE user_events ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), event_name VARCHAR(100) );
CREATE TABLE user_history ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL, event_id INT NOT NULL);
CREATE TABLE user_logon ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), username VARCHAR(100) NOT NULL, [password] VARCHAR(100) NOT NULL);
CREATE TABLE user_bill ( id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), [user_id] INT NOT NULL FOREIGN KEY ([user_id]) REFERENCES user_logon(id), amount MONEY );
GO

-- Create 500 another_event* tables
DECLARE @sql NVARCHAR(255);
DECLARE @count INT = 0;
DECLARE @count_string VARCHAR(5)
WHILE(@count < 500)
BEGIN
    SET @count = @count + 1
    SET @count_string = RIGHT('00' + CAST(@count AS varchar(3)), 3);
    SET @sql = 'CREATE TABLE another_event' + @count_string + ' (id INT NOT NULL PRIMARY KEY, added DATETIME NOT NULL DEFAULT GETDATE(), id_other INT NOT NULL'
    IF(@count > 1)
        SET @sql = @sql + ' FOREIGN KEY (id_other) REFERENCES another_event' + RIGHT('00' + CAST(@count-1 AS varchar(3)), 3) + ' (id) );'
    ELSE
        SET @sql = @sql + ');'

    EXEC sys.sp_executesql @sql
END
GO


-- Drop 500 another_event* tables
DECLARE @sql NVARCHAR(255);
DECLARE @count INT = 500;
DECLARE @count_string VARCHAR(5)
WHILE(@count > 0)
BEGIN
    SET @count_string = RIGHT('00' + CAST(@count AS varchar(3)), 3);
    SET @sql = 'DROP TABLE another_event' + @count_string
    SET @count = @count - 1

    EXEC sys.sp_executesql @sql
END
GO