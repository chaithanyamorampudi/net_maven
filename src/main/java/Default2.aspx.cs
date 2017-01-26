using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        }
       

        // Total count of columns.
      

        // Add 3 columns.
       

        // Add data to the datatable.
        //dt.Rows.Add(new object[] { "EmpnSLNPame", "Required Docs" });
        //dt.Rows.Add(new object[] { "Austin", "Earnngs", "Amount" });
        //dt.Rows.Add(new object[] { "Austin", "df", "Amount" });
        //dt.Rows.Add(new object[] { "sdfsdf", "dsfdf", "df" });
        //dt.Rows.Add(new object[] { "Empdsfsdfname", "Earnngs", "df" });


        // Loop through each column in the DataTable and set the column name to the data in the first row of data.
       
        // Set the datasource of the grid.
        // this.GridView1.DataSource = dt;

        // Bind the data to the grid.
        // this.GridView1.DataBind();
    
    protected void Button1_Click(object sender, EventArgs e)
    {
DataTable dt = new DataTable();
        string s = string.Empty;
        int colCount = 0;
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            dt.Columns.Add(new DataColumn("col" + i.ToString()));

            if (CheckBoxList1.Items[i].Selected)
            {
                s += CheckBoxList1.Items[i].Value + ";";
                colCount++;
            

            dt.Rows.Add( "EmpnSLNPame", "Required Docs" );
            foreach (DataColumn dc in dt.Columns)
                {
                    dc.ColumnName = s;
                      }
            }
                
           
    }
}
}