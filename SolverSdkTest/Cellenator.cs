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
            @"private double? _j{0};
            public double J{0}
            {{
                get
                {{
                    //Debug.WriteLine(""J{0}"");
                    if(_j{0} == null)
                        _j{0} = F{0}*(1-I{0});  
                    return _j{0}.Value;
                }}
            }}";
            var j808cell =
            @"public double J808
            {{
                get
                {{
                    //Debug.WriteLine(""J808"");
                    return {0};  
                }}
            }}";
            var icell =
            @"private double? _i{0};
            public double I{0}
            {{
                get
                {{
                    //Debug.WriteLine(""I{0}"");
                    if(_i{0} == null)
                        _i{0} = (B3 == Position.Vertical ? (A{0} < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A{0} / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value)); 
                    return _i{0}.Value;
                }}
            }}";
            var fcell =
            @"private double? _f{0};
            public double F{0}
            {{
                get
                {{
                    //Debug.WriteLine(""F{0}"");
                    if(_f{0} == null)
                        _f{0} = E{0} * B585;
                    return _f{0}.Value; 
                }}
            }}"; 
            var a607cell =
            @"public double A607 { get; set; }";
            var acell =
            @"private double? _a{0};
            public double A{0}
            {{
                get
                {{
                    //Debug.WriteLine(""A{0}"");
                    if(_a{0} == null)
                        _a{0} = (A807 - A607) / 200 + A{1};
                    return _a{0}.Value; 
                }}
            }}"; 
            var a807cell =
            @"public double A807
            {
                get
                {
                    //Debug.WriteLine(""A807"");
                    return _b593.Value - 1; 
                }
            }";
            var e607cell =
            @"public double E607 { get; set; }";
            var ecell =
            @"private double? _e{0};
            public double E{0}
            {{
                get
                {{
                    //Debug.WriteLine(""E{0}"");
                    if(_e{0} == null)
                        _e{0} = D{0} - D{1};
                    return _e{0}.Value; 
                }}
            }}";
            var dcell =
            @"private double? _d{0};
            public double D{0}
            {{
                get
                {{
                    //Debug.WriteLine(""D{0}"");
                    if(_d{0} == null)
                        _d{0} = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C{0}));
                    return _d{0}.Value; 
                }}
            }}";
            var ccell =
            @"private double? _c{0};
            public double C{0}
            {{
                get
                {{
                    //Debug.WriteLine(""C{0}"");
                    if(_c{0} == null)
                        _c{0} = Math.Log(_b596.Value * A{0} / (_b593.Value - A{0})); //Natural Log base(e)
                    return _c{0}.Value; 
                }}
            }}";

            var pProperties = @"
            private double? _b576 { get; set; }
            private double? _e33 { get; set; }
            private double? _e20 { get; set; }
            private double? _e39 { get; set; }
            private double? _b571 { get; set; }
            private double? _b588 { get; set; }
            private double? _b593 { get; set; }
            private double? _b596 { get; set; }
            ";

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
            regionJ808.AppendLine(pProperties);
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
