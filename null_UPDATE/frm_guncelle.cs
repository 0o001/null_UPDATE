using Ionic.Zip;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace null_UPDATE
{
    public partial class frm_guncelle : Form
    {
        private const string PROGRAM_ADI = "SQL Yardımcısı"; //Program Adı
        private const string YUKLU_YER = @"HKEY_CURRENT_USER\SOFTWARE\null\" + PROGRAM_ADI; //Programın yüklendiğinde regeditteki yeri

        private Uri url = new Uri("http://sqlyardimcisi.nullovy.com/SQL-Yardimcisi.zip"); //Yüklenecek .zip dosyası urlsi
        private string dosyaYoluAl = null;
        public frm_guncelle()
        {
            InitializeComponent();
            Indir(url, ref dosyaYoluAl); //Dosyayı indir
        }

        #region Indir&Yukle
        private void Indir(Uri url, ref string dosyaYolu)
        {
            try
            {
                using (var wc_indir = new WebClient())
                {
                    dosyaYolu = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString(); //Temp dosyasında özel adlı bir dosya oluştur
                    wc_indir.DownloadFileAsync(url, dosyaYolu); //Temp dosyasındaki yola .zip dosyasını indir
                    wc_indir.DownloadProgressChanged += Wc_indir_DownloadProgressChanged;
                    wc_indir.DownloadFileCompleted += Wc_indir_DownloadFileCompleted;
                }
            }
            catch //Hata oluşursa
            {
                Indir(url, ref dosyaYolu); //Dosyayı indir
            }
        }

        private void Wc_indir_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pbr_indir.Style = ProgressBarStyle.Continuous;
            try
            {
                string cikarDosyaYolu = (string)Registry.GetValue(YUKLU_YER, "InstallLocation", System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + PROGRAM_ADI); //InstallLocation adlı anahtardan programın yüklü olduğu yeri al
                ZiptenCikar(dosyaYoluAl, cikarDosyaYolu); //Zipten çıkar
                if (File.Exists(string.Concat(cikarDosyaYolu, "\\", PROGRAM_ADI, ".exe")))
                {
                    System.Diagnostics.Process.Start(string.Concat(cikarDosyaYolu, "\\", PROGRAM_ADI, ".exe")); //Programı aç
                }
                else if (File.Exists(string.Concat(Application.StartupPath, "\\", PROGRAM_ADI, ".exe")))
                {
                    System.Diagnostics.Process.Start(string.Concat(Application.StartupPath, "\\", PROGRAM_ADI, ".exe")); //Programı aç
                }
                else
                {
                    MessageBox.Show("\"" + PROGRAM_ADI + "\" adlı dosya açılamıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            try
            {
                File.Delete(dosyaYoluAl); //Zip dosyasını sil
            }
            catch { }
            Environment.Exit(1); //Programı kapat
        }

        private void Wc_indir_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbr_indir.Value = e.ProgressPercentage;
        }

        private void frm_guncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public static void ZiptenCikar(string dosyaYolu, string cikarDosyaYolu) //Zipten çıkar
        {
            using (ZipFile zipFile = ZipFile.Read(dosyaYolu))
            {
                zipFile.ExtractAll(cikarDosyaYolu, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
