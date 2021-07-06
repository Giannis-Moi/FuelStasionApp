UPDATE [dbo].Items
SET  [Code] = '{0}', [Description]= '{1}', [ItemType]= {2}, [Price]= {3:0.00},[Cost]= {4:0.00}
WHERE ID = '{5}';
