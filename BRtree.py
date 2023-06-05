from enum import Enum

class Color(Enum):
    BLACK = "BLACK"
    RED = "RED"

class Node():
    def __init__(self, value):
        self.value = value
        self.parent = None
        self.left = None
        self.right = None
        self.color = 1

# Define R-B Tree
class Tree():
    def __init__(self):
        self.nil = Node(0)
        self.nil.color = Color.BLACK
        self.nil.left = None
        self.nil.right = None
        self.root = self.nil

    # Insert New Node
    def insertNode(self, value):
        newNode = Node(value)
        newNode.parent = None
        newNode.value = value
        newNode.left = self.nil
        newNode.right = self.nil
        newNode.color = Color.RED

        parent = None
        node = self.root
        while node != self.nil:
            parent = node
            if newNode.value < node.value:
                node = node.left
            else :
                node = node.right
        newNode.parent = parent
        if parent == None:
            self.root = newNode
        elif newNode.value < parent.value:
            parent.left = newNode
        else:
            parent.right = newNode

        if newNode.parent == None:
            newNode.color = Color.RED
            return
        if newNode.parent.parent == None:
            return
        self.fixInsert(newNode)

    # Code for left rotate
    def leftRightRotate (self, node):
        rightChild = node.right
        node.right = rightChild.left
        if rightChild.left != self.nil:
            rightChild.left.parent = node

        rightChild.parent = node.parent
        if node.parent == None:
            self.root = rightChild
        elif node == node.parent.left:
            node.parent.left = rightChild
        else:
            node.parent.right = rightChild
        rightChild.left = node
        node.parent = rightChild

    # Code for right rotate
    def rightRotate (self, node):
        leftChild = node.left
        node.left = leftChild.right
        if leftChild.right != self.nil:
            leftChild.right.parent = node

        leftChild.parent = node.parent
        if node.parent == None:
            self.root = leftChild
        elif node == node.parent.right:
            node.parent.right = leftChild
        else:
            node.parent.left = leftChild
        leftChild.right = node
        node.parent = leftChild

    # Fix Up Insertion
    def fixInsert(self, node):
        while node.parent.color == Color.RED:
            if node.parent.parent.left == node.parent:
                uncle = node.parent.parent.right
            else:
                uncle = node.parent.parent.left

            if uncle.color == Color.RED:
                uncle.color = Color.BLACK
                node.parent.color = Color.BLACK
                node.parent.parent.color = Color.RED
                node = node.parent.parent
            else:
                if node.parent == node.parent.parent.right:
                    if node == node.parent.left:
                        node = node.parent
                        self.rightRotate(node)
                    node.parent.color = Color.BLACK
                    node.parent.parent.color = Color.RED
                    self.leftRightRotate(node.parent.parent)
                else:
                    if node == node.parent.right:
                        node = node.parent
                        self.leftRightRotate(node)
                    node.parent.color = Color.BLACK
                    node.parent.parent.color = Color.RED
                    self.rightRotate(node.parent.parent)
            if node == self.root:
                break
        self.root.color = Color.BLACK

    # Function to fix issues after deletion
    def fixDelete (self, node):
        while node != self.root and node.color == Color.BLACK:
            if node == node.parent.left:
                brother = node.parent.right
                if brother.color == Color.RED:
                    brother.color = Color.BLACK
                    node.parent.color = Color.RED
                    self.leftRightRotate (node.parent)
                    brother = node.parent.right
                if brother.left.color == Color.BLACK and brother.right.color == Color.BLACK:
                    brother.color = Color.RED
                    node = node.parent
                else:
                    if brother.right.color == Color.BLACK:
                        brother.left.color = Color.BLACK
                        brother.color = Color.RED
                        self.rightRotate (brother)
                        brother = node.parent.right

                    brother.color = node.parent.color
                    node.parent.color = Color.BLACK
                    brother.right.color = Color.BLACK
                    self.leftRightRotate (node.parent)
                    node = self.root
            else:
                brother = node.parent.left
                if brother.color == Color.RED:
                    brother.color = Color.BLACK
                    node.parent.color = Color.RED
                    self.rightRotate (node.parent)
                    brother = node.parent.left

                if brother.right.color == Color.BLACK and brother.right.color == Color.BLACK:
                    brother.color = Color.RED
                    node = node.parent
                else:
                    if brother.left.color == Color.BLACK:
                        brother.right.color = Color.BLACK
                        brother.color = Color.RED
                        self.leftRightRotate (brother)
                        brother = node.parent.left

                    brother.color = node.parent.color
                    node.parent.color = Color.BLACK
                    brother.left.color = Color.BLACK
                    self.rightRotate (node.parent)
                    node = self.root
        node.color = Color.BLACK

    # Function to transplant nodes
    def __transplant(self, node1, node2):
        if node1.parent == None:
            self.root = node2
        elif node1 == node1.parent.left:
            node1.parent.left = node2
        else:
            node1.parent.right = node2
        node2.parent = node1.parent

    def minimum(self, node):
        while node.left != self.nil:
            node = node.left
        return node

    # Deletion of node
    def delete(self, value):
        node = self.root
        nodeToDelete = self.nil
        while node != self.nil:
            if node.value == value:
                nodeToDelete = node
            if node.value <= value:
                node = node.right
            else:
                node = node.left

        if nodeToDelete == self.nil:
            return

        nodeColor = nodeToDelete.color
        if nodeToDelete.left == self.nil:
            node = nodeToDelete.right
            self.__transplant(nodeToDelete, nodeToDelete.right)
        elif (nodeToDelete.right == self.nil):
            node = nodeToDelete.left
            self.__transplant(nodeToDelete , nodeToDelete.left)
        else:
            minNode = self.minimum(nodeToDelete.right)
            nodeColor = minNode.color
            node = minNode.right
            if minNode.parent == nodeToDelete:
                node.parent = minNode
            else:
                self.__transplant(minNode , minNode.right)
                minNode.right = nodeToDelete.right
                minNode.right.parent = minNode

            self.__transplant(nodeToDelete, minNode)
            minNode.left = nodeToDelete.left
            minNode.left.parent = minNode
            minNode.color = nodeToDelete.color
        if nodeColor == Color.BLACK:
            self.fixDelete(node)


    # Function to print
    def __printCall ( self , node , indent , last ) :
        if node != self.nil :
            print(indent, end=' ')
            if last :
                print ("R----",end= ' ')
                indent += "     "
            else :
                print("L----",end=' ')
                indent += "|    "

            s_color = "RED" if node.color == 1 else "BLACK"
            print ( str ( node.value ) + "(" + s_color + ")" )
            self.__printCall ( node.left , indent , False )
            self.__printCall ( node.right , indent , True )

    # Function to call print
def RBprint_tree(node: Node, lines, level=0):
    if node.value != 0:
        RBprint_tree(node.left, lines, level + 1)
        lines.append('-' * 4 * level + '> ' +
                    str(node.value) + ' ' + ('r' if node.color == Color.RED else 'b'))
        RBprint_tree(node.right, lines, level + 1)
        return '\n'.join(lines)

rbTree = Tree()
rbTree.insertNode(10)
rbTree.insertNode(11)
rbTree.insertNode(12)
rbTree.insertNode(13)
rbTree.insertNode(8)
rbTree.insertNode(9)
rbTree.insertNode(7)

print(RBprint_tree(rbTree.root, []))
print()

rbTree.delete(8)

print(RBprint_tree(rbTree.root, []))
print()
