//�ں���student()�������˺��������name��age��female��ʹ�ñհ����ƣ����䱩¶�������ⲿ
//function student() {
//    let name = 'lihua';
//    var age = 18;
//    var female = 'woman';
//    return function () {
//        return name;
//     //   return age;
//     //   return female;
//    }

//}
//var result = student();
//console.log(`"�հ��Ľ�����ƣ�"${name}`);





//�������´������н������ condition ? <statement when true> : <statement when false>��
//function foo(x) {
//    var tmp = 3;
//    return function (y) {
//        x = x ? x + 1 : 1;
//        console.log(x + y + tmp);
//    };
//}

//var bar = foo(0);
////���ߣ�var bar = foo(1);
////���ߣ�var bar = foo(0);

//bar(10);






//�Ķ����´��룬���������ͼ��ʾ����˵�����ɡ�
//����1����varΪlet
//function buildList(list) {
//    var result = [];
//    for (let i = 0; i < list.length; i++) {
//        result.push(function () {
//            console.log('item' + i + ': ' + list[i]);
//        });
//    }
//    return result;
//}

//(function () {
//    var fnlist = buildList([1, 2, 3]);
//    for (var i = 0; i < fnlist.length; i++) {
//        fnlist[i]();
//    }
//})();

//����Ƕ�ף�����ִ��

function buildList(list) {
    var result = [];
    for (var i = 0; i < list.length; i++) {
        result.push(
            (function (i) {
                function () {
                    console.log('item' + i + ': ' + list[i]);
                }
            })(i)
        );
    }
    return result;
}

(function () {
    var fnlist = buildList([1, 2, 3]);
    for (var i = 0; i < fnlist.length; i++) {
        fnlist[i]();
    }
})();

