using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shlock_A.Models
{
    public class MyDBInit
         : System.Data.Entity.CreateDatabaseIfNotExists<MyDB>
    {
        protected override void Seed(MyDB context)

        {
            base.Seed(context);

            context.Student_Information.Add(new Student_Information
            {
                Xueshengxuehao = "20180001",
                Xueshengxingming = "张三",
                Xueshengxingbie = "男"

            });
            context.Student_Information.Add(new Student_Information
            {
                Xueshengxuehao = "20180002",
                Xueshengxingming = "李四",
                Xueshengxingbie = "女"
            });

            context.Student_grade.Add(new Student_grade
            {
                Student_gradeID = "123456789",
                Student_ID = "20180001",
                Student_Name = "张三",
                Student_Sex = "男",
                Courses_Name = "性健康教育",
                Courses_Grad = 100

            });
            context.Student_grade.Add(new Student_grade
            {
                Student_gradeID = "987654321",
                Student_ID = "20180002",
                Student_Name = "李四",
                Student_Sex = "女",
                Courses_Name = ".NTE",
                Courses_Grad = 60
            });
        }
    }
}