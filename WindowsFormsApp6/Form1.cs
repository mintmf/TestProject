using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private BindingSource ordersBindingSource = new BindingSource();
        private BindingSource transfersBindingSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(Properties.Resources.connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(Properties.Resources.createPaymentString, connection))
                {
                    SqlParameter param = new SqlParameter();
                    SqlParameter param2 = new SqlParameter();
                    SqlParameter param3 = new SqlParameter();
                    param.ParameterName = "@order";
                    param2.ParameterName = "@transfer";
                    param3.ParameterName = "@sum";
                    if (ordersGridView.CurrentRow == null)
                    {
                        MessageBox.Show("Выберите заказ", "Ошибка");
                        return;
                    }
                    param.Value = ordersGridView.CurrentRow.Cells[0].Value;
                    if (transfersGridView.CurrentRow == null)
                    {
                        MessageBox.Show("Выберите приход денег", "Ошибка");
                        return;
                    }
                    param2.Value = transfersGridView.CurrentRow.Cells[0].Value;
                    
                    try
                    {
                        param3.Value = Decimal.Parse(paymentSumTextBox.Text);
                    }
                    catch (Exception)
                    {
                        if (paymentSumTextBox.Text == String.Empty)
                        {
                            MessageBox.Show("Введите сумму платежа", "Ошибка");
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат суммы платежа", "Ошибка");
                        }
                        return;
                    }
                    command.Parameters.Add(param);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Errors[0].Message, "Ошибка");
                    }
                }
            }

            paymentSumTextBox.Text = string.Empty;
            
            ordersGridView.DataSource = ordersBindingSource;
            GetData(Properties.Resources.getOrdersString, ordersBindingSource);

            transfersGridView.DataSource = transfersBindingSource;
            GetData(Properties.Resources.getTransfersString, transfersBindingSource);

            FilterGrid(textBox2, ordersGridView, ordersBindingSource);
            FilterGrid(textBox3, transfersGridView, transfersBindingSource);
        }

        private void GetData(string selectCommand, BindingSource bindingSource)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, Properties.Resources.connectionString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show("Не удалось подключиться", "Ошибка");
            }
        }

        private void FilterGrid(TextBox t, DataGridView dgv, BindingSource bindingSource)
        {
            bool v;

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                v = false;

                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dr.Cells[j].Value != null)
                    {
                        if (dr.Cells[j].Value.ToString().Contains(t.Text))
                        {
                            v = true;
                            break;
                        }
                    }
                }

                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgv.DataSource];
                currencyManager1.SuspendBinding();

                dr.Visible = v;
                currencyManager1.ResumeBinding();
            }

            dgv.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterGrid(textBox2, ordersGridView, ordersBindingSource);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ordersGridView.DataSource = ordersBindingSource;
            GetData(Properties.Resources.getOrdersString, ordersBindingSource);

            transfersGridView.DataSource = transfersBindingSource;
            GetData(Properties.Resources.getTransfersString, transfersBindingSource);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            FilterGrid(textBox2, ordersGridView, ordersBindingSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilterGrid(textBox3, transfersGridView, transfersBindingSource);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
            FilterGrid(textBox3, transfersGridView, transfersBindingSource);
        }
    }
}
