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
        private string table;
        private string connection;
        private string[] fields;
        private string[] primaryKeys;

        private SqlDataAdapter sqlAdapter;
        private SqlCommandBuilder sqlBuilder;

        private DataTable dataTable;
        private DataRow dataRow;

        public SQLManager(string _table, string[] _fields, string[] _primaryKeys)
        {
            table = _table;
            connection = Program.GetConnectionString(); ;
            fields = _fields;
            primaryKeys = _primaryKeys;
        }

        public void ReadTable()
        {
            string sql = @"select * from " + table;
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
                controls[i].Text = dataRow[fields[i]].ToString();
            }

            return "";
        }

        public string[] GetData(string[] keys, string[] fields)
        {
            string[] output = new string[fields.Length];

            try
            {
                dataRow = dataTable.Rows.Find(keys);

                if (dataRow == null) throw new Exception();

                for (int i = 0; i < fields.Length; i++)
                {
                    output[i] = dataRow[fields[i]].ToString();
                }

                return output;
            }

            catch (Exception)
            {
                return output;
            }
        }

        public List<string> GetAllData(string field, string condition, string data)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                if (dataRow[field].ToString() == condition)
                {
                    output.Add(dataRow[data].ToString());
                }
            }

            return output;
        }

        public void PopulateComboBox(string idField, string dataField, ref ComboBox display)
        {
            /*
            foreach (DataRow dr in dataTable.Rows)
            {
                var item = new Container(dr[idField].ToString(), dr[dataField].ToString());

                display.Items.Add(item);
            }
            */
        }

        public string DeleteRow(string[] keys)
        {
            try
            {
                dataRow = dataTable.Rows.Find(keys);

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

        public string DeleteAllWith(string field, string condition)
        {
            //delete any row which has the conditions
            int num = 0;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                if (dataRow[field].ToString() == condition)
                {
                    dataRow.Delete();
                    sqlAdapter.Update(dataTable);

                    num++;
                }
            }

            return num + " rows deleted";
        }

        public string AddRow(string[] data)
        {
            dataRow = null;
            dataRow = dataTable.NewRow();

            for (int i = 0; i < data.Length; i++)
            {
                dataRow[fields[i]] = data[i];
            }

            dataTable.Rows.Add(dataRow);
            sqlAdapter.Update(dataTable);

            return "Record added";
        }

        public string AddRow(ref Control[] controls)
        {
            dataRow = null;
            dataRow = GetRow(ref controls);

            dataTable.Rows.Add(dataRow);
            sqlAdapter.Update(dataTable);

            return "Record added";
        }

        public string EditRow(string[] keys, ref Control[] controls)
        {
            DialogResult edit = MessageBox.Show("Do you want to update the record?", "Edit record", MessageBoxButtons.YesNo);

            if (edit == DialogResult.Yes)
            {
                DeleteRow(keys);
                AddRow(ref controls);
                return "Record Updated";
            }
            return "";
        }

        private DataRow GetRow(ref Control[] controls)
        {
            DataRow outputRow = dataTable.NewRow();

            for (int i = 0; i < fields.Length; i++)
            {
                outputRow[fields[i]] = controls[i].Text.ToString();
            }

            return outputRow;
        }

        public bool KeyInUse(string[] keys)
        {
            try
            {
                var temp = dataTable.Rows.Find(keys);

                if (temp == null) throw new Exception();

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

    }
}
