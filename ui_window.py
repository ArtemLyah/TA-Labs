# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'ui_window_export.ui'
##
## Created by: Qt User Interface Compiler version 6.5.1
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QBrush, QColor, QConicalGradient, QCursor,
    QFont, QFontDatabase, QGradient, QIcon,
    QImage, QKeySequence, QLinearGradient, QPainter,
    QPalette, QPixmap, QRadialGradient, QTransform)
from PySide6.QtWidgets import (QApplication, QCheckBox, QLabel, QLineEdit,
    QMainWindow, QPushButton, QSizePolicy, QTextBrowser, QMessageBox,
    QVBoxLayout, QWidget)

from serviceTree import TreeService, AVLTree, RBTree

class Ui_MainWindow():
    def __init__(self) -> None:
       self.serviceTree = TreeService(AVLTree(), RBTree())

    def setupUi(self, MainWindow):
        if not MainWindow.objectName():
            MainWindow.setObjectName(u"MainWindow")
        MainWindow.resize(948, 364)
        self.centralwidget = QWidget(MainWindow)
        self.centralwidget.setObjectName(u"centralwidget")
        self.textBrowser = QTextBrowser(self.centralwidget)
        self.textBrowser.setObjectName(u"textBrowser")
        self.textBrowser.setGeometry(QRect(340, 35, 601, 321))
        self.label = QLabel(self.centralwidget)
        self.label.setObjectName(u"label")
        self.label.setGeometry(QRect(340, 10, 131, 21))
        self.label_2 = QLabel(self.centralwidget)
        self.label_2.setObjectName(u"label_2")
        self.label_2.setGeometry(QRect(10, 10, 231, 31))
        self.lineEdit = QLineEdit(self.centralwidget)
        self.lineEdit.setObjectName(u"lineEdit")
        self.lineEdit.setGeometry(QRect(10, 40, 301, 21))
        self.verticalLayoutWidget = QWidget(self.centralwidget)
        self.verticalLayoutWidget.setObjectName(u"verticalLayoutWidget")
        self.verticalLayoutWidget.setGeometry(QRect(10, 80, 301, 271))
        self.verticalLayout = QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setObjectName(u"verticalLayout")
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.addNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.addNodeBtn.setObjectName(u"addNode")

        self.verticalLayout.addWidget(self.addNodeBtn)

        self.deleteNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.deleteNodeBtn.setObjectName(u"deleteNode")

        self.verticalLayout.addWidget(self.deleteNodeBtn)

        self.searchNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.searchNodeBtn.setObjectName(u"searchNode")

        self.verticalLayout.addWidget(self.searchNodeBtn)

        self.isRedBlueCb = QCheckBox(self.verticalLayoutWidget)
        self.isRedBlueCb.setObjectName(u"isRedBlue")

        self.verticalLayout.addWidget(self.isRedBlueCb)

        MainWindow.setCentralWidget(self.centralwidget)

        self.retranslateUi(MainWindow)

        QMetaObject.connectSlotsByName(MainWindow)

        self.addNodeBtn.clicked.connect(lambda: self.insertNode(self.lineEdit.text()))    
        self.deleteNodeBtn.clicked.connect(lambda: self.deleteNode(self.lineEdit.text()))    
        self.searchNodeBtn.clicked.connect(lambda: self.searchNode(self.lineEdit.text()))  
        self.isRedBlueCb.clicked.connect(lambda: self.searchNode(self.lineEdit.text()))  
    # setupUi

    def retranslateUi(self, MainWindow):
        MainWindow.setWindowTitle(QCoreApplication.translate("MainWindow", "Печера леприкона", None))
        self.label.setText(QCoreApplication.translate("MainWindow", "Печери зі скарбами", None))
        self.label_2.setText(QCoreApplication.translate("MainWindow", u"\u0412\u0432\u0435\u0434\u0456\u0442\u044c \u043f\u0435\u0447\u0435\u0440\u0443 \u0437\u0456 \u0441\u043a\u0430\u0440\u0431\u0430\u043c\u0438", None))
        self.addNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u0414\u043e\u0434\u0430\u0442\u0438 \u043f\u0435\u0447\u0435\u0440\u0443", None))
        self.deleteNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u0412\u0438\u0434\u0430\u043b\u0438\u0442\u0438 \u043f\u0435\u0447\u0435\u0440\u0443", None))
        self.searchNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u041f\u043e\u0448\u0443\u043a \u043f\u0435\u0447\u0435\u0440\u0438", None))
        self.isRedBlueCb.setText(QCoreApplication.translate("MainWindow", u"\u041a\u0440\u0430\u0441\u043d\u043e-\u0447\u043e\u0440\u043d\u0435 \u0434\u0435\u0440\u0435\u0432\u043e", None))
    # retranslateUi

    def insertNode(self, value):
        try:
            value = int(value)
        except:
            self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
            return
        self.serviceTree.insert(value)
        treeText = self.serviceTree.printTree(self.isRedBlueCb.isChecked())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
    
    def deleteNode(self, value):
        try:
            value = int(value)
        except:
            self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
            return
        self.serviceTree.delete(value)
        treeText = self.serviceTree.printTree(self.isRedBlueCb.isChecked())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
        self.showMessageBox("Печера обвалилася! Скарби втрачені(")

    def searchNode(self, value):
        if value == "root" or value == "":
            treeText = self.serviceTree.printTree(self.isRedBlueCb.isChecked())
        else:
            try:
                value = int(value)
            except:
                self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
                return
            node = self.serviceTree.search(value, self.isRedBlueCb.isChecked())
            treeText = self.serviceTree.printNode(node, self.isRedBlueCb.isChecked())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
    
    def showMessageBox(self, text, status=QMessageBox.Information):
        msgBox = QMessageBox()
        msgBox.setIcon(status)
        msgBox.setText(text)
        msgBox.setWindowTitle("Information")
        msgBox.setStandardButtons(QMessageBox.Ok | QMessageBox.Cancel)
        msgBox.exec()

    