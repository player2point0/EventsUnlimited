using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EventsUnlimited
{
    class SQLManager
    {
        private Table table;
        private string connection;

        private SqlDataAdapter sqlAdapter;
        private SqlCommandBuilder sqlBuilder;

        private DataTable dataTable;
        private DataRow dataRow;

        public SQLManager(string _name, string[] _primaryKeys, string[] _fields)
        {
            connection = Program.GetConnectionString();
            table = new Table(_name, _primaryKeys, (_primaryKeys.Length > 1), _fields);
        }

        public void ReadTable()
        {
            string sql = @"select * from " + table.Name;
            sqlAdapter = new SqlDataAdapter(sql, connection);
            sqlBuilder = new SqlCommandBuilder(sqlAdapter);
            dataTable = new DataTable();
            sqlAdapter.FillSchema(dataTable, SchemaType.Source);
            sqlAdapter.Fill(dataTable);
        }

        public string ShowTable(ref int index, ref Control[] controls)
        {
            if (index < 0)
            {
                index = 0;
                return "First record";
            }

            else if (index >= dataTable.Rows.Count)
            {
                index = (dataTable.Rows.Count - 1);
                return "Last record";
            }

            dataRow = dataTable.Rows[index];

            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Text = dataRow[table.Fields[i]].ToString();
            }

            return "";
        }
          
        public string DeleteRow(string[] rowKey)
        {
            try
            {
                dataRow = dataTable.Rows.Find(rowKey);

                if (dataRow == null) throw new Exception("Record not found");

                dataRow.Delete();
                sqlAdapter.Update(dataTable);
                return "Record deleted";
            }

            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string AddRow(ref Control[] controls)
        {
            dataRow = null;
            dataRow = GetRow(ref controls);

            dataTable.Rows.Add(dataRow);
            sqlAdapter.Update(dataTable);

            return "Record added";
        }

        public string EditRow(string[] rowKeys, ref Control[] controls)
        {
            DialogResult edit = MessageBox.Show("Do you want to update the record?", "Edit record", MessageBoxButtons.YesNo);

            if (edit == DialogResult.Yes)
            {
                DeleteRow(rowKeys);
                AddRow(ref controls);
                return "Record Updated";
            }
            return "";
        }

        private DataRow GetRow(ref Control[] controls)
        {
            DataRow outputRow = dataTable.NewRow();

            for (int i = 0; i < table.Fields.Length; i++)
            {
                outputRow[table.Fields[i]] = controls[i].Text.ToString();
            }

            return outputRow;
        }
    }
}
