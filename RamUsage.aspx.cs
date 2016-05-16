using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Microsoft.Office;
using System.Data.OleDb;
using System.Configuration;
using System.Text;
using System.Net.Mail;
using System.Drawing.Design;
using System.Web.UI.WebControls.WebParts;
using System.Drawing;

public partial class RamUsage : System.Web.UI.Page
{
    String dir3 = "";

   
    char[] delimiterChars = { ' ' };

    protected void Page_Load(object sender, EventArgs e)
    {
        ColorCoding();
    }
    private void ColorCoding()
    {
        dir3 = ConfigurationManager.AppSettings["Ramstats"];

        string[] subdirEntries = Directory.GetDirectories(dir3);
        foreach (string d in subdirEntries)
        {

            DirectoryInfo di = new DirectoryInfo(d);
            FileInfo[] f = di.GetFiles();
            DateTime lastWrite = DateTime.MinValue;
            FileInfo lastWritenFile = null;
            String diname = di.Name.ToString();
            foreach (FileInfo file in f)
            {
                //if (file.LastAccessTime < DateTime.Now.AddHours(-2))
                //{
                //    file.Delete();
                //}
                lastWritenFile = file;
                String ff = lastWritenFile.Name.ToString();
                String[] words = ff.Split(delimiterChars);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains("NORMAL") && diname.Equals("SAINS_SS"))
                    {

                        tab1.Rows[1].Cells[0].BackColor = Color.Green;
                        sains01.Text = words[i + 1];

                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("SAINS_SS"))
                    {

                        tab1.Rows[1].Cells[0].BackColor = Color.Red;
                        sains01.Text = words[i + 1];

                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("SAINS_SS"))
                    {

                        tab1.Rows[1].Cells[0].BackColor = Color.Yellow;
                        sains01.Text = words[i + 1];
                    }

                    else if (words[i].Contains("NORMAL") && diname.Equals("AEONT1"))
                    {

                        tab1.Rows[1].Cells[10].BackColor = Color.Green;
                        aeon01.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("AEONT1"))
                    {

                        tab1.Rows[1].Cells[10].BackColor = Color.Red;
                        aeon01.Text = words[i + 1];
                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("AEONT1"))
                    {
                        tab1.Rows[1].Cells[10].BackColor = Color.Yellow;
                        aeon01.Text = words[i + 1] ;

                    }

                    else if (words[i].Contains("NORMAL") && diname.Equals("ICA01"))
                    {
                        tab1.Rows[1].Cells[11].BackColor = Color.Green;
                        ica01.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("ICA01"))
                    {
                        ica01.Text = words[i + 1];

                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("ICA01"))
                    {
                        tab1.Rows[1].Cells[11].BackColor = Color.Yellow;
                        ica01.Text = words[i + 1];
                            
                    } 
                        else if (words[i].Contains("NORMAL") && diname.Equals("SONAE01"))
                        {
                            tab1.Rows[1].Cells[9].BackColor = Color.Green;
                            sonae01.Text = words[i + 1] ;


                        }

                        else if (words[i].Contains("CRITICAL") && diname.Equals("SONAE01"))
                        {
                            tab1.Rows[1].Cells[9].BackColor = Color.Red;
                            sonae01.Text = words[i + 1];
                        }
                        else if (words[i].Contains("WARNING") && diname.Equals("SONAE01"))
                        {
                            tab1.Rows[1].Cells[9].BackColor = Color.Yellow;
                            sonae01.Text = words[i + 1];
                        }
                    else if (words[i].Contains("NORMAL") && diname.Equals("SOBEYS01"))
                    {
                        tab1.Rows[1].Cells[5].BackColor = Color.Green;
                        sobeys01.Text = words[i + 1] ;
                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("SOBEYS01"))
                    {
                        tab1.Rows[1].Cells[5].BackColor = Color.Red;
                        sobeys01.Text = words[i + 1] ;
                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("SOBEYS01"))
                    {
                        tab1.Rows[1].Cells[5].BackColor = Color.Yellow;
                        sobeys01.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("SPARTAN01"))
                    {
                        tab1.Rows[1].Cells[7].BackColor = Color.Green;
                        spartan01.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("SPARTAN01"))
                    {
                        tab1.Rows[1].Cells[7].BackColor = Color.Red;
                        spartan01.Text = words[i + 1];


                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("SPARTAN01"))
                    {
                        tab1.Rows[1].Cells[7].BackColor = Color.Yellow;
                        spartan01.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("MIGROS01"))
                    {
                        tab1.Rows[1].Cells[8].BackColor = Color.Green;
                        migros01.Text = words[i + 1] ;

                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("MIGROS01"))
                    {
                        tab1.Rows[1].Cells[8].BackColor = Color.Red;
                        migros01.Text = words[i + 1];


                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("MIGROS01"))
                    {
                        tab1.Rows[1].Cells[8].BackColor = Color.Yellow;
                        migros01.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("SSL03_03"))
                    {
                        tab1.Rows[1].Cells[1].BackColor = Color.Green;
                        sains02.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("SSL03_03"))
                    {
                        tab1.Rows[1].Cells[1].BackColor = Color.Red;
                        sains02.Text = words[i + 1];

                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("SSL03_03"))
                    {
                        tab1.Rows[1].Cells[1].BackColor = Color.Yellow;
                        sains02.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("SSL04_04"))
                    {
                        tab1.Rows[1].Cells[2].BackColor = Color.Green;
                        sains03.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("SSL04_04"))
                    {
                        tab1.Rows[1].Cells[2].BackColor = Color.Red;
                        sains03.Text = words[i + 1];


                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("SSL04_04"))
                    {
                        tab1.Rows[1].Cells[2].BackColor = Color.Yellow;
                        sains03.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("MADISON01"))
                    {
                        tab1.Rows[1].Cells[6].BackColor = Color.Green;
                        madison01.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("MADISON01"))
                    {
                        tab1.Rows[1].Cells[6].BackColor = Color.Red;
                        madison01.Text = words[i + 1];


                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("MADISON01"))
                    {
                        tab1.Rows[1].Cells[6].BackColor = Color.Yellow;
                        madison01.Text = words[i + 1] ;

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("CVS02"))
                    {
                        tab1.Rows[1].Cells[4].BackColor = Color.Green;
                        cvs02.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("CVS02"))
                    {
                        tab1.Rows[1].Cells[4].BackColor = Color.Red;
                        cvs02.Text = words[i + 1];


                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("CVS02"))
                    {
                        tab1.Rows[1].Cells[4].BackColor = Color.Yellow;
                        cvs02.Text = words[i + 1];

                    }
                    else if (words[i].Contains("NORMAL") && diname.Equals("CVS01"))
                    {
                        tab1.Rows[1].Cells[3].BackColor = Color.Green;
                        cvs01.Text = words[i + 1];


                    }

                    else if (words[i].Contains("CRITICAL") && diname.Equals("CVS01"))
                    {
                        tab1.Rows[1].Cells[3].BackColor = Color.Red;
                        cvs01.Text = words[i + 1];



                    }
                    else if (words[i].Contains("WARNING") && diname.Equals("CVS01"))
                    {
                        tab1.Rows[1].Cells[3].BackColor = Color.Yellow;
                        cvs01.Text = words[i + 1] ;

                    }
                        
                    }

                }


            }
            

        }



    }



