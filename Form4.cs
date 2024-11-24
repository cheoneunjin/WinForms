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
    public partial class Form4 : Form
    {
        SqlConnection con;      //sql server 데이터베이스에 연결 하는 클래스
        SqlCommand cmd;         //sql server 데이터베이스에 대해 실행할 sql문이나 저장 프로시저 나타냄
        SqlDataReader reader;   //sql server 데이터베이스에서 행의 앞으로만 이동가능한 스트림을 읽는 클래스이다
        string sql;             //sql문 저장하는 변수
        DataSet ds;             //dataset의 결과를 저장하는 자료형이다. ds변수 사용하였다.
        SqlDataAdapter adt;     //dataset을 채우고 데이터베이스를 업데이트 하는데 사용할 데이터 명령 집합과 데이터베이스 연결을 나타냄 adt 객체 사용

        public Form4(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;     //데이터베이스를 연결한다.
            //데이터베이스의 연결상태가 연결되어있다면 데이터베이스를 연다.
            if (con.State == ConnectionState.Open)
                con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //종료
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //조회버튼
            string value1 = textBox1.Text;      //회원번호
            string value2 = textBox2.Text;      //회원이름
            //회원번호와 이름을 통해 데이터 조회
            sql = "select * from TBresv " + 
                " where id = '" + value1 + "' and name = N'" + value2 + "' ";
            displayGrid(sql);   //DataGridView에 결과를 보여줌
        }
        public void displayGrid(string sql)
        {
            adt = new SqlDataAdapter(sql, con); //sql문을 실행할 객체
            ds = new DataSet(); //sql 결과가 들어갈 집합체
            adt.Fill(ds);   //sql 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];    //datagridview에 ds에 들어있는 결과 테이블을출력한다.

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //초기화면에 데이터를 표시하지 않기 위해 메소드안에 아무것도 정의하지 않았다.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //총 결제 금액 확인 및 이용 횟수 확인
            con.Open(); //데이터베이스 연결
            //회원번호와 이름으로 검색된 데이터의 모든 비용을 총합한 것을 c변수에 저장, 결과값의 개수를 r 변수에 저장한다.
            sql = "select sum(cost) as c, count(*) as r from TBresv " +
                " where id = '"  + textBox1.Text + "' and name = N'" + textBox2.Text + "' " ;

            cmd = new SqlCommand(sql, con);     //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.
            reader = cmd.ExecuteReader();       //데이터베이스의 행을 읽어온다.


            //데이터 읽어오기
            if (reader.Read())
            {
                textBox3.Text = reader["c"].ToString();
                textBox4.Text = reader["r"].ToString();
            }
            reader.Close(); //읽기 종료
            con.Close();    //데이터베이스 연결 종료
        }

        private void textBox1_Click(object sender, EventArgs e)
        {   //첫번째 텍스트박스를 누르면 모든 항목 초기화
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
        }

        

    }
}
