﻿CREATE TABLE Users
(
	[UserID] INT NOT NULL PRIMARY KEY,
    [Username] VARCHAR(20) NOT NULL, 
    [PasswordHash] VARCHAR(MAX) NOT NULL
)
