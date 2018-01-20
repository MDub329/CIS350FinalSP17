/************************************************************/
/*                                                          */
/*  Course: CIS 350 -- Data Structures                      */
/*                                                          */
/*  Project: FinalSp17.CSPrj                                 */
/*                                                          */
/*  Program: FinalSp17.CS                                    */
/*                                                          */
/*  Programmer: Matt Wells                                   */
/*                                                          */
/*  Purpose: A forms-based application start point.         */
/*                                                          */
/*  Classes: 1. FinalSp17Form : Form                         */
/*           2. FinalSp17App                                 */
/*                                                          */
/************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using LibGArrayList;

/***************************************************************/
/*  Begin namespace FinalSp17                                   */
/***************************************************************/
namespace FinalSp17
{

  /***************************************************************/
  /*  1. Begin main form class FinalSp17Form : Form               */
  /***************************************************************/  
  public class FinalSp17Form : Form
  {
    private Label elapsedTimeDisplay;
    private Label label10;
    private Label percentProcessedDisplay;
    private Label label8;
    private Label possibleCallsDisplay;
    private Label label6;
    private Label recursiveCallsDisplay;
    private Label label4;
    private Label patternLengthDisplay;
    private Label label2;
    private Label patternCountDisplay;
    private Button cancelButton;
    private Button generateButton;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem1;
    private NumericUpDown cCount;
    private NumericUpDown dCount;
    private NumericUpDown aCount;
    private NumericUpDown bCount;
    private Label label1;
    private Label label5;
    private Label label7;
    private Label label9;
    private System.ComponentModel.BackgroundWorker bgWorker;
    private Timer timer;
    private System.ComponentModel.IContainer components;
    private DataGridView dgv;
    private Label label3;
    private BindingList<IDObject> idBindingList = new BindingList<IDObject>();
    private int patternLength, patternCount, numOfRecurCalls, index;
    private int numOfA, numOfB, numOfC, numOfD;
    private int reqNumOfA, reqNumOfB, reqNumOfC, reqNumOfD;
    private GArrayList<char> pattern = new GArrayList<char>();
    private double elapsedTime;
    private DataGridViewTextBoxColumn indexColumn;
    private DataGridViewTextBoxColumn patternColumn;
    private bool bgWorkerCancelled;
    private ulong n;


    public FinalSp17Form()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalSp17Form));
      this.elapsedTimeDisplay = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.percentProcessedDisplay = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.possibleCallsDisplay = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.recursiveCallsDisplay = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.patternLengthDisplay = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.patternCountDisplay = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cancelButton = new System.Windows.Forms.Button();
      this.generateButton = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.cCount = new System.Windows.Forms.NumericUpDown();
      this.dCount = new System.Windows.Forms.NumericUpDown();
      this.aCount = new System.Windows.Forms.NumericUpDown();
      this.bCount = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.bgWorker = new System.ComponentModel.BackgroundWorker();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.dgv = new System.Windows.Forms.DataGridView();
      this.indexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.patternColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // elapsedTimeDisplay
      // 
      this.elapsedTimeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.elapsedTimeDisplay.Location = new System.Drawing.Point(397, 284);
      this.elapsedTimeDisplay.Name = "elapsedTimeDisplay";
      this.elapsedTimeDisplay.Size = new System.Drawing.Size(124, 23);
      this.elapsedTimeDisplay.TabIndex = 27;
      this.elapsedTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label10
      // 
      this.label10.Location = new System.Drawing.Point(397, 260);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(126, 24);
      this.label10.TabIndex = 26;
      this.label10.Text = "Elapsed Time";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // percentProcessedDisplay
      // 
      this.percentProcessedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.percentProcessedDisplay.Location = new System.Drawing.Point(267, 284);
      this.percentProcessedDisplay.Name = "percentProcessedDisplay";
      this.percentProcessedDisplay.Size = new System.Drawing.Size(124, 23);
      this.percentProcessedDisplay.TabIndex = 25;
      this.percentProcessedDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(267, 260);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(126, 24);
      this.label8.TabIndex = 24;
      this.label8.Text = "Percent Processed";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // possibleCallsDisplay
      // 
      this.possibleCallsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.possibleCallsDisplay.Location = new System.Drawing.Point(397, 226);
      this.possibleCallsDisplay.Name = "possibleCallsDisplay";
      this.possibleCallsDisplay.Size = new System.Drawing.Size(124, 23);
      this.possibleCallsDisplay.TabIndex = 23;
      this.possibleCallsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(397, 202);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(126, 24);
      this.label6.TabIndex = 22;
      this.label6.Text = "Possible Calls";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // recursiveCallsDisplay
      // 
      this.recursiveCallsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.recursiveCallsDisplay.Location = new System.Drawing.Point(270, 226);
      this.recursiveCallsDisplay.Name = "recursiveCallsDisplay";
      this.recursiveCallsDisplay.Size = new System.Drawing.Size(124, 23);
      this.recursiveCallsDisplay.TabIndex = 21;
      this.recursiveCallsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(270, 202);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(126, 24);
      this.label4.TabIndex = 20;
      this.label4.Text = "Recursive Calls";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // patternLengthDisplay
      // 
      this.patternLengthDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.patternLengthDisplay.Location = new System.Drawing.Point(267, 179);
      this.patternLengthDisplay.Name = "patternLengthDisplay";
      this.patternLengthDisplay.Size = new System.Drawing.Size(124, 23);
      this.patternLengthDisplay.TabIndex = 29;
      this.patternLengthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(267, 155);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(126, 24);
      this.label2.TabIndex = 28;
      this.label2.Text = "Pattern Length";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // patternCountDisplay
      // 
      this.patternCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.patternCountDisplay.Location = new System.Drawing.Point(400, 179);
      this.patternCountDisplay.Name = "patternCountDisplay";
      this.patternCountDisplay.Size = new System.Drawing.Size(124, 23);
      this.patternCountDisplay.TabIndex = 31;
      this.patternCountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(400, 155);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(126, 24);
      this.label3.TabIndex = 30;
      this.label3.Text = "Pattern Count";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.LightCoral;
      this.cancelButton.ForeColor = System.Drawing.Color.Black;
      this.cancelButton.Location = new System.Drawing.Point(473, 354);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 22);
      this.cancelButton.TabIndex = 33;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = false;
      this.cancelButton.Visible = false;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // generateButton
      // 
      this.generateButton.Location = new System.Drawing.Point(358, 330);
      this.generateButton.Name = "generateButton";
      this.generateButton.Size = new System.Drawing.Size(75, 22);
      this.generateButton.TabIndex = 32;
      this.generateButton.Text = "Generate";
      this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
      this.generateButton.MouseEnter += new System.EventHandler(this.MouseEnter);
      this.generateButton.MouseLeave += new System.EventHandler(this.MouseLeave);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(560, 24);
      this.menuStrip1.TabIndex = 34;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
      this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // helpToolStripMenuItem1
      // 
      this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
      this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.helpToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
      this.helpToolStripMenuItem1.Text = "About...";
      this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
      // 
      // cCount
      // 
      this.cCount.Location = new System.Drawing.Point(300, 116);
      this.cCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.cCount.Name = "cCount";
      this.cCount.Size = new System.Drawing.Size(48, 23);
      this.cCount.TabIndex = 35;
      this.cCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.cCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.cCount.ValueChanged += new System.EventHandler(this.ValueChanged);
      // 
      // dCount
      // 
      this.dCount.Location = new System.Drawing.Point(429, 116);
      this.dCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.dCount.Name = "dCount";
      this.dCount.Size = new System.Drawing.Size(48, 23);
      this.dCount.TabIndex = 36;
      this.dCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.dCount.ValueChanged += new System.EventHandler(this.ValueChanged);
      // 
      // aCount
      // 
      this.aCount.Location = new System.Drawing.Point(300, 59);
      this.aCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.aCount.Name = "aCount";
      this.aCount.Size = new System.Drawing.Size(48, 23);
      this.aCount.TabIndex = 37;
      this.aCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.aCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.aCount.ValueChanged += new System.EventHandler(this.ValueChanged);
      // 
      // bCount
      // 
      this.bCount.Location = new System.Drawing.Point(429, 59);
      this.bCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.bCount.Name = "bCount";
      this.bCount.Size = new System.Drawing.Size(48, 23);
      this.bCount.TabIndex = 38;
      this.bCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.bCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.bCount.ValueChanged += new System.EventHandler(this.ValueChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(264, 89);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 24);
      this.label1.TabIndex = 39;
      this.label1.Text = "\'c\' Count";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(396, 89);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(126, 24);
      this.label5.TabIndex = 40;
      this.label5.Text = "\'d\' Count";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(264, 36);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(126, 20);
      this.label7.TabIndex = 41;
      this.label7.Text = "\'a\' Count";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(400, 32);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(126, 24);
      this.label9.TabIndex = 42;
      this.label9.Text = "\'b\' Count";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // bgWorker
      // 
      this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
      // 
      // timer
      // 
      this.timer.Interval = 1000;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexColumn,
            this.patternColumn});
      this.dgv.Location = new System.Drawing.Point(13, 32);
      this.dgv.Name = "dgv";
      this.dgv.RowHeadersVisible = false;
      this.dgv.Size = new System.Drawing.Size(203, 374);
      this.dgv.TabIndex = 43;
      // 
      // indexColumn
      // 
      this.indexColumn.HeaderText = "Index";
      this.indexColumn.Name = "indexColumn";
      this.indexColumn.Width = 73;
      // 
      // patternColumn
      // 
      this.patternColumn.HeaderText = "Patterns";
      this.patternColumn.Name = "patternColumn";
      this.patternColumn.Width = 110;
      // 
      // FinalSp17Form
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(560, 420);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bCount);
      this.Controls.Add(this.aCount);
      this.Controls.Add(this.dCount);
      this.Controls.Add(this.cCount);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.generateButton);
      this.Controls.Add(this.patternCountDisplay);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.patternLengthDisplay);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.elapsedTimeDisplay);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.percentProcessedDisplay);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.possibleCallsDisplay);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.recursiveCallsDisplay);
      this.Controls.Add(this.label4);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(50, 300);
      this.MaximizeBox = false;
      this.Name = "FinalSp17Form";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FinalSp17 - Generate a,b,c,d Patterns";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinalSp17Form_FormClosing);
      this.Load += new System.EventHandler(this.FinalSp17Form_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion


    private void FinalSp17Form_Load(object sender, EventArgs e)
    {
      cancelButton.Location = generateButton.Location;
    }

    private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AboutDialog aboutDialog = new AboutDialog();

      aboutDialog.ShowDialog(this);
    }

    private void ValueChanged(object sender, EventArgs e)
    {
      bgWorkerCancelled = true;
      Initialize();
    }

    private void MouseEnter(object sender, EventArgs e)
    {
      ((Button)sender).BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
    }
    private void MouseLeave(object sender, EventArgs e)
    {
      ((Button)sender).BackColor = System.Drawing.SystemColors.Control;
    }
    private void FinalSp17Form_FormClosing(object sender, FormClosingEventArgs e)
    {
      bgWorkerCancelled = true;
    }
    private void cancelButton_Click(object sender, EventArgs e)
    {
      bgWorkerCancelled = true;
      Initialize();
    }
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void generateButton_Click(object sender, EventArgs e)
    {
      DateTime startDateTime;
      TimeSpan timeSpan;

      generateButton.Visible = false;
      cancelButton.Visible = true;
      Initialize();
      patternLengthDisplay.Text = patternLength.ToString();
      ulong possibleCalls = (ulong)(Math.Pow(n, patternLength + 1) - 1) / (n - 1);
      possibleCallsDisplay.Text = possibleCalls.ToString("n0");     
      elapsedTime = 0.0;
      elapsedTimeDisplay.Text = elapsedTime.ToString("n3");
      startDateTime = DateTime.Now;
      timer.Enabled = true;
      bgWorker.RunWorkerAsync();
      while (bgWorker.IsBusy)
        Application.DoEvents();
      timer.Enabled = false;
      timeSpan = DateTime.Now - startDateTime;
      elapsedTime = timeSpan.Hours * 3600.0 + timeSpan.Minutes * 60.0 + timeSpan.Seconds * 1.0 +
                      timeSpan.Milliseconds / 1000.0;
      if (!bgWorkerCancelled)
      {
        DisplayResults();
      }
      else
      {
        dgv.Rows.Clear();
      }
      generateButton.Visible = true;
      cancelButton.Visible = false;
    }

    private void Initialize()
    {
      index = 0;
      numOfRecurCalls = 0;
      numOfA = 0; numOfB = 0; numOfC = 0; numOfD = 0;
      patternCount = 0;
      n = 0;
      recursiveCallsDisplay.Text = "";
      percentProcessedDisplay.Text = "";
      possibleCallsDisplay.Text = "";
      elapsedTimeDisplay.Text = "";
      patternCountDisplay.Text = "";
      patternLengthDisplay.Text = "";
      if (aCount.Value > 0)
        n++;
      if (bCount.Value > 0)
        n++;
      if (cCount.Value > 0)
        n++;
      if (dCount.Value > 0)
        n++;
      reqNumOfA = (int) aCount.Value;
      reqNumOfB = (int) bCount.Value;
      reqNumOfC = (int) cCount.Value;
      reqNumOfD = (int) dCount.Value;
      idBindingList.Clear();
      dgv.DataSource = null;
      patternLength = reqNumOfA + reqNumOfB + reqNumOfC + reqNumOfD;
      pattern.Clear();
      for (int i = 1; i <= patternLength; i++)
        pattern.Add((char)0);
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      ulong possibleCalls;
      double percent;

      elapsedTime++;
      possibleCalls = (ulong)(Math.Pow(n, patternLength + 1) - 1) / (n-1);
      percent = 100.0 * numOfRecurCalls / possibleCalls;
      recursiveCallsDisplay.Text = numOfRecurCalls.ToString("n0");
      percentProcessedDisplay.Text = percent.ToString("n2") + "%";
      elapsedTimeDisplay.Text = elapsedTime.ToString("f3") + " sec";
      patternCountDisplay.Text = patternCount.ToString("n0");
    }

    private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      bgWorkerCancelled = false;
      GenPatterns(1);
    }

    private void GenPatterns(int position)
    {
      numOfRecurCalls++;
      if(!bgWorkerCancelled)
      {
        if (position == patternLength + 1)
        {
          patternCount++;
          string patternString = "";
          foreach (Char ch in pattern)
            patternString += ch;
          idBindingList.Add(new IDObject(++index, patternString));
        }
        else
        {
          if (numOfA < reqNumOfA)
          {
            pattern[position] = 'a';
            numOfA++;
            GenPatterns(position + 1);
            numOfA--;
          }
          if (numOfB < reqNumOfB)
          {
            pattern[position] = 'b';
            numOfB++;
            GenPatterns(position + 1);
            numOfB--;
          }
          if (numOfC < reqNumOfC)
          {
            pattern[position] = 'c';
            numOfC++;
            GenPatterns(position + 1);
            numOfC--;
          }
          if (numOfD < reqNumOfD)
          {
            pattern[position] = 'd';
            numOfD++;
            GenPatterns(position + 1);
            numOfD--;
          }
        }
      }
    }

    private void DisplayResults()
    {
      ulong possibleCalls;
      double percent;

      possibleCalls = (ulong)(Math.Pow(n, patternLength + 1) - 1) / (n - 1);
      percent = 100.0 * numOfRecurCalls / possibleCalls;
      recursiveCallsDisplay.Text = numOfRecurCalls.ToString("n0");
      percentProcessedDisplay.Text = percent.ToString("n2") + "%";      
      elapsedTimeDisplay.Text = elapsedTime.ToString("f3") + " sec";
      patternCountDisplay.Text = patternCount.ToString("n0");
      dgv.Columns.Clear();
      dgv.DataSource = idBindingList;      
      dgv.Columns[0].Width = 73;
      dgv.Columns[1].Width = 110;
      dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dgv.Columns[0].DefaultCellStyle.Format = "n0";
    }
  } // End class FinalSp17Form

  /***************************************************************/
  /*  2. Begin application class FinalSp17App                     */
  /***************************************************************/
  public class FinalSp17App
  {
    // The application entry point
    static void Main()
    {
      Application.Run(new FinalSp17Form());
    }
  } // End application class FinalSp17App


  /**********************************************************/
  /*  3. Class IDObject                                     */
  /**********************************************************/
  public class IDObject
  {
    private int index;
    private string id;

    public IDObject(int indexValue, string idValue)
    {
      this.Index = indexValue;
      this.Pattern = idValue;
    }

    public int Index
    {
      get
      {
        return this.index;
      }
      set
      {
        this.index = value;
      }
    }

    public string Pattern
    {
      get
      {
        return this.id;
      }
      set
      {
        this.id = value;
      }
    }
  }
} // End namespace FinalSp17

