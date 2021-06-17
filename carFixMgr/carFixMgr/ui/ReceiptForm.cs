using carFixMgr.model;
using carFixMgr.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr.ui
{
    public partial class ReceiptForm : MaterialForm
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telA = custTelA.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string carnumber = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staffname = staffName.Text;




            if (name.Equals(""))
            {
                MessageBox.Show("이름을 입력하세요");
                ActiveControl = custName;           //이름이 같아야되는 시점
                custName.Focus();
                return;
            }


            if (telA.Equals(""))
            {
                MessageBox.Show("이름을 입력하세요");
                ActiveControl = custTelA;           //번호 앞부분이 같아야되는 시점
                custTelA.Focus();
                return;
            }

            string[] arrData = new string[]
            {
                name, telA, telB, year, month, day, model, carnumber, cc, caryear, staffname
            };

            object[] arrObj = new object[]
            {
                custName, custTelA, custTelB, custYear, custMonth, custDay, carModel, carNum, carCC, caryear, staffname
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 선택하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "차량모델을 선택하세요",
                "차량번호를 입력하세요",
                "차량연식을 선택하세요",
                "배기량을 선택하세요",
                "담당자를 선택하세요",
            };

            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("") || arrData[i].Equals("선택"))
                {
                MessageBox.Show(arrMsg[i]);
                ActiveControl = (Control)arrObj[i];
                ActiveControl.Focus();
                return;
            }
        }
           /* for (int i=0; i<arrData.Length; i++)
            {
                if(arrData[i].Equals("")) ||
            }*/
            

            UICheckBox[] checkbox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };

            List<RepairItem> itemList = new List<RepairItem>();


            for (int i=RepairTable.ENGINE_OIL; i<RepairTable.ETC_COST; i++)
            {
                if (checkbox[i].Checked)
                {
                    Console.WriteLine("수리항목" + checkbox[i].Text);
                    Console.WriteLine("수리비" + RepairTable.fixMoney[i]);
                    itemList.Add(new RepairItem(i, checkbox[i].Text, RepairTable.fixMoney[i]));
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }

            //한글 입력 체크
            string chkName = Regex.Replace(name, @"[^가-힣]", "");
            Console.WriteLine("정규표현식: " + chkName);
            if (chkName.Length != name.Length)
            {
                setFocus(custName, "올바른 이름을 입력하세요");
            }

            //자리수 체크
            Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if(m.Success == false)
            {
                MessageBox.Show("이름 자리수가 올바르지 않습니다.");
                ActiveControl = custName;
                ActiveControl.Focus();
                custName.Text="";
                return;
            }

            //전화번호 체크
            string telAll = telA + telB;
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                Match m2 = regex2.Match(telAll);
                if (m.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }

            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화번호: " + telA + telB);
            Console.WriteLine("생년월일: " + year + "년" + month + "월" + day + "일");
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + carnumber);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + caryear);
            Console.WriteLine("담당자: " + staffname);

        }

        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}