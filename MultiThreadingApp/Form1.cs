using Microsoft.Data.SqlClient;
using MultiThreadingApp.Models;
using System.Reflection;
using System.Security.Cryptography;

namespace MultiThreadingApp
{
    public partial class Form1 : Form
    {

        MTApp_Context _context;
        Thread th1;
        Thread th2;
        private readonly object databaseLock = new object();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public Form1()
        {
            _context = new MTApp_Context();
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            StartApp(Convert.ToInt32(nmrFirstValue.Value));
            th1 = new Thread(MethodForTh1);
            th2 = new Thread(MethodForTh2);
            th1.Start();
            th2.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            th1 = null;
            th2 = null;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource = new CancellationTokenSource();
            th1 = new Thread(MethodForTh1);
            th2 = new Thread(MethodForTh2);
            th1.Start();
            th2.Start();
        }
        private void MethodForTh1()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {

                lock (databaseLock)
                {
                    int currentDatabaseNumber = _context.Datas.FirstOrDefault().Number;
                    currentDatabaseNumber += 1;
                    var entity = _context.Datas.FirstOrDefault();
                    entity.Number = currentDatabaseNumber;
                    entity.ModifiedDate = DateTime.Now;
                    _context.SaveChanges();

                    listView1.Items.Add($"Thread1:    Number = {currentDatabaseNumber}       Date = {entity.ModifiedDate}");
                    Thread.Sleep(1000);
                }

            }
        }

        private void MethodForTh2()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {

                lock (databaseLock)
                {
                    int currentDatabaseNumber = _context.Datas.FirstOrDefault().Number;
                    currentDatabaseNumber += 1;
                    var entity = _context.Datas.FirstOrDefault();
                    entity.Number = currentDatabaseNumber;
                    entity.ModifiedDate = DateTime.Now;
                    _context.SaveChanges();

                    listView1.Items.Add($"Thread2:    Number = {currentDatabaseNumber}       Date = {entity.ModifiedDate}");
                    Thread.Sleep(1000);
                }
            }

        }

        private void StartApp(int newNumber)
        {
            lock (databaseLock)
            {
                var entityToUpdate = _context.Datas.FirstOrDefault();

                entityToUpdate.Number = newNumber;
                _context.SaveChanges();
                nmrFirstValue.Value = 0;
            }


        }


    }
}
