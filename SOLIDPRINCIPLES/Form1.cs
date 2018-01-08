using SOLIDPRINCIPLES.DIP.BadPractice;
using SOLIDPRINCIPLES.DIP.BestPractice;
using SOLIDPRINCIPLES.ISP.BadPractice;
using SOLIDPRINCIPLES.ISP.BestPractice;
using SOLIDPRINCIPLES.LSP.BadPractice;
using SOLIDPRINCIPLES.LSP.BestPractice;
using SOLIDPRINCIPLES.OCP.BestPractice;
using SOLIDPRINCIPLES.SRP.BadPractice;
using SOLIDPRINCIPLES.SRP.BestPractice.Manager;
using SOLIDPRINCIPLES.SRP.BestPractice.Models;
using SOLIDPRINCIPLES.SRP.BestPractice.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDPRINCIPLES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object EmployeManager { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region SRP

            Employee emp = new Employee();
            emp.FirstName = "Ali";
            emp.AddToDB(emp);

            _Employee emp1 = new _Employee();
            emp1.FirstName = "Deneme";

            EmployeeManager manager = new EmployeeManager(emp1);
            manager.Insert();

            EmployeeManager manager2 = new EmployeeManager(new MessageService(), emp1);
            manager2.SendMessage("Test");

            #endregion

            #region OCP

            OCPClient manager1 = new OCPClient(new NormalTicket());
            manager1.Sale(100);

            OCPClient manager3 = new OCPClient(new StudentTicket());
            manager3.Sale(100);

            #endregion

            #region LSP

            #region BadPractice

            Shape s = new Square(5, 10);
            double d1 = s.GetArea();

            Shape s1 = new Rect(3, 5);
            double d2 = s1.GetArea();


            #endregion

            #region BestPractice


            AbstractShape s3 = new _Square(3);
            s3.GetArea();

            AbstractShape s4 = new _Rect(3, 5);
            s4.GetArea();

            AbstractShape s5 = new _Circle(5);

            MessageBox.Show(s5.Diagonal.ToString());


            #endregion

            #endregion

            //Interface Segregation Principle
            #region ISP

            #region BadPractice

            JuniorDeveloper j = new JuniorDeveloper();
            j.UseSolid();

            SeniorDeveloper ss = new SeniorDeveloper();
            ss.UseSolid();

            #endregion

            #region BestPractice

            JDeveloper j1 = new JDeveloper();
            j1.UseOOP();
           

            SDeveloper s3 = new SDeveloper();
            s3.UseOOP();
            s3.UseSolid();


            #endregion

            #endregion

            #region DIP

            #region BadPractice

            IOService service = new IOService(new DBIO());
            service.Write("asdasda", "asddsa");

            #endregion

            //read işlemleri için

            _IOService _service = new _IOService(new _ExcelIO());
            _service.Read("asdsad","ssadasd");
            _service.Write("adsdas","asdasd");

            _IOService _service2 = new _IOService(new _TextIO());
            _service2.Read("asdasd", "asdasd");
            _service2.Write("asdasd", "asdsad");

            _IOService _service3 = new _IOService(new _DBIO());
            _service3.Read("sadasd","asdasd");

 


            #endregion


        }
    }
}
