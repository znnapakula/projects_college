using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Przychodnia
{
    public class Serializacja
    {
        public static void Wczytaj()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = string.Empty;
            try
            {

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                FileStream file = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                CzynnoscMedyczna.listaCzynnosci = (List<CzynnoscMedyczna>)bf.Deserialize(file);
                CzynnoscZaplanowana.listaCzynnosciZaplanowanych = (List<CzynnoscZaplanowana>)bf.Deserialize(file);
                Gabinet.listaGabinetow = (List<Gabinet>)bf.Deserialize(file);
                Pacjent.listaPacjentow = (List<Pacjent>)bf.Deserialize(file);
                Pracownik.listaPracownikow = (List<Pracownik>)bf.Deserialize(file);
                Terminy.listaTerminow = (List<Terminy>)bf.Deserialize(file);

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych z pliku:\n" + ofd.FileName + "\n" + ex.Message, "Błąd");
            }
        }
        public static void Zapisz()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                DialogResult result = MessageBox.Show("Czy zapisać dane do pliku?", "Zamykanie aplikacji", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.No)
                    return;
                if (result == DialogResult.Cancel)
                {

                    return;
                }


                if (sfd.ShowDialog() != DialogResult.OK)
                {

                    return;
                }

                FileStream file = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, CzynnoscMedyczna.listaCzynnosci);
                bf.Serialize(file, CzynnoscZaplanowana.listaCzynnosciZaplanowanych);
                bf.Serialize(file, Gabinet.listaGabinetow);
                bf.Serialize(file, Pacjent.listaPacjentow);
                bf.Serialize(file, Pracownik.listaPracownikow);
                bf.Serialize(file, Terminy.listaTerminow);

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych do pliku:\n" + sfd.FileName + "\n" + ex.Message, "Błąd");
            }
        }
        public static void WczytajDlaStrony()
        {
            try
            {

                FileStream file = new FileStream("C: \\Users\\Zuzanna\\Documents", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                CzynnoscMedyczna.listaCzynnosci = (List<CzynnoscMedyczna>)bf.Deserialize(file);
                CzynnoscZaplanowana.listaCzynnosciZaplanowanych = (List<CzynnoscZaplanowana>)bf.Deserialize(file);
                Gabinet.listaGabinetow = (List<Gabinet>)bf.Deserialize(file);
                Pacjent.listaPacjentow = (List<Pacjent>)bf.Deserialize(file);
                Pracownik.listaPracownikow = (List<Pracownik>)bf.Deserialize(file);
                Terminy.listaTerminow = (List<Terminy>)bf.Deserialize(file);

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych z plikue" + "\n" + ex.Message, "Błąd");
            }
        }
    }
}
