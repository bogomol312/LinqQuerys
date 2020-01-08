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
            //Połącz EMPNO i nazwisko, opatrz je nagłówkiem EMPLOYEE. 
            var res = from emp in Emps
                      select new
                      {
                          EMPLOYEE = emp.Ename + emp.Empno
                      };

            DataGrid.ItemsSource = res.ToList();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //Utwórz zapytanie zwracające wynik w postaci np. „Kowalski pracuje w dziale 20”.

            var res = from emp in Emps
                      select new
                      {
                          param = emp.Ename + " pracuje w dziale " + emp.Deptno
                       };

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            //Wylicz roczną pensję całkowitą dla każdego pracownika (z uwzględnieniem prowizji). 

            var res = Emps.GroupBy(emp => new
            {
                Imie = emp.Ename,
                salary = emp.Sal * 12 + emp.Comm
            });

            DataGrid.ItemsSource = res.ToList();       

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //Wyświetl wszystkie numery departamentów występujące w tabeli EMP
            var res = Emps.Select(emp => emp.Deptno);

            DataGrid.ItemsSource = res.ToList<int>();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            //  Wyświetl wszystkie różne numery departamentów występujące w tabeli EMP.

            var res = Emps.Select(emp => emp.Deptno);

            var ress = res.Distinct();

            DataGrid.ItemsSource = ress.ToList();

        }
       
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz wszystkie wzajemnie różne kombinacje wartości DEPTNO i JOB.

            var res = Emps.Select(emp => new { deptno = emp.Deptno, job = emp.Job }).Distinct();
            DataGrid.ItemsSource = res.ToList();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            //Posortuj malejąco wszystkie dane tabeli EMP według daty ich zatrudnienia począwszy od ostatnio zatrudnionych
            var res = Emps.Select(emp => emp);
            var ress = res.OrderByDescending(r => r.HireDate);

            DataGrid.ItemsSource = ress.ToList();

        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            //  Posortuj dane tabeli EMP według wzrastających wartości kolumn DEPTNO oraz malejących wartości kolumny SAL (bez wypisywania kolumny SAL). 

            var res = Emps.Select(emp => emp);
            var ress = res.OrderBy(r => r.Deptno).ThenByDescending(r => r.Sal); 

            DataGrid.ItemsSource = ress.Select(emp => new
            {
                Empno = emp.Empno,
                Ename = emp.Ename,
                Job = emp.Job,
                Mgr = emp.Mgr,
                HireDate = emp.HireDate,
                Comm = emp.Comm,
                Deptno = emp.Deptno
            });

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz  wszystkie nazwy i numery departamentów większe od nr 20.
            var res = Depts.Where(r => r.Deptno > 20).Select(r => r);

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz pracowników, których prowizja przekracza miesięczną pensję
            var res = Emps.Where(r => r.Comm > r.Sal).Select(r => new
            {
                Ename = r.Ename,
                Empno = r.Empno
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz dane tych pracowników, których zarobki mieszczą się pomiędzy 1000 a 2000. 

            var res = Emps.Where(r => r.Sal > 1000 && r.Sal < 2000).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz dane pracowników, których bezpośrednimi szefami  są 7902,7566 lub 7788.

            var res = Emps.Where(r => r.Mgr == 7902 || r.Mgr == 7566 || r.Mgr == 7788).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz dane tych pracowników, których nazwiska zaczynają się na S.

            var result2 = Emps.Where(r => r.Ename.StartsWith("S"));


            DataGrid.ItemsSource = result2.ToList();
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz dane tych pracowników, których nazwiska są czteroliterowe. 

            var res = Emps.Where(r => r.Ename.Length == 4);

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz dane tych pracowników, którzy nie posiadają szefa
            var res = Emps.Where(r => r.Mgr is null).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }
        
        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz dane tych pracowników, których zarobki są poza przedziałem<1000,2000 >.

            var res = Emps.Where(r => r.Sal<=1000 && r.Sal>=2000).Select(r => new 
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz dane tych pracowników, których nazwiska nie zaczynają się na M. 
            var result2 = Emps.Where(r => !r.Ename.StartsWith("M"));

            DataGrid.ItemsSource = result2.ToList();

        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz dane tych pracowników, którzy mają szefa.
            var res = Emps.Where(r => (r.Mgr != null)).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz dane tych pracowników zatrudnionych na stanowisku CLERK których zarobki SAL mieszczą się w przedziale < 1000.2000). 

            var res = Emps.Where(r => r.Job == "CLERK" && (r.Sal >= 1000 && r.Sal <= 2000)).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Job = r.Job,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList(); 
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz dane pracowników zatrudnionych na stanowisku CLERK albo takich, których zarobki SAL mieszczą się w przedziale <1000.2000). 

            var res = Emps.Where(r => r.Job == "CLERK" || (r.Sal >= 1000 && r.Sal <= 2000)).Select(r => new
            {
                r.Empno,
                Nazw=r.Ename,
                Mgr = r.Mgr,
                Job = r.Job,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz wszystkich pracowników zatrudnionych na stanowisku MANAGER z pensją powyżej 1500 
            //oraz wszystkich pracowników na stanowisku  SALESMAN, niezależnie od pensji.

            var res = Emps.Where(r => (r.Job == "MANAGER" && r.Sal > 1500) || r.Job =="SALESMAN").Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Job = r.Job,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz wszystkich pracowników zatrudnionych na stanowisku MANAGER lub na stanowisku SALESMAN lecz zarabiających powyżej 1500. 
            var res = Emps.Where(r => (r.Job=="MANAGER" || r.Job=="SALESMAN")&& r.Sal > 1500).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Job = r.Job,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz wszystkich pracowników zatrudnionych na stanowisku MANAGER ze wszystkich departamentów wraz ze 
            //wszystkimi pracownikami zatrudnionymi na stanowisku CLERK w departamencie 10

            var res = Emps.Where(r => r.Job=="MANAGER" || (r.Job=="CLERK" && r.Deptno == 10)).Select(r => new
            {
                Empno = r.Empno,
                Ename = r.Ename,
                Mgr = r.Mgr,
                Job = r.Job,
                Deptno = r.Deptno,
                Sal = r.Sal
            });

            DataGrid.ItemsSource = res.ToList();
        }
    }
}
