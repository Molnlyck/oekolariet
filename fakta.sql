CREATE TABLE fakta (
  id INT AUTO_INCREMENT PRIMARY KEY,
  fakta text,
  spoergsmaal int FOREIGN KEY REFERENCES spoergsmaal(id)
)
