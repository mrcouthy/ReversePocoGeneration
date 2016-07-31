USE Northwind
GO

-- List extended properties
SELECT  s.name AS [schema],
        t.name AS [table],
        c.name AS [column],
        value AS [property],ep.*
FROM    sys.extended_properties AS ep
        INNER JOIN sys.tables AS t
            ON ep.major_id = t.object_id
        INNER JOIN sys.schemas AS s
            ON s.schema_id = t.schema_id
        INNER JOIN sys.columns AS c
            ON ep.major_id = c.object_id
               AND ep.minor_id = c.column_id
WHERE   class = 1
ORDER BY t.name

-- Add
EXECUTE sp_addextendedproperty  N'MS_Description', 
                                N'The category name. Maximum of 15 characters.', 
                                N'SCHEMA', N'dbo', 
                                N'TABLE',  N'Categories', 
                                N'COLUMN', N'CategoryName'
GO

-- Remove
EXECUTE sp_dropextendedproperty N'MS_Description',
                                N'SCHEMA', N'dbo', 
                                N'TABLE',  N'Categories', 
                                N'COLUMN', N'CategoryName'
GO

