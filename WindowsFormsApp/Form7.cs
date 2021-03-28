using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form7 : Form
    {
        private List<List<Student>> classes = new List<List<Student>>();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxClassNames.Items.Add("Cao Đẳng 17");
            comboBoxClassNames.Items.Add("Cao Đẳng 18");

            List<Student> studentList1 = new List<Student>();
            studentList1.Add(new Student("Anh Tuấn", 9, 8, 9));
            studentList1.Add(new Student("Hoàng Giang", 10, 7, 9));
            studentList1.Add(new Student("Trâm Anh", 8, 7, 10));

            List<Student> studentList2 = new List<Student>();
            studentList2.Add(new Student("Hữu Tiến", 7, 8, 9));
            studentList2.Add(new Student("Thanh Lâm", 5, 4, 6));
            studentList2.Add(new Student("Yến Như", 4, 7, 7));

            classes.Add(studentList1);
            classes.Add(studentList2);
        }

        private void comboBoxClassNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClassNames.SelectedIndex >= 0)
            {
                listViewStudentList.Items.Clear();
                ResetForm();
                List<Student> studentList = classes[comboBoxClassNames.SelectedIndex];

                for (int index = 0; index < studentList.Count; index++)
                {
                    InsertDataIntoTable(studentList[index]);
                }
            }
        }

        private void listViewStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudentList.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = listViewStudentList.SelectedItems[0];
                textBoxFullName.Text = listViewItem.SubItems[0].Text;
                numericUpDownLTGD.Value = Convert.ToDecimal(listViewItem.SubItems[1].Text);
                numericUpDownMMT.Value = Convert.ToDecimal(listViewItem.SubItems[2].Text);
                numericUpDownCSDL.Value = Convert.ToDecimal(listViewItem.SubItems[3].Text);

                decimal average = Math.Round((numericUpDownLTGD.Value + numericUpDownMMT.Value + numericUpDownMMT.Value) / 3, 2);
                labelStudentInfo.Text = $"Điểm trung bình của sinh viên {textBoxFullName.Text} là: {average}";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClassNames.SelectedIndex >= 0)
            {
                List<Student> students = classes[Convert.ToInt32(comboBoxClassNames.SelectedIndex)];
                Student student = GetInfoStudentFromForm();
                InsertDataIntoTable(student);
                students.Add(student);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxClassNames.SelectedIndex >= 0)
            {
                if (listViewStudentList.SelectedItems.Count != 0)
                {
                    ListViewItem listViewItem = listViewStudentList.SelectedItems[0];
                    listViewItem.SubItems[0].Text = textBoxFullName.Text;
                    listViewItem.SubItems[1].Text = numericUpDownLTGD.Value.ToString();
                    listViewItem.SubItems[2].Text = numericUpDownMMT.Value.ToString();
                    listViewItem.SubItems[3].Text = numericUpDownCSDL.Value.ToString();

                    Student student = classes[comboBoxClassNames.SelectedIndex][listViewStudentList.SelectedIndices[0]];
                    student.FullName = textBoxFullName.Text;
                    student.MarkLTGD = numericUpDownLTGD.Value;
                    student.MarkMMT = numericUpDownMMT.Value;
                    student.MarkCSDL = numericUpDownCSDL.Value;
                }
                else
                {
                    MessageBox.Show("Chưa chọn sinh viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxClassNames.SelectedIndex >= 0)
            {
                if (listViewStudentList.SelectedItems.Count != 0)
                {
                    int numberOfdeleteStudent = listViewStudentList.SelectedItems.Count;

                    for (int index = numberOfdeleteStudent - 1; index >= 0; index--)
                    {
                        int positionToDelete = listViewStudentList.SelectedIndices[index];
                        listViewStudentList.Items.RemoveAt(positionToDelete);
                        classes[comboBoxClassNames.SelectedIndex].RemoveAt(positionToDelete);
                    }

                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Chưa chọn sinh viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn lớp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDataIntoTable(Student student)
        {
            string[] rowData = new string[] {
                student.FullName,
                student.MarkLTGD.ToString(),
                student.MarkMMT.ToString(),
                student.MarkCSDL.ToString()
            };
            listViewStudentList.Items.Add(new ListViewItem(rowData));
        }

        private Student GetInfoStudentFromForm()
        {
            Student student = new Student();
            student.FullName = textBoxFullName.Text;
            student.MarkLTGD = numericUpDownLTGD.Value;
            student.MarkMMT = numericUpDownMMT.Value;
            student.MarkCSDL = numericUpDownCSDL.Value;
            return student;
        }

        private void ResetForm()
        {
            textBoxFullName.Text = "";
            numericUpDownLTGD.Value = 0;
            numericUpDownMMT.Value = 0;
            numericUpDownCSDL.Value = 0;
            labelStudentInfo.Text = "";
        }
    }
}
