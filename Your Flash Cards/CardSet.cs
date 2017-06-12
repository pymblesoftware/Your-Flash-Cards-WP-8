using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;
using System.IO.IsolatedStorage;


namespace Your_Flash_Cards
{
    class CardSet
    {
        String setName;

        static string currSet;
        static int CardNumberInSet;
        static Card cardHeld;

        public CardSet(String name)
        {
            System.Diagnostics.Debug.WriteLine("CardSet constructor: " + name);
            setName = name;
            mkdir( setName );
            CardSet.setCurrentSet(setName );
            CardNumberInSet = 1;
            cardHeld = null;
        }


        public static Card currentCard()
        {
            return cardHeld;
        }

        public static string[] getSets()
        {
            IsolatedStorageFile isoStore;

            isoStore = IsolatedStorageFile.GetUserStoreForApplication();
            String[] cardSetDirs = isoStore.GetDirectoryNames();

            System.Diagnostics.Debug.WriteLine("Directories in CardSet.getSets() ...");
            foreach (string curr in cardSetDirs)
            {
                System.Diagnostics.Debug.WriteLine(curr);
            }

            return cardSetDirs;
        }

        public static int numberOfCardsInSet()
        {
            int result = 0;

            IsolatedStorageFile isoStore;
            isoStore = IsolatedStorageFile.GetUserStoreForApplication();
            string[] filelist = isoStore.GetFileNames(currentSet() + "\\Front.*");
            result = filelist.Length;

            return result;
        }

        public static int currentCardNum()
        {
            return CardNumberInSet;
        }

        public static void nextCard( bool write = false)
        {
            CardNumberInSet++;

            if (!write)
            {
                if (CardNumberInSet > numberOfCardsInSet())
                    CardNumberInSet = 1;
            }
        }

        public static string currentSet()
        {
            return currSet;
        }

        public static void setCardNum(int cardNum)
        {
            CardNumberInSet = cardNum;
        }

        public static void setCurrentSet(string name)
        {
            currSet = name;
        }

        public static void newCard(Card NewCard)
        {
            cardHeld = NewCard;
        }

        private void mkdir(String name)
        {
            IsolatedStorageFile isoStore;

            try
            {
                // TODO: Test if directory already exists.
                isoStore = IsolatedStorageFile.GetUserStoreForApplication();
                isoStore.CreateDirectory(name);
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
                // e.Message;
            }
            /** 
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
     IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);

            // This code creates a few different directories.
            isoStore.CreateDirectory("TopLevelDirectory");
             * ***/
        }

        public String name()
        {
            return setName;
        }


    }
}
