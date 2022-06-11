using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using Microsoft.ML;
using NLP.models;
using Microsoft.ML.Data;
using System.Text.RegularExpressions;
using NLPML.Model;

namespace NLP
{
    public partial class FormYouTubeApi : Form
    {
        public FormYouTubeApi()
        {
            InitializeComponent();
        }
        void Tokenizing()
        {
            var context = new MLContext();
            var emptydata = new List<TextData>();
            var data = context.Data.LoadFromEnumerable(emptydata);
            var tokenization = context.Transforms.Text.TokenizeIntoWords("Tokens", "Text", separators: new[] { ' ', '.' });
            var tokenModel = tokenization.Fit(data);
            var engine = context.Model.CreatePredictionEngine<TextData, TextTokens>(tokenModel);
            var tokens = engine.Predict(new TextData { Text = richTextBox1.Text });
            ShowTokens(tokens);
            richTextBox1.Text = richTextBox1.Text.ToLower();
        }
        void NGram()
        {
           
            var context = new MLContext();
            var emptydata = new List<TextData>();
            var data = context.Data.LoadFromEnumerable(emptydata);
            var tokenization = context.Transforms.Text.TokenizeIntoWords("Tokens", "Text", separators: new[] { '.' });
            var tokenModel = tokenization.Fit(data);
            var engine = context.Model.CreatePredictionEngine<TextData, TextTokens>(tokenModel);
            var tokens = engine.Predict(new TextData { Text = richTextBox1.Text });
            var cumleler = new List<InputNGram>();
            foreach (var cumle in tokens.Tokens)
            {
                cumleler.Add(new InputNGram { Text = cumle });


            }

            var dataView = context.Data.LoadFromEnumerable(cumleler);
            int ngramlength = (int)ngramNumber.Value;
            var nGramPipeline = context.Transforms.Text.TokenizeIntoWords("Tokens", nameof(InputNGram.Text))
                .Append(context.Transforms.Conversion.MapValueToKey("Tokens")
                .Append(context.Transforms.Text.ProduceNgrams(
                    "NGrams",
                    "Tokens",
                    ngramLength: ngramlength,
                    useAllLengths: false,
                    weighting: Microsoft.ML.Transforms.Text.NgramExtractingEstimator.WeightingCriteria.Tf)));

            var fitData = nGramPipeline.Fit(dataView);
            var dataTransformed = fitData.Transform(dataView);

            VBuffer<ReadOnlyMemory<char>> slotNames = default;
            dataTransformed.Schema["NGrams"].GetSlotNames(ref slotNames);

            var nGramsColumn = dataTransformed.GetColumn<VBuffer<float>>(dataTransformed.Schema["NGrams"]);
            var slots = slotNames.GetValues();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var row in nGramsColumn)
            {
                foreach (var item in row.Items())
                {

                    stringBuilder.Append(slots[item.Key]);
                    stringBuilder.AppendLine();

                }
                richTextBox2.Text = stringBuilder.ToString();

            }

        }
        void RemoveStopWords()
        {
            var separators = new[] { ' ', '.', ',', '!' };
            var context = new MLContext();
            var emptydata = new List<TextData>();
            var data = context.Data.LoadFromEnumerable(emptydata);
            var tokenization = context.Transforms.Text.TokenizeIntoWords("Tokens", "Text",
                separators: separators).Append(context.Transforms.Text.RemoveDefaultStopWords("Tokens","Tokens",
                Microsoft.ML.Transforms.Text.StopWordsRemovingEstimator.Language.English));
            var tokenModel = tokenization.Fit(data);
            var engine = context.Model.CreatePredictionEngine<TextData, TextTokens>(tokenModel);
            var text = engine.Predict(new TextData { Text = richTextBox1.Text.ToLower() });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in text.Tokens)
            {
                stringBuilder.Append(item);
                stringBuilder.Append(" ");
               
            }
            label7.Text = "RemoveStopWord";
            richTextBox2.Text = stringBuilder.ToString();
        }
        void ShowTokens(TextTokens tokens)
        {
            kelimelistesi.Rows.Clear();
            //Kelimelirem isimli bir dictonary oluşturuyoruz
            Dictionary<dynamic, int> kelimelerim = new Dictionary<dynamic, int>();
            //count isimli kelime sayıcı fnksiyonumuzu çağırıyoruz,
            kelimelerim = Count(tokens.Tokens);

            //fonksiyondan gelen kelimeler ve sayılarına göre sıraya sokuyoruz
            var items = from pair in kelimelerim
                        orderby pair.Value descending
                        select pair;
            //Toplam ve eşsiz kelimeleri form üzerindeki labellere yazdırıyorum.
            toplamKelime.Text = tokens.Tokens.Count().ToString();
            benzersizKelime.Text = items.Count().ToString();

            int x = tokens.Tokens.Count() - items.Count();

            int oran = 100 - ((100 * x) / tokens.Tokens.Count());
            kelimeOran.Text = "%" + oran;
           
            int y = tokens.Tokens.Count();
            foreach (KeyValuePair<dynamic, int> pair in items)
            {
                string kelime = pair.Key + " : " + pair.Value;
    
                kelimelistesi.Rows.Add(pair.Key, pair.Value);
            }

        }
        void getYoutubeComment()
        {
            YouTubeService tubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyDiG58KCHu_PVJVMh2Xdml_fC6bhd7tE7A",
            }
       );
            var request = tubeService.CommentThreads.List("snippet, replies");
            request.VideoId = textBox1.Text;

            var result = request.Execute();

            foreach (var item in result.Items)
            {
                listBox1.Items.Add(item.Snippet.TopLevelComment.Snippet.TextOriginal);
            }
        }
        private void FormYouTubeApi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            getYoutubeComment();
        }
        public static Dictionary<dynamic, int> Count(dynamic[] array)
        {

            Dictionary<dynamic, int> counts = new Dictionary<dynamic, int>();

            foreach (var item in array)
            {

                if (!counts.ContainsKey(item))
                {
                    counts.Add(item, 1);
                }
                else
                {
                    counts[item]++;
                }

            }

            return counts;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string result = Regex.Replace(listBox1.SelectedItem.ToString(), @"\p{Cs}", "");
            richTextBox1.Text =result;
        }
        public void renklendir(string kelime, Color renk, Boolean tamam)
        {

            /*
MatchCase	4	
Arama metninin yalnızca tam büyük/küçük harfe sahip örneklerini bulun.

NoHighlight	8	
Arama metni bulunursa vurgulanmamalıdır.

None	0	
Aramada bulunan örneklerin tam sözcük olup olmadığına bakılmaksızın, arama metninin tüm örneklerini bulun.

Reverse	16	
Arama, denetimin belgesinin sonunda başlar ve belgenin başına kadar arar.

WholeWord	2	
Arama metninin yalnızca tam sözcüklerden oluşan örneklerini bulun.
             */
            int start = 0;
            int end = richTextBox1.Text.LastIndexOf(kelime);
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            richTextBox1.Font = new Font("Arial", 14);
            while (start < end)
            {
                richTextBox1.Find(kelime.ToLower(), start, richTextBox1.TextLength, RichTextBoxFinds.WholeWord);
                richTextBox1.SelectionBackColor = Color.Yellow;
                start = richTextBox1.Text.IndexOf(kelime, start) + 1;
            }



        }
     
        void YorumTahmin()
        {
           
            ModelInput sampleData = new ModelInput()
            {
                SentimentText =richTextBox1.Text,
            };
            string sentiment = "";
          
            var predictionResult = ConsumeModel.Predict(sampleData);
       
            if (predictionResult.Prediction=="0")
            {
                sentiment = "OLUMSUZ";
            }
            else if (predictionResult.Prediction == "1")
            {
                sentiment = "OLUMLU";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("Yapılan Yorum:" + sentiment);
 
            richTextBox2.Text = sb.ToString() ;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Tokenizing();
        }
        private void kelimelistesi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                RichTextBox rtbTemp = new RichTextBox();
                rtbTemp.Text = richTextBox1.Text;
                richTextBox1.Rtf = rtbTemp.Rtf;
                string cell = "";
               
               

                if (kelimelistesi.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    cell = kelimelistesi.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                renklendir(cell, Color.Yellow, true);
                kelimelistesi.Rows[e.RowIndex].Selected = true;
                IDF_TF(e.RowIndex);
              
            }
        } 
       
        void IDF_TF(int index)
        {
           
            int df = 1;
            int N = listBox1.Items.Count;
            string kelime = kelimelistesi.Rows[index].Cells[0].Value.ToString();

            foreach (var item in listBox1.Items)
            {
                if (item.ToString().Contains(kelime))
                {
                    df++;
                }

            }
            int frekans = (int)kelimelistesi.Rows[index].Cells[1].Value;
            tf.Text = "TF:" + String.Format("{0:0.##}", Math.Log10(frekans + 1));
            double IDF = Math.Log10(N / df);
            idf.Text="IDF:"+ String.Format("{0:0.##}", IDF);
           double weight = Math.Log10(frekans + 1) * IDF;
           Wtf_idf.Text = "Wtf-idf:" + String.Format("{0:0.##}",weight);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YorumTahmin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveStopWords();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NGram();
        }

       
    }
}
