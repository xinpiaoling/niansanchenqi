//例子1
<h1 onclick="greet('luckystar')" >  HTML 示范 DOM元素</h1>
//onclick使用在绑定事件上，其他情况使用click。
//点击这一行，就会出现，这是因为代码块。
<script>
function greet(name) {
    alert('hello'+name);
}
</script>

//例子2
//一般使用这样的形式
    <h1 >  HTML 示范 DOM元素</h1>
<script>
    let name='luckystar';
document.getElementsByTagName('h1')[0].addEventListener('click',greet) ;
function greet(name) {
        alert('hello,' + name);
}
    </script>
//例子3
<script>
    <h1 >  HTML 示范 DOM元素</h1>

   let name='luckystar';
 document.getElementsByTagName('h1')[0].onclick = greet();
function greet(name) {
        alert('hello,' + name);
}
  
</script>

//例子4
<script>
<h1 >  HTML 示范 DOM元素</h1>
let name='luckystar';
document.getElementsByTagName('h1')[0].onclick = function greet(){
        alert('hello,' + name);
}   
    </script>

//例子5
<script>
    <h1 style="color red" >  你必须努力挣钱，才可以有钱做自己想做的事情</h1>
document.getElementsByTagName('h1')[0].onclick = function greet(){
        alert(this.innerText);            //this.innerText是内置属性，可以取出。this.style或者.name取不出来
    }
    </script>


//例子6  使用this

document.getElementById('btn').onclick = function () {
    document.getElementsByTagName('h1')[0].style.color = 
        this.style.color;
}

//谁触发了事件，谁就是this

//例子7  prevent default  //禁止默认行为

document.getElementsByTagName('a')[0].onclick = function (event) {
    event.preventDefault();



    console.log('event.type:' + event.type);
    console.log('event.target:' + event.target);      //此处的event.target是整个dom元素a标签。<a>sss</a>
}
//比如点击会跳转网页，使用event.preventDefault()可以阻止跳转。


//例子8   return false     //功能同上
document.getElementsByTagName('a')[0].onclick = function (event) {
    //event.preventDefault();
    //return false; 
    console.log('event.type:' + event.type);
    console.log('event.target:' + event.target);      //此处的event.target是整个dom元素a标签。<a>sss</a>
    return false;            //return false后面的程序不会再运行。而event.preventDefault()后面的程序还是会执行，推荐使用event.preventDefault()
}



//window.onload   页面打开时加载
//focus/blur     移入/移出焦点
//keydown/keypress/keyup        keydown输入（找到按下的键）



//例子9
document.getElementsByName('level')[0].onchange = function (e) {
    console.log(this.children[this.selectedIndex].innerText);
}

//change     选择更改后


//例子10
document.getElementsByName('form')[0].onsubmit = function (e) {
    if (document.getElementsByName('username')[0].value==='') {
        alert('用户名不能为空');
        return false;
    }

}



//例子11
window.onbeforeunload = function (e) {
    return '关闭提示';
}



//onload    加载    unload   卸载


//例子12
//scroll 滚动条 offset 偏移  visible  可视的  content  内容  overflow  溢出

document.querySelector('[zyf-scroll-sample]').addEventListener('scroll', function () {
    console.log('offsetHeight:' + this.offsetHeight);
    console.log('clientHeight:' + this.clientHeight);
    console.log('scrollHeight:' + this.scrollHeight);
    console.log('clientTop:' + this.clientTop);
    console.log('scrollTop:' + this.scrollTop);

};
//offsetHeight      可视化高度+边框高度
//clientHeight     客户端高度，可视化高度
//scrollTop        滚动条上方高度
//scrollHeight      滚动高度，内容高度

//visible的高度小于content的高度，会出现滚动条   



//例子13
<h2> 万紫千红</h2>
    <button style="color:red" name="change-color">变红</button>
    <button style="color:blue" name="change-color">变蓝</button>
    <button style="color:yellow" name="change-color">变黄</button>
    <script>
        function changeColor(color) {
            document.getElementsByTagName('h2')[0].style.color = color;
        }
            //document.getElementsByTagName('button')[0].onclick = function () {
            //    changeColor('red');
            //}
            //document.getElementsByTagName('button')[1].onclick = function () {
            //    changeColor('blue');
            //}
            //document.getElementsByTagName('button')[2].onclick = function () {
            //    changeColor('yellow');
            //}
            var btns = document.getElementsByTagName('button');
            for (var i = 0; i < btns.length; i++) {
            btns[i].onclick = function () {
                changeColor(this.style.color);
            }
        }
    </script>


//绑定事件的时候不能加括号，加了括号是返回一个函数运算结果回去。

//注意需要闭包现象


//例子14
<style>
    spropagate{
        padding:30px;
border:1px solid;

}

    #propagate>ol{
        background-color:blue;
}

    #propagate>ol>li{
        border:1px dashed;
    }

    </style>

<div id="propagate">
    <ol style="padding:30px;">
        <li>深藏功与名</li>
    </ol>
</div>

<script>
    var father=document.getElementById('propagate'),
    child= father.children[0];
    father.addEventListener('mouseover',function(event){
        //event.stoppropagation();   //阻止传播
        console.log('event.target of father:'+event.target.innerHTML);
        console.log('event.currentTarget of father:'+event.currentTarget.innerHTML);
console.log('this=event.currentTarget in father:?'+(this ===event.currentTarget));
},true);

    child.addEventListener('mouseover',function(){
        //event.stoppropagation();   //阻止传播
        console.log('event.target of child:' + event.target.innerHTML);
        console.log('event.currentTarget of child:'+event.currentTarget.innerHTML);
        console.log('this=event.currentTarget in child?'+(this === event.currentTarget));
    },false);

</script>


//冒泡是由内到外，捕获是从外到内
//w3c标准：先冒泡由内到外，再捕获从外到内

//true - 事件句柄在捕获阶段执行
//false- false- 默认。事件句柄在冒泡阶段执行


