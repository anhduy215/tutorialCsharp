using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Function
{
    List<SinhVien> arrSinhVien = new List<SinhVien>();//list để chứa các đối tượng thuộc class sinhvien

    //constructor tự động thực thi việc add sinh vien list
    public Function()
    {
        arrSinhVien.Add(new SinhVien("Duy", 23, 7.5f, 8f, 9f));
        arrSinhVien.Add(new SinhVien("Vũ", 24, 10f, 8.5f, 9.5f));
        arrSinhVien.Add(new SinhVien("Khoa", 19, 8.5f, 7f, 3f));
        arrSinhVien.Add(new SinhVien("Bảo", 20, 6.5f, 5f, 6f));
    }
    //tutorial hàm show sinh viên ra màn hình có dùng vòng lặp for
    public void showList()
    {
        //var để biên dịch tự động thành kiểu dữ liệu đối tượng sinhvien trong list
        foreach (var item in arrSinhVien)
        {
            Console.WriteLine(item.ToString());
        }
    }
    //tutorial collection và foreach
    public void showByAge()
    {
        // sắp xếp theo tuổi và lưu vào ds tạm
        List<SinhVien> tmp = arrSinhVien
            .OrderByDescending(sv => sv.tuoi)
            .ToList();

        // in ds tạm
        foreach (var item in tmp)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
