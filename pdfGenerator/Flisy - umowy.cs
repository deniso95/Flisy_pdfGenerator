using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace pdfGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Generator umów - FLISY GORZÓW";
        }

        public class Formatowanie
        {
            private static string zero = "zero";
            private static string[] jednosci = { "", " jeden ", " dwa ", " trzy ",
        " cztery ", " pięć ", " sześć ", " siedem ", " osiem ", " dziewięć " };
            private static string[] dziesiatki = { "", " dziesięć ", " dwadzieścia ",
        " trzydzieści ", " czterdzieści ", " pięćdziesiąt ",
        " sześćdziesiąt ", " siedemdziesiąt ", " osiemdziesiąt ",
        " dziewięćdziesiąt "};
            private static string[] nascie = { "dziesięć", " jedenaście ", " dwanaście ",
        " trzynaście ", " czternaście ", " piętnaście ", " szesnaście ",
        " siedemnaście ", " osiemnaście ", " dziewiętnaście "};
            private static string[] setki = { "", " sto ", " dwieście ", " trzysta ",
        " czterysta ", " pięćset ", " sześćset ",
        " siedemset ", " osiemset ", " dziewięćset " };
            private static string[,] rzedy = {{" tysiąc ", " tysiące ", " tysięcy "},
                            {" milion ", " miliony ", " milionów "},
                            {" miliard ", " miliardy ", " miliardów "}};

            private static Dictionary<string, string[]> Waluty = new Dictionary<string, string[]>() {
        //Formy podawane według wzorca: jeden-dwa-pięć, np.
        //(jeden) złoty, (dwa) złote, (pięć) złotych
        { "PLN", new string[]{ "złoty", "złote", "złotych" } },
        { "RUB", new string[]{ "rubel", "ruble", "rubli" } },
        { "USD", new string[]{ "dolar", "dolary", "dolarów" } }
    };

            public static string LiczbaSlownie(int liczba)
            {
                return LiczbaSlownieBase(liczba).Replace("  ", " ").Trim();
            }

            public static string WalutaSlownie(int liczba, string kodWaluty)
            {
                var key = Waluty[kodWaluty];
                return key[DeklinacjaWalutyIndex(liczba)];
            }

            private static string LiczbaSlownieBase(int wartosc)
            {
                StringBuilder sb = new StringBuilder();
                //0-999
                if (wartosc == 0)
                    return zero;
                int jednosc = wartosc % 10;
                int para = wartosc % 100;
                int set = (wartosc % 1000) / 100;
                if (para > 10 && para < 20)
                    sb.Insert(0, nascie[jednosc]);
                else
                {
                    sb.Insert(0, jednosci[jednosc]);
                    sb.Insert(0, dziesiatki[para / 10]);
                }
                sb.Insert(0, setki[set]);

                //Pozostałe rzędy wielkości
                wartosc = wartosc / 1000;
                int rzad = 0;
                while (wartosc > 0)
                {
                    jednosc = wartosc % 10;
                    para = wartosc % 100;
                    set = (wartosc % 1000) / 100;
                    bool rzadIstnieje = wartosc % 1000 != 0;
                    if ((wartosc % 1000) / 10 == 0)
                    {
                        //nie ma dziesiątek i setek
                        if (jednosc == 1)
                            sb.Insert(0, rzedy[rzad, 0]);
                        else if (jednosc >= 2 && jednosc <= 4)
                            sb.Insert(0, rzedy[rzad, 1]);
                        else if (rzadIstnieje)
                            sb.Insert(0, rzedy[rzad, 2]);
                        if (jednosc > 1)
                            sb.Insert(0, jednosci[jednosc]);
                    }
                    else
                    {
                        if (para >= 10 && para < 20)
                        {
                            sb.Insert(0, rzedy[rzad, 2]);
                            sb.Insert(0, nascie[para % 10]);
                        }
                        else
                        {
                            if (jednosc >= 2 && jednosc <= 4)
                                sb.Insert(0, rzedy[rzad, 1]);
                            else if (rzadIstnieje)
                                sb.Insert(0, rzedy[rzad, 2]);
                            sb.Insert(0, jednosci[jednosc]);
                            sb.Insert(0, dziesiatki[para / 10]);
                        }
                        sb.Insert(0, setki[set]);
                    }
                    rzad++;
                    wartosc = wartosc / 1000;
                }
                return sb.ToString();
            }

            private static int DeklinacjaWalutyIndex(int liczba)
            {
                if (liczba == 1)
                    return 0;

                int para = liczba % 100;
                if (para >= 10 && para < 20)
                    return 2;

                int jednosc = liczba % 10;
                if (jednosc >= 2 && jednosc <= 4)
                    return 1;

                return 2;
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int cena = Int32.Parse(cena_txt.Text);
            int zadatek = Int32.Parse(zadatek_txt.Text);
            int pozostala = cena - zadatek;

            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(desktopFolder, "umowa.pdf");

            FileStream fs = new FileStream(fullFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Font timesBoldItalic = FontFactory.GetFont(FontFactory.TIMES_BOLDITALIC, BaseFont.CP1250, 11);
            iTextSharp.text.Font timesBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, BaseFont.CP1250, 11);
            iTextSharp.text.Font times = FontFactory.GetFont(FontFactory.TIMES, BaseFont.CP1250, 11);
            Document doc = new Document(PageSize.A4, 40, 40, 20, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            iTextSharp.text.Image flisy_1 = iTextSharp.text.Image.GetInstance("flisy_01.png");
            doc.Open();
            doc.SetMargins(40f, 40f, 40f, 40f);
            doc.AddTitle("Umowa Flisy");
            doc.AddAuthor("Flisy");
            // first image
            flisy_1.ScaleToFit(600f, 70f);
            flisy_1.Alignment = Element.ALIGN_CENTER;
            doc.Add(flisy_1);

            Paragraph title = new Paragraph("UMOWA O DZIEŁO", timesBoldItalic);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            // &0
            var zero_ph = new Phrase();
            zero_ph.Add(new Chunk("Zawarta w dniu ", times));
            zero_ph.Add(new Chunk(data_txt.Text, timesBold));
            zero_ph.Add(new Chunk(" pomiędzy zespołem muzycznym FLISY reprezentowanym przez Arkadiusza Olka zamieszkałym w Gorzowie Wlkp.ul.Wiedeńska 1i / 15 zwanym w treści umowy wykonawcą, a organizatorem imprezy czyli ", times));
            zero_ph.Add(new Chunk(zlece_txt.Text, timesBold));
            zero_ph.Add(new Chunk(" zamieszkałym ", times));
            zero_ph.Add(new Chunk(adr_zlece_txt.Text, timesBold));
            zero_ph.Add(new Chunk(" zwanym w treści umowy zamawiającym.", times));

            Paragraph zero = new Paragraph(zero_ph);
            zero.Alignment = Element.ALIGN_JUSTIFIED;
            zero.SetLeading(0.0f, 1.5f);
            doc.Add(zero);

            // &1
            Paragraph one_amp = new Paragraph("&1", timesBold);
            one_amp.Alignment = Element.ALIGN_CENTER;
            one_amp.SetLeading(0.0f, 1.5f);
            doc.Add(one_amp);

            var one_ph = new Phrase();
            one_ph.Add(new Chunk("Zamawiający zamawia wykonanie a wykonawca zobowiązuje się wykonać dzieło polegające na: \na) oprawie muzyczno - wokalnej uroczystości weselnej \nb) oprawie muzyczno-wokalnej uroczystości weselnej wraz z poprawinami \nc) oprawie muzyczno-wokalnej imprezy", times));

            Paragraph one = new Paragraph(one_ph);
            one.Alignment = Element.ALIGN_JUSTIFIED;
            one.SetLeading(0.0f, 1.5f);
            doc.Add(one);

            // &2
            Paragraph two_amp = new Paragraph("&2", timesBold);
            two_amp.Alignment = Element.ALIGN_CENTER;
            two_amp.SetLeading(0.0f, 1.5f);
            doc.Add(two_amp);

            var two_ph = new Phrase();
            two_ph.Add(new Chunk("W terminie dnia ", times));
            two_ph.Add(new Chunk(termin_txt.Text, timesBold));
            two_ph.Add(new Chunk(" od godz. 16:00 do godz. 4:00 w miejscu ", times));
            two_ph.Add(new Chunk(miejsce_txt.Text, timesBold));
            two_ph.Add(new Chunk(".", times));

            Paragraph two = new Paragraph(two_ph);
            two.Alignment = Element.ALIGN_JUSTIFIED;
            two.SetLeading(0.0f, 1.5f);
            doc.Add(two);

            // &3
            Paragraph three_amp = new Paragraph("&3", timesBold);
            three_amp.Alignment = Element.ALIGN_CENTER;
            three_amp.SetLeading(0.0f, 1.5f);
            doc.Add(three_amp);

            var three_ph = new Phrase();
            three_ph.Add(new Chunk("Za wykonanie dzieła zamawiający wypłaci wykonawcy wynagrodzenie w wysokości ", times));
            three_ph.Add(new Chunk(cena_txt.Text + ",00", timesBold));
            three_ph.Add(new Chunk(" słownie ", times));
            three_ph.Add(new Chunk(String.Format("{0} {1}", Formatowanie.LiczbaSlownie(cena), Formatowanie.WalutaSlownie(cena, "PLN")), timesBold));
            three_ph.Add(new Chunk(".", times));

            Paragraph three = new Paragraph(three_ph);
            three.Alignment = Element.ALIGN_JUSTIFIED;
            three.SetLeading(0.0f, 1.5f);
            doc.Add(three);

            // &4
            Paragraph four_amp = new Paragraph("&4", timesBold);
            four_amp.Alignment = Element.ALIGN_CENTER;
            four_amp.SetLeading(0.0f, 1.5f);
            doc.Add(four_amp);

            var four_ph = new Phrase();
            four_ph.Add(new Chunk("Zadatek w kwocie ", times));
            four_ph.Add(new Chunk(zadatek_txt.Text + ",00", timesBold));
            four_ph.Add(new Chunk(" słownie ", times));
            four_ph.Add(new Chunk(String.Format("{0} {1}", Formatowanie.LiczbaSlownie(zadatek), Formatowanie.WalutaSlownie(zadatek, "PLN")), timesBold));
            four_ph.Add(new Chunk(" pobrano w dniu sporządzenia umowy. Do uregulowania pozostaje kwota ", times));
            four_ph.Add(new Chunk(pozostala.ToString() + ",00", timesBold));
            four_ph.Add(new Chunk(" słownie ", times));
            four_ph.Add(new Chunk(String.Format("{0} {1}", Formatowanie.LiczbaSlownie(pozostala), Formatowanie.WalutaSlownie(pozostala, "PLN")), timesBold));
            four_ph.Add(new Chunk(" która wypłacona będzie bezpośrednio po zakończeniu imprezy.", times));

            Paragraph four = new Paragraph(four_ph);
            four.Alignment = Element.ALIGN_JUSTIFIED;
            four.SetLeading(0.0f, 1.5f);
            doc.Add(four);

            // &5
            Paragraph five_amp = new Paragraph("&5", timesBold);
            five_amp.Alignment = Element.ALIGN_CENTER;
            five_amp.SetLeading(0.0f, 1.5f);
            doc.Add(five_amp);

            var five_ph = new Phrase();
            five_ph.Add(new Chunk("Wykonawca nie może powierzyć dzieła innym osobom bez zgody zamawiającego. ", times));

            Paragraph five = new Paragraph(five_ph);
            five.Alignment = Element.ALIGN_JUSTIFIED;
            five.SetLeading(0.0f, 1.5f);
            doc.Add(five);

            // &6
            Paragraph six_amp = new Paragraph("&6", timesBold);
            six_amp.Alignment = Element.ALIGN_CENTER;
            six_amp.SetLeading(0.0f, 1.5f);
            doc.Add(six_amp);

            var six_ph = new Phrase();
            six_ph.Add(new Chunk("Zamawiający jest jednocześnie organizatorem imprezy. ", times));

            Paragraph six = new Paragraph(six_ph);
            six.Alignment = Element.ALIGN_JUSTIFIED;
            six.SetLeading(0.0f, 1.5f);
            doc.Add(six);

            // &7
            Paragraph seven_amp = new Paragraph("&7", timesBold);
            seven_amp.Alignment = Element.ALIGN_CENTER;
            seven_amp.SetLeading(0.0f, 1.5f);
            doc.Add(seven_amp);

            var seven_ph = new Phrase();
            seven_ph.Add(new Chunk("Zamawiający ponosi odpowiedzialność materialną za zniszczenie lub uszkodzenie sprzętu powstałe z winy osób nie będących członkami zespołu.", times));

            Paragraph seven = new Paragraph(seven_ph);
            seven.Alignment = Element.ALIGN_JUSTIFIED;
            seven.SetLeading(0.0f, 1.5f);
            doc.Add(seven);

            // &8
            Paragraph eight_amp = new Paragraph("&8", timesBold);
            eight_amp.Alignment = Element.ALIGN_CENTER;
            eight_amp.SetLeading(0.0f, 1.5f);
            doc.Add(eight_amp);

            var eight_ph = new Phrase();
            eight_ph.Add(new Chunk("W przypadku rozwiązania umowy przez zamawiającego, zadatek przechodzi na rzecz wykonawcy. ", times));

            Paragraph eight = new Paragraph(eight_ph);
            eight.Alignment = Element.ALIGN_JUSTIFIED;
            eight.SetLeading(0.0f, 1.5f);
            doc.Add(eight);

            // &9
            Paragraph nine_amp = new Paragraph("&9", timesBold);
            nine_amp.Alignment = Element.ALIGN_CENTER;
            nine_amp.SetLeading(0.0f, 1.5f);
            doc.Add(nine_amp);

            var nine_ph = new Phrase();
            nine_ph.Add(new Chunk("W przypadku rozwiązania umowy przez wykonawcę, zadatek w podwójnej wysokości przechodzi na rzecz zamawiającego.", times));

            Paragraph nine = new Paragraph(nine_ph);
            nine.Alignment = Element.ALIGN_JUSTIFIED;
            nine.SetLeading(0.0f, 1.5f);
            doc.Add(nine);

            // &10
            Paragraph ten_amp = new Paragraph("&10", timesBold);
            ten_amp.Alignment = Element.ALIGN_CENTER;
            ten_amp.SetLeading(0.0f, 1.5f);
            doc.Add(ten_amp);

            var ten_ph = new Phrase();
            ten_ph.Add(new Chunk("W sprawach nie uregulowanych niniejszą umową mają zastosowanie przepisy kodeksu cywilnego.", times));

            Paragraph ten = new Paragraph(ten_ph);
            ten.Alignment = Element.ALIGN_JUSTIFIED;
            ten.SetLeading(0.0f, 1.5f);
            doc.Add(ten);

            // &11
            Paragraph eleven_amp = new Paragraph("&11", timesBold);
            eleven_amp.Alignment = Element.ALIGN_CENTER;
            eleven_amp.SetLeading(0.0f, 1.5f);
            doc.Add(eleven_amp);

            var eleven_ph = new Phrase();
            eleven_ph.Add(new Chunk("Umowę sporządzono w dwóch jednobrzmiących egzemplarzach, po jednym dla każdej ze stron.", times));

            Paragraph eleven = new Paragraph(eleven_ph);
            eleven.Alignment = Element.ALIGN_JUSTIFIED;
            eleven.SetLeading(0.0f, 1.5f);
            doc.Add(eleven);

            // signatures
            var signatures_ph = new Phrase();
            signatures_ph.Add(new Chunk("\n\n             (zamawiający)                                                                                               (wykonawca)    ", times));

            Paragraph signatures = new Paragraph(signatures_ph);
            signatures.Alignment = Element.ALIGN_JUSTIFIED;
            doc.Add(signatures);

            doc.Close();
            System.Windows.Forms.MessageBox.Show("Umowa została wygenerowana.");
        }
    }
}
