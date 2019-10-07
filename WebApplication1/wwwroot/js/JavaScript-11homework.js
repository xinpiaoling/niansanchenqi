
1.判断并证明事件处理函数中的this，等于target还是currentTarget

    < style >
#propagate {
    padding: 30px;
    border: 1px solid;
}

#propagate > ol {
    background - color: blue;
}

#propagate > ol > li {
    border: 1px dashed;
}
    </style >
    <div id="propagate">
        <ol style="padding:30px;">
            <li>深藏功与名</li>
        </ol>
    </div>
    <script>
        var father = document.getElementById('propagate'),
            child = father.children[0];
        father.addEventListener('click', function (event) {
            //event.stopPropagation();
            console.log('event.target of father:' + event.target.innerHTML);
        console.log('event.currentTarget of father:' + event.currentTarget.innerHTML);
        console.log('this=event.currentTarget in father?   ' + (this === event.currentTarget))
    }, true);

        child.addEventListener('click', function () {//event.stopPropagation();
            console.log('event.target of child:' + event.target.innerHTML);
        console.log('event.currentTarget of child:' + event.currentTarget.innerHTML);
        console.log('this=event.currentTarget in child?   ' + (this === event.currentTarget))

    }/*, false*/);

    </script>







2.已有如下代码：
var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
}
请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’


a.fn.call();          //飞哥    默认this为window

var bname = {sname:"飞哥"};
a.fn.apply(bname);    //飞哥

a.fn();    //老程








3.不改变上述代码，分别使用call()和apply() ，打印出‘文轩’和‘两开花’
var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
}

a.fn.call({ sname: "文轩" });    

var bname = { sname: '两开花' };
a.fn.apply(bname);





4.将fn()永久拷贝到showName() ，始终打印‘源栈最棒！^ _ ^’


var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
}



a.fn.bind({ sname:"源栈最棒！^ _ ^"})();





