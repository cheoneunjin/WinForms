using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_reservation
{
    public partial class Form1 : Form
    {
        RestaurantresvList InfoList;    //리스트 저장소에 접근, InfoList는 함수에 접근
        public Form1()
        {
            InitializeComponent();
            InfoList = new RestaurantresvList();    //새로운 객체를 생성
            InfoList.AddInfo("천은진", "010-2468-3658", 2, 0, "2021년 5월 5일 수요일", "18:00", "A코스", "레드와인");  //객체를 추가

            foreach (Info_resv i in InfoList)
            {
                listBox1.Items.Add(i.inName);   //ListBox1에 출력
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = comboBox2.SelectedIndex.ToString();  //comboBox2에 인덱스를 선언
            pictureBox1.Load(index + ".jpg");   //콤보박스 항목을 선택할때 마다 이미지를 출력
        }



        private void button1_Click(object sender, EventArgs e)
        { 
            string txtWine = "";    //txtWine이라는 변수를 비어있는 상태로 선언
            if (radioButton1.Checked == true)   //라디오버튼을 선택
                txtWine = "화이트 와인";
            else
                txtWine = "레드 와인";
            //새로운 객체 입력받기
            Info_resv r = new Info_resv(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), dateTimePicker1.Text, textBox5.Text, comboBox2.Text,txtWine);
            InfoList.Add(r);    //리스트에 저장

            //항목을 초기화 시킨다.
            textBox1.Text = ""; textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); 
            dateTimePicker1.ResetText();
            comboBox2.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            pictureBox1.Image = null;
            //리스트 박스에 객체 저장
            listBox1.Items.Add(r.inName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //리스트박스에서 이름을 클릭하면 출력
            int index = listBox1.SelectedIndex;     //인덱스를 통해 선택
            textBox1.Text = ""; textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); //항목 초기화
            dateTimePicker1.ResetText();
            comboBox2.ResetText();

            if (index > -1 && index < InfoList.Count)   //항목을 선택하였을 때 출력
            {
                Info_resv r = (Info_resv)InfoList[index];

                int people = r.inPeople;
                int kids = r.inKids;
                double dep = r.calDep(people, kids);

                txtContent.Text = "이름 : " + r.inName + "\r\n연락처 : " + r.inPhone + "\r\n인원수 : " + r.inPeople + "\r\n어린이 : " + 
                r.inKids + "\r\n날짜 : " + r.inDate + "\r\n시간 : " + r.inTime + "\r\n메뉴 : " + r.inMenu + "\r\n와인 : " + r.inWine  + "\r\n예약금 : " + dep;

                textBox1.Text = listBox1.Items[index].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //삭제버튼
            int index = listBox1.SelectedIndex;

            if (index > -1)
            {
                MessageBox.Show("해당 예약은 목록에서 삭제되며 예약금은 환불기준에 따라 돌려드립니다. \n 3일 이전 : 100% \n 2일 전 : 70% \n 1일 전 : 50% \n 당일 예약취소 : 20%");
                InfoList.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                txtContent.Clear();
            }
            else
                MessageBox.Show("삭제할 이름을 선택하세요");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //이름검색
            string name = textBox1.Text;
            int cnt, i;
            Info_resv r;
            cnt = InfoList.Count;

            if (name == "")
                MessageBox.Show("검색할 이름을 입력하세요");
            else
            {
                for (i = 0; i < cnt; i++)
                {
                    r = (Info_resv)InfoList[i];
                    if (name.Equals(r.inName))
                    {
                        int people = r.inPeople;
                        int kids = r.inKids;
                        double dep = r.calDep(people, kids);

                        //텍스트박스에서 출력할 값
                        txtContent.Text = "이름 : " + r.inName + "\r\n연락처 : " + r.inPhone + "\r\n인원수 : " + r.inPeople + "\r\n어린이 : " +
                        r.inKids + "\r\n날짜 : " + r.inDate + "\r\n시간 : " + r.inTime + "\r\n메뉴 : " + r.inMenu + "\r\n와인 : " + r.inWine + "\r\n예약금 : " + dep;
                    }
                }
            }
        }
    }

    //RestuarnatresvList 함수 정의
    public class RestaurantresvList : ArrayList
    {
        public int AddInfo(string name, string phone, int people, int kids, string date, string time, string menu, string wine)
        {
            return base.Add(new Info_resv(name, phone, people, kids, date, time, menu, wine));
        }
    }
    //새로운 메소드 정의, 캡슐화 이용
    public class Info_resv
    {
        private string name;
        private string phone;
        private int people;
        private int kids;
        private string date;
        private string time;
        private string menu;
        private string wine;

        public Info_resv(string name, string phone, int people, int kids, string date, string time, string menu, string wine)
        {
            this.name = name;
            this.phone = phone;
            this.people = people;
            this.kids = kids;
            this.date = date;
            this.time = time;
            this.menu = menu;
            this.wine = wine;
        }

        //예약금을 연산하는 메소드 정의
        public double calDep(int people, int kids)
        {
            return (people * 20000) + (kids * 10000);
        }

        //getter, setter을 통해 값에 접근
        public string inName
        {
            set { name = value; }
            get { return name; }
        }
        public string inPhone
        {
            set { phone = value; }
            get { return phone; }
        }
        public int inPeople
        {
            set { people = value; }
            get { return people; }
        }
        public int inKids
        {
            set { kids = value; }
            get { return kids; }
        }
        public string inDate
        {
            set { date = value; }
            get { return date; }
        }
        public string inTime
        {
            set { time = value; }
            get { return time; }

        }
         public string inMenu
        {
            set { menu = value; }
            get { return menu; }
        }
        public string inWine
        {
            set { wine = value; }
            get { return wine; }
        }

    }
}
