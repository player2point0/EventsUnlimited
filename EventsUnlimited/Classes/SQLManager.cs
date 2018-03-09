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
        //COULD REPLACE ALL COMPOSITE KEY METHODS WITH PRIMARY KEY METHODS

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

            ReadTable();
        }
        private void ReadTable()
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

                if(controls[i] is CheckBox)
                {
                    (controls[i] as CheckBox).Checked = bool.Parse(dataRow[table.Fields[i]].ToString());
                    continue;
                }

                controls[i].Text = dataRow[table.Fields[i]].ToString();
            }

            return "";
        }
        public void SetLastIndex(ref int index)
        {
            index = dataTable.Rows.Count - 1;
        }

        public string DeleteRow(string[] rowKey)
        {
            dataRow = dataTable.Rows.Find(rowKey);
            DataRow copy = dataRow;

            try
            {
                dataRow.Delete();
                sqlAdapter.Update(dataTable);
                return "Record deleted";
            }

            catch
            {
                MessageBox.Show("Can't delete record as it is used in another table");
                dataRow = copy;
                ReadTable();
                return "Not deleted";
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

                    num++;
                }
            }

            sqlAdapter.Update(dataTable);

            return num + " rows deleted";
        }

        public string AddRow(ref Control[] controls)
        {
            try
            {
                DataRow dr = GetRow(ref controls);

                dataTable.Rows.Add(dr);
                sqlAdapter.Update(dataTable);
            }

            catch(Exception e)
            {
                return e.ToString();
            }

            return "Record added";
        }
        public string AddRow(string[] values)
        {
            dataRow = dataTable.NewRow();

            for (int i = 0; i < table.Fields.Length; i++)
            {
                dataRow[table.Fields[i]] = values[i];
            }

            dataTable.Rows.Add(dataRow);
            sqlAdapter.Update(dataTable);

            return "Record added";
        }
        
        public DataRow GetRow(ref Control[] controls)
        {
            DataRow dr = dataTable.NewRow();
            
            for (int i = 0; i < table.Fields.Length; i++)
            {
                if (controls[i] is ValidationTextBox)
                {
                    dr[table.Fields[i]] = controls[i].ToString();
                }

                else if (controls[i] is CheckBox)
                {
                    bool val = (controls[i] as CheckBox).Checked;

                    if (val) dr[table.Fields[i]] = 1;

                    else dr[table.Fields[i]] = 0;
                }


                else if (controls[i] is ComboBox)
                {
                    Container c = (controls[i] as ComboBox).SelectedItem as Container;   

                    dr[table.Fields[i]] = c.Id;
                }

                else
                {
                    dr[table.Fields[i]] = controls[i].Text.ToString();
                }
            }

            return dr;
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
        public List<string> GetAllValues(string key, string keyCondition, string field)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];

                if (dataRow[key].ToString() == keyCondition)
                {
                    output.Add(dataRow[field].ToString());
                }
            }

            return output;
        }

        public string EditRow(string[] rowKeys, ref Control[] controls)
        {
            DialogResult edit = MessageBox.Show("Do you want to update the record?", "Edit record", MessageBoxButtons.YesNo);

            if (edit == DialogResult.Yes)
            {
                //LONG WINDED BUT ONLY WAY THAT WORKS
                DataRow dr = dataTable.Rows.Find(rowKeys);
                DataRow dr1 = GetRow(ref controls);

                for(int i=0;i<table.Fields.Length;i++)
                {
                    dr[table.Fields[i]] = dr1[table.Fields[i]];
                }

                sqlAdapter.Update(dataTable);

                return "Record Updated";
            }
            return "";
        }
        
        public int GenerateNewPrimaryKey()
        {
            List<int> primaryKeys = new List<int>();

            //GENERATE A LIST OF ALL PRIMARY KEYS IN USE
            foreach(DataRow dr in dataTable.Rows)
            {
                primaryKeys.Add((int)dr[table.PrimaryKeys[0]]);
            }
            //SORT KEYS 
            primaryKeys.Sort();
            //GENERATE NEW KEY BY ADDING ONE TO THE LARGEST KEY
            return (primaryKeys[primaryKeys.Count - 1] + 1); ;
        }

        public void PopulateComboBox(ref ComboBox display)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                var item = new Container(dr[table.PrimaryKeys[0]].ToString(), dr[table.Fields[1]].ToString());

                display.Items.Add(item);
            }
        }
  
        public bool Contains(string[] keys)
        {
            return !(dataTable.Rows.Find(keys) == null);
        }
    }
}