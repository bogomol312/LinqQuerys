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
            Example();
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // Oblicz średni zarobek w firmie.

            var res = Emps.Select(r => r.Sal).Average();

            Console.WriteLine("AVERAGE : " + res + " <-------------------------------");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // Znajdź minimalne zarobki na stanowisku CLERK.

            var res = Emps.Where(p => p.Job == "CLERK").Select(p => p.Sal);

            DataGrid.ItemsSource = res.ToList();

            var min = res.Min();

            Console.WriteLine("MINIMAL : " + min + " <-------------------------------");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            // Znajdź ilu pracowników zatrudniono w departamencie 20.

            var res = Emps.Where(p => p.Deptno == 20).Select(p => p.Empno);

            DataGrid.ItemsSource = res.ToList();

            var COUNT = res.Count();

            Console.WriteLine("COUNT : " + COUNT + " <-------------------------------");
        }
        
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            // Oblicz średnie zarobki na każdym ze stanowisk pracy

            var jobs = Emps.GroupBy(g => g.Job).Select(group => new
            {
                Job=group.Key,
                SrednieZarobki=group.Average(ee => ee.Sal)
            });

            DataGrid.ItemsSource = jobs.ToList();

        }
        
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            // Oblicz średnie zarobki na każdym ze stanowisk pracy z wyjątkiem stanowiska MANAGER

            var jobs = Emps.Where(r => r.Job != "MANAGER").Select(r => new
            {
                 r.Job,
                 r.Sal
            }).OrderBy(r => r.Job).Average(r => r.Sal);

            DataGrid.ItemsSource = jobs.ToString();

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            // Oblicz średnie zarobki na każdym ze stanowisk pracy w każdym departamencie. 

            var res = Emps.GroupBy(r => new { r.Deptno, r.Job }).Select(r => new
            {
                DeptJob=r.Key,
                Sal = r.Average(ee => ee.Sal)
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            // Dla każdego stanowiska oblicz maksymalne zarobki. 

            var res = Emps.GroupBy(g => g.Job).Select(r => new
            {
                Job = r.Key,
                Sal = r.Max(ee => ee.Sal)
            });

            DataGrid.ItemsSource = res.ToList();
        }
        //?
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            //?rozne wyniki
            // Wybierz średnie zarobki tylko tych departamentów, które zatrudniają więcej niż trzech pracowników. 
            //select AVG(sal) from emp,dept where EMP.DEPTNO=dept.DEPTNO group by emp.DEPTNO having count(*) > 3; 

            var res = Emps.GroupBy(r => r.Deptno).
                      Where(r => r.Count() > 3)
                      .Select(r => new
                      {
                          Srednie = r.Average(ee => ee.Sal)
                      });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz tylko te stanowiska, na których średni zarobek wynosi 3000 lub więcej. 
            //select job,sal from emp where sal>=(select avg(sal) from emp) ;

            var res = Emps.Where(r => r.Sal >= Emps.Select(jj => jj.Sal).Average()).Select(t => t.Job);

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            //  Znajdź średnie miesięczne pensje oraz średnie roczne zarobki dla każdego stanowiska, pamiętaj o prowizji.
            //select avg(sal+comm),avg(sal*12+comm) from emp group by job;

            var res = Emps.GroupBy(r => r.Job).Select(r => new
            {
                Job = r.Key,
                Misieczne = r.Average(ee => ee.Sal + ee.Comm),
                Rokowe = r.Average(eer => eer.Sal * 12 + eer.Comm)
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            //  Znajdź różnicę miedzy najwyższą i najniższa pensją. 

            var resmax = Emps.Max(ee => ee.Sal);
            var resmin = Emps.Min(ee => ee.Sal);
            var roz = resmax - resmin;

            Console.WriteLine("11 :" + roz + " <----------------------------------------------------------------");
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            //  Znajdź departamenty zatrudniające powyżej trzech pracowników. 
            //select deptno from emp group by emp.DEPTNO having count(*) > 3;

            var res = Emps.GroupBy(r => r.Deptno).Where(r => r.Count() > 3).Select(r => r.Key);

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            //  Sprawdź, czy wszystkie numery pracowników są rzeczywiście wzajemnie różne
            //  select empno from emp group by empno having count(*)> 1;

            var res = Emps.GroupBy(r => r.Empno).Where(r => r.Count() > 1).Select(r => r.Key);
            //jezeli sa recordy - wiec jest powtorzenie 
            DataGrid.ItemsSource = res.ToList();
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            //  Sprawdź, czy wszystkie numery pracowników są rzeczywiście wzajemnie różne
            //  select empno from emp group by empno having count(*)> 1;

            var res = Emps.GroupBy(r => r.Empno).Where(r => r.Count() > 1).Select(r => r.Key);
            //jezeli sa recordy - wiec jest powtorzenie 
            DataGrid.ItemsSource = res.ToList();
        }
    }
}
