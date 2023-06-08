from Tree import Tree, Node

class AVLNode(Node):
    height = 0
    def __init__(self, value) -> None:
        self.value = value
class AVLTree(Tree):
    def __init__(self) -> None:
        self.root = None 
    
    def insert(self, value):
        return self.__insert(self.root, value)

    def __search(self, node: AVLNode, value):
        if node == None:
            return None
        if value < node.value:
            return self.__search(node.left, value)
        elif value > node.value:
            return self.__search(node.right, value)
        else:
            return node

    def search(self, value):
        return self.__search(self.root, value)

    def __insert(self, node: AVLNode, value):
        if node == None:
            self.root = AVLNode(value)
            return
        if value >= node.value:
            if node.right == None:
                node.right = AVLNode(value)
            else:
                self.__insert(node.right, value)
        elif value < node.value:
            if node.left == None:
                node.left = AVLNode(value)
            else:
                self.__insert(node.left, value)
        self.updateHeight(node)
        self.balanceNode(node)

    def getMax(self, node: AVLNode) -> AVLNode:
        if node.right == None:
            return node
        return self.getMax(node.right)

    def getMin(self, node: AVLNode) -> AVLNode:
        if node.left == None:
            return node
        return self.getMin(node.left)

    def delete(self, value: int) -> None:
        return self.__delete(self.root, value)

    def __delete(self, node: AVLNode, value: int) -> None:
        if node == None: return None
        elif value == self.root.value:
            self.root = None
            return
        elif value < node.value: node.left = self.__delete(node.left, value)
        elif value > node.value: node.right = self.__delete(node.right, value)
        else:
            if node.left == None and node.right == None:
                return None
            elif node.left == None:
                return node.right
            elif node.right == None:
                return node.left
            maxLeft = self.getMax(node.left)
            node.value = maxLeft.value
            node.left = self.__delete(node.left, maxLeft.value)
        self.updateHeight(node)
        self.balanceNode(node)
        return node

    def getHeight(self, node: AVLNode):
        return -1 if node == None else node.height 

    def updateHeight(self, node: AVLNode):
        height = max(self.getHeight(node.left), self.getHeight(node.right)) + 1
        node.height = height

    def getBalance(self, node: AVLNode):
        if node == None: return None
        return self.getHeight(node.right) - self.getHeight(node.left)

    def swap(self, node1: Node, node2: AVLNode):
        node1.value, node2.value = node2.value, node1.value

    def rotateRight(self, node: AVLNode):
        rightChild = node.right
        self.swap(node, node.left)
        node.right = node.left
        node.left = node.right.left
        node.right.left = node.right.right
        node.right.right = rightChild
        self.updateHeight(node.right)
        self.updateHeight(node)

    def rotateLeft(self, node: AVLNode):
        leftChild = node.left
        self.swap(node, node.right)
        node.left = node.right
        node.right = node.left.right
        node.left.right = node.left.left
        node.left.left = leftChild
        self.updateHeight(node.left)
        self.updateHeight(node)

    def balanceNode(self, node: AVLNode):
        balance = self.getBalance(node)
        if balance == -2:
            if self.getBalance(node.left) == 1: self.rotateLeft(node.left)
            self.rotateRight(node)
        elif balance == 2:
            if self.getBalance(node.right) == -1: self.rotateRight(node.right)
            self.rotateLeft(node)