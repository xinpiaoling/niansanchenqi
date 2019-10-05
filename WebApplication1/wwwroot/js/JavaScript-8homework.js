//1.JSON生成和解析：
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示。
var introduce = { name:'王新',age:25,QQ:"956506458",sex:'男',hobby:'study'};
console.log(JSON.stringify(introduce));
cosole.log(JSON.stringify(introduce, ['age']));
console.log(JSON.stringify(introduce, null, ''));         //null表示全部转换，''表示换行
console.log(JSON.stringify(introduce, function (key,value) {
    if (typeof value==="string") {
        return value.toUpperCase();
    }
}));

console.log(JSON.parse(JSON.stringify(introduce)));


onload = function () {
    var establish = document.getElementsByTagName('body')[0];
    establish.appendChild(createTable(sequence));
};

function createTable(sequence) {
    var table = document.createElement('table');
    table.setAttribute('style', 'width:450px');
    var headline = document.createElement('caption');
    headline.innerHTML = '学生信息表';
    table.appendChild(headline);
    table.appendChild(createTr('姓名', '年龄', 'QQ', '兴趣爱好', '性别'));
    table.childNodes[1].setAttribute('style','background:#cae8ea');
    for (var i = 0; i < sequence.length; i++) { 
    table.appenChild(createTr(sequence[i].name, sequence[i].age, sequence[i].QQ, sequence[i].hobby, sequence[i].sex));
    }
return table;
}


var creatTr = function (name, age, QQ, hobby, sex) {
    var tr = document.creatElement('tr');
    var tdName = document.creatElement('td');
    tdName.innerHTML = name;
    var tdAge = document.createElement('td');
    tdAge.innerHTML = age;
    var tdQQ = document.createElement('td');
    tdQQ.innerHTML = QQ;
    var tdHobby = document.createElement('td');
    tdHobby.innerHTML = hobby;
    var tdSex = document.createElement('td');
    tdSex.innerHTML = sex;










}


















//2.利用新学到的Array函数，重新完成之前的数组相关作业










//3.使用正则表达式判断某个字符串:
//a.是否是合格的Email格式
//b.是否是小数（正负小数都可以）
//c.将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）


a
设置合法邮箱的地址为'字段1'@'字段2'.'字段3'
字段1为数字和任意字母的组合，中间可以有不连续出现的”.”，”-“，”_”出现
字段2为数字和任意字母的组合
字段3为字母



测试1 输入： var email = "956506458@qq.com";
输出：true
测试2 输入：var email = "xinwang199406@163.com";
输出:true;
测试3 输入：var email = "正是@163.com";



var reg = new RegExp (/^ [a - z0 - 9A - Z]+@[a - z0 - 9A - Z]+\.[a - zA - Z]+$/ );
reg.test(email);



b
是否是小数
测试1: 输入：var number=0.11
输出：true
测试1: 输入：var number=-0.11
输出：true


var number = -0.11;
var reg = new RegExp(/^-?\d+\.\d+$/);
reg.test(number);




//c将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）
测试1
输入：<a lzyf-old=''
输出：<a lzyf-old=''
测试2
 输入：<span>zyf---+---fyz</span> 
输出：<span>zyf--+---fyz</span> 
测试3
输入：<a zyf-kk >32</a>

分析： zyf— 的格式为<英文标签名+ 空格 + zyf - 英文字母或者空格 



var reg=/<[^>]*\b(zyf-).*?>/;
var target = "<a zyf-222";
removezyf = removezyf.replace(reg,'');



function removezyf(target) {
    return target.replace(reg, function (match, content) {
        return match.replace(content,'')
    })
}

