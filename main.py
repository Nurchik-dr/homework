from models.book import Book
from models.reader import Reader
from models.library import Library


def main():
    lib = Library()

    # Книги
    b1 = Book("Война и мир", "Толстой", "111", 3)
    b2 = Book("1984", "Оруэлл", "222", 2)

    # Читатели
    r1 = Reader("Иван", 1)
    r2 = Reader("Мария", 2)

    # Добавление
    lib.add_book(b1)
    lib.add_book(b2)
    lib.register_reader(r1)
    lib.register_reader(r2)

    # Выдача
    lib.issue_book("111", 1)
    lib.issue_book("222", 2)

    # Возврат
    lib.return_book("111", 1)

    # Вывод
    print("\n--- Книги ---")
    lib.show_books()

    print("\n--- Читатели ---")
    lib.show_readers()


if __name__ == "__main__":
    main()
