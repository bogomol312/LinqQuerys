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
        //    Example();
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
                Sal = 800,
                Comm = 0,
                Deptno = 20
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
                HireDate = new DateTime(1981, 12, 3),
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
                Deptno = 10,
                Dname = "ACCOUNTING",
                Loc = "NEW YORK"
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
            //Połącz dane z tabel EMP i DEPT przy pomocy INNER JOIN. 
            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          DeptnoFromEMP = emp.Deptno,
                          DepartmantFromDepts = dept.Dname
                      };

            var ress = res.Distinct();

            DataGrid.ItemsSource = ress.ToList();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz nazwiska oraz nazwy departamentów  wszystkich pracowników w kolejności alfabetycznej. 

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Ename = emp.Ename,
                          Deptno = dept.Dname
                      };

            var ress = res.OrderBy(r => r.Deptno).ThenBy(r => r.Ename);


            DataGrid.ItemsSource = ress.ToList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz nazwiska wszystkich pracowników wraz z numerami i nazwami departamentów w których są zatrudnieni.

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Ename = emp.Ename,
                          Deptno = dept.Deptno,
                          DName = dept.Dname
                      };

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            // Dla pracowników o miesięcznej pensji  powyżej 1500 podaj ich nazwiska, miejsca usytuowania ich departamentów oraz nazwy tych departamentów.

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Ename = emp.Ename,
                          Sal = emp.Sal,
                          DName = dept.Dname,
                          Place = dept.Loc
                      };

            var ress = res.Where(r => r.Sal > 1500);

            DataGrid.ItemsSource = ress.ToList();
        }
       
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            // Utwórz listę pracowników podając ich nazwisko, zawód, pensję i ****stopień zaszeregowania****

            var res = Emps.Select(r => new
            {
                Ename = r.Ename,
                Job = r.Job,
                Sal = r.Sal
                //stopien zaszeregowania??
            });

            DataGrid.ItemsSource = res.ToList();
        }
    
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz informacje o pracownikach, których zarobki odpowiadają klasie zarobkowej 3. 

            // co to jest klasa zarobkowa?
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz pracowników zatrudnionych w Dallas. 

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Ename = emp.Ename,
                          Sal = emp.Sal,
                          DName = dept.Dname,
                          Place = dept.Loc
                      };

            var ress = res.Where(r => r.Place == "DALLAS").Select(r => new
            {
                Name = r.Ename,
                Dept = r.Place
            });

            DataGrid.ItemsSource = ress.ToList();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            // Wybierz nazwiska pracowników, nazwy działów i **stopnie zaszeregowania** 

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Ename = emp.Ename,
                          DName = dept.Dname,
                          Place = dept.Loc
                      };

            DataGrid.ItemsSource = res.ToList();
        }

        //? - UNION 
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            // Wypisz dane wszystkich działów oraz ich pracowników tak, aby dane działu pojawiły się,
            //nawet jeśli nie ma w dziale żadnego pracownika.  

            var res = from emp in Emps
                      join d in Depts 
                      on emp.Deptno equals d.Deptno 
                      select new
                      {
                          Ename = emp.Ename,
                          EmpDept = emp.Deptno,
                      };
            // var res = r.Where(ee => !Emps.Exists(emp => emp.Deptno == 30 && emp.Job == ee));
            var res2 = res.Where(er => !Emps.Exists(emp => emp.Ename == er.Ename)).Select(er => er.EmpDept);

           // DataGrid.ItemsSource = res.Union(res2).ToList();
        }

        //? - union
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            //Wypisz dane wszystkich działów oraz ich pracowników tak, aby dane pracownika pojawiły się
            //, nawet jeśli pracownik nie jest przypisany do działu.  

             var res = from emp in Emps 
                       join d in Depts on emp.Deptno equals d.Deptno
                       select new
                       {
                           Ename = emp.Ename,
                           EmpDept = emp.Deptno
                       };

             DataGrid.ItemsSource = res.ToList();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz pracowników(nazwisko, numer działu) z działu 30 i 20.Wypisz dział 20 bez nazwisk.

            var result1 = Emps.Join(Depts, Emps => Emps.Deptno, Depts => Depts.Deptno, (Emps, Depts) => new
            {
                Deptno = Depts.Deptno,
                Ename = Emps.Ename
            }).Where(row => row.Deptno == 30);
            var result2 = Emps.Join(Depts, Emps => Emps.Deptno, Depts => Depts.Deptno, (Emps, Depts) => new
            {
                Deptno = Depts.Deptno,
                Ename = "",
            }).Where(row => row.Deptno == 20);

            DataGrid.ItemsSource = result1.Concat(result2).ToList();

        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            //Wypisz stanowiska występujące w dziale 10 oraz 30..
            //wszystko dpet 30 oraz dept 10 + intersect(po zawodach)

            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Job = emp.Job,
                          Dept = dept.Deptno,
                          Place = dept.Loc
                      };

            var ress = res.Where(p => p.Dept == 10 && p.Dept == 30).Select(p => new
            {
                Job = p.Job,
                Dept = p.Dept
            });

            DataGrid.ItemsSource = ress.Distinct().ToList();
        }
      
        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            //Wypisz stanowiska występujące w dziale 10 oraz 30..


            var res = from emp in Emps
                      join dept in Depts
                      on emp.Deptno equals dept.Deptno
                      select new
                      {
                          Job = emp.Job,
                          Dept = dept.Deptno,
                          Place = dept.Loc
                      };

            var ress = res.Where(p => p.Dept == 10 || p.Dept == 30).Select(p => new
            {
                Job = p.Job,
                Dept = p.Dept
            });

            DataGrid.ItemsSource = ress.Distinct().ToList();
        }
        
        private void Button14_Click(object sender, RoutedEventArgs e) {
            // Wypisz stanowiska występujące w dziale 10 a nie występujące w dziale 30.
            //najpierw wszystko z 10 
           
            var r = from emp in Emps
                    where emp.Deptno == 10
                    select emp.Job;

            var res = r.Where(ee => !Emps.Exists(emp => emp.Deptno == 30 && emp.Job == ee));
       
            DataGrid.ItemsSource = res.ToList();
        }
     
        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            //Wybierz pracowników, którzy zarabiają mniej od swoich kierowników. 
            var res = from emp in Emps
                      join mgr in Emps
                      on emp.Mgr equals mgr.Mgr
                      where emp.Sal<mgr.Sal
                      select new
                      {
                          Prac = emp.Ename,
                          PracSal = emp.Sal,
                          Szef = mgr.Ename,
                          SzefSal = mgr.Sal
                      };

            DataGrid.ItemsSource = res.ToList();
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            //  Dla każdego pracownika wypisz jego nazwisko oraz nazwisko jego szefa. Posortuj według nazwiska szefa. 

            var res = from emp in Emps
                      join mgr in Emps
                      on emp.Mgr equals mgr.Mgr
                      select new
                      {
                          Prac = emp.Ename,
                          Szef = mgr.Ename
                      };

            DataGrid.ItemsSource = res.OrderBy(k => k.Szef).ToList();
        }

    }
}
