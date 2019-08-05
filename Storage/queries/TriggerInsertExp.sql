--триггер на Insert в таблицу Expends(расходы)
USE u0775942_StorageDB
DROP TRIGGER IF EXISTS ExpInsert
GO

CREATE TRIGGER ExpInsert
ON Expends
AFTER INSERT  
AS 
UPDATE Items SET [Count] = (Items.Count + 1), Price = (Items.Price - I.Price*I.Count)
FROM INSERTED I
Where Items.Id = I.ItemIdId
PRINT 'Success' 