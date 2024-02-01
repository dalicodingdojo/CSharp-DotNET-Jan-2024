// Binary Search Tree

class Node {
    constructor(data) {
        this.data = data;
        this.left = null;
        this.right = null
    }
}

class BST {
    constructor() {
        this.root = null
    }

    isEmpty() {
        return this.root == null;
    }
    min() {
        if (this.isEmpty()) {
            return false
        } else {
            let runner = this.root;
            let minValue = runner.data
            while (runner.left) {
                minValue = runner.left.data
                runner = runner.left
            }
            return minValue
        }
    }
    max() {
        if (this.isEmpty()) {
            return false
        } else {
            let runner = this.root;
            let maxValue = runner.data
            while (runner.right) {
                maxValue = runner.right.data
                runner = runner.right
            }
            return maxValue
        }
    }
    insert(value) {
        console.log("Value : ", value);
        let newNode = new Node(value)
        if (this.isEmpty()) {
            this.root = newNode
            return this
        } else {
            let runner = this.root
            while (runner) {
                if (runner.data > value) {
                    if (runner.left) {
                        runner = runner.left
                    } else {
                        runner.left = newNode
                        return this
                    }
                } else {
                    if (runner.right) {
                        runner = runner.right
                    } else {
                        runner.right = newNode
                        return this
                    }
                }
            }
        }
    }
    find(value){
        if(this.isEmpty()){
            return false
        }else{
            let runner = this.root
            while(runner){
                if(runner.data == value){
                    return true
                }else{
                    if(runner.data < value){
                        runner = runner.right
                    }else{
                        runner = runner.left
                    }
                }
            }
            return false
        }
    }
}

// const nodeOne  = new Node(26)
// const nodeTwo  = new Node(12)
// const nodeThree  = new Node(62)
// const node4 = new Node(11)
// const node5  = new Node(19)
// const node6  = new Node(17)
// const node7 = new Node(38)
// const node8  = new Node(45)
// const node9 = new Node(73)
// const node10 = new Node(83)
// nodeOne.left = nodeTwo
// nodeOne.right = nodeThree
// nodeTwo.left = node4
// nodeTwo.right = node5
// node5.left = node6
// nodeThree.left = node7
// node7.right = node8
// nodeThree.right = node9
// node9.right = node10

const bst = new BST();
// bst.root = nodeOne;
bst.insert(26).insert(12).insert(62).insert(11).insert(19)
console.log("BST : ", bst);
// console.log("Min BST = ", bst.min());
// console.log("Max BST = ", bst.max());
console.log("Find 20 = ", bst.find(20));
console.log("Find 62 = ", bst.find(62));