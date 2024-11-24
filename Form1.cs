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

    public partial class Form1 : Form
    {
        SqlConnection con;      //sql server 데이터베이스에 연결 하는 클래스
        SqlCommand cmd;         //sql server 데이터베이스에 대해 실행할 sql문이나 저장 프로시저 나타냄
        SqlDataReader reader;   //sql server 데이터베이스에서 행의 앞으로만 이동가능한 스트림을 읽는 클래스이다.
        string sql;             //sql문 저장하는 변수

        public Form1()
        {
            InitializeComponent();
            //constr변수에 데이터베이스 위치를 지정
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\Project_2\\DBHotel.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);    //con에 새로운 constr객체를 생성하여 데이터베이스를 연결한다.
        }

        private void 회원예약ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //회원예약 : 회원예약 폼으로 이동한다.
            Form2 frm2 = new Form2(con);
            frm2.Show();
        }

        private void 비회원예약ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //비회원 예약 : 비회원예약 폼으로 이동한다.
            Form3 frm3 = new Form3(con);
            frm3.Show();
        }

        private void 회원별조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //회원별 조회 : 비회원조회 폼으로 넘어간다.
            Form4 frm4 = new Form4(con);
            frm4.Show();
        }

        private void 기간별조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //기간별 조회 : 기간별 조회 폼으로 넘어간다.
            Form5 frm5 = new Form5(con);
            frm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //종료 : 폼을 닫는다.
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //회원등록 버튼
            if (textBox1.Text == "")    //회원번호 입력란이 비었을 경우
            {   
                //메세지 출력
                MessageBox.Show("회원번호는 필수 정보입니다. 회원번호를 입력하세요.", "정보 입력", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textBox2.Text == "")    //이름 입력란이 비었을 경우
            {
                //메세지 출력
                MessageBox.Show("이름은 필수 정보입니다. 이름을 입력하세요.", "정보 입력", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            else if(textBox3.Text == "")    //연락처 입력란이 비었을 경우
            {
                //메세지 출력
                MessageBox.Show("연락처는 필수 정보입니다. 연락처 정보를 입력하세요.", "정보 입력", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //등록
                string value1, value2, value3, value4;
                value1 = textBox1.Text; //회원번호
                value2 = textBox2.Text; //이름
                value3 = textBox3.Text; //연락처
                value4 = lblBirth.Text; //생년월일
                con.Open(); //데이터베이스에 연결
                //TBmember 테이블에 입력된 회원번호, 이름, 연락처, 생년월일 자료를 등록한다.
                sql = "insert into TBmember " +
                    "values ('" + value1 + "', N'" + value2 + "', '" + value3 + "', '" + value4 + "')";
                cmd = new SqlCommand(sql, con); //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.

                cmd.ExecuteNonQuery();  //입력 수정 삭제 수행 (실행된 행의 수를 반환한다.)

                //제목이 자료등록이고 저장되었습니다가 출력되는 정보 메시지 박스를 보여준다.
                MessageBox.Show("저장되었습니다.", "자료등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();    //데이터베이스를 연결종료
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {   //생년월일 입력에서 입력받는 자료형을 지정한다.
            lblBirth.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //조회버튼
            //입력한 이름과 일치하는 데이터검색
            string value1 = textBox2.Text;  //value1 변수에 입력된 이름을 저장한다.
            con.Open(); //데이터베이스에 연결
            //sql 변수에 이름이 value1변수와 동일한 데이터를 TBmember 테이블에서 찾아 출력한다.
            sql = "select * from TBmember " +
                " where name = N'" + value1 + "' ";
            //cmd에 새로운 객체를 생성하여 sql문을 실행하여 con에 저장한다.
            cmd = new SqlCommand(sql, con);

            reader = cmd.ExecuteReader();   //데이터베이스의 행을 읽어온다.

            while (reader.Read())  
            {
                textBox1.Text = reader["id"].ToString();    //회원번호 텍스트 박스에 id값을 출력한다.
                textBox2.Text = reader["name"].ToString();  //이름 텍스트 박스에 name값을 출력한다.
                textBox3.Text = reader["phone"].ToString(); //연락처 텍스트 박스에 phone값을 출력한다.
                lblBirth.Text = reader["birth"].ToString(); //생년월일 텍스트 박스에 birth값을 출력한다.
            }
            con.Close();    //데이터베이스 연결 종료
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            //삭제버튼
            string value1 = textBox2.Text; //입력된 이름을 value1변수에 저장한다.
            con.Open(); //데이터베이스에 연결

            //CommandText는 sql을 실행하고 저장 프로시저를 읽고 쓴다.
            //입력된 이름이 있는 행을 TBmember 테이블에서 삭제한다.
            cmd.CommandText = "delete from TBmember " +
                " where name = N'" + value1 + "' ";
            cmd.ExecuteNonQuery();  //sql문을 실행했을 때 실행한 행의 수를 반환한다.
            con.Close();    //데이터베이스 연결 종료

            //모든 텍스트박스를 초기화 한다.
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; lblBirth.Text = "";
            //메시지 박스 출력
            MessageBox.Show("삭제되었습니다.", "자료삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //수정버튼
            string value1, value2, value3, value4;
            value1 = textBox1.Text; //회원번호
            value2 = textBox2.Text; //이름
            value3 = textBox3.Text; //연락처
            value4 = lblBirth.Text; //생년월일
            con.Open(); //데이터베이스에 연결
            //회원 id로 데이터를 찾아내어 수정하는 sql문
            cmd.CommandText = "update TBmember " +
                " set name = N'" + value2 + "', " +
                " phone = '" + value3 + "', " +
                " birth = '" + value4 + "' " +
                " where id = '" + value1 + "' ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("수정되었습니다. ");
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; lblBirth.Text = "";

            con.Close();    //데이터베이스에 연결 종료
        }

        

        private void 회원조회및등급확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //회원정보 및 등급 조회 폼으로 이동
            Form6 frm6 = new Form6(con);
            frm6.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {   //첫번째 텍스트박스 클릭 -> 초기화
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; lblBirth.Text = "";
        }
    }
}
