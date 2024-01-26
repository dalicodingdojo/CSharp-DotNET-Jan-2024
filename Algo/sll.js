// Singly Linked List

class SLL {
    constructor(){
        this.head = null
    }
    isEmpty() {
        if(this.head){
            return false
        }else{
            return true
        }
    }
    isEmptyV01() {
        return this.head==null
    }
    addToFront(data){
        const newNode  = new Node(data)
        if(this.isEmpty()){
            this.head = newNode
            return this
        }else{
            newNode.next = this.head
            this.head = newNode
            return this
        }
    }
    addToFrontV01(node){
        if(this.isEmpty()){
            this.head = node
            return this
        }else{
            node.next = this.head
            this.head = node
            return this
        }
    }
    removeAtFront(){
        if(this.isEmpty()){
            return false
        }else {
            this.head = this.head.next
            return this
        }
    }
    print(){
        if(this.isEmpty()){
            return false
        }else{
            let runner = this.head
            while(runner){
                console.log(runner.data);
                runner  =  runner.next
            }
        }
    }
    contains(value){
        if(this.isEmpty()){
            return false
        }else{
            let runner = this.head
            while(runner){
                if(runner.data == value){
                    return true
                }
                runner  =  runner.next
            }
            return false
        }
    }
    length(){
        if(this.isEmpty())
        {
            return false
        }else{
            let count  = 1;
            let runner  = this.head
            while(runner.next){
                count ++;
                runner = runner.next;
            }
            return count;
        }
    }
    addToBack(value){
        if(this.isEmpty()){
            this.addToFront(value)
            return this
        }else{
            let newNode = new Node(value);
            let runner  = this.head;
            while(runner.next){
                runner = runner.next;
            }
            runner.next = newNode
            return this
        }
    }
    delete(value){
        if(this.isEmpty()){
            return false
        }else if(this.head.data == value){
            this.head = this.head.next
            return this
        }else {
            let runner  = this.head
            while(runner.next){
                if(runner.next.data == value){
                    runner.next = runner.next.next
                    return this
                }
                runner = runner.next
            }
        }
    }
    reverse(){
        if(this.isEmpty()){
            return false
        }else{
            const reversedList = new SLL();
            let runner = this.head
            while(runner){
                reversedList.addToFront(runner.data)
                runner = runner.next
            }
            return reversedList
        }
    }
}

class Node {
    constructor(data){
        this.data = data
        this.next = null
    }
}

const sll  = new SLL();
// console.log("Is SLL Empty? ->  ", sll.isEmpty());
// console.log("Is SLL EmptyV01? ->  ", sll.isEmptyV01());
const nodeOne =  new Node(24);
const nodeTwo =  new Node(2);
const nodeThree =  new Node(-30);
const nodeFour =  new Node(73);
sll.head = nodeOne
// console.log("Is SLL Empty? -> ", sll.isEmpty());
// console.log("Is SLL EmptyV01? -> ", sll.isEmptyV01());
nodeOne.next = nodeTwo
nodeTwo.next = nodeThree
nodeThree.next = nodeFour
// console.log(sll);
// console.log(nodeOne);
// console.log(nodeTwo);
// console.log(nodeThree);
// sll.print();
// sll.removeAtFront()
// console.log("--------------------------");
// sll.print();
// console.log("Contains  2 -> ",sll.contains(2));
// console.log("Contains  5 -> ",sll.contains(5));

// console.log("SLL Length : " , sll.length());
// const sllTwo = new SLL()
// console.log("SLL Length : " , sllTwo.length());
// sll.print()
// console.log("--------------------------");
// sll.addToBack(999)
// console.log("--------------------------");
// sll.print()
// sll.print()
// sll.delete(8)
// console.log("--------------------------");
// sll.print()
sll.print()
const reversedSll = sll.reverse()
console.log("--------------------------");
reversedSll.print()

