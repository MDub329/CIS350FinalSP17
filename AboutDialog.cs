/************************************************************/
/*                                                          */
/*  Course: CIS 350 -- Data Structures                      */
/*                                                          */
/*  Project: FinalSp17.CSProj                                */
/*                                                          */
/*  Source File: AboutDialog.CS                             */
/*                                                          */
/*  Programmer: Matt Wells                                  */
/*                                                          */
/*  Class: AboutDialog                                      */
/*                                                          */
/************************************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

// Begin partial namespace FinalSp17
namespace FinalSp17
{

  // Begin class AboutDialog
  public class AboutDialog : Form
  {
    private PictureBox picture1Box;
    private PictureBox picture2Box;
    private Label      label1;
    private Label      label3;
    private Label      label4;
    private Label      label5;
    private Label      label2;
    private Button     okButton;

    public AboutDialog()
    {
      InitializeComponent();
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      this.picture2Box = new System.Windows.Forms.PictureBox();
      this.okButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.picture1Box = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picture2Box)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picture1Box)).BeginInit();
      this.SuspendLayout();
      // 
      // picture2Box
      // 
      this.picture2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(45)))));
      this.picture2Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picture2Box.Image = global::FinalSp17.Properties.Resources.LionLogoNonTrans;
      this.picture2Box.Location = new System.Drawing.Point(449, 9);
      this.picture2Box.Name = "picture2Box";
      this.picture2Box.Size = new System.Drawing.Size(100, 100);
      this.picture2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picture2Box.TabIndex = 26;
      this.picture2Box.TabStop = false;
      // 
      // okButton
      // 
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.okButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.okButton.Location = new System.Drawing.Point(389, 15);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(44, 23);
      this.okButton.TabIndex = 22;
      this.okButton.Text = "OK";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Black;
      this.label5.Location = new System.Drawing.Point(111, 27);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(305, 20);
      this.label5.TabIndex = 25;
      this.label5.Text = "Computer Information Science Department";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Black;
      this.label4.Location = new System.Drawing.Point(111, 8);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(245, 20);
      this.label4.TabIndex = 24;
      this.label4.Text = "Missouri Southern State University";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Black;
      this.label3.Location = new System.Drawing.Point(111, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(283, 20);
      this.label3.TabIndex = 23;
      this.label3.Text = "CIS 350 – Data Structures";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(111, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(383, 20);
      this.label1.TabIndex = 20;
      this.label1.Text = "FinalSp17 – Generate a,b,c,d Patterns (Version 1.0)";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // picture1Box
      // 
      this.picture1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(189)))));
      this.picture1Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picture1Box.Image = global::FinalSp17.Properties.Resources.MSSULogoNonTrans;
      this.picture1Box.Location = new System.Drawing.Point(6, 9);
      this.picture1Box.Name = "picture1Box";
      this.picture1Box.Size = new System.Drawing.Size(100, 100);
      this.picture1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picture1Box.TabIndex = 19;
      this.picture1Box.TabStop = false;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(112, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(328, 18);
      this.label2.TabIndex = 27;
      this.label2.Text = "Copyright © 2017 · Matt Wells · All Rights Reserved";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // AboutDialog
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.CancelButton = this.okButton;
      this.ClientSize = new System.Drawing.Size(553, 115);
      this.ControlBox = false;
      this.Controls.Add(this.label2);
      this.Controls.Add(this.picture2Box);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.picture1Box);
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Location = new System.Drawing.Point(225, 150);
      this.MaximizeBox = false;
      this.Name = "AboutDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About FinalSp17";
      ((System.ComponentModel.ISupportInitialize)(this.picture2Box)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picture1Box)).EndInit();
      this.ResumeLayout(false);

    }
    #endregion

  } // End class AboutDialog

}  // End partial namespace FinalSp17
