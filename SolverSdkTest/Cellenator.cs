using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverSdkTest
{
    public class Cellenator
    {
        public StringBuilder ACells { get; set; }
        public StringBuilder CCells { get; set; }
        public StringBuilder DCells { get; set; }
        public StringBuilder ECells { get; set; }
        public StringBuilder FCells { get; set; }
        public StringBuilder ICells { get; set; }
        public StringBuilder JCells { get; set; }

        public void GenJCells()
        {
            JCells = new StringBuilder();
            ICells = new StringBuilder();
            FCells = new StringBuilder();
            ACells = new StringBuilder();
            ECells = new StringBuilder();
            DCells = new StringBuilder();
            CCells = new StringBuilder();

            var jcell =
            @"public double J{0}
            {{
                get
                {{
                    return F{0}*(1-I{0});  
                }}
            }}";
            var j808cell =
            @"public double J808
            {{
                get
                {{
                    return {0};  
                }}
            }}";
            var icell =
            @"public double I{0}
            {{
                get
                {{
                    return (B3 == Position.Vertical ? (A{0} < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A{0} / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));  
                }}
            }}";
            var fcell =
            @"public double F{0}
            {{
                get
                {{
                    return E{0} * B585;  
                }}
            }}"; 
            var a607cell =
            @"public double A607 { get; set; }";
            var acell =
            @"public double A{0}
            {{
                get
                {{
                    return (A807 - A607) / 200 + A{1}; 
                }}
            }}"; 
            var a807cell =
            @"public double A807
            {
                get
                {
                    return B593 - 1; 
                }
            }";
            var e607cell =
            @"public double E607 { get; set; }";
            var ecell =
            @"public double E{0}
            {{
                get
                {{
                    return D{0} - D{1}; 
                }}
            }}";
            var dcell =
            @"public double D{0}
            {{
                get
                {{
                    return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C{0}));
                }}
            }}";
            var ccell =
            @"public double C{0}
            {{
                get
                {{
                    return Math.Log(B596 * A{0} / (B593 - A{0})); //Natural Log base(e)
                }}
            }}";
            
            var j808 = new StringBuilder();

            for (int i = 607; i <= 807; i++)
            {
                if (i == 807)
                    j808.AppendFormat("J{0}", i);
                else
                    j808.AppendFormat("J{0} + ", i);
                JCells.AppendLine(string.Format(jcell, i));
                ICells.AppendLine(string.Format(icell, i));
                FCells.AppendLine(string.Format(fcell, i));
                if (i == 607)
                    ACells.AppendLine(a607cell);
                else if (i == 807)
                    ACells.AppendLine(a807cell);
                else
                    ACells.AppendLine(string.Format(acell, i, i - 1));
                if (i == 607)
                    ECells.AppendLine(e607cell);
                else
                    ECells.AppendLine(string.Format(ecell, i, i - 1));
                DCells.AppendLine(string.Format(dcell, i));
                CCells.AppendLine(string.Format(ccell, i));
            }

            JCells.AppendLine(string.Format(j808cell, j808.ToString()));
                        
            var regionJ808 = new StringBuilder();
            regionJ808.AppendLine("#region J808");
            regionJ808.AppendLine(ACells.ToString());
            regionJ808.AppendLine(CCells.ToString());
            regionJ808.AppendLine(DCells.ToString());
            regionJ808.AppendLine(ECells.ToString());
            regionJ808.AppendLine(FCells.ToString());
            regionJ808.AppendLine(ICells.ToString());
            regionJ808.AppendLine(JCells.ToString());
            regionJ808.AppendLine("#endregion J808");

            var finalVars = regionJ808.ToString();

        }

    }
}
