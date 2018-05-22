using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stadium2.Model;
namespace Stadium2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDgv();
            CmbFill();
        }
        StadiumEntities db = new StadiumEntities();
        private void FillDgv()
        {
            List<Rent> rents = db.Rents.ToList();
            foreach (var item in rents)
            {
                DgvStadium.Rows.Add(item.Id,item.User.Name,item.User.Surname,item.StartTime.ToString("dd.MM.yyyy HH:mm"),item.Time,item.EndTime.ToString("dd.MM.yyyy HH:mm"),item.MyStadium.Name,item.User.Type==0?"Birdəfəlik":"Abunə",item.MyStadium.Price);
            }
        }
        private void CmbFill()
        {
            List<MyStadium> stadiums = db.MyStadiums.ToList();
            foreach (var item in stadiums)
            {
                CmbStadiums.Items.Add(item.Name);
            }
        }
        private void Reset()
        {
            CmbStadiums.ResetText();
            CmbTime.ResetText();
            DtpStartDate.Value = DateTime.Now;
            TxtName.ResetText();
            TxtSurname.ResetText();
            CkbSingleUse.Checked = false;
            CkbSubcribe.Checked = false;
            CmbWeeks.ResetText();
            CmbWeeks.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CkbSubcribe_CheckedChanged(object sender, EventArgs e)
        {
            CkbSingleUse.Checked = false;
            CmbWeeks.Enabled = true;
        }

        private void CkbSingleUse_CheckedChanged(object sender, EventArgs e)
        {
            CkbSubcribe.Checked = false;
            CmbWeeks.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblError.ResetText();
            if (string.IsNullOrEmpty(CmbStadiums.Text) || string.IsNullOrEmpty(CmbTime.Text) || string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || (CkbSingleUse.Checked == false && CkbSubcribe.Checked == false))
            {
                LblError.Text = "Bütün məlumatları daxil edin!";
                return;
            }

            string Name = TxtName.Text;
            string Surname = TxtSurname.Text;
            string SelectedStadium = CmbStadiums.Text;
            int Interval = Convert.ToInt32(CmbTime.Text);
            int Type = CkbSubcribe.Checked == true ? 1 : 0;
            TimeSpan MatchInterval = TimeSpan.FromMinutes(Interval);
            MessageBox.Show(MatchInterval.ToString());
            DateTime StartTime = DtpStartDate.Value;
            DateTime EndTime = StartTime.Add(MatchInterval);
            int Week = Type==0?1:Convert.ToInt32(CmbWeeks.Text);
            List<Rent> rents = db.Rents.ToList();
            
            foreach (var item in rents)
            {
                int DateDiffStart = Convert.ToInt32((StartTime - item.StartTime).TotalMinutes);
                int DateDiffStart2= Convert.ToInt32((item.EndTime - StartTime).TotalMinutes);
                int DateDiffEnd = Convert.ToInt32((EndTime - item.StartTime).TotalMinutes);
                int DateDiffEnd2 = Convert.ToInt32((item.EndTime - EndTime).TotalMinutes);
                if(item.MyStadium.Name==SelectedStadium && ((DateDiffStart>=0 && DateDiffStart2>=0) || (DateDiffEnd>=0 && DateDiffEnd2>0) || (DateDiffStart<=0 && DateDiffEnd2 <= 0)))
                {
                    LblError.Text = "Bu vaxta artıq oyun əlavə edilib.";
                    return;
                }
            }
            MessageBox.Show(Week.ToString());
            DgvStadium.Rows.Clear();
            User user = new User();
            user.Name = Name;
            user.Surname = Surname;
            user.Type = Type;
            db.Users.Add(user);
            db.SaveChanges();

            for (int i = 0; i < Week; i++)
            {
                Rent rent = new Rent();
                rent.UserId = user.Id;
                rent.StadiumId = db.MyStadiums.FirstOrDefault(s => s.Name == SelectedStadium).Id;
                rent.StartTime = StartTime;
                rent.Time = Interval;
                rent.EndTime = EndTime;
                db.Rents.Add(rent);
                db.SaveChanges();
                StartTime = StartTime.AddDays(7);
                EndTime = EndTime.AddDays(7);
            }
            Reset();
            FillDgv();


        }
    }
}
