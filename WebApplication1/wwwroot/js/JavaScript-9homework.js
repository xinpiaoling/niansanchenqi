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
        console.log(this.name+"于"+new Date+"开课，共有"+this.students.length+"名同学"+this.students+"报名");
    }
    end() {
        console.log(this.endDate);
    }
}

var JavaScript = new Course("JavaScript", new Date(2019,5,5),new Date(2020,1,20),"['两开花','王枫','王平','采玲','老程']");
JavaScript.begin();
var SQL = new Course("SQL");
SQL.end();



//2.生成两个课程对象：JavaScript和SQL













//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。







//4.不修改class，动态的改变begin()方法，使其能影响所有Course对象









//5.让end()方法为各自对象“自有”，其他对象无法修改











//6.在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天













//7.判断并证明以下说法：
//ES里的class其实就是一个function

