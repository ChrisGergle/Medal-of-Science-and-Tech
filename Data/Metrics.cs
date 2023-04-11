using System.Collections;
using System.Data;
using System.IO;


namespace bsMOTS.Data
{
    public class MetricReader
    {
        public DataTable clicktable;
        public DataTable timespent;
        public float idleTime;
        

        public DataTable BuildClickTable(DataTable t, string name)
        {
            t = new DataTable(name);

            DataColumn c;
            DataRow r;
            r = t.NewRow();

            // Set ID
            c = new DataColumn();
            c.DataType = typeof(int);
            c.ColumnName = "ID";
            c.AutoIncrement = true;
            c.ReadOnly = false;
            c.Unique= true;
            t.Columns.Add(c);
            //r auto increments

            // Checks for navigational key presses
            c = new DataColumn();
            c.DataType = typeof(bool);
            c.ColumnName = "IsProfile";
            c.Unique = false;
            c.ReadOnly = false;
            t.Columns.Add(c);
            r["IsProfile"] = false;

            // Set which medal
            c = new DataColumn();
            c.DataType = typeof(string);
            c.ColumnName = "MedalType";
            c.ReadOnly = false;
            c.Unique = false;
            t.Columns.Add(c);
            r["MedalType"] = "TestData";

            
            c = new DataColumn();
            c.ColumnName = "Name";
            c.ReadOnly = false;
            c.Unique = false;
            c.DataType = typeof(string);
            t.Columns.Add(c);
            r["Name"] = "TestRow";

            c = new DataColumn();
            c.DataType= typeof(DateTime);
            c.ColumnName = "TimeStamp";
            c.ReadOnly = false;
            c.Unique = false;
            t.Columns.Add(c);
            r["TimeStamp"] = DateTime.Now;
            //
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = t.Columns["ID"];
            t.PrimaryKey= PrimaryKey;

            return t;
        }



        


    }
}
