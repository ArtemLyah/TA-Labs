# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'ui_window_export.ui'
##
## Created by: Qt User Interface Compiler version 6.5.1
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

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
    QMainWindow, QPushButton, QSizePolicy, QTextBrowser, QMessageBox, QRadioButton,
    QVBoxLayout, QWidget, QLayout, QHBoxLayout)
from serviceTree import TreeService, TreeType
class Ui_MainWindow(object):
    def __init__(self) -> None:
        self.serviceTree = TreeService()

    def setupUi(self, MainWindow):
        if not MainWindow.objectName():
            MainWindow.setObjectName(u"MainWindow")
        MainWindow.setEnabled(True)
        MainWindow.resize(829, 366)
        self.centralwidget = QWidget(MainWindow)
        self.centralwidget.setObjectName(u"centralwidget")
        self.textBrowser = QTextBrowser(self.centralwidget)
        self.textBrowser.setObjectName(u"textBrowser")
        self.textBrowser.setGeometry(QRect(370, 45, 451, 311))
        self.textBrowser.setLineWrapMode(self.textBrowser.LineWrapMode.NoWrap)
        self.label = QLabel(self.centralwidget)
        self.label.setObjectName(u"label")
        self.label.setGeometry(QRect(370, 20, 131, 21))
        self.label_2 = QLabel(self.centralwidget)
        self.label_2.setObjectName(u"label_2")
        self.label_2.setGeometry(QRect(10, 10, 231, 31))
        self.lineEdit = QLineEdit(self.centralwidget)
        self.lineEdit.setObjectName(u"lineEdit")
        self.lineEdit.setGeometry(QRect(10, 40, 341, 31))
        font = QFont()
        font.setPointSize(12)
        self.lineEdit.setFont(font)
        self.lineEdit.setLayoutDirection(Qt.LeftToRight)
        self.verticalLayoutWidget = QWidget(self.centralwidget)
        self.verticalLayoutWidget.setObjectName(u"verticalLayoutWidget")
        self.verticalLayoutWidget.setGeometry(QRect(10, 80, 341, 271))
        self.verticalLayout = QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setObjectName(u"verticalLayout")
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.addNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.addNodeBtn.setObjectName(u"addNodeBtn")
        sizePolicy = QSizePolicy(QSizePolicy.Minimum, QSizePolicy.Minimum)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.addNodeBtn.sizePolicy().hasHeightForWidth())
        self.addNodeBtn.setSizePolicy(sizePolicy)

        self.verticalLayout.addWidget(self.addNodeBtn)

        self.deleteNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.deleteNodeBtn.setObjectName(u"deleteNodeBtn")
        sizePolicy.setHeightForWidth(self.deleteNodeBtn.sizePolicy().hasHeightForWidth())
        self.deleteNodeBtn.setSizePolicy(sizePolicy)

        self.verticalLayout.addWidget(self.deleteNodeBtn)

        self.searchNodeBtn = QPushButton(self.verticalLayoutWidget)
        self.searchNodeBtn.setObjectName(u"searchNodeBtn")
        sizePolicy.setHeightForWidth(self.searchNodeBtn.sizePolicy().hasHeightForWidth())
        self.searchNodeBtn.setSizePolicy(sizePolicy)

        self.verticalLayout.addWidget(self.searchNodeBtn)

        self.horizontalLayout = QHBoxLayout()
        self.horizontalLayout.setObjectName(u"horizontalLayout")
        self.horizontalLayout.setSizeConstraint(QLayout.SetFixedSize)
        self.basicTreeRb = QRadioButton(self.verticalLayoutWidget)
        self.basicTreeRb.setObjectName(u"basicTreeRb")
        self.basicTreeRb.setChecked(True)

        sizePolicy1 = QSizePolicy(QSizePolicy.Minimum, QSizePolicy.Maximum)
        sizePolicy1.setHorizontalStretch(0)
        sizePolicy1.setVerticalStretch(0)
        sizePolicy1.setHeightForWidth(self.basicTreeRb.sizePolicy().hasHeightForWidth())
        self.basicTreeRb.setSizePolicy(sizePolicy1)

        self.horizontalLayout.addWidget(self.basicTreeRb)

        self.avlTreeRb = QRadioButton(self.verticalLayoutWidget)
        self.avlTreeRb.setObjectName(u"avlTreeRb")
        self.avlTreeRb.setEnabled(True)
        sizePolicy1.setHeightForWidth(self.avlTreeRb.sizePolicy().hasHeightForWidth())
        self.avlTreeRb.setSizePolicy(sizePolicy1)

        self.horizontalLayout.addWidget(self.avlTreeRb)

        self.rbTreeRb = QRadioButton(self.verticalLayoutWidget)
        self.rbTreeRb.setObjectName(u"rbTreeRb")
        self.rbTreeRb.setEnabled(True)
        sizePolicy1.setHeightForWidth(self.rbTreeRb.sizePolicy().hasHeightForWidth())
        self.rbTreeRb.setSizePolicy(sizePolicy1)

        self.horizontalLayout.addWidget(self.rbTreeRb)

        self.verticalLayout.addLayout(self.horizontalLayout)

        self.verticalLayout.setStretch(0, 2)
        self.verticalLayout.setStretch(1, 2)
        self.verticalLayout.setStretch(2, 2)
        self.verticalLayout.setStretch(3, 3)
        MainWindow.setCentralWidget(self.centralwidget)

        self.retranslateUi(MainWindow)

        QMetaObject.connectSlotsByName(MainWindow)

        self.addNodeBtn.clicked.connect(lambda: self.insertNode(self.lineEdit.text()))    
        self.deleteNodeBtn.clicked.connect(lambda: self.deleteNode(self.lineEdit.text()))    
        self.searchNodeBtn.clicked.connect(lambda: self.searchNode(self.lineEdit.text()))  
        self.basicTreeRb.clicked.connect(lambda: self.searchTree())
        self.avlTreeRb.clicked.connect(lambda: self.searchTree())
        self.rbTreeRb.clicked.connect(lambda: self.searchTree())
    # setupUi

    def retranslateUi(self, MainWindow):
        MainWindow.setWindowTitle(QCoreApplication.translate("MainWindow", "Печера леприкона", None))
        self.label.setText(QCoreApplication.translate("MainWindow", u"\u0421\u0442\u0440\u0443\u043a\u0442\u0443\u0440\u0430 \u043f\u0435\u0447\u0435\u0440", None))
        self.label_2.setText(QCoreApplication.translate("MainWindow", u"\u041a\u0456\u043b\u044c\u043a\u0456\u0441\u0442\u044c \u0441\u043a\u0430\u0440\u0431\u0456\u0432 \u0432 \u043f\u0435\u0447\u0435\u0440\u0456", None))
        self.addNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u0414\u043e\u0434\u0430\u0442\u0438 \u043f\u0435\u0447\u0435\u0440\u0443", None))
        self.deleteNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u0412\u0438\u0434\u0430\u043b\u0438\u0442\u0438 \u043f\u0435\u0447\u0435\u0440\u0443", None))
        self.searchNodeBtn.setText(QCoreApplication.translate("MainWindow", u"\u041f\u043e\u0448\u0443\u043a \u043f\u0435\u0447\u0435\u0440\u0438", None))
        self.basicTreeRb.setText(QCoreApplication.translate("MainWindow", "Початкове дерево", None))
        self.avlTreeRb.setText(QCoreApplication.translate("MainWindow", u"\u0417\u0431\u0430\u043b\u0430\u043d\u0441\u043e\u0432\u0430\u043d\u0435", None))
        self.rbTreeRb.setText(QCoreApplication.translate("MainWindow", u"\u041a\u0440\u0430\u0441\u043d\u043e-\u0447\u043e\u0440\u043d\u0435", None))
    # retranslateUi

    def insertNode(self, value):
        try:
            value = int(value)
        except:
            self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
            return
        self.serviceTree.insert(value)
        treeText = self.serviceTree.printTree(self.getTreeType())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
    
    def deleteNode(self, value):
        try:
            value = int(value)
        except:
            self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
            return
        self.serviceTree.delete(value)
        treeText = self.serviceTree.printTree(self.getTreeType())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
        self.showMessageBox("Печера обвалилася! Скарби втрачені(")

    def searchNode(self, value):
        if value == "root" or value == "":
            treeText = self.serviceTree.printTree(self.getTreeType())
        else:
            try:
                value = int(value)
            except:
                self.showMessageBox("Неправильно введено кількість скарбів", QMessageBox.Warning)
                return
            node = self.serviceTree.search(value, self.getTreeType())
            treeText = self.serviceTree.printNode(node, self.getTreeType())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
    
    def searchTree(self):
        treeText = self.serviceTree.printTree(self.getTreeType())
        self.textBrowser.setText(treeText)
        self.lineEdit.clear()
    
    def showMessageBox(self, text, status=QMessageBox.Information):
        msgBox = QMessageBox()
        msgBox.setIcon(status)
        msgBox.setText(text)
        msgBox.setWindowTitle("Information")
        msgBox.setStandardButtons(QMessageBox.Ok | QMessageBox.Cancel)
        msgBox.exec()

    def getTreeType(self):
        if self.basicTreeRb.isChecked():
            return TreeType.BASIC
        elif self.avlTreeRb.isChecked():
            return TreeType.AVL
        elif self.rbTreeRb.isChecked():
            return TreeType.RB