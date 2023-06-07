import sys

from PySide6.QtWidgets import QApplication, QMainWindow, QSizePolicy
from ui_window import Ui_MainWindow

class MainWindow(QMainWindow):
    def __init__(self, parent=None) -> None:
        super().__init__(parent)
        self.ui = Ui_MainWindow()
        self.ui.setupUi(self)

if __name__ == "__main__":
    app = QApplication()
    window = MainWindow()
    window.show()
    sys.exit(app.exec())