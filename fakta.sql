CREATE TABLE fakta (
  id INT PRIMARY KEY,
  fakta text,
  spoergsmaal int FOREIGN KEY REFERENCES spoergsmaal(id)
)
