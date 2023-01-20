using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp.Common;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class FormConfig : Form
    {
        public List<DictPair> ListKamus { get; set; }


        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkSlot.Text.Trim()))
            {
                MessageBox.Show("Please Input number.");
                return;
            }
            try
            {
                Convert.ToInt32(txtParkSlot.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Input number.");
                return;
            }
            CommonConstant.UpdateParkAppSettings(txtParkSlot.Text.Trim());

            MessageBox.Show(string.Format("Value Saved.. Created a parking lot with {0} slots", CommonConstant.TotalParkSlot));
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            txtParkSlot.Text = CommonConstant.TotalParkSlot.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public IList<IList<int>> Subsets(int[] nums)
        {
            //write your solution here
            IList<IList<int>> result = new List<IList<int>>();

            //result.Add(null);
            //int iIndex = 0;
            //int iIndexLater = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    iIndex = i;

            //    if (!result.Contains(new List<int>(nums[i])))
            //        result.Add(new List<int>(nums[i]));


            //    iIndexLater = iIndex + 1;
            //    if (!result.Contains(new List<int>(nums[i])) && iIndexLater<nums.Length)
            //        result.Add(new List<int>(nums[i], nums[iIndexLater]));

            //}

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //JObject jo = JObject.Parse("");
            //JsonValue value = JsonValue.Parse(@"{ ""name"":""Prince Charming"", ...");
            //JsonObject result = value as JsonObject;
            //var array = JArray.Parse(""); 
            //array.SelectTokens("[?(@.value == 'N/A')]").ToList().ForEach(i => i.Remove());

            //array.ToString
            MessageBox.Show("" + hitungNomorBit(13, 2));
        }


        int? hitungNomorBit(int angka, int nomorBit)
        {

            string sInput = angka.ToString();
            try
            {
                char chars = sInput[nomorBit];
                if (chars == null)
                    return chars;
                else
                    return Convert.ToInt32(chars);
            }
            catch (Exception)
            {
                return null;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var result = cariKata("italy");


            MessageBox.Show("Selesai");
            Console.WriteLine(JsonConvert.SerializeObject(result));

        }
        public List<(int, int)> cariKata(string kata)
        {
            List<char[]> papan = new List<char[]>();
            papan.Add(new char[] { 'J', 'Y', 'B', 'Y', 'Q', 'V', 'W', 'G', 'B', 'Q', 'F', 'D', 'D', 'U', 'L', 'H', 'M' });
            papan.Add(new char[] { 'D', 'G', 'O', 'C', 'G', 'V', 'N', 'K', 'Z', 'C', 'R', 'U', 'B', 'A', 'O', 'I', 'K' });
            papan.Add(new char[] { 'U', 'G', 'E', 'U', 'H', 'E', 'W', 'J', 'W', 'T', 'O', 'Y', 'N', 'U', 'M', 'N', 'V' });
            papan.Add(new char[] { 'N', 'H', 'U', 'R', 'D', 'B', 'R', 'J', 'I', 'V', 'U', 'I', 'T', 'P', 'G', 'H', 'W' });
            papan.Add(new char[] { 'I', 'H', 'H', 'O', 'O', 'I', 'E', 'M', 'Z', 'W', 'T', 'J', 'M', 'D', 'T', 'S', 'V' });
            papan.Add(new char[] { 'T', 'M', 'V', 'O', 'I', 'P', 'O', 'U', 'A', 'N', 'B', 'E', 'D', 'X', 'T', 'W', 'X' });
            papan.Add(new char[] { 'E', 'Z', 'H', 'B', 'B', 'Q', 'A', 'U', 'E', 'N', 'W', 'C', 'W', 'C', 'B', 'O', 'N' });
            papan.Add(new char[] { 'D', 'L', 'U', 'S', 'A', 'D', 'F', 'G', 'N', 'R', 'Y', 'Y', 'G', 'W', 'W', 'S', 'R' });
            papan.Add(new char[] { 'K', 'H', 'Y', 'I', 'I', 'R', 'R', 'M', 'N', 'I', 'P', 'H', 'A', 'B', 'R', 'W', 'P' });
            papan.Add(new char[] { 'I', 'T', 'Q', 'M', 'S', 'A', 'H', 'I', 'M', 'I', 'R', 'U', 'N', 'Z', 'Y', 'H', 'S' });
            papan.Add(new char[] { 'N', 'E', 'T', 'H', 'E', 'R', 'L', 'A', 'N', 'D', 'S', 'H', 'U', 'N', 'K', 'E', 'Z' });
            papan.Add(new char[] { 'G', 'F', 'K', 'L', 'N', 'L', 'A', 'G', 'U', 'T', 'R', 'O', 'P', 'B', 'I', 'U', 'E' });
            papan.Add(new char[] { 'D', 'C', 'P', 'G', 'O', 'G', 'G', 'A', 'R', 'U', 'P', 'U', 'E', 'O', 'P', 'K', 'M' });
            papan.Add(new char[] { 'O', 'J', 'B', 'T', 'D', 'N', 'T', 'A', 'X', 'O', 'B', 'X', 'Z', 'M', 'J', 'C', 'C' });
            papan.Add(new char[] { 'M', 'J', 'F', 'P', 'N', 'S', 'L', 'L', 'X', 'B', 'V', 'C', 'Y', 'W', 'T', 'K', 'E' });
            papan.Add(new char[] { 'R', 'X', 'I', 'S', 'I', 'I', 'Z', 'W', 'A', 'M', 'K', 'S', 'L', 'N', 'H', 'V', 'S' });
            papan.Add(new char[] { 'A', 'O', 'J', 'O', 'A', 'E', 'G', 'T', 'X', 'M', 'C', 'Z', 'P', 'C', 'I', 'O', 'U' });

            // Silakan selesaikan method ini
            List<(int, int)> result = new List<(int, int)>();


            //Hoorizontal
            for (int i = 0; i < papan.Count(); i++)
            {
                var current = papan.ElementAt(i);

                for (int j = 0; j < current.Length; j++)
                {
                    List<(int, int)> currentProgress = new List<(int, int)>();
                    bool equal = char.ToUpperInvariant(current[j]) == char.ToUpperInvariant(kata[0]);

                    if (equal)
                    {
                        for (int kataSearch = 0; kataSearch < kata.Length; kataSearch++)
                        {
                            if (current.Length - (j + kata.Length) <= 0)
                                goto REPEATV;

                            equal = char.ToUpperInvariant(current[j + kataSearch]) == char.ToUpperInvariant(kata[kataSearch]);

                            if (equal)
                            {

                                currentProgress.Add((i, j));
                                if (kata.Length - 1 == kataSearch)
                                    return currentProgress;
                            }
                        }
                    }
                }
            REPEATV:
                Console.WriteLine("continue Vertical");
            }



            //Vertical
            int iMaxLength = papan.ElementAt(0).Length;

            for (int j = 0; j < iMaxLength; j++)
            {
                List<(int, int)> currentProgress = new List<(int, int)>();
                for (int i = 0; i < papan.Count(); i++)
                {
                    for (int iKataSearch = 0; iKataSearch < kata.Length; iKataSearch++)
                    {
                        if (papan.Count - (i + kata.Length) <= 0)
                            goto REPEATH;

                        bool equal = char.ToUpperInvariant(papan.ElementAt(i)[j]) == char.ToUpperInvariant(kata[iKataSearch]);
                        if (equal)
                        {

                            currentProgress.Add((i, j));

                            //if reach max length return search result
                            if (kata.Length - 1 == iKataSearch)
                                goto REPEATH;
                        }
                    }
                }
            REPEATH:
                Console.WriteLine("continue Horizontal");
            }

            //Diagonal
            for (int j = 0; j < iMaxLength; j++)
            {
                List<(int, int)> currentProgress = new List<(int, int)>();
                for (int i = 0; i < papan.Count(); i++)
                {

                    bool equal = char.ToUpperInvariant(papan.ElementAt(i)[j]) == char.ToUpperInvariant(kata[0]);

                    //if reach max length return search result
                    if (equal)
                    {
                        currentProgress = new List<(int, int)>();

                        for (int iKataSearch = 0; iKataSearch < kata.Length; iKataSearch++)
                        {
                            if (papan.Count - (i + kata.Length) <= 0)
                                goto REPEATD;
                            if (iMaxLength - (j + kata.Length) <= 0)
                                goto REPEATD;

                            equal = char.ToUpperInvariant(papan.ElementAt(i + iKataSearch)[j + iKataSearch]) == char.ToUpperInvariant(kata[iKataSearch]);
                            if (equal)
                            {
                                currentProgress.Add((j + iKataSearch, i + iKataSearch));

                                if (kata.Length - 1 == iKataSearch)
                                    return currentProgress;
                            }
                        }
                    }
                }
            REPEATD:
                Console.WriteLine("continue Horizontal");
            }

            return result;
        }

        #region Kamus
        public void Tambah(string kata, List<string> sinonim)
        {
            if (ListKamus == null)
                ListKamus = new List<DictPair>();

            DictPair newItem = new DictPair();
            newItem.Key = kata;
            newItem.Synonim = sinonim;
            ListKamus.Add(newItem);
        }

        public List<string> ambilSinonim(string kata)
        {
            List<string> result = new List<string>();

            var listKeys = ListKamus.Where(x => GetStringCheckToUpper(x.Key).Equals(GetStringCheckToUpper(kata))).ToList();
            foreach (var item in listKeys)
            {
                result = JoinList(result, item.Synonim);
            }


            var listDictSyn = ListKamus.Where(x => x.Synonim.Contains(kata)).ToList();

            foreach (var item in listDictSyn)
            {
                result.Add(item.Key);
            }

            return result;
        }
        public String GetStringCheckToUpper(String oParam)
        {
            return string.IsNullOrWhiteSpace(oParam) ? "" : oParam.ToUpper().Trim();
        }


        public List<string> JoinList(List<string> first, List<string> second)
        {
            if (first == null)
            {
                return second;
            }
            if (second == null)
            {
                return first;
            }

            return first.Concat(second).ToList();
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            Tambah("big", new List<string>() { "large", "great" });
            Tambah("big", new List<string>() { "huge", "fat" });
            Tambah("huge", new List<string>() { "enormous", "gigantic" });

            var kamus = ambilSinonim("big");
            var kamus2 = ambilSinonim("huge");
            var kamus3 = ambilSinonim("gigantic");
            var kamus4 = ambilSinonim("colossal");
            Console.WriteLine("Ok");
        }
    }
}
