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
    public partial class Form5 : Form
    {
        SqlConnection con;      //sql server 데이터베이스에 연결 하는 클래스
        SqlCommand cmd;         //sql server 데이터베이스에 대해 실행할 sql문이나 저장 프로시저 나타냄
        SqlDataReader reader;   //sql server 데이터베이스에서 행의 앞으로만 이동가능한 스트림을 읽는 클래스이다
        string sql;             //sql문 저장하는 변수
        DataSet ds;             //dataset의 결과를 저장하는 자료형이다. ds변수 사용하였다.
        SqlDataAdapter adt;     //dataset을 채우고 데이터베이스를 업데이트 하는데 사용할 데이터 명령 집합과 데이터베이스 연결을 나타냄 adt 객체 사용

        public Form5(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;         //데이터베이스를 연결한다.
            //데이터베이스의 연결상태가 연결되어있다면 데이터베이스를 연다.
            if (con.State == ConnectionState.Open)
                con.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //초기화면에 데이터를 표시하지 않기 위해 메소드안에 아무것도 정의하지 않았다.

        }

        public void displayGrid(string sql)
        {
            adt = new SqlDataAdapter(sql, con); //sql문을 실행할 객체
            ds = new DataSet(); //sql 결과가 들어갈 집합체
            adt.Fill(ds);   //sql 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];    //datagridview에 ds에 들어있는 결과 테이블을출력한다.

        }

        private void button2_Click(object sender, EventArgs e)
        {   //날짜별 조회버튼
            //공백으로 두면 2021년의 예약을 조회
            if (sdate.Text == "    -  -") sdate.Text = "20210101";
            if (edate.Text == "    -  -") edate.Text = "20211231";

            //TBresv 테이블에서 입력한 날짜 사이의 값을 조회한다.
            sql = "select * from TBresv " +
                " where idate >= '" + sdate.Text + "' and" +
                " idate <= '" + edate.Text + "' ";

            //sql문의 결과를 DataGridView에 출력한다.
            displayGrid(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {   //통계 조회 버튼
            con.Open(); //데이터베이스 연결
            //TBresv 테이블로부터 입력받은 날짜 사이의 데이터를 출력한다. 결과값을 개수를 a변수에 저장, 어른수를 더한 값을 b변수에 저장, 아이 수를 더한 값을 c변수에 저장한다.
            sql = "select count(*) as a, sum(adult) as b, sum(kid) as c from TBresv " +
                " where odate >= '" + sdate.Text + "' and" +
                " idate <= '" + edate.Text + "' ";

            cmd = new SqlCommand(sql, con);     //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.
            reader = cmd.ExecuteReader();       //데이터베이스의 행을 읽어온다.

            //데이터 읽어오기
            if (reader.Read())
            {
                textBox3.Text = reader["a"].ToString(); //예약건수 출력
                textBox1.Text = reader["b"].ToString(); //어른 수 총합 출력
                textBox2.Text = reader["c"].ToString(); //아이 수 총합 출력
            }
            reader.Close();     //데이터 읽어오기 종료
            con.Close();        //데이터베이스 연결조욜
        }

        private void button3_Click(object sender, EventArgs e)
        {   //종료
            this.Close();
        }
    }
}
