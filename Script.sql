
-- ********************************************************************
-- ******                     TABLES DESIGN                      ******
-- ********************************************************************

DROP TABLE IF EXISTS [hola];

CREATE TABLE [hola](
      [int] INTEGER NOT NULL,
      [string] TEXT NOT NULL);
      
INSERT INTO hola (int, string) VALUES (1, 'a');