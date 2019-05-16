using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shlock_A.Models
{
    public class Student_Information
    {
        [Key]
        [Display(Name = "学生学号")]
        [Required(ErrorMessage = "【学生学号】不能为空白")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "请输入 4 到 50 字符以内的【学生学号】。")]
        //[RegularExpression(@"^[\w\u4e00-\u9fa5\s]*$", ErrorMessage = "请输入仅由字母和数字组成的产品名称。")]
        [RegularExpression(@"^[a-zA-Z\w]{4,50}$", ErrorMessage = "请输入由【字母或数字】组成的学生学号。")]
        [DataType(DataType.Text)]
        public string Xueshengxuehao { get; set; }


        [Display(Name = "学生姓名")]
        [Required(ErrorMessage = "【学生姓名】不能为空白")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "请输入 50 字以内的【学生姓名】。")]
        //[RegularExpression(@"^[\w\u4e00-\u9fa5\s]*$", ErrorMessage = "请输入仅由字母和数字组成的产品名称。")]
        [RegularExpression(@"^[\u4e00-\u9fa5\a-zA-Z0-9.-]*$", ErrorMessage = "请输入由【中文、字母、数字或 - 、或 .】组成的学生姓名。")]
        [DataType(DataType.Text)]
        public string Xueshengxingming { get; set; }

        [Display(Name = "学生性别")]
        [Required(ErrorMessage = "【学生性别】不能为空白")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "请输入 2 字以内的【学生性别】。")]
        //[RegularExpression(@"^[\w\u4e00-\u9fa5\s]*$", ErrorMessage = "请输入仅由字母和数字组成的产品名称。")]
        [RegularExpression(@"^[\u4e00-\u9fa5\a-zA-Z0-9]*$", ErrorMessage = "请输入由【中文、字母或数字】表示学生性别。")]
        [DataType(DataType.Text)]
        public string Xueshengxingbie { get; set; }
    }
}