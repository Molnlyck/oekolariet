CREATE TABLE fakta (
  id INT IDENTITY(1,1) PRIMARY KEY,
  fakta TEXT,
  spoergsmaal INT FOREIGN KEY REFERENCES spoergsmaal(id)
)
