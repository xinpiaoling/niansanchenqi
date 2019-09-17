//使用setTimeout()（不是setInterval()）实现每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
//测试用例
//第5周，源栈同学541人；
//明确需求
//周数设置为1-48周以内包含第48周；
//人数要求为正整数；
//人数限制为0-1000人以内,，；



//var counter = 1;
//function greet() {
//    if( counter< 49) {
//        var k = Math.ceil(Math.random() * 1000 + 1);
//        setTimeout(function () {
//            console.log('第' + counter + '周，源栈同学' + k/*Math.ceil(Math.random() * 1000) */ + '人');
//            counter++;
//            greet();
//        }, 1000);

//    }

//}

//greet();



//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

//测试用例
//


var gameNumber = Math.ceil(Math.random() * 1000);
console.log(gameNumber);

if (confirm(`游戏



规则`)) {
    for (var i = 1; i < 11; i++) {
        var word = prompt('');
        if (isNaN(word)) {
            if (i < 10) {
                alert('你输入的不是一个数字,请输入一个正整数');
                continue;
            }
            else {
                alert('^ (*￣(oo) ￣)^');
                break;
            }

        }
        if (word < 0) {
            if (i < 10) {
                alert('你输入的不是一个正整数，请输入一个正整数');
                continue;
            }
            else {
                alert('^ (*￣(oo) ￣)^');
                break;
            }

        }
        if (!(word.indexOf('.') === -1)) {
            if (i < 10) {
                alert('你输入的不是一个正整数，请输入正整数');
                continue;
            }
            else {
                alert('^ (*￣(oo) ￣)^');
                break;
            }

        }
        if (word == gameNumber) {      //无法比较。修改三个等号为两个等号，解决问题，可以比较
            if (i < 6) {
                alert('碉堡了');
                break;

            } else if(i<8) {
                alert('666');
                break;

            } else {
                alert('猜到了');
                break;
            }
        }
        else if (word < gameNumber) {
            if (i < 10) {
                alert('小了');
            }
        }
        else if (word > gameNumber) {
            if (i < 10) {
                alert('大了');
            }
        }

        else {
            alert('^ (*￣(oo) ￣)^');
        }

    }

}

















