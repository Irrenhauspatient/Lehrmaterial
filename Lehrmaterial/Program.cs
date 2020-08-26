using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lehrmaterial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Syntax des Formatausdrucks

            long value = 4711;
            WriteLine("value = {0,0:C}", value);
            ReadLine();



            /*

            {N [,M][:FORMAT]}

            Formatangabe        Beschreibung

            C                   Zeigt die Zahl im lokalen Währungsformat an
            D                   Zeigt die Zahl als dezimalen Integer an
            E                   Zeigt die Zahl im wissenschaftlichen Format an (Exponentialschreibweise)
            F                   Zeigt die Zahl im Festpunktformat an
            G                   Eine numerische Zahl wird entweder im Festpunkt- oder im wissenschaftlichen Format angezeigt. (kompakteste immer)
            N                   Zeigt eine numerischer Zahl einschließlich Kommaseparatoren an
            P                   Zeigt eine numerische Zahl als Prozentzahl an.
            X                   die Anzeige erfolgt in Hexadezimalnotation

            */

            #endregion


            #region Stringinterpolation

            int a = 67;
            int b = 771;
            WriteLine($"a= {a}, b={b}");
            ReadLine();

            #endregion

            #region Escapezeichen

            WriteLine("C#\nmacht\nSpaß\a");
            ReadLine();

            /*
             
            Escape-Zeichen      Beschreibung

            \´                  Fügt ein Hochkomma in die Zeichenfolge ein.
            \"                  Fügt ANführungsstriche ein.
            \\                  Fügt einen Backslash in die Zeichenfolge ein.
            \a                  Löst einen Alarmton aus.
            \b                  Führt zum Löschen des vorhergehenden Zeichens.
            \f                  Löst einen Formularvorschub bei Druckern aus.
            \n                  Löst einen Zeilenvorschub aus.
            \r                  Führt zu einem Wagenrücklauf.
            \t                  Führt auf dem Bildschirm zu einen Tabulatorsprung.
            \u                  Fügt ein Unicode-Zeichen in die Zeichenfolge ein.
            \v                  Fügt einen vertikalen Tabulator in eine Zeichenfolge ein.
            @                   Schaltet die Escape Sequenz ab. (Alle Zeichen werden ausgegeben)

            */

            #endregion

        }




    }

}
