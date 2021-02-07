using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ForestControl.Model;
using ForestControl.Panel.Extensions;

namespace ForestControl.Panel
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnClick(object sender, EventArgs e)
		{
			var input = this.tbData.Text;
			if (string.IsNullOrEmpty(input)) return;

			try
            {
				var drones = GetDrones(input.Split(Environment.NewLine).RemoveWhiteSpaces().ToArray());
				var result = drones.Select(d => d.Move());

				var resultList = new StringBuilder();
				foreach (var item in result)
				{
					resultList.AppendLine(item != null ? item.ToString() : "Drone out of map!");
				}

				MessageBox.Show(resultList.ToString(), "Results");
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "Error");
            }
		}

		private List<Drone> GetDrones(string[] input)
		{
			var map = this.GetMap(input[0]);
			var list = new List<Drone>();
			for (int i = 1; i < input.Length; i=i+2)
			{
				var startPoint = i;
				var movements = i+1;

				list.Add(new Drone(map, input[startPoint], input[movements]));
			}
			return list;
		}

		private Map GetMap(string line) => new Map(line);
	}
}
