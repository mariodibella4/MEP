using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMEP
{
    public partial class Profile : BaseForm
    {
        protected int lastX = 0;
        protected int lastY = 0;
        protected string lastFilename = String.Empty;
        protected DragDropEffects effect;
        protected bool validData;
        protected Image image;
        protected Image nextImage;
        protected Thread getImageThread;
		private static string randomManager;
		private static string randomWorker;
		public static string RandomManager { get => randomManager; set => randomManager = value; }
		public static string RandomWorker { get => randomWorker; set => randomWorker = value; }

		public Profile()
        {
            InitializeComponent();
        }

		private delegate void AssignImageDlgt();

		protected void LoadImage()
		{
			nextImage = new Bitmap(lastFilename);
			this.Invoke(new AssignImageDlgt(AssignImage));
		}
		protected void AssignImage()
		{
			thumbnail.Width = 100;
			thumbnail.Height = nextImage.Height * 100 / nextImage.Width;
			SetThumbnailLocation(this.PointToClient(new Point(lastX, lastY)));
			thumbnail.Image = nextImage;
		}
		#region drag and drop Image
		private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
		{
			if (validData)
			{
				while (getImageThread.IsAlive)
				{
					Application.DoEvents();
					Thread.Sleep(0);
				}
				thumbnail.Visible = false;
				image = nextImage;
				AdjustView();
				if ((profilePictureBox.Image != null) && (profilePictureBox.Image != nextImage))
				{
					profilePictureBox.Image.Dispose();
				}
				profilePictureBox.Image = image;
				
			}
		}

		private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
		{
			string filename;
			validData = GetFilename(out filename, e);
			if (validData)
			{
				if (lastFilename != filename)
				{
					thumbnail.Image = null;
					thumbnail.Visible = false;
					lastFilename = filename;
					string ext = Path.GetExtension(filename).ToLower();
					File.Copy(lastFilename, Path.Combine(@"C:\Users\mario\source\repos\FinalProjectMEP\FinalProjectMEP\Images\","ProfilePic"+ext));
					getImageThread = new Thread(new ThreadStart(LoadImage));
					getImageThread.Start();
				}
				else
				{
					thumbnail.Visible = true;
				}
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void flowLayoutPanel1_DragLeave(object sender, EventArgs e)
		{
			thumbnail.Visible = false;
		}
		
       
		protected bool GetFilename(out string filename, DragEventArgs e)
		{
			bool ret = false;
			filename = String.Empty;

			if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
			{
				Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
				if (data != null)
				{
					if ((data.Length == 1) && (data.GetValue(0) is String))
					{
						filename = ((string[])data)[0];
						string ext = Path.GetExtension(filename).ToLower();
						if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
						{
							
							ret = true;
						}
					}
				}
			}
			return ret;
		}

		protected void SetThumbnailLocation(Point p)
		{
			if (thumbnail.Image == null)
			{
				thumbnail.Visible = false;
			}
			else
			{
				p.X -= thumbnail.Width / 2;
				p.Y -= thumbnail.Height / 2;
				thumbnail.Location = p;
				thumbnail.Visible = true;
			}
		}

		protected void AdjustView()
		{
			float fw = this.ClientSize.Width;
			float fh = this.ClientSize.Height;
			float iw = image.Width;
			float ih = image.Height;

			// iw/fw > ih/fh, then iw/fw controls ih

			float rw = fw / iw;         // ratio of width
			float rh = fh / ih;         // ratio of height

			if (rw < rh)
			{
				profilePictureBox.Width = (int)fw;
				profilePictureBox.Height = (int)(ih * rw);
				profilePictureBox.Left = thumbnail.Left;
				profilePictureBox.Top = (int)((fh - profilePictureBox.Height) / 2);
			}
			else
			{
				profilePictureBox.Width = (int)(iw * rh);
				profilePictureBox.Height = (int)fh;
				profilePictureBox.Left = (int)((fw - profilePictureBox.Width) / 2);
				profilePictureBox.Top = 0;
			}
		}

		protected override void OnLayout(LayoutEventArgs levent)
		{
			if (image != null)
			{
				AdjustView();
			}
		}


        #endregion drag and drop//
        
		

		private void meetingWorkerButton_Click(object sender, EventArgs e)
		{
			List<string> workers = new List<string>();
			for (int i = 0; i < Employee.Employees.Count; i++)
			{
				if (!Employee.Employees[i].EmployeePosition.Contains("Manager"))
				{
					workers.Add(Employee.Employees[i].EmployeeName);

				}
			}
			var random = new Random();
			int index = random.Next(workers.Count);
			RandomWorker = workers[index];
			WorkerInfo man = new WorkerInfo();
			man.ShowDialog();
		}
		Bitmap bitmap;
		private void button1_Click(object sender, EventArgs e)
		{
			Panel panel = new Panel();
			this.Controls.Add(panel);
			Graphics grp = panel.CreateGraphics();
			Size formSize = this.ClientSize;
			bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
			grp = Graphics.FromImage(bitmap);
			Point panelLocation = PointToScreen(panel.Location);
			grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.PrintPreviewControl.Zoom = 1;
			printPreviewDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bitmap,
					 (e.PageBounds.Width - bitmap.Width) / 2,
					 (e.PageBounds.Height - bitmap.Height) / 2,
					 bitmap.Width,
					 bitmap.Height);
		}
	}
}

  