CREATE TABLE svar (
  id INT AUTO_INCREMENT PRIMARY KEY,
  svar varchar(3),
  spoergsmaal int FOREIGN KEY REFERENCES spoergsmaal(id)
)
