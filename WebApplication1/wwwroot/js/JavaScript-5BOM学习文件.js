
//setTimeout和setInterval使用方法
//setTimeout是只出现一次，setInterval重复出现

//例子
function repeat(name) {
    alert('hello,' + name);
}
function delayGreet(name) {
    setTimeout(function () {
        repeat(name);
    }, 2000);
}
var result = delayGreet('王新');
function greet(name) {
    alert('loser or success' + name);
}




var counter = 0;
var mutiplegreet = setinterval(function () {
    greet('王新');
    counter++;
    if (counter === 2) {
        clearinterval(mutiplegreen);
    }
}, 2000);



//var conunter = 0;
//setTimeout(function () {
//    setTimeout(function () {
//        counter++;
//        console.log('counter:' + counter);
//        greet('王新');
//    }, 1000);s
//}, 1000);

setTimeout(greet, 2000);
greet('王新');
console.log('after multipleGreet');

