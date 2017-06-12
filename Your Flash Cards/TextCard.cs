using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


using System.IO;
using System.IO.IsolatedStorage;
using System.Diagnostics;

namespace Your_Flash_Cards
{
    public class TextCard : Card
    {
        string frontOfCardText;
        string backOfCardText;

        public void setFront(string text)
        {
            frontOfCardText = text;
        }

        public void setBack(string text)
        {
            backOfCardText = text;
        }


        private void writeFront(String fileName )
        {
            try
            {
                IsolatedStorageFile isoStore;
                isoStore = IsolatedStorageFile.GetUserStoreForApplication();
                FileMode mode = FileMode.Create;
                FileStream FrontStr = isoStore.OpenFile(fileName, mode);

                byte[] output = Encoding.UTF8.GetBytes(frontOfCardText);
                FrontStr.Write(output, 0, frontOfCardText.Length);
                FrontStr.Close();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        private void writeBack( string fileName )
        {
            try
            {
                IsolatedStorageFile isoStore;
                isoStore = IsolatedStorageFile.GetUserStoreForApplication();
                FileMode mode = FileMode.Create;
                FileStream BackStr = isoStore.OpenFile(fileName, mode);
                byte[] output = Encoding.UTF8.GetBytes(backOfCardText);
                BackStr.Write( output, 0, backOfCardText.Length);
                BackStr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }


        public override void write(string setName )
        {           
            try
            {
                int cardNumber = CardSet.currentCardNum();
            
                string frontFileName = setName + "\\Front." + cardNumber + ".text";
                string backFileName = setName + "\\Back." + cardNumber + ".text";
                System.Diagnostics.Debug.WriteLine("Writing files: " + frontFileName + " " + backFileName );

                writeFront(frontFileName);
                writeBack(backFileName);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine( "TextCard write:" + e.Message);
            }

        }

        public override void read(string setName)
        {
            try
            {
                base.read(setName);

                int cardNumber = CardSet.currentCardNum();

                if (cardNumber > CardSet.numberOfCardsInSet())
                {
                    CardSet.setCardNum(1);
                    cardNumber = 1;
                }

                string fileName;
                IsolatedStorageFile isoStore;
                isoStore = IsolatedStorageFile.GetUserStoreForApplication();
                FileMode mode = FileMode.Open;
                byte[] input;

                fileName = setName + "\\Front." + cardNumber + ".text"; ;

                if (isoStore.FileExists(fileName))
                {
                    Debug.WriteLine("FILE EXISTS");
                }
                else
                {
                    Debug.WriteLine("DOES NOT exist");
                }
#if NOTHING
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(fileName, FileMode.Open, isoStore))
                {
                    long length = stream.Length;
                    byte[] decoded = new byte[length];
                    stream.Read(decoded, 0, (int)length);
                    Debug.WriteLine(Encoding.UTF8.GetString(decoded, 0, (int)length));
                }
#endif

                System.Diagnostics.Debug.WriteLine("File: " + fileName);

                FileStream FrontStr = isoStore.OpenFile(fileName, mode);

                int len = (int) FrontStr.Length;
                input = new byte[len];
                FrontStr.Read(input, 0, len);  
                FrontStr.Close();
                frontOfCardText = UTF8Encoding.UTF8.GetString(input, 0, len);

                fileName = setName + "\\Back." + cardNumber + ".text";
                FileStream BackStr = isoStore.OpenFile(fileName, mode);

                len = (int)BackStr.Length;
                input = new byte[len];
                BackStr.Read(input, 0, len);  
                BackStr.Close();
                backOfCardText = UTF8Encoding.UTF8.GetString(input, 0, len);
            }
            catch (Exception e)
            {
                Debug.WriteLine( "TextCard: " + e.Message);
            }
        }

        // SPecial versions should be some kind of common way through overrides of base methods.
        public void presentFrontSP( TextBlock output )
        {
            output.Text = frontOfCardText;
        }

        public void presentBackSP(TextBlock output)
        {
            output.Text = backOfCardText;
        }


        public override void presentFront()
        {

        }

        public override void presentBack()
        {

        }

    }
}
