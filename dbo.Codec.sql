CREATE TABLE [dbo].[Table]
(
	[time_stamp] DATETIME NOT NULL PRIMARY KEY DEFAULT NOW(), 
    [encode_string] NCHAR(45) NULL, 
    [decode_string] NCHAR(200) NULL, 
    [status] NCHAR(9) NULL
)
