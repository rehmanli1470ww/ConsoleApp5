using ConsoleApp5.Context;
using ConsoleApp5.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {

        Debtor_Db debtor_Db = new Debtor_Db();

        //2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
        //var tap = debtor_Db.Debtors.Where(d => d.Email.Contains("rhyta.com") || d.Email.Contains("dayrep.com")).ToList();
        //foreach (var item in tap)
        //{
        //    Console.WriteLine(item);
        //}


        //3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag

        //var tarix = DateTime.Now.Year;
        //var Birtdate = debtor_Db.Debtors.Where(d => (tarix-d.BirthDay.Year) > 26 && (tarix - d.BirthDay.Year) < 36);
        //foreach (var item in Birtdate)
        //{
        //    Console.WriteLine(item);
        //}


        //4) Borcu 5000 - den cox olmayan borclularic cixartmag
        //var Borclu = debtor_Db.Debtors.Where(d => d.Debt > 5000);
        //foreach (var item in Borclu)
        //{
        //    Console.WriteLine(item);
        //}



        //5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq
        //var sayi = debtor_Db.Debtors.ToList().Where(d => d.FullName.Length > 18 && d.Phone.Count(c=>c=='7') > 2);
        //foreach (var item in sayi)
        //{
        //    Console.WriteLine(item);
        //}



        //7) Qishda anadan olan borclulari cixardmaq
        //var Qisda = debtor_Db.Debtors.Where(d => d.BirthDay.Month == 12|| d.BirthDay.Month == 1|| d.BirthDay.Month == 2);
        //foreach (var item in Qisda)
        //{
        //    Console.WriteLine(item);
        //}


        //8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
        //var BorcOrtalama=debtor_Db.Debtors.Average(x => x.Debt);
        //var OrtaBorc = debtor_Db.Debtors.
        //    Where(d => d.Debt > BorcOrtalama).
        //    OrderBy(d=> d.FullName).
        //    OrderByDescending(d=>d.Debt);
        //
        //foreach (var item in OrtaBorc)
        //{
        //    Console.WriteLine(item);
        //}





        //9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
        //var Nomre8 = debtor_Db.Debtors.Where(d => !d.Phone.Contains("8"));
        //foreach (var item in Nomre8)
        //{
        //    Console.WriteLine(item);
        //}


        //11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
        //var saxla=debtor_Db.Debtors.ToList().Where(d=>d.FullName.GroupBy(d=>d.ToString()).Any(s=>s.Count()==3));
        //foreach (var item in saxla)
        //{
        //    Console.WriteLine(item);
        //}




        //13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq
        //var saxla = debtor_Db.Debtors.GroupBy(d => d.BirthDay.Year).Select(d => new
        //{
        //    BirthDate=d.Key,
        //    Count=d.Count()
        //}).OrderByDescending(d=>d.Count).FirstOrDefault();




        //var saxla = debtor_Db.Debtors.GroupBy(d => d.BirthDay).OrderBy(a=>a.ToString()).OrderByDescending(a=>a.ToString());

        //foreach (var item in saxla)
        //{
        //    Console.WriteLine(item);
        //}



        //14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
        //var BorcMax=debtor_Db.Debtors.OrderBy(a=>a.Debt).OrderByDescending(a=>a.Debt).Take(5);
        //foreach (var item in BorcMax)
        //{
        //    Console.WriteLine(item);
        //}




        //15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq
        //var SumDebt = debtor_Db.Debtors.Sum(d => d.Debt);
        //Console.WriteLine(SumDebt);



        //16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
        //var saxla = DateTime.Now.Year;
        //var IkinciDunyaMuharibesi = debtor_Db.Debtors.Where(d => (saxla -39 )< d.BirthDay.Year && (saxla - 45) > d.BirthDay.Year);
        //foreach (var item in IkinciDunyaMuharibesi)
        //{
        //    Console.WriteLine(item);
        //}


        //18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

        //var Tekrar = debtor_Db.Debtors.ToList().Where(a => a.Phone.GroupBy(a => a.ToString()).Any(a => a.Count() < 2));
        //foreach (var item in Tekrar)
        //{
        //    Console.WriteLine(item);
        //}




        //19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq

        //var Borclu = debtor_Db.Debtors.Where(d => d.Debt - (d.BirthDay.Month > DateTime.Now.Month ? d.BirthDay.Month - DateTime.Now.Month: DateTime.Now.Month- d.BirthDay.Month) * 500 <= 0);
        //foreach (var item in Borclu)
        //{
        //    Console.WriteLine(item);
        //}


        //20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq

        //var Smile = debtor_Db.Debtors.Where(a => a.FullName.Contains("s")&& a.FullName.Contains("m") && a.FullName.Contains("i") && a.FullName.Contains("l") && a.FullName.Contains("e"));
        //foreach (var item in Smile)
        //{
        //    Console.WriteLine(item);
        //}
    }
}



