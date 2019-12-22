//内置对象

parseInt('1生1世')    //尽量转换。  1
+ 1生1世             //全部能转换才转换        NaN 

    .是对象的运算符

build -in 内置

JavaScript万物皆对象

new  //新创建一个对象

var n = new Number(32);


new Date();
new Date().getyear();            //年是正常显示的，2019
new Date().getmonth();          //月份是从0计算的，9月显示8月

new Date().getday();           //显示星期几，2


new Date(2019, 3, 17);                  //指定日期，无指定的时间会自动补齐

Date.parse(new Date());              //时间戳，解析时间.得到一串数字   158244684355

new Date(new Date().setDate(17))              //指定日期17号

new Date(new Date().setMonth(new Date().getMonth()-1))    //指定日期8月。。。当前月份减去一个月就是八月


ES6新特性

Map
//复习二位数组方法
var students = [['于伟倩', 95], ['彭志强', 96], ['王新', 75]];
for (var i = 0; i < students.length; i++) {
    console.log(students[i][0]+'：'+students[i][1]);
}

//使用Map方法
var students = new Map([['于伟倩', 95], ['彭志强', 96], ['王新', 75]]);
students.get('于伟倩');      //通过key取出值value
students.set('阿泰', 80);     //添加key,value
students.have('阿泰');        //检查key是否存在
students.delete('阿泰');      //通过key删除value

//无法通过value取出key

//以上是简单的Map使用方法，可以在MDN查看




Set

var s = new Set([1, 2, 3, 3, '3']);

s.keys

s.values()

//Set的重复的值会被删除



for ... of   //只取集合元素，不取属性
for...in...//遍历对象内属性

for (var i in students) {
    console.log(i);
}



var m = new Map([[1, 'x'], [2, 'y'], [3, 'z']]);
m.forEach(fuction(value, key, map ){
    console.log(key);
    });


//根据参数位置遍历。后面的参数可以不写



var s = new Set([1,2,3,'3']);

s.add(5);
s.add({ nume: '彭志强' });

s.add({ nume: '彭志强' });      //两个都可以添加，这两个对象不相等，只是值相等，Set不会删除



iterable //迭代器




再看数组


var arr = [2,-1,'33',true,78.5,null,'',15];

arr.map(function (value, index, array) {
    console.log(value);                               

});                       



//map：对数组元素依次进行运算

//filter：过滤掉不符合条件的元素

//sort：自定义排序规则

//every：检查数组里每个元素是否符合规则

//find / findIndex：

//reduce：重叠运算，每一次运算返回的值作为previous



var n = '33' + 1;
cosole.log(n);           //n为331



var cumulated = arr.reduce(function (previous, currentIndex, array) {
    console.log(`previous:${previous}    currentIndex:${currentIndex}`);
    if (!isNaN(previous + currentIndex)) {
        console.log('continue');
        return currentIndex + previous;
    } else {
        console.log('ignore');
        return previous;
    }
});





正则表达式（Regular Expression）

创建正则表达式
字面量：两个斜杠（//）包裹，如/<a.*?/a>/gl,注意不要加引号
RegExp构造函数：（表达式会动态改变时使用）
var regex = new RegExp('/< a.*?/a >/', 'gi');

var reg = /<option.*?> /gim;
var result = null;

while ((result = reg.exec(`<form>
        <input type="text" name="username" />
        <textarea></textarea>
        <select name="level">
            <option value="1">一级</option>      
            <option value="2">二级</option>
            <option value="3">三级</option>

            <option>4</option>
            <option>5</option>
        </select>
        </form>`))!== null) {
    console.log(result[0] + ':' + reg.lastIndex);


}


//execute  执行



function getHighScoresStudents() {

    var scores = new Map([['于伟倩',95],['阿泰',80],['彭志强',94]]);

    var result;
    scores.forEach(function (value, key, map) {
        if (value > 80) {
            result= key;
        }
    })
    return result;

}

//forEach里面return的值还在里面，必须要赋值，再在外面return








var reg = /<option.*?> /gim;

var option = `<form>
        <input type="text" name="username" />
        <textarea></textarea>
        <select name="level">
            <option value="1">一级</option>      
            <option value="2">二级</option>
            <option value="3">三级</option>

            <option>4</option>
            <option>5</option>
        </select>
        </form>`;

console.log(option.match(reg));
console.log(option.substring(option.search(reg)));





//gim是指示标志。g是global, i是ignore case, m是multiple line;
//test() ：Regexp方法，返回 true / false
//search() ：String方法，返回 index / -1
//match() ：String方法，返回 array / null
//exec() ：Regexp方法，返回 array / null
//replace():String方法




var target = document.getElementsByTagName('body')[0].innerHTML;

var reg = /<h1.*>(.*)<\/h1>/g;

target = target.replace(reg,function(match,content){
    return match.replace(content, 'hello world');
})





回调函数：把函数作为一个参数传入主函数,这个函数就是回调函数。

例1
function main(para) {
    console.log(`I'm main function,I invoked para`);
    para();

}
main(callback);

function callback() {
    console.log(`I'm a callback function`);

}
//函数提升

//变量提升，提升的是变量，不是提升变量里面的值。


例2

var callback = function (sname) {
    console.log(`I'm a callback function,name is ${sname}`);
};


function main(para,work) {
    console.log(`I'm main function,I invoked para（）`);
    para(work);
}
main(callback, 'eat');




例3

function main(callback) {
    var sname = '飞哥',age = '38';
    callback(sname, age);
}

main(function (n, a) {
    console.log(`${n}今年${a}岁`);

});






JSON(JavaScript Object Notation)

序列化：将对象的状态信息转换为可以存储或传输的形式的过程（简单理解：内存=>i/0）
XML是一种严格的文本格式，较臃肿。JSON较简洁
内存直接和cpu进行配合的运算
磁盘（外存）：存储信息

内存和外存信息的传递


方括号是数组的形式
花括号是对象的形式

编码格式必须是UTF - 8，包含6种类型：
1.Number
2.boolean
3.string
4.null
5.string
6.object

JSON是把对象转换为字符串的形式，还有其他变化


例1  序列化
console.log(JSON.stringify(laocheng));   //把对象转换为JSON字符串
console.log(JSON.stringify(laocheng,null,' '));     //null值表示全部转换，，''表示换行


例2   反序列化
JSON.parse("laocheng");   //对JSON解析，变成JavaScript对象


注意null和undefined






















