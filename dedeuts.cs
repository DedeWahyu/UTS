using System;
namespace UTS
{
  public class Dosen
  {

    public int id {get;set;}
    public string nama {get;set;}
    public int Nik {get;set;}
    public string gender {get;set;}
    public string course {get;set;}

    public void dosen()
    {
      Console.WriteLine("Dosen pengampu ujian : {0}",nama);
      Console.WriteLine("Mata kuliah : {0}",course);
      Console.WriteLine("Tahun ajaran : {0}",id);
      Console.WriteLine("Jenis kelamin : {0}",gender);
    }
    public static void attdosen(string name,int nik)
    {
      Console.WriteLine("Nama dosen : {0}",name);
      Console.WriteLine("NIK : {0}",nik);
    }
    public static void addcourse(string course)
    {
      Console.WriteLine("Mata kuliah : {0}",course);
    }
  }
  class program
  {
    static void Main(string[] args)
    {
      string nama,course;
      int nik;

      Dosen awal = new Dosen();
      awal.nama = "Kamarudin, M.Kom";
      awal.course = "Pemrograman";
      awal.id = 2021;
      awal.gender = "Laki-laki";
      awal.dosen();
      Console.WriteLine();

      Console.Write("Inputkan nama dosen : ");
      nama = Console.ReadLine();
      Console.Write("Inputkan NIK dosen : ");
      nik = Convert.ToInt32(Console.ReadLine());
      Console.Write("Inputkan mata kuliah dosen : ");
      course = Console.ReadLine();
      Console.WriteLine();

      Console.WriteLine("Data dosen yang sudah diinputkan !");
      Console.WriteLine();
      Dosen.attdosen(nama,nik);
      Dosen.addcourse(course);

      Console.ReadKey();
    }
  }
}
