








//setTimeout��setIntervalʹ�÷���
//setTimeout��ֻ����һ�Σ�setInterval�ظ�����

//����
//function repeat(name) {
//    alert('hello,' + name);
//}
//function delayGreet(name) {
//    setTimeout(function () {
//        repeat(name);
//    }, 2000);
//}
//var result = delayGreet('����');



                             
                             


//            function greet(name) {
//                alert('loser or success' + name);
//            }
//           var counter = 0;
//var mutiplegreet = setinterval(function () {
//                greet('����');
//            counter++;
//    if (counter === 2) {
//                clearinterval(mutiplegreen);
//            }
//        }, 2000)
        
function greet(name) {
	console.log('hello,'+name)

}    
var conunter=0;
setTimeout(function () {
    setTimeout(function () {
        counter++;
        console.log('counter:' + counter);
        greet('����');



    }, 1000)



}, 1000);
console.log('after multipleGreet');












