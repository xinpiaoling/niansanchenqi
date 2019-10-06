例1
function hello() {
    console.log(this);     //this是window
}
hello();
例2
'use strict';             //使用严格模式
function hello() {
    console.log(this);     //undefined
}
hello();

例3
function Student() {
    this.name = name;         //构造函数里面的this就是对象本身

    //return this;
}
var wx = new Student('');

例4
var test = {
    hello: function () {
        console.log(this);    
    }
};
test.hello();

//输出：{hello:f()};


事件处理函数：触发事件的DOM元素（复习：冒泡 / 捕获, target / current / Target）

例5
<button onclick="alert(this.tagname,toLowerCase())">
show this
</button>
//输出：弹出button
例6

< button onclick = "show" >
        show this
</button >
    function show() {
        alert(this.tagname, toLowerCase())
    }
//输出：报错。此处的this为window。window没有tagname.
//更改为例7

例7
< button onclick = "show(this)" >
        show this
</button >
    function show(that) {
        ale

        rt(that.tagname, toLowerCase())
    }

//输出：弹出button。
//变量转换


例8
function Student() {
    this.age = 0;
    setInterval(function () {
        this.age++;

    },1000);
}

var wf = new Student();

//未改




箭头函数


例9
function add(a, b) {
    console.log(`${a}+${b}=${a+b}`);
    return a + b;
}
变1
((a, b) => {
    console.log(`${a}+${b}=${a + b}`);
    return a + b;
})(3,5);

变2
var add=(a, b) => {
    console.log(`${a}+${b}=${a + b}`);
    return a + b;
};
add(3, 5);
//一般匿名函数使用,绑定事件时候

例10
function Student() {
    this.age = 0;
    setInterval(()=> {
        this.age++;
    }, 1000);
}

var wf = new Student();

//根据例8更改




Apply和Call
使用Function对象的Apply和Call方法，使得传入第一个参数为this, 其他参数就是Function的参数;


例11
function hello(sname) {
    console.log(sname + this.age);
}

hello.call({ age: 37 }, '飞哥');


//使用call固定this为括号内的值；


Math.max.apply([30, 50, 100]);


















