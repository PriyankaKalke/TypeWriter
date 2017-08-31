using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TypeWriter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        
        protected void btnCompare_Click(object sender, EventArgs e)
        {
                TypewriterLogic tl = new TypewriterLogic();
                string[] input = txtInput.Text.Split(' ').ToArray();
                string[] output = txtOutput.Text.Split(' ').ToArray();

            List<KeyValuePair<string, int>> Difference = new List<KeyValuePair<string, int>>();

            Difference = tl.CompareData(input, output);

            foreach(var item in Difference)
            {
                string str = (item.Key == "" || item.Key == null) ? " " : item.Key;
                output[item.Value] = "<mark >" + str + "</mark>";
            }

            lbltext.Text = String.Join(" ", output);
            }
        }

    public class TypewriterLogic
    {
        public List<KeyValuePair<string, int>> CompareData(string[] input, string[] output)
        {
            List<string> expected = new List<string>();
            List<KeyValuePair<string, int>> diff = new List<KeyValuePair<string, int>>();
            int size = 0;
            if (input.Length >= output.Length)
            {
                size = output.Length;
            }
            else
            {
                size = input.Length;
                for (int i = size; i < output.Length; i++)
                {
                    diff.Add(new KeyValuePair<string, int>(output[i], i));
                }
            }

            for (int j = 0; j < size; j++)
            {
                expected.Add(input[j]);
                if (expected.Contains(output[j]))
                {
                    expected.Remove(output[j]);
                }
                else
                {
                    diff.Add(new KeyValuePair<string, int>(output[j], j));
                }
            }
            //diff.AddRange(expected);            
            return diff;

        }
    }
}