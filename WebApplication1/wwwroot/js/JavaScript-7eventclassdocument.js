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
    let name='您';
document.getElementsByTagName('h1')[0].addEventListener('click',greet) ;
function greet(name) {
        alert('hello,' + name);
}
</script>