using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shlock_A.Models
{
    public class Student_grade
    {
        [Key]
        [Display(Name = "成绩序号")]
        [Required(ErrorMessage = "【成绩序号】不能为空白")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "请输入 4 到 50 字符以内的【成绩序号】。")]
        [RegularExpression(@"^[a-zA-Z\w]{4,50}$", ErrorMessage = "请输入由【字母或数字】组成的成绩序号。")]
        [DataType(DataType.Text)]
        public string Student_gradeID { get; set; }

        [Display(Name = "学生学号")]
        [Required(ErrorMessage = "【学生学号】不能为空白")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "请输入 4 到 50 字符以内的【学生学号】。")]
        [RegularExpression(@"^[a-zA-Z\w]{4,50}$", ErrorMessage = "请输入由【字母或数字】组成的学生学号。")]
        [DataType(DataType.Text)]
        public string Student_ID { get; set; }

        [Display(Name = "学生姓名")]
        [Required(ErrorMessage = "【学生姓名】不能为空白")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "请输入 50 字以内的【学生姓名】。")]
        [RegularExpression(@"^[\u4e00-\u9fa5\a-zA-Z0-9.-]*$", ErrorMessage = "请输入由【中文、字母、数字或 - 、或 .】组成的学生姓名。")]
        [DataType(DataType.Text)]
        public string Student_Name { get; set; }

        [Display(Name = "学生性别")]
        [Required(ErrorMessage = "【学生性别】不能为空白")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "请输入 2 字以内的【学生性别】。")]
        [RegularExpression(@"^[\u4e00-\u9fa5\a-zA-Z0-9.-]*$", ErrorMessage = "请输入由【中文、字母、数字或 - 、或 .】表示学生性别。")]
        [DataType(DataType.Text)]
        public string Student_Sex { get; set; }

        [Display(Name = "课程名称")]
        [Required(ErrorMessage = "【课程名称】不能为空白")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "请输入 50 字以内的【课程名称】。")]
        [RegularExpression(@"^[\u4e00-\u9fa5\a-zA-Z0-9.-]*$", ErrorMessage = "请输入由【中文、字母、数字或-、或·】表示课程名称。")]
        [DataType(DataType.Text)]
        public string Courses_Name { get; set; }

        [Display(Name = "课程成绩")]
        [Required(ErrorMessage = "【课程成绩】不能为空白")]
        [RegularExpression(@"^[0-9.-]*$", ErrorMessage = "请输入由【数字】表示课程成绩。")]
        [DataType(DataType.Text)]
        public Single Courses_Grad { get; set; }
    }
}