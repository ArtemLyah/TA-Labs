from Tree import Tree, Node
from avlTree import AVLTree, AVLNode
from rbTree import RBTree, RBNode, Color
from basicTree import BasicTree
from enum import Enum

class TreeType(Enum):
    BASIC = "BASIC",
    RB = "RB",
    AVL = "AVL"

class TreeService:
    def __init__(self, \
        avlTree=AVLTree(), \
        rbTree=RBTree(),
        basicTree=BasicTree() \
    ) -> None:
        self.avlTree = avlTree
        self.rbTree = rbTree
        self.basicTree = basicTree

    def _getNodesArray(self, root: Node):
        array = [[root]]
        while any(array[-1]):
            queue = array[-1]
            array.append([])
            for node in queue:
                if node == None:
                    array[-1].append(None)
                    array[-1].append(None)
                else:    
                    array[-1].append(node.left)
                    array[-1].append(node.right)
        return array[:-1]

    def printTree(self, treeType: TreeType):
        if treeType == treeType.RB:
            root = self.rbTree.root
        elif treeType == treeType.AVL:
            root = self.avlTree.root 
        elif treeType == treeType.BASIC:
            root = self.basicTree.root 
        return self.printNode(root, treeType)

    def printNode(self, node: Node, treeType: TreeType):
        def stringifyNodes(node: Node):
            if node == None:
                return "  "
            else:
                if treeType == TreeType.RB:
                    return f"{node.value}{'B' if node.color == Color.BLACK else 'R'}"
                else:
                    return str(node.value)

        result = ""    
        arrayTree = self._getNodesArray(node)
        elems = 2**len(arrayTree)
    
        for nodes in arrayTree:
            nodes = list(map(stringifyNodes, nodes))
            result += (round(elems-2))*" " + (" "*round(elems*2-1)).join(nodes) + "\n"
            elems //= 2
        return result
    
    def getArray(self, root):
        return self._getArray(root)

    def _getArray(self, node: Node):
        array = []
        if node.left:
            leftArray = self._getArray(node.left)
        array.append(node)
        if node.right:
            rightArray = self._getArray(node.right)
        return leftArray + array + rightArray

    def insert(self, value):
        self.avlTree.insert(value)
        self.rbTree.insert(value)
        self.basicTree.insert(value)

    def delete(self, value):
        self.avlTree.delete(value)
        self.rbTree.delete(value)
        self.basicTree.delete(value)

    def search(self, value, treeType: TreeType):
        match treeType:
            case TreeType.RB: return self.rbTree.search(value)
            case TreeType.AVL: return self.avlTree.search(value)
            case TreeType.BASIC: return self.basicTree.search(value)
