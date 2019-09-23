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



