class Person {
    constructor(name,age) {
        this.name = name;
        this.age = age;
    }
    greet() {
        console.log(this.name+'是一个hero');

    }
    get End() {
        return this.name.toUpperCase();
    }
    set Finish(value) {
        this.name = value;
    }
}


异常不等于语法错误
异常的原因是程序无法处理当前的状况



function add(a, b){
    if (typeof a!== 'number' || typeof b!=='number') {
        throw new Error("a或b不是一个数字");

    }
    return a + b;
}

function showResult() {

    try {
        console.log(add('a', 1));
    } catch (e) {
        //log
        console.log('出错了' + e);
        throw e;
    } finally {
        console.log('继续运行代码');
    }
 
}

showResult();




























