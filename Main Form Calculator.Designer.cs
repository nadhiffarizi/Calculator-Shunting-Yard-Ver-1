namespace Calculator_Shunting_Yard_Ver_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBoxEquation = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TablePanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDoubleZero = new System.Windows.Forms.Button();
            this.ButtonAns = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.TablePanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxEquation
            // 
            this.TextBoxEquation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEquation.Location = new System.Drawing.Point(9, 17);
            this.TextBoxEquation.Name = "TextBoxEquation";
            this.TextBoxEquation.Size = new System.Drawing.Size(272, 26);
            this.TextBoxEquation.TabIndex = 0;
            this.TextBoxEquation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(8, 48);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(273, 32);
            this.LabelResult.TabIndex = 1;
            this.LabelResult.Text = "Result";
            // 
            // TablePanelButton
            // 
            this.TablePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelButton.ColumnCount = 4;
            this.TablePanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelButton.Controls.Add(this.ButtonDoubleZero, 0, 4);
            this.TablePanelButton.Controls.Add(this.ButtonAns, 0, 0);
            this.TablePanelButton.Controls.Add(this.ButtonEquals, 3, 4);
            this.TablePanelButton.Controls.Add(this.ButtonDot, 2, 4);
            this.TablePanelButton.Controls.Add(this.ButtonZero, 1, 4);
            this.TablePanelButton.Controls.Add(this.ButtonDivide, 3, 3);
            this.TablePanelButton.Controls.Add(this.ButtonThree, 2, 3);
            this.TablePanelButton.Controls.Add(this.ButtonTwo, 1, 3);
            this.TablePanelButton.Controls.Add(this.ButtonOne, 0, 3);
            this.TablePanelButton.Controls.Add(this.ButtonMinus, 3, 2);
            this.TablePanelButton.Controls.Add(this.ButtonSix, 2, 2);
            this.TablePanelButton.Controls.Add(this.ButtonFive, 1, 2);
            this.TablePanelButton.Controls.Add(this.ButtonFour, 0, 2);
            this.TablePanelButton.Controls.Add(this.ButtonMultiply, 3, 1);
            this.TablePanelButton.Controls.Add(this.ButtonNine, 2, 1);
            this.TablePanelButton.Controls.Add(this.ButtonEight, 1, 1);
            this.TablePanelButton.Controls.Add(this.ButtonSeven, 0, 1);
            this.TablePanelButton.Controls.Add(this.ButtonPlus, 3, 0);
            this.TablePanelButton.Controls.Add(this.ButtonDelete, 2, 0);
            this.TablePanelButton.Controls.Add(this.ButtonCE, 1, 0);
            this.TablePanelButton.Location = new System.Drawing.Point(8, 80);
            this.TablePanelButton.Name = "TablePanelButton";
            this.TablePanelButton.RowCount = 5;
            this.TablePanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanelButton.Size = new System.Drawing.Size(279, 224);
            this.TablePanelButton.TabIndex = 2;
            // 
            // ButtonDoubleZero
            // 
            this.ButtonDoubleZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDoubleZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDoubleZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDoubleZero.Location = new System.Drawing.Point(3, 179);
            this.ButtonDoubleZero.Name = "ButtonDoubleZero";
            this.ButtonDoubleZero.Size = new System.Drawing.Size(63, 42);
            this.ButtonDoubleZero.TabIndex = 21;
            this.ButtonDoubleZero.Text = "00";
            this.ButtonDoubleZero.UseVisualStyleBackColor = true;
            this.ButtonDoubleZero.Click += new System.EventHandler(this.ButtonDoubleZero_Click);
            // 
            // ButtonAns
            // 
            this.ButtonAns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAns.Location = new System.Drawing.Point(3, 3);
            this.ButtonAns.Name = "ButtonAns";
            this.ButtonAns.Size = new System.Drawing.Size(63, 38);
            this.ButtonAns.TabIndex = 20;
            this.ButtonAns.Text = "ANS";
            this.ButtonAns.UseVisualStyleBackColor = true;
            this.ButtonAns.Click += new System.EventHandler(this.ButtonANS_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.Location = new System.Drawing.Point(210, 179);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(66, 42);
            this.ButtonEquals.TabIndex = 19;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDot.Location = new System.Drawing.Point(141, 179);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(63, 42);
            this.ButtonDot.TabIndex = 18;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZero.Location = new System.Drawing.Point(72, 179);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(63, 42);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivide.Location = new System.Drawing.Point(210, 135);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(66, 38);
            this.ButtonDivide.TabIndex = 15;
            this.ButtonDivide.Text = "÷ ";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThree.Location = new System.Drawing.Point(141, 135);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(63, 38);
            this.ButtonThree.TabIndex = 14;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTwo.Location = new System.Drawing.Point(72, 135);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(63, 38);
            this.ButtonTwo.TabIndex = 13;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 135);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(63, 38);
            this.ButtonOne.TabIndex = 12;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinus.Location = new System.Drawing.Point(210, 91);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(66, 38);
            this.ButtonMinus.TabIndex = 11;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSix.Location = new System.Drawing.Point(141, 91);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(63, 38);
            this.ButtonSix.TabIndex = 10;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFive.Location = new System.Drawing.Point(72, 91);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(63, 38);
            this.ButtonFive.TabIndex = 9;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 91);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(63, 38);
            this.ButtonFour.TabIndex = 8;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiply.Location = new System.Drawing.Point(210, 47);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(66, 38);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "x";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiple_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNine.Location = new System.Drawing.Point(141, 47);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(63, 38);
            this.ButtonNine.TabIndex = 6;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEight.Location = new System.Drawing.Point(72, 47);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(63, 38);
            this.ButtonEight.TabIndex = 5;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 47);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(63, 38);
            this.ButtonSeven.TabIndex = 4;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(210, 3);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(66, 38);
            this.ButtonPlus.TabIndex = 3;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(141, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(63, 38);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "DEL";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCE.Location = new System.Drawing.Point(72, 3);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(63, 38);
            this.ButtonCE.TabIndex = 0;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 318);
            this.Controls.Add(this.TablePanelButton);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.TextBoxEquation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(311, 357);
            this.MinimumSize = new System.Drawing.Size(311, 357);
            this.Name = "MainForm";
            this.Text = "Nadhif\'s Calculator";
            this.TablePanelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEquation;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TableLayoutPanel TablePanelButton;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAns;
        private System.Windows.Forms.Button ButtonDoubleZero;
    }
}

