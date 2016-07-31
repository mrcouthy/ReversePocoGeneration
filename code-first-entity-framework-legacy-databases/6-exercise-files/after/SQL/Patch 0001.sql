USE efdemo
GO

ALTER TABLE engineer_person ADD
    date_added DATETIME NOT NULL DEFAULT GETDATE()
GO
