class Student {
    constructor(name) {
        this.name = name;
    }
    hello() {
        alert('hello,'+this.name+'!');
    }
}


var cxb = new Student('陈晓斌');
cxb.hello();

var zjq = new Student('曾俊清'); 


一定要带上this，不然不能用




原型

法则：实例对象._proto_ = 函数.property;


cxb.hasOwnProperty(age);














class Person {
    constructor(name) {
        this.name = name;

    }
    hello() {
        console.log('hello'+this.name);
    }
}

