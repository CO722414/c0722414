﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {

        }
    }
        

    
        class Village


    {
        public static int numberOfVillage = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;

        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillage++;
        }
        class Countryside
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;

            public void MapInitializer()
               
            {
                Maple = new Village();
                Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;

                Toronto = new Village();
                Toronto.previousVillage = Maple;
                Toronto.VillageName = "Toronto";
                    Toronto.nextVillage = Ajax;

                Ajax = new Village();
                Ajax.previousVillage = Toronto;
                Ajax.isAstrildeHere = true;
            }
            public void LookForAstrilde()
            { 

            }
        }
    }

}