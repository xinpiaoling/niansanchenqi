//JQuery是一个JavaScript的库;


优点：
完美的解决了浏览器兼容性的问题（cross - brower）
强大的选择器
方便的Ajax调用
常用方法封装（hide / toggle / animate）
一些新颖独特的语法 / 书写模式
大量第三方插件（plugin）的支持（JQuery UI, mobile UI, bootstrap, Vue）


<script type="~/lib/jquery/dist/"></script>


$(document).ready(function () {          // 起手式    
    $("p").click(function () {           //选择器和事件
        $(this).hide();                  //常用封装
    });
});


min是压缩文件，节省带宽

CDN是content delivery network


先放置JQuery, 再放bootstrap等插件

$('td')[0]     //通过tagname来取内容
$('.class')[0]   //通过class
$('[href]')[0]    //通过属性来取
$('#zyf')       //通过ID来取


前段开发的痛苦是  JQuery通过标签a取内容，然后前端a更改了，导致JQuery写的错误，取不到也不报错


$('p')[0] 和 $('p:first')的区别：都是取第一个P标签，但是$('p')[0] 取出来的是JavaScript对象，$('p:first')取出来的JQuery对象

$('p:first')     //第一个P标签
$('p:last')      //最后一个P标签
$('p:even')      //偶数P标签
$('p:odd')      //奇数P标签


$('p[type="text"]')       //通过p标签的属性type="text"来取，这样更加准确

$('p,h1')         //取这两个标签p和h1的内容

$('table>tr')     //取table标签下的tr标签内容


书写惯例 一种提示  JQuery的变量以$符号开头，如$this = $(this)

遍历
$('p[href]').parents()[0]     //取这个含有href属性的p标签的第一个父辈元素
$('p[href]').parent()
$('p[href]').parentsUntil('div')[0]  //直到。。。

chirdren()



DOM操作
$('div').html('mmmmm')             //赋值mmmmmm,如果括号不填则为取值
$('div').text()

例
$(document).ready(function () {
    $('button').click(function () {
        alert($('[text]'.val()));             //取值
    })
})

    < input type = "text"  val = "" />
        <button> 显示值</button>


$('[text]').val()            //取值



$('[text]').val(i, function () {

})

$("#w3s").attr("href"))     //取属性

$('#w3s').attr(
    {
        "href": "www.baidu.com",
        "title": "build Dream"                      //给多个属性设置属性

    })


$('#w3s').attr("href", fucntion(i, origValue){      //利用回调函数设置属性
    return origValue + "/JQuery";
})


$("w3s").text(function (i, origText) {
    return origText + "hello world(index:" + i + ")";       //利用回调函数设置text
});


$("w3s").html(function (i, origText) {
    return origText + "hello world(index:" + i + ")";     //利用回调函数设置html
});



$("p:first").append(" <b>Appended text</b>.");           //在第一个p标签的末尾加上内容


$("p:first").prepend(" <b>Appended text</b>.");         //在第一个p标签的开头加上内容

function appendText() {
    var txt1 = "<p>Text.</p>";              // 以 HTML 创建新元素
    var txt2 = $("<p></p>").text("Text.");  // 以 jQuery 创建新元素
    var txt3 = document.createElement("p");
    txt3.innerHTML = "Text.";               // 通过 DOM 来创建文本
    $("body").append(txt1, txt2, txt3);        // 追加新元素
}


$("img").after("<b>after</b>");               //在图片后面加内容

$("img").before("<b>before</b>");             //在图片前面加内容



$("div1").remove();                           //删除选中元素和子元素
$("div1").empty();                            //删除子元素


$("div").remove("[zyf]");                     //删除所有含有zyf属性的div标签
CSS

$("h1,p").addClass("blue important")             //在所有的h1,p标签上添加类blue
$("h1,p").removeClass("blue")                    //在所有的h1,p标签上删除类blue
$("h1,p").toggleClass("blue")                    //在所有的h1,p标签上切换类blue




例
    < script >
    $(document).ready(function () {
        $("button").click(function () {
            $("h1,h2,p").removeClass("blue");
        });
    });
</script >
    <style type="text/css">
        .important
{
            font - weight: bold;
    font-size:xx-large;
    }
    .blue
{
            color: blue;
    }
</style>




$("p").css("background-color")                //取出值

$("p").css("background-color", "yellow")      //设置背景颜色

$("p").css("background-color": "yellow", "font-size": "200px")



$("p").hide(1000);            //隐藏这个便签内容,1000是可以设置的隐藏速度，也可以设置fast,slow
$("p").show();                //显示这个便签内容
$("p").toggle();              //切换显示隐藏

例
$("document").ready(function () {
    $("button").click(function () {
        $("p").toggle();
    });
});


$(document).ready(function () {
    (function repeatHide() {
        $("p").hide(2000, function () {
            $("p").show(2000, repeatHide());
        })();
    });
});


$("p").slideDown();         //向下滑动这个标签内容，括号内可填写speed,callback函数
$("p").slideUp();
$("p").slideToggle();



$(selector).animate({ params }, speed, callback);           //动画效果。params是css属性参数，必选。。speed和callback同上。
例
$("button").click(function () {
    $("div").animate({
        left: '250px',                          //把div标签内容移动为离左边250px。注意位置的变动要在便签内设置position的absolute，relative，fixed
        height: '+=150px',
        weight:'+=100px'
    });                                   
}); 

$("#stop").click(function () {
    $("#panel").stop();                         //在动画运行期间停止动画的运行效果
});


callback的用法是在效果运行后执行这个函数，不然容易产生页面冲突等。

另一种绑定事件on和取消绑定事件off的写法
$(document).ready(function () {
    $("button").on('click', function () {
        $("p").hide;
    })
    $("button").off('click', function () {
        $("p").hide;
    })

});


推荐写法
$(document).ready(function () {
    $('p').click(function (event) {
        event.preventdefault();
        $(this).hide;
    });
});


只支持冒泡事件，不支持捕获事件



静态方法
trim   

var greet = "         源栈欢迎您                ";
$.trim("greet")           //清除前后文空格，中间的文字空格无法清除

$.isNumberic(23)       //判断其是不是一个数字


$('.text-area').data('id');       //


$.noConflict();             //解决命名冲突的方法
例
var jq = $.noConflict();
jq(document).ready(function(){
    jq("button").click(function () {
        jq('p').hide;
    });

});



