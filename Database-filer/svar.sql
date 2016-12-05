CREATE TABLE svar (
  id INT IDENTITY(1,1) PRIMARY KEY,
  svar VARCHAR(3),
  spoergsmaal INT FOREIGN KEY REFERENCES spoergsmaal(id)
)
