from Tree import Tree, Node

class BasicNode(Node):
    def __init__(self, value) -> None:
        self.value = value

class BasicTree(Tree):
    def __init__(self) -> None:
        self.arrayTree = []
        self.root = None
    
    def insert(self, value):
        self.arrayTree.append(value)
        self.reformRoot()
    
    def delete(self, value):
        try:
            self.arrayTree.remove(value)
            self.reformRoot()
        except ValueError:
            return

    def reformRoot(self):
        self.root = None
        for value in self.arrayTree:
            self._insertToRoot(value)

    def _insertToRoot(self, value):
        node = self.root
        parent = None
        if self.root == None:
            self.root = BasicNode(value)
            return
        while node != None:
            parent = node
            if value >= node.value:
                node = node.right
            elif value < node.value:
                node = node.left
        if value >= parent.value:
            parent.right = BasicNode(value)
        elif value < parent.value:
            parent.left = BasicNode(value)


    def search(self, value):
        node = self.root
        while node != None and node.value != value:
            if value > node.value:
                node = node.right
            else:
                node = node.left
        return node

