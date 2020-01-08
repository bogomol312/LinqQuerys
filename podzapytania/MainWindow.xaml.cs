using Cwiczenia6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Emp> Emps { get; set; }
        public List<Dept> Depts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            //Example();
        }

        public void LoadData()
        {
            Emps = new List<Emp>();
            Depts = new List<Dept>();

            Emps.Add(new Emp
            {
                Empno = 7369,
                Ename = "SMITH",
                Job = "CLERK",
                Mgr = 7902,
                HireDate = new DateTime(1980, 12, 17),
                Sal=800,
                Comm=0,
                Deptno=20
            });

            Emps.Add(new Emp
            {
                Empno = 7499,
                Ename = "ALLEN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 20),
                Sal = 1600,
                Comm = 300,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7521,
                Ename = "WARD",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 22),
                Sal = 1250,
                Comm = 500,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7566,
                Ename = "JONES",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 4, 2),
                Sal = 2975,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7654,
                Ename = "MARTIN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 28),
                Sal = 1250,
                Comm = 1400,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7698,
                Ename = "BLAKE",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 5, 1),
                Sal = 2850,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7782,
                Ename = "CLARK",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 6, 9),
                Sal = 2450,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7788,
                Ename = "SCOTT",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate = new DateTime(1982, 12, 9),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7839,
                Ename = "KING",
                Job = "PRESIDENT",
                Mgr = null,
                HireDate = new DateTime(1981, 11, 17),
                Sal = 5000,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7844,
                Ename = "TURNER",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 8),
                Sal = 1500,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7876,
                Ename = "ADAMS",
                Job = "CLERK",
                Mgr = 7788,
                HireDate = new DateTime(1983, 1, 12),
                Sal = 1100,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7900,
                Ename = "JAMES",
                Job = "CLERK",
                Mgr = 7698,
                HireDate = new DateTime(1981, 12, 3),
                Sal = 950,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7902,
                Ename = "FORD",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate= new DateTime(1981, 12, 3),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7934,
                Ename = "MILLER",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 1234,
                Ename = "Test",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 0

            });

            Depts.Add(new Dept
            {
                Deptno=10,
                Dname= "ACCOUNTING",
                Loc= "NEW YORK"
            });

            Depts.Add(new Dept
            {
                Deptno = 20,
                Dname = "RESEARCH",
                Loc = "DALLAS"
            });

            Depts.Add(new Dept
            {
                Deptno = 30,
                Dname = "SALES",
                Loc = "CHICAGO"
            });

            Depts.Add(new Dept
            {
                Deptno = 40,
                Dname = "OPERATIONS",
                Loc = "BOSTON"
            });
        }

        private void Example()
        {
            //Query syntax
            var result = from e in Emps
                         where e.Ename.StartsWith("K")
                         select e;

            //Lambda and Extension methods syntax
            var result2 = Emps.Where(e => e.Ename.StartsWith("K"));


            DataGrid.ItemsSource = result.ToList();
        }

        private void Zapytanie_Proste14()
        {
            var res = from emp in Emps  // jezeli chcemy kilka wartosci emp,sal
                      where emp.Sal >= 100 && emp.Sal <= 2000
                      select new
                      {
                          Ename = emp.Ename,
                          Sal = emp.Sal
                      };

            var res2 = Emps.Where(emp => emp.Sal >= 1000 && emp.Sal <= 2000);

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //1.	Znajdź pracowników z pensją równą minimalnemu zarobkowi w firmie.
            var result = Emps.Where(row => row.Sal == Emps.Min(row2 => row2.Sal));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            //2.	Znajdź wszystkich pracowników zatrudnionych na tym samym stanowisku co BLAKE.
            var res = Emps.Where(er => er.Ename == "BLAKE").Select(er => er.Job);

            string tmp = res.ToList()[0].ToString();
            Console.WriteLine(tmp);

            var ress = Emps.Where(k => k.Job == tmp).Select(k => k.Ename);

            DataGrid.ItemsSource = ress.ToList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            //3.	Znajdź pracowników o pensjach z listy najniższych zarobków osiągalnych w departamentach.
            //select ename from emp where sal = any ( select min(sal) from emp group by deptno);

            var res1 = Emps.GroupBy(r => r.Deptno).Select(r => new
            {
                Deptno = r.Key,
                Sal = r.Min(k => k.Sal)
            });

            var res2 = Emps.Where(k => res1.Select(l => l.Sal).Contains(k.Sal));

            DataGrid.ItemsSource = res2.ToList();       

        }
        
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //4.	Znajdź pracowników o najniższych zarobkach w ich departamentach.
            var res1 = Emps.GroupBy(r => r.Deptno).Select(r => new
            {
                Deptno = r.Key,
                Sal = r.Min(k => k.Sal)
            });

            var res2 = Emps.Where(k => res1.Select(l => l.Sal).Contains(k.Sal));

            DataGrid.ItemsSource = res2.ToList();

        }
        //wtf lenght
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            //5.	Stosując operator ANY wybierz pracowników zarabiających powyżej najniższego zarobku z departamentu 30.

            var res = Emps.Select(er => new
            {
                er.Ename,
                er.Sal,
                er.Deptno
            });

            List<string> resss = new List<string>();

            foreach (var k in res)
                if (res.Any(j => k.Sal > Emps.Where(d => d.Deptno == 30).Select(d => d.Sal).Min()))
                {
                    resss.Add(k.Ename);
                }
                else Console.WriteLine("false");
            
            DataGrid.ItemsSource = resss.ToList();

        }
       
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            //6.	Znajdź pracowników, których zarobki są wyższe od pensji każdego pracownika z departamentu 30.

            var prac = Emps.Where(r => r.Deptno == 30).Select(r => r.Sal);

            var kazdy = Emps.Select(kk => new
            {
                kk.Ename,
                kk.Sal
            });

            List<string> result = new List<string>();

            foreach (var k in kazdy)
                if (prac.All(p => p < k.Sal))
                    result.Add(k.Ename);
            
            DataGrid.ItemsSource = result.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            //7.	Wybierz departamenty, których średnie zarobki przekraczają średni zarobek departamentu 30.
            //select deptno from emp group by deptno having avg(sal) > (select avg(sal) from emp where deptno = 30) ;

            var avg = Emps.Where(d => d.Deptno == 30).Select(s => s.Sal).Average();

            var koks = Emps.GroupBy(d => d.Deptno).Select(d => new
            {
                Deptno = d.Key,
                Sal = d.Average(c => c.Sal)
            });

            var res = koks.Where(ll => ll.Sal > avg);

            DataGrid.ItemsSource = res.ToList();

        
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
//            8.Znajdź stanowisko, na którym są najwyższe średnie zarobki.

            var res = Emps.GroupBy(row => row.Job).Select(row => new
            {
                Job = row.Key,
                AvgSal = row.Average(c => c.Sal)
            });
            var maxRes = res.Select(row => row.AvgSal).Max();

            var result = res.Where(row => row.AvgSal == maxRes);
            DataGrid.ItemsSource = result;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz  wszystkie nazwy i numery departamentów większe od nr 20.
            var res = Depts.Where(row => row.Dname == "SALES").Select(row => row.Deptno);
            var res2 = Emps.Where(row => row.Deptno == res.ToList()[0]).Select(row => row.Sal).Max();
            var result = Emps.Where(row => row.Sal > res2);
            DataGrid.ItemsSource = result;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            //10.	Znajdź pracowników, którzy zarabiają powyżej średniej w ich departamentach

            var sr = Emps.GroupBy(d => d.Deptno).Select(s => new
            {
                Dept = s.Key,
                Sr = Emps.Average(dd => dd.Sal)
            });

            var prac = Emps.Where(k => k.Sal > sr.Where(row => row.Dept==k.Deptno).Select(s=>s.Sr).ToList()[0]);

            DataGrid.ItemsSource = prac.ToList();

        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            //11.	Znajdź pracowników, którzy posiadają podwładnych za pomocą operatora EXISTS.
            //            var res2 = res.Where(er => !Emps.Exists(emp => emp.Ename == er.Ename)).Select(er => er.EmpDept);

            var res = Emps.Where(r => Emps.Exists(emp => emp.Mgr == r.Mgr)).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();


        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            //12.	Znajdź pracowników, których departament nie występuje w tabeli DEPT.

            var res = Emps.Where(r => !Depts.Exists(dept => dept.Deptno == r.Deptno)).Select(s => new
            {
                s.Deptno,
                s.Ename
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            //13.	Wskaż dla każdego departamentu ostatnio zatrudnionych pracowników. Uporządkuj według dat zatrudnienia.

            //Podaj ename, sal i deptno dla pracowników, których zarobki przekraczają średnią ich departamentów.

            var res = Emps.GroupBy(row => row.Deptno).Select(row => new
            {
                Deptno = row.Key,
                HireDate = Emps.Where(row2 => row2.Deptno == row.Key).Select(row2 => row2.HireDate).Max(),
            });
            var result = Emps.Join(res, e1 => new { e1.Deptno, e1.HireDate }, e2 => new { e2.Deptno, e2.HireDate }, (e1, e2) => new
            {
                Deptno = e1.Deptno,
                Ename = e1.Ename,
                HireDate = e1.HireDate

            });
            DataGrid.ItemsSource = result;
        }
    }
}
