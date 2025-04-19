namespace Laboration4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl1 = new TabControl();
            LagerPage = new TabPage();
            AddDeliveryButton = new Button();
            LagerTabTyp = new TabControl();
            tabPage1 = new TabPage();
            BokGridView = new DataGridView();
            BokID = new DataGridViewTextBoxColumn();
            ProduktNamn = new DataGridViewTextBoxColumn();
            Pris = new DataGridViewTextBoxColumn();
            Författare = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Format = new DataGridViewTextBoxColumn();
            Språk = new DataGridViewTextBoxColumn();
            BokLagerAntal = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            SpelGridView = new DataGridView();
            spelID = new DataGridViewTextBoxColumn();
            SpelNamn = new DataGridViewTextBoxColumn();
            SpelPris = new DataGridViewTextBoxColumn();
            SpelPlatform = new DataGridViewTextBoxColumn();
            SpelLagerAntal = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            FilmGridView = new DataGridView();
            FilmID = new DataGridViewTextBoxColumn();
            FilmNamn = new DataGridViewTextBoxColumn();
            FilmPris = new DataGridViewTextBoxColumn();
            FilmFormat = new DataGridViewTextBoxColumn();
            FilmSpeltid = new DataGridViewTextBoxColumn();
            FilmLagerAntal = new DataGridViewTextBoxColumn();
            LagerRemoveButton = new Button();
            LagerAddButton = new Button();
            KassaPage = new TabPage();
            TotalLabel = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            BetalaButton = new Button();
            RemoveKundKorgenButton = new Button();
            AddKundkorgenButton = new Button();
            KundKorgenKassa = new DataGridView();
            ProID = new DataGridViewTextBoxColumn();
            ProNamn = new DataGridViewTextBoxColumn();
            ProPris = new DataGridViewTextBoxColumn();
            ProduktListaKassa = new DataGridView();
            KassaID = new DataGridViewTextBoxColumn();
            KassaNamn = new DataGridViewTextBoxColumn();
            KassaPris = new DataGridViewTextBoxColumn();
            KassaLagerAntal = new DataGridViewTextBoxColumn();
            TabControl1.SuspendLayout();
            LagerPage.SuspendLayout();
            LagerTabTyp.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BokGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpelGridView).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilmGridView).BeginInit();
            KassaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KundKorgenKassa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProduktListaKassa).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(LagerPage);
            TabControl1.Controls.Add(KassaPage);
            TabControl1.Location = new Point(2, 4);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(949, 489);
            TabControl1.TabIndex = 0;
            // 
            // LagerPage
            // 
            LagerPage.Controls.Add(AddDeliveryButton);
            LagerPage.Controls.Add(LagerTabTyp);
            LagerPage.Controls.Add(LagerRemoveButton);
            LagerPage.Controls.Add(LagerAddButton);
            LagerPage.Location = new Point(4, 24);
            LagerPage.Name = "LagerPage";
            LagerPage.Padding = new Padding(3);
            LagerPage.Size = new Size(941, 461);
            LagerPage.TabIndex = 0;
            LagerPage.Text = "Lager";
            LagerPage.UseVisualStyleBackColor = true;
            // 
            // AddDeliveryButton
            // 
            AddDeliveryButton.Location = new Point(673, 387);
            AddDeliveryButton.Name = "AddDeliveryButton";
            AddDeliveryButton.Size = new Size(157, 53);
            AddDeliveryButton.TabIndex = 4;
            AddDeliveryButton.Text = "Lägg till leverans";
            AddDeliveryButton.UseVisualStyleBackColor = true;
            AddDeliveryButton.Click += AddDeliveryButton_Click;
            // 
            // LagerTabTyp
            // 
            LagerTabTyp.Controls.Add(tabPage1);
            LagerTabTyp.Controls.Add(tabPage2);
            LagerTabTyp.Controls.Add(tabPage3);
            LagerTabTyp.Location = new Point(3, 6);
            LagerTabTyp.Name = "LagerTabTyp";
            LagerTabTyp.SelectedIndex = 0;
            LagerTabTyp.Size = new Size(932, 375);
            LagerTabTyp.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BokGridView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(924, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bok";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BokGridView
            // 
            BokGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BokGridView.Columns.AddRange(new DataGridViewColumn[] { BokID, ProduktNamn, Pris, Författare, Genre, Format, Språk, BokLagerAntal });
            BokGridView.Location = new Point(0, 0);
            BokGridView.Name = "BokGridView";
            BokGridView.Size = new Size(921, 344);
            BokGridView.TabIndex = 0;
            // 
            // BokID
            // 
            BokID.HeaderText = "ID";
            BokID.Name = "BokID";
            // 
            // ProduktNamn
            // 
            ProduktNamn.HeaderText = "Namn";
            ProduktNamn.Name = "ProduktNamn";
            // 
            // Pris
            // 
            Pris.HeaderText = "Pris";
            Pris.Name = "Pris";
            // 
            // Författare
            // 
            Författare.HeaderText = "Författare";
            Författare.Name = "Författare";
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // Format
            // 
            Format.HeaderText = "Format";
            Format.Name = "Format";
            // 
            // Språk
            // 
            Språk.HeaderText = "Språk";
            Språk.Name = "Språk";
            // 
            // BokLagerAntal
            // 
            BokLagerAntal.HeaderText = "Lager Antal";
            BokLagerAntal.Name = "BokLagerAntal";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SpelGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(924, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dataspel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SpelGridView
            // 
            SpelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpelGridView.Columns.AddRange(new DataGridViewColumn[] { spelID, SpelNamn, SpelPris, SpelPlatform, SpelLagerAntal });
            SpelGridView.Location = new Point(0, 0);
            SpelGridView.Name = "SpelGridView";
            SpelGridView.Size = new Size(921, 344);
            SpelGridView.TabIndex = 0;
            // 
            // spelID
            // 
            spelID.HeaderText = "ID";
            spelID.Name = "spelID";
            // 
            // SpelNamn
            // 
            SpelNamn.HeaderText = "Namn";
            SpelNamn.Name = "SpelNamn";
            // 
            // SpelPris
            // 
            SpelPris.HeaderText = "Pris";
            SpelPris.Name = "SpelPris";
            // 
            // SpelPlatform
            // 
            SpelPlatform.HeaderText = "Platform";
            SpelPlatform.Name = "SpelPlatform";
            // 
            // SpelLagerAntal
            // 
            SpelLagerAntal.HeaderText = "Lager Antal";
            SpelLagerAntal.Name = "SpelLagerAntal";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(FilmGridView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(924, 347);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Film";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FilmGridView
            // 
            FilmGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilmGridView.Columns.AddRange(new DataGridViewColumn[] { FilmID, FilmNamn, FilmPris, FilmFormat, FilmSpeltid, FilmLagerAntal });
            FilmGridView.Location = new Point(0, 0);
            FilmGridView.Name = "FilmGridView";
            FilmGridView.Size = new Size(924, 347);
            FilmGridView.TabIndex = 0;
            // 
            // FilmID
            // 
            FilmID.HeaderText = "ID";
            FilmID.Name = "FilmID";
            // 
            // FilmNamn
            // 
            FilmNamn.HeaderText = "Namn";
            FilmNamn.Name = "FilmNamn";
            // 
            // FilmPris
            // 
            FilmPris.HeaderText = "Pris";
            FilmPris.Name = "FilmPris";
            // 
            // FilmFormat
            // 
            FilmFormat.HeaderText = "Format";
            FilmFormat.Name = "FilmFormat";
            // 
            // FilmSpeltid
            // 
            FilmSpeltid.HeaderText = "Speltid";
            FilmSpeltid.Name = "FilmSpeltid";
            // 
            // FilmLagerAntal
            // 
            FilmLagerAntal.HeaderText = "Lager Antal";
            FilmLagerAntal.Name = "FilmLagerAntal";
            // 
            // LagerRemoveButton
            // 
            LagerRemoveButton.Location = new Point(379, 387);
            LagerRemoveButton.Name = "LagerRemoveButton";
            LagerRemoveButton.Size = new Size(182, 53);
            LagerRemoveButton.TabIndex = 2;
            LagerRemoveButton.Text = "Ta bort produkt";
            LagerRemoveButton.UseVisualStyleBackColor = true;
            LagerRemoveButton.Click += LagerRemoveButton_Click;
            // 
            // LagerAddButton
            // 
            LagerAddButton.Location = new Point(72, 387);
            LagerAddButton.Name = "LagerAddButton";
            LagerAddButton.Size = new Size(182, 54);
            LagerAddButton.TabIndex = 1;
            LagerAddButton.Text = "Lägg till produkt";
            LagerAddButton.UseVisualStyleBackColor = true;
            LagerAddButton.Click += LagerAddButton_Click;
            // 
            // KassaPage
            // 
            KassaPage.Controls.Add(TotalLabel);
            KassaPage.Controls.Add(textBox2);
            KassaPage.Controls.Add(textBox1);
            KassaPage.Controls.Add(BetalaButton);
            KassaPage.Controls.Add(RemoveKundKorgenButton);
            KassaPage.Controls.Add(AddKundkorgenButton);
            KassaPage.Controls.Add(KundKorgenKassa);
            KassaPage.Controls.Add(ProduktListaKassa);
            KassaPage.Location = new Point(4, 24);
            KassaPage.Name = "KassaPage";
            KassaPage.Padding = new Padding(3);
            KassaPage.Size = new Size(941, 461);
            KassaPage.TabIndex = 1;
            KassaPage.Text = "Kassa";
            KassaPage.UseVisualStyleBackColor = true;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(593, 420);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(62, 30);
            TotalLabel.TabIndex = 7;
            TotalLabel.Text = "Total:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(593, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "Kundkorgen";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "ProduktLista";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // BetalaButton
            // 
            BetalaButton.Location = new Point(467, 257);
            BetalaButton.Name = "BetalaButton";
            BetalaButton.Size = new Size(111, 63);
            BetalaButton.TabIndex = 4;
            BetalaButton.Text = "Betala";
            BetalaButton.UseVisualStyleBackColor = true;
            BetalaButton.Click += BetalaButton_Click;
            // 
            // RemoveKundKorgenButton
            // 
            RemoveKundKorgenButton.Location = new Point(467, 149);
            RemoveKundKorgenButton.Name = "RemoveKundKorgenButton";
            RemoveKundKorgenButton.Size = new Size(111, 63);
            RemoveKundKorgenButton.TabIndex = 3;
            RemoveKundKorgenButton.Text = "Ta bort  i kundkorg";
            RemoveKundKorgenButton.UseVisualStyleBackColor = true;
            RemoveKundKorgenButton.Click += RemoveKundKorgenButton_Click;
            // 
            // AddKundkorgenButton
            // 
            AddKundkorgenButton.Location = new Point(467, 33);
            AddKundkorgenButton.Name = "AddKundkorgenButton";
            AddKundkorgenButton.Size = new Size(111, 63);
            AddKundkorgenButton.TabIndex = 2;
            AddKundkorgenButton.Text = "Lägg till i kundkorg";
            AddKundkorgenButton.UseVisualStyleBackColor = true;
            AddKundkorgenButton.Click += AddKundkorgenButton_Click;
            // 
            // KundKorgenKassa
            // 
            KundKorgenKassa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KundKorgenKassa.Columns.AddRange(new DataGridViewColumn[] { ProID, ProNamn, ProPris });
            KundKorgenKassa.Location = new Point(593, 33);
            KundKorgenKassa.Name = "KundKorgenKassa";
            KundKorgenKassa.Size = new Size(342, 374);
            KundKorgenKassa.TabIndex = 1;
            // 
            // ProID
            // 
            ProID.HeaderText = "ID";
            ProID.Name = "ProID";
            // 
            // ProNamn
            // 
            ProNamn.HeaderText = "Namn";
            ProNamn.Name = "ProNamn";
            // 
            // ProPris
            // 
            ProPris.HeaderText = "Pris";
            ProPris.Name = "ProPris";
            // 
            // ProduktListaKassa
            // 
            ProduktListaKassa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProduktListaKassa.Columns.AddRange(new DataGridViewColumn[] { KassaID, KassaNamn, KassaPris, KassaLagerAntal });
            ProduktListaKassa.Location = new Point(6, 33);
            ProduktListaKassa.Name = "ProduktListaKassa";
            ProduktListaKassa.Size = new Size(443, 428);
            ProduktListaKassa.TabIndex = 0;
            // 
            // KassaID
            // 
            KassaID.HeaderText = "ID";
            KassaID.Name = "KassaID";
            // 
            // KassaNamn
            // 
            KassaNamn.HeaderText = "Namn";
            KassaNamn.Name = "KassaNamn";
            // 
            // KassaPris
            // 
            KassaPris.HeaderText = "Pris";
            KassaPris.Name = "KassaPris";
            // 
            // KassaLagerAntal
            // 
            KassaLagerAntal.HeaderText = "Lager Antal";
            KassaLagerAntal.Name = "KassaLagerAntal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 492);
            Controls.Add(TabControl1);
            Name = "Form1";
            Text = "Form1";
            TabControl1.ResumeLayout(false);
            LagerPage.ResumeLayout(false);
            LagerTabTyp.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BokGridView).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpelGridView).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FilmGridView).EndInit();
            KassaPage.ResumeLayout(false);
            KassaPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KundKorgenKassa).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProduktListaKassa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl1;
        private TabPage LagerPage;
        private TabPage KassaPage;
        private Button LagerRemoveButton;
        private Button LagerAddButton;
        private TabControl LagerTabTyp;
        private TabPage tabPage1;
        private DataGridView BokGridView;
        private TabPage tabPage2;
        private DataGridView SpelGridView;
        private TabPage tabPage3;
        private DataGridViewTextBoxColumn BokID;
        private DataGridViewTextBoxColumn ProduktNamn;
        private DataGridViewTextBoxColumn Pris;
        private DataGridViewTextBoxColumn Författare;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Format;
        private DataGridViewTextBoxColumn Språk;
        private DataGridView FilmGridView;
        private DataGridView KundKorgenKassa;
        private DataGridViewTextBoxColumn ProID;
        private DataGridViewTextBoxColumn ProNamn;
        private DataGridViewTextBoxColumn ProPris;
        private DataGridView ProduktListaKassa;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button BetalaButton;
        private Button RemoveKundKorgenButton;
        private Button AddKundkorgenButton;
        private Label TotalLabel;
        private Button AddDeliveryButton;
        private DataGridViewTextBoxColumn BokLagerAntal;
        private DataGridViewTextBoxColumn spelID;
        private DataGridViewTextBoxColumn SpelNamn;
        private DataGridViewTextBoxColumn SpelPris;
        private DataGridViewTextBoxColumn SpelPlatform;
        private DataGridViewTextBoxColumn SpelLagerAntal;
        private DataGridViewTextBoxColumn FilmID;
        private DataGridViewTextBoxColumn FilmNamn;
        private DataGridViewTextBoxColumn FilmPris;
        private DataGridViewTextBoxColumn FilmFormat;
        private DataGridViewTextBoxColumn FilmSpeltid;
        private DataGridViewTextBoxColumn FilmLagerAntal;
        private DataGridViewTextBoxColumn KassaID;
        private DataGridViewTextBoxColumn KassaNamn;
        private DataGridViewTextBoxColumn KassaPris;
        private DataGridViewTextBoxColumn KassaLagerAntal;
    }
}
