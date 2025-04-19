using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic; //används för att kunna använda Interaction.InputBox

namespace Laboration4
{
    public partial class Form1 : Form
    {
        private List<Produkt> allaProdukter = new List<Produkt>();
        private List<Produkt> kundkorg = new List<Produkt>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProductsFromCSV();
            MessageBox.Show("CSV loaded!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProductsToCSV();
        }

        private void LoadProductsFromCSV()
        {
            string filePath = Path.Combine(Application.StartupPath, @"..\..\..\produkter.csv");

            if (!File.Exists(filePath)) return;

            foreach (var row in File.ReadAllLines(filePath).Skip(1))
            {
                try
                {
                    var parts = row.Split(',');
                    if (parts.Length < 4) continue;

                    string typ = parts[0];
                    string id = parts[1];
                    string namn = parts[2];
                    decimal pris = decimal.Parse(parts[3]);
                    int lagerAntal = parts.Length > 8 && int.TryParse(parts[8], out var la) ? la : 0; // Hämta antal i lager från CSV, annars sätt till 0

                    if (typ == "Bok")
                    {
                        var bok = new Bok
                        {
                            ID = id,
                            Namn = namn,
                            Pris = pris,
                            LagerAntal = lagerAntal,
                            Författare = parts[4],
                            Genre = parts[5],
                            Format = parts[6],
                            Språk = parts[7]
                        };
                        allaProdukter.Add(bok);
                        BokGridView.Rows.Add(id, namn, pris, bok.Författare, bok.Genre, bok.Format, bok.Språk, bok.LagerAntal);
                    }
                    else if (typ == "Spel")
                    {
                        var spel = new Spel
                        {
                            ID = id,
                            Namn = namn,
                            Pris = pris,
                            LagerAntal = lagerAntal,
                            Plattform = parts[4]
                        };
                        allaProdukter.Add(spel);
                        SpelGridView.Rows.Add(id, namn, pris, spel.Plattform, spel.LagerAntal);
                    }
                    else if (typ == "Film")
                    {
                        var film = new Film
                        {
                            ID = id,
                            Namn = namn,
                            Pris = pris,
                            LagerAntal = lagerAntal,
                            Format = parts[4],
                            Speltid = parts[5]
                        };
                        allaProdukter.Add(film);
                        FilmGridView.Rows.Add(id, namn, pris, film.Format, film.Speltid, film.LagerAntal);
                    }

                    HighlightEmptyCells(BokGridView); //markera tomma grids
                    HighlightEmptyCells(SpelGridView);
                    HighlightEmptyCells(FilmGridView);

                    // Always add to kassa lista
                    ProduktListaKassa.Rows.Add(id, namn, pris, lagerAntal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fel på rad: " + row + "\n\n" + ex.Message);
                }
            }
        }
        //Sparar produkterna till CSV
        private void SaveProductsToCSV()
        {
            string filePath = Path.Combine(Application.StartupPath, @"..\..\..\produkter.csv");


            var lines = new List<string>
    {
        "Typ,ID,Namn,Pris,Extra1,Extra2,Extra3,Extra4,LagerAntal" 
    };

            foreach (var produkt in allaProdukter)
            {
                lines.Add(produkt.ToCSV());
            }

            File.WriteAllLines(filePath, lines);
        }

       
        //Lägg till produkter till kundkorgen (knapp)
        private void AddKundkorgenButton_Click(object sender, EventArgs e)
        {
            if (ProduktListaKassa.CurrentRow != null)
            {
                // ?.ToString() används för att programmet ska inte krasha om det ör null
                string id = ProduktListaKassa.CurrentRow.Cells[0].Value?.ToString() ?? ""; //Hämta ID från valda raden
                string namn = ProduktListaKassa.CurrentRow.Cells[1].Value?.ToString() ?? ""; //Hämta namn
                decimal pris = Convert.ToDecimal(ProduktListaKassa.CurrentRow.Cells[2].Value); //Hämta priset

                // Find the actual produkt from allaProdukter
                var produkt = allaProdukter.FirstOrDefault(p => p.ID == id); // Hitta den första produkten i listan där ID matchar det angivna ID:t, annars returnera null
                if (produkt == null)
                {
                    MessageBox.Show("Produkten kunde inte hittas.");
                    return;
                }

                if (produkt.LagerAntal <= 0)
                {
                    MessageBox.Show("Produkten finns inte i lager.");
                    return;
                }

                // Add to cart and decrease LagerAntal
                kundkorg.Add(produkt);
                produkt.LagerAntal--;

                KundKorgenKassa.Rows.Add(id, namn, pris);

                // Update the Lager tab to reflect new stock
                UpdateLagerGridRow(produkt);
                UpdateTotal();
            }
        } 
        private void UpdateTotal()
        {
            decimal total = kundkorg.Sum(p => p.Pris); //Summera alla pris
            TotalLabel.Text = $"Total: {total} kr";
        }

        //tar bort produkter från kundkorgen (knapp)
        private void RemoveKundKorgenButton_Click(object sender, EventArgs e)
        {
            if (KundKorgenKassa.CurrentRow != null)
            {
                int index = KundKorgenKassa.CurrentRow.Index;
                if (index >= 0 && index < kundkorg.Count)// Hämta index för den markerade raden i kundkorgen (DataGridView)
                                                         // och kontrollera att det är ett giltigt index inom listan 'kundkorg'
                {
                    var produkt = kundkorg[index];

                    // tar bort från kundkorgen
                    kundkorg.RemoveAt(index);
                    KundKorgenKassa.Rows.RemoveAt(index);

                    // Höja stock antal
                    produkt.LagerAntal++;
                    UpdateLagerGridRow(produkt);

                    UpdateTotal();
                }
            }
        }

        //betala knappen

        private void BetalaButton_Click(object sender, EventArgs e)
        {
            if (kundkorg.Count == 0)
            {
                MessageBox.Show("Kundkorgen är tom.");
                return;
            }

            // Clear korgen och uppdatera total label
            kundkorg.Clear();
            KundKorgenKassa.Rows.Clear();
            UpdateTotal();
            MessageBox.Show("Köp genomfört!");
        }
        
        //Lägg Till knappen i Lager page
        private void LagerAddButton_Click(object sender, EventArgs e)
        {
            // Typen på produkten måste vara Bok, Spel eller Film
            string typ = "";
            while (typ != "Bok" && typ != "Spel" && typ != "Film")
            {
                typ = Interaction.InputBox("Produktens typ (Bok, Spel eller Film):", "Ny produkt").Trim();
                if (typ != "Bok" && typ != "Spel" && typ != "Film")
                    MessageBox.Show("Ogiltig typ. Du måste skriva Bok, Spel eller Film.");
            }

            // Unikt ID
            string id = "";
            while (true)
            {
                id = Interaction.InputBox("ID (t.ex. B1, S3, F2):", "Ny produkt").Trim();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("ID får inte vara tomt.");
                    continue;
                }

                if (allaProdukter.Any(p => p.ID == id))
                {
                    MessageBox.Show("Det finns redan en produkt med detta ID.");
                    continue;
                }

                // Rätt format är oblgatorisk exempelvis, B7 eller S8
                if ((typ == "Bok" && !(id.StartsWith("B") && id.Length > 1 && id.Substring(1).All(char.IsDigit))) ||
                    (typ == "Spel" && !(id.StartsWith("S") && id.Length > 1 && id.Substring(1).All(char.IsDigit))) ||
                    (typ == "Film" && !(id.StartsWith("F") && id.Length > 1 && id.Substring(1).All(char.IsDigit))))
                {
                    MessageBox.Show($"ID:t måste börja med '{typ[0]}' och följas av siffror. T.ex. B1, S2, F3.");
                    continue;
                }

                break;
            }

            // Inga siffror eller whitespace
            string namn = "";
            while (true)
            {
                namn = Interaction.InputBox("Namn:", "Ny produkt").Trim();
                if (string.IsNullOrWhiteSpace(namn) || namn.Any(char.IsDigit))
                {
                    MessageBox.Show("Namnet får inte vara tomt eller innehålla siffror.");
                }
                else
                {
                    break;
                }
            }

            // Pris
            decimal pris = 0;
            while (true)
            {
                string prisStr = Interaction.InputBox("Pris:", "Ny produkt").Trim();
                if (!decimal.TryParse(prisStr, out pris) || pris < 0)
                {
                    MessageBox.Show("Ogiltigt pris.");
                }
                else
                {
                    break;
                }
            }

            // beroende på vald typ
            if (typ == "Bok")
            {
                string författare = Interaction.InputBox("Författare:", "Ny bok");
                string genre = Interaction.InputBox("Genre:", "Ny bok");
                string format = Interaction.InputBox("Format:", "Ny bok");
                string språk = Interaction.InputBox("Språk:", "Ny bok");

                var bok = new Bok
                {
                    ID = id,
                    Namn = namn,
                    Pris = pris,
                    Författare = författare,
                    Genre = genre,
                    Format = format,
                    Språk = språk
                };

                allaProdukter.Add(bok);
                BokGridView.Rows.Add(id, namn, pris, författare, genre, format, språk, bok.LagerAntal);
                ProduktListaKassa.Rows.Add(id, namn, pris, bok.LagerAntal);
            }
            else if (typ == "Spel")
            {
                string plattform = Interaction.InputBox("Plattform:", "Nytt spel");

                var spel = new Spel
                {
                    ID = id,
                    Namn = namn,
                    Pris = pris,
                    Plattform = plattform
                };

                allaProdukter.Add(spel);
                SpelGridView.Rows.Add(id, namn, pris, plattform, spel.LagerAntal);
                ProduktListaKassa.Rows.Add(id, namn, pris, spel.LagerAntal);
            }
            else if (typ == "Film")
            {
                string format = Interaction.InputBox("Format:", "Ny film");

                int speltid = 0;
                while (true)
                {
                    string speltidInput = Interaction.InputBox("Speltid (minuter):", "Ny film").Trim();

                    // speltiden måste vara ett positivt heltal
                    if (!int.TryParse(speltidInput, out speltid) || speltid < 0)
                    {
                        MessageBox.Show("Speltid måste vara ett positivt heltal.");
                    }
                    else
                    {
                        break;
                    }
                }

                var film = new Film
                {
                    ID = id,
                    Namn = namn,
                    Pris = pris,
                    Format = format,
                    Speltid = speltid.ToString()
                };

                allaProdukter.Add(film);
                FilmGridView.Rows.Add(id, namn, pris, format, speltid, film.LagerAntal);
                ProduktListaKassa.Rows.Add(id, namn, pris, film.LagerAntal);
            }

            MessageBox.Show("Produkten har lagts till.");
        }

        // Ta bort knappen i Lagerpage
        private void LagerRemoveButton_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = LagerTabTyp.SelectedTab;

            DataGridView currentGrid = selectedTab == tabPage1 ? BokGridView :
                                       selectedTab == tabPage2 ? SpelGridView :
                                       FilmGridView;

            if (currentGrid.CurrentRow == null || currentGrid.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Ingen produkt vald.");
                return;
            }
            // Hämta ID och namn för vald produkt
            string id = currentGrid.CurrentRow.Cells[0].Value?.ToString();
            string namn = currentGrid.CurrentRow.Cells[1].Value?.ToString();

            DialogResult result = MessageBox.Show(
                $"Vill du verkligen ta bort produkten \"{namn}\" ({id})?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            //avbryt
            if (result == DialogResult.No)
                return;

            // ta bort från listan (allaprodukter)
            var produkt = allaProdukter.FirstOrDefault(p => p.ID == id);
            if (produkt != null)
            {
                allaProdukter.Remove(produkt);
            }

            //Ta bort från lager vyn
            currentGrid.Rows.Remove(currentGrid.CurrentRow);

            //ta bort från kassa vyn
            foreach (DataGridViewRow row in ProduktListaKassa.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id)
                {
                    ProduktListaKassa.Rows.Remove(row);
                    break;
                }
            }

            MessageBox.Show("Produkten har tagits bort.");
        }

        // Lägg till leverans knapp
        private void AddDeliveryButton_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ange produktens ID:", "Lägg till leverans").Trim();
            if (string.IsNullOrWhiteSpace(id)) return;

            var produkt = allaProdukter.FirstOrDefault(p => p.ID == id);
            if (produkt == null)
            {
                MessageBox.Show("Ingen produkt hittades med det ID.");
                return;
            }

            int antal = 0;
            bool valid = false;

            while (!valid)
            {
                string antalStr = Interaction.InputBox("Hur många ska läggas till i lager?", "Lägg till leverans").Trim();

                if (string.IsNullOrWhiteSpace(antalStr))
                    return;

                if (!int.TryParse(antalStr, out antal) || antal <= 0)
                {
                    MessageBox.Show("Ogiltigt antal. Försök igen.");
                }
                else
                {
                    valid = true;
                }
            }

            produkt.LagerAntal += antal;

            UpdateLagerGridRow(produkt);
            MessageBox.Show($"Leverans på {antal} enheter har lagts till för {produkt.Namn}.");
        }

        //uppdaterar Lager listor
        private void UpdateLagerGridRow(Produkt produkt)
        {
            UpdateKassaGridRow(produkt);
            DataGridView grid = produkt switch
            {
                Bok => BokGridView,
                Spel => SpelGridView,
                Film => FilmGridView,
                _ => null
            };

            if (grid == null) return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value?.ToString() == produkt.ID)
                {
                    row.Cells[row.Cells.Count - 1].Value = produkt.LagerAntal;
                    return;
                }
            }
        }
        // Uppdaterar kassa listor
        private void UpdateKassaGridRow(Produkt produkt)
        {
            foreach (DataGridViewRow row in ProduktListaKassa.Rows)
            {
                if (row.Cells[0].Value?.ToString() == produkt.ID)
                {
                    row.Cells[3].Value = produkt.LagerAntal; 
                    return;
                }
            }
        }

        // Markerar tomma celler med DarkBlue
        private void HighlightEmptyCells(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = Color.DarkBlue; // or any color you want
                    }
                }
            }
        }

    }
}
