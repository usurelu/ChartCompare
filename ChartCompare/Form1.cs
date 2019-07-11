using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ChartCompare
{
    public partial class Form1 : Form
    {
        TimeSpan delay = TimeSpan.FromSeconds(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadNoVPN_Click(object sender, EventArgs e)
        {
            if (openFileNoVPN.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    
                    labelFileNoVPN.Text = openFileNoVPN.SafeFileName;
                    List<string> ips = new List<string>();
                    StreamReader streamReader = new StreamReader(openFileNoVPN.FileName);

                    string line = "";
                    List<DateTime> xValues = new List<DateTime>();
                    List<int> yValues = new List<int>();
                    int result = 0;
                    if (!streamReader.EndOfStream)
                        line = streamReader.ReadLine();
                    TimeSpan time = TimeSpan.Parse(line.Split()[0]);
                    time = time - TimeSpan.FromTicks(time.Ticks % delay.Ticks);
                    TimeSpan startTime = time;
                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        if (line.Contains("length"))
                        {
                            if (TimeSpan.Parse(line.Split()[0]) < time + delay)
                            {
                                result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                            }
                            else
                            {
                                xValues.Add(DateTime.Today + time - startTime);
                                yValues.Add(result);
                                result = 0;
                                time += delay;
                                while (time + delay <= TimeSpan.Parse(line.Split()[0]))
                                {
                                    xValues.Add(DateTime.Today + time - startTime);
                                    yValues.Add(result);
                                    time += delay;
                                }
                                result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                            }
                        }
                    }

                    charIpLeft.Series[0].Points.Clear();
                    charIpLeft.Series[0].XValueType = ChartValueType.DateTime;
                    charIpLeft.Series[0].Points.DataBindXY(xValues, yValues);

                    chartNonVPN.Series[0].Points.Clear();
                    chartNonVPN.Series[0].XValueType = ChartValueType.DateTime;
                    chartNonVPN.Series[0].Points.DataBindXY(xValues, yValues);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private List<int> readFromFile(string openFileName)
        {
            try
            {
                StreamReader streamReader = new StreamReader(openFileName);

                string line = "";
                List<DateTime> xValues = new List<DateTime>();
                List<int> yValues = new List<int>();
                int result = 0;
                if (!streamReader.EndOfStream)
                    line = streamReader.ReadLine();
                TimeSpan time = TimeSpan.Parse(line.Split()[0]);
                time = time - TimeSpan.FromTicks(time.Ticks % delay.Ticks);
                TimeSpan startTime = time;
                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    if (line.Contains("length"))
                    {
                        if (TimeSpan.Parse(line.Split()[0]) < time + delay)
                        {
                            result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                        }
                        else
                        {
                            xValues.Add(DateTime.Today + time - startTime);
                            yValues.Add(result);
                            result = 0;
                            time += delay;
                            while (time + delay <= TimeSpan.Parse(line.Split()[0]))
                            {
                                xValues.Add(DateTime.Today + time - startTime);
                                yValues.Add(result);
                                time += delay;
                            }
                            result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                        }
                    }
                }
                return yValues;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private int[] convertListToArray(List<int> intList)
        {
            int[] resultArray = new int[intList.Count];
            for(int i=0; i<intList.Count; i++)
            {
                resultArray[i] = intList[i];
            }
            return resultArray;
        }

        private void btnUploadVPN_Click(object sender, EventArgs e)
        {
            if (openFileVPN.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //HTTP 
                    string httpFileName = @"L:\Dizertatie\Disertatie Data Collected\HTTP\DataWithoutVPN.txt";
                    List<int> valFromFile = readFromFile(httpFileName);
                    int[] http = convertListToArray(valFromFile);
                    //SSH
                    string sshFileName = @"L:\Dizertatie\Disertatie Data Collected\SSH\DataWithoutVPN.txt";
                    List<int> valFromFileSSH = readFromFile(sshFileName);
                    int[] ssh = convertListToArray(valFromFileSSH);
                    //torrent
                    string torrentFileName = @"L:\Dizertatie\Disertatie Data Collected\Torrente\DataWithoutVPN.txt";
                    List<int> valFromFileTorrent = readFromFile(torrentFileName);
                    int[] torrent = convertListToArray(valFromFileTorrent);
                    //int[] a = { 1, 2 };

                    labelFileVPN.Text = openFileVPN.SafeFileName;
                    List<string> ips = new List<string>();
                    StreamReader streamReader = new StreamReader(openFileVPN.FileName);

                    string line = "";
                    List<DateTime> xValues = new List<DateTime>();
                    List<int> yValues = new List<int>();
                    int result = 0;
                    if (!streamReader.EndOfStream)
                        line = streamReader.ReadLine();
                    TimeSpan time = TimeSpan.Parse(line.Split()[0]);
                    time = time - TimeSpan.FromTicks(time.Ticks % delay.Ticks);
                    TimeSpan startTime = time;
                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        if (line.Contains("length"))
                        {
                            if (TimeSpan.Parse(line.Split()[0]) < time + delay)
                            {
                                result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                            }
                            else
                            {
                                xValues.Add(DateTime.Today + time - startTime);
                                yValues.Add(result);
                                result = 0;
                                time += delay;
                                while (time + delay <= TimeSpan.Parse(line.Split()[0]))
                                {
                                    xValues.Add(DateTime.Today + time - startTime);
                                    yValues.Add(result);
                                    time += delay;
                                }
                                result = result + Int32.Parse(line.Substring(line.IndexOf("length") + 7).Split(':')[0]);
                            }
                        }
                    }

                    charIpLeft.Series[1].Points.Clear();
                    charIpLeft.Series[1].XValueType = ChartValueType.DateTime;
                    charIpLeft.Series[1].Points.DataBindXY(xValues, yValues);

                    chartVPN.Series[0].Points.Clear();
                    chartVPN.Series[0].XValueType = ChartValueType.DateTime;
                    chartVPN.Series[0].Points.DataBindXY(xValues, yValues);

                    // b=fisierul incarcat este cumparat cu HTTP, SSH, torrent 
                    //si dupa se compara costul minim si asa se stabileste
                    int[] fileLoadedForClassification = convertListToArray(yValues);
                    int minHttp = dynamicTimeWrapping(http, fileLoadedForClassification);
                    int minSSH = dynamicTimeWrapping(ssh, fileLoadedForClassification);
                    int minTorrent = dynamicTimeWrapping(torrent, fileLoadedForClassification);
                    int minrezultat;
                    string protocolName;
                    if (minHttp < minSSH)
                    {
                        minrezultat = minHttp;
                        protocolName = "HTTP";
                    }
                    else
                    {
                        minrezultat = minSSH;
                        protocolName = "SSH";
                    }

                    if (minrezultat < minTorrent)
                    {
                        minrezultat = minTorrent;
                        protocolName = "Torrent";
                    }
                    labelType.Text = protocolName;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void identificationOfVPNProtocol()
        {
        }
    
        private int dynamicTimeWrapping(int[] matriceA, int[] matriceB)
        {
            //int[] a = { 1, 3, 4, 9, 8, 2, 1, 5, 7, 3 };
            //int[] b = { 1, 6, 2, 3, 0, 9, 4, 3, 6, 3 };
            
            int[,] matrix = new int[matriceA.Length, matriceB.Length];
            int[,] transpusaMatrix = new int[matriceA.Length, matriceB.Length];
            int[] rezultat = new int[matriceA.Length + matriceB.Length];

            matrix[0, 0] = Math.Abs( matriceA[0] - matriceB[0] );
            int i, j;
            for (i=0; i< matriceA.Length; i++)
            {
                for (j = 0; j < matriceB.Length; j++)
                {
                    // pe prima linie 
                    if (i == 0)
                    {
                        if (j > 0)
                        {
                            matrix[i, j] = Math.Abs(matriceA[i] - matriceB[j]) + matrix[0, j - 1];
                        }
                    }

                    // pe prima coloana
                    else if (j == 0)
                    {
                        if (i > 0)
                        {
                            matrix[i, j] = Math.Abs(matriceA[i] - matriceB[j]) + matrix[i - 1, 0];
                        }
                    }
                    else {
                        if (i > 0 && j> 0) 
                            matrix[i, j] = Math.Abs(matriceA[i] - matriceB[j]) + Math.Min(Math.Min(matrix[i - 1, j - 1], matrix[i - 1, j]),matrix[i,j-1]);
                            }
                }
            }

            int contor = 0;
            int minCost = 0;
            int min, pozitiaI, pozitiaJ;
            rezultat[contor] = matrix[matriceA.Length-1,  matriceB.Length-1];
            i = matriceA.Length-1;
            j = matriceB.Length-1;
            while(i >0 && j>0)
                {

                    if ( matrix[i - 1,j - 1] < matrix[i,j-1] )
                    {
                        min = matrix[i - 1, j - 1];
                        pozitiaI = i - 1;
                        pozitiaJ = j - 1;
                    }
                    else
                    {
                        min = matrix[i, j - 1];
                        pozitiaI = i;
                        pozitiaJ = j - 1;
                    }

                    if (matrix[i - 1, j] < min)
                    {
                        min = matrix[i - 1, j];
                        pozitiaI = i - 1;
                        pozitiaJ = j;
                    }
                   
                    contor++;
                    rezultat[contor] = min;
                    minCost += min;
                    i = pozitiaI;
                    j = pozitiaJ;
                }
            return minCost;
        }

        /*private void cbIpLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVal = cbIpLeft.Text;
            string[] line;
            List<DateTime> xValues = new List<DateTime>();
            List<int> yValues = new List<int>();
            StreamReader streamReader = new StreamReader(mypath);
            TimeSpan time = TimeSpan.Parse("09:17:50");
            int result = 0;
            while (!streamReader.EndOfStream)
            {
                TimeSpan delay = TimeSpan.FromSeconds(5);

                
                line = streamReader.ReadLine().Split(' ');
                if (line.Length == 8 && line[2] == selectedVal)
                {
                    if (TimeSpan.Parse(line[0]) < time + delay)
                    {
                        result = result + Int32.Parse(line[7]);
                    }
                    else
                    {
                        xValues.Add(DateTime.ParseExact(line[0], "HH:mm:ss.ffffff", CultureInfo.CurrentCulture));
                        //yValues.Add(Int32.Parse(line[7]));
                        yValues.Add(result);
                        result = 0;
                        result = result + Int32.Parse(line[7]);
                        time = TimeSpan.Parse(line[0]);
                    }
                }

            }

            charIpLeft.Series[0].Points.Clear();
            charIpLeft.Series[0].XValueType = ChartValueType.DateTime;
            charIpLeft.Series[0].Points.DataBindXY(xValues, yValues);
        }

        private void cbIpRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVal = cbIpRight.Text;
            string[] line;
            List<DateTime> xValues = new List<DateTime>();
            List<int> yValues = new List<int>();
            StreamReader streamReader = new StreamReader(mypath);
            TimeSpan time = TimeSpan.Parse("09:17:50");
            int result = 0;
            while (!streamReader.EndOfStream)
            {
                TimeSpan delay = TimeSpan.FromSeconds(5);
                line = streamReader.ReadLine().Split(' ');
                if (line.Length == 8 && line[2] == selectedVal)
                {
                    if (TimeSpan.Parse(line[0]) < time + delay)
                    {
                        result = result + Int32.Parse(line[7]);
                    }
                    else
                    {
                        xValues.Add(DateTime.ParseExact(line[0], "HH:mm:ss.ffffff", CultureInfo.CurrentCulture));
                        yValues.Add(result);
                        result = 0;
                        result = result + Int32.Parse(line[7]);
                        time = TimeSpan.Parse(line[0]);
                    }
                }
            }
            charIpRight.Series[0].Points.Clear();
            charIpRight.Series[0].XValueType = ChartValueType.DateTime;
            charIpRight.Series[0].Points.DataBindXY(xValues, yValues);
        }*/
    }
}
