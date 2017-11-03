using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControlWork1
{
    class Checker
    {
        private string[] arrayOfWrongStartString;
        private string[] arrayOfWrongFileNames;

        //paths of files with limitations
        public Checker()
        {
            arrayOfWrongStartString = File.ReadAllLines ( @"f:\Test\FirstControlWork\TAT0003.test01\ControlWork1\ControlWork1\WrongStartString.txt" );
            arrayOfWrongFileNames = File.ReadAllLines ( @"f:\Test\FirstControlWork\TAT0003.test01\ControlWork1\ControlWork1\WrongFileNames.txt" );
        }

        public bool Check ( string path )
        {
            bool res = path.IndexOfAny ( Path.GetInvalidPathChars () ) == -1;
            // 92 -> unicode for '\'
            char backslash = (char) 92;

            //Check for existance of wrong start symbols of directories and files
            for ( int i = 0 ; i < arrayOfWrongStartString.Length ; i++ )
            {
                if ( path.Contains ( backslash + arrayOfWrongStartString[ i ] ) )
                {
                    res = false;
                    break;
                }
            }

            //Check for existance of wrong file or directorye names
            for ( int i = 0 ; i < arrayOfWrongFileNames.Length ; i++ )
            {
                if ( path.Contains ( backslash + arrayOfWrongFileNames [ i ] + '.' ) )
                {
                    res = false;
                    break;
                }
            }

            //Check for right number of points
            if ( path.Count ( x => x == '.' ) > 3 )
            {
                res = false;
            }
            else if ( path [ 0 ] != '.' && path [ 1 ] != '.' )
            {
                res = false;
            }
            else if ( path.LastIndexOf ( backslash ) > path.LastIndexOf ( '.' ) )
            {
                res = false;
            }

            //Check for right number of ':'
            if ( path.Count ( x => x == ':' ) != 1)
            {
                res = false;
            }

            return res;
        }

    }
}
