---
title: ABOUT PAGE
layout: template
filename: Ontap.md
--- 
#hk1 22-23 (12/11/2022)
câu 1:[3đ]: viết hàm nhận vào 3 tham số ngày tháng năm cho biết đó là ngày thứ mấy trong tuần.
*write a function that takes in 3 arguments the date of the year indicating what day of the week it is.*
***Hướng làm: nếu không sử dụng các hàm trong thư viện có sẵn (vd: hàm Datetime,..) 
có thể sử dụng công thức Zeller's Congruence***
**bài làm:** 
'''cs
using System;
public struct ThuNgay
{
  public int Ngay;
  public int Thang;
  public int Nam;
  
public class Program 
{
  public static void Main(string[] args)
  {
    ThuNgay thuNgay = new ThuNgay { 
    int 
    Console.WriteLine(
  }
  
  public static int TimThuNgay(
}
}
'''
câu 2:4đ: viết hàm đếm số lần xuất hiện của phần tử nhỏ nhất trong mảng 1 chiều các số nguyên. 
vd: A:{1,2,10,3,1,9,1} -> số nhỏ nhất là 1 và xuất hiện 3 lần
câu 3:3đ: viết hàm tính trung bình cộng các số nguyên tố trong ma trận có các số nguyên. 
(số nguyên tố là số chỉ chia hết cho 1 và chính nó)
