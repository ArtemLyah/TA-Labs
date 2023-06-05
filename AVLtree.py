class Node():
    value: int
    height = 0
    left = None
    right = None
    def __init__(self, value) -> None:
        self.value = value

def insert(node: Node, value):
    if value >= node.value:
        if node.right == None:
            node.right = Node(value)
        else:
            insert(node.right, value)
    elif value < node.value:
        if node.left == None:
            node.left = Node(value)
        else:
            insert(node.left, value)
    updateHeight(node)
    balanceNode(node)

def getMax(node: Node) -> Node:
    if node.right == None:
        return node
    return getMax(node.right)

def getMin(node: Node) -> Node:
    if node.left == None:
        return node
    return getMin(node.left)

def delete(node: Node, value: int) -> None:
    if node == None: return None
    elif value < node.value: node.left = delete(node.left, value)
    elif value > node.value: node.right = delete(node.right, value)
    else:
        if node.left == None and node.right == None:
            return None
        elif node.left == None:
            return node.right
        elif node.right == None:
            return node.left
        maxLeft = getMax(node.left)
        node.value = maxLeft.value
        node.left = delete(node.left, maxLeft.value)
    updateHeight(node)
    balanceNode(node)
    return node

def printTree(node: Node):
    if node == None: return
    printTree(node.left)
    print(node.value, end=" ")
    printTree(node.right)

def getHeight(node: Node):
    return -1 if node == None else node.height 

def updateHeight(node: Node):
    height = max(getHeight(node.left), getHeight(node.right)) + 1
    node.height = height

def getBalance(node: Node):
    if node == None: return None
    return getHeight(node.right) - getHeight(node.left)

def swap(node1: Node, node2: Node):
    node1.value, node2.value = node2.value, node1.value

def rotateRight(node: Node):
    rightChild = node.right
    swap(node, node.left)
    node.right = node.left
    node.left = node.right.left
    node.right.left = node.right.right
    node.right.right = rightChild
    updateHeight(node.right)
    updateHeight(node)

def rotateLeft(node: Node):
    leftChild = node.left
    swap(node, node.right)
    node.left = node.right
    node.right = node.left.right
    node.left.right = node.left.left
    node.left.left = leftChild
    updateHeight(node.left)
    updateHeight(node)

def balanceNode(node: Node):
    balance = getBalance(node)
    if balance == -2:
        if getBalance(node.left) == 1: rotateLeft(node.left)
        rotateRight(node)
    elif balance == 2:
        if getBalance(node.right) == -1: rotateRight(node.right)
        rotateLeft(node)

root = Node(10)
# insert(root, 6)
# insert(root, 4)
# insert(root, 11)
# insert(root, 2)
# insert(root, 3)
# insert(root, 5)
# insert(root, 1)
# insert(root, 7)
# insert(root, 12)

insert(root, 9)
insert(root, 8)
insert(root, 7)
insert(root, 6)
insert(root, 5)

queue = [root]
i = 1
while queue:
    node = queue.pop(0)
    if node == None:
        i -= 1
        continue
    i -= 1
    print(node.value, end=" ")
    queue.append(node.left)
    queue.append(node.right)
    if i == 0:
        i = len(queue)
        print()

print()
print(getBalance(root))
printTree(root)


# print(getMax(root).value)
# print(getMin(root).value)
# print(search(root, 11))
# print(search(root, 3))
# print(search(root, 2))
# print(search(root, 0))