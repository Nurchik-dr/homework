from models.book import Book
from models.reader import Reader


class Library:
    def __init__(self):
        self.books = []
        self.readers = []
        self.issued_books = {}

    def add_book(self, book):
        self.books.append(book)
        print(f"[+] Добавлена книга: {book.title}")

    def remove_book(self, isbn):
        self.books = [b for b in self.books if b.isbn != isbn]

    def register_reader(self, reader):
        self.readers.append(reader)

    def remove_reader(self, reader_id):
        self.readers = [r for r in self.readers if r.reader_id != reader_id]

    def issue_book(self, isbn, reader_id):
        book = next((b for b in self.books if b.isbn == isbn), None)
        reader = next((r for r in self.readers if r.reader_id == reader_id), None)

        if not book or not reader or book.copies < 1:
            print("[!] Выдача невозможна")
            return

        book.copies -= 1
        self.issued_books.setdefault(reader_id, []).append(book)
        print(f"[>>] '{book.title}' выдана читателю {reader.name}")

    def return_book(self, isbn, reader_id):
        if reader_id not in self.issued_books:
            return
        for book in self.issued_books[reader_id]:
            if book.isbn == isbn:
                self.issued_books[reader_id].remove(book)
                book.copies += 1
                print(f"[<<] '{book.title}' возвращена")
                return

    def show_books(self):
        for b in self.books:
            print(b)

    def show_readers(self):
        for r in self.readers:
            print(r)
