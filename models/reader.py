class Reader:
    def __init__(self, name, reader_id):
        self.name = name
        self.reader_id = reader_id

    def __str__(self):
        return f"{self.name} (ID: {self.reader_id})"
