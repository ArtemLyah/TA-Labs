from Tree import Tree, Node
from AVLtree import AVLTree, AVLNode
from RBtree import RBTree, RBNode, Color

class TreeService:
    def __init__(self, avlTree: AVLTree, rbTree: RBTree) -> None:
        self.avlTree = avlTree
        self.rbTree = rbTree

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

    def printTree(self, isRb=False):
        if isRb:
            root = self.rbTree.root
        else:
            root = self.avlTree.root 
        return self._printNode(root, isRb)

    def printNode(self, node: Node, isRb=False):
        return self._printNode(node, isRb)

    def _printNode(self, node: Node, isRb=False):
        def stringifyNodes(node: Node):
            if node == None:
                return "  "
            else:
                if isRb:
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
    
    def insert(self, value):
        self.avlTree.insert(value)
        self.rbTree.insert(value)

    def delete(self, value):
        self.avlTree.delete(value)
        self.rbTree.delete(value)

    def search(self, value, isRB=False):
        if isRB:
            return self.rbTree.search(value)
        else:
            return self.avlTree.search(value)