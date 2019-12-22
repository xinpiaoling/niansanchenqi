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






同一个类的不同实例共享一个prototype
可以在function prototype上设置属性，从而影响该函数生成的对象

function senior(student){
    this.student = student;
}
senior.prototype.end = function () {
    console.log('这个'+this.student+'是谁');

};

let xin = new senior('girl');
xin.end();



get End(){);
}

set End(value){
    console.log();
}


var _end = date;

_表示提示这个变量为私有





继承的本质


子类.__proto__ = 父类；

































