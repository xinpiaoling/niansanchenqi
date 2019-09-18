//浏览器弹窗常用动作
//alter（）；   弹出弹窗一次，（内容）；
//confirm（）；  弹出弹窗一次，（内容），出现确认 / 取消选项，返回true / false；
//prompt(); 弹出弹窗一次，（内容），出现输入框，输入内容，内容会显示在浏览器窗口，点击取消会返回null值
//open();  （'网址'），新建一个窗口，转到网址页面

//location.href               出现当前页面的网址
//location.href = 'http://17bang.ren'   不新建窗口，直接转到输入的网址
//location.host    出现主机域名 17bang.ren
//location.port     出现端口地址 /article/search
//location.protocol   出现协议 http:
//location.search     出现编码  % 4ssl %$
//location.reload     页面重新加载
//location.reload(true)    强制刷新，作用和ctrl + F5一样
//location.repalce()('网址')跳转网址，无法回退网页
//location.assign()       可以回退网页

//navigator.userAgent      可以查看浏览器的类型，目前浏览器伪装很多，判断不出来浏览器类型

//history.back          回退一个页面
//history.forward       前进一个页面
//history.go(-2)        回退两个页面。可以指定回退或者前进步长
//screen        查看屏幕信息












//setTimeout和setInterval使用方法
//setTimeout是只出现一次，setInterval重复出现

//例子1

//function greet(sname) {
//    alert('hello' + sname);
//}
//function delayGreet(name) {
//    var title = '先生';
//    return function () {
//        setTimeout(function () {
//            greet(name + title);
//        }, 2000);
//    };
//}
//var result = delayGreet('王新');
//result是一个函数，将参数name赋值'王新'，greet(sname)中参数sname赋值为name+title
//title属于闭包，闭包的作用为储存这个值title，直到result函数调用的时候才被释放，不然它会一直保存，外部无法使用这个参数


//例子2
//function greet(name) {
//    alert('hello' + name);
//}
//setInterval(function () {
//    greet('于伟倩');
//}, 2000);
//传入一个函数，再赋值。可以重复运行。
//例子3


//function greet(name) {
//    alert('hello' + name);
//var counter = 0;
//var mutipleGreet = setInterval(function () {
//    greet('王新');
//    counter++;
//    console.log(counter);
//    if (counter === 3) {
//        clearinterval(mutipleGreet);
//    }
//}, 2000);
//console.log('会被先执行');
//setInterval和setTimeout是异步的代码，JavaScript先执行同步代码，再执行异步代码

//var counter = 0;
//function greet() {
//    //var counter = 0;
//    return setTimeout(function () {
//        console.log('hello');
//        counter = counter + 1000;
//        console.log('第'+counter/1000+'次间隔'+counter/1000+'秒');
//        setTimeout(greet, 1000 + counter);
//    },1);
//}
//greet();

//setTimeout里面嵌套一个函数，函数内部再写入setTimeout，
//外面的setTimeout是第一次出现的时间间隔1秒，里面的setTimeout是第二第三次。。。出现的时间间隔2,3。。。秒

