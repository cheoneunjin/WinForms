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
    public partial class Form3 : Form
    {
        SqlConnection con;      //sql server 데이터베이스에 연결 하는 클래스
        SqlCommand cmd;         //sql server 데이터베이스에 대해 실행할 sql문이나 저장 프로시저 나타냄
        SqlDataReader reader;   //sql server 데이터베이스에서 행의 앞으로만 이동가능한 스트림을 읽는 클래스이다.
        string sql;             //sql문 저장하는 변수
        Boolean cal = false;    //sql문이 실행되기 전 계산버튼을 통해 가격을 확인했는지 알 수 있도록하는 boolean형 변수이다. 초기값은 false
        public Form3(SqlConnection con)
        {
            InitializeComponent();
            //데이터베이스를 연결한다.
            this.con = con;
            //데이터베이스의 연결상태가 연결되어있다면 데이터베이스를 연다.
            if (con.State == ConnectionState.Open)
                con.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {   //종료
            this.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {   //체크인 날짜 : 체크인 캘린더를 선택했을 때 텍스트박스에 출력될 날짜의 형식을 지정한다.
            lblDate.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {   //체크아웃 날짜 : 체크아웃 캘린더를 선택했을 때 텍스트박스에 출력될 날짜의 형식을 지정한다.
            lblOut.Text = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //콤보 박스 : 어른 수
            int adu = Convert.ToInt32(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //콤보 박스 : 아이 수
            int kid = Convert.ToInt32(comboBox2.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //계산버튼
            int adu = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int kid = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            string sdate = lblDate.Text;    //예약날짜(체크아웃)
            string edate = lblOut.Text;     //예약날짜(체크인)
            DateTime T1 = DateTime.Parse(sdate);    //날짜형으로 변환
            DateTime T2 = DateTime.Parse(edate);    //날짜형으로 변환
            //TS 변수에 체크인 날짜와 체크아웃날짜 차이 계산
            TimeSpan TS = T2 - T1;
            //값 계산 및 저장
            int diffDay = TS.Days;
            //성인 1인당 1박 30000원 아이 1명 1박 10000원
            long tot = (((30000 * adu) + (10000 * kid)) * diffDay);
            int Tot = Convert.ToInt32(Math.Abs(tot));   //Tot 변수에 비용의 절대값을 저장
            txtCost.Text = Tot.ToString();  //텍스트박스에 값 저장
            cal = true;         //계산버튼 눌림여부 true
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //등록
            if (cal == false)   //계산버튼이 눌려지지 않았을 경우
            {
                MessageBox.Show("먼저 계산버튼을 눌러서 비용을 확인하십시오.", "비용 확인 안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string edate = lblOut.Text; //예약날짜(체크아웃)
                DateTime T2 = DateTime.Parse(edate);    //날짜형으로 변환
                string sdate = lblDate.Text;    //예약날짜(체크인)
                DateTime T1 = DateTime.Parse(sdate);        //날짜형으로 변환

                string date = DateTime.Now.ToShortDateString(); //오늘날짜
                DateTime Tn = DateTime.Parse(date);             //날짜형으로 변환

                //오늘날짜와 체크인 날짜를 비교한다.
                //오늘날짜가 체크인날짜 보다 이전이라면 0이상의 값을 반환한다.
                int result_1 = DateTime.Compare(Tn, T1);

                //체크인 날짜와 체크아웃 날짜를 비교한다.
                //체크아웃날짜가 체크인날짜보다 먼저이면 0이하의 값을 반환한다.
                int result_2 = DateTime.Compare(T1, T2);

                //체크인 날짜가 오늘날짜보다 이전일 경우
                if (result_1 > 0)
                {
                    //오류 메시지 박스를 출력한다.
                    MessageBox.Show("숙박일자를 다시 선택하십시오", "숙박일자 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //날짜를 출력하는 텍스트 박스와 캘린더를 초기화한다.
                    monthCalendar1.ResetText(); monthCalendar2.ResetText();
                    lblDate.Text = ""; lblOut.Text = "";

                }
                //체크인날짜가 체크아웃날짜 이후일 경우
                else if (result_2 > 0)
                {
                    //오류 메시지 박스를 출력한다.
                    MessageBox.Show("숙박일자를 다시 선택하십시오", "숙박일자 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //날짜를 출력하는 텍스트 박스와 캘린더를 초기화한다.
                    monthCalendar1.ResetText(); monthCalendar2.ResetText();
                    lblDate.Text = ""; lblOut.Text = "";
                }
                else
                {
                    string value1, value2, value3, value4, value5, value6, value7, value8;
                    value1 = null;  //회원이 아니기때문에 회원번호는 공백으로 둔다.
                    value2 = textBox1.Text; //이름
                    value3 = textBox2.Text; //연락처
                    value4 = comboBox1.SelectedItem.ToString(); //어른 수
                    value5 = comboBox2.SelectedItem.ToString(); //아이 수
                    value6 = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");  //체크인 날짜
                    value7 = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");  //체크아웃 날짜
                    value8 = txtCost.Text;  //비용
                    con.Open();     //데이터베이스 연결 

                    //입력된 데이터를 TBresv 테이블에 삽입한다.
                    sql = "insert into TBresv " +
                        "values ('" + value1 + "', N'" + value2 + "', '" + value3 + "', '" + value4 + "', '" + value5 + "', '" + value6 + "', '" + value7 + "', '" + value8 + "')";
                    cmd = new SqlCommand(sql, con);     //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.
                    cmd.ExecuteNonQuery();  //입력 수정 삭제 수행

                    //메세지박스 출력
                    MessageBox.Show("저장되었습니다.", "자료등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //모든항목 초기화
                    textBox1.Text = ""; textBox2.Text = "";
                    comboBox1.ResetText(); comboBox2.ResetText();
                    monthCalendar1.ResetText(); monthCalendar2.ResetText();
                    lblDate.Text = ""; lblOut.Text = "";
                    txtCost.Text = "";
                    con.Close();    //데이터베이스 연결종료
                    cal = false;    //계산버튼 눌림여부 false
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //초기화
            textBox1.Text = ""; textBox2.Text = "";
            comboBox1.ResetText(); comboBox2.ResetText();
            monthCalendar1.ResetText(); monthCalendar2.ResetText();
            lblDate.Text = ""; lblOut.Text = "";
            txtCost.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //수정
            string value1, value2, value3, value4, value5, value6, value7, value8;
            value1 = null;  //회원번호(비회원이기때문에 null 입력)
            value2 = textBox1.Text; //이름
            value3 = textBox2.Text; //연락처
            value4 = comboBox1.SelectedItem.ToString(); //어른 수
            value5 = comboBox2.SelectedItem.ToString(); //아이 수
            value6 = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");  //체크인 날짜
            value7 = monthCalendar2.SelectionStart.ToString("yyyy-MM-dd");  //체크아웃 날짜
            value8 = txtCost.Text;  //비용

            string edate = lblOut.Text; //예약날짜(체크아웃)
            DateTime T2 = DateTime.Parse(edate);    //날짜형으로 변환
            string sdate = lblDate.Text;    //예약날짜(체크인)
            DateTime T1 = DateTime.Parse(sdate);        //날짜형으로 변환

            string date = DateTime.Now.ToShortDateString(); //오늘날짜
            DateTime Tn = DateTime.Parse(date);

            int result_1 = DateTime.Compare(Tn, T2);
            int result_2 = DateTime.Compare(T1, T2);

            //체크인 날짜가 오늘날짜보다 이전일 경우
            if (result_1 > 0)
            {
                MessageBox.Show("숙박일자를 다시 선택하십시오", "숙박일자 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //캘린더와 날짜텍스트박스 초기화
                monthCalendar1.ResetText(); monthCalendar2.ResetText();
                lblDate.Text = ""; lblOut.Text = "";

            }
            //체크인날짜가 체크아웃날짜 이후일 경우
            else if (result_2 > 0)
            {
                MessageBox.Show("숙박일자를 다시 선택하십시오", "숙박일자 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //캘린더와 날짜텍스트박스 초기화
                monthCalendar1.ResetText(); monthCalendar2.ResetText();
                lblDate.Text = ""; lblOut.Text = "";

            }
            else
            {
                if (cal == false)       //계산버튼을 눌리지 않았을 경우
                {
                    MessageBox.Show("먼저 계산버튼을 눌러서 비용을 확인하십시오.", "비용 확인 안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCost.Text = " ";
                }
                else
                {   
                    con.Open();     //데이터베이스 연결
                    //이름, 체크인, 체크아웃 날짜를 조건으로 수정한다.
                     cmd.CommandText = "update TBresv " +
                        " set id = '" + value1 + "', " +
                        " phone = '" + value3 + "', " +
                        " adult = '" + value4 + "', " +
                        " kid = '" + value5 + "', " +
                        " cost = '" + value8 + "' " +
                        " where name = N'" + value2 + "' and idate = '" + value6 + "' and odate = '" + value7 + "' ";

                    cmd.ExecuteNonQuery();      //입력 수정 삭제 수행 (실행된 행의 수를 반환한다.)
                    //메세지 박스 출력
                    MessageBox.Show("수정되었습니다. 날짜는 변경하실 수 없습니다. 날짜를 변경하려면 예약을 취소하시고 다시 예약해 주세요.", "자료수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //모든항목 초기화
                    textBox1.Text = ""; textBox2.Text = "";
                    comboBox1.ResetText(); comboBox2.ResetText();
                    monthCalendar1.ResetText(); monthCalendar2.ResetText();
                    lblDate.Text = ""; lblOut.Text = "";
                    txtCost.Text = "";

                    con.Close();    //데이터에비스 연결종료
                    cal = false;    //계산버튼 눌림여부 false
                }
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //삭제버튼 : 이름, 체크인 날짜, 체크아웃 날짜 조건으로 삭제한다.
            string value1 = textBox1.Text;  //이름
            string value2 = lblDate.Text; //체크인 날짜
            string value3 = lblOut.Text;  //체크아웃 날짜
            con.Open();     //데이터베이스 연결
            //이름, 체크인날짜, 체크아웃날짜 조건으로 삭제한다.
            cmd.CommandText = "delete from TBresv " +
                " where name = N'" + value1 + "' and idate = '" + value2 + "' and odate = '" + value3 + "' ";
            cmd.ExecuteNonQuery();      //입력 수정 삭제 수행 (실행된 행의 수를 반환한다.)
            con.Close();        //데이터베이스 연결종료

            //모든항목 초기화
            textBox1.Text = ""; textBox2.Text = "";
            comboBox1.ResetText(); comboBox2.ResetText();
            monthCalendar1.ResetText(); monthCalendar2.ResetText();
            lblDate.Text = ""; lblOut.Text = "";
            txtCost.Text = "";
            //메세지박스 출력
            MessageBox.Show("삭제되었습니다.", "자료삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //조회버튼
            //입력한 이름, 체크인 날짜 체크아웃날짜와 일치하는 데이터검색
            string value1 = textBox1.Text;  //이름
            string value2 = lblDate.Text; //체크인 날짜
            string value3 = lblOut.Text;  //체크아웃 날짜
            con.Open(); //데이터베이스 연결
            //이름, 체크인날짜, 체크아웃날짜로 데이터를 조회할 수 있다.
            sql = "select * from TBresv " +
                " where name = N'" + value1 + "' and idate = '" + value2 + "' and odate = '" + value3 + "' ";
            cmd = new SqlCommand(sql, con); //cmd에 새로운 객체를 생성하여 sql문을 실행하고 con에 새로운 데이터를 넣는다.

            reader = cmd.ExecuteReader();    //데이터베이스의 행을 읽어온다.

            //데이터 읽어오기
            while (reader.Read())
            {
                textBox1.Text = reader["name"].ToString();
                textBox2.Text = reader["phone"].ToString();
                comboBox1.SelectedItem = reader["adult"].ToString();
                comboBox2.SelectedItem = reader["kid"].ToString();
                string inD = reader["idate"].ToString();    //날짜만 추출하기 위한 코드 부분
                lblDate.Text = inD.Substring(0, 10);        //읽어온 데이터를 10자만 추출한다.
                string outD = reader["odate"].ToString();   //날짜만 추출하기 위한 코드 부분
                lblOut.Text = outD.Substring(0, 10);        //읽어온 데이터를 10자만 추출한다.
                txtCost.Text = reader["cost"].ToString();
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("해당회원의 예약 내역이 없습니다.", "예약 내역 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                con.Close();
            }
            else
            {
                string edate = lblOut.Text; //예약날짜(체크아웃)
                DateTime T2 = DateTime.Parse(edate);    //날짜형으로 변환

                string date = DateTime.Now.ToShortDateString(); //오늘날짜
                DateTime Tn = DateTime.Parse(date);     //날짜형으로 변환

                int result_1 = DateTime.Compare(Tn, T2);    //날짜비교

                //체크인 날짜가 오늘날짜보다 이전일 경우
                if (result_1 > 0)
                {
                    MessageBox.Show("지난 예약 내역 입니다.", "지난 예약 내역", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //모든항목 초기화
                    textBox1.Text = ""; textBox2.Text = "";
                    comboBox1.ResetText(); comboBox2.ResetText();
                    monthCalendar1.ResetText(); monthCalendar2.ResetText();
                    lblDate.Text = ""; lblOut.Text = "";
                    txtCost.Text = "";
                }
            }

            con.Close();    //데이터베이스 종료
        }
    }
}
