class Book:
    def __init__(self, title, author, isbn, copies):
        self.title = title
        self.author = author
        self.isbn = isbn
        self.copies = copies

    def __str__(self):
        return f"{self.title} — {self.author}, ISBN: {self.isbn}, доступно: {self.copies}"
