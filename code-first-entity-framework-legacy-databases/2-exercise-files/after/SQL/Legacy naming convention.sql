USE Northwind
GO

CREATE TABLE engineer
(
    engineer_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    added DATETIME NOT NULL DEFAULT GETDATE(),
    forename varchar(100) not null,
    surname varchar(100) not null
)

CREATE TABLE engineer_order
( 
    engineer_order_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    engineer_id INT NOT NULL,
    order_placed DATETIME NOT NULL,
);

CREATE TABLE engineer_order_item
( 
    engineer_order_item_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    engineer_order_id INT,
    sku VARCHAR(50) NOT NULL
);
ALTER TABLE engineer_order ADD CONSTRAINT EO_FK FOREIGN KEY (engineer_id) REFERENCES engineer (engineer_id);
ALTER TABLE engineer_order_item ADD CONSTRAINT EOI_FK FOREIGN KEY (engineer_order_id) REFERENCES engineer_order (engineer_order_id);


-- Remove
DROP TABLE engineer_order_item
DROP TABLE engineer_order
DROP TABLE engineer