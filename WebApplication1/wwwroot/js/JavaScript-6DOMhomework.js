//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果
//利用标签sample取出
var changeColor = document.getElementById('sample').style.color;
setInterval(function () {
    if (changeColor === 'red') {
        changeColor = 'green';
    } else {
        changeColor = 'red';
    }
}, 1000);





//统计有多少个悬赏大于1的求助
//解题思路，找到求助这个字符，设定条件if>0的while循环，使用i++，最后console.log(i)即可。

//<a class="help" /a>
//整体思路是这样，，悬赏不会写css
var help = document.getElementsByClassName('help');
//document.getElementsByClassName('help')[i].innerText;
var counter = 0;
for (var i = 0; i < help.length;i++) {
    if (help[i].innerText > 1) {
        counter= counter+ 1;
    }
}
console.log(counter);









//将状态为“协助中”的求助背景改成灰黑色
 //解题思路,找到"协助中"的blackground,=darkgray;

//这是一起帮主页的位置取出的
//document.getElementsByClassName('problem-status')[1].style.backgroundColor = 'darkgray';

var dark = document.getElementsByClassName('problem-status');
for (var i= 0; i < dark.length; i++) {
    if (dark[i].innerText === '协助中') {
        dark[i].style.backgroundColor = 'darkgray';

    }

}



//写一个函数，可以统计某个求助使用了多少关键字

//还是没有自己写css页面，直接从一起帮页面太难取出。

//没有写出来
//function get() {
//    var keyWords = document.getElementsByClassName('bear');
//    for (var i = 0; i < keyWords.length;i++) {
//        if()
//    }
//}








//如果总结数为0，将其从DOM树删除

//var removeSummary = document.getElementsByClassName('bear')；
//在一起帮页面取出“总结”的方法：document.querySelector('span.fa-key').nextElementSibling.innerText
//使用remove（document...）方法可以删除
//一起帮页面太复杂。太难取了







//参考用户注册页面，创建一下函数：
//显示密码的长度

//参考用户注册页面，创建一下函数：
//如果密码和确认密码不一致，弹出提示

var password = document.querySelectorAll('[type="password"]')[0].value;
var repeatpassword = document.querySelectorAll('[type="password"]')[1].value;
alert('你输入的密码长度为' + password.length);
//回答上一道题
if (!(password === repeatpassword)) {
    alert('您输入的密码和确认密码不一致');
}

//总结：回答这道题
//注意elements的文件要加下标，不然取出来的是数组

//参考用户资料页面，控制台显示出用户的：性别 / 出生年月 / 关注（关键字）/ 自我介绍
//自己不会写css页面，此题是抄陈元

document.getElementsByClassName('button')[0].onclick = previous();
function previous(event) {
    event.preventDefault();
    if (document.getElementsByName('sex')[0].checked) {
        console.log('你选中的是男性');
    } else {
        console.log('你选中的是女性');
    }
    var year = document.getElementsByClassName('year')[0].value;
    var month = document.getElementsByClassName('month')[0].value;
    var constellation = document.getElementsByClassName('constellation')[0].value;
    console.log('你出生于' + year + '年' + month + '月，你的星座是' + 'constellation ');
    console.log(document.getElementsByClassName('introduce')[0].value);
}



