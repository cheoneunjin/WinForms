using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form6 : Form
    {
        SqlConnection con;      //sql server 데이터베이스에 연결 하는 클래스
        SqlCommand cmd;         //sql server 데이터베이스에 대해 실행할 sql문이나 저장 프로시저 나타냄
        SqlDataReader reader;   //sql server 데이터베이스에서 행의 앞으로만 이동가능한 스트림을 읽는 클래스이다
        string sql;             //sql문 저장하는 변수
        DataSet ds;             //dataset의 결과를 저장하는 자료형이다. ds변수 사용하였다.
        SqlDataAdapter adt;     //dataset을 채우고 데이터베이스를 업데이트 하는데 사용할 데이터 명령 집합과 데이터베이스 연결을 나타냄 adt 객체 사용

        public Form6(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //데이터베이스를 연결한다.

            //데이터베이스의 연결상태가 연결되어있다면 데이터베이스를 연다.
            if (con.State == ConnectionState.Open)
                con.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dBHotelDataSet2.TBmember' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBmemberTableAdapter.Fill(this.dBHotelDataSet2.TBmember);

        }
        public void displayGrid(string sql)
        {
            adt = new SqlDataAdapter(sql, con); //sql문을 실행할 객체
            ds = new DataSet(); //sql 결과가 들어갈 집합체
            adt.Fill(ds);   //sql 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];    //datagridview에 ds에 들어있는 결과 테이블을출력한다.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //조회버튼
            string value1 = textBox1.Text;  //회원번호
            string value2 = textBox2.Text;  //이름
            //회원번호와 이름으로 데이터를 검색한다.
            sql = "select * from TBmember " +
                " where id = '" + value1 + "' and name = N'" + value2 + "' ";
            //sql문의 결과를 DataGridView에 출력한다.
            displayGrid(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //등급확인
            con.Open(); //데이터베이스 연결
            //회원번호와 이름으로 TBresv 테이블에서 검색한 데이터의 개수를 변수 a에 저장한다.
            sql = "select count(*) as a from TBresv " +
                " where id = '" + textBox1.Text + "' and" +
                " name = N'" + textBox2.Text + "' ";

            cmd = new SqlCommand(sql, con);     //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.
            reader = cmd.ExecuteReader();       //데이터베이스의 행을 읽어온다.
            reader.Read();      //데이터를 읽어온다.
            int r = Convert.ToInt32(reader["a"].ToString());    //a변수를 정수형으로 읽어온다.
            
            if(r >= 10) //이용횟수 10회 이상
            {
                textBox4.Text = textBox2.Text;  //오른쪽 상단에 회원이름 표시
                textBox3.Text = "VVIP Level";   //VVIP고객
                //리스트박스에 출력
                listBox1.Items.Add("1. 예약시 5%할인 항시 적용");
                listBox1.Items.Add("2. 방문 시 예약 고객 동반 1인에게 조식 제공");
                listBox1.Items.Add("3. 호텔 내 스파 무료이용권 제공");
            }
            else if(r >= 5)     //이용횟수 5회 이상
            {
                textBox4.Text = textBox2.Text;  //오른쪽 상단에 회원이름 표시
                textBox3.Text = "VIP Level";    //VIP고객
                //리스트박스에 출력
                listBox1.Items.Add("1. 예약시 5%할인 항시 적용");
                listBox1.Items.Add("2. 방문 시 예약 고객 동반 1인에게 조식 제공");
                listBox1.Items.Add("3. 호텔 내 카페에서 아메리카노 한잔 무료 제공");

                
            }
            else if (r >= 3)        //이용횟수 3회 이상
            {
                textBox4.Text = textBox2.Text;      //오른쪽 상단에 회원이름 표시
                textBox3.Text = "Gold Level";       //GOLD고객
                //리스트박스에 출력
                listBox1.Items.Add("1. 예약시 5%할인 항시 적용");
                listBox1.Items.Add("2. 방문 시 예약 고객에게 조식 제공");
                listBox1.Items.Add("3. 호텔 내 카페 30%할인 쿠폰 제공");
            }
            else if(r >= 1)     //이용횟수 1회 이상
            {
                textBox4.Text = textBox2.Text;      //오른쪽 상단에 회원이름 표시
                textBox3.Text = "Bronze Level";     //BRONZE 고객
                //리스트박스에 출력
                listBox1.Items.Add("1. 예약시 5%할인 항시 적용");
                listBox1.Items.Add("2. 방문 시 예약 고객에게 조식 제공");
            }
            else if(r ==0)      //이용횟수 0회
            {
                textBox4.Text = textBox2.Text;      //오른쪽 상단에 회원이름 표시
                textBox3.Text = "Silver Level";     //SILVER 고객
                //리스트박스에 출력
                listBox1.Items.Add("예약시 5%할인 항시 적용");
            }
            reader.Close(); //데이터 읽어오기 종료
            con.Close();    //데이터베이스 연결 종료
        }

        private void button3_Click(object sender, EventArgs e)
        {   //종료
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {   //첫번째 텍스트 박스를 누르면 모든 항목이 초기화된다.
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; listBox1.Items.Clear();
        }
    }
}
