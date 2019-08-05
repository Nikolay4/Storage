--триггер на Insert в таблицу Incomes(приходы)
USE u0775942_StorageDB
DROP TRIGGER IF EXISTS IncInsert
GO

CREATE TRIGGER IncInsert
ON Incomes
AFTER INSERT  
AS 
	UPDATE Items SET [Count] = (Items.Count + 1), [Price] = (Items.[Price] + I.Price*I.Count)
	FROM INSERTED I
	Where Items.Id = I.ItemIdId
	PRINT 'Success'