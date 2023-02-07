using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Course
    {
    private string crsIdentifier;
    private string crsDesc;
    private int crsCode;


        public Course() { }

        public Course(string crsIdentifier, string crsDesc)
        {IsNotNullOrWhiteSpace(crsIdentifier);
         this.crsIdentifier = crsIdentifier;

         IsNotNullOrWhiteSpace(crsDesc);
         this.crsDesc = crsDesc;
        }

        public Course(int crsCode, string crsIdentifier, string crsDesc)
        {this.crsCode = crsCode;
         
        IsNotNullOrWhiteSpace(crsIdentifier);
         this.crsIdentifier = crsIdentifier;

            IsNotNullOrWhiteSpace(crsDesc);
            this.crsDesc = crsDesc;
        }

        public int CrsCode
        {get => crsCode;
        set => crsCode = value;}

        public string CrsIdentifier
        {get => crsIdentifier;
         set{IsNotNullOrWhiteSpace(value);
                crsIdentifier = value;}
        }

        public string CrsDesc
        {
            get => crsDesc;
            set
            {
                IsNotNullOrWhiteSpace(value);
                crsDesc = value;
            }
        }

        public void IsNotNullOrWhiteSpace(string value)
        {
            if (String.IsNullOrWhiteSpace(value)) throw new Exception("");
        }

    }

