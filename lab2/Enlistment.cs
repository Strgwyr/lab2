using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_2_v3
{
    internal class Enlistment
    {
        private int yrLevel;
        private string semester; 
        private int schoolYr;
        private string program;

        public string Term
        {get
            {
                int nextYear = schoolYr + 1;
                return $"AY {schoolYr} - {nextYear}, {semester}";
            }
        }
        public int SchoolYr
        {get => schoolYr;
            set => schoolYr = value;
        }

        public int YrLevel
        {get => yrLevel;
            set
            {if (value < 1 || value > 5)
                {
                    Console.WriteLine("\n!!! ERROR: YEAR LEVEL MUST BE BETWEEN 1 - 5 !!!\n");
                    throw new Exception("");
                }
                yrLevel = value;
            }
        }

        public string Semester
        {get => semester;
            set
            {isNumber(value);

                switch (Convert.ToInt32(value))
                {
                    case 1:
                        semester = "First Semester";
                        break;
                    case 2:
                        semester = "Second Semester";
                        break;
                    case 3:
                        semester = "Summer Semester";
                        break;
                    default:
                        Console.WriteLine("\n!!! ERROR: PLEASE INPUT ONLY VALUES FROM 1 - 3 !!!\n");
                        break;
                }
            }
        }

        public string Program
        {get => program;
            set
            {
                IsNotNullOrWhiteSpace(value, "program");
                program = value;
            }
        }

        public void isNumber(string value)
        {bool isNumber = int.TryParse(value, out _);

            if (!isNumber)
            {
                Console.WriteLine("\n!!! ERROR: SEMESTER IS NOT NUMBER !!!\n");
                throw new Exception("");
            }
        }

        public void IsNotNullOrWhiteSpace(string value, string inputField)
        {if (String.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine($"\n!!! ERROR: {inputField.ToUpper()} IS EMPTY !!!\n");
                throw new Exception("");
            }
        }

        public bool Equals(Enlistment enlistment)
        {if(enlistment.SchoolYr == schoolYr && enlistment.yrLevel ==
            yrLevel && enlistment.Semester == semester && enlistment.Program
            == program)
            {
                return true;
            }

            return false;
        }
    }
}
