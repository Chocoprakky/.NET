using System;
using System.Data;
using System.Data.SqlClient;

class DeleteAcc{
public static void Main(){
SqlConnection scon;
SqlCommand scmd;
int no;

Console.WriteLine("Enter the Account Number");
no=Convert.ToInt32(Console.ReadLine());
scon=new SqlConnection("server=PrachiMishra\\sqlexpress;uid=sa;pwd=microsoft;database=prachidb");
scmd= new SqlCommand("delete from accounts where accno=@a",scon);

scon.Open();

scmd.Parameters.AddWithValue("a",no);
 int cnt = scmd.ExecuteNonQuery();

if(cnt > 0)
Console.WriteLine("Account deleted successfully");
else
Console.WriteLine("Account does'nt exist");

scmd.Dispose();
scon.Close();



}
}