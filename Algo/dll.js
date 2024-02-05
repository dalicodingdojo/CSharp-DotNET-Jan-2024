class Node {
    constructor(data){
        this.data  = data;
        this.next = null;
        this.previous = null;
    }
}
class DLL {
    constructor(){
        this.head = null;
        this.tail = null;
    }
    isEmpty(){
        return this.head == null
    }
    addToHead(value){
        let newNode = new Node(value)
        if(this.isEmpty()){
            this.head = newNode
            this.tail = newNode
            return this
        }else {
            newNode.next = this.head
            this.head.previous = newNode
            this.head = newNode
            return this
        }
    }
}

const nodeOne = new Node(26);
const nodeTwo = new Node(-10);
const nodeThree= new Node(73);
nodeOne.next = nodeTwo
nodeTwo.previous = nodeOne
nodeTwo.next = nodeThree
nodeThree.previous = nodeTwo
const dll = new DLL()
dll.head = nodeOne
dll.tail = nodeThree
console.log("Double Linked List : ", dll);
dll.addToHead(99)
console.log("------------------------------------------------");
console.log("Double Linked List : ", dll);

