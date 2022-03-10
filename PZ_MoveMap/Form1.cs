using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PZ_MoveMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadMap_Click(object sender, EventArgs e)
        {
            var fbd = new FolderPicker();
            fbd.InputPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Zomboid\mods\");

            if (fbd.ShowDialog() == true && !string.IsNullOrWhiteSpace(fbd.ResultPath))
            {
                dgv_Cells.Rows.Clear();
                lbl_MapPath.Text = fbd.ResultPath + @"\";
                DirectoryInfo d = new DirectoryInfo(fbd.ResultPath);

                FileInfo[] Files = d.GetFiles("*.lotheader"); //Getting Text files

                foreach (FileInfo file in Files)
                {
                    string[] coord = Path.GetFileNameWithoutExtension(file.Name).Split(new Char[] { '_' });
                    this.dgv_Cells.Rows.Add(file.Name, int.Parse(coord[0]), int.Parse(coord[1]));
                }
                dgv_Cells.Sort(dgv_Cells.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                dgv_Cells.ClearSelection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Cells.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_Cells.RowHeadersVisible = false;
        }

        private void dgv_Cells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgv_Cells.CurrentCell != null)
            {
                foreach (DataGridViewRow row in dgv_Cells.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        tbx_Xold.Text = row.Cells[1].Value.ToString();
                        tbx_Yold.Text = row.Cells[2].Value.ToString();
                        num_Xnew.Value = int.Parse(tbx_Xold.Text);
                        num_Ynew.Value = int.Parse(tbx_Yold.Text);
                        btn_MoveMap.Enabled = true;
                    }
                }
            }
            else
            {
                btn_MoveMap.Enabled = false;
            }
        }

        private void num_Xnew_ValueChanged(object sender, EventArgs e)
        {
            int Xold = int.Parse(tbx_Xold.Text);
            int Xnew = (int)num_Xnew.Value;
            tbx_TargetX.Text = (Xnew - Xold).ToString();
        }

        private void num_Ynew_ValueChanged(object sender, EventArgs e)
        {
            int Yold = int.Parse(tbx_Yold.Text);
            int Ynew = (int)num_Ynew.Value;
            tbx_TargetY.Text = (Ynew - Yold).ToString();
        }

        public static string GetStringValueBetween(string input, string From, string To)
        {
            int pFrom = input.IndexOf(From) + From.Length;
            int pTo = input.LastIndexOf(To);

            String result = input.Substring(pFrom, pTo - pFrom);
            return result;
        }

        private void btn_MoveMap_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(lbl_MapPath.Text + @"\output");
            int XTarget = int.Parse(tbx_TargetX.Text);
            int YTarget = int.Parse(tbx_TargetY.Text);
            foreach (DataGridViewRow row in dgv_Cells.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int Xold = int.Parse(row.Cells[1].Value.ToString());
                    int Yold = int.Parse(row.Cells[2].Value.ToString());

                    int X = Xold + (XTarget);
                    int Y = Yold + (YTarget);
                    System.IO.File.Copy(lbl_MapPath.Text + @"\" + Xold.ToString() + "_" + Yold.ToString() + ".lotheader", lbl_MapPath.Text + @"\output\" + X.ToString() + "_" + Y.ToString() + ".lotheader", true);
                    System.IO.File.Copy(lbl_MapPath.Text + @"\chunkdata_" + Xold.ToString() + "_" + Yold.ToString() + ".bin", lbl_MapPath.Text + @"\output\chunkdata_" + X.ToString() + "_" + Y.ToString() + ".bin", true);
                    System.IO.File.Copy(lbl_MapPath.Text + @"\world_" + Xold.ToString() + "_" + Yold.ToString() + ".lotpack", lbl_MapPath.Text + @"\output\world_" + X.ToString() + "_" + Y.ToString() + ".lotpack", true);
                }
            }

            // objects.lua
            string objects_file = lbl_MapPath.Text + @"\objects.lua";
            string new_objects_file = lbl_MapPath.Text + @"\output\objects.lua";
            List<string> objects_lines = new List<string>();

            if (File.Exists(objects_file))
            {

                StreamReader Textfile = new StreamReader(objects_file);
                string line;


                while ((line = Textfile.ReadLine()) != null)
                {
                    int OldX = 0;
                    int OldY = 0;

                    if (line.Contains("x ="))
                    {
                        OldX = int.Parse(GetStringValueBetween(line, "x =", ", y").Trim());
                        OldY = int.Parse(GetStringValueBetween(line, "y =", ", z").Trim());
                    }

                    int NewX = OldX + (XTarget * 300);
                    int NewY = OldY + (YTarget * 300);

                    string NewString = line.Replace("x = " + OldX.ToString() + ", y = " + OldY.ToString() + ",", "x = " + NewX.ToString() + ", y = " + NewY.ToString() + ",");

                    objects_lines.Add(NewString);

                }

                File.WriteAllLines(new_objects_file, objects_lines);
            }

            // spawnpoints.lua
            string spawnpoints_file = lbl_MapPath.Text + @"\spawnpoints.lua";
            string new_spawnpoints_file = lbl_MapPath.Text + @"\output\spawnpoints.lua";
            List<string> spawnpoints_lines = new List<string>();

            if (File.Exists(spawnpoints_file))
            {

                StreamReader Textfile = new StreamReader(spawnpoints_file);
                string line;


                while ((line = Textfile.ReadLine()) != null)
                {
                    int OldX = 0;
                    int OldY = 0;

                    if (line.Contains("worldX"))
                    {
                        OldX = int.Parse(GetStringValueBetween(line, "worldX =", ", worldY").Trim());
                        OldY = int.Parse(GetStringValueBetween(line, "worldY =", ", posX").Trim());
                    }
                    int NewX = OldX + (XTarget);
                    int NewY = OldY + (YTarget);

                    string NewString = line.Replace("worldX = " + OldX.ToString() + ", worldY = " + OldY.ToString() + ",", "worldX = " + NewX.ToString() + ", worldY = " + NewY.ToString() + ",");

                    spawnpoints_lines.Add(NewString);

                }

                File.WriteAllLines(new_spawnpoints_file, spawnpoints_lines);
            }
            // spawnOrigins.lua
            string spawnOrigins_file = lbl_MapPath.Text + @"\spawnOrigins.lua";
            string new_spawnOrigins_file = lbl_MapPath.Text + @"\output\spawnOrigins.lua";
            List<string> spawnOrigins_lines = new List<string>();

            if (File.Exists(spawnOrigins_file))
            {

                StreamReader Textfile = new StreamReader(spawnOrigins_file);
                string line;


                while ((line = Textfile.ReadLine()) != null)
                {
                    int OldX = 0;
                    int OldY = 0;

                    if (line.Contains("worldX"))
                    {
                        OldX = int.Parse(GetStringValueBetween(line, "worldX =", ", worldY").Trim());
                        OldY = int.Parse(GetStringValueBetween(line, "worldY =", ", posX").Trim());
                    }
                    int NewX = OldX + (XTarget);
                    int NewY = OldY + (YTarget);

                    string NewString = line.Replace("worldX = " + OldX.ToString() + ", worldY = " + OldY.ToString() + ",", "worldX = " + NewX.ToString() + ", worldY = " + NewY.ToString() + ",");

                    spawnOrigins_lines.Add(NewString);

                }

                File.WriteAllLines(new_spawnOrigins_file, spawnOrigins_lines);
            }
            // worldmap.xml
            string worldmap_file = lbl_MapPath.Text + @"\worldmap.xml";
            string new_worldmap_file = lbl_MapPath.Text + @"\output\worldmap.xml";
            List<string> worldmap_lines = new List<string>();

            if (File.Exists(worldmap_file))
            {
                string text = File.ReadAllText(worldmap_file);
                text = text.Replace("x= \"", "x=\"");
                text = text.Replace("y= \"", "y=\"");
                File.WriteAllText(worldmap_file, text);

                StreamReader Textfile = new StreamReader(worldmap_file);
                string line;


                while ((line = Textfile.ReadLine()) != null)
                {
                    int OldX = 0;
                    int OldY = 0;

                    if (line.Contains("<cell"))
                    {
                        OldX = int.Parse(GetStringValueBetween(line, "<cell x=\"", "\" y=\"").Trim());
                        OldY = int.Parse(GetStringValueBetween(line, "\" y=\"", "\">").Trim());
                    }
                    int NewX = OldX + (XTarget);
                    int NewY = OldY + (YTarget);

                    string NewString = line.Replace("<cell x=\"" + OldX.ToString() + "\" y=\"" + OldY.ToString() + "\">", "<cell x=\"" + NewX.ToString() + "\" y=\"" + NewY.ToString() + "\">");

                    worldmap_lines.Add(NewString);

                }

                File.WriteAllLines(new_worldmap_file, worldmap_lines);
            }

            // worldmap-forest.xml
            string worldmapforest_file = lbl_MapPath.Text + @"\worldmap-forest.xml";
            string new_worldmapforest_file = lbl_MapPath.Text + @"\output\worldmap-forest.xml";
            List<string> worldmapforest_lines = new List<string>();

            if (File.Exists(worldmapforest_file))
            {
                string text = File.ReadAllText(worldmapforest_file);
                text = text.Replace("x= \"", "x=\"");
                text = text.Replace("y= \"", "y=\"");
                File.WriteAllText(worldmapforest_file, text);


                StreamReader Textfile = new StreamReader(worldmapforest_file);
                string line;


                while ((line = Textfile.ReadLine()) != null)
                {
                    int OldX = 0;
                    int OldY = 0;

                    if (line.Contains("<cell"))
                    {
                        line.Replace("x= \"", "x=\"");
                        line.Replace("y= \"", "y=\"");
                        OldX = int.Parse(GetStringValueBetween(line, "<cell x=\"", "\" y=\"").Trim());
                        OldY = int.Parse(GetStringValueBetween(line, "\" y=\"", "\">").Trim());
                    }
                    int NewX = OldX + (XTarget);
                    int NewY = OldY + (YTarget);

                    string NewString = line.Replace("<cell x=\"" + OldX.ToString() + "\" y=\"" + OldY.ToString() + "\">", "<cell x=\"" + NewX.ToString() + "\" y=\"" + NewY.ToString() + "\">");

                    worldmapforest_lines.Add(NewString);

                }

                File.WriteAllLines(new_worldmapforest_file, worldmapforest_lines);
            }

            System.Windows.MessageBox.Show("MOVED !");
            Process.Start(lbl_MapPath.Text + @"\output\");
        }
    }
}
