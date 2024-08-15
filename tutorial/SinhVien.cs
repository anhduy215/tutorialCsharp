using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
public class SinhVien
{
    // khai báo các thuộc tính và các phương thức get set để tương tác
    public string ten { get; set; }
    public int tuoi { get; set; }
    public float diemToan { get; set; }
    public float diemLy { get; set; }
    public float diemVan { get; set; }

    //cstructor trống để tạo đối tượng không thông tin
    public SinhVien()
    {
    }
    //tạo đối tượng với các thông tin cần thiết
    public SinhVien(string ten, int tuoi, float diemToan, float diemLy, float diemVan)
    {
        this.ten = ten;
        this.tuoi = tuoi;
        this.diemToan = diemToan;
        this.diemLy = diemLy;
        this.diemVan = diemVan;
    }

    public override string? ToString()
    {
        return $"ten: {ten}|tuoi: {tuoi}|toan: {diemToan:F1}|ly: {diemLy:F1}|van: {diemVan:F1}";
    }
}
