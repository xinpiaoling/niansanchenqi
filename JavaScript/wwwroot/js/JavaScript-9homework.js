//1.用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end()

class Course{
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
    }
    begin() {
        //JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
        var startDateRule = this.startDate.getFullYear() + '-' + this.startDate.getMonth() + '-' + this.startDate.getDate();
        console.log(this.name + "于" + startDateRule + "开课，共有" + this.students.length + "名同学(" + this.students + ")报名");
    }
    end() {
        console.log(this.endDate);
    }
}

var JavaScript = new Course("JavaScript", new Date(2019,4,5),new Date(2020,1,20),['两开花','王枫','王平','采玲','老程']);
JavaScript.begin();
var SQL = new Course("SQL");



//Course.prototype.begin = function () {
//    console.log("飞哥真帅");
//};
JavaScript.__proto__.begin = function () {
    console.log("飞哥超级帅");
};
SQL.begin();

//2.生成两个课程对象：JavaScript和SQL













//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。





//4.不修改class，动态的改变begin()方法，使其能影响所有Course对象









//5.让end()方法为各自对象“自有”，其他对象无法修改

class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
        this.end = function () {
            console.log("飞哥");
        };
    }
    begin() {
        //JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
        var startDateRule = this.startDate.getFullYear() + '-' + this.startDate.getMonth() + '-' + this.startDate.getDate();
        console.log(this.name + "于" + startDateRule + "开课，共有" + this.students.length + "名同学(" + this.students + ")报名");
    }

}

var JavaScript = new Course("JavaScript", new Date(2019, 4, 5), new Date(2020, 1, 20), ['两开花', '王枫', '王平', '采玲', '老程']);
JavaScript.begin();
var SQL = new Course("SQL");

JavaScript.__proto__.end = function () {
    console.log("就是要改");

};

SQL.end();



//6.在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天

class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
        this.end = function () {
            console.log("飞哥");
        };
    }
    begin() {
        //JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
        var startDateRule = this.startDate.getFullYear() + '-' + this.startDate.getMonth() + '-' + this.startDate.getDate();
        console.log(this.name + "于" + startDateRule + "开课，共有" + this.students.length + "名同学(" + this.students + ")报名");
    }
    set EndDate(value) {
        if (value < this.startDate || value-this.startDate>365*24*60*60*1000) {
            throw new Error("毕业时间不能小于开课时间，并且大于365天");
        }
        this.endDate = value;
}
}

var JavaScript = new Course("JavaScript", new Date(2019, 4, 5), new Date(2020, 1, 20), ['两开花', '王枫', '王平', '采玲', '老程']);
JavaScript.begin();
var SQL = new Course("SQL");


JavaScript.EndDate = new Date(2019,10,3);









//7.判断并证明以下说法：
//ES里的class其实就是一个function
typeof Course === "function";



//constructor总是返回class的实例

class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
        return {};
    }
    begin() {
        //JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
        var startDateRule = this.startDate.getFullYear() + '-' + this.startDate.getMonth() + '-' + this.startDate.getDate();
        console.log(this.name + "于" + startDateRule + "开课，共有" + this.students.length + "名同学(" + this.students + ")报名");
    }
    end() {
        console.log(this.endDate);
    }
}

var JavaScript = new Course("JavaScript", new Date(2019, 4, 5), new Date(2020, 1, 20), ['两开花', '王枫', '王平', '采玲', '老程']);
JavaScript.begin();
var SQL = new Course("SQL");



//Course.prototype.begin = function () {
//    console.log("飞哥真帅");
//};
JavaScript.__proto__.begin = function () {
    console.log("飞哥超级帅");
};
SQL.begin();






也返回对象，并不是实例





//当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上

错的
class声明的方法被copy在实例对象的__proto__上。其本身没有这个属性

JavaScript.hasOwnProperty（begin）;
JavaScript.__proto__.hasOwnProperty(begin);








//JavaScript里面，类就是对象，对象也是类
错的
类本身是一个函数，对象不一定只是函数。












//只有Function才有prototype

对的


实例对象无prototype

法则：JavaScript.__proto__ = Course.prototype;




//Javascript是动态类型语言，所以对象的类型是可以随意更改的

对的



如更改为数组类型：JavaScript = [];







在封装作业的基础上，为Course添加两个子类：主修课（MajorCourse）和辅修课（ElectiveCourse）
声明一个Stundent类，包含name和score两个属性，让Course的Students包含的是Student的对象
主修课需要参加考试，所以有一个Exam(student)方法；辅修课只需要测评，所以有一个方法Assess(student)
class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
    }
    begin() {
        //JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
        var startDateRule = this.startDate.getFullYear() + '-' + this.startDate.getMonth() + '-' + this.startDate.getDate();
        console.log(this.name + "于" + startDateRule + "开课，共有" + this.students.length + "名同学(" + this.students + ")报名");
    }
    end() {
        console.log(this.endDate);
    }
}


class MajorCourse extends Course {
    constructor(name) {
        super(name);
       
    }
}

class ElectiveCourse extends Course {
    constructor(name) {
        super(name);

    }
}








var JavaScript = new Course("JavaScript", new Date(2019, 4, 5), new Date(2020, 1, 20), ['两开花', '王枫', '王平', '采玲', '老程']);
JavaScript.begin();
var SQL = new Course("SQL");



//Course.prototype.begin = function () {
//    console.log("飞哥真帅");
//};
JavaScript.__proto__.begin = function () {
    console.log("飞哥超级帅");
};
SQL.begin();





















