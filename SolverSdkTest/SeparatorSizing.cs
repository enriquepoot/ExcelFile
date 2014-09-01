using SolverPlatform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverSdkTest
{
    public class SeparatorSizing
    {
        public enum Position { N_A=0, Vertical = 1, Horizontal = 2 }
        public enum GeneralClassification { None = 0, Mesh = 1, Vane, Cyclone }
        public enum BooleanResponse { N_A = 0, N = 1, Y }
        public enum SettlingLaw { OutOfRange=0, Stokes=1, Intermediate, Newtons}

        public double H21
        {
            get
            {
                return B57 * (3.1416 * H16 * H19 / 12 * H17 + 2 * B58 * H20 / 12 * Math.Pow(H16, 2)) + B194 + E182 + H180 + B456 + B473 + B520 + B569 + B541 + C541;
            }
        }
    
        public  double B57 { get; set; }
        public double H16
        {
            get
            {
                return Math.Pow(((Math.Pow(H7,2)+Math.Pow((H7+2*B56/12),2))/2),0.5);
            }
        }
        public double H19
        {
            get
            {
                return B52 * (H7 * 12 / 2) / (B54 * B55 - 0.6 * B52) + B56;
            }
        }
        public double H17
        {
            get
            {
                //TODO
                return B3 == Position.Vertical ? (B877 + B39 + B40 + B41 + B42 + B43 + B44 + B45 + B46) : (B492 + H8 + B493);
            }
        }
        public  double B58 { get; set; }
        public double H20
        {
            get
            {
                //TODO
                return B52*(H7*12)/(2*B54*B55-0.2*B52)+B56;
            }
        }
        public double B194
        {
            get
            {
                //FINE
                return VLOOKUP(B181, GetLookupTable(), (B53 == 150 ? 4 : (B53 == 300 ? 5 : (B53 == 600 ? 6 : (B53 == 900 ? 7 : 8)))));
            }
        }

        private double[,] GetLookupTable(int index = 1)
        {
            //TODO
            switch(index)
            {
                case 1:
                default:
                    {
                        return new double[,]{
                            {L165,M165,N165,O165,P165,Q165,R165,S165},
                            {L166,M166,N166,O166,P166,Q166,R166,S166},
                            {L167,M167,N167,O167,P167,Q167,R167,S167},
                            {L168,M168,N168,O168,P168,Q168,R168,S168},
                            {L169,M169,N169,O169,P169,Q169,R169,S169},
                            {L170,M170,N170,O170,P170,Q170,R170,S170},
                            {L171,M171,N171,O171,P171,Q171,R171,S171},
                            {L172,M172,N172,O172,P172,Q172,R172,S172},
                            {L173,M173,N173,O173,P173,Q173,R173,S173},
                            {L174,M174,N174,O174,P174,Q174,R174,S174},
                            {L175,M175,N175,O175,P175,Q175,R175,S175},
                            {L176,M176,N176,O176,P176,Q176,R176,S176},
                            {L177,M177,N177,O177,P177,Q177,R177,S177},
                            {L178,M178,N178,O178,P178,Q178,R178,S178},
                            {L179,M179,N179,O179,P179,Q179,R179,S179},
                            {L180,M180,N180,O180,P180,Q180,R180,S180},
                            };
                    }
                case 2:
                    {
                        return new double[,]{
                            {K165,L165,M165,N165},
                            {K166,L166,M166,N166},
                            {K167,L167,M167,N167},
                            {K168,L168,M168,N168},
                            {K169,L169,M169,N169},
                            {K170,L170,M170,N170},
                            {K171,L171,M171,N171},
                            {K172,L172,M172,N172},
                            {K173,L173,M173,N173},
                            {K174,L174,M174,N174},
                            {K175,L175,M175,N175},
                            {K176,L176,M176,N176},
                            {K177,L177,M177,N177},
                            {K178,L178,M178,N178},
                            {K179,L179,M179,N179},
                            {K180,L180,M180,N180},
                            };
                    }
                case 3:
                    {
                        return new double[,]{
                            {A101,B101,C101,D101,E101,F101,G101,H101,I101},
                            {A102,B102,C102,D102,E102,F102,G102,H102,I102},
                            {A103,B103,C103,D103,E103,F103,G103,H103,I103},
                            {A104,B104,C104,D104,E104,F104,G104,H104,I104},
                            {A105,B105,C105,D105,E105,F105,G105,H105,I105},
                        };
                    }
                case 4:
                    {
                        return new double[,]{
                            {A123,B123,C123,D123,E123,F123,G123,H123,I123,J123,K123,L123,M123,N123,O123},
                            {A124,B124,C124,D124,E124,F124,G124,H124,I124,J124,K124,L124,M124,N124,O124},
                            {A125,B125,C125,D125,E125,F125,G125,H125,I125,J125,K125,L125,M125,N125,O125},
                            {A126,B126,C126,D126,E126,F126,G126,H126,I126,J126,K126,L126,M126,N126,O126},
                            {A127,B127,C127,D127,E127,F127,G127,H127,I127,J127,K127,L127,M127,N127,O127},
                        };
                    }
                case 5:
                    {
                        return new double[,]{
                            {A136,B136,C136,D136,E136,F136,G136,H136,I136,J136,K136,L136,M136,N136,O136},
                            {A137,B137,C137,D137,E137,F137,G137,H137,I137,J137,K137,L137,M137,N137,O137},
                            {A138,B138,C138,D138,E138,F138,G138,H138,I138,J138,K138,L138,M138,N138,O138},
                            {A139,B139,C139,D139,E139,F139,G139,H139,I139,J139,K139,L139,M139,N139,O139}
                        };
                    }
                case 6:
                    {
                        return new double[,]{
                            {A149,B149,C149,D149,E149,F149,G149,H149,I149,J149,K149,L149,M149,N149,O149,P149},
                            {A150,B150,C150,D150,E150,F150,G150,H150,I150,J150,K150,L150,M150,N150,O150,P150},
                            {A151,B151,C151,D151,E151,F151,G151,H151,I151,J151,K151,L151,M151,N151,O151,P151},
                        };
                    }
            }
        }

        private double VLOOKUP(double lookUpValue, double[,] tableArray, double colIndexNum, bool rangeLookup = true)
        {
            var i = 0;
            colIndexNum--;

            if(colIndexNum < 0 || colIndexNum > tableArray.GetLength(1) || lookUpValue < tableArray[0,0]) {
                return 0; //NULL
            }
    
            var lookupCol = 0;
            var values = new List<double>();
            for(i=0; i<tableArray.GetLength(0); i++)
                values.Add(tableArray[i, lookupCol]);
    
            var index = values.IndexOf(lookUpValue);
    
            if(index > -1)
                return tableArray[index, (int)colIndexNum];
    
            if(rangeLookup)
            {        
                var value = values[0];
                for (i = 0; i < values.Count; i++)
                {
                    value = values[i];
                    if(value > lookUpValue && i>0){
                        value = values[i - 1];
                        break;
                    }
                }        
                index = values.IndexOf(value);        
                return tableArray[index, (int)colIndexNum];
            }
    
            return 0; //NULL
        }

        public double E182
        {
            get
            {
                //fINE
                return VLOOKUP(E175, GetLookupTable(), (B53 == 150 ? 4 : (B53 == 300 ? 5 : (B53 == 600 ? 6 : (B53 == 900 ? 7 : 8)))));
            }
        }
        public double H180
        {
            get
            {
                //FINE
                return VLOOKUP(H174, GetLookupTable(), (B53 == 150 ? 4 : (B53 == 300 ? 5 : (B53 == 600 ? 6 : (B53 == 900 ? 7 : 8)))));
            }
        }
        public double B456
        {
            get
            {
                //TODO
                return I108 * 0.7854 * Math.Pow((B184 / 12), 2);
            }
        }
        public double B473
        {
            get
            {
                //TODO
                return (B471 == BooleanResponse.N ? 0 : B462 * E113);
            }
        }
        public double B520
        {
            get
            {
                //TODO
                return (B514 == GeneralClassification.None ? 0 : (B518 == BooleanResponse.N ? 0 : B529 * E114));
            }
        }
        public double B569
        {
            get
            {
                //TODO
                return (B567 == BooleanResponse.N ? 0 : B462 * E113);
            }
        }
        public double B541
        {
            get
            {
                //TODO
                return (B514 == GeneralClassification.Mesh ? B529 * M131 : (B514 == GeneralClassification.Vane ? B529 * L143 : (B514 == GeneralClassification.Cyclone ? B529 * N155 : 0)));
            }
        }
        public double C541
        {
            get
            {
                //TODO
                return (C514 == GeneralClassification.Mesh ? C529 * M131 : (C514 == GeneralClassification.Vane ? C529 * L143 : (C514 == GeneralClassification.Cyclone ? C529 * N155 : 0)));
            }
        }
        public double H7 { get; set; }
        public double B56 { get; set; }
        public double B52
        {
            get
            {
                //TODO
                return B18 * 1.1;
            }
        }
        public double B54 { get; set; }
        public double B55 { get; set; }
        public Position B3 { get; set; }
        public double B877
        {
            get
            {
                //TODO
                return H9 + Math.Max(B872, B875);
            }
        }
        public double B492
        {
            get
            {
                //TODO
                return (A108 >= 4 ? 0.6 * H7 : 0.4 * H7);
            }
        }
        public double H8 { get; set; }
        public double B493
        {
            get
            {
                //TODO
                return 0.5 * H7;
            }
        }
        public double B39
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? (H7 < 6 ? 0.5 : 1) : F108 * H7);
            }
        }
        public double B40
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? (H7 < 6 ? 0.75 : 1) : 0);
            }
        }
        public double B41
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? 0 : G108 * B181 / 12);
            }
        }
        public double B42
        {
            get
            {
                //TODO
                return H8;
            }
        }
        public double B43
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? 0 : B543);
            }
        }
        public double B44
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? 0.25 : (C514 == GeneralClassification.None ? 0 : Math.Max(0.2 * H7, 1.5)));
            }
        }
        public double B45
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? 0 : C543);
            }
        }
        public double B46
        {
            get
            {
                //TODO
                return (B3 == Position.Horizontal ? 0 : 0.15 * H7);
            }
        }
        public double B181
        {
            get
            {
                //FINE
                return VLOOKUP(B180, GetLookupTable(2), 2);
            }
        }
        public double B53
        {
            get
            {
                //TODO
                return (B52 < 285 ? 150 : (B52 < 740 ? 300 : (B52 < 1480 ? 600 : (B52 < 2220 ? 900 : 1500))));
            }
        }

        #region Table Nozzle Weights
        public double K165 { get; set; }
        public double L165 { get; set; }
        public double M165 { get; set; }
        public double N165
        {
            get
            {
                return B52 * M165 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O165 { get; set; }
        public double P165 { get; set; }
        public double Q165 { get; set; }
        public double R165 { get; set; }
        public double S165 { get; set; }
        public double K166
        {
            get
            {
                return M165 - 2 * N165;
            }
        }
        public double L166 { get; set; }
        public double M166 { get; set; }
        public double N166
        {
            get
            {
                return B52 * M166 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O166 { get; set; }
        public double P166 { get; set; }
        public double Q166 { get; set; }
        public double R166 { get; set; }
        public double S166 { get; set; }
        public double K167
        {
            get
            {
                return M166 - 2 * N166;
            }
        }
        public double L167 { get; set; }
        public double M167 { get; set; }
        public double N167
        {
            get
            {
                return B52 * M167 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O167 { get; set; }
        public double P167 { get; set; }
        public double Q167 { get; set; }
        public double R167 { get; set; }
        public double S167 { get; set; }
        public double K168
        {
            get
            {
                return M167 - 2 * N167;
            }
        }
        public double L168 { get; set; }
        public double M168 { get; set; }
        public double N168
        {
            get
            {
                return B52 * M168 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O168 { get; set; }
        public double P168 { get; set; }
        public double Q168 { get; set; }
        public double R168 { get; set; }
        public double S168 { get; set; }
        public double K169
        {
            get
            {
                return M168 - 2 * N168;
            }
        }
        public double L169 { get; set; }
        public double M169 { get; set; }
        public double N169
        {
            get
            {
                return B52 * M169 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O169 { get; set; }
        public double P169 { get; set; }
        public double Q169 { get; set; }
        public double R169 { get; set; }
        public double S169 { get; set; }
        public double K170
        {
            get
            {
                return M169 - 2 * N169;
            }
        }
        public double L170 { get; set; }
        public double M170 { get; set; }
        public double N170
        {
            get
            {
                return B52 * M170 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O170 { get; set; }
        public double P170 { get; set; }
        public double Q170 { get; set; }
        public double R170 { get; set; }
        public double S170 { get; set; }
        public double K171
        {
            get
            {
                return M170 - 2 * N170;
            }
        }
        public double L171 { get; set; }
        public double M171 { get; set; }
        public double N171
        {
            get
            {
                return B52 * M171 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O171 { get; set; }
        public double P171 { get; set; }
        public double Q171 { get; set; }
        public double R171 { get; set; }
        public double S171 { get; set; }
        public double K172
        {
            get
            {
                return M171 - 2 * N171;
            }
        }
        public double L172 { get; set; }
        public double M172 { get; set; }
        public double N172
        {
            get
            {
                return B52 * M172 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O172 { get; set; }
        public double P172 { get; set; }
        public double Q172 { get; set; }
        public double R172 { get; set; }
        public double S172 { get; set; }
        public double K173
        {
            get
            {
                return M172 - 2 * N172;
            }
        }
        public double L173 { get; set; }
        public double M173 { get; set; }
        public double N173
        {
            get
            {
                return B52 * M173 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O173 { get; set; }
        public double P173 { get; set; }
        public double Q173 { get; set; }
        public double R173 { get; set; }
        public double S173 { get; set; }
        public double K174
        {
            get
            {
                return M173 - 2 * N173;
            }
        }
        public double L174 { get; set; }
        public double M174 { get; set; }
        public double N174
        {
            get
            {
                return B52 * M174 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O174 { get; set; }
        public double P174 { get; set; }
        public double Q174 { get; set; }
        public double R174 { get; set; }
        public double S174 { get; set; }
        public double K175
        {
            get
            {
                return M174 - 2 * N174;
            }
        }
        public double L175 { get; set; }
        public double M175 { get; set; }
        public double N175
        {
            get
            {
                return B52 * M175 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O175 { get; set; }
        public double P175 { get; set; }
        public double Q175 { get; set; }
        public double R175 { get; set; }
        public double S175 { get; set; }
        public double K176
        {
            get
            {
                return M175 - 2 * N175;
            }
        }
        public double L176 { get; set; }
        public double M176 { get; set; }
        public double N176
        {
            get
            {
                return B52 * M176 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O176 { get; set; }
        public double P176 { get; set; }
        public double Q176 { get; set; }
        public double R176 { get; set; }
        public double S176 { get; set; }
        public double K177
        {
            get
            {
                return M176 - 2 * N176;
            }
        }
        public double L177 { get; set; }
        public double M177 { get; set; }
        public double N177
        {
            get
            {
                return B52 * M177 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O177 { get; set; }
        public double P177 { get; set; }
        public double Q177 { get; set; }
        public double R177 { get; set; }
        public double S177 { get; set; }
        public double K178
        {
            get
            {
                return M177 - 2 * N177;
            }
        }
        public double L178 { get; set; }
        public double M178 { get; set; }
        public double N178
        {
            get
            {
                return B52 * M178 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O178 { get; set; }
        public double P178 { get; set; }
        public double Q178 { get; set; }
        public double R178 { get; set; }
        public double S178 { get; set; }
        public double K179
        {
            get
            {
                return M178 - 2 * N178;
            }
        }
        public double L179 { get; set; }
        public double M179 { get; set; }
        public double N179
        {
            get
            {
                return B52 * M179 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O179 { get; set; }
        public double P179 { get; set; }
        public double Q179 { get; set; }
        public double R179 { get; set; }
        public double S179 { get; set; }
        public double K180
        {
            get
            {
                return M179 - 2 * N179;
            }
        }
        public double L180 { get; set; }
        public double M180 { get; set; }
        public double N180
        {
            get
            {
                return B52 * M180 / (2 * (20000 + 0.4 * B52));
            }
        }
        public double O180 { get; set; }
        public double P180 { get; set; }
        public double Q180 { get; set; }
        public double R180 { get; set; }
        public double S180 { get; set; }
        #endregion

        public double E175
        {
            get
            {
                //fINE
                return VLOOKUP(E174, GetLookupTable(2), 2);
            }
        }
        public double H174
        {
            get
            {
                //FINE
                return VLOOKUP(H173, GetLookupTable(2), 2);
            }
        }
        public double I108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), I97);
            }
        }
        public double B184
        {
            get
            {
                return B182 - 2 * B183;
            }
        }
        public BooleanResponse B471
        {
            get
            {
                return B113;
            }
        }
        public double B462
        {
            get
            {
                return (B3 == Position.Vertical ? 0.7854 * Math.Pow(H7, 2) : 0.7854 * Math.Pow(H7, 2) - B488);
            }
        }
        public double E113
        {
            get
            {
                return 0.25 * 144 / 1728 * (1 - 0.2) * 489;
            }
        }
        public GeneralClassification B514 { get; set; }
        public BooleanResponse B518
        {
            get
            {
                return (B514 == GeneralClassification.None ? BooleanResponse.N_A : B114);
            }
        }
        public double B529
        {
            get
            {
                return (B514== GeneralClassification.None
                    ?0//"N/A"
                    :(C514== GeneralClassification.None
                        ?((B3== Position.Vertical && B517==Position.Vertical)
                            ?Math.Min(0.7854*Math.Pow(B461,2),B460*B523/B526)
                            :B460*B523/B526):0));
            }
        }
        public double E114
        {
            get
            {
                return 0.25 * 144 / 1728 * (1 - 0.2) * 489;
            }
        }
        public BooleanResponse B567
        {
            get
            {
                return B115;
            }
        }
        public double M131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), M119, false);
            }
        }
        public double L143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), L119, false);
            }
        }
        public double N155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), N119, false);
            }
        }
        public GeneralClassification C514 { get; set; }
        public double C529
        {
            get
            {
                return (C514 == GeneralClassification.None? 0 : B460 * B523 / C526); //N/A 0
            }
        }
        public double B18 { get; set; }
        public double H9 { get; set; }
        public double B872
        {
            get
            {
                return (B3 == Position.Vertical ? B860 + B868 / (0.7854 * Math.Pow(H7, 2)) + B865 : B871 * H7);
            }
        }
        public double B875
        {
            get
            {
                return B860 + B49 + B865;
            }
        }
        public double F108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), F97);
            }
        }
        public double G108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), G97);
            }
        }
        public double B543
        {
            get
            {
                return (B514 == GeneralClassification.None ? 0 : (B517 == Position.Vertical ? 1.2 * B542 : Math.Pow((1.5 * B529), 0.5) + 1));
            }
        }
        public double C543
        {
            get
            {
                return (C514 == GeneralClassification.None ? 0 : (C517 == Position.Vertical ? 1.2 * C542 : 0));
            }
        }
        public double B180
        {
            get
            {
                return (Math.Pow((B179 / 0.7854), 0.5)) * 12;
            }
        }
        public double A108 { get; set; }
        public double E174
        {
            get
            {
                return (Math.Pow((E173 / 0.7854), 0.5)) * 12;
            }
        }
        public double H173
        {
            get
            {
                return Math.Max((Math.Pow((H172 / 0.7854), 0.5)) * 12, 2);
            }
        }
        public double I97
        {
            get
            {
                return H97 + 1;
            }
        }

        #region Table Inlet Device
        public double A101 { get; set; }
        public double B101 { get; set; }
        public double C101 { get; set; }
        public double D101
        {
            get
            {
                return C101 * 1.488;
            }
        }
        public double E101 { get; set; }
        public double F101 { get; set; }
        public double G101 { get; set; }
        public double H101 { get; set; }
        public double I101 { get; set; }
        public double A102 { get; set; }
        public double B102 { get; set; }
        public double C102 { get; set; }
        public double D102
        {
            get
            {
                return C102 * 1.488;
            }
        }
        public double E102 { get; set; }
        public double F102 { get; set; }
        public double G102 { get; set; }
        public double H102 { get; set; }
        public double I102 { get; set; }
        public double A103 { get; set; }
        public double B103 { get; set; }
        public double C103 { get; set; }
        public double D103
        {
            get
            {
                return C103 * 1.488;
            }
        }
        public double E103 { get; set; }
        public double F103 { get; set; }
        public double G103 { get; set; }
        public double H103 { get; set; }
        public double I103 { get; set; }
        public double A104 { get; set; }
        public double B104 { get; set; }
        public double C104 { get; set; }
        public double D104
        {
            get
            {
                return C104 * 1.488;
            }
        }
        public double E104 { get; set; }
        public double F104 { get; set; }
        public double G104 { get; set; }
        public double H104 { get; set; }
        public double I104 { get; set; }
        public double A105 { get; set; }
        public double B105 { get; set; }
        public double C105 { get; set; }
        public double D105
        {
            get
            {
                return C105 * 1.488;
            }
        }
        public double E105 { get; set; }
        public double F105 { get; set; }
        public double G105 { get; set; }
        public double H105 { get; set; }
        public double I105 { get; set; }
        #endregion

        public double B182
        {
            get
            {
                //fINE
                return VLOOKUP(B180, GetLookupTable(2), 3);
            }
        }
        public double B183
        {
            get
            {
                return B52 * B182 / (2 * (20000 + 0.4 * B52));
            }
        }
        public BooleanResponse B113 { get; set; }
        public double B488
        {
            get
            {
                return B483 * (1 / 3.1416 * Math.Acos(1 - 2 * B878) - 2 / 3.1416 * (1 - 2 * B878) * Math.Pow((B878 - Math.Pow(B878, 2)), 0.5));
            }
        }
        public BooleanResponse B114 { get; set; }
        public double B461
        {
            get
            {
                return H7;
            }
        }
        public Position B517
        {
            get
            {
                return (B514 == GeneralClassification.Mesh ? C131 : (B514 == GeneralClassification.Vane ? C143 : (B514 == GeneralClassification.Cyclone ? C155 : Position.N_A)));
            }
        }
        public double B526
        {
            get
            {
                return (B514 == GeneralClassification.None
                    ? 0 //"N/A"
                    : B525 * Math.Pow(((E33 - E20) / E20), 0.5));
            }
        }
        public double B523
        {
            get
            {
                return (B514 == GeneralClassification.None
                ? 0//"N/A"
                : Math.Max(((B521 - 1) * (1 - 0.2 * B522) + 1), 1));
            }
        }
        public double B460
        {
            get
            {
                return E21;
            }
        }
        public BooleanResponse B115 { get; set; }
        public double M119
        {
            get
            {
                return L119 + 1;
            }
        }
        /// <summary>
        /// Mesh Pads Selector: None 1, M1 =1 M2 = 2, M3 = 3, M4 = 4
        /// </summary>
        public double A131 { get; set; }

        #region Table Mesh Pads
        public double A123 { get; set; }
        public double A124 { get; set; }
        public double A125 { get; set; }
        public double A126 { get; set; }
        public double A127 { get; set; }
        public double B123 { get; set; }
        public double B124 { get; set; }
        public double B125 { get; set; }
        public double B126 { get; set; }
        public double B127 { get; set; }
        public double C123 { get; set; }
        public double C124 { get; set; }
        public double C125 { get; set; }
        public double C126 { get; set; }
        public double C127 { get; set; }
        public double D123 { get; set; }
        public double D124 { get; set; }
        public double D125 { get; set; }
        public double D126 { get; set; }
        public double D127 { get; set; }
        public double E123 { get; set; }
        public double E124 { get; set; }
        public double E125 { get; set; }
        public double E126 { get; set; }
        public double E127 { get; set; }
        public double F123 { get; set; }
        public double F124 { get; set; }
        public double F125 { get; set; }
        public double F126 { get; set; }
        public double F127 { get; set; }
        public double G123 { get; set; }
        public double G124 { get; set; }
        public double G125 { get; set; }
        public double G126 { get; set; }
        public double G127 { get; set; }
        public double H123 { get; set; }
        public double H124 { get; set; }
        public double H125 { get; set; }
        public double H126 { get; set; }
        public double H127 { get; set; }
        public double I123 { get; set; }
        public double I124
        {
            get
            {
                return (C124 == (double)Position.Vertical ? 0.38 : 0.67 * 0.38);
            }
        }
        public double I125
        {
            get
            {
                return (C125 == (double)Position.Vertical ? 0.35 : 0.67 * 0.35);
            }
        }
        public double I126
        {
            get
            {
                return (C126 == (double)Position.Vertical ? 0.35 : 0.67 * 0.35);
            }
        }
        public double I127
        {
            get
            {
                return (C125 == (double)Position.Vertical ? 0.25 : 0.67 * 0.25);
            }
        }
        public double J123 { get; set; }
        public double J124 { get; set; }
        public double J125 { get; set; }
        public double J126 { get; set; }
        public double J127 { get; set; }
        public double K123 { get; set; }
        public double K124 { get; set; }
        public double K125 { get; set; }
        public double K126 { get; set; }
        public double K127 { get; set; }
        public double L123 { get; set; }
        public double L124
        {
            get
            {
                return 2 * 0.8 * D124 * H124 / ((F124 / 12) * 493);
            }
        }
        public double L125
        {
            get
            {
                return 2 * 0.8 * D125 * H125 / ((F125 / 12) * 493);
            }
        }
        public double L126
        {
            get
            {
                return 2 * 0.8 * D126 * H126 / ((F126 / 12) * 493);
            }
        }
        public double L127
        {
            get
            {
                return 2 * 0.8 * D127 * H127 / ((F127 / 12) * 493);
            }
        }
        public double M123 { get; set; }
        public double M124
        {
            get
            {
                return 1.1 * D124;
            }
        }
        public double M125
        {
            get
            {
                return 1.1 * D125;
            }
        }
        public double M126
        {
            get
            {
                return 1.1 * D126;
            }
        }
        public double M127
        {
            get
            {
                return 1.1 * D127;
            }
        }
        public double N123 { get; set; }
        public double N124 { get; set; }
        public double N125 { get; set; }
        public double N126 { get; set; }
        public double N127 { get; set; }
        public double O123 { get; set; }
        public double O124
        {
            get
            {
                return (H7 < 6 ? 1.5 : 2);
            }
        }
        public double O125
        {
            get
            {
                return (H7 < 6 ? 1.5 : 2);
            }
        }
        public double O126
        {
            get
            {
                return (H7 < 6 ? 1.5 : 2);
            }
        }
        public double O127
        {
            get
            {
                return (H7 < 6 ? 1.5 : 2);
            }
        }
        #endregion

        /// <summary>
        /// Vane Packs Selector: None = 0, V1 = 1, V2 = 2, V3 = 3
        /// </summary>
        public double A143 { get; set; }
        public double L119
        {
            get
            {
                return K119 + 1;
            }
        }

        #region Table Vane Packs
        public double A136 { get; set; }
        public double A137 { get; set; }
        public double A138 { get; set; }
        public double A139 { get; set; }
        public double B136 { get; set; }
        public double B137 { get; set; }
        public double B138 { get; set; }
        public double B139 { get; set; }
        public double C136 { get; set; }
        public double C137 { get; set; }
        public double C138 { get; set; }
        public double C139 { get; set; }
        public double D136 { get; set; }
        public double D137 { get; set; }
        public double D138 { get; set; }
        public double D139 { get; set; }
        public double E136 { get; set; }
        public double E137 { get; set; }
        public double E138 { get; set; }
        public double E139 { get; set; }
        public double F136 { get; set; }
        public double F137 { get; set; }
        public double F138 { get; set; }
        public double F139 { get; set; }
        public double G136 { get; set; }
        public double G137 { get; set; }
        public double G138 { get; set; }
        public double G139 { get; set; }
        public double H136 { get; set; }
        public double H137
        {
            get
            {
                return (C137 == (double)Position.Vertical ? 0.5 : 0.65);
            }
        }
        public double H138
        {
            get
            {
                return (C138 == (double)Position.Vertical ? 0.8 : 0.9);
            }
        }
        public double H139
        {
            get
            {
                return (C139 == (double)Position.Vertical ? 1 : 1.15);
            }
        }
        public double I136 { get; set; }
        public double I137 { get; set; }
        public double I138 { get; set; }
        public double I139 { get; set; }
        public double J136 { get; set; }
        public double J137 { get; set; }
        public double J138 { get; set; }
        public double J139 { get; set; }
        public double K136 { get; set; }
        public double K137 { get; set; }
        public double K138 { get; set; }
        public double K139 { get; set; }
        public double L136 { get; set; }
        public double L137 { get; set; }
        public double L138 { get; set; }
        public double L139 { get; set; }
        public double M136 { get; set; }
        public double M137 { get; set; }
        public double M138 { get; set; }
        public double M139 { get; set; }
        public double N136 { get; set; }
        public double N137 { get; set; }
        public double N138 { get; set; }
        public double N139 { get; set; }
        public double O136 { get; set; }
        public double O137
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        public double O138
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        public double O139
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        #endregion

        /// <summary>
        /// Demisting Cyclone Selector: None = 0, C1 = 1, C2 = 2
        /// </summary>
        public double A155 { get; set; }
        public double N119
        {
            get
            {
                return M119 + 1;
            }
        }

        #region Table Demisting Cyclones
        public double A149 { get; set; }
        public double A150 { get; set; }
        public double A151 { get; set; }
        public double B149 { get; set; }
        public double B150 { get; set; }
        public double B151 { get; set; }
        public double C149 { get; set; }
        public double C150 { get; set; }
        public double C151 { get; set; }
        public double D149 { get; set; }
        public double D150 { get; set; }
        public double D151 { get; set; }
        public double E149 { get; set; }
        public double E150 { get; set; }
        public double E151 { get; set; }
        public double F149 { get; set; }
        public double F150
        {
            get
            {
                return 144 / Math.Pow((D150 * E150) , 2);
            }
        }
        public double F151
        {
            get
            {
                return 144 / Math.Pow((D151 * E151), 2);
            }
        }
        public double G149 { get; set; }
        public double G150
        {
            get
            {
                return F150 * 0.7854 * Math.Pow((D150 / 12), 2);
            }
        }
        public double G151
        {
            get
            {
                return F151 * 0.7854 * Math.Pow((D151 / 12), 2);
            }
        }
        public double H149 { get; set; }
        public double H150 { get; set; }
        public double H151 { get; set; }
        public double I149 { get; set; }
        public double I150 { get; set; }
        public double I151 { get; set; }
        public double J149 { get; set; }
        public double J150 { get; set; }
        public double J151 { get; set; }
        public double K149 { get; set; }
        public double K150 { get; set; }
        public double K151 { get; set; }
        public double L149 { get; set; }
        public double L150 { get; set; }
        public double L151 { get; set; }
        public double M149 { get; set; }
        public double M150 { get; set; }
        public double M151 { get; set; }
        public double N149 { get; set; }
        public double N150 { get; set; }
        public double N151 { get; set; }
        public double O149 { get; set; }
        public double O150 { get; set; }
        public double O151 { get; set; }
        public double P149
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        public double P150
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        public double P151
        {
            get
            {
                return (H7 < 6 ? 2 : 2.5);
            }
        }
        #endregion

        public double C526
        {
            get
            {
                return (C514 == GeneralClassification.None
                 ? 0 //"N/A"
                 : C525 * Math.Pow(((E33 - E20) / E20), 0.5));
            }
        }
        public double B860
        {
            get
            {
                return H9 + Math.Max(B848, Math.Max(B855, B858));
            }
        }
        public double B868
        {
            get
            {
                return E32 * 60 * B50;
            }
        }
        public double B865
        {
            get
            {
                return (B15 == BooleanResponse.N ? 0 : 1);
            }
        }
        public double B871
        {
            get
            {
                return 5.6548 * Math.Pow(B870, 5) - 14.137 * Math.Pow(B870 , 4) + 13.385 * Math.Pow(B870 , 3) - 5.9405 * Math.Pow(B870 , 2) + 2.0325 * B870 + 0.002574;
            }
        }
        public double B49
        {
            get
            {
                return (H7 < 6 ? 0.5 : 0.75);
            }
        }
        public double F97
        {
            get
            {
                return E97 + 1;
            }
        }
        public double G97
        {
            get
            {
                return F97 + 1;
            }
        }
        public double B542
        {
            get
            {
                return (B514 == GeneralClassification.None ? 0 : (B514 == GeneralClassification.Mesh ? H131 : (B514 == GeneralClassification.Vane ? G143 : (B514 == GeneralClassification.Cyclone ? (H155 / 12) 
                    : 0 // "N/A"
                    ))));
            }
        }
        public double C542
        {
            get
            {
                return (C514 == GeneralClassification.None ? 0 : (C514 == GeneralClassification.Mesh ? H131 : (C514 == GeneralClassification.Vane ? G143 : (C514 == GeneralClassification.Cyclone ? H155 :
                    0 //"N/A"
                    ))));
            }
        }
        public Position C517
        {
            get
            {
                return (C514 == GeneralClassification.Mesh ? C131 : (C514 == GeneralClassification.Vane ? C143 : (C514 == GeneralClassification.Cyclone ? C155 
                    : 0//"N/A"
                    )));
            }
        }
        public double B179
        {
            get
            {
                return B168 / B178;
            }
        }
        public double E173
        {
            get
            {
                return E169 / E172;
            }
        }
        public double H172
        {
            get
            {
                return H169 / H171;
            }
        }
        public double H97
        {
            get
            {
                return G97 + 1;
            }
        }
        public double B483
        {
            get
            {
                return 0.7854 * Math.Pow(H7, 2);
            }
        }
        public double B878
        {
            get
            {
                return B877 / H7;
            }
        }
        public Position C131
        {
            get
            {
                return (Position)VLOOKUP(A131, GetLookupTable(4), C119, false);
            }
        }
        public Position C143
        {
            get
            {
                return (Position)VLOOKUP(A143, GetLookupTable(5), C119, false);
            }
        }
        public Position C155
        {
            get
            {
                return (Position)VLOOKUP(A155, GetLookupTable(6), C119, false);
            }
        }
        public double E33
        {
            get
            {
                return (350 * (141.5 / (131.5 + B21)) + 0.0764 * B20 * E29) / (5.615 * E30);
            }
        }
        public double B525
        {
            get
            {
                return (B514 == GeneralClassification.None ?
                    0 //"N/A"
                    : B524 * ((B18 < 350 ? 1 - 0.17 / 300 * B18 : 0.84 - 0.12 / 1650 * B18)));
            }
        }
        public double E20
        {
            get
            {
                return (B18 + B29) * E10 / (E19 * 10.73 * (B16 + 460));
            }
        }
        public double B521
        {
            get
            {
                return (B518 == BooleanResponse.N ? B474 : (B474 - 1) * (1 - C114) + 1);
            }
        }
        public double B522
        {
            get
            {
                return (B514 == GeneralClassification.None ? 0 :
                    (B514 == GeneralClassification.Mesh ? 0.193 * (0.05 * 1 + 1) * L131 * E20 * Math.Pow(B526, 2) / (2 * 32.17) :
                    (B514 == GeneralClassification.Vane ? 0.193 * (0.05 * 1 + 1) * K143 * E20 * Math.Pow(B526, 2) / (2 * 32.17) :
                    (B514 == GeneralClassification.Cyclone ? 0.193 * (0.05 * 1 + 1) * L155 * E20 * Math.Pow(B526, 2) / (2 * 32.17) :
                    0 //"N/A"
                    ))));
            }
        }
        public double E21
        {
            get
            {
                return (B13 * 1000000 - B12 * E29) / 86400 / 379.4 * E10 / E20;
            }
        }
        public double K119
        {
            get
            {
                return J119 + 1;
            }
        }

        public double C525
        {
            get
            {
                return (C514 == GeneralClassification.None ?
                    0 //"N/A"
                    : C524 * ((B18 < 350 ? 1 - 0.17 / 300 * B18 : 0.84 - 0.12 / 1650 * B18)));
            }
        }
        public double B848
        {
            get
            {
                return (B3 == Position.Vertical ? B831 + (B842 + B838) / Math.Pow((0.7854 * H7), 2) : B847 * H7);
            }
        }
        public double B855
        {
            get
            {
                return (B3 == Position.Vertical ? B831 + B851 / (0.7854 * Math.Pow(H7, 2)) : B854 * H7);
            }
        }
        public double B858
        {
            get
            {
                return B831 + B47;
            }
        }
        public double E32
        {
            get
            {
                return B12*E30*5.615/86400;
            }
        }
        public double B50 { get; set; }
        public BooleanResponse B15 { get; set; }
        public double B870
        {
            get
            {
                return B869 / (0.7854 * Math.Pow(H7, 2));
            }
        }
        public double E97
        {
            get
            {
                return D97 + 1;
            }
        }
        public double H131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), H119, false);
            }
        }
        public double G143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), G119, false);
            }
        }
        public double H155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), H119, false);
            }
        }
        public double B168
        {
            get
            {
                return E21+E32;
            }
        }
        public double B178
        {
            get
            {
                return Math.Pow((B174 / B169), 0.5);
            }
        }
        public double E169
        {
            get
            {
                return E21;
            }
        }
        public double E172
        {
            get
            {
                return Math.Pow((E171 / E170), 0.5);
            }
        }
        public double H169
        {
            get
            {
                return E32;
            }
        }
        public double H171 { get; set; }
        public double C119
        {
            get
            {
                return B119 + 1;
            }
        }
        public double B21 { get; set; }
        public double B20 { get; set; }
        public double E29
        {
            get
            {
                return (B21 <= 30 ? 0.0362 * B20 * (Math.Pow((B18 + B29), 1.0937)) * Math.Exp(25.724 * B21 / (B16 + 460)) : 1.15 * 0.0178 * B20 * (Math.Pow((B18 + B29), 1.187)) * Math.Exp(23.931 * B21 / (B16 + 460)));
            }
        }
        public double E30
        {
            get
            {
                return (B21 <= 30 ? 1 + 0.0004677 * E29 + 0.00001751 * (B16 - 60) * (B21 / B20) - 0.00000001811 * E29 * (B16 - 60) * (B21 / B20) : 1 + 0.000467 * E29 + 0.000011 * (B16 - 60) * (B21 / B20) + 0.000000001337 * E29 * (B16 - 60) * (B21 / B20));
            }
        }
        public double B524
        {
            get
            {
                return (B514 == GeneralClassification.Mesh ? I131 : (B514 == GeneralClassification.Vane ? H143 : (B514 == GeneralClassification.Cyclone ? J155 : 0//"N/A"
                    )));
            }
        }
        public double B29 { get; set; }
        public double E10
        {
            get
            {
                return B20 * 29;
            }
        }
        public double E19
        {
            get
            {
                return E15 + (1 - E15) * (Math.Exp(-E16)) + E17 * Math.Pow(E14, E18);
            }
        }
        public double B16 { get; set; }
        public double B474
        {
            get
            {
                return (B471 == BooleanResponse.N ? B470 : (B470 - 1) * (1 - C113) + 1);
            }
        }
        public double C114 { get; set; }
        public double L131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), L119, false);
            }
        }
        public double K143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), K119, false);
            }
        }
        public double L155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), L119, false);
            }
        }
        public double B13
        {
            get
            {
                return B8 * B11;
            }
        }
        public double B12
        {
            get
            {
                return B7 * B11;
            }
        }
        public double J119
        {
            get
            {
                return I119 + 1;
            }
        }

        public double C524
        {
            get
            {
                return (C514 == GeneralClassification.Mesh ? I131 : (C514 == GeneralClassification.Vane ? H143 : (C514 == GeneralClassification.Cyclone ? J155 : 0//"N/A"
                    )));
            }
        }
        public double B831
        {
            get
            {
                return H9 + Math.Max(B826, B829);
            }
        }
        public double B842
        {
            get
            {
                return B841 * 5.615;
            }
        }
        public double B838
        {
            get
            {
                return B837 * 5.615;
            }
        }
        public double B847
        {
            get
            {
                return 5.6548 * Math.Pow(B846 , 5) - 14.137 * Math.Pow(B846 , 4) + 13.385 * Math.Pow(B846 , 3) - 5.9405 * Math.Pow(B846 , 2) + 2.0325 * B846 + 0.002574;
            }
        }
        public double B851
        {
            get
            {
                return E32 * (B48 * 60);
            }
        }
        public double B854
        {
            get
            {
                return 5.6548 * Math.Pow(B853 , 5) - 14.137 * Math.Pow(B853 , 4) + 13.385 * Math.Pow(B853 , 3) - 5.9405 * Math.Pow(B853 , 2) + 2.0325 * B853 + 0.002574;
            }
        }
        public double B47
        {
            get
            {
                return (H7 < 6 ? 1.17 : 1.5);
            }
        }
        public double B869
        {
            get
            {
                return B487 + B868 / (B492 + H8 + B493);
            }
        }
        public double D97
        {
            get
            {
                return C97 + 1;
            }
        }
        public double H119
        {
            get
            {
                return G119 + 1;
            }
        }
        public double G119
        {
            get
            {
                return F119 + 1;
            }
        }
        public double B174
        {
            get
            {
                return B173 * B172;
            }
        }
        public double B169
        {
            get
            {
                return (E21 * E20 + E32 * E33) / B168;
            }
        }
        public double E171 { get; set; }
        public double E170
        {
            get
            {
                return E20;
            }
        }
        public double B119
        {
            get
            {
                return A119 + 1;
            }
        }
        public double I131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), I119, false);
            }
        }
        public double H143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), H119, false);
            }
        }
        public double J155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), J119, false);
            }
        }
        public double E15
        {
            get
            {
                return 1.39 * Math.Pow((E13 - 0.92) , 0.5) - 0.36 * E13 - 0.101;
            }
        }
        public double E16
        {
            get
            {
                return (0.62 - 0.23 * E13) * E14 + ((0.066 / (E13 - 0.86)) - 0.037) * Math.Pow(E14 , 2) + (0.32 * Math.Pow(E14 , 6)) / Math.Exp(20.723 * (E13 - 1));
            }
        }
        public double E17
        {
            get
            {
                return 0.132 - 0.32 * Math.Log10(E13);
            }
        }
        public double E14
        {
            get
            {
                return (B18 + B29) / E12;
            }
        }
        public double E18
        {
            get
            {
                return Math.Exp(0.715 - 1.128 * E13 + 0.42 * Math.Pow(E13, 2));
            }
        }
        public double B470
        {
            get
            {
                return Math.Max(1,(A108==1?(3.011-0.2136*B469)/(1+0.1541*B469-0.01749*Math.Pow(B469,2)):(A108==2?(2.002-0.02044*B469)/(1+0.14936*B469-0.007879*Math.Pow(B469,2)):(A108==3?(1.6002+0.05315*B469)/(1+0.15228*B469-0.0045517*Math.Pow(B469,2)):(A108==4?(1.3009+0.18943*B469)/(1+0.22544*B469-0.0009816*Math.Pow(B469,2)):(1.4501+0.094073*B469)/(1+0.16319*B469-0.0029191*Math.Pow(B469,2)))))));
            }
        }
        public double C113 { get; set; }
        public double B8 { get; set; }
        public double B11 { get; set; }
        public double B7 { get; set; }
        public double I119
        {
            get
            {
                return H119 + 1;
            }
        }

        public double B826
        {
            get
            {
                return (B3 == Position.Vertical ? B816 + B822 / (0.7854 * Math.Pow(H7, 2)) : B825 * H7);
            }
        }
        public double B829
        {
            get
            {
                return B816 + B49;
            }
        }
        public double B841
        {
            get
            {
                return B837;
            }
        }
        public double B837
        {
            get
            {
                return B14 * B190 * 0.7854 * Math.Pow((B184 / 12), 2) / 5.615;
            }
        }
        public double B846
        {
            get
            {
                return B845 / (0.7854 * Math.Pow(H7, 2));
            }
        }
        public double B48 { get; set; }
        public double B853
        {
            get
            {
                return B852 / (0.7854 * Math.Pow(H7, 2));
            }
        }
        public double B487
        {
            get
            {
                return B483 * (1 / 3.1416 * Math.Acos(1 - 2 * B861) - 2 / 3.1416 * (1 - 2 * B861) * Math.Pow((B861 - Math.Pow(B861, 2)), 0.5));
            }
        }
        public double C97
        {
            get
            {
                return B97 + 1;
            }
        }
        public double F119
        {
            get
            {
                return E119 + 1;
            }
        }
        public double B173 { get; set; }
        public double B172
        {
            get
            {
                return C108;
            }
        }
        public double A119 { get; set; }
        public double E13
        {
            get
            {
                return (B16 + 460) / E11;
            }
        }
        public double E12
        {
            get
            {
                return 690 - 35 * B20;
            }
        }
        public double B469
        {
            get
            {
                return (B3 == Position.Vertical ? H8 / H7 : H8 / B468);
            }
        }

        public double B816
        {
            get
            {
                return B51;
            }
        }
        public double B822
        {
            get
            {
                return E32 * 60 * B50;
            }
        }
        public double B825
        {
            get
            {
                return 5.6548 * Math.Pow(B824 , 5) - 14.137 * Math.Pow(B824 , 4) + 13.385 * Math.Pow(B824 , 3) - 5.9405 * Math.Pow(B824 , 2) + 2.0325 * B824 + 0.002574;
            }
        }
        public double B14 { get; set; }
        public double B190
        {
            get
            {
                return B188 + B189;
            }
        }
        public double B845
        {
            get
            {
                return B485 + B844 / (B492 + H8 + B493);
            }
        }
        public double B852
        {
            get
            {
                return B485 + B851 / (B492 + H8 + B493);
            }
        }
        public double B861
        {
            get
            {
                return B860 / H7;
            }
        }
        public double B97
        {
            get
            {
                return A97 + 1;
            }
        }
        public double E119
        {
            get
            {
                return D119 + 1;
            }
        }
        public double C108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), C97);
            }
        }
        public double E11
        {
            get
            {
                return 158 + 330 * B20;
            }
        }
        public double B468
        {
            get
            {
                return Math.Pow(((B483 - B488) / 0.7854), 0.5);
            }
        }

        public double B51
        {
            get
            {
                return (H7 < 6 ? 0.5 : 1);
            }
        }
        public double B824
        {
            get
            {
                return B823 / (0.7854 * Math.Pow(H7 , 2));
            }
        }
        public double B188
        {
            get
            {
                return E21 / (0.7854 * Math.Pow((B184 / 12), 2));
            }
        }
        public double B189
        {
            get
            {
                return E32 / (0.7854 * Math.Pow((B184 / 12), 2));
            }
        }
        public double B485
        {
            get
            {
                return B483 * (1 / 3.1416 * Math.Acos(1 - 2 * B832) - 2 / 3.1416 * (1 - 2 * B832) * Math.Pow((B832 - Math.Pow(B832 , 2)) , 0.5));
            }
        }
        public double B844
        {
            get
            {
                return B838 + B842;
            }
        }
        public double A97 { get; set; }
        public double D119
        {
            get
            {
                return C119 + 1;
            }
        }

        public double B823
        {
            get
            {
                return B819 + B822 / (B492 + H8 + B493);
            }
        }
        public double B832
        {
            get
            {
                return B831 / H7;
            }
        }
        public double B819
        {
            get
            {
                return 0.7854 * Math.Pow(H7, 2) * B818;
            }
        }
        public double B818
        {
            get
            {
                return 1 / 3.1416 * Math.Acos(1 - 2 * B817) - 2 / 3.1416 * (1 - 2 * B817) * Math.Pow((B817 - Math.Pow(B817 , 2)) , 0.5);
            }
        }
        public double B817
        {
            get
            {
                return B816 / H7;
            }
        }

        #region Constraint Variales
        public double I72
        {
            get
            {
                return H60 - H61;
            }
        }
        public double I73
        {
            get
            {
                return H61 - H63;
            }
        }
        public double I74
        {
            get
            {
                return H63 - H64;
            }
        }
        public double K72
        {
            get
            {
                return J72 / 60;
            }
        }
        public double K73
        {
            get
            {
                return J73 / 60;
            }
        }
        public double K74
        {
            get
            {
                return J74 / 60;
            }
        }
        public double H28
        {
            get
            {
                return H15 - B36;
            }
        }
        public double H29
        {
            get
            {
                return H17 - B35;
            }
        }
        public double H30
        {
            get
            {
                return (B3 == Position.Vertical ? H8 - H108 * H7 : 99);
            }
        }
        public double H31
        {
            get
            {
                return H18 - B37;
            }
        }
        public double H32
        {
            get
            {
                return H18 - B38;
            }
        }
        public double H33
        {
            get
            {
                return C68 - B68;
            }
        }
        public double H34
        {
            get
            {
                return C81 - B81;
            }
        }
        public double H35
        {
            get
            {
                return (B3 == Position.Vertical ? H7 - B528 : 99);
            }
        }
        public double H37
        {
            get
            {
                return (B3 == Position.Horizontal ? B506 - B502 : -99);
            }
        }
        public double H38
        {
            get
            {
                return C70 - B70;
            }
        }
        public double H39
        {
            get
            {
                return C69 - B69;
            }
        }
        public double H42
        {
            get
            {
                return (B3 == Position.Horizontal ? I60 - B550 : -99);
            }
        }
        public double H44
        {
            get
            {
                return (B3 == Position.Horizontal ? (B549 - B877) - B40 : 99);
            }
        }
        public double H43
        {
            get
            {
                return (B3 == Position.Horizontal ? B551 - B552 : 99);
            }
        }
        public double H60
        {
            get
            {
                return B877;
            }
        }
        public double H61
        {
            get
            {
                return B860;
            }
        }
        public double H63
        {
            get
            {
                return B831;
            }
        }
        public double H64
        {
            get
            {
                return B816;
            }
        }
        public double J72
        {
            get
            {
                return H72 / E32;
            }
        }
        public double J73
        {
            get
            {
                return H73 / E32;
            }
        }
        public double J74
        {
            get
            {
                return H74 / E32;
            }
        }
        public double B35 { get; set; }
        public double H15
        {
            get
            {
                return H7 + 2 * H19 / 12;
            }
        }
        public double B36 { get; set; }
        public double H108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), H97);
            }
        }
        public double H18
        {
            get
            {
                return H17 / H15;
            }
        }
        public double B37 { get; set; }
        public double B38
        {
            get
            {
                return (B3 == Position.Vertical ? 1.5 : 2.5);
            }
        }
        public double C68
        {
            get
            {
                return Z441; //OHh my gosh!!!
            }
        }
        public double B68 { get; set; }
        public double B81
        {
            get
            {
                return (B3 == Position.Horizontal ? 0.75 : 0.5);
            }
        }
        public double C81
        {
            get
            {
                return B465;
            }
        }
        public double B528
        {
            get
            {
                return ((B3 == Position.Vertical && B517 == Position.Vertical) ? Math.Pow((B527 / 0.7854), 0.5) :
                    0 //"N/A"
                    );
            }
        }
        public double B506
        {
            get
            {
                return B504 - B505;
            }
        }
        public double B502
        {
            get
            {
                return (B500 < 160 ? 1.5 * (E41 / (E39 * 0.000672)) * (Math.Pow((E33 / E20), 0.5)) * Math.Pow(B500, -0.5) : ((B500 <= 1635 && B501 <= 0.0667) ? 11.78 * (E41 / (E39 * 0.000672)) * (Math.Pow((E33 / E20), 0.5)) * Math.Pow(B501, 0.8) * Math.Pow(B500, -0.333) : ((B500 <= 1635 && B501 > 0.0667) ? 1.35 * (E41 / (E39 * 0.000672)) * (Math.Pow((E33 / E20), 0.5)) * Math.Pow(B500, -0.333) : ((B500 > 1635 && B501 <= 0.0667) ? (E41 / (E39 * 0.000672)) * (Math.Pow((E33 / E20), 0.5)) * Math.Pow(B501, 0.8) : ((B500 > 1635 && B501 > 0.0667) ? 0.1146 * (E41 / (E39 * 0.000672)) * (Math.Pow((E33 / E20), 0.5)) : 0 //"????"
                    )))));
            }
        }
        public double C70
        {
            get
            {
                return B576;
            }
        }
        public double B70 { get; set; }
        public double C69
        {
            get
            {
                return B600;
            }
        }
        public double B69 { get; set; }
        public double I60
        {
            get
            {
                return (B3 == Position.Vertical ? H60 / H17 : H60 / H59);
            }
        }
        public double B550
        {
            get
            {
                return (B514 == GeneralClassification.Mesh ? N131 : (B514 == GeneralClassification.Vane ? M143 : (B514 == GeneralClassification.Cyclone ? O155 : 0.8)));
            }
        }
        public double B549
        {
            get
            {
                return (B514 == GeneralClassification.None ? H7 : (B517 == Position.Vertical ? B545 - B546 - 1.2 * (B542 + C542) : H7 - 1.1 * H7 * (5.6548 * Math.Pow((B529 / B483), 5) - 14.137 * Math.Pow((B529 / B483), 4) + 13.385 * Math.Pow((B529 / B483), 3) - 5.9405 * Math.Pow((B529 / B483), 2) + 2.0325 * (B529 / B483) + 0.002574)));
            }
        }
        public double B551
        {
            get
            {
                return H7 - B877;
            }
        }
        public double B552
        {
            get
            {
                return (B514 == GeneralClassification.Mesh ? O131 : (B514 == GeneralClassification.Vane ? N143 : (B514 == GeneralClassification.Cyclone ? P155 : 0)));
            }
        }
        public double H72
        {
            get
            {
                return (B3 == Position.Vertical ? 0.7854 * Math.Pow(H7, 2) * (H60 - H61) : (B488 - B487) * H8);
            }
        }
        public double H73
        {
            get
            {
                return (B3 == Position.Vertical ? 0.7854 * Math.Pow(H7, 2) * (H61 - H63) : (B487 - B485) * H8);
            }
        }
        public double H74
        {
            get
            {
                return (B3 == Position.Vertical ? 0.7854 * Math.Pow(H7, 2) * (H63 - H64) : (B485 - B484) * H8);
            }
        }
        public double B465
        {
            get
            {
                return B463 / Math.Pow(((E33 - E20) / E20), 0.5);
            }
        }
        public double B527
        {
            get
            {
                return ((B514 == GeneralClassification.None || B517 == Position.Horizontal) ? 0 : B460 * B523 / B526);
            }
        }
        public double B504
        {
            get
            {
                return B475;
            }
        }
        public double B505
        {
            get
            {
                return B571;
            }
        }
        public double B500
        {
            get
            {
                return E33 * B499 * B498 / (E39 * 0.000672);
            }
        }
        public double E41
        {
            get
            {
                return E40 * 0.001 * 2.205;
            }
        }
        public double E39
        {
            get
            {
                return E37 * Math.Pow(E36, E38);
            }
        }
        public double B501
        {
            get
            {
                return E39 * 0.000672 / Math.Pow((E33 * E41 * Math.Pow((E41 / (32.2 * (E33 - E20))), 0.5)), 0.5);
            }
        }
        public double B576
        {
            get
            {
                return (B575 == SettlingLaw.Stokes ? 304800 * Math.Pow((B573 * 18 * E39 / (1488 * 32.2 * (E33 - E20))), 0.5) : (B575 == SettlingLaw.Intermediate ? 304800 * Math.Pow((B573 * Math.Pow(E33, 0.29) * Math.Pow(E39, 0.43) / (3.54 * Math.Pow(32.2, 0.71) * Math.Pow((E33 - E20), 0.71))), (1 / 1.14)) : 304800 * (Math.Pow((B573 / 1.74), 2)) * E33 / (32.2 * (E33 - E20))));
            }
        }
        public double B600
        {
            get
            {
                return J808;
            }
        }
        public double H59
        {
            get
            {
                return H7;
            }
        }
        public double N131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), N119, false);
            }
        }
        public double M143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), M119, false);
            }
        }
        public double O155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), O119, false);
            }
        }
        public double B545
        {
            get
            {
                return 0.9 * H7;
            }
        }
        public double B546
        {
            get
            {
                return (H7 < 6 ? 0.5 : 0.75);
            }
        }
        public double O131
        {
            get
            {
                return VLOOKUP(A131, GetLookupTable(4), O119, false);
            }
        }
        public double N143
        {
            get
            {
                return VLOOKUP(A143, GetLookupTable(5), N119, false);
            }
        }
        public double P155
        {
            get
            {
                return VLOOKUP(A155, GetLookupTable(6), P119, false);
            }
        }
        public double B484
        {
            get
            {
                return B819;
            }
        }
        public double B463
        {
            get
            {
                return B460 / B462;
            }
        }
        public double B475
        {
            get
            {
                return B474 * B463;
            }
        }
        public double B571
        {
            get
            {
                return B570 * B562;
            }
        }
        public double B499
        {
            get
            {
                return B560 / B488 * B570;
            }
        }
        public double B498
        {
            get
            {
                return 4 * B488 / B497;
            }
        }
        public double E40
        {
            get
            {
                return (1.11591 - 0.00305 * (B17)) * (38.085 - 0.259 * B21) / (1 + 0.02549 * (0.1782 * (Math.Pow(E29, 1.0157))));
            }
        }
        public double E37
        {
            get
            {
                return 10.715 * Math.Pow((E29 + 100), -0.515);
            }
        }
        public double E36
        {
            get
            {
                return 31310000000 / (Math.Pow(B16, 3.444)) * Math.Pow((Math.Log10(B21)), (10.313 * Math.Log10(B16) - 36.447));
            }
        }
        public double E38
        {
            get
            {
                return 5.44 * Math.Pow((E29 + 150), -0.338);
            }
        }
        public SettlingLaw B575
        {
            get
            {
                return (B574 < B897 ? SettlingLaw.Stokes : (B574 < B898 ? SettlingLaw.Intermediate : (B574 < B899 ? SettlingLaw.Newtons : SettlingLaw.OutOfRange)));
            }
        }
        public double B573
        {
            get
            {
                return (B3 == Position.Vertical ? B571 : B588 / (B572 * 60));
            }
        }
        public double O119
        {
            get
            {
                return N119 + 1;
            }
        }
        public double P119
        {
            get
            {
                return O119 + 1;
            }
        }
        public double B570
        {
            get
            {
                return (B567 == BooleanResponse.N ? B566 : (B566 - 1) * C115 + 1);
            }
        }
        public double B562
        {
            get
            {
                return (B3 == Position.Vertical ? B560 / (0.7854 * Math.Pow(H7, 2)) : B560 / B486);
            }
        }
        public double B560
        {
            get
            {
                return E32 - B8 * Z441 / 7.48 / 86400;
            }
        }
        public double B497
        {
            get
            {
                return H7 * Math.Acos(1 - 2 * B877 / H7);
            }
        }
        public double B17
        {
            get
            {
                return (B16 - 32) / 1.8;
            }
        }
        public double B574
        {
            get
            {
                return 304800 * Math.Pow((B573 * 18 * E39 / (1488 * 32.2 * (E33 - E20))), 0.5);
            }
        }
        public double B897
        {
            get
            {
                return 0.025 * 304800 * Math.Pow((Math.Pow(E39, 2) / (32.2 * E33 * (E33 - E20))), 0.333);
            }
        }
        public double B899
        {
            get
            {
                return 18.13 * 304800 * Math.Pow((Math.Pow(E39, 2) / (32.2 * E33 * (E33 - E20))), 0.333);
            }
        }
        public double B898
        {
            get
            {
                return 0.334 * 304800 * Math.Pow((Math.Pow(E39, 2) / (32.2 * E33 * (E33 - E20))), 0.333);
            }
        }
        public double B588
        {
            get
            {
                return Math.Min(B880, 3.2808 * 2.4 * (Math.Pow((0.3048 * B579), 0.66)) * (Math.Pow((0.3048 * B580), 0.66)));
            }
        }
        public double B572
        {
            get
            {
                return B563 / B570;
            }
        }
        public double B566
        {
            get
            {
                return Math.Max(1, (A108 == 1 ? (3.011 - 0.2136 * B565) / (1 + 0.1541 * B565 - 0.01749 * (Math.Pow(B565, 2))) : (A108 == 2 ? (2.002 - 0.02044 * B565) / (1 + 0.14936 * B565 - 0.007879 * (Math.Pow(B565, 2))) : (A108 == 3 ? (1.6002 + 0.05315 * B565) / (1 + 0.15228 * B565 - 0.0045517 * (Math.Pow(B565, 2))) : (A108 == 4 ? (1.3009 + 0.18943 * B565) / (1 + 0.22544 * B565 - 0.0009816 * (Math.Pow(B565, 2))) : (1.3009 + 0.18943 * B565) / (1 + 0.22544 * B565 - 0.0009816 * (Math.Pow(B565, 2))))))));
            }
        }
        public double C115 { get; set; }
        public double B486
        {
            get
            {
                return B483 * (1 / 3.1416 * Math.Acos(1 - 2 * B881) - 2 / 3.1416 * (1 - 2 * B881) * Math.Pow((B881 - Math.Pow(B881, 2)), 0.5));
            }
        }
        public double B880
        {
            get
            {
                return (B831 + B860) / 2;
            }
        }
        public double B579
        {
            get
            {
                return B192 / E108;
            }
        }
        public double B580
        {
            get
            {
                return Math.Pow((B578 / B579 / 0.7854), 0.5);
            }
        }
        public double B563
        {
            get
            {
                return (B3 == Position.Vertical ? 0.7854 * Math.Pow(H7, 2) * B880 / B560 / 60 : H8 / B562 / 60);
            }
        }
        public double B565
        {
            get
            {
                return B880 / H7;
            }
        }
        public double B881
        {
            get
            {
                return B880 / H7;
            }
        }
        public double B192
        {
            get
            {
                return E32 / (B191 * 0.7854 * Math.Pow((B184 / 12), 2));
            }
        }
        public double E108
        {
            get
            {
                return VLOOKUP(A108, GetLookupTable(3), E97);
            }
        }
        public double B578
        {
            get
            {
                return B560;
            }
        }
        public double B191
        {
            get
            {
                return 1 / (1 + 0.33 * Math.Pow((1.2 * B188), 0.92));
            }
        }

        public double Z441 { get; set; }
        #endregion

        #region J808

        private double? _b576 { get; set; }
        private double? _e33 { get; set; }
        private double? _e20 { get; set; }
        private double? _e39 { get; set; }
        private double? _b571 { get; set; }
        private double? _b588 { get; set; }
        private double? _b593 { get; set; }
        private double? _b596 { get; set; }

        public double A607 { get; set; }
        private double? _a608;
        public double A608
        {
            get
            {
                //Debug.WriteLine("A608");
                if (_a608 == null)
                    _a608 = (A807 - A607) / 200 + A607;
                return _a608.Value;
            }
        }
        private double? _a609;
        public double A609
        {
            get
            {
                //Debug.WriteLine("A609");
                if (_a609 == null)
                    _a609 = (A807 - A607) / 200 + A608;
                return _a609.Value;
            }
        }
        private double? _a610;
        public double A610
        {
            get
            {
                //Debug.WriteLine("A610");
                if (_a610 == null)
                    _a610 = (A807 - A607) / 200 + A609;
                return _a610.Value;
            }
        }
        private double? _a611;
        public double A611
        {
            get
            {
                //Debug.WriteLine("A611");
                if (_a611 == null)
                    _a611 = (A807 - A607) / 200 + A610;
                return _a611.Value;
            }
        }
        private double? _a612;
        public double A612
        {
            get
            {
                //Debug.WriteLine("A612");
                if (_a612 == null)
                    _a612 = (A807 - A607) / 200 + A611;
                return _a612.Value;
            }
        }
        private double? _a613;
        public double A613
        {
            get
            {
                //Debug.WriteLine("A613");
                if (_a613 == null)
                    _a613 = (A807 - A607) / 200 + A612;
                return _a613.Value;
            }
        }
        private double? _a614;
        public double A614
        {
            get
            {
                //Debug.WriteLine("A614");
                if (_a614 == null)
                    _a614 = (A807 - A607) / 200 + A613;
                return _a614.Value;
            }
        }
        private double? _a615;
        public double A615
        {
            get
            {
                //Debug.WriteLine("A615");
                if (_a615 == null)
                    _a615 = (A807 - A607) / 200 + A614;
                return _a615.Value;
            }
        }
        private double? _a616;
        public double A616
        {
            get
            {
                //Debug.WriteLine("A616");
                if (_a616 == null)
                    _a616 = (A807 - A607) / 200 + A615;
                return _a616.Value;
            }
        }
        private double? _a617;
        public double A617
        {
            get
            {
                //Debug.WriteLine("A617");
                if (_a617 == null)
                    _a617 = (A807 - A607) / 200 + A616;
                return _a617.Value;
            }
        }
        private double? _a618;
        public double A618
        {
            get
            {
                //Debug.WriteLine("A618");
                if (_a618 == null)
                    _a618 = (A807 - A607) / 200 + A617;
                return _a618.Value;
            }
        }
        private double? _a619;
        public double A619
        {
            get
            {
                //Debug.WriteLine("A619");
                if (_a619 == null)
                    _a619 = (A807 - A607) / 200 + A618;
                return _a619.Value;
            }
        }
        private double? _a620;
        public double A620
        {
            get
            {
                //Debug.WriteLine("A620");
                if (_a620 == null)
                    _a620 = (A807 - A607) / 200 + A619;
                return _a620.Value;
            }
        }
        private double? _a621;
        public double A621
        {
            get
            {
                //Debug.WriteLine("A621");
                if (_a621 == null)
                    _a621 = (A807 - A607) / 200 + A620;
                return _a621.Value;
            }
        }
        private double? _a622;
        public double A622
        {
            get
            {
                //Debug.WriteLine("A622");
                if (_a622 == null)
                    _a622 = (A807 - A607) / 200 + A621;
                return _a622.Value;
            }
        }
        private double? _a623;
        public double A623
        {
            get
            {
                //Debug.WriteLine("A623");
                if (_a623 == null)
                    _a623 = (A807 - A607) / 200 + A622;
                return _a623.Value;
            }
        }
        private double? _a624;
        public double A624
        {
            get
            {
                //Debug.WriteLine("A624");
                if (_a624 == null)
                    _a624 = (A807 - A607) / 200 + A623;
                return _a624.Value;
            }
        }
        private double? _a625;
        public double A625
        {
            get
            {
                //Debug.WriteLine("A625");
                if (_a625 == null)
                    _a625 = (A807 - A607) / 200 + A624;
                return _a625.Value;
            }
        }
        private double? _a626;
        public double A626
        {
            get
            {
                //Debug.WriteLine("A626");
                if (_a626 == null)
                    _a626 = (A807 - A607) / 200 + A625;
                return _a626.Value;
            }
        }
        private double? _a627;
        public double A627
        {
            get
            {
                //Debug.WriteLine("A627");
                if (_a627 == null)
                    _a627 = (A807 - A607) / 200 + A626;
                return _a627.Value;
            }
        }
        private double? _a628;
        public double A628
        {
            get
            {
                //Debug.WriteLine("A628");
                if (_a628 == null)
                    _a628 = (A807 - A607) / 200 + A627;
                return _a628.Value;
            }
        }
        private double? _a629;
        public double A629
        {
            get
            {
                //Debug.WriteLine("A629");
                if (_a629 == null)
                    _a629 = (A807 - A607) / 200 + A628;
                return _a629.Value;
            }
        }
        private double? _a630;
        public double A630
        {
            get
            {
                //Debug.WriteLine("A630");
                if (_a630 == null)
                    _a630 = (A807 - A607) / 200 + A629;
                return _a630.Value;
            }
        }
        private double? _a631;
        public double A631
        {
            get
            {
                //Debug.WriteLine("A631");
                if (_a631 == null)
                    _a631 = (A807 - A607) / 200 + A630;
                return _a631.Value;
            }
        }
        private double? _a632;
        public double A632
        {
            get
            {
                //Debug.WriteLine("A632");
                if (_a632 == null)
                    _a632 = (A807 - A607) / 200 + A631;
                return _a632.Value;
            }
        }
        private double? _a633;
        public double A633
        {
            get
            {
                //Debug.WriteLine("A633");
                if (_a633 == null)
                    _a633 = (A807 - A607) / 200 + A632;
                return _a633.Value;
            }
        }
        private double? _a634;
        public double A634
        {
            get
            {
                //Debug.WriteLine("A634");
                if (_a634 == null)
                    _a634 = (A807 - A607) / 200 + A633;
                return _a634.Value;
            }
        }
        private double? _a635;
        public double A635
        {
            get
            {
                //Debug.WriteLine("A635");
                if (_a635 == null)
                    _a635 = (A807 - A607) / 200 + A634;
                return _a635.Value;
            }
        }
        private double? _a636;
        public double A636
        {
            get
            {
                //Debug.WriteLine("A636");
                if (_a636 == null)
                    _a636 = (A807 - A607) / 200 + A635;
                return _a636.Value;
            }
        }
        private double? _a637;
        public double A637
        {
            get
            {
                //Debug.WriteLine("A637");
                if (_a637 == null)
                    _a637 = (A807 - A607) / 200 + A636;
                return _a637.Value;
            }
        }
        private double? _a638;
        public double A638
        {
            get
            {
                //Debug.WriteLine("A638");
                if (_a638 == null)
                    _a638 = (A807 - A607) / 200 + A637;
                return _a638.Value;
            }
        }
        private double? _a639;
        public double A639
        {
            get
            {
                //Debug.WriteLine("A639");
                if (_a639 == null)
                    _a639 = (A807 - A607) / 200 + A638;
                return _a639.Value;
            }
        }
        private double? _a640;
        public double A640
        {
            get
            {
                //Debug.WriteLine("A640");
                if (_a640 == null)
                    _a640 = (A807 - A607) / 200 + A639;
                return _a640.Value;
            }
        }
        private double? _a641;
        public double A641
        {
            get
            {
                //Debug.WriteLine("A641");
                if (_a641 == null)
                    _a641 = (A807 - A607) / 200 + A640;
                return _a641.Value;
            }
        }
        private double? _a642;
        public double A642
        {
            get
            {
                //Debug.WriteLine("A642");
                if (_a642 == null)
                    _a642 = (A807 - A607) / 200 + A641;
                return _a642.Value;
            }
        }
        private double? _a643;
        public double A643
        {
            get
            {
                //Debug.WriteLine("A643");
                if (_a643 == null)
                    _a643 = (A807 - A607) / 200 + A642;
                return _a643.Value;
            }
        }
        private double? _a644;
        public double A644
        {
            get
            {
                //Debug.WriteLine("A644");
                if (_a644 == null)
                    _a644 = (A807 - A607) / 200 + A643;
                return _a644.Value;
            }
        }
        private double? _a645;
        public double A645
        {
            get
            {
                //Debug.WriteLine("A645");
                if (_a645 == null)
                    _a645 = (A807 - A607) / 200 + A644;
                return _a645.Value;
            }
        }
        private double? _a646;
        public double A646
        {
            get
            {
                //Debug.WriteLine("A646");
                if (_a646 == null)
                    _a646 = (A807 - A607) / 200 + A645;
                return _a646.Value;
            }
        }
        private double? _a647;
        public double A647
        {
            get
            {
                //Debug.WriteLine("A647");
                if (_a647 == null)
                    _a647 = (A807 - A607) / 200 + A646;
                return _a647.Value;
            }
        }
        private double? _a648;
        public double A648
        {
            get
            {
                //Debug.WriteLine("A648");
                if (_a648 == null)
                    _a648 = (A807 - A607) / 200 + A647;
                return _a648.Value;
            }
        }
        private double? _a649;
        public double A649
        {
            get
            {
                //Debug.WriteLine("A649");
                if (_a649 == null)
                    _a649 = (A807 - A607) / 200 + A648;
                return _a649.Value;
            }
        }
        private double? _a650;
        public double A650
        {
            get
            {
                //Debug.WriteLine("A650");
                if (_a650 == null)
                    _a650 = (A807 - A607) / 200 + A649;
                return _a650.Value;
            }
        }
        private double? _a651;
        public double A651
        {
            get
            {
                //Debug.WriteLine("A651");
                if (_a651 == null)
                    _a651 = (A807 - A607) / 200 + A650;
                return _a651.Value;
            }
        }
        private double? _a652;
        public double A652
        {
            get
            {
                //Debug.WriteLine("A652");
                if (_a652 == null)
                    _a652 = (A807 - A607) / 200 + A651;
                return _a652.Value;
            }
        }
        private double? _a653;
        public double A653
        {
            get
            {
                //Debug.WriteLine("A653");
                if (_a653 == null)
                    _a653 = (A807 - A607) / 200 + A652;
                return _a653.Value;
            }
        }
        private double? _a654;
        public double A654
        {
            get
            {
                //Debug.WriteLine("A654");
                if (_a654 == null)
                    _a654 = (A807 - A607) / 200 + A653;
                return _a654.Value;
            }
        }
        private double? _a655;
        public double A655
        {
            get
            {
                //Debug.WriteLine("A655");
                if (_a655 == null)
                    _a655 = (A807 - A607) / 200 + A654;
                return _a655.Value;
            }
        }
        private double? _a656;
        public double A656
        {
            get
            {
                //Debug.WriteLine("A656");
                if (_a656 == null)
                    _a656 = (A807 - A607) / 200 + A655;
                return _a656.Value;
            }
        }
        private double? _a657;
        public double A657
        {
            get
            {
                //Debug.WriteLine("A657");
                if (_a657 == null)
                    _a657 = (A807 - A607) / 200 + A656;
                return _a657.Value;
            }
        }
        private double? _a658;
        public double A658
        {
            get
            {
                //Debug.WriteLine("A658");
                if (_a658 == null)
                    _a658 = (A807 - A607) / 200 + A657;
                return _a658.Value;
            }
        }
        private double? _a659;
        public double A659
        {
            get
            {
                //Debug.WriteLine("A659");
                if (_a659 == null)
                    _a659 = (A807 - A607) / 200 + A658;
                return _a659.Value;
            }
        }
        private double? _a660;
        public double A660
        {
            get
            {
                //Debug.WriteLine("A660");
                if (_a660 == null)
                    _a660 = (A807 - A607) / 200 + A659;
                return _a660.Value;
            }
        }
        private double? _a661;
        public double A661
        {
            get
            {
                //Debug.WriteLine("A661");
                if (_a661 == null)
                    _a661 = (A807 - A607) / 200 + A660;
                return _a661.Value;
            }
        }
        private double? _a662;
        public double A662
        {
            get
            {
                //Debug.WriteLine("A662");
                if (_a662 == null)
                    _a662 = (A807 - A607) / 200 + A661;
                return _a662.Value;
            }
        }
        private double? _a663;
        public double A663
        {
            get
            {
                //Debug.WriteLine("A663");
                if (_a663 == null)
                    _a663 = (A807 - A607) / 200 + A662;
                return _a663.Value;
            }
        }
        private double? _a664;
        public double A664
        {
            get
            {
                //Debug.WriteLine("A664");
                if (_a664 == null)
                    _a664 = (A807 - A607) / 200 + A663;
                return _a664.Value;
            }
        }
        private double? _a665;
        public double A665
        {
            get
            {
                //Debug.WriteLine("A665");
                if (_a665 == null)
                    _a665 = (A807 - A607) / 200 + A664;
                return _a665.Value;
            }
        }
        private double? _a666;
        public double A666
        {
            get
            {
                //Debug.WriteLine("A666");
                if (_a666 == null)
                    _a666 = (A807 - A607) / 200 + A665;
                return _a666.Value;
            }
        }
        private double? _a667;
        public double A667
        {
            get
            {
                //Debug.WriteLine("A667");
                if (_a667 == null)
                    _a667 = (A807 - A607) / 200 + A666;
                return _a667.Value;
            }
        }
        private double? _a668;
        public double A668
        {
            get
            {
                //Debug.WriteLine("A668");
                if (_a668 == null)
                    _a668 = (A807 - A607) / 200 + A667;
                return _a668.Value;
            }
        }
        private double? _a669;
        public double A669
        {
            get
            {
                //Debug.WriteLine("A669");
                if (_a669 == null)
                    _a669 = (A807 - A607) / 200 + A668;
                return _a669.Value;
            }
        }
        private double? _a670;
        public double A670
        {
            get
            {
                //Debug.WriteLine("A670");
                if (_a670 == null)
                    _a670 = (A807 - A607) / 200 + A669;
                return _a670.Value;
            }
        }
        private double? _a671;
        public double A671
        {
            get
            {
                //Debug.WriteLine("A671");
                if (_a671 == null)
                    _a671 = (A807 - A607) / 200 + A670;
                return _a671.Value;
            }
        }
        private double? _a672;
        public double A672
        {
            get
            {
                //Debug.WriteLine("A672");
                if (_a672 == null)
                    _a672 = (A807 - A607) / 200 + A671;
                return _a672.Value;
            }
        }
        private double? _a673;
        public double A673
        {
            get
            {
                //Debug.WriteLine("A673");
                if (_a673 == null)
                    _a673 = (A807 - A607) / 200 + A672;
                return _a673.Value;
            }
        }
        private double? _a674;
        public double A674
        {
            get
            {
                //Debug.WriteLine("A674");
                if (_a674 == null)
                    _a674 = (A807 - A607) / 200 + A673;
                return _a674.Value;
            }
        }
        private double? _a675;
        public double A675
        {
            get
            {
                //Debug.WriteLine("A675");
                if (_a675 == null)
                    _a675 = (A807 - A607) / 200 + A674;
                return _a675.Value;
            }
        }
        private double? _a676;
        public double A676
        {
            get
            {
                //Debug.WriteLine("A676");
                if (_a676 == null)
                    _a676 = (A807 - A607) / 200 + A675;
                return _a676.Value;
            }
        }
        private double? _a677;
        public double A677
        {
            get
            {
                //Debug.WriteLine("A677");
                if (_a677 == null)
                    _a677 = (A807 - A607) / 200 + A676;
                return _a677.Value;
            }
        }
        private double? _a678;
        public double A678
        {
            get
            {
                //Debug.WriteLine("A678");
                if (_a678 == null)
                    _a678 = (A807 - A607) / 200 + A677;
                return _a678.Value;
            }
        }
        private double? _a679;
        public double A679
        {
            get
            {
                //Debug.WriteLine("A679");
                if (_a679 == null)
                    _a679 = (A807 - A607) / 200 + A678;
                return _a679.Value;
            }
        }
        private double? _a680;
        public double A680
        {
            get
            {
                //Debug.WriteLine("A680");
                if (_a680 == null)
                    _a680 = (A807 - A607) / 200 + A679;
                return _a680.Value;
            }
        }
        private double? _a681;
        public double A681
        {
            get
            {
                //Debug.WriteLine("A681");
                if (_a681 == null)
                    _a681 = (A807 - A607) / 200 + A680;
                return _a681.Value;
            }
        }
        private double? _a682;
        public double A682
        {
            get
            {
                //Debug.WriteLine("A682");
                if (_a682 == null)
                    _a682 = (A807 - A607) / 200 + A681;
                return _a682.Value;
            }
        }
        private double? _a683;
        public double A683
        {
            get
            {
                //Debug.WriteLine("A683");
                if (_a683 == null)
                    _a683 = (A807 - A607) / 200 + A682;
                return _a683.Value;
            }
        }
        private double? _a684;
        public double A684
        {
            get
            {
                //Debug.WriteLine("A684");
                if (_a684 == null)
                    _a684 = (A807 - A607) / 200 + A683;
                return _a684.Value;
            }
        }
        private double? _a685;
        public double A685
        {
            get
            {
                //Debug.WriteLine("A685");
                if (_a685 == null)
                    _a685 = (A807 - A607) / 200 + A684;
                return _a685.Value;
            }
        }
        private double? _a686;
        public double A686
        {
            get
            {
                //Debug.WriteLine("A686");
                if (_a686 == null)
                    _a686 = (A807 - A607) / 200 + A685;
                return _a686.Value;
            }
        }
        private double? _a687;
        public double A687
        {
            get
            {
                //Debug.WriteLine("A687");
                if (_a687 == null)
                    _a687 = (A807 - A607) / 200 + A686;
                return _a687.Value;
            }
        }
        private double? _a688;
        public double A688
        {
            get
            {
                //Debug.WriteLine("A688");
                if (_a688 == null)
                    _a688 = (A807 - A607) / 200 + A687;
                return _a688.Value;
            }
        }
        private double? _a689;
        public double A689
        {
            get
            {
                //Debug.WriteLine("A689");
                if (_a689 == null)
                    _a689 = (A807 - A607) / 200 + A688;
                return _a689.Value;
            }
        }
        private double? _a690;
        public double A690
        {
            get
            {
                //Debug.WriteLine("A690");
                if (_a690 == null)
                    _a690 = (A807 - A607) / 200 + A689;
                return _a690.Value;
            }
        }
        private double? _a691;
        public double A691
        {
            get
            {
                //Debug.WriteLine("A691");
                if (_a691 == null)
                    _a691 = (A807 - A607) / 200 + A690;
                return _a691.Value;
            }
        }
        private double? _a692;
        public double A692
        {
            get
            {
                //Debug.WriteLine("A692");
                if (_a692 == null)
                    _a692 = (A807 - A607) / 200 + A691;
                return _a692.Value;
            }
        }
        private double? _a693;
        public double A693
        {
            get
            {
                //Debug.WriteLine("A693");
                if (_a693 == null)
                    _a693 = (A807 - A607) / 200 + A692;
                return _a693.Value;
            }
        }
        private double? _a694;
        public double A694
        {
            get
            {
                //Debug.WriteLine("A694");
                if (_a694 == null)
                    _a694 = (A807 - A607) / 200 + A693;
                return _a694.Value;
            }
        }
        private double? _a695;
        public double A695
        {
            get
            {
                //Debug.WriteLine("A695");
                if (_a695 == null)
                    _a695 = (A807 - A607) / 200 + A694;
                return _a695.Value;
            }
        }
        private double? _a696;
        public double A696
        {
            get
            {
                //Debug.WriteLine("A696");
                if (_a696 == null)
                    _a696 = (A807 - A607) / 200 + A695;
                return _a696.Value;
            }
        }
        private double? _a697;
        public double A697
        {
            get
            {
                //Debug.WriteLine("A697");
                if (_a697 == null)
                    _a697 = (A807 - A607) / 200 + A696;
                return _a697.Value;
            }
        }
        private double? _a698;
        public double A698
        {
            get
            {
                //Debug.WriteLine("A698");
                if (_a698 == null)
                    _a698 = (A807 - A607) / 200 + A697;
                return _a698.Value;
            }
        }
        private double? _a699;
        public double A699
        {
            get
            {
                //Debug.WriteLine("A699");
                if (_a699 == null)
                    _a699 = (A807 - A607) / 200 + A698;
                return _a699.Value;
            }
        }
        private double? _a700;
        public double A700
        {
            get
            {
                //Debug.WriteLine("A700");
                if (_a700 == null)
                    _a700 = (A807 - A607) / 200 + A699;
                return _a700.Value;
            }
        }
        private double? _a701;
        public double A701
        {
            get
            {
                //Debug.WriteLine("A701");
                if (_a701 == null)
                    _a701 = (A807 - A607) / 200 + A700;
                return _a701.Value;
            }
        }
        private double? _a702;
        public double A702
        {
            get
            {
                //Debug.WriteLine("A702");
                if (_a702 == null)
                    _a702 = (A807 - A607) / 200 + A701;
                return _a702.Value;
            }
        }
        private double? _a703;
        public double A703
        {
            get
            {
                //Debug.WriteLine("A703");
                if (_a703 == null)
                    _a703 = (A807 - A607) / 200 + A702;
                return _a703.Value;
            }
        }
        private double? _a704;
        public double A704
        {
            get
            {
                //Debug.WriteLine("A704");
                if (_a704 == null)
                    _a704 = (A807 - A607) / 200 + A703;
                return _a704.Value;
            }
        }
        private double? _a705;
        public double A705
        {
            get
            {
                //Debug.WriteLine("A705");
                if (_a705 == null)
                    _a705 = (A807 - A607) / 200 + A704;
                return _a705.Value;
            }
        }
        private double? _a706;
        public double A706
        {
            get
            {
                //Debug.WriteLine("A706");
                if (_a706 == null)
                    _a706 = (A807 - A607) / 200 + A705;
                return _a706.Value;
            }
        }
        private double? _a707;
        public double A707
        {
            get
            {
                //Debug.WriteLine("A707");
                if (_a707 == null)
                    _a707 = (A807 - A607) / 200 + A706;
                return _a707.Value;
            }
        }
        private double? _a708;
        public double A708
        {
            get
            {
                //Debug.WriteLine("A708");
                if (_a708 == null)
                    _a708 = (A807 - A607) / 200 + A707;
                return _a708.Value;
            }
        }
        private double? _a709;
        public double A709
        {
            get
            {
                //Debug.WriteLine("A709");
                if (_a709 == null)
                    _a709 = (A807 - A607) / 200 + A708;
                return _a709.Value;
            }
        }
        private double? _a710;
        public double A710
        {
            get
            {
                //Debug.WriteLine("A710");
                if (_a710 == null)
                    _a710 = (A807 - A607) / 200 + A709;
                return _a710.Value;
            }
        }
        private double? _a711;
        public double A711
        {
            get
            {
                //Debug.WriteLine("A711");
                if (_a711 == null)
                    _a711 = (A807 - A607) / 200 + A710;
                return _a711.Value;
            }
        }
        private double? _a712;
        public double A712
        {
            get
            {
                //Debug.WriteLine("A712");
                if (_a712 == null)
                    _a712 = (A807 - A607) / 200 + A711;
                return _a712.Value;
            }
        }
        private double? _a713;
        public double A713
        {
            get
            {
                //Debug.WriteLine("A713");
                if (_a713 == null)
                    _a713 = (A807 - A607) / 200 + A712;
                return _a713.Value;
            }
        }
        private double? _a714;
        public double A714
        {
            get
            {
                //Debug.WriteLine("A714");
                if (_a714 == null)
                    _a714 = (A807 - A607) / 200 + A713;
                return _a714.Value;
            }
        }
        private double? _a715;
        public double A715
        {
            get
            {
                //Debug.WriteLine("A715");
                if (_a715 == null)
                    _a715 = (A807 - A607) / 200 + A714;
                return _a715.Value;
            }
        }
        private double? _a716;
        public double A716
        {
            get
            {
                //Debug.WriteLine("A716");
                if (_a716 == null)
                    _a716 = (A807 - A607) / 200 + A715;
                return _a716.Value;
            }
        }
        private double? _a717;
        public double A717
        {
            get
            {
                //Debug.WriteLine("A717");
                if (_a717 == null)
                    _a717 = (A807 - A607) / 200 + A716;
                return _a717.Value;
            }
        }
        private double? _a718;
        public double A718
        {
            get
            {
                //Debug.WriteLine("A718");
                if (_a718 == null)
                    _a718 = (A807 - A607) / 200 + A717;
                return _a718.Value;
            }
        }
        private double? _a719;
        public double A719
        {
            get
            {
                //Debug.WriteLine("A719");
                if (_a719 == null)
                    _a719 = (A807 - A607) / 200 + A718;
                return _a719.Value;
            }
        }
        private double? _a720;
        public double A720
        {
            get
            {
                //Debug.WriteLine("A720");
                if (_a720 == null)
                    _a720 = (A807 - A607) / 200 + A719;
                return _a720.Value;
            }
        }
        private double? _a721;
        public double A721
        {
            get
            {
                //Debug.WriteLine("A721");
                if (_a721 == null)
                    _a721 = (A807 - A607) / 200 + A720;
                return _a721.Value;
            }
        }
        private double? _a722;
        public double A722
        {
            get
            {
                //Debug.WriteLine("A722");
                if (_a722 == null)
                    _a722 = (A807 - A607) / 200 + A721;
                return _a722.Value;
            }
        }
        private double? _a723;
        public double A723
        {
            get
            {
                //Debug.WriteLine("A723");
                if (_a723 == null)
                    _a723 = (A807 - A607) / 200 + A722;
                return _a723.Value;
            }
        }
        private double? _a724;
        public double A724
        {
            get
            {
                //Debug.WriteLine("A724");
                if (_a724 == null)
                    _a724 = (A807 - A607) / 200 + A723;
                return _a724.Value;
            }
        }
        private double? _a725;
        public double A725
        {
            get
            {
                //Debug.WriteLine("A725");
                if (_a725 == null)
                    _a725 = (A807 - A607) / 200 + A724;
                return _a725.Value;
            }
        }
        private double? _a726;
        public double A726
        {
            get
            {
                //Debug.WriteLine("A726");
                if (_a726 == null)
                    _a726 = (A807 - A607) / 200 + A725;
                return _a726.Value;
            }
        }
        private double? _a727;
        public double A727
        {
            get
            {
                //Debug.WriteLine("A727");
                if (_a727 == null)
                    _a727 = (A807 - A607) / 200 + A726;
                return _a727.Value;
            }
        }
        private double? _a728;
        public double A728
        {
            get
            {
                //Debug.WriteLine("A728");
                if (_a728 == null)
                    _a728 = (A807 - A607) / 200 + A727;
                return _a728.Value;
            }
        }
        private double? _a729;
        public double A729
        {
            get
            {
                //Debug.WriteLine("A729");
                if (_a729 == null)
                    _a729 = (A807 - A607) / 200 + A728;
                return _a729.Value;
            }
        }
        private double? _a730;
        public double A730
        {
            get
            {
                //Debug.WriteLine("A730");
                if (_a730 == null)
                    _a730 = (A807 - A607) / 200 + A729;
                return _a730.Value;
            }
        }
        private double? _a731;
        public double A731
        {
            get
            {
                //Debug.WriteLine("A731");
                if (_a731 == null)
                    _a731 = (A807 - A607) / 200 + A730;
                return _a731.Value;
            }
        }
        private double? _a732;
        public double A732
        {
            get
            {
                //Debug.WriteLine("A732");
                if (_a732 == null)
                    _a732 = (A807 - A607) / 200 + A731;
                return _a732.Value;
            }
        }
        private double? _a733;
        public double A733
        {
            get
            {
                //Debug.WriteLine("A733");
                if (_a733 == null)
                    _a733 = (A807 - A607) / 200 + A732;
                return _a733.Value;
            }
        }
        private double? _a734;
        public double A734
        {
            get
            {
                //Debug.WriteLine("A734");
                if (_a734 == null)
                    _a734 = (A807 - A607) / 200 + A733;
                return _a734.Value;
            }
        }
        private double? _a735;
        public double A735
        {
            get
            {
                //Debug.WriteLine("A735");
                if (_a735 == null)
                    _a735 = (A807 - A607) / 200 + A734;
                return _a735.Value;
            }
        }
        private double? _a736;
        public double A736
        {
            get
            {
                //Debug.WriteLine("A736");
                if (_a736 == null)
                    _a736 = (A807 - A607) / 200 + A735;
                return _a736.Value;
            }
        }
        private double? _a737;
        public double A737
        {
            get
            {
                //Debug.WriteLine("A737");
                if (_a737 == null)
                    _a737 = (A807 - A607) / 200 + A736;
                return _a737.Value;
            }
        }
        private double? _a738;
        public double A738
        {
            get
            {
                //Debug.WriteLine("A738");
                if (_a738 == null)
                    _a738 = (A807 - A607) / 200 + A737;
                return _a738.Value;
            }
        }
        private double? _a739;
        public double A739
        {
            get
            {
                //Debug.WriteLine("A739");
                if (_a739 == null)
                    _a739 = (A807 - A607) / 200 + A738;
                return _a739.Value;
            }
        }
        private double? _a740;
        public double A740
        {
            get
            {
                //Debug.WriteLine("A740");
                if (_a740 == null)
                    _a740 = (A807 - A607) / 200 + A739;
                return _a740.Value;
            }
        }
        private double? _a741;
        public double A741
        {
            get
            {
                //Debug.WriteLine("A741");
                if (_a741 == null)
                    _a741 = (A807 - A607) / 200 + A740;
                return _a741.Value;
            }
        }
        private double? _a742;
        public double A742
        {
            get
            {
                //Debug.WriteLine("A742");
                if (_a742 == null)
                    _a742 = (A807 - A607) / 200 + A741;
                return _a742.Value;
            }
        }
        private double? _a743;
        public double A743
        {
            get
            {
                //Debug.WriteLine("A743");
                if (_a743 == null)
                    _a743 = (A807 - A607) / 200 + A742;
                return _a743.Value;
            }
        }
        private double? _a744;
        public double A744
        {
            get
            {
                //Debug.WriteLine("A744");
                if (_a744 == null)
                    _a744 = (A807 - A607) / 200 + A743;
                return _a744.Value;
            }
        }
        private double? _a745;
        public double A745
        {
            get
            {
                //Debug.WriteLine("A745");
                if (_a745 == null)
                    _a745 = (A807 - A607) / 200 + A744;
                return _a745.Value;
            }
        }
        private double? _a746;
        public double A746
        {
            get
            {
                //Debug.WriteLine("A746");
                if (_a746 == null)
                    _a746 = (A807 - A607) / 200 + A745;
                return _a746.Value;
            }
        }
        private double? _a747;
        public double A747
        {
            get
            {
                //Debug.WriteLine("A747");
                if (_a747 == null)
                    _a747 = (A807 - A607) / 200 + A746;
                return _a747.Value;
            }
        }
        private double? _a748;
        public double A748
        {
            get
            {
                //Debug.WriteLine("A748");
                if (_a748 == null)
                    _a748 = (A807 - A607) / 200 + A747;
                return _a748.Value;
            }
        }
        private double? _a749;
        public double A749
        {
            get
            {
                //Debug.WriteLine("A749");
                if (_a749 == null)
                    _a749 = (A807 - A607) / 200 + A748;
                return _a749.Value;
            }
        }
        private double? _a750;
        public double A750
        {
            get
            {
                //Debug.WriteLine("A750");
                if (_a750 == null)
                    _a750 = (A807 - A607) / 200 + A749;
                return _a750.Value;
            }
        }
        private double? _a751;
        public double A751
        {
            get
            {
                //Debug.WriteLine("A751");
                if (_a751 == null)
                    _a751 = (A807 - A607) / 200 + A750;
                return _a751.Value;
            }
        }
        private double? _a752;
        public double A752
        {
            get
            {
                //Debug.WriteLine("A752");
                if (_a752 == null)
                    _a752 = (A807 - A607) / 200 + A751;
                return _a752.Value;
            }
        }
        private double? _a753;
        public double A753
        {
            get
            {
                //Debug.WriteLine("A753");
                if (_a753 == null)
                    _a753 = (A807 - A607) / 200 + A752;
                return _a753.Value;
            }
        }
        private double? _a754;
        public double A754
        {
            get
            {
                //Debug.WriteLine("A754");
                if (_a754 == null)
                    _a754 = (A807 - A607) / 200 + A753;
                return _a754.Value;
            }
        }
        private double? _a755;
        public double A755
        {
            get
            {
                //Debug.WriteLine("A755");
                if (_a755 == null)
                    _a755 = (A807 - A607) / 200 + A754;
                return _a755.Value;
            }
        }
        private double? _a756;
        public double A756
        {
            get
            {
                //Debug.WriteLine("A756");
                if (_a756 == null)
                    _a756 = (A807 - A607) / 200 + A755;
                return _a756.Value;
            }
        }
        private double? _a757;
        public double A757
        {
            get
            {
                //Debug.WriteLine("A757");
                if (_a757 == null)
                    _a757 = (A807 - A607) / 200 + A756;
                return _a757.Value;
            }
        }
        private double? _a758;
        public double A758
        {
            get
            {
                //Debug.WriteLine("A758");
                if (_a758 == null)
                    _a758 = (A807 - A607) / 200 + A757;
                return _a758.Value;
            }
        }
        private double? _a759;
        public double A759
        {
            get
            {
                //Debug.WriteLine("A759");
                if (_a759 == null)
                    _a759 = (A807 - A607) / 200 + A758;
                return _a759.Value;
            }
        }
        private double? _a760;
        public double A760
        {
            get
            {
                //Debug.WriteLine("A760");
                if (_a760 == null)
                    _a760 = (A807 - A607) / 200 + A759;
                return _a760.Value;
            }
        }
        private double? _a761;
        public double A761
        {
            get
            {
                //Debug.WriteLine("A761");
                if (_a761 == null)
                    _a761 = (A807 - A607) / 200 + A760;
                return _a761.Value;
            }
        }
        private double? _a762;
        public double A762
        {
            get
            {
                //Debug.WriteLine("A762");
                if (_a762 == null)
                    _a762 = (A807 - A607) / 200 + A761;
                return _a762.Value;
            }
        }
        private double? _a763;
        public double A763
        {
            get
            {
                //Debug.WriteLine("A763");
                if (_a763 == null)
                    _a763 = (A807 - A607) / 200 + A762;
                return _a763.Value;
            }
        }
        private double? _a764;
        public double A764
        {
            get
            {
                //Debug.WriteLine("A764");
                if (_a764 == null)
                    _a764 = (A807 - A607) / 200 + A763;
                return _a764.Value;
            }
        }
        private double? _a765;
        public double A765
        {
            get
            {
                //Debug.WriteLine("A765");
                if (_a765 == null)
                    _a765 = (A807 - A607) / 200 + A764;
                return _a765.Value;
            }
        }
        private double? _a766;
        public double A766
        {
            get
            {
                //Debug.WriteLine("A766");
                if (_a766 == null)
                    _a766 = (A807 - A607) / 200 + A765;
                return _a766.Value;
            }
        }
        private double? _a767;
        public double A767
        {
            get
            {
                //Debug.WriteLine("A767");
                if (_a767 == null)
                    _a767 = (A807 - A607) / 200 + A766;
                return _a767.Value;
            }
        }
        private double? _a768;
        public double A768
        {
            get
            {
                //Debug.WriteLine("A768");
                if (_a768 == null)
                    _a768 = (A807 - A607) / 200 + A767;
                return _a768.Value;
            }
        }
        private double? _a769;
        public double A769
        {
            get
            {
                //Debug.WriteLine("A769");
                if (_a769 == null)
                    _a769 = (A807 - A607) / 200 + A768;
                return _a769.Value;
            }
        }
        private double? _a770;
        public double A770
        {
            get
            {
                //Debug.WriteLine("A770");
                if (_a770 == null)
                    _a770 = (A807 - A607) / 200 + A769;
                return _a770.Value;
            }
        }
        private double? _a771;
        public double A771
        {
            get
            {
                //Debug.WriteLine("A771");
                if (_a771 == null)
                    _a771 = (A807 - A607) / 200 + A770;
                return _a771.Value;
            }
        }
        private double? _a772;
        public double A772
        {
            get
            {
                //Debug.WriteLine("A772");
                if (_a772 == null)
                    _a772 = (A807 - A607) / 200 + A771;
                return _a772.Value;
            }
        }
        private double? _a773;
        public double A773
        {
            get
            {
                //Debug.WriteLine("A773");
                if (_a773 == null)
                    _a773 = (A807 - A607) / 200 + A772;
                return _a773.Value;
            }
        }
        private double? _a774;
        public double A774
        {
            get
            {
                //Debug.WriteLine("A774");
                if (_a774 == null)
                    _a774 = (A807 - A607) / 200 + A773;
                return _a774.Value;
            }
        }
        private double? _a775;
        public double A775
        {
            get
            {
                //Debug.WriteLine("A775");
                if (_a775 == null)
                    _a775 = (A807 - A607) / 200 + A774;
                return _a775.Value;
            }
        }
        private double? _a776;
        public double A776
        {
            get
            {
                //Debug.WriteLine("A776");
                if (_a776 == null)
                    _a776 = (A807 - A607) / 200 + A775;
                return _a776.Value;
            }
        }
        private double? _a777;
        public double A777
        {
            get
            {
                //Debug.WriteLine("A777");
                if (_a777 == null)
                    _a777 = (A807 - A607) / 200 + A776;
                return _a777.Value;
            }
        }
        private double? _a778;
        public double A778
        {
            get
            {
                //Debug.WriteLine("A778");
                if (_a778 == null)
                    _a778 = (A807 - A607) / 200 + A777;
                return _a778.Value;
            }
        }
        private double? _a779;
        public double A779
        {
            get
            {
                //Debug.WriteLine("A779");
                if (_a779 == null)
                    _a779 = (A807 - A607) / 200 + A778;
                return _a779.Value;
            }
        }
        private double? _a780;
        public double A780
        {
            get
            {
                //Debug.WriteLine("A780");
                if (_a780 == null)
                    _a780 = (A807 - A607) / 200 + A779;
                return _a780.Value;
            }
        }
        private double? _a781;
        public double A781
        {
            get
            {
                //Debug.WriteLine("A781");
                if (_a781 == null)
                    _a781 = (A807 - A607) / 200 + A780;
                return _a781.Value;
            }
        }
        private double? _a782;
        public double A782
        {
            get
            {
                //Debug.WriteLine("A782");
                if (_a782 == null)
                    _a782 = (A807 - A607) / 200 + A781;
                return _a782.Value;
            }
        }
        private double? _a783;
        public double A783
        {
            get
            {
                //Debug.WriteLine("A783");
                if (_a783 == null)
                    _a783 = (A807 - A607) / 200 + A782;
                return _a783.Value;
            }
        }
        private double? _a784;
        public double A784
        {
            get
            {
                //Debug.WriteLine("A784");
                if (_a784 == null)
                    _a784 = (A807 - A607) / 200 + A783;
                return _a784.Value;
            }
        }
        private double? _a785;
        public double A785
        {
            get
            {
                //Debug.WriteLine("A785");
                if (_a785 == null)
                    _a785 = (A807 - A607) / 200 + A784;
                return _a785.Value;
            }
        }
        private double? _a786;
        public double A786
        {
            get
            {
                //Debug.WriteLine("A786");
                if (_a786 == null)
                    _a786 = (A807 - A607) / 200 + A785;
                return _a786.Value;
            }
        }
        private double? _a787;
        public double A787
        {
            get
            {
                //Debug.WriteLine("A787");
                if (_a787 == null)
                    _a787 = (A807 - A607) / 200 + A786;
                return _a787.Value;
            }
        }
        private double? _a788;
        public double A788
        {
            get
            {
                //Debug.WriteLine("A788");
                if (_a788 == null)
                    _a788 = (A807 - A607) / 200 + A787;
                return _a788.Value;
            }
        }
        private double? _a789;
        public double A789
        {
            get
            {
                //Debug.WriteLine("A789");
                if (_a789 == null)
                    _a789 = (A807 - A607) / 200 + A788;
                return _a789.Value;
            }
        }
        private double? _a790;
        public double A790
        {
            get
            {
                //Debug.WriteLine("A790");
                if (_a790 == null)
                    _a790 = (A807 - A607) / 200 + A789;
                return _a790.Value;
            }
        }
        private double? _a791;
        public double A791
        {
            get
            {
                //Debug.WriteLine("A791");
                if (_a791 == null)
                    _a791 = (A807 - A607) / 200 + A790;
                return _a791.Value;
            }
        }
        private double? _a792;
        public double A792
        {
            get
            {
                //Debug.WriteLine("A792");
                if (_a792 == null)
                    _a792 = (A807 - A607) / 200 + A791;
                return _a792.Value;
            }
        }
        private double? _a793;
        public double A793
        {
            get
            {
                //Debug.WriteLine("A793");
                if (_a793 == null)
                    _a793 = (A807 - A607) / 200 + A792;
                return _a793.Value;
            }
        }
        private double? _a794;
        public double A794
        {
            get
            {
                //Debug.WriteLine("A794");
                if (_a794 == null)
                    _a794 = (A807 - A607) / 200 + A793;
                return _a794.Value;
            }
        }
        private double? _a795;
        public double A795
        {
            get
            {
                //Debug.WriteLine("A795");
                if (_a795 == null)
                    _a795 = (A807 - A607) / 200 + A794;
                return _a795.Value;
            }
        }
        private double? _a796;
        public double A796
        {
            get
            {
                //Debug.WriteLine("A796");
                if (_a796 == null)
                    _a796 = (A807 - A607) / 200 + A795;
                return _a796.Value;
            }
        }
        private double? _a797;
        public double A797
        {
            get
            {
                //Debug.WriteLine("A797");
                if (_a797 == null)
                    _a797 = (A807 - A607) / 200 + A796;
                return _a797.Value;
            }
        }
        private double? _a798;
        public double A798
        {
            get
            {
                //Debug.WriteLine("A798");
                if (_a798 == null)
                    _a798 = (A807 - A607) / 200 + A797;
                return _a798.Value;
            }
        }
        private double? _a799;
        public double A799
        {
            get
            {
                //Debug.WriteLine("A799");
                if (_a799 == null)
                    _a799 = (A807 - A607) / 200 + A798;
                return _a799.Value;
            }
        }
        private double? _a800;
        public double A800
        {
            get
            {
                //Debug.WriteLine("A800");
                if (_a800 == null)
                    _a800 = (A807 - A607) / 200 + A799;
                return _a800.Value;
            }
        }
        private double? _a801;
        public double A801
        {
            get
            {
                //Debug.WriteLine("A801");
                if (_a801 == null)
                    _a801 = (A807 - A607) / 200 + A800;
                return _a801.Value;
            }
        }
        private double? _a802;
        public double A802
        {
            get
            {
                //Debug.WriteLine("A802");
                if (_a802 == null)
                    _a802 = (A807 - A607) / 200 + A801;
                return _a802.Value;
            }
        }
        private double? _a803;
        public double A803
        {
            get
            {
                //Debug.WriteLine("A803");
                if (_a803 == null)
                    _a803 = (A807 - A607) / 200 + A802;
                return _a803.Value;
            }
        }
        private double? _a804;
        public double A804
        {
            get
            {
                //Debug.WriteLine("A804");
                if (_a804 == null)
                    _a804 = (A807 - A607) / 200 + A803;
                return _a804.Value;
            }
        }
        private double? _a805;
        public double A805
        {
            get
            {
                //Debug.WriteLine("A805");
                if (_a805 == null)
                    _a805 = (A807 - A607) / 200 + A804;
                return _a805.Value;
            }
        }
        private double? _a806;
        public double A806
        {
            get
            {
                //Debug.WriteLine("A806");
                if (_a806 == null)
                    _a806 = (A807 - A607) / 200 + A805;
                return _a806.Value;
            }
        }
        public double A807
        {
            get
            {
                //Debug.WriteLine("A807");
                return _b593.Value - 1;
            }
        }

        private double? _c607;
        public double C607
        {
            get
            {
                //Debug.WriteLine("C607");
                if (_c607 == null)
                    _c607 = Math.Log(_b596.Value * A607 / (_b593.Value - A607)); //Natural Log base(e)
                return _c607.Value;
            }
        }
        private double? _c608;
        public double C608
        {
            get
            {
                //Debug.WriteLine("C608");
                if (_c608 == null)
                    _c608 = Math.Log(_b596.Value * A608 / (_b593.Value - A608)); //Natural Log base(e)
                return _c608.Value;
            }
        }
        private double? _c609;
        public double C609
        {
            get
            {
                //Debug.WriteLine("C609");
                if (_c609 == null)
                    _c609 = Math.Log(_b596.Value * A609 / (_b593.Value - A609)); //Natural Log base(e)
                return _c609.Value;
            }
        }
        private double? _c610;
        public double C610
        {
            get
            {
                //Debug.WriteLine("C610");
                if (_c610 == null)
                    _c610 = Math.Log(_b596.Value * A610 / (_b593.Value - A610)); //Natural Log base(e)
                return _c610.Value;
            }
        }
        private double? _c611;
        public double C611
        {
            get
            {
                //Debug.WriteLine("C611");
                if (_c611 == null)
                    _c611 = Math.Log(_b596.Value * A611 / (_b593.Value - A611)); //Natural Log base(e)
                return _c611.Value;
            }
        }
        private double? _c612;
        public double C612
        {
            get
            {
                //Debug.WriteLine("C612");
                if (_c612 == null)
                    _c612 = Math.Log(_b596.Value * A612 / (_b593.Value - A612)); //Natural Log base(e)
                return _c612.Value;
            }
        }
        private double? _c613;
        public double C613
        {
            get
            {
                //Debug.WriteLine("C613");
                if (_c613 == null)
                    _c613 = Math.Log(_b596.Value * A613 / (_b593.Value - A613)); //Natural Log base(e)
                return _c613.Value;
            }
        }
        private double? _c614;
        public double C614
        {
            get
            {
                //Debug.WriteLine("C614");
                if (_c614 == null)
                    _c614 = Math.Log(_b596.Value * A614 / (_b593.Value - A614)); //Natural Log base(e)
                return _c614.Value;
            }
        }
        private double? _c615;
        public double C615
        {
            get
            {
                //Debug.WriteLine("C615");
                if (_c615 == null)
                    _c615 = Math.Log(_b596.Value * A615 / (_b593.Value - A615)); //Natural Log base(e)
                return _c615.Value;
            }
        }
        private double? _c616;
        public double C616
        {
            get
            {
                //Debug.WriteLine("C616");
                if (_c616 == null)
                    _c616 = Math.Log(_b596.Value * A616 / (_b593.Value - A616)); //Natural Log base(e)
                return _c616.Value;
            }
        }
        private double? _c617;
        public double C617
        {
            get
            {
                //Debug.WriteLine("C617");
                if (_c617 == null)
                    _c617 = Math.Log(_b596.Value * A617 / (_b593.Value - A617)); //Natural Log base(e)
                return _c617.Value;
            }
        }
        private double? _c618;
        public double C618
        {
            get
            {
                //Debug.WriteLine("C618");
                if (_c618 == null)
                    _c618 = Math.Log(_b596.Value * A618 / (_b593.Value - A618)); //Natural Log base(e)
                return _c618.Value;
            }
        }
        private double? _c619;
        public double C619
        {
            get
            {
                //Debug.WriteLine("C619");
                if (_c619 == null)
                    _c619 = Math.Log(_b596.Value * A619 / (_b593.Value - A619)); //Natural Log base(e)
                return _c619.Value;
            }
        }
        private double? _c620;
        public double C620
        {
            get
            {
                //Debug.WriteLine("C620");
                if (_c620 == null)
                    _c620 = Math.Log(_b596.Value * A620 / (_b593.Value - A620)); //Natural Log base(e)
                return _c620.Value;
            }
        }
        private double? _c621;
        public double C621
        {
            get
            {
                //Debug.WriteLine("C621");
                if (_c621 == null)
                    _c621 = Math.Log(_b596.Value * A621 / (_b593.Value - A621)); //Natural Log base(e)
                return _c621.Value;
            }
        }
        private double? _c622;
        public double C622
        {
            get
            {
                //Debug.WriteLine("C622");
                if (_c622 == null)
                    _c622 = Math.Log(_b596.Value * A622 / (_b593.Value - A622)); //Natural Log base(e)
                return _c622.Value;
            }
        }
        private double? _c623;
        public double C623
        {
            get
            {
                //Debug.WriteLine("C623");
                if (_c623 == null)
                    _c623 = Math.Log(_b596.Value * A623 / (_b593.Value - A623)); //Natural Log base(e)
                return _c623.Value;
            }
        }
        private double? _c624;
        public double C624
        {
            get
            {
                //Debug.WriteLine("C624");
                if (_c624 == null)
                    _c624 = Math.Log(_b596.Value * A624 / (_b593.Value - A624)); //Natural Log base(e)
                return _c624.Value;
            }
        }
        private double? _c625;
        public double C625
        {
            get
            {
                //Debug.WriteLine("C625");
                if (_c625 == null)
                    _c625 = Math.Log(_b596.Value * A625 / (_b593.Value - A625)); //Natural Log base(e)
                return _c625.Value;
            }
        }
        private double? _c626;
        public double C626
        {
            get
            {
                //Debug.WriteLine("C626");
                if (_c626 == null)
                    _c626 = Math.Log(_b596.Value * A626 / (_b593.Value - A626)); //Natural Log base(e)
                return _c626.Value;
            }
        }
        private double? _c627;
        public double C627
        {
            get
            {
                //Debug.WriteLine("C627");
                if (_c627 == null)
                    _c627 = Math.Log(_b596.Value * A627 / (_b593.Value - A627)); //Natural Log base(e)
                return _c627.Value;
            }
        }
        private double? _c628;
        public double C628
        {
            get
            {
                //Debug.WriteLine("C628");
                if (_c628 == null)
                    _c628 = Math.Log(_b596.Value * A628 / (_b593.Value - A628)); //Natural Log base(e)
                return _c628.Value;
            }
        }
        private double? _c629;
        public double C629
        {
            get
            {
                //Debug.WriteLine("C629");
                if (_c629 == null)
                    _c629 = Math.Log(_b596.Value * A629 / (_b593.Value - A629)); //Natural Log base(e)
                return _c629.Value;
            }
        }
        private double? _c630;
        public double C630
        {
            get
            {
                //Debug.WriteLine("C630");
                if (_c630 == null)
                    _c630 = Math.Log(_b596.Value * A630 / (_b593.Value - A630)); //Natural Log base(e)
                return _c630.Value;
            }
        }
        private double? _c631;
        public double C631
        {
            get
            {
                //Debug.WriteLine("C631");
                if (_c631 == null)
                    _c631 = Math.Log(_b596.Value * A631 / (_b593.Value - A631)); //Natural Log base(e)
                return _c631.Value;
            }
        }
        private double? _c632;
        public double C632
        {
            get
            {
                //Debug.WriteLine("C632");
                if (_c632 == null)
                    _c632 = Math.Log(_b596.Value * A632 / (_b593.Value - A632)); //Natural Log base(e)
                return _c632.Value;
            }
        }
        private double? _c633;
        public double C633
        {
            get
            {
                //Debug.WriteLine("C633");
                if (_c633 == null)
                    _c633 = Math.Log(_b596.Value * A633 / (_b593.Value - A633)); //Natural Log base(e)
                return _c633.Value;
            }
        }
        private double? _c634;
        public double C634
        {
            get
            {
                //Debug.WriteLine("C634");
                if (_c634 == null)
                    _c634 = Math.Log(_b596.Value * A634 / (_b593.Value - A634)); //Natural Log base(e)
                return _c634.Value;
            }
        }
        private double? _c635;
        public double C635
        {
            get
            {
                //Debug.WriteLine("C635");
                if (_c635 == null)
                    _c635 = Math.Log(_b596.Value * A635 / (_b593.Value - A635)); //Natural Log base(e)
                return _c635.Value;
            }
        }
        private double? _c636;
        public double C636
        {
            get
            {
                //Debug.WriteLine("C636");
                if (_c636 == null)
                    _c636 = Math.Log(_b596.Value * A636 / (_b593.Value - A636)); //Natural Log base(e)
                return _c636.Value;
            }
        }
        private double? _c637;
        public double C637
        {
            get
            {
                //Debug.WriteLine("C637");
                if (_c637 == null)
                    _c637 = Math.Log(_b596.Value * A637 / (_b593.Value - A637)); //Natural Log base(e)
                return _c637.Value;
            }
        }
        private double? _c638;
        public double C638
        {
            get
            {
                //Debug.WriteLine("C638");
                if (_c638 == null)
                    _c638 = Math.Log(_b596.Value * A638 / (_b593.Value - A638)); //Natural Log base(e)
                return _c638.Value;
            }
        }
        private double? _c639;
        public double C639
        {
            get
            {
                //Debug.WriteLine("C639");
                if (_c639 == null)
                    _c639 = Math.Log(_b596.Value * A639 / (_b593.Value - A639)); //Natural Log base(e)
                return _c639.Value;
            }
        }
        private double? _c640;
        public double C640
        {
            get
            {
                //Debug.WriteLine("C640");
                if (_c640 == null)
                    _c640 = Math.Log(_b596.Value * A640 / (_b593.Value - A640)); //Natural Log base(e)
                return _c640.Value;
            }
        }
        private double? _c641;
        public double C641
        {
            get
            {
                //Debug.WriteLine("C641");
                if (_c641 == null)
                    _c641 = Math.Log(_b596.Value * A641 / (_b593.Value - A641)); //Natural Log base(e)
                return _c641.Value;
            }
        }
        private double? _c642;
        public double C642
        {
            get
            {
                //Debug.WriteLine("C642");
                if (_c642 == null)
                    _c642 = Math.Log(_b596.Value * A642 / (_b593.Value - A642)); //Natural Log base(e)
                return _c642.Value;
            }
        }
        private double? _c643;
        public double C643
        {
            get
            {
                //Debug.WriteLine("C643");
                if (_c643 == null)
                    _c643 = Math.Log(_b596.Value * A643 / (_b593.Value - A643)); //Natural Log base(e)
                return _c643.Value;
            }
        }
        private double? _c644;
        public double C644
        {
            get
            {
                //Debug.WriteLine("C644");
                if (_c644 == null)
                    _c644 = Math.Log(_b596.Value * A644 / (_b593.Value - A644)); //Natural Log base(e)
                return _c644.Value;
            }
        }
        private double? _c645;
        public double C645
        {
            get
            {
                //Debug.WriteLine("C645");
                if (_c645 == null)
                    _c645 = Math.Log(_b596.Value * A645 / (_b593.Value - A645)); //Natural Log base(e)
                return _c645.Value;
            }
        }
        private double? _c646;
        public double C646
        {
            get
            {
                //Debug.WriteLine("C646");
                if (_c646 == null)
                    _c646 = Math.Log(_b596.Value * A646 / (_b593.Value - A646)); //Natural Log base(e)
                return _c646.Value;
            }
        }
        private double? _c647;
        public double C647
        {
            get
            {
                //Debug.WriteLine("C647");
                if (_c647 == null)
                    _c647 = Math.Log(_b596.Value * A647 / (_b593.Value - A647)); //Natural Log base(e)
                return _c647.Value;
            }
        }
        private double? _c648;
        public double C648
        {
            get
            {
                //Debug.WriteLine("C648");
                if (_c648 == null)
                    _c648 = Math.Log(_b596.Value * A648 / (_b593.Value - A648)); //Natural Log base(e)
                return _c648.Value;
            }
        }
        private double? _c649;
        public double C649
        {
            get
            {
                //Debug.WriteLine("C649");
                if (_c649 == null)
                    _c649 = Math.Log(_b596.Value * A649 / (_b593.Value - A649)); //Natural Log base(e)
                return _c649.Value;
            }
        }
        private double? _c650;
        public double C650
        {
            get
            {
                //Debug.WriteLine("C650");
                if (_c650 == null)
                    _c650 = Math.Log(_b596.Value * A650 / (_b593.Value - A650)); //Natural Log base(e)
                return _c650.Value;
            }
        }
        private double? _c651;
        public double C651
        {
            get
            {
                //Debug.WriteLine("C651");
                if (_c651 == null)
                    _c651 = Math.Log(_b596.Value * A651 / (_b593.Value - A651)); //Natural Log base(e)
                return _c651.Value;
            }
        }
        private double? _c652;
        public double C652
        {
            get
            {
                //Debug.WriteLine("C652");
                if (_c652 == null)
                    _c652 = Math.Log(_b596.Value * A652 / (_b593.Value - A652)); //Natural Log base(e)
                return _c652.Value;
            }
        }
        private double? _c653;
        public double C653
        {
            get
            {
                //Debug.WriteLine("C653");
                if (_c653 == null)
                    _c653 = Math.Log(_b596.Value * A653 / (_b593.Value - A653)); //Natural Log base(e)
                return _c653.Value;
            }
        }
        private double? _c654;
        public double C654
        {
            get
            {
                //Debug.WriteLine("C654");
                if (_c654 == null)
                    _c654 = Math.Log(_b596.Value * A654 / (_b593.Value - A654)); //Natural Log base(e)
                return _c654.Value;
            }
        }
        private double? _c655;
        public double C655
        {
            get
            {
                //Debug.WriteLine("C655");
                if (_c655 == null)
                    _c655 = Math.Log(_b596.Value * A655 / (_b593.Value - A655)); //Natural Log base(e)
                return _c655.Value;
            }
        }
        private double? _c656;
        public double C656
        {
            get
            {
                //Debug.WriteLine("C656");
                if (_c656 == null)
                    _c656 = Math.Log(_b596.Value * A656 / (_b593.Value - A656)); //Natural Log base(e)
                return _c656.Value;
            }
        }
        private double? _c657;
        public double C657
        {
            get
            {
                //Debug.WriteLine("C657");
                if (_c657 == null)
                    _c657 = Math.Log(_b596.Value * A657 / (_b593.Value - A657)); //Natural Log base(e)
                return _c657.Value;
            }
        }
        private double? _c658;
        public double C658
        {
            get
            {
                //Debug.WriteLine("C658");
                if (_c658 == null)
                    _c658 = Math.Log(_b596.Value * A658 / (_b593.Value - A658)); //Natural Log base(e)
                return _c658.Value;
            }
        }
        private double? _c659;
        public double C659
        {
            get
            {
                //Debug.WriteLine("C659");
                if (_c659 == null)
                    _c659 = Math.Log(_b596.Value * A659 / (_b593.Value - A659)); //Natural Log base(e)
                return _c659.Value;
            }
        }
        private double? _c660;
        public double C660
        {
            get
            {
                //Debug.WriteLine("C660");
                if (_c660 == null)
                    _c660 = Math.Log(_b596.Value * A660 / (_b593.Value - A660)); //Natural Log base(e)
                return _c660.Value;
            }
        }
        private double? _c661;
        public double C661
        {
            get
            {
                //Debug.WriteLine("C661");
                if (_c661 == null)
                    _c661 = Math.Log(_b596.Value * A661 / (_b593.Value - A661)); //Natural Log base(e)
                return _c661.Value;
            }
        }
        private double? _c662;
        public double C662
        {
            get
            {
                //Debug.WriteLine("C662");
                if (_c662 == null)
                    _c662 = Math.Log(_b596.Value * A662 / (_b593.Value - A662)); //Natural Log base(e)
                return _c662.Value;
            }
        }
        private double? _c663;
        public double C663
        {
            get
            {
                //Debug.WriteLine("C663");
                if (_c663 == null)
                    _c663 = Math.Log(_b596.Value * A663 / (_b593.Value - A663)); //Natural Log base(e)
                return _c663.Value;
            }
        }
        private double? _c664;
        public double C664
        {
            get
            {
                //Debug.WriteLine("C664");
                if (_c664 == null)
                    _c664 = Math.Log(_b596.Value * A664 / (_b593.Value - A664)); //Natural Log base(e)
                return _c664.Value;
            }
        }
        private double? _c665;
        public double C665
        {
            get
            {
                //Debug.WriteLine("C665");
                if (_c665 == null)
                    _c665 = Math.Log(_b596.Value * A665 / (_b593.Value - A665)); //Natural Log base(e)
                return _c665.Value;
            }
        }
        private double? _c666;
        public double C666
        {
            get
            {
                //Debug.WriteLine("C666");
                if (_c666 == null)
                    _c666 = Math.Log(_b596.Value * A666 / (_b593.Value - A666)); //Natural Log base(e)
                return _c666.Value;
            }
        }
        private double? _c667;
        public double C667
        {
            get
            {
                //Debug.WriteLine("C667");
                if (_c667 == null)
                    _c667 = Math.Log(_b596.Value * A667 / (_b593.Value - A667)); //Natural Log base(e)
                return _c667.Value;
            }
        }
        private double? _c668;
        public double C668
        {
            get
            {
                //Debug.WriteLine("C668");
                if (_c668 == null)
                    _c668 = Math.Log(_b596.Value * A668 / (_b593.Value - A668)); //Natural Log base(e)
                return _c668.Value;
            }
        }
        private double? _c669;
        public double C669
        {
            get
            {
                //Debug.WriteLine("C669");
                if (_c669 == null)
                    _c669 = Math.Log(_b596.Value * A669 / (_b593.Value - A669)); //Natural Log base(e)
                return _c669.Value;
            }
        }
        private double? _c670;
        public double C670
        {
            get
            {
                //Debug.WriteLine("C670");
                if (_c670 == null)
                    _c670 = Math.Log(_b596.Value * A670 / (_b593.Value - A670)); //Natural Log base(e)
                return _c670.Value;
            }
        }
        private double? _c671;
        public double C671
        {
            get
            {
                //Debug.WriteLine("C671");
                if (_c671 == null)
                    _c671 = Math.Log(_b596.Value * A671 / (_b593.Value - A671)); //Natural Log base(e)
                return _c671.Value;
            }
        }
        private double? _c672;
        public double C672
        {
            get
            {
                //Debug.WriteLine("C672");
                if (_c672 == null)
                    _c672 = Math.Log(_b596.Value * A672 / (_b593.Value - A672)); //Natural Log base(e)
                return _c672.Value;
            }
        }
        private double? _c673;
        public double C673
        {
            get
            {
                //Debug.WriteLine("C673");
                if (_c673 == null)
                    _c673 = Math.Log(_b596.Value * A673 / (_b593.Value - A673)); //Natural Log base(e)
                return _c673.Value;
            }
        }
        private double? _c674;
        public double C674
        {
            get
            {
                //Debug.WriteLine("C674");
                if (_c674 == null)
                    _c674 = Math.Log(_b596.Value * A674 / (_b593.Value - A674)); //Natural Log base(e)
                return _c674.Value;
            }
        }
        private double? _c675;
        public double C675
        {
            get
            {
                //Debug.WriteLine("C675");
                if (_c675 == null)
                    _c675 = Math.Log(_b596.Value * A675 / (_b593.Value - A675)); //Natural Log base(e)
                return _c675.Value;
            }
        }
        private double? _c676;
        public double C676
        {
            get
            {
                //Debug.WriteLine("C676");
                if (_c676 == null)
                    _c676 = Math.Log(_b596.Value * A676 / (_b593.Value - A676)); //Natural Log base(e)
                return _c676.Value;
            }
        }
        private double? _c677;
        public double C677
        {
            get
            {
                //Debug.WriteLine("C677");
                if (_c677 == null)
                    _c677 = Math.Log(_b596.Value * A677 / (_b593.Value - A677)); //Natural Log base(e)
                return _c677.Value;
            }
        }
        private double? _c678;
        public double C678
        {
            get
            {
                //Debug.WriteLine("C678");
                if (_c678 == null)
                    _c678 = Math.Log(_b596.Value * A678 / (_b593.Value - A678)); //Natural Log base(e)
                return _c678.Value;
            }
        }
        private double? _c679;
        public double C679
        {
            get
            {
                //Debug.WriteLine("C679");
                if (_c679 == null)
                    _c679 = Math.Log(_b596.Value * A679 / (_b593.Value - A679)); //Natural Log base(e)
                return _c679.Value;
            }
        }
        private double? _c680;
        public double C680
        {
            get
            {
                //Debug.WriteLine("C680");
                if (_c680 == null)
                    _c680 = Math.Log(_b596.Value * A680 / (_b593.Value - A680)); //Natural Log base(e)
                return _c680.Value;
            }
        }
        private double? _c681;
        public double C681
        {
            get
            {
                //Debug.WriteLine("C681");
                if (_c681 == null)
                    _c681 = Math.Log(_b596.Value * A681 / (_b593.Value - A681)); //Natural Log base(e)
                return _c681.Value;
            }
        }
        private double? _c682;
        public double C682
        {
            get
            {
                //Debug.WriteLine("C682");
                if (_c682 == null)
                    _c682 = Math.Log(_b596.Value * A682 / (_b593.Value - A682)); //Natural Log base(e)
                return _c682.Value;
            }
        }
        private double? _c683;
        public double C683
        {
            get
            {
                //Debug.WriteLine("C683");
                if (_c683 == null)
                    _c683 = Math.Log(_b596.Value * A683 / (_b593.Value - A683)); //Natural Log base(e)
                return _c683.Value;
            }
        }
        private double? _c684;
        public double C684
        {
            get
            {
                //Debug.WriteLine("C684");
                if (_c684 == null)
                    _c684 = Math.Log(_b596.Value * A684 / (_b593.Value - A684)); //Natural Log base(e)
                return _c684.Value;
            }
        }
        private double? _c685;
        public double C685
        {
            get
            {
                //Debug.WriteLine("C685");
                if (_c685 == null)
                    _c685 = Math.Log(_b596.Value * A685 / (_b593.Value - A685)); //Natural Log base(e)
                return _c685.Value;
            }
        }
        private double? _c686;
        public double C686
        {
            get
            {
                //Debug.WriteLine("C686");
                if (_c686 == null)
                    _c686 = Math.Log(_b596.Value * A686 / (_b593.Value - A686)); //Natural Log base(e)
                return _c686.Value;
            }
        }
        private double? _c687;
        public double C687
        {
            get
            {
                //Debug.WriteLine("C687");
                if (_c687 == null)
                    _c687 = Math.Log(_b596.Value * A687 / (_b593.Value - A687)); //Natural Log base(e)
                return _c687.Value;
            }
        }
        private double? _c688;
        public double C688
        {
            get
            {
                //Debug.WriteLine("C688");
                if (_c688 == null)
                    _c688 = Math.Log(_b596.Value * A688 / (_b593.Value - A688)); //Natural Log base(e)
                return _c688.Value;
            }
        }
        private double? _c689;
        public double C689
        {
            get
            {
                //Debug.WriteLine("C689");
                if (_c689 == null)
                    _c689 = Math.Log(_b596.Value * A689 / (_b593.Value - A689)); //Natural Log base(e)
                return _c689.Value;
            }
        }
        private double? _c690;
        public double C690
        {
            get
            {
                //Debug.WriteLine("C690");
                if (_c690 == null)
                    _c690 = Math.Log(_b596.Value * A690 / (_b593.Value - A690)); //Natural Log base(e)
                return _c690.Value;
            }
        }
        private double? _c691;
        public double C691
        {
            get
            {
                //Debug.WriteLine("C691");
                if (_c691 == null)
                    _c691 = Math.Log(_b596.Value * A691 / (_b593.Value - A691)); //Natural Log base(e)
                return _c691.Value;
            }
        }
        private double? _c692;
        public double C692
        {
            get
            {
                //Debug.WriteLine("C692");
                if (_c692 == null)
                    _c692 = Math.Log(_b596.Value * A692 / (_b593.Value - A692)); //Natural Log base(e)
                return _c692.Value;
            }
        }
        private double? _c693;
        public double C693
        {
            get
            {
                //Debug.WriteLine("C693");
                if (_c693 == null)
                    _c693 = Math.Log(_b596.Value * A693 / (_b593.Value - A693)); //Natural Log base(e)
                return _c693.Value;
            }
        }
        private double? _c694;
        public double C694
        {
            get
            {
                //Debug.WriteLine("C694");
                if (_c694 == null)
                    _c694 = Math.Log(_b596.Value * A694 / (_b593.Value - A694)); //Natural Log base(e)
                return _c694.Value;
            }
        }
        private double? _c695;
        public double C695
        {
            get
            {
                //Debug.WriteLine("C695");
                if (_c695 == null)
                    _c695 = Math.Log(_b596.Value * A695 / (_b593.Value - A695)); //Natural Log base(e)
                return _c695.Value;
            }
        }
        private double? _c696;
        public double C696
        {
            get
            {
                //Debug.WriteLine("C696");
                if (_c696 == null)
                    _c696 = Math.Log(_b596.Value * A696 / (_b593.Value - A696)); //Natural Log base(e)
                return _c696.Value;
            }
        }
        private double? _c697;
        public double C697
        {
            get
            {
                //Debug.WriteLine("C697");
                if (_c697 == null)
                    _c697 = Math.Log(_b596.Value * A697 / (_b593.Value - A697)); //Natural Log base(e)
                return _c697.Value;
            }
        }
        private double? _c698;
        public double C698
        {
            get
            {
                //Debug.WriteLine("C698");
                if (_c698 == null)
                    _c698 = Math.Log(_b596.Value * A698 / (_b593.Value - A698)); //Natural Log base(e)
                return _c698.Value;
            }
        }
        private double? _c699;
        public double C699
        {
            get
            {
                //Debug.WriteLine("C699");
                if (_c699 == null)
                    _c699 = Math.Log(_b596.Value * A699 / (_b593.Value - A699)); //Natural Log base(e)
                return _c699.Value;
            }
        }
        private double? _c700;
        public double C700
        {
            get
            {
                //Debug.WriteLine("C700");
                if (_c700 == null)
                    _c700 = Math.Log(_b596.Value * A700 / (_b593.Value - A700)); //Natural Log base(e)
                return _c700.Value;
            }
        }
        private double? _c701;
        public double C701
        {
            get
            {
                //Debug.WriteLine("C701");
                if (_c701 == null)
                    _c701 = Math.Log(_b596.Value * A701 / (_b593.Value - A701)); //Natural Log base(e)
                return _c701.Value;
            }
        }
        private double? _c702;
        public double C702
        {
            get
            {
                //Debug.WriteLine("C702");
                if (_c702 == null)
                    _c702 = Math.Log(_b596.Value * A702 / (_b593.Value - A702)); //Natural Log base(e)
                return _c702.Value;
            }
        }
        private double? _c703;
        public double C703
        {
            get
            {
                //Debug.WriteLine("C703");
                if (_c703 == null)
                    _c703 = Math.Log(_b596.Value * A703 / (_b593.Value - A703)); //Natural Log base(e)
                return _c703.Value;
            }
        }
        private double? _c704;
        public double C704
        {
            get
            {
                //Debug.WriteLine("C704");
                if (_c704 == null)
                    _c704 = Math.Log(_b596.Value * A704 / (_b593.Value - A704)); //Natural Log base(e)
                return _c704.Value;
            }
        }
        private double? _c705;
        public double C705
        {
            get
            {
                //Debug.WriteLine("C705");
                if (_c705 == null)
                    _c705 = Math.Log(_b596.Value * A705 / (_b593.Value - A705)); //Natural Log base(e)
                return _c705.Value;
            }
        }
        private double? _c706;
        public double C706
        {
            get
            {
                //Debug.WriteLine("C706");
                if (_c706 == null)
                    _c706 = Math.Log(_b596.Value * A706 / (_b593.Value - A706)); //Natural Log base(e)
                return _c706.Value;
            }
        }
        private double? _c707;
        public double C707
        {
            get
            {
                //Debug.WriteLine("C707");
                if (_c707 == null)
                    _c707 = Math.Log(_b596.Value * A707 / (_b593.Value - A707)); //Natural Log base(e)
                return _c707.Value;
            }
        }
        private double? _c708;
        public double C708
        {
            get
            {
                //Debug.WriteLine("C708");
                if (_c708 == null)
                    _c708 = Math.Log(_b596.Value * A708 / (_b593.Value - A708)); //Natural Log base(e)
                return _c708.Value;
            }
        }
        private double? _c709;
        public double C709
        {
            get
            {
                //Debug.WriteLine("C709");
                if (_c709 == null)
                    _c709 = Math.Log(_b596.Value * A709 / (_b593.Value - A709)); //Natural Log base(e)
                return _c709.Value;
            }
        }
        private double? _c710;
        public double C710
        {
            get
            {
                //Debug.WriteLine("C710");
                if (_c710 == null)
                    _c710 = Math.Log(_b596.Value * A710 / (_b593.Value - A710)); //Natural Log base(e)
                return _c710.Value;
            }
        }
        private double? _c711;
        public double C711
        {
            get
            {
                //Debug.WriteLine("C711");
                if (_c711 == null)
                    _c711 = Math.Log(_b596.Value * A711 / (_b593.Value - A711)); //Natural Log base(e)
                return _c711.Value;
            }
        }
        private double? _c712;
        public double C712
        {
            get
            {
                //Debug.WriteLine("C712");
                if (_c712 == null)
                    _c712 = Math.Log(_b596.Value * A712 / (_b593.Value - A712)); //Natural Log base(e)
                return _c712.Value;
            }
        }
        private double? _c713;
        public double C713
        {
            get
            {
                //Debug.WriteLine("C713");
                if (_c713 == null)
                    _c713 = Math.Log(_b596.Value * A713 / (_b593.Value - A713)); //Natural Log base(e)
                return _c713.Value;
            }
        }
        private double? _c714;
        public double C714
        {
            get
            {
                //Debug.WriteLine("C714");
                if (_c714 == null)
                    _c714 = Math.Log(_b596.Value * A714 / (_b593.Value - A714)); //Natural Log base(e)
                return _c714.Value;
            }
        }
        private double? _c715;
        public double C715
        {
            get
            {
                //Debug.WriteLine("C715");
                if (_c715 == null)
                    _c715 = Math.Log(_b596.Value * A715 / (_b593.Value - A715)); //Natural Log base(e)
                return _c715.Value;
            }
        }
        private double? _c716;
        public double C716
        {
            get
            {
                //Debug.WriteLine("C716");
                if (_c716 == null)
                    _c716 = Math.Log(_b596.Value * A716 / (_b593.Value - A716)); //Natural Log base(e)
                return _c716.Value;
            }
        }
        private double? _c717;
        public double C717
        {
            get
            {
                //Debug.WriteLine("C717");
                if (_c717 == null)
                    _c717 = Math.Log(_b596.Value * A717 / (_b593.Value - A717)); //Natural Log base(e)
                return _c717.Value;
            }
        }
        private double? _c718;
        public double C718
        {
            get
            {
                //Debug.WriteLine("C718");
                if (_c718 == null)
                    _c718 = Math.Log(_b596.Value * A718 / (_b593.Value - A718)); //Natural Log base(e)
                return _c718.Value;
            }
        }
        private double? _c719;
        public double C719
        {
            get
            {
                //Debug.WriteLine("C719");
                if (_c719 == null)
                    _c719 = Math.Log(_b596.Value * A719 / (_b593.Value - A719)); //Natural Log base(e)
                return _c719.Value;
            }
        }
        private double? _c720;
        public double C720
        {
            get
            {
                //Debug.WriteLine("C720");
                if (_c720 == null)
                    _c720 = Math.Log(_b596.Value * A720 / (_b593.Value - A720)); //Natural Log base(e)
                return _c720.Value;
            }
        }
        private double? _c721;
        public double C721
        {
            get
            {
                //Debug.WriteLine("C721");
                if (_c721 == null)
                    _c721 = Math.Log(_b596.Value * A721 / (_b593.Value - A721)); //Natural Log base(e)
                return _c721.Value;
            }
        }
        private double? _c722;
        public double C722
        {
            get
            {
                //Debug.WriteLine("C722");
                if (_c722 == null)
                    _c722 = Math.Log(_b596.Value * A722 / (_b593.Value - A722)); //Natural Log base(e)
                return _c722.Value;
            }
        }
        private double? _c723;
        public double C723
        {
            get
            {
                //Debug.WriteLine("C723");
                if (_c723 == null)
                    _c723 = Math.Log(_b596.Value * A723 / (_b593.Value - A723)); //Natural Log base(e)
                return _c723.Value;
            }
        }
        private double? _c724;
        public double C724
        {
            get
            {
                //Debug.WriteLine("C724");
                if (_c724 == null)
                    _c724 = Math.Log(_b596.Value * A724 / (_b593.Value - A724)); //Natural Log base(e)
                return _c724.Value;
            }
        }
        private double? _c725;
        public double C725
        {
            get
            {
                //Debug.WriteLine("C725");
                if (_c725 == null)
                    _c725 = Math.Log(_b596.Value * A725 / (_b593.Value - A725)); //Natural Log base(e)
                return _c725.Value;
            }
        }
        private double? _c726;
        public double C726
        {
            get
            {
                //Debug.WriteLine("C726");
                if (_c726 == null)
                    _c726 = Math.Log(_b596.Value * A726 / (_b593.Value - A726)); //Natural Log base(e)
                return _c726.Value;
            }
        }
        private double? _c727;
        public double C727
        {
            get
            {
                //Debug.WriteLine("C727");
                if (_c727 == null)
                    _c727 = Math.Log(_b596.Value * A727 / (_b593.Value - A727)); //Natural Log base(e)
                return _c727.Value;
            }
        }
        private double? _c728;
        public double C728
        {
            get
            {
                //Debug.WriteLine("C728");
                if (_c728 == null)
                    _c728 = Math.Log(_b596.Value * A728 / (_b593.Value - A728)); //Natural Log base(e)
                return _c728.Value;
            }
        }
        private double? _c729;
        public double C729
        {
            get
            {
                //Debug.WriteLine("C729");
                if (_c729 == null)
                    _c729 = Math.Log(_b596.Value * A729 / (_b593.Value - A729)); //Natural Log base(e)
                return _c729.Value;
            }
        }
        private double? _c730;
        public double C730
        {
            get
            {
                //Debug.WriteLine("C730");
                if (_c730 == null)
                    _c730 = Math.Log(_b596.Value * A730 / (_b593.Value - A730)); //Natural Log base(e)
                return _c730.Value;
            }
        }
        private double? _c731;
        public double C731
        {
            get
            {
                //Debug.WriteLine("C731");
                if (_c731 == null)
                    _c731 = Math.Log(_b596.Value * A731 / (_b593.Value - A731)); //Natural Log base(e)
                return _c731.Value;
            }
        }
        private double? _c732;
        public double C732
        {
            get
            {
                //Debug.WriteLine("C732");
                if (_c732 == null)
                    _c732 = Math.Log(_b596.Value * A732 / (_b593.Value - A732)); //Natural Log base(e)
                return _c732.Value;
            }
        }
        private double? _c733;
        public double C733
        {
            get
            {
                //Debug.WriteLine("C733");
                if (_c733 == null)
                    _c733 = Math.Log(_b596.Value * A733 / (_b593.Value - A733)); //Natural Log base(e)
                return _c733.Value;
            }
        }
        private double? _c734;
        public double C734
        {
            get
            {
                //Debug.WriteLine("C734");
                if (_c734 == null)
                    _c734 = Math.Log(_b596.Value * A734 / (_b593.Value - A734)); //Natural Log base(e)
                return _c734.Value;
            }
        }
        private double? _c735;
        public double C735
        {
            get
            {
                //Debug.WriteLine("C735");
                if (_c735 == null)
                    _c735 = Math.Log(_b596.Value * A735 / (_b593.Value - A735)); //Natural Log base(e)
                return _c735.Value;
            }
        }
        private double? _c736;
        public double C736
        {
            get
            {
                //Debug.WriteLine("C736");
                if (_c736 == null)
                    _c736 = Math.Log(_b596.Value * A736 / (_b593.Value - A736)); //Natural Log base(e)
                return _c736.Value;
            }
        }
        private double? _c737;
        public double C737
        {
            get
            {
                //Debug.WriteLine("C737");
                if (_c737 == null)
                    _c737 = Math.Log(_b596.Value * A737 / (_b593.Value - A737)); //Natural Log base(e)
                return _c737.Value;
            }
        }
        private double? _c738;
        public double C738
        {
            get
            {
                //Debug.WriteLine("C738");
                if (_c738 == null)
                    _c738 = Math.Log(_b596.Value * A738 / (_b593.Value - A738)); //Natural Log base(e)
                return _c738.Value;
            }
        }
        private double? _c739;
        public double C739
        {
            get
            {
                //Debug.WriteLine("C739");
                if (_c739 == null)
                    _c739 = Math.Log(_b596.Value * A739 / (_b593.Value - A739)); //Natural Log base(e)
                return _c739.Value;
            }
        }
        private double? _c740;
        public double C740
        {
            get
            {
                //Debug.WriteLine("C740");
                if (_c740 == null)
                    _c740 = Math.Log(_b596.Value * A740 / (_b593.Value - A740)); //Natural Log base(e)
                return _c740.Value;
            }
        }
        private double? _c741;
        public double C741
        {
            get
            {
                //Debug.WriteLine("C741");
                if (_c741 == null)
                    _c741 = Math.Log(_b596.Value * A741 / (_b593.Value - A741)); //Natural Log base(e)
                return _c741.Value;
            }
        }
        private double? _c742;
        public double C742
        {
            get
            {
                //Debug.WriteLine("C742");
                if (_c742 == null)
                    _c742 = Math.Log(_b596.Value * A742 / (_b593.Value - A742)); //Natural Log base(e)
                return _c742.Value;
            }
        }
        private double? _c743;
        public double C743
        {
            get
            {
                //Debug.WriteLine("C743");
                if (_c743 == null)
                    _c743 = Math.Log(_b596.Value * A743 / (_b593.Value - A743)); //Natural Log base(e)
                return _c743.Value;
            }
        }
        private double? _c744;
        public double C744
        {
            get
            {
                //Debug.WriteLine("C744");
                if (_c744 == null)
                    _c744 = Math.Log(_b596.Value * A744 / (_b593.Value - A744)); //Natural Log base(e)
                return _c744.Value;
            }
        }
        private double? _c745;
        public double C745
        {
            get
            {
                //Debug.WriteLine("C745");
                if (_c745 == null)
                    _c745 = Math.Log(_b596.Value * A745 / (_b593.Value - A745)); //Natural Log base(e)
                return _c745.Value;
            }
        }
        private double? _c746;
        public double C746
        {
            get
            {
                //Debug.WriteLine("C746");
                if (_c746 == null)
                    _c746 = Math.Log(_b596.Value * A746 / (_b593.Value - A746)); //Natural Log base(e)
                return _c746.Value;
            }
        }
        private double? _c747;
        public double C747
        {
            get
            {
                //Debug.WriteLine("C747");
                if (_c747 == null)
                    _c747 = Math.Log(_b596.Value * A747 / (_b593.Value - A747)); //Natural Log base(e)
                return _c747.Value;
            }
        }
        private double? _c748;
        public double C748
        {
            get
            {
                //Debug.WriteLine("C748");
                if (_c748 == null)
                    _c748 = Math.Log(_b596.Value * A748 / (_b593.Value - A748)); //Natural Log base(e)
                return _c748.Value;
            }
        }
        private double? _c749;
        public double C749
        {
            get
            {
                //Debug.WriteLine("C749");
                if (_c749 == null)
                    _c749 = Math.Log(_b596.Value * A749 / (_b593.Value - A749)); //Natural Log base(e)
                return _c749.Value;
            }
        }
        private double? _c750;
        public double C750
        {
            get
            {
                //Debug.WriteLine("C750");
                if (_c750 == null)
                    _c750 = Math.Log(_b596.Value * A750 / (_b593.Value - A750)); //Natural Log base(e)
                return _c750.Value;
            }
        }
        private double? _c751;
        public double C751
        {
            get
            {
                //Debug.WriteLine("C751");
                if (_c751 == null)
                    _c751 = Math.Log(_b596.Value * A751 / (_b593.Value - A751)); //Natural Log base(e)
                return _c751.Value;
            }
        }
        private double? _c752;
        public double C752
        {
            get
            {
                //Debug.WriteLine("C752");
                if (_c752 == null)
                    _c752 = Math.Log(_b596.Value * A752 / (_b593.Value - A752)); //Natural Log base(e)
                return _c752.Value;
            }
        }
        private double? _c753;
        public double C753
        {
            get
            {
                //Debug.WriteLine("C753");
                if (_c753 == null)
                    _c753 = Math.Log(_b596.Value * A753 / (_b593.Value - A753)); //Natural Log base(e)
                return _c753.Value;
            }
        }
        private double? _c754;
        public double C754
        {
            get
            {
                //Debug.WriteLine("C754");
                if (_c754 == null)
                    _c754 = Math.Log(_b596.Value * A754 / (_b593.Value - A754)); //Natural Log base(e)
                return _c754.Value;
            }
        }
        private double? _c755;
        public double C755
        {
            get
            {
                //Debug.WriteLine("C755");
                if (_c755 == null)
                    _c755 = Math.Log(_b596.Value * A755 / (_b593.Value - A755)); //Natural Log base(e)
                return _c755.Value;
            }
        }
        private double? _c756;
        public double C756
        {
            get
            {
                //Debug.WriteLine("C756");
                if (_c756 == null)
                    _c756 = Math.Log(_b596.Value * A756 / (_b593.Value - A756)); //Natural Log base(e)
                return _c756.Value;
            }
        }
        private double? _c757;
        public double C757
        {
            get
            {
                //Debug.WriteLine("C757");
                if (_c757 == null)
                    _c757 = Math.Log(_b596.Value * A757 / (_b593.Value - A757)); //Natural Log base(e)
                return _c757.Value;
            }
        }
        private double? _c758;
        public double C758
        {
            get
            {
                //Debug.WriteLine("C758");
                if (_c758 == null)
                    _c758 = Math.Log(_b596.Value * A758 / (_b593.Value - A758)); //Natural Log base(e)
                return _c758.Value;
            }
        }
        private double? _c759;
        public double C759
        {
            get
            {
                //Debug.WriteLine("C759");
                if (_c759 == null)
                    _c759 = Math.Log(_b596.Value * A759 / (_b593.Value - A759)); //Natural Log base(e)
                return _c759.Value;
            }
        }
        private double? _c760;
        public double C760
        {
            get
            {
                //Debug.WriteLine("C760");
                if (_c760 == null)
                    _c760 = Math.Log(_b596.Value * A760 / (_b593.Value - A760)); //Natural Log base(e)
                return _c760.Value;
            }
        }
        private double? _c761;
        public double C761
        {
            get
            {
                //Debug.WriteLine("C761");
                if (_c761 == null)
                    _c761 = Math.Log(_b596.Value * A761 / (_b593.Value - A761)); //Natural Log base(e)
                return _c761.Value;
            }
        }
        private double? _c762;
        public double C762
        {
            get
            {
                //Debug.WriteLine("C762");
                if (_c762 == null)
                    _c762 = Math.Log(_b596.Value * A762 / (_b593.Value - A762)); //Natural Log base(e)
                return _c762.Value;
            }
        }
        private double? _c763;
        public double C763
        {
            get
            {
                //Debug.WriteLine("C763");
                if (_c763 == null)
                    _c763 = Math.Log(_b596.Value * A763 / (_b593.Value - A763)); //Natural Log base(e)
                return _c763.Value;
            }
        }
        private double? _c764;
        public double C764
        {
            get
            {
                //Debug.WriteLine("C764");
                if (_c764 == null)
                    _c764 = Math.Log(_b596.Value * A764 / (_b593.Value - A764)); //Natural Log base(e)
                return _c764.Value;
            }
        }
        private double? _c765;
        public double C765
        {
            get
            {
                //Debug.WriteLine("C765");
                if (_c765 == null)
                    _c765 = Math.Log(_b596.Value * A765 / (_b593.Value - A765)); //Natural Log base(e)
                return _c765.Value;
            }
        }
        private double? _c766;
        public double C766
        {
            get
            {
                //Debug.WriteLine("C766");
                if (_c766 == null)
                    _c766 = Math.Log(_b596.Value * A766 / (_b593.Value - A766)); //Natural Log base(e)
                return _c766.Value;
            }
        }
        private double? _c767;
        public double C767
        {
            get
            {
                //Debug.WriteLine("C767");
                if (_c767 == null)
                    _c767 = Math.Log(_b596.Value * A767 / (_b593.Value - A767)); //Natural Log base(e)
                return _c767.Value;
            }
        }
        private double? _c768;
        public double C768
        {
            get
            {
                //Debug.WriteLine("C768");
                if (_c768 == null)
                    _c768 = Math.Log(_b596.Value * A768 / (_b593.Value - A768)); //Natural Log base(e)
                return _c768.Value;
            }
        }
        private double? _c769;
        public double C769
        {
            get
            {
                //Debug.WriteLine("C769");
                if (_c769 == null)
                    _c769 = Math.Log(_b596.Value * A769 / (_b593.Value - A769)); //Natural Log base(e)
                return _c769.Value;
            }
        }
        private double? _c770;
        public double C770
        {
            get
            {
                //Debug.WriteLine("C770");
                if (_c770 == null)
                    _c770 = Math.Log(_b596.Value * A770 / (_b593.Value - A770)); //Natural Log base(e)
                return _c770.Value;
            }
        }
        private double? _c771;
        public double C771
        {
            get
            {
                //Debug.WriteLine("C771");
                if (_c771 == null)
                    _c771 = Math.Log(_b596.Value * A771 / (_b593.Value - A771)); //Natural Log base(e)
                return _c771.Value;
            }
        }
        private double? _c772;
        public double C772
        {
            get
            {
                //Debug.WriteLine("C772");
                if (_c772 == null)
                    _c772 = Math.Log(_b596.Value * A772 / (_b593.Value - A772)); //Natural Log base(e)
                return _c772.Value;
            }
        }
        private double? _c773;
        public double C773
        {
            get
            {
                //Debug.WriteLine("C773");
                if (_c773 == null)
                    _c773 = Math.Log(_b596.Value * A773 / (_b593.Value - A773)); //Natural Log base(e)
                return _c773.Value;
            }
        }
        private double? _c774;
        public double C774
        {
            get
            {
                //Debug.WriteLine("C774");
                if (_c774 == null)
                    _c774 = Math.Log(_b596.Value * A774 / (_b593.Value - A774)); //Natural Log base(e)
                return _c774.Value;
            }
        }
        private double? _c775;
        public double C775
        {
            get
            {
                //Debug.WriteLine("C775");
                if (_c775 == null)
                    _c775 = Math.Log(_b596.Value * A775 / (_b593.Value - A775)); //Natural Log base(e)
                return _c775.Value;
            }
        }
        private double? _c776;
        public double C776
        {
            get
            {
                //Debug.WriteLine("C776");
                if (_c776 == null)
                    _c776 = Math.Log(_b596.Value * A776 / (_b593.Value - A776)); //Natural Log base(e)
                return _c776.Value;
            }
        }
        private double? _c777;
        public double C777
        {
            get
            {
                //Debug.WriteLine("C777");
                if (_c777 == null)
                    _c777 = Math.Log(_b596.Value * A777 / (_b593.Value - A777)); //Natural Log base(e)
                return _c777.Value;
            }
        }
        private double? _c778;
        public double C778
        {
            get
            {
                //Debug.WriteLine("C778");
                if (_c778 == null)
                    _c778 = Math.Log(_b596.Value * A778 / (_b593.Value - A778)); //Natural Log base(e)
                return _c778.Value;
            }
        }
        private double? _c779;
        public double C779
        {
            get
            {
                //Debug.WriteLine("C779");
                if (_c779 == null)
                    _c779 = Math.Log(_b596.Value * A779 / (_b593.Value - A779)); //Natural Log base(e)
                return _c779.Value;
            }
        }
        private double? _c780;
        public double C780
        {
            get
            {
                //Debug.WriteLine("C780");
                if (_c780 == null)
                    _c780 = Math.Log(_b596.Value * A780 / (_b593.Value - A780)); //Natural Log base(e)
                return _c780.Value;
            }
        }
        private double? _c781;
        public double C781
        {
            get
            {
                //Debug.WriteLine("C781");
                if (_c781 == null)
                    _c781 = Math.Log(_b596.Value * A781 / (_b593.Value - A781)); //Natural Log base(e)
                return _c781.Value;
            }
        }
        private double? _c782;
        public double C782
        {
            get
            {
                //Debug.WriteLine("C782");
                if (_c782 == null)
                    _c782 = Math.Log(_b596.Value * A782 / (_b593.Value - A782)); //Natural Log base(e)
                return _c782.Value;
            }
        }
        private double? _c783;
        public double C783
        {
            get
            {
                //Debug.WriteLine("C783");
                if (_c783 == null)
                    _c783 = Math.Log(_b596.Value * A783 / (_b593.Value - A783)); //Natural Log base(e)
                return _c783.Value;
            }
        }
        private double? _c784;
        public double C784
        {
            get
            {
                //Debug.WriteLine("C784");
                if (_c784 == null)
                    _c784 = Math.Log(_b596.Value * A784 / (_b593.Value - A784)); //Natural Log base(e)
                return _c784.Value;
            }
        }
        private double? _c785;
        public double C785
        {
            get
            {
                //Debug.WriteLine("C785");
                if (_c785 == null)
                    _c785 = Math.Log(_b596.Value * A785 / (_b593.Value - A785)); //Natural Log base(e)
                return _c785.Value;
            }
        }
        private double? _c786;
        public double C786
        {
            get
            {
                //Debug.WriteLine("C786");
                if (_c786 == null)
                    _c786 = Math.Log(_b596.Value * A786 / (_b593.Value - A786)); //Natural Log base(e)
                return _c786.Value;
            }
        }
        private double? _c787;
        public double C787
        {
            get
            {
                //Debug.WriteLine("C787");
                if (_c787 == null)
                    _c787 = Math.Log(_b596.Value * A787 / (_b593.Value - A787)); //Natural Log base(e)
                return _c787.Value;
            }
        }
        private double? _c788;
        public double C788
        {
            get
            {
                //Debug.WriteLine("C788");
                if (_c788 == null)
                    _c788 = Math.Log(_b596.Value * A788 / (_b593.Value - A788)); //Natural Log base(e)
                return _c788.Value;
            }
        }
        private double? _c789;
        public double C789
        {
            get
            {
                //Debug.WriteLine("C789");
                if (_c789 == null)
                    _c789 = Math.Log(_b596.Value * A789 / (_b593.Value - A789)); //Natural Log base(e)
                return _c789.Value;
            }
        }
        private double? _c790;
        public double C790
        {
            get
            {
                //Debug.WriteLine("C790");
                if (_c790 == null)
                    _c790 = Math.Log(_b596.Value * A790 / (_b593.Value - A790)); //Natural Log base(e)
                return _c790.Value;
            }
        }
        private double? _c791;
        public double C791
        {
            get
            {
                //Debug.WriteLine("C791");
                if (_c791 == null)
                    _c791 = Math.Log(_b596.Value * A791 / (_b593.Value - A791)); //Natural Log base(e)
                return _c791.Value;
            }
        }
        private double? _c792;
        public double C792
        {
            get
            {
                //Debug.WriteLine("C792");
                if (_c792 == null)
                    _c792 = Math.Log(_b596.Value * A792 / (_b593.Value - A792)); //Natural Log base(e)
                return _c792.Value;
            }
        }
        private double? _c793;
        public double C793
        {
            get
            {
                //Debug.WriteLine("C793");
                if (_c793 == null)
                    _c793 = Math.Log(_b596.Value * A793 / (_b593.Value - A793)); //Natural Log base(e)
                return _c793.Value;
            }
        }
        private double? _c794;
        public double C794
        {
            get
            {
                //Debug.WriteLine("C794");
                if (_c794 == null)
                    _c794 = Math.Log(_b596.Value * A794 / (_b593.Value - A794)); //Natural Log base(e)
                return _c794.Value;
            }
        }
        private double? _c795;
        public double C795
        {
            get
            {
                //Debug.WriteLine("C795");
                if (_c795 == null)
                    _c795 = Math.Log(_b596.Value * A795 / (_b593.Value - A795)); //Natural Log base(e)
                return _c795.Value;
            }
        }
        private double? _c796;
        public double C796
        {
            get
            {
                //Debug.WriteLine("C796");
                if (_c796 == null)
                    _c796 = Math.Log(_b596.Value * A796 / (_b593.Value - A796)); //Natural Log base(e)
                return _c796.Value;
            }
        }
        private double? _c797;
        public double C797
        {
            get
            {
                //Debug.WriteLine("C797");
                if (_c797 == null)
                    _c797 = Math.Log(_b596.Value * A797 / (_b593.Value - A797)); //Natural Log base(e)
                return _c797.Value;
            }
        }
        private double? _c798;
        public double C798
        {
            get
            {
                //Debug.WriteLine("C798");
                if (_c798 == null)
                    _c798 = Math.Log(_b596.Value * A798 / (_b593.Value - A798)); //Natural Log base(e)
                return _c798.Value;
            }
        }
        private double? _c799;
        public double C799
        {
            get
            {
                //Debug.WriteLine("C799");
                if (_c799 == null)
                    _c799 = Math.Log(_b596.Value * A799 / (_b593.Value - A799)); //Natural Log base(e)
                return _c799.Value;
            }
        }
        private double? _c800;
        public double C800
        {
            get
            {
                //Debug.WriteLine("C800");
                if (_c800 == null)
                    _c800 = Math.Log(_b596.Value * A800 / (_b593.Value - A800)); //Natural Log base(e)
                return _c800.Value;
            }
        }
        private double? _c801;
        public double C801
        {
            get
            {
                //Debug.WriteLine("C801");
                if (_c801 == null)
                    _c801 = Math.Log(_b596.Value * A801 / (_b593.Value - A801)); //Natural Log base(e)
                return _c801.Value;
            }
        }
        private double? _c802;
        public double C802
        {
            get
            {
                //Debug.WriteLine("C802");
                if (_c802 == null)
                    _c802 = Math.Log(_b596.Value * A802 / (_b593.Value - A802)); //Natural Log base(e)
                return _c802.Value;
            }
        }
        private double? _c803;
        public double C803
        {
            get
            {
                //Debug.WriteLine("C803");
                if (_c803 == null)
                    _c803 = Math.Log(_b596.Value * A803 / (_b593.Value - A803)); //Natural Log base(e)
                return _c803.Value;
            }
        }
        private double? _c804;
        public double C804
        {
            get
            {
                //Debug.WriteLine("C804");
                if (_c804 == null)
                    _c804 = Math.Log(_b596.Value * A804 / (_b593.Value - A804)); //Natural Log base(e)
                return _c804.Value;
            }
        }
        private double? _c805;
        public double C805
        {
            get
            {
                //Debug.WriteLine("C805");
                if (_c805 == null)
                    _c805 = Math.Log(_b596.Value * A805 / (_b593.Value - A805)); //Natural Log base(e)
                return _c805.Value;
            }
        }
        private double? _c806;
        public double C806
        {
            get
            {
                //Debug.WriteLine("C806");
                if (_c806 == null)
                    _c806 = Math.Log(_b596.Value * A806 / (_b593.Value - A806)); //Natural Log base(e)
                return _c806.Value;
            }
        }
        private double? _c807;
        public double C807
        {
            get
            {
                //Debug.WriteLine("C807");
                if (_c807 == null)
                    _c807 = Math.Log(_b596.Value * A807 / (_b593.Value - A807)); //Natural Log base(e)
                return _c807.Value;
            }
        }

        private double? _d607;
        public double D607
        {
            get
            {
                //Debug.WriteLine("D607");
                if (_d607 == null)
                    _d607 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C607));
                return _d607.Value;
            }
        }
        private double? _d608;
        public double D608
        {
            get
            {
                //Debug.WriteLine("D608");
                if (_d608 == null)
                    _d608 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C608));
                return _d608.Value;
            }
        }
        private double? _d609;
        public double D609
        {
            get
            {
                //Debug.WriteLine("D609");
                if (_d609 == null)
                    _d609 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C609));
                return _d609.Value;
            }
        }
        private double? _d610;
        public double D610
        {
            get
            {
                //Debug.WriteLine("D610");
                if (_d610 == null)
                    _d610 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C610));
                return _d610.Value;
            }
        }
        private double? _d611;
        public double D611
        {
            get
            {
                //Debug.WriteLine("D611");
                if (_d611 == null)
                    _d611 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C611));
                return _d611.Value;
            }
        }
        private double? _d612;
        public double D612
        {
            get
            {
                //Debug.WriteLine("D612");
                if (_d612 == null)
                    _d612 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C612));
                return _d612.Value;
            }
        }
        private double? _d613;
        public double D613
        {
            get
            {
                //Debug.WriteLine("D613");
                if (_d613 == null)
                    _d613 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C613));
                return _d613.Value;
            }
        }
        private double? _d614;
        public double D614
        {
            get
            {
                //Debug.WriteLine("D614");
                if (_d614 == null)
                    _d614 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C614));
                return _d614.Value;
            }
        }
        private double? _d615;
        public double D615
        {
            get
            {
                //Debug.WriteLine("D615");
                if (_d615 == null)
                    _d615 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C615));
                return _d615.Value;
            }
        }
        private double? _d616;
        public double D616
        {
            get
            {
                //Debug.WriteLine("D616");
                if (_d616 == null)
                    _d616 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C616));
                return _d616.Value;
            }
        }
        private double? _d617;
        public double D617
        {
            get
            {
                //Debug.WriteLine("D617");
                if (_d617 == null)
                    _d617 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C617));
                return _d617.Value;
            }
        }
        private double? _d618;
        public double D618
        {
            get
            {
                //Debug.WriteLine("D618");
                if (_d618 == null)
                    _d618 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C618));
                return _d618.Value;
            }
        }
        private double? _d619;
        public double D619
        {
            get
            {
                //Debug.WriteLine("D619");
                if (_d619 == null)
                    _d619 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C619));
                return _d619.Value;
            }
        }
        private double? _d620;
        public double D620
        {
            get
            {
                //Debug.WriteLine("D620");
                if (_d620 == null)
                    _d620 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C620));
                return _d620.Value;
            }
        }
        private double? _d621;
        public double D621
        {
            get
            {
                //Debug.WriteLine("D621");
                if (_d621 == null)
                    _d621 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C621));
                return _d621.Value;
            }
        }
        private double? _d622;
        public double D622
        {
            get
            {
                //Debug.WriteLine("D622");
                if (_d622 == null)
                    _d622 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C622));
                return _d622.Value;
            }
        }
        private double? _d623;
        public double D623
        {
            get
            {
                //Debug.WriteLine("D623");
                if (_d623 == null)
                    _d623 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C623));
                return _d623.Value;
            }
        }
        private double? _d624;
        public double D624
        {
            get
            {
                //Debug.WriteLine("D624");
                if (_d624 == null)
                    _d624 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C624));
                return _d624.Value;
            }
        }
        private double? _d625;
        public double D625
        {
            get
            {
                //Debug.WriteLine("D625");
                if (_d625 == null)
                    _d625 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C625));
                return _d625.Value;
            }
        }
        private double? _d626;
        public double D626
        {
            get
            {
                //Debug.WriteLine("D626");
                if (_d626 == null)
                    _d626 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C626));
                return _d626.Value;
            }
        }
        private double? _d627;
        public double D627
        {
            get
            {
                //Debug.WriteLine("D627");
                if (_d627 == null)
                    _d627 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C627));
                return _d627.Value;
            }
        }
        private double? _d628;
        public double D628
        {
            get
            {
                //Debug.WriteLine("D628");
                if (_d628 == null)
                    _d628 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C628));
                return _d628.Value;
            }
        }
        private double? _d629;
        public double D629
        {
            get
            {
                //Debug.WriteLine("D629");
                if (_d629 == null)
                    _d629 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C629));
                return _d629.Value;
            }
        }
        private double? _d630;
        public double D630
        {
            get
            {
                //Debug.WriteLine("D630");
                if (_d630 == null)
                    _d630 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C630));
                return _d630.Value;
            }
        }
        private double? _d631;
        public double D631
        {
            get
            {
                //Debug.WriteLine("D631");
                if (_d631 == null)
                    _d631 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C631));
                return _d631.Value;
            }
        }
        private double? _d632;
        public double D632
        {
            get
            {
                //Debug.WriteLine("D632");
                if (_d632 == null)
                    _d632 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C632));
                return _d632.Value;
            }
        }
        private double? _d633;
        public double D633
        {
            get
            {
                //Debug.WriteLine("D633");
                if (_d633 == null)
                    _d633 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C633));
                return _d633.Value;
            }
        }
        private double? _d634;
        public double D634
        {
            get
            {
                //Debug.WriteLine("D634");
                if (_d634 == null)
                    _d634 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C634));
                return _d634.Value;
            }
        }
        private double? _d635;
        public double D635
        {
            get
            {
                //Debug.WriteLine("D635");
                if (_d635 == null)
                    _d635 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C635));
                return _d635.Value;
            }
        }
        private double? _d636;
        public double D636
        {
            get
            {
                //Debug.WriteLine("D636");
                if (_d636 == null)
                    _d636 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C636));
                return _d636.Value;
            }
        }
        private double? _d637;
        public double D637
        {
            get
            {
                //Debug.WriteLine("D637");
                if (_d637 == null)
                    _d637 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C637));
                return _d637.Value;
            }
        }
        private double? _d638;
        public double D638
        {
            get
            {
                //Debug.WriteLine("D638");
                if (_d638 == null)
                    _d638 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C638));
                return _d638.Value;
            }
        }
        private double? _d639;
        public double D639
        {
            get
            {
                //Debug.WriteLine("D639");
                if (_d639 == null)
                    _d639 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C639));
                return _d639.Value;
            }
        }
        private double? _d640;
        public double D640
        {
            get
            {
                //Debug.WriteLine("D640");
                if (_d640 == null)
                    _d640 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C640));
                return _d640.Value;
            }
        }
        private double? _d641;
        public double D641
        {
            get
            {
                //Debug.WriteLine("D641");
                if (_d641 == null)
                    _d641 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C641));
                return _d641.Value;
            }
        }
        private double? _d642;
        public double D642
        {
            get
            {
                //Debug.WriteLine("D642");
                if (_d642 == null)
                    _d642 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C642));
                return _d642.Value;
            }
        }
        private double? _d643;
        public double D643
        {
            get
            {
                //Debug.WriteLine("D643");
                if (_d643 == null)
                    _d643 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C643));
                return _d643.Value;
            }
        }
        private double? _d644;
        public double D644
        {
            get
            {
                //Debug.WriteLine("D644");
                if (_d644 == null)
                    _d644 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C644));
                return _d644.Value;
            }
        }
        private double? _d645;
        public double D645
        {
            get
            {
                //Debug.WriteLine("D645");
                if (_d645 == null)
                    _d645 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C645));
                return _d645.Value;
            }
        }
        private double? _d646;
        public double D646
        {
            get
            {
                //Debug.WriteLine("D646");
                if (_d646 == null)
                    _d646 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C646));
                return _d646.Value;
            }
        }
        private double? _d647;
        public double D647
        {
            get
            {
                //Debug.WriteLine("D647");
                if (_d647 == null)
                    _d647 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C647));
                return _d647.Value;
            }
        }
        private double? _d648;
        public double D648
        {
            get
            {
                //Debug.WriteLine("D648");
                if (_d648 == null)
                    _d648 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C648));
                return _d648.Value;
            }
        }
        private double? _d649;
        public double D649
        {
            get
            {
                //Debug.WriteLine("D649");
                if (_d649 == null)
                    _d649 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C649));
                return _d649.Value;
            }
        }
        private double? _d650;
        public double D650
        {
            get
            {
                //Debug.WriteLine("D650");
                if (_d650 == null)
                    _d650 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C650));
                return _d650.Value;
            }
        }
        private double? _d651;
        public double D651
        {
            get
            {
                //Debug.WriteLine("D651");
                if (_d651 == null)
                    _d651 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C651));
                return _d651.Value;
            }
        }
        private double? _d652;
        public double D652
        {
            get
            {
                //Debug.WriteLine("D652");
                if (_d652 == null)
                    _d652 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C652));
                return _d652.Value;
            }
        }
        private double? _d653;
        public double D653
        {
            get
            {
                //Debug.WriteLine("D653");
                if (_d653 == null)
                    _d653 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C653));
                return _d653.Value;
            }
        }
        private double? _d654;
        public double D654
        {
            get
            {
                //Debug.WriteLine("D654");
                if (_d654 == null)
                    _d654 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C654));
                return _d654.Value;
            }
        }
        private double? _d655;
        public double D655
        {
            get
            {
                //Debug.WriteLine("D655");
                if (_d655 == null)
                    _d655 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C655));
                return _d655.Value;
            }
        }
        private double? _d656;
        public double D656
        {
            get
            {
                //Debug.WriteLine("D656");
                if (_d656 == null)
                    _d656 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C656));
                return _d656.Value;
            }
        }
        private double? _d657;
        public double D657
        {
            get
            {
                //Debug.WriteLine("D657");
                if (_d657 == null)
                    _d657 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C657));
                return _d657.Value;
            }
        }
        private double? _d658;
        public double D658
        {
            get
            {
                //Debug.WriteLine("D658");
                if (_d658 == null)
                    _d658 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C658));
                return _d658.Value;
            }
        }
        private double? _d659;
        public double D659
        {
            get
            {
                //Debug.WriteLine("D659");
                if (_d659 == null)
                    _d659 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C659));
                return _d659.Value;
            }
        }
        private double? _d660;
        public double D660
        {
            get
            {
                //Debug.WriteLine("D660");
                if (_d660 == null)
                    _d660 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C660));
                return _d660.Value;
            }
        }
        private double? _d661;
        public double D661
        {
            get
            {
                //Debug.WriteLine("D661");
                if (_d661 == null)
                    _d661 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C661));
                return _d661.Value;
            }
        }
        private double? _d662;
        public double D662
        {
            get
            {
                //Debug.WriteLine("D662");
                if (_d662 == null)
                    _d662 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C662));
                return _d662.Value;
            }
        }
        private double? _d663;
        public double D663
        {
            get
            {
                //Debug.WriteLine("D663");
                if (_d663 == null)
                    _d663 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C663));
                return _d663.Value;
            }
        }
        private double? _d664;
        public double D664
        {
            get
            {
                //Debug.WriteLine("D664");
                if (_d664 == null)
                    _d664 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C664));
                return _d664.Value;
            }
        }
        private double? _d665;
        public double D665
        {
            get
            {
                //Debug.WriteLine("D665");
                if (_d665 == null)
                    _d665 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C665));
                return _d665.Value;
            }
        }
        private double? _d666;
        public double D666
        {
            get
            {
                //Debug.WriteLine("D666");
                if (_d666 == null)
                    _d666 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C666));
                return _d666.Value;
            }
        }
        private double? _d667;
        public double D667
        {
            get
            {
                //Debug.WriteLine("D667");
                if (_d667 == null)
                    _d667 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C667));
                return _d667.Value;
            }
        }
        private double? _d668;
        public double D668
        {
            get
            {
                //Debug.WriteLine("D668");
                if (_d668 == null)
                    _d668 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C668));
                return _d668.Value;
            }
        }
        private double? _d669;
        public double D669
        {
            get
            {
                //Debug.WriteLine("D669");
                if (_d669 == null)
                    _d669 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C669));
                return _d669.Value;
            }
        }
        private double? _d670;
        public double D670
        {
            get
            {
                //Debug.WriteLine("D670");
                if (_d670 == null)
                    _d670 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C670));
                return _d670.Value;
            }
        }
        private double? _d671;
        public double D671
        {
            get
            {
                //Debug.WriteLine("D671");
                if (_d671 == null)
                    _d671 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C671));
                return _d671.Value;
            }
        }
        private double? _d672;
        public double D672
        {
            get
            {
                //Debug.WriteLine("D672");
                if (_d672 == null)
                    _d672 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C672));
                return _d672.Value;
            }
        }
        private double? _d673;
        public double D673
        {
            get
            {
                //Debug.WriteLine("D673");
                if (_d673 == null)
                    _d673 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C673));
                return _d673.Value;
            }
        }
        private double? _d674;
        public double D674
        {
            get
            {
                //Debug.WriteLine("D674");
                if (_d674 == null)
                    _d674 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C674));
                return _d674.Value;
            }
        }
        private double? _d675;
        public double D675
        {
            get
            {
                //Debug.WriteLine("D675");
                if (_d675 == null)
                    _d675 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C675));
                return _d675.Value;
            }
        }
        private double? _d676;
        public double D676
        {
            get
            {
                //Debug.WriteLine("D676");
                if (_d676 == null)
                    _d676 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C676));
                return _d676.Value;
            }
        }
        private double? _d677;
        public double D677
        {
            get
            {
                //Debug.WriteLine("D677");
                if (_d677 == null)
                    _d677 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C677));
                return _d677.Value;
            }
        }
        private double? _d678;
        public double D678
        {
            get
            {
                //Debug.WriteLine("D678");
                if (_d678 == null)
                    _d678 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C678));
                return _d678.Value;
            }
        }
        private double? _d679;
        public double D679
        {
            get
            {
                //Debug.WriteLine("D679");
                if (_d679 == null)
                    _d679 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C679));
                return _d679.Value;
            }
        }
        private double? _d680;
        public double D680
        {
            get
            {
                //Debug.WriteLine("D680");
                if (_d680 == null)
                    _d680 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C680));
                return _d680.Value;
            }
        }
        private double? _d681;
        public double D681
        {
            get
            {
                //Debug.WriteLine("D681");
                if (_d681 == null)
                    _d681 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C681));
                return _d681.Value;
            }
        }
        private double? _d682;
        public double D682
        {
            get
            {
                //Debug.WriteLine("D682");
                if (_d682 == null)
                    _d682 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C682));
                return _d682.Value;
            }
        }
        private double? _d683;
        public double D683
        {
            get
            {
                //Debug.WriteLine("D683");
                if (_d683 == null)
                    _d683 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C683));
                return _d683.Value;
            }
        }
        private double? _d684;
        public double D684
        {
            get
            {
                //Debug.WriteLine("D684");
                if (_d684 == null)
                    _d684 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C684));
                return _d684.Value;
            }
        }
        private double? _d685;
        public double D685
        {
            get
            {
                //Debug.WriteLine("D685");
                if (_d685 == null)
                    _d685 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C685));
                return _d685.Value;
            }
        }
        private double? _d686;
        public double D686
        {
            get
            {
                //Debug.WriteLine("D686");
                if (_d686 == null)
                    _d686 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C686));
                return _d686.Value;
            }
        }
        private double? _d687;
        public double D687
        {
            get
            {
                //Debug.WriteLine("D687");
                if (_d687 == null)
                    _d687 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C687));
                return _d687.Value;
            }
        }
        private double? _d688;
        public double D688
        {
            get
            {
                //Debug.WriteLine("D688");
                if (_d688 == null)
                    _d688 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C688));
                return _d688.Value;
            }
        }
        private double? _d689;
        public double D689
        {
            get
            {
                //Debug.WriteLine("D689");
                if (_d689 == null)
                    _d689 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C689));
                return _d689.Value;
            }
        }
        private double? _d690;
        public double D690
        {
            get
            {
                //Debug.WriteLine("D690");
                if (_d690 == null)
                    _d690 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C690));
                return _d690.Value;
            }
        }
        private double? _d691;
        public double D691
        {
            get
            {
                //Debug.WriteLine("D691");
                if (_d691 == null)
                    _d691 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C691));
                return _d691.Value;
            }
        }
        private double? _d692;
        public double D692
        {
            get
            {
                //Debug.WriteLine("D692");
                if (_d692 == null)
                    _d692 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C692));
                return _d692.Value;
            }
        }
        private double? _d693;
        public double D693
        {
            get
            {
                //Debug.WriteLine("D693");
                if (_d693 == null)
                    _d693 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C693));
                return _d693.Value;
            }
        }
        private double? _d694;
        public double D694
        {
            get
            {
                //Debug.WriteLine("D694");
                if (_d694 == null)
                    _d694 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C694));
                return _d694.Value;
            }
        }
        private double? _d695;
        public double D695
        {
            get
            {
                //Debug.WriteLine("D695");
                if (_d695 == null)
                    _d695 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C695));
                return _d695.Value;
            }
        }
        private double? _d696;
        public double D696
        {
            get
            {
                //Debug.WriteLine("D696");
                if (_d696 == null)
                    _d696 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C696));
                return _d696.Value;
            }
        }
        private double? _d697;
        public double D697
        {
            get
            {
                //Debug.WriteLine("D697");
                if (_d697 == null)
                    _d697 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C697));
                return _d697.Value;
            }
        }
        private double? _d698;
        public double D698
        {
            get
            {
                //Debug.WriteLine("D698");
                if (_d698 == null)
                    _d698 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C698));
                return _d698.Value;
            }
        }
        private double? _d699;
        public double D699
        {
            get
            {
                //Debug.WriteLine("D699");
                if (_d699 == null)
                    _d699 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C699));
                return _d699.Value;
            }
        }
        private double? _d700;
        public double D700
        {
            get
            {
                //Debug.WriteLine("D700");
                if (_d700 == null)
                    _d700 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C700));
                return _d700.Value;
            }
        }
        private double? _d701;
        public double D701
        {
            get
            {
                //Debug.WriteLine("D701");
                if (_d701 == null)
                    _d701 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C701));
                return _d701.Value;
            }
        }
        private double? _d702;
        public double D702
        {
            get
            {
                //Debug.WriteLine("D702");
                if (_d702 == null)
                    _d702 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C702));
                return _d702.Value;
            }
        }
        private double? _d703;
        public double D703
        {
            get
            {
                //Debug.WriteLine("D703");
                if (_d703 == null)
                    _d703 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C703));
                return _d703.Value;
            }
        }
        private double? _d704;
        public double D704
        {
            get
            {
                //Debug.WriteLine("D704");
                if (_d704 == null)
                    _d704 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C704));
                return _d704.Value;
            }
        }
        private double? _d705;
        public double D705
        {
            get
            {
                //Debug.WriteLine("D705");
                if (_d705 == null)
                    _d705 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C705));
                return _d705.Value;
            }
        }
        private double? _d706;
        public double D706
        {
            get
            {
                //Debug.WriteLine("D706");
                if (_d706 == null)
                    _d706 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C706));
                return _d706.Value;
            }
        }
        private double? _d707;
        public double D707
        {
            get
            {
                //Debug.WriteLine("D707");
                if (_d707 == null)
                    _d707 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C707));
                return _d707.Value;
            }
        }
        private double? _d708;
        public double D708
        {
            get
            {
                //Debug.WriteLine("D708");
                if (_d708 == null)
                    _d708 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C708));
                return _d708.Value;
            }
        }
        private double? _d709;
        public double D709
        {
            get
            {
                //Debug.WriteLine("D709");
                if (_d709 == null)
                    _d709 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C709));
                return _d709.Value;
            }
        }
        private double? _d710;
        public double D710
        {
            get
            {
                //Debug.WriteLine("D710");
                if (_d710 == null)
                    _d710 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C710));
                return _d710.Value;
            }
        }
        private double? _d711;
        public double D711
        {
            get
            {
                //Debug.WriteLine("D711");
                if (_d711 == null)
                    _d711 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C711));
                return _d711.Value;
            }
        }
        private double? _d712;
        public double D712
        {
            get
            {
                //Debug.WriteLine("D712");
                if (_d712 == null)
                    _d712 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C712));
                return _d712.Value;
            }
        }
        private double? _d713;
        public double D713
        {
            get
            {
                //Debug.WriteLine("D713");
                if (_d713 == null)
                    _d713 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C713));
                return _d713.Value;
            }
        }
        private double? _d714;
        public double D714
        {
            get
            {
                //Debug.WriteLine("D714");
                if (_d714 == null)
                    _d714 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C714));
                return _d714.Value;
            }
        }
        private double? _d715;
        public double D715
        {
            get
            {
                //Debug.WriteLine("D715");
                if (_d715 == null)
                    _d715 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C715));
                return _d715.Value;
            }
        }
        private double? _d716;
        public double D716
        {
            get
            {
                //Debug.WriteLine("D716");
                if (_d716 == null)
                    _d716 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C716));
                return _d716.Value;
            }
        }
        private double? _d717;
        public double D717
        {
            get
            {
                //Debug.WriteLine("D717");
                if (_d717 == null)
                    _d717 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C717));
                return _d717.Value;
            }
        }
        private double? _d718;
        public double D718
        {
            get
            {
                //Debug.WriteLine("D718");
                if (_d718 == null)
                    _d718 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C718));
                return _d718.Value;
            }
        }
        private double? _d719;
        public double D719
        {
            get
            {
                //Debug.WriteLine("D719");
                if (_d719 == null)
                    _d719 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C719));
                return _d719.Value;
            }
        }
        private double? _d720;
        public double D720
        {
            get
            {
                //Debug.WriteLine("D720");
                if (_d720 == null)
                    _d720 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C720));
                return _d720.Value;
            }
        }
        private double? _d721;
        public double D721
        {
            get
            {
                //Debug.WriteLine("D721");
                if (_d721 == null)
                    _d721 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C721));
                return _d721.Value;
            }
        }
        private double? _d722;
        public double D722
        {
            get
            {
                //Debug.WriteLine("D722");
                if (_d722 == null)
                    _d722 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C722));
                return _d722.Value;
            }
        }
        private double? _d723;
        public double D723
        {
            get
            {
                //Debug.WriteLine("D723");
                if (_d723 == null)
                    _d723 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C723));
                return _d723.Value;
            }
        }
        private double? _d724;
        public double D724
        {
            get
            {
                //Debug.WriteLine("D724");
                if (_d724 == null)
                    _d724 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C724));
                return _d724.Value;
            }
        }
        private double? _d725;
        public double D725
        {
            get
            {
                //Debug.WriteLine("D725");
                if (_d725 == null)
                    _d725 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C725));
                return _d725.Value;
            }
        }
        private double? _d726;
        public double D726
        {
            get
            {
                //Debug.WriteLine("D726");
                if (_d726 == null)
                    _d726 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C726));
                return _d726.Value;
            }
        }
        private double? _d727;
        public double D727
        {
            get
            {
                //Debug.WriteLine("D727");
                if (_d727 == null)
                    _d727 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C727));
                return _d727.Value;
            }
        }
        private double? _d728;
        public double D728
        {
            get
            {
                //Debug.WriteLine("D728");
                if (_d728 == null)
                    _d728 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C728));
                return _d728.Value;
            }
        }
        private double? _d729;
        public double D729
        {
            get
            {
                //Debug.WriteLine("D729");
                if (_d729 == null)
                    _d729 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C729));
                return _d729.Value;
            }
        }
        private double? _d730;
        public double D730
        {
            get
            {
                //Debug.WriteLine("D730");
                if (_d730 == null)
                    _d730 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C730));
                return _d730.Value;
            }
        }
        private double? _d731;
        public double D731
        {
            get
            {
                //Debug.WriteLine("D731");
                if (_d731 == null)
                    _d731 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C731));
                return _d731.Value;
            }
        }
        private double? _d732;
        public double D732
        {
            get
            {
                //Debug.WriteLine("D732");
                if (_d732 == null)
                    _d732 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C732));
                return _d732.Value;
            }
        }
        private double? _d733;
        public double D733
        {
            get
            {
                //Debug.WriteLine("D733");
                if (_d733 == null)
                    _d733 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C733));
                return _d733.Value;
            }
        }
        private double? _d734;
        public double D734
        {
            get
            {
                //Debug.WriteLine("D734");
                if (_d734 == null)
                    _d734 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C734));
                return _d734.Value;
            }
        }
        private double? _d735;
        public double D735
        {
            get
            {
                //Debug.WriteLine("D735");
                if (_d735 == null)
                    _d735 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C735));
                return _d735.Value;
            }
        }
        private double? _d736;
        public double D736
        {
            get
            {
                //Debug.WriteLine("D736");
                if (_d736 == null)
                    _d736 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C736));
                return _d736.Value;
            }
        }
        private double? _d737;
        public double D737
        {
            get
            {
                //Debug.WriteLine("D737");
                if (_d737 == null)
                    _d737 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C737));
                return _d737.Value;
            }
        }
        private double? _d738;
        public double D738
        {
            get
            {
                //Debug.WriteLine("D738");
                if (_d738 == null)
                    _d738 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C738));
                return _d738.Value;
            }
        }
        private double? _d739;
        public double D739
        {
            get
            {
                //Debug.WriteLine("D739");
                if (_d739 == null)
                    _d739 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C739));
                return _d739.Value;
            }
        }
        private double? _d740;
        public double D740
        {
            get
            {
                //Debug.WriteLine("D740");
                if (_d740 == null)
                    _d740 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C740));
                return _d740.Value;
            }
        }
        private double? _d741;
        public double D741
        {
            get
            {
                //Debug.WriteLine("D741");
                if (_d741 == null)
                    _d741 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C741));
                return _d741.Value;
            }
        }
        private double? _d742;
        public double D742
        {
            get
            {
                //Debug.WriteLine("D742");
                if (_d742 == null)
                    _d742 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C742));
                return _d742.Value;
            }
        }
        private double? _d743;
        public double D743
        {
            get
            {
                //Debug.WriteLine("D743");
                if (_d743 == null)
                    _d743 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C743));
                return _d743.Value;
            }
        }
        private double? _d744;
        public double D744
        {
            get
            {
                //Debug.WriteLine("D744");
                if (_d744 == null)
                    _d744 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C744));
                return _d744.Value;
            }
        }
        private double? _d745;
        public double D745
        {
            get
            {
                //Debug.WriteLine("D745");
                if (_d745 == null)
                    _d745 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C745));
                return _d745.Value;
            }
        }
        private double? _d746;
        public double D746
        {
            get
            {
                //Debug.WriteLine("D746");
                if (_d746 == null)
                    _d746 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C746));
                return _d746.Value;
            }
        }
        private double? _d747;
        public double D747
        {
            get
            {
                //Debug.WriteLine("D747");
                if (_d747 == null)
                    _d747 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C747));
                return _d747.Value;
            }
        }
        private double? _d748;
        public double D748
        {
            get
            {
                //Debug.WriteLine("D748");
                if (_d748 == null)
                    _d748 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C748));
                return _d748.Value;
            }
        }
        private double? _d749;
        public double D749
        {
            get
            {
                //Debug.WriteLine("D749");
                if (_d749 == null)
                    _d749 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C749));
                return _d749.Value;
            }
        }
        private double? _d750;
        public double D750
        {
            get
            {
                //Debug.WriteLine("D750");
                if (_d750 == null)
                    _d750 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C750));
                return _d750.Value;
            }
        }
        private double? _d751;
        public double D751
        {
            get
            {
                //Debug.WriteLine("D751");
                if (_d751 == null)
                    _d751 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C751));
                return _d751.Value;
            }
        }
        private double? _d752;
        public double D752
        {
            get
            {
                //Debug.WriteLine("D752");
                if (_d752 == null)
                    _d752 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C752));
                return _d752.Value;
            }
        }
        private double? _d753;
        public double D753
        {
            get
            {
                //Debug.WriteLine("D753");
                if (_d753 == null)
                    _d753 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C753));
                return _d753.Value;
            }
        }
        private double? _d754;
        public double D754
        {
            get
            {
                //Debug.WriteLine("D754");
                if (_d754 == null)
                    _d754 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C754));
                return _d754.Value;
            }
        }
        private double? _d755;
        public double D755
        {
            get
            {
                //Debug.WriteLine("D755");
                if (_d755 == null)
                    _d755 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C755));
                return _d755.Value;
            }
        }
        private double? _d756;
        public double D756
        {
            get
            {
                //Debug.WriteLine("D756");
                if (_d756 == null)
                    _d756 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C756));
                return _d756.Value;
            }
        }
        private double? _d757;
        public double D757
        {
            get
            {
                //Debug.WriteLine("D757");
                if (_d757 == null)
                    _d757 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C757));
                return _d757.Value;
            }
        }
        private double? _d758;
        public double D758
        {
            get
            {
                //Debug.WriteLine("D758");
                if (_d758 == null)
                    _d758 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C758));
                return _d758.Value;
            }
        }
        private double? _d759;
        public double D759
        {
            get
            {
                //Debug.WriteLine("D759");
                if (_d759 == null)
                    _d759 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C759));
                return _d759.Value;
            }
        }
        private double? _d760;
        public double D760
        {
            get
            {
                //Debug.WriteLine("D760");
                if (_d760 == null)
                    _d760 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C760));
                return _d760.Value;
            }
        }
        private double? _d761;
        public double D761
        {
            get
            {
                //Debug.WriteLine("D761");
                if (_d761 == null)
                    _d761 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C761));
                return _d761.Value;
            }
        }
        private double? _d762;
        public double D762
        {
            get
            {
                //Debug.WriteLine("D762");
                if (_d762 == null)
                    _d762 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C762));
                return _d762.Value;
            }
        }
        private double? _d763;
        public double D763
        {
            get
            {
                //Debug.WriteLine("D763");
                if (_d763 == null)
                    _d763 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C763));
                return _d763.Value;
            }
        }
        private double? _d764;
        public double D764
        {
            get
            {
                //Debug.WriteLine("D764");
                if (_d764 == null)
                    _d764 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C764));
                return _d764.Value;
            }
        }
        private double? _d765;
        public double D765
        {
            get
            {
                //Debug.WriteLine("D765");
                if (_d765 == null)
                    _d765 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C765));
                return _d765.Value;
            }
        }
        private double? _d766;
        public double D766
        {
            get
            {
                //Debug.WriteLine("D766");
                if (_d766 == null)
                    _d766 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C766));
                return _d766.Value;
            }
        }
        private double? _d767;
        public double D767
        {
            get
            {
                //Debug.WriteLine("D767");
                if (_d767 == null)
                    _d767 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C767));
                return _d767.Value;
            }
        }
        private double? _d768;
        public double D768
        {
            get
            {
                //Debug.WriteLine("D768");
                if (_d768 == null)
                    _d768 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C768));
                return _d768.Value;
            }
        }
        private double? _d769;
        public double D769
        {
            get
            {
                //Debug.WriteLine("D769");
                if (_d769 == null)
                    _d769 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C769));
                return _d769.Value;
            }
        }
        private double? _d770;
        public double D770
        {
            get
            {
                //Debug.WriteLine("D770");
                if (_d770 == null)
                    _d770 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C770));
                return _d770.Value;
            }
        }
        private double? _d771;
        public double D771
        {
            get
            {
                //Debug.WriteLine("D771");
                if (_d771 == null)
                    _d771 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C771));
                return _d771.Value;
            }
        }
        private double? _d772;
        public double D772
        {
            get
            {
                //Debug.WriteLine("D772");
                if (_d772 == null)
                    _d772 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C772));
                return _d772.Value;
            }
        }
        private double? _d773;
        public double D773
        {
            get
            {
                //Debug.WriteLine("D773");
                if (_d773 == null)
                    _d773 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C773));
                return _d773.Value;
            }
        }
        private double? _d774;
        public double D774
        {
            get
            {
                //Debug.WriteLine("D774");
                if (_d774 == null)
                    _d774 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C774));
                return _d774.Value;
            }
        }
        private double? _d775;
        public double D775
        {
            get
            {
                //Debug.WriteLine("D775");
                if (_d775 == null)
                    _d775 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C775));
                return _d775.Value;
            }
        }
        private double? _d776;
        public double D776
        {
            get
            {
                //Debug.WriteLine("D776");
                if (_d776 == null)
                    _d776 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C776));
                return _d776.Value;
            }
        }
        private double? _d777;
        public double D777
        {
            get
            {
                //Debug.WriteLine("D777");
                if (_d777 == null)
                    _d777 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C777));
                return _d777.Value;
            }
        }
        private double? _d778;
        public double D778
        {
            get
            {
                //Debug.WriteLine("D778");
                if (_d778 == null)
                    _d778 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C778));
                return _d778.Value;
            }
        }
        private double? _d779;
        public double D779
        {
            get
            {
                //Debug.WriteLine("D779");
                if (_d779 == null)
                    _d779 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C779));
                return _d779.Value;
            }
        }
        private double? _d780;
        public double D780
        {
            get
            {
                //Debug.WriteLine("D780");
                if (_d780 == null)
                    _d780 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C780));
                return _d780.Value;
            }
        }
        private double? _d781;
        public double D781
        {
            get
            {
                //Debug.WriteLine("D781");
                if (_d781 == null)
                    _d781 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C781));
                return _d781.Value;
            }
        }
        private double? _d782;
        public double D782
        {
            get
            {
                //Debug.WriteLine("D782");
                if (_d782 == null)
                    _d782 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C782));
                return _d782.Value;
            }
        }
        private double? _d783;
        public double D783
        {
            get
            {
                //Debug.WriteLine("D783");
                if (_d783 == null)
                    _d783 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C783));
                return _d783.Value;
            }
        }
        private double? _d784;
        public double D784
        {
            get
            {
                //Debug.WriteLine("D784");
                if (_d784 == null)
                    _d784 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C784));
                return _d784.Value;
            }
        }
        private double? _d785;
        public double D785
        {
            get
            {
                //Debug.WriteLine("D785");
                if (_d785 == null)
                    _d785 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C785));
                return _d785.Value;
            }
        }
        private double? _d786;
        public double D786
        {
            get
            {
                //Debug.WriteLine("D786");
                if (_d786 == null)
                    _d786 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C786));
                return _d786.Value;
            }
        }
        private double? _d787;
        public double D787
        {
            get
            {
                //Debug.WriteLine("D787");
                if (_d787 == null)
                    _d787 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C787));
                return _d787.Value;
            }
        }
        private double? _d788;
        public double D788
        {
            get
            {
                //Debug.WriteLine("D788");
                if (_d788 == null)
                    _d788 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C788));
                return _d788.Value;
            }
        }
        private double? _d789;
        public double D789
        {
            get
            {
                //Debug.WriteLine("D789");
                if (_d789 == null)
                    _d789 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C789));
                return _d789.Value;
            }
        }
        private double? _d790;
        public double D790
        {
            get
            {
                //Debug.WriteLine("D790");
                if (_d790 == null)
                    _d790 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C790));
                return _d790.Value;
            }
        }
        private double? _d791;
        public double D791
        {
            get
            {
                //Debug.WriteLine("D791");
                if (_d791 == null)
                    _d791 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C791));
                return _d791.Value;
            }
        }
        private double? _d792;
        public double D792
        {
            get
            {
                //Debug.WriteLine("D792");
                if (_d792 == null)
                    _d792 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C792));
                return _d792.Value;
            }
        }
        private double? _d793;
        public double D793
        {
            get
            {
                //Debug.WriteLine("D793");
                if (_d793 == null)
                    _d793 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C793));
                return _d793.Value;
            }
        }
        private double? _d794;
        public double D794
        {
            get
            {
                //Debug.WriteLine("D794");
                if (_d794 == null)
                    _d794 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C794));
                return _d794.Value;
            }
        }
        private double? _d795;
        public double D795
        {
            get
            {
                //Debug.WriteLine("D795");
                if (_d795 == null)
                    _d795 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C795));
                return _d795.Value;
            }
        }
        private double? _d796;
        public double D796
        {
            get
            {
                //Debug.WriteLine("D796");
                if (_d796 == null)
                    _d796 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C796));
                return _d796.Value;
            }
        }
        private double? _d797;
        public double D797
        {
            get
            {
                //Debug.WriteLine("D797");
                if (_d797 == null)
                    _d797 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C797));
                return _d797.Value;
            }
        }
        private double? _d798;
        public double D798
        {
            get
            {
                //Debug.WriteLine("D798");
                if (_d798 == null)
                    _d798 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C798));
                return _d798.Value;
            }
        }
        private double? _d799;
        public double D799
        {
            get
            {
                //Debug.WriteLine("D799");
                if (_d799 == null)
                    _d799 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C799));
                return _d799.Value;
            }
        }
        private double? _d800;
        public double D800
        {
            get
            {
                //Debug.WriteLine("D800");
                if (_d800 == null)
                    _d800 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C800));
                return _d800.Value;
            }
        }
        private double? _d801;
        public double D801
        {
            get
            {
                //Debug.WriteLine("D801");
                if (_d801 == null)
                    _d801 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C801));
                return _d801.Value;
            }
        }
        private double? _d802;
        public double D802
        {
            get
            {
                //Debug.WriteLine("D802");
                if (_d802 == null)
                    _d802 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C802));
                return _d802.Value;
            }
        }
        private double? _d803;
        public double D803
        {
            get
            {
                //Debug.WriteLine("D803");
                if (_d803 == null)
                    _d803 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C803));
                return _d803.Value;
            }
        }
        private double? _d804;
        public double D804
        {
            get
            {
                //Debug.WriteLine("D804");
                if (_d804 == null)
                    _d804 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C804));
                return _d804.Value;
            }
        }
        private double? _d805;
        public double D805
        {
            get
            {
                //Debug.WriteLine("D805");
                if (_d805 == null)
                    _d805 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C805));
                return _d805.Value;
            }
        }
        private double? _d806;
        public double D806
        {
            get
            {
                //Debug.WriteLine("D806");
                if (_d806 == null)
                    _d806 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C806));
                return _d806.Value;
            }
        }
        private double? _d807;
        public double D807
        {
            get
            {
                //Debug.WriteLine("D807");
                if (_d807 == null)
                    _d807 = 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C807));
                return _d807.Value;
            }
        }

        public double E607 { get; set; }
        private double? _e608;
        public double E608
        {
            get
            {
                //Debug.WriteLine("E608");
                if (_e608 == null)
                    _e608 = D608 - D607;
                return _e608.Value;
            }
        }
        private double? _e609;
        public double E609
        {
            get
            {
                //Debug.WriteLine("E609");
                if (_e609 == null)
                    _e609 = D609 - D608;
                return _e609.Value;
            }
        }
        private double? _e610;
        public double E610
        {
            get
            {
                //Debug.WriteLine("E610");
                if (_e610 == null)
                    _e610 = D610 - D609;
                return _e610.Value;
            }
        }
        private double? _e611;
        public double E611
        {
            get
            {
                //Debug.WriteLine("E611");
                if (_e611 == null)
                    _e611 = D611 - D610;
                return _e611.Value;
            }
        }
        private double? _e612;
        public double E612
        {
            get
            {
                //Debug.WriteLine("E612");
                if (_e612 == null)
                    _e612 = D612 - D611;
                return _e612.Value;
            }
        }
        private double? _e613;
        public double E613
        {
            get
            {
                //Debug.WriteLine("E613");
                if (_e613 == null)
                    _e613 = D613 - D612;
                return _e613.Value;
            }
        }
        private double? _e614;
        public double E614
        {
            get
            {
                //Debug.WriteLine("E614");
                if (_e614 == null)
                    _e614 = D614 - D613;
                return _e614.Value;
            }
        }
        private double? _e615;
        public double E615
        {
            get
            {
                //Debug.WriteLine("E615");
                if (_e615 == null)
                    _e615 = D615 - D614;
                return _e615.Value;
            }
        }
        private double? _e616;
        public double E616
        {
            get
            {
                //Debug.WriteLine("E616");
                if (_e616 == null)
                    _e616 = D616 - D615;
                return _e616.Value;
            }
        }
        private double? _e617;
        public double E617
        {
            get
            {
                //Debug.WriteLine("E617");
                if (_e617 == null)
                    _e617 = D617 - D616;
                return _e617.Value;
            }
        }
        private double? _e618;
        public double E618
        {
            get
            {
                //Debug.WriteLine("E618");
                if (_e618 == null)
                    _e618 = D618 - D617;
                return _e618.Value;
            }
        }
        private double? _e619;
        public double E619
        {
            get
            {
                //Debug.WriteLine("E619");
                if (_e619 == null)
                    _e619 = D619 - D618;
                return _e619.Value;
            }
        }
        private double? _e620;
        public double E620
        {
            get
            {
                //Debug.WriteLine("E620");
                if (_e620 == null)
                    _e620 = D620 - D619;
                return _e620.Value;
            }
        }
        private double? _e621;
        public double E621
        {
            get
            {
                //Debug.WriteLine("E621");
                if (_e621 == null)
                    _e621 = D621 - D620;
                return _e621.Value;
            }
        }
        private double? _e622;
        public double E622
        {
            get
            {
                //Debug.WriteLine("E622");
                if (_e622 == null)
                    _e622 = D622 - D621;
                return _e622.Value;
            }
        }
        private double? _e623;
        public double E623
        {
            get
            {
                //Debug.WriteLine("E623");
                if (_e623 == null)
                    _e623 = D623 - D622;
                return _e623.Value;
            }
        }
        private double? _e624;
        public double E624
        {
            get
            {
                //Debug.WriteLine("E624");
                if (_e624 == null)
                    _e624 = D624 - D623;
                return _e624.Value;
            }
        }
        private double? _e625;
        public double E625
        {
            get
            {
                //Debug.WriteLine("E625");
                if (_e625 == null)
                    _e625 = D625 - D624;
                return _e625.Value;
            }
        }
        private double? _e626;
        public double E626
        {
            get
            {
                //Debug.WriteLine("E626");
                if (_e626 == null)
                    _e626 = D626 - D625;
                return _e626.Value;
            }
        }
        private double? _e627;
        public double E627
        {
            get
            {
                //Debug.WriteLine("E627");
                if (_e627 == null)
                    _e627 = D627 - D626;
                return _e627.Value;
            }
        }
        private double? _e628;
        public double E628
        {
            get
            {
                //Debug.WriteLine("E628");
                if (_e628 == null)
                    _e628 = D628 - D627;
                return _e628.Value;
            }
        }
        private double? _e629;
        public double E629
        {
            get
            {
                //Debug.WriteLine("E629");
                if (_e629 == null)
                    _e629 = D629 - D628;
                return _e629.Value;
            }
        }
        private double? _e630;
        public double E630
        {
            get
            {
                //Debug.WriteLine("E630");
                if (_e630 == null)
                    _e630 = D630 - D629;
                return _e630.Value;
            }
        }
        private double? _e631;
        public double E631
        {
            get
            {
                //Debug.WriteLine("E631");
                if (_e631 == null)
                    _e631 = D631 - D630;
                return _e631.Value;
            }
        }
        private double? _e632;
        public double E632
        {
            get
            {
                //Debug.WriteLine("E632");
                if (_e632 == null)
                    _e632 = D632 - D631;
                return _e632.Value;
            }
        }
        private double? _e633;
        public double E633
        {
            get
            {
                //Debug.WriteLine("E633");
                if (_e633 == null)
                    _e633 = D633 - D632;
                return _e633.Value;
            }
        }
        private double? _e634;
        public double E634
        {
            get
            {
                //Debug.WriteLine("E634");
                if (_e634 == null)
                    _e634 = D634 - D633;
                return _e634.Value;
            }
        }
        private double? _e635;
        public double E635
        {
            get
            {
                //Debug.WriteLine("E635");
                if (_e635 == null)
                    _e635 = D635 - D634;
                return _e635.Value;
            }
        }
        private double? _e636;
        public double E636
        {
            get
            {
                //Debug.WriteLine("E636");
                if (_e636 == null)
                    _e636 = D636 - D635;
                return _e636.Value;
            }
        }
        private double? _e637;
        public double E637
        {
            get
            {
                //Debug.WriteLine("E637");
                if (_e637 == null)
                    _e637 = D637 - D636;
                return _e637.Value;
            }
        }
        private double? _e638;
        public double E638
        {
            get
            {
                //Debug.WriteLine("E638");
                if (_e638 == null)
                    _e638 = D638 - D637;
                return _e638.Value;
            }
        }
        private double? _e639;
        public double E639
        {
            get
            {
                //Debug.WriteLine("E639");
                if (_e639 == null)
                    _e639 = D639 - D638;
                return _e639.Value;
            }
        }
        private double? _e640;
        public double E640
        {
            get
            {
                //Debug.WriteLine("E640");
                if (_e640 == null)
                    _e640 = D640 - D639;
                return _e640.Value;
            }
        }
        private double? _e641;
        public double E641
        {
            get
            {
                //Debug.WriteLine("E641");
                if (_e641 == null)
                    _e641 = D641 - D640;
                return _e641.Value;
            }
        }
        private double? _e642;
        public double E642
        {
            get
            {
                //Debug.WriteLine("E642");
                if (_e642 == null)
                    _e642 = D642 - D641;
                return _e642.Value;
            }
        }
        private double? _e643;
        public double E643
        {
            get
            {
                //Debug.WriteLine("E643");
                if (_e643 == null)
                    _e643 = D643 - D642;
                return _e643.Value;
            }
        }
        private double? _e644;
        public double E644
        {
            get
            {
                //Debug.WriteLine("E644");
                if (_e644 == null)
                    _e644 = D644 - D643;
                return _e644.Value;
            }
        }
        private double? _e645;
        public double E645
        {
            get
            {
                //Debug.WriteLine("E645");
                if (_e645 == null)
                    _e645 = D645 - D644;
                return _e645.Value;
            }
        }
        private double? _e646;
        public double E646
        {
            get
            {
                //Debug.WriteLine("E646");
                if (_e646 == null)
                    _e646 = D646 - D645;
                return _e646.Value;
            }
        }
        private double? _e647;
        public double E647
        {
            get
            {
                //Debug.WriteLine("E647");
                if (_e647 == null)
                    _e647 = D647 - D646;
                return _e647.Value;
            }
        }
        private double? _e648;
        public double E648
        {
            get
            {
                //Debug.WriteLine("E648");
                if (_e648 == null)
                    _e648 = D648 - D647;
                return _e648.Value;
            }
        }
        private double? _e649;
        public double E649
        {
            get
            {
                //Debug.WriteLine("E649");
                if (_e649 == null)
                    _e649 = D649 - D648;
                return _e649.Value;
            }
        }
        private double? _e650;
        public double E650
        {
            get
            {
                //Debug.WriteLine("E650");
                if (_e650 == null)
                    _e650 = D650 - D649;
                return _e650.Value;
            }
        }
        private double? _e651;
        public double E651
        {
            get
            {
                //Debug.WriteLine("E651");
                if (_e651 == null)
                    _e651 = D651 - D650;
                return _e651.Value;
            }
        }
        private double? _e652;
        public double E652
        {
            get
            {
                //Debug.WriteLine("E652");
                if (_e652 == null)
                    _e652 = D652 - D651;
                return _e652.Value;
            }
        }
        private double? _e653;
        public double E653
        {
            get
            {
                //Debug.WriteLine("E653");
                if (_e653 == null)
                    _e653 = D653 - D652;
                return _e653.Value;
            }
        }
        private double? _e654;
        public double E654
        {
            get
            {
                //Debug.WriteLine("E654");
                if (_e654 == null)
                    _e654 = D654 - D653;
                return _e654.Value;
            }
        }
        private double? _e655;
        public double E655
        {
            get
            {
                //Debug.WriteLine("E655");
                if (_e655 == null)
                    _e655 = D655 - D654;
                return _e655.Value;
            }
        }
        private double? _e656;
        public double E656
        {
            get
            {
                //Debug.WriteLine("E656");
                if (_e656 == null)
                    _e656 = D656 - D655;
                return _e656.Value;
            }
        }
        private double? _e657;
        public double E657
        {
            get
            {
                //Debug.WriteLine("E657");
                if (_e657 == null)
                    _e657 = D657 - D656;
                return _e657.Value;
            }
        }
        private double? _e658;
        public double E658
        {
            get
            {
                //Debug.WriteLine("E658");
                if (_e658 == null)
                    _e658 = D658 - D657;
                return _e658.Value;
            }
        }
        private double? _e659;
        public double E659
        {
            get
            {
                //Debug.WriteLine("E659");
                if (_e659 == null)
                    _e659 = D659 - D658;
                return _e659.Value;
            }
        }
        private double? _e660;
        public double E660
        {
            get
            {
                //Debug.WriteLine("E660");
                if (_e660 == null)
                    _e660 = D660 - D659;
                return _e660.Value;
            }
        }
        private double? _e661;
        public double E661
        {
            get
            {
                //Debug.WriteLine("E661");
                if (_e661 == null)
                    _e661 = D661 - D660;
                return _e661.Value;
            }
        }
        private double? _e662;
        public double E662
        {
            get
            {
                //Debug.WriteLine("E662");
                if (_e662 == null)
                    _e662 = D662 - D661;
                return _e662.Value;
            }
        }
        private double? _e663;
        public double E663
        {
            get
            {
                //Debug.WriteLine("E663");
                if (_e663 == null)
                    _e663 = D663 - D662;
                return _e663.Value;
            }
        }
        private double? _e664;
        public double E664
        {
            get
            {
                //Debug.WriteLine("E664");
                if (_e664 == null)
                    _e664 = D664 - D663;
                return _e664.Value;
            }
        }
        private double? _e665;
        public double E665
        {
            get
            {
                //Debug.WriteLine("E665");
                if (_e665 == null)
                    _e665 = D665 - D664;
                return _e665.Value;
            }
        }
        private double? _e666;
        public double E666
        {
            get
            {
                //Debug.WriteLine("E666");
                if (_e666 == null)
                    _e666 = D666 - D665;
                return _e666.Value;
            }
        }
        private double? _e667;
        public double E667
        {
            get
            {
                //Debug.WriteLine("E667");
                if (_e667 == null)
                    _e667 = D667 - D666;
                return _e667.Value;
            }
        }
        private double? _e668;
        public double E668
        {
            get
            {
                //Debug.WriteLine("E668");
                if (_e668 == null)
                    _e668 = D668 - D667;
                return _e668.Value;
            }
        }
        private double? _e669;
        public double E669
        {
            get
            {
                //Debug.WriteLine("E669");
                if (_e669 == null)
                    _e669 = D669 - D668;
                return _e669.Value;
            }
        }
        private double? _e670;
        public double E670
        {
            get
            {
                //Debug.WriteLine("E670");
                if (_e670 == null)
                    _e670 = D670 - D669;
                return _e670.Value;
            }
        }
        private double? _e671;
        public double E671
        {
            get
            {
                //Debug.WriteLine("E671");
                if (_e671 == null)
                    _e671 = D671 - D670;
                return _e671.Value;
            }
        }
        private double? _e672;
        public double E672
        {
            get
            {
                //Debug.WriteLine("E672");
                if (_e672 == null)
                    _e672 = D672 - D671;
                return _e672.Value;
            }
        }
        private double? _e673;
        public double E673
        {
            get
            {
                //Debug.WriteLine("E673");
                if (_e673 == null)
                    _e673 = D673 - D672;
                return _e673.Value;
            }
        }
        private double? _e674;
        public double E674
        {
            get
            {
                //Debug.WriteLine("E674");
                if (_e674 == null)
                    _e674 = D674 - D673;
                return _e674.Value;
            }
        }
        private double? _e675;
        public double E675
        {
            get
            {
                //Debug.WriteLine("E675");
                if (_e675 == null)
                    _e675 = D675 - D674;
                return _e675.Value;
            }
        }
        private double? _e676;
        public double E676
        {
            get
            {
                //Debug.WriteLine("E676");
                if (_e676 == null)
                    _e676 = D676 - D675;
                return _e676.Value;
            }
        }
        private double? _e677;
        public double E677
        {
            get
            {
                //Debug.WriteLine("E677");
                if (_e677 == null)
                    _e677 = D677 - D676;
                return _e677.Value;
            }
        }
        private double? _e678;
        public double E678
        {
            get
            {
                //Debug.WriteLine("E678");
                if (_e678 == null)
                    _e678 = D678 - D677;
                return _e678.Value;
            }
        }
        private double? _e679;
        public double E679
        {
            get
            {
                //Debug.WriteLine("E679");
                if (_e679 == null)
                    _e679 = D679 - D678;
                return _e679.Value;
            }
        }
        private double? _e680;
        public double E680
        {
            get
            {
                //Debug.WriteLine("E680");
                if (_e680 == null)
                    _e680 = D680 - D679;
                return _e680.Value;
            }
        }
        private double? _e681;
        public double E681
        {
            get
            {
                //Debug.WriteLine("E681");
                if (_e681 == null)
                    _e681 = D681 - D680;
                return _e681.Value;
            }
        }
        private double? _e682;
        public double E682
        {
            get
            {
                //Debug.WriteLine("E682");
                if (_e682 == null)
                    _e682 = D682 - D681;
                return _e682.Value;
            }
        }
        private double? _e683;
        public double E683
        {
            get
            {
                //Debug.WriteLine("E683");
                if (_e683 == null)
                    _e683 = D683 - D682;
                return _e683.Value;
            }
        }
        private double? _e684;
        public double E684
        {
            get
            {
                //Debug.WriteLine("E684");
                if (_e684 == null)
                    _e684 = D684 - D683;
                return _e684.Value;
            }
        }
        private double? _e685;
        public double E685
        {
            get
            {
                //Debug.WriteLine("E685");
                if (_e685 == null)
                    _e685 = D685 - D684;
                return _e685.Value;
            }
        }
        private double? _e686;
        public double E686
        {
            get
            {
                //Debug.WriteLine("E686");
                if (_e686 == null)
                    _e686 = D686 - D685;
                return _e686.Value;
            }
        }
        private double? _e687;
        public double E687
        {
            get
            {
                //Debug.WriteLine("E687");
                if (_e687 == null)
                    _e687 = D687 - D686;
                return _e687.Value;
            }
        }
        private double? _e688;
        public double E688
        {
            get
            {
                //Debug.WriteLine("E688");
                if (_e688 == null)
                    _e688 = D688 - D687;
                return _e688.Value;
            }
        }
        private double? _e689;
        public double E689
        {
            get
            {
                //Debug.WriteLine("E689");
                if (_e689 == null)
                    _e689 = D689 - D688;
                return _e689.Value;
            }
        }
        private double? _e690;
        public double E690
        {
            get
            {
                //Debug.WriteLine("E690");
                if (_e690 == null)
                    _e690 = D690 - D689;
                return _e690.Value;
            }
        }
        private double? _e691;
        public double E691
        {
            get
            {
                //Debug.WriteLine("E691");
                if (_e691 == null)
                    _e691 = D691 - D690;
                return _e691.Value;
            }
        }
        private double? _e692;
        public double E692
        {
            get
            {
                //Debug.WriteLine("E692");
                if (_e692 == null)
                    _e692 = D692 - D691;
                return _e692.Value;
            }
        }
        private double? _e693;
        public double E693
        {
            get
            {
                //Debug.WriteLine("E693");
                if (_e693 == null)
                    _e693 = D693 - D692;
                return _e693.Value;
            }
        }
        private double? _e694;
        public double E694
        {
            get
            {
                //Debug.WriteLine("E694");
                if (_e694 == null)
                    _e694 = D694 - D693;
                return _e694.Value;
            }
        }
        private double? _e695;
        public double E695
        {
            get
            {
                //Debug.WriteLine("E695");
                if (_e695 == null)
                    _e695 = D695 - D694;
                return _e695.Value;
            }
        }
        private double? _e696;
        public double E696
        {
            get
            {
                //Debug.WriteLine("E696");
                if (_e696 == null)
                    _e696 = D696 - D695;
                return _e696.Value;
            }
        }
        private double? _e697;
        public double E697
        {
            get
            {
                //Debug.WriteLine("E697");
                if (_e697 == null)
                    _e697 = D697 - D696;
                return _e697.Value;
            }
        }
        private double? _e698;
        public double E698
        {
            get
            {
                //Debug.WriteLine("E698");
                if (_e698 == null)
                    _e698 = D698 - D697;
                return _e698.Value;
            }
        }
        private double? _e699;
        public double E699
        {
            get
            {
                //Debug.WriteLine("E699");
                if (_e699 == null)
                    _e699 = D699 - D698;
                return _e699.Value;
            }
        }
        private double? _e700;
        public double E700
        {
            get
            {
                //Debug.WriteLine("E700");
                if (_e700 == null)
                    _e700 = D700 - D699;
                return _e700.Value;
            }
        }
        private double? _e701;
        public double E701
        {
            get
            {
                //Debug.WriteLine("E701");
                if (_e701 == null)
                    _e701 = D701 - D700;
                return _e701.Value;
            }
        }
        private double? _e702;
        public double E702
        {
            get
            {
                //Debug.WriteLine("E702");
                if (_e702 == null)
                    _e702 = D702 - D701;
                return _e702.Value;
            }
        }
        private double? _e703;
        public double E703
        {
            get
            {
                //Debug.WriteLine("E703");
                if (_e703 == null)
                    _e703 = D703 - D702;
                return _e703.Value;
            }
        }
        private double? _e704;
        public double E704
        {
            get
            {
                //Debug.WriteLine("E704");
                if (_e704 == null)
                    _e704 = D704 - D703;
                return _e704.Value;
            }
        }
        private double? _e705;
        public double E705
        {
            get
            {
                //Debug.WriteLine("E705");
                if (_e705 == null)
                    _e705 = D705 - D704;
                return _e705.Value;
            }
        }
        private double? _e706;
        public double E706
        {
            get
            {
                //Debug.WriteLine("E706");
                if (_e706 == null)
                    _e706 = D706 - D705;
                return _e706.Value;
            }
        }
        private double? _e707;
        public double E707
        {
            get
            {
                //Debug.WriteLine("E707");
                if (_e707 == null)
                    _e707 = D707 - D706;
                return _e707.Value;
            }
        }
        private double? _e708;
        public double E708
        {
            get
            {
                //Debug.WriteLine("E708");
                if (_e708 == null)
                    _e708 = D708 - D707;
                return _e708.Value;
            }
        }
        private double? _e709;
        public double E709
        {
            get
            {
                //Debug.WriteLine("E709");
                if (_e709 == null)
                    _e709 = D709 - D708;
                return _e709.Value;
            }
        }
        private double? _e710;
        public double E710
        {
            get
            {
                //Debug.WriteLine("E710");
                if (_e710 == null)
                    _e710 = D710 - D709;
                return _e710.Value;
            }
        }
        private double? _e711;
        public double E711
        {
            get
            {
                //Debug.WriteLine("E711");
                if (_e711 == null)
                    _e711 = D711 - D710;
                return _e711.Value;
            }
        }
        private double? _e712;
        public double E712
        {
            get
            {
                //Debug.WriteLine("E712");
                if (_e712 == null)
                    _e712 = D712 - D711;
                return _e712.Value;
            }
        }
        private double? _e713;
        public double E713
        {
            get
            {
                //Debug.WriteLine("E713");
                if (_e713 == null)
                    _e713 = D713 - D712;
                return _e713.Value;
            }
        }
        private double? _e714;
        public double E714
        {
            get
            {
                //Debug.WriteLine("E714");
                if (_e714 == null)
                    _e714 = D714 - D713;
                return _e714.Value;
            }
        }
        private double? _e715;
        public double E715
        {
            get
            {
                //Debug.WriteLine("E715");
                if (_e715 == null)
                    _e715 = D715 - D714;
                return _e715.Value;
            }
        }
        private double? _e716;
        public double E716
        {
            get
            {
                //Debug.WriteLine("E716");
                if (_e716 == null)
                    _e716 = D716 - D715;
                return _e716.Value;
            }
        }
        private double? _e717;
        public double E717
        {
            get
            {
                //Debug.WriteLine("E717");
                if (_e717 == null)
                    _e717 = D717 - D716;
                return _e717.Value;
            }
        }
        private double? _e718;
        public double E718
        {
            get
            {
                //Debug.WriteLine("E718");
                if (_e718 == null)
                    _e718 = D718 - D717;
                return _e718.Value;
            }
        }
        private double? _e719;
        public double E719
        {
            get
            {
                //Debug.WriteLine("E719");
                if (_e719 == null)
                    _e719 = D719 - D718;
                return _e719.Value;
            }
        }
        private double? _e720;
        public double E720
        {
            get
            {
                //Debug.WriteLine("E720");
                if (_e720 == null)
                    _e720 = D720 - D719;
                return _e720.Value;
            }
        }
        private double? _e721;
        public double E721
        {
            get
            {
                //Debug.WriteLine("E721");
                if (_e721 == null)
                    _e721 = D721 - D720;
                return _e721.Value;
            }
        }
        private double? _e722;
        public double E722
        {
            get
            {
                //Debug.WriteLine("E722");
                if (_e722 == null)
                    _e722 = D722 - D721;
                return _e722.Value;
            }
        }
        private double? _e723;
        public double E723
        {
            get
            {
                //Debug.WriteLine("E723");
                if (_e723 == null)
                    _e723 = D723 - D722;
                return _e723.Value;
            }
        }
        private double? _e724;
        public double E724
        {
            get
            {
                //Debug.WriteLine("E724");
                if (_e724 == null)
                    _e724 = D724 - D723;
                return _e724.Value;
            }
        }
        private double? _e725;
        public double E725
        {
            get
            {
                //Debug.WriteLine("E725");
                if (_e725 == null)
                    _e725 = D725 - D724;
                return _e725.Value;
            }
        }
        private double? _e726;
        public double E726
        {
            get
            {
                //Debug.WriteLine("E726");
                if (_e726 == null)
                    _e726 = D726 - D725;
                return _e726.Value;
            }
        }
        private double? _e727;
        public double E727
        {
            get
            {
                //Debug.WriteLine("E727");
                if (_e727 == null)
                    _e727 = D727 - D726;
                return _e727.Value;
            }
        }
        private double? _e728;
        public double E728
        {
            get
            {
                //Debug.WriteLine("E728");
                if (_e728 == null)
                    _e728 = D728 - D727;
                return _e728.Value;
            }
        }
        private double? _e729;
        public double E729
        {
            get
            {
                //Debug.WriteLine("E729");
                if (_e729 == null)
                    _e729 = D729 - D728;
                return _e729.Value;
            }
        }
        private double? _e730;
        public double E730
        {
            get
            {
                //Debug.WriteLine("E730");
                if (_e730 == null)
                    _e730 = D730 - D729;
                return _e730.Value;
            }
        }
        private double? _e731;
        public double E731
        {
            get
            {
                //Debug.WriteLine("E731");
                if (_e731 == null)
                    _e731 = D731 - D730;
                return _e731.Value;
            }
        }
        private double? _e732;
        public double E732
        {
            get
            {
                //Debug.WriteLine("E732");
                if (_e732 == null)
                    _e732 = D732 - D731;
                return _e732.Value;
            }
        }
        private double? _e733;
        public double E733
        {
            get
            {
                //Debug.WriteLine("E733");
                if (_e733 == null)
                    _e733 = D733 - D732;
                return _e733.Value;
            }
        }
        private double? _e734;
        public double E734
        {
            get
            {
                //Debug.WriteLine("E734");
                if (_e734 == null)
                    _e734 = D734 - D733;
                return _e734.Value;
            }
        }
        private double? _e735;
        public double E735
        {
            get
            {
                //Debug.WriteLine("E735");
                if (_e735 == null)
                    _e735 = D735 - D734;
                return _e735.Value;
            }
        }
        private double? _e736;
        public double E736
        {
            get
            {
                //Debug.WriteLine("E736");
                if (_e736 == null)
                    _e736 = D736 - D735;
                return _e736.Value;
            }
        }
        private double? _e737;
        public double E737
        {
            get
            {
                //Debug.WriteLine("E737");
                if (_e737 == null)
                    _e737 = D737 - D736;
                return _e737.Value;
            }
        }
        private double? _e738;
        public double E738
        {
            get
            {
                //Debug.WriteLine("E738");
                if (_e738 == null)
                    _e738 = D738 - D737;
                return _e738.Value;
            }
        }
        private double? _e739;
        public double E739
        {
            get
            {
                //Debug.WriteLine("E739");
                if (_e739 == null)
                    _e739 = D739 - D738;
                return _e739.Value;
            }
        }
        private double? _e740;
        public double E740
        {
            get
            {
                //Debug.WriteLine("E740");
                if (_e740 == null)
                    _e740 = D740 - D739;
                return _e740.Value;
            }
        }
        private double? _e741;
        public double E741
        {
            get
            {
                //Debug.WriteLine("E741");
                if (_e741 == null)
                    _e741 = D741 - D740;
                return _e741.Value;
            }
        }
        private double? _e742;
        public double E742
        {
            get
            {
                //Debug.WriteLine("E742");
                if (_e742 == null)
                    _e742 = D742 - D741;
                return _e742.Value;
            }
        }
        private double? _e743;
        public double E743
        {
            get
            {
                //Debug.WriteLine("E743");
                if (_e743 == null)
                    _e743 = D743 - D742;
                return _e743.Value;
            }
        }
        private double? _e744;
        public double E744
        {
            get
            {
                //Debug.WriteLine("E744");
                if (_e744 == null)
                    _e744 = D744 - D743;
                return _e744.Value;
            }
        }
        private double? _e745;
        public double E745
        {
            get
            {
                //Debug.WriteLine("E745");
                if (_e745 == null)
                    _e745 = D745 - D744;
                return _e745.Value;
            }
        }
        private double? _e746;
        public double E746
        {
            get
            {
                //Debug.WriteLine("E746");
                if (_e746 == null)
                    _e746 = D746 - D745;
                return _e746.Value;
            }
        }
        private double? _e747;
        public double E747
        {
            get
            {
                //Debug.WriteLine("E747");
                if (_e747 == null)
                    _e747 = D747 - D746;
                return _e747.Value;
            }
        }
        private double? _e748;
        public double E748
        {
            get
            {
                //Debug.WriteLine("E748");
                if (_e748 == null)
                    _e748 = D748 - D747;
                return _e748.Value;
            }
        }
        private double? _e749;
        public double E749
        {
            get
            {
                //Debug.WriteLine("E749");
                if (_e749 == null)
                    _e749 = D749 - D748;
                return _e749.Value;
            }
        }
        private double? _e750;
        public double E750
        {
            get
            {
                //Debug.WriteLine("E750");
                if (_e750 == null)
                    _e750 = D750 - D749;
                return _e750.Value;
            }
        }
        private double? _e751;
        public double E751
        {
            get
            {
                //Debug.WriteLine("E751");
                if (_e751 == null)
                    _e751 = D751 - D750;
                return _e751.Value;
            }
        }
        private double? _e752;
        public double E752
        {
            get
            {
                //Debug.WriteLine("E752");
                if (_e752 == null)
                    _e752 = D752 - D751;
                return _e752.Value;
            }
        }
        private double? _e753;
        public double E753
        {
            get
            {
                //Debug.WriteLine("E753");
                if (_e753 == null)
                    _e753 = D753 - D752;
                return _e753.Value;
            }
        }
        private double? _e754;
        public double E754
        {
            get
            {
                //Debug.WriteLine("E754");
                if (_e754 == null)
                    _e754 = D754 - D753;
                return _e754.Value;
            }
        }
        private double? _e755;
        public double E755
        {
            get
            {
                //Debug.WriteLine("E755");
                if (_e755 == null)
                    _e755 = D755 - D754;
                return _e755.Value;
            }
        }
        private double? _e756;
        public double E756
        {
            get
            {
                //Debug.WriteLine("E756");
                if (_e756 == null)
                    _e756 = D756 - D755;
                return _e756.Value;
            }
        }
        private double? _e757;
        public double E757
        {
            get
            {
                //Debug.WriteLine("E757");
                if (_e757 == null)
                    _e757 = D757 - D756;
                return _e757.Value;
            }
        }
        private double? _e758;
        public double E758
        {
            get
            {
                //Debug.WriteLine("E758");
                if (_e758 == null)
                    _e758 = D758 - D757;
                return _e758.Value;
            }
        }
        private double? _e759;
        public double E759
        {
            get
            {
                //Debug.WriteLine("E759");
                if (_e759 == null)
                    _e759 = D759 - D758;
                return _e759.Value;
            }
        }
        private double? _e760;
        public double E760
        {
            get
            {
                //Debug.WriteLine("E760");
                if (_e760 == null)
                    _e760 = D760 - D759;
                return _e760.Value;
            }
        }
        private double? _e761;
        public double E761
        {
            get
            {
                //Debug.WriteLine("E761");
                if (_e761 == null)
                    _e761 = D761 - D760;
                return _e761.Value;
            }
        }
        private double? _e762;
        public double E762
        {
            get
            {
                //Debug.WriteLine("E762");
                if (_e762 == null)
                    _e762 = D762 - D761;
                return _e762.Value;
            }
        }
        private double? _e763;
        public double E763
        {
            get
            {
                //Debug.WriteLine("E763");
                if (_e763 == null)
                    _e763 = D763 - D762;
                return _e763.Value;
            }
        }
        private double? _e764;
        public double E764
        {
            get
            {
                //Debug.WriteLine("E764");
                if (_e764 == null)
                    _e764 = D764 - D763;
                return _e764.Value;
            }
        }
        private double? _e765;
        public double E765
        {
            get
            {
                //Debug.WriteLine("E765");
                if (_e765 == null)
                    _e765 = D765 - D764;
                return _e765.Value;
            }
        }
        private double? _e766;
        public double E766
        {
            get
            {
                //Debug.WriteLine("E766");
                if (_e766 == null)
                    _e766 = D766 - D765;
                return _e766.Value;
            }
        }
        private double? _e767;
        public double E767
        {
            get
            {
                //Debug.WriteLine("E767");
                if (_e767 == null)
                    _e767 = D767 - D766;
                return _e767.Value;
            }
        }
        private double? _e768;
        public double E768
        {
            get
            {
                //Debug.WriteLine("E768");
                if (_e768 == null)
                    _e768 = D768 - D767;
                return _e768.Value;
            }
        }
        private double? _e769;
        public double E769
        {
            get
            {
                //Debug.WriteLine("E769");
                if (_e769 == null)
                    _e769 = D769 - D768;
                return _e769.Value;
            }
        }
        private double? _e770;
        public double E770
        {
            get
            {
                //Debug.WriteLine("E770");
                if (_e770 == null)
                    _e770 = D770 - D769;
                return _e770.Value;
            }
        }
        private double? _e771;
        public double E771
        {
            get
            {
                //Debug.WriteLine("E771");
                if (_e771 == null)
                    _e771 = D771 - D770;
                return _e771.Value;
            }
        }
        private double? _e772;
        public double E772
        {
            get
            {
                //Debug.WriteLine("E772");
                if (_e772 == null)
                    _e772 = D772 - D771;
                return _e772.Value;
            }
        }
        private double? _e773;
        public double E773
        {
            get
            {
                //Debug.WriteLine("E773");
                if (_e773 == null)
                    _e773 = D773 - D772;
                return _e773.Value;
            }
        }
        private double? _e774;
        public double E774
        {
            get
            {
                //Debug.WriteLine("E774");
                if (_e774 == null)
                    _e774 = D774 - D773;
                return _e774.Value;
            }
        }
        private double? _e775;
        public double E775
        {
            get
            {
                //Debug.WriteLine("E775");
                if (_e775 == null)
                    _e775 = D775 - D774;
                return _e775.Value;
            }
        }
        private double? _e776;
        public double E776
        {
            get
            {
                //Debug.WriteLine("E776");
                if (_e776 == null)
                    _e776 = D776 - D775;
                return _e776.Value;
            }
        }
        private double? _e777;
        public double E777
        {
            get
            {
                //Debug.WriteLine("E777");
                if (_e777 == null)
                    _e777 = D777 - D776;
                return _e777.Value;
            }
        }
        private double? _e778;
        public double E778
        {
            get
            {
                //Debug.WriteLine("E778");
                if (_e778 == null)
                    _e778 = D778 - D777;
                return _e778.Value;
            }
        }
        private double? _e779;
        public double E779
        {
            get
            {
                //Debug.WriteLine("E779");
                if (_e779 == null)
                    _e779 = D779 - D778;
                return _e779.Value;
            }
        }
        private double? _e780;
        public double E780
        {
            get
            {
                //Debug.WriteLine("E780");
                if (_e780 == null)
                    _e780 = D780 - D779;
                return _e780.Value;
            }
        }
        private double? _e781;
        public double E781
        {
            get
            {
                //Debug.WriteLine("E781");
                if (_e781 == null)
                    _e781 = D781 - D780;
                return _e781.Value;
            }
        }
        private double? _e782;
        public double E782
        {
            get
            {
                //Debug.WriteLine("E782");
                if (_e782 == null)
                    _e782 = D782 - D781;
                return _e782.Value;
            }
        }
        private double? _e783;
        public double E783
        {
            get
            {
                //Debug.WriteLine("E783");
                if (_e783 == null)
                    _e783 = D783 - D782;
                return _e783.Value;
            }
        }
        private double? _e784;
        public double E784
        {
            get
            {
                //Debug.WriteLine("E784");
                if (_e784 == null)
                    _e784 = D784 - D783;
                return _e784.Value;
            }
        }
        private double? _e785;
        public double E785
        {
            get
            {
                //Debug.WriteLine("E785");
                if (_e785 == null)
                    _e785 = D785 - D784;
                return _e785.Value;
            }
        }
        private double? _e786;
        public double E786
        {
            get
            {
                //Debug.WriteLine("E786");
                if (_e786 == null)
                    _e786 = D786 - D785;
                return _e786.Value;
            }
        }
        private double? _e787;
        public double E787
        {
            get
            {
                //Debug.WriteLine("E787");
                if (_e787 == null)
                    _e787 = D787 - D786;
                return _e787.Value;
            }
        }
        private double? _e788;
        public double E788
        {
            get
            {
                //Debug.WriteLine("E788");
                if (_e788 == null)
                    _e788 = D788 - D787;
                return _e788.Value;
            }
        }
        private double? _e789;
        public double E789
        {
            get
            {
                //Debug.WriteLine("E789");
                if (_e789 == null)
                    _e789 = D789 - D788;
                return _e789.Value;
            }
        }
        private double? _e790;
        public double E790
        {
            get
            {
                //Debug.WriteLine("E790");
                if (_e790 == null)
                    _e790 = D790 - D789;
                return _e790.Value;
            }
        }
        private double? _e791;
        public double E791
        {
            get
            {
                //Debug.WriteLine("E791");
                if (_e791 == null)
                    _e791 = D791 - D790;
                return _e791.Value;
            }
        }
        private double? _e792;
        public double E792
        {
            get
            {
                //Debug.WriteLine("E792");
                if (_e792 == null)
                    _e792 = D792 - D791;
                return _e792.Value;
            }
        }
        private double? _e793;
        public double E793
        {
            get
            {
                //Debug.WriteLine("E793");
                if (_e793 == null)
                    _e793 = D793 - D792;
                return _e793.Value;
            }
        }
        private double? _e794;
        public double E794
        {
            get
            {
                //Debug.WriteLine("E794");
                if (_e794 == null)
                    _e794 = D794 - D793;
                return _e794.Value;
            }
        }
        private double? _e795;
        public double E795
        {
            get
            {
                //Debug.WriteLine("E795");
                if (_e795 == null)
                    _e795 = D795 - D794;
                return _e795.Value;
            }
        }
        private double? _e796;
        public double E796
        {
            get
            {
                //Debug.WriteLine("E796");
                if (_e796 == null)
                    _e796 = D796 - D795;
                return _e796.Value;
            }
        }
        private double? _e797;
        public double E797
        {
            get
            {
                //Debug.WriteLine("E797");
                if (_e797 == null)
                    _e797 = D797 - D796;
                return _e797.Value;
            }
        }
        private double? _e798;
        public double E798
        {
            get
            {
                //Debug.WriteLine("E798");
                if (_e798 == null)
                    _e798 = D798 - D797;
                return _e798.Value;
            }
        }
        private double? _e799;
        public double E799
        {
            get
            {
                //Debug.WriteLine("E799");
                if (_e799 == null)
                    _e799 = D799 - D798;
                return _e799.Value;
            }
        }
        private double? _e800;
        public double E800
        {
            get
            {
                //Debug.WriteLine("E800");
                if (_e800 == null)
                    _e800 = D800 - D799;
                return _e800.Value;
            }
        }
        private double? _e801;
        public double E801
        {
            get
            {
                //Debug.WriteLine("E801");
                if (_e801 == null)
                    _e801 = D801 - D800;
                return _e801.Value;
            }
        }
        private double? _e802;
        public double E802
        {
            get
            {
                //Debug.WriteLine("E802");
                if (_e802 == null)
                    _e802 = D802 - D801;
                return _e802.Value;
            }
        }
        private double? _e803;
        public double E803
        {
            get
            {
                //Debug.WriteLine("E803");
                if (_e803 == null)
                    _e803 = D803 - D802;
                return _e803.Value;
            }
        }
        private double? _e804;
        public double E804
        {
            get
            {
                //Debug.WriteLine("E804");
                if (_e804 == null)
                    _e804 = D804 - D803;
                return _e804.Value;
            }
        }
        private double? _e805;
        public double E805
        {
            get
            {
                //Debug.WriteLine("E805");
                if (_e805 == null)
                    _e805 = D805 - D804;
                return _e805.Value;
            }
        }
        private double? _e806;
        public double E806
        {
            get
            {
                //Debug.WriteLine("E806");
                if (_e806 == null)
                    _e806 = D806 - D805;
                return _e806.Value;
            }
        }
        private double? _e807;
        public double E807
        {
            get
            {
                //Debug.WriteLine("E807");
                if (_e807 == null)
                    _e807 = D807 - D806;
                return _e807.Value;
            }
        }

        private double? _f607;
        public double F607
        {
            get
            {
                //Debug.WriteLine("F607");
                if (_f607 == null)
                    _f607 = E607 * B585;
                return _f607.Value;
            }
        }
        private double? _f608;
        public double F608
        {
            get
            {
                //Debug.WriteLine("F608");
                if (_f608 == null)
                    _f608 = E608 * B585;
                return _f608.Value;
            }
        }
        private double? _f609;
        public double F609
        {
            get
            {
                //Debug.WriteLine("F609");
                if (_f609 == null)
                    _f609 = E609 * B585;
                return _f609.Value;
            }
        }
        private double? _f610;
        public double F610
        {
            get
            {
                //Debug.WriteLine("F610");
                if (_f610 == null)
                    _f610 = E610 * B585;
                return _f610.Value;
            }
        }
        private double? _f611;
        public double F611
        {
            get
            {
                //Debug.WriteLine("F611");
                if (_f611 == null)
                    _f611 = E611 * B585;
                return _f611.Value;
            }
        }
        private double? _f612;
        public double F612
        {
            get
            {
                //Debug.WriteLine("F612");
                if (_f612 == null)
                    _f612 = E612 * B585;
                return _f612.Value;
            }
        }
        private double? _f613;
        public double F613
        {
            get
            {
                //Debug.WriteLine("F613");
                if (_f613 == null)
                    _f613 = E613 * B585;
                return _f613.Value;
            }
        }
        private double? _f614;
        public double F614
        {
            get
            {
                //Debug.WriteLine("F614");
                if (_f614 == null)
                    _f614 = E614 * B585;
                return _f614.Value;
            }
        }
        private double? _f615;
        public double F615
        {
            get
            {
                //Debug.WriteLine("F615");
                if (_f615 == null)
                    _f615 = E615 * B585;
                return _f615.Value;
            }
        }
        private double? _f616;
        public double F616
        {
            get
            {
                //Debug.WriteLine("F616");
                if (_f616 == null)
                    _f616 = E616 * B585;
                return _f616.Value;
            }
        }
        private double? _f617;
        public double F617
        {
            get
            {
                //Debug.WriteLine("F617");
                if (_f617 == null)
                    _f617 = E617 * B585;
                return _f617.Value;
            }
        }
        private double? _f618;
        public double F618
        {
            get
            {
                //Debug.WriteLine("F618");
                if (_f618 == null)
                    _f618 = E618 * B585;
                return _f618.Value;
            }
        }
        private double? _f619;
        public double F619
        {
            get
            {
                //Debug.WriteLine("F619");
                if (_f619 == null)
                    _f619 = E619 * B585;
                return _f619.Value;
            }
        }
        private double? _f620;
        public double F620
        {
            get
            {
                //Debug.WriteLine("F620");
                if (_f620 == null)
                    _f620 = E620 * B585;
                return _f620.Value;
            }
        }
        private double? _f621;
        public double F621
        {
            get
            {
                //Debug.WriteLine("F621");
                if (_f621 == null)
                    _f621 = E621 * B585;
                return _f621.Value;
            }
        }
        private double? _f622;
        public double F622
        {
            get
            {
                //Debug.WriteLine("F622");
                if (_f622 == null)
                    _f622 = E622 * B585;
                return _f622.Value;
            }
        }
        private double? _f623;
        public double F623
        {
            get
            {
                //Debug.WriteLine("F623");
                if (_f623 == null)
                    _f623 = E623 * B585;
                return _f623.Value;
            }
        }
        private double? _f624;
        public double F624
        {
            get
            {
                //Debug.WriteLine("F624");
                if (_f624 == null)
                    _f624 = E624 * B585;
                return _f624.Value;
            }
        }
        private double? _f625;
        public double F625
        {
            get
            {
                //Debug.WriteLine("F625");
                if (_f625 == null)
                    _f625 = E625 * B585;
                return _f625.Value;
            }
        }
        private double? _f626;
        public double F626
        {
            get
            {
                //Debug.WriteLine("F626");
                if (_f626 == null)
                    _f626 = E626 * B585;
                return _f626.Value;
            }
        }
        private double? _f627;
        public double F627
        {
            get
            {
                //Debug.WriteLine("F627");
                if (_f627 == null)
                    _f627 = E627 * B585;
                return _f627.Value;
            }
        }
        private double? _f628;
        public double F628
        {
            get
            {
                //Debug.WriteLine("F628");
                if (_f628 == null)
                    _f628 = E628 * B585;
                return _f628.Value;
            }
        }
        private double? _f629;
        public double F629
        {
            get
            {
                //Debug.WriteLine("F629");
                if (_f629 == null)
                    _f629 = E629 * B585;
                return _f629.Value;
            }
        }
        private double? _f630;
        public double F630
        {
            get
            {
                //Debug.WriteLine("F630");
                if (_f630 == null)
                    _f630 = E630 * B585;
                return _f630.Value;
            }
        }
        private double? _f631;
        public double F631
        {
            get
            {
                //Debug.WriteLine("F631");
                if (_f631 == null)
                    _f631 = E631 * B585;
                return _f631.Value;
            }
        }
        private double? _f632;
        public double F632
        {
            get
            {
                //Debug.WriteLine("F632");
                if (_f632 == null)
                    _f632 = E632 * B585;
                return _f632.Value;
            }
        }
        private double? _f633;
        public double F633
        {
            get
            {
                //Debug.WriteLine("F633");
                if (_f633 == null)
                    _f633 = E633 * B585;
                return _f633.Value;
            }
        }
        private double? _f634;
        public double F634
        {
            get
            {
                //Debug.WriteLine("F634");
                if (_f634 == null)
                    _f634 = E634 * B585;
                return _f634.Value;
            }
        }
        private double? _f635;
        public double F635
        {
            get
            {
                //Debug.WriteLine("F635");
                if (_f635 == null)
                    _f635 = E635 * B585;
                return _f635.Value;
            }
        }
        private double? _f636;
        public double F636
        {
            get
            {
                //Debug.WriteLine("F636");
                if (_f636 == null)
                    _f636 = E636 * B585;
                return _f636.Value;
            }
        }
        private double? _f637;
        public double F637
        {
            get
            {
                //Debug.WriteLine("F637");
                if (_f637 == null)
                    _f637 = E637 * B585;
                return _f637.Value;
            }
        }
        private double? _f638;
        public double F638
        {
            get
            {
                //Debug.WriteLine("F638");
                if (_f638 == null)
                    _f638 = E638 * B585;
                return _f638.Value;
            }
        }
        private double? _f639;
        public double F639
        {
            get
            {
                //Debug.WriteLine("F639");
                if (_f639 == null)
                    _f639 = E639 * B585;
                return _f639.Value;
            }
        }
        private double? _f640;
        public double F640
        {
            get
            {
                //Debug.WriteLine("F640");
                if (_f640 == null)
                    _f640 = E640 * B585;
                return _f640.Value;
            }
        }
        private double? _f641;
        public double F641
        {
            get
            {
                //Debug.WriteLine("F641");
                if (_f641 == null)
                    _f641 = E641 * B585;
                return _f641.Value;
            }
        }
        private double? _f642;
        public double F642
        {
            get
            {
                //Debug.WriteLine("F642");
                if (_f642 == null)
                    _f642 = E642 * B585;
                return _f642.Value;
            }
        }
        private double? _f643;
        public double F643
        {
            get
            {
                //Debug.WriteLine("F643");
                if (_f643 == null)
                    _f643 = E643 * B585;
                return _f643.Value;
            }
        }
        private double? _f644;
        public double F644
        {
            get
            {
                //Debug.WriteLine("F644");
                if (_f644 == null)
                    _f644 = E644 * B585;
                return _f644.Value;
            }
        }
        private double? _f645;
        public double F645
        {
            get
            {
                //Debug.WriteLine("F645");
                if (_f645 == null)
                    _f645 = E645 * B585;
                return _f645.Value;
            }
        }
        private double? _f646;
        public double F646
        {
            get
            {
                //Debug.WriteLine("F646");
                if (_f646 == null)
                    _f646 = E646 * B585;
                return _f646.Value;
            }
        }
        private double? _f647;
        public double F647
        {
            get
            {
                //Debug.WriteLine("F647");
                if (_f647 == null)
                    _f647 = E647 * B585;
                return _f647.Value;
            }
        }
        private double? _f648;
        public double F648
        {
            get
            {
                //Debug.WriteLine("F648");
                if (_f648 == null)
                    _f648 = E648 * B585;
                return _f648.Value;
            }
        }
        private double? _f649;
        public double F649
        {
            get
            {
                //Debug.WriteLine("F649");
                if (_f649 == null)
                    _f649 = E649 * B585;
                return _f649.Value;
            }
        }
        private double? _f650;
        public double F650
        {
            get
            {
                //Debug.WriteLine("F650");
                if (_f650 == null)
                    _f650 = E650 * B585;
                return _f650.Value;
            }
        }
        private double? _f651;
        public double F651
        {
            get
            {
                //Debug.WriteLine("F651");
                if (_f651 == null)
                    _f651 = E651 * B585;
                return _f651.Value;
            }
        }
        private double? _f652;
        public double F652
        {
            get
            {
                //Debug.WriteLine("F652");
                if (_f652 == null)
                    _f652 = E652 * B585;
                return _f652.Value;
            }
        }
        private double? _f653;
        public double F653
        {
            get
            {
                //Debug.WriteLine("F653");
                if (_f653 == null)
                    _f653 = E653 * B585;
                return _f653.Value;
            }
        }
        private double? _f654;
        public double F654
        {
            get
            {
                //Debug.WriteLine("F654");
                if (_f654 == null)
                    _f654 = E654 * B585;
                return _f654.Value;
            }
        }
        private double? _f655;
        public double F655
        {
            get
            {
                //Debug.WriteLine("F655");
                if (_f655 == null)
                    _f655 = E655 * B585;
                return _f655.Value;
            }
        }
        private double? _f656;
        public double F656
        {
            get
            {
                //Debug.WriteLine("F656");
                if (_f656 == null)
                    _f656 = E656 * B585;
                return _f656.Value;
            }
        }
        private double? _f657;
        public double F657
        {
            get
            {
                //Debug.WriteLine("F657");
                if (_f657 == null)
                    _f657 = E657 * B585;
                return _f657.Value;
            }
        }
        private double? _f658;
        public double F658
        {
            get
            {
                //Debug.WriteLine("F658");
                if (_f658 == null)
                    _f658 = E658 * B585;
                return _f658.Value;
            }
        }
        private double? _f659;
        public double F659
        {
            get
            {
                //Debug.WriteLine("F659");
                if (_f659 == null)
                    _f659 = E659 * B585;
                return _f659.Value;
            }
        }
        private double? _f660;
        public double F660
        {
            get
            {
                //Debug.WriteLine("F660");
                if (_f660 == null)
                    _f660 = E660 * B585;
                return _f660.Value;
            }
        }
        private double? _f661;
        public double F661
        {
            get
            {
                //Debug.WriteLine("F661");
                if (_f661 == null)
                    _f661 = E661 * B585;
                return _f661.Value;
            }
        }
        private double? _f662;
        public double F662
        {
            get
            {
                //Debug.WriteLine("F662");
                if (_f662 == null)
                    _f662 = E662 * B585;
                return _f662.Value;
            }
        }
        private double? _f663;
        public double F663
        {
            get
            {
                //Debug.WriteLine("F663");
                if (_f663 == null)
                    _f663 = E663 * B585;
                return _f663.Value;
            }
        }
        private double? _f664;
        public double F664
        {
            get
            {
                //Debug.WriteLine("F664");
                if (_f664 == null)
                    _f664 = E664 * B585;
                return _f664.Value;
            }
        }
        private double? _f665;
        public double F665
        {
            get
            {
                //Debug.WriteLine("F665");
                if (_f665 == null)
                    _f665 = E665 * B585;
                return _f665.Value;
            }
        }
        private double? _f666;
        public double F666
        {
            get
            {
                //Debug.WriteLine("F666");
                if (_f666 == null)
                    _f666 = E666 * B585;
                return _f666.Value;
            }
        }
        private double? _f667;
        public double F667
        {
            get
            {
                //Debug.WriteLine("F667");
                if (_f667 == null)
                    _f667 = E667 * B585;
                return _f667.Value;
            }
        }
        private double? _f668;
        public double F668
        {
            get
            {
                //Debug.WriteLine("F668");
                if (_f668 == null)
                    _f668 = E668 * B585;
                return _f668.Value;
            }
        }
        private double? _f669;
        public double F669
        {
            get
            {
                //Debug.WriteLine("F669");
                if (_f669 == null)
                    _f669 = E669 * B585;
                return _f669.Value;
            }
        }
        private double? _f670;
        public double F670
        {
            get
            {
                //Debug.WriteLine("F670");
                if (_f670 == null)
                    _f670 = E670 * B585;
                return _f670.Value;
            }
        }
        private double? _f671;
        public double F671
        {
            get
            {
                //Debug.WriteLine("F671");
                if (_f671 == null)
                    _f671 = E671 * B585;
                return _f671.Value;
            }
        }
        private double? _f672;
        public double F672
        {
            get
            {
                //Debug.WriteLine("F672");
                if (_f672 == null)
                    _f672 = E672 * B585;
                return _f672.Value;
            }
        }
        private double? _f673;
        public double F673
        {
            get
            {
                //Debug.WriteLine("F673");
                if (_f673 == null)
                    _f673 = E673 * B585;
                return _f673.Value;
            }
        }
        private double? _f674;
        public double F674
        {
            get
            {
                //Debug.WriteLine("F674");
                if (_f674 == null)
                    _f674 = E674 * B585;
                return _f674.Value;
            }
        }
        private double? _f675;
        public double F675
        {
            get
            {
                //Debug.WriteLine("F675");
                if (_f675 == null)
                    _f675 = E675 * B585;
                return _f675.Value;
            }
        }
        private double? _f676;
        public double F676
        {
            get
            {
                //Debug.WriteLine("F676");
                if (_f676 == null)
                    _f676 = E676 * B585;
                return _f676.Value;
            }
        }
        private double? _f677;
        public double F677
        {
            get
            {
                //Debug.WriteLine("F677");
                if (_f677 == null)
                    _f677 = E677 * B585;
                return _f677.Value;
            }
        }
        private double? _f678;
        public double F678
        {
            get
            {
                //Debug.WriteLine("F678");
                if (_f678 == null)
                    _f678 = E678 * B585;
                return _f678.Value;
            }
        }
        private double? _f679;
        public double F679
        {
            get
            {
                //Debug.WriteLine("F679");
                if (_f679 == null)
                    _f679 = E679 * B585;
                return _f679.Value;
            }
        }
        private double? _f680;
        public double F680
        {
            get
            {
                //Debug.WriteLine("F680");
                if (_f680 == null)
                    _f680 = E680 * B585;
                return _f680.Value;
            }
        }
        private double? _f681;
        public double F681
        {
            get
            {
                //Debug.WriteLine("F681");
                if (_f681 == null)
                    _f681 = E681 * B585;
                return _f681.Value;
            }
        }
        private double? _f682;
        public double F682
        {
            get
            {
                //Debug.WriteLine("F682");
                if (_f682 == null)
                    _f682 = E682 * B585;
                return _f682.Value;
            }
        }
        private double? _f683;
        public double F683
        {
            get
            {
                //Debug.WriteLine("F683");
                if (_f683 == null)
                    _f683 = E683 * B585;
                return _f683.Value;
            }
        }
        private double? _f684;
        public double F684
        {
            get
            {
                //Debug.WriteLine("F684");
                if (_f684 == null)
                    _f684 = E684 * B585;
                return _f684.Value;
            }
        }
        private double? _f685;
        public double F685
        {
            get
            {
                //Debug.WriteLine("F685");
                if (_f685 == null)
                    _f685 = E685 * B585;
                return _f685.Value;
            }
        }
        private double? _f686;
        public double F686
        {
            get
            {
                //Debug.WriteLine("F686");
                if (_f686 == null)
                    _f686 = E686 * B585;
                return _f686.Value;
            }
        }
        private double? _f687;
        public double F687
        {
            get
            {
                //Debug.WriteLine("F687");
                if (_f687 == null)
                    _f687 = E687 * B585;
                return _f687.Value;
            }
        }
        private double? _f688;
        public double F688
        {
            get
            {
                //Debug.WriteLine("F688");
                if (_f688 == null)
                    _f688 = E688 * B585;
                return _f688.Value;
            }
        }
        private double? _f689;
        public double F689
        {
            get
            {
                //Debug.WriteLine("F689");
                if (_f689 == null)
                    _f689 = E689 * B585;
                return _f689.Value;
            }
        }
        private double? _f690;
        public double F690
        {
            get
            {
                //Debug.WriteLine("F690");
                if (_f690 == null)
                    _f690 = E690 * B585;
                return _f690.Value;
            }
        }
        private double? _f691;
        public double F691
        {
            get
            {
                //Debug.WriteLine("F691");
                if (_f691 == null)
                    _f691 = E691 * B585;
                return _f691.Value;
            }
        }
        private double? _f692;
        public double F692
        {
            get
            {
                //Debug.WriteLine("F692");
                if (_f692 == null)
                    _f692 = E692 * B585;
                return _f692.Value;
            }
        }
        private double? _f693;
        public double F693
        {
            get
            {
                //Debug.WriteLine("F693");
                if (_f693 == null)
                    _f693 = E693 * B585;
                return _f693.Value;
            }
        }
        private double? _f694;
        public double F694
        {
            get
            {
                //Debug.WriteLine("F694");
                if (_f694 == null)
                    _f694 = E694 * B585;
                return _f694.Value;
            }
        }
        private double? _f695;
        public double F695
        {
            get
            {
                //Debug.WriteLine("F695");
                if (_f695 == null)
                    _f695 = E695 * B585;
                return _f695.Value;
            }
        }
        private double? _f696;
        public double F696
        {
            get
            {
                //Debug.WriteLine("F696");
                if (_f696 == null)
                    _f696 = E696 * B585;
                return _f696.Value;
            }
        }
        private double? _f697;
        public double F697
        {
            get
            {
                //Debug.WriteLine("F697");
                if (_f697 == null)
                    _f697 = E697 * B585;
                return _f697.Value;
            }
        }
        private double? _f698;
        public double F698
        {
            get
            {
                //Debug.WriteLine("F698");
                if (_f698 == null)
                    _f698 = E698 * B585;
                return _f698.Value;
            }
        }
        private double? _f699;
        public double F699
        {
            get
            {
                //Debug.WriteLine("F699");
                if (_f699 == null)
                    _f699 = E699 * B585;
                return _f699.Value;
            }
        }
        private double? _f700;
        public double F700
        {
            get
            {
                //Debug.WriteLine("F700");
                if (_f700 == null)
                    _f700 = E700 * B585;
                return _f700.Value;
            }
        }
        private double? _f701;
        public double F701
        {
            get
            {
                //Debug.WriteLine("F701");
                if (_f701 == null)
                    _f701 = E701 * B585;
                return _f701.Value;
            }
        }
        private double? _f702;
        public double F702
        {
            get
            {
                //Debug.WriteLine("F702");
                if (_f702 == null)
                    _f702 = E702 * B585;
                return _f702.Value;
            }
        }
        private double? _f703;
        public double F703
        {
            get
            {
                //Debug.WriteLine("F703");
                if (_f703 == null)
                    _f703 = E703 * B585;
                return _f703.Value;
            }
        }
        private double? _f704;
        public double F704
        {
            get
            {
                //Debug.WriteLine("F704");
                if (_f704 == null)
                    _f704 = E704 * B585;
                return _f704.Value;
            }
        }
        private double? _f705;
        public double F705
        {
            get
            {
                //Debug.WriteLine("F705");
                if (_f705 == null)
                    _f705 = E705 * B585;
                return _f705.Value;
            }
        }
        private double? _f706;
        public double F706
        {
            get
            {
                //Debug.WriteLine("F706");
                if (_f706 == null)
                    _f706 = E706 * B585;
                return _f706.Value;
            }
        }
        private double? _f707;
        public double F707
        {
            get
            {
                //Debug.WriteLine("F707");
                if (_f707 == null)
                    _f707 = E707 * B585;
                return _f707.Value;
            }
        }
        private double? _f708;
        public double F708
        {
            get
            {
                //Debug.WriteLine("F708");
                if (_f708 == null)
                    _f708 = E708 * B585;
                return _f708.Value;
            }
        }
        private double? _f709;
        public double F709
        {
            get
            {
                //Debug.WriteLine("F709");
                if (_f709 == null)
                    _f709 = E709 * B585;
                return _f709.Value;
            }
        }
        private double? _f710;
        public double F710
        {
            get
            {
                //Debug.WriteLine("F710");
                if (_f710 == null)
                    _f710 = E710 * B585;
                return _f710.Value;
            }
        }
        private double? _f711;
        public double F711
        {
            get
            {
                //Debug.WriteLine("F711");
                if (_f711 == null)
                    _f711 = E711 * B585;
                return _f711.Value;
            }
        }
        private double? _f712;
        public double F712
        {
            get
            {
                //Debug.WriteLine("F712");
                if (_f712 == null)
                    _f712 = E712 * B585;
                return _f712.Value;
            }
        }
        private double? _f713;
        public double F713
        {
            get
            {
                //Debug.WriteLine("F713");
                if (_f713 == null)
                    _f713 = E713 * B585;
                return _f713.Value;
            }
        }
        private double? _f714;
        public double F714
        {
            get
            {
                //Debug.WriteLine("F714");
                if (_f714 == null)
                    _f714 = E714 * B585;
                return _f714.Value;
            }
        }
        private double? _f715;
        public double F715
        {
            get
            {
                //Debug.WriteLine("F715");
                if (_f715 == null)
                    _f715 = E715 * B585;
                return _f715.Value;
            }
        }
        private double? _f716;
        public double F716
        {
            get
            {
                //Debug.WriteLine("F716");
                if (_f716 == null)
                    _f716 = E716 * B585;
                return _f716.Value;
            }
        }
        private double? _f717;
        public double F717
        {
            get
            {
                //Debug.WriteLine("F717");
                if (_f717 == null)
                    _f717 = E717 * B585;
                return _f717.Value;
            }
        }
        private double? _f718;
        public double F718
        {
            get
            {
                //Debug.WriteLine("F718");
                if (_f718 == null)
                    _f718 = E718 * B585;
                return _f718.Value;
            }
        }
        private double? _f719;
        public double F719
        {
            get
            {
                //Debug.WriteLine("F719");
                if (_f719 == null)
                    _f719 = E719 * B585;
                return _f719.Value;
            }
        }
        private double? _f720;
        public double F720
        {
            get
            {
                //Debug.WriteLine("F720");
                if (_f720 == null)
                    _f720 = E720 * B585;
                return _f720.Value;
            }
        }
        private double? _f721;
        public double F721
        {
            get
            {
                //Debug.WriteLine("F721");
                if (_f721 == null)
                    _f721 = E721 * B585;
                return _f721.Value;
            }
        }
        private double? _f722;
        public double F722
        {
            get
            {
                //Debug.WriteLine("F722");
                if (_f722 == null)
                    _f722 = E722 * B585;
                return _f722.Value;
            }
        }
        private double? _f723;
        public double F723
        {
            get
            {
                //Debug.WriteLine("F723");
                if (_f723 == null)
                    _f723 = E723 * B585;
                return _f723.Value;
            }
        }
        private double? _f724;
        public double F724
        {
            get
            {
                //Debug.WriteLine("F724");
                if (_f724 == null)
                    _f724 = E724 * B585;
                return _f724.Value;
            }
        }
        private double? _f725;
        public double F725
        {
            get
            {
                //Debug.WriteLine("F725");
                if (_f725 == null)
                    _f725 = E725 * B585;
                return _f725.Value;
            }
        }
        private double? _f726;
        public double F726
        {
            get
            {
                //Debug.WriteLine("F726");
                if (_f726 == null)
                    _f726 = E726 * B585;
                return _f726.Value;
            }
        }
        private double? _f727;
        public double F727
        {
            get
            {
                //Debug.WriteLine("F727");
                if (_f727 == null)
                    _f727 = E727 * B585;
                return _f727.Value;
            }
        }
        private double? _f728;
        public double F728
        {
            get
            {
                //Debug.WriteLine("F728");
                if (_f728 == null)
                    _f728 = E728 * B585;
                return _f728.Value;
            }
        }
        private double? _f729;
        public double F729
        {
            get
            {
                //Debug.WriteLine("F729");
                if (_f729 == null)
                    _f729 = E729 * B585;
                return _f729.Value;
            }
        }
        private double? _f730;
        public double F730
        {
            get
            {
                //Debug.WriteLine("F730");
                if (_f730 == null)
                    _f730 = E730 * B585;
                return _f730.Value;
            }
        }
        private double? _f731;
        public double F731
        {
            get
            {
                //Debug.WriteLine("F731");
                if (_f731 == null)
                    _f731 = E731 * B585;
                return _f731.Value;
            }
        }
        private double? _f732;
        public double F732
        {
            get
            {
                //Debug.WriteLine("F732");
                if (_f732 == null)
                    _f732 = E732 * B585;
                return _f732.Value;
            }
        }
        private double? _f733;
        public double F733
        {
            get
            {
                //Debug.WriteLine("F733");
                if (_f733 == null)
                    _f733 = E733 * B585;
                return _f733.Value;
            }
        }
        private double? _f734;
        public double F734
        {
            get
            {
                //Debug.WriteLine("F734");
                if (_f734 == null)
                    _f734 = E734 * B585;
                return _f734.Value;
            }
        }
        private double? _f735;
        public double F735
        {
            get
            {
                //Debug.WriteLine("F735");
                if (_f735 == null)
                    _f735 = E735 * B585;
                return _f735.Value;
            }
        }
        private double? _f736;
        public double F736
        {
            get
            {
                //Debug.WriteLine("F736");
                if (_f736 == null)
                    _f736 = E736 * B585;
                return _f736.Value;
            }
        }
        private double? _f737;
        public double F737
        {
            get
            {
                //Debug.WriteLine("F737");
                if (_f737 == null)
                    _f737 = E737 * B585;
                return _f737.Value;
            }
        }
        private double? _f738;
        public double F738
        {
            get
            {
                //Debug.WriteLine("F738");
                if (_f738 == null)
                    _f738 = E738 * B585;
                return _f738.Value;
            }
        }
        private double? _f739;
        public double F739
        {
            get
            {
                //Debug.WriteLine("F739");
                if (_f739 == null)
                    _f739 = E739 * B585;
                return _f739.Value;
            }
        }
        private double? _f740;
        public double F740
        {
            get
            {
                //Debug.WriteLine("F740");
                if (_f740 == null)
                    _f740 = E740 * B585;
                return _f740.Value;
            }
        }
        private double? _f741;
        public double F741
        {
            get
            {
                //Debug.WriteLine("F741");
                if (_f741 == null)
                    _f741 = E741 * B585;
                return _f741.Value;
            }
        }
        private double? _f742;
        public double F742
        {
            get
            {
                //Debug.WriteLine("F742");
                if (_f742 == null)
                    _f742 = E742 * B585;
                return _f742.Value;
            }
        }
        private double? _f743;
        public double F743
        {
            get
            {
                //Debug.WriteLine("F743");
                if (_f743 == null)
                    _f743 = E743 * B585;
                return _f743.Value;
            }
        }
        private double? _f744;
        public double F744
        {
            get
            {
                //Debug.WriteLine("F744");
                if (_f744 == null)
                    _f744 = E744 * B585;
                return _f744.Value;
            }
        }
        private double? _f745;
        public double F745
        {
            get
            {
                //Debug.WriteLine("F745");
                if (_f745 == null)
                    _f745 = E745 * B585;
                return _f745.Value;
            }
        }
        private double? _f746;
        public double F746
        {
            get
            {
                //Debug.WriteLine("F746");
                if (_f746 == null)
                    _f746 = E746 * B585;
                return _f746.Value;
            }
        }
        private double? _f747;
        public double F747
        {
            get
            {
                //Debug.WriteLine("F747");
                if (_f747 == null)
                    _f747 = E747 * B585;
                return _f747.Value;
            }
        }
        private double? _f748;
        public double F748
        {
            get
            {
                //Debug.WriteLine("F748");
                if (_f748 == null)
                    _f748 = E748 * B585;
                return _f748.Value;
            }
        }
        private double? _f749;
        public double F749
        {
            get
            {
                //Debug.WriteLine("F749");
                if (_f749 == null)
                    _f749 = E749 * B585;
                return _f749.Value;
            }
        }
        private double? _f750;
        public double F750
        {
            get
            {
                //Debug.WriteLine("F750");
                if (_f750 == null)
                    _f750 = E750 * B585;
                return _f750.Value;
            }
        }
        private double? _f751;
        public double F751
        {
            get
            {
                //Debug.WriteLine("F751");
                if (_f751 == null)
                    _f751 = E751 * B585;
                return _f751.Value;
            }
        }
        private double? _f752;
        public double F752
        {
            get
            {
                //Debug.WriteLine("F752");
                if (_f752 == null)
                    _f752 = E752 * B585;
                return _f752.Value;
            }
        }
        private double? _f753;
        public double F753
        {
            get
            {
                //Debug.WriteLine("F753");
                if (_f753 == null)
                    _f753 = E753 * B585;
                return _f753.Value;
            }
        }
        private double? _f754;
        public double F754
        {
            get
            {
                //Debug.WriteLine("F754");
                if (_f754 == null)
                    _f754 = E754 * B585;
                return _f754.Value;
            }
        }
        private double? _f755;
        public double F755
        {
            get
            {
                //Debug.WriteLine("F755");
                if (_f755 == null)
                    _f755 = E755 * B585;
                return _f755.Value;
            }
        }
        private double? _f756;
        public double F756
        {
            get
            {
                //Debug.WriteLine("F756");
                if (_f756 == null)
                    _f756 = E756 * B585;
                return _f756.Value;
            }
        }
        private double? _f757;
        public double F757
        {
            get
            {
                //Debug.WriteLine("F757");
                if (_f757 == null)
                    _f757 = E757 * B585;
                return _f757.Value;
            }
        }
        private double? _f758;
        public double F758
        {
            get
            {
                //Debug.WriteLine("F758");
                if (_f758 == null)
                    _f758 = E758 * B585;
                return _f758.Value;
            }
        }
        private double? _f759;
        public double F759
        {
            get
            {
                //Debug.WriteLine("F759");
                if (_f759 == null)
                    _f759 = E759 * B585;
                return _f759.Value;
            }
        }
        private double? _f760;
        public double F760
        {
            get
            {
                //Debug.WriteLine("F760");
                if (_f760 == null)
                    _f760 = E760 * B585;
                return _f760.Value;
            }
        }
        private double? _f761;
        public double F761
        {
            get
            {
                //Debug.WriteLine("F761");
                if (_f761 == null)
                    _f761 = E761 * B585;
                return _f761.Value;
            }
        }
        private double? _f762;
        public double F762
        {
            get
            {
                //Debug.WriteLine("F762");
                if (_f762 == null)
                    _f762 = E762 * B585;
                return _f762.Value;
            }
        }
        private double? _f763;
        public double F763
        {
            get
            {
                //Debug.WriteLine("F763");
                if (_f763 == null)
                    _f763 = E763 * B585;
                return _f763.Value;
            }
        }
        private double? _f764;
        public double F764
        {
            get
            {
                //Debug.WriteLine("F764");
                if (_f764 == null)
                    _f764 = E764 * B585;
                return _f764.Value;
            }
        }
        private double? _f765;
        public double F765
        {
            get
            {
                //Debug.WriteLine("F765");
                if (_f765 == null)
                    _f765 = E765 * B585;
                return _f765.Value;
            }
        }
        private double? _f766;
        public double F766
        {
            get
            {
                //Debug.WriteLine("F766");
                if (_f766 == null)
                    _f766 = E766 * B585;
                return _f766.Value;
            }
        }
        private double? _f767;
        public double F767
        {
            get
            {
                //Debug.WriteLine("F767");
                if (_f767 == null)
                    _f767 = E767 * B585;
                return _f767.Value;
            }
        }
        private double? _f768;
        public double F768
        {
            get
            {
                //Debug.WriteLine("F768");
                if (_f768 == null)
                    _f768 = E768 * B585;
                return _f768.Value;
            }
        }
        private double? _f769;
        public double F769
        {
            get
            {
                //Debug.WriteLine("F769");
                if (_f769 == null)
                    _f769 = E769 * B585;
                return _f769.Value;
            }
        }
        private double? _f770;
        public double F770
        {
            get
            {
                //Debug.WriteLine("F770");
                if (_f770 == null)
                    _f770 = E770 * B585;
                return _f770.Value;
            }
        }
        private double? _f771;
        public double F771
        {
            get
            {
                //Debug.WriteLine("F771");
                if (_f771 == null)
                    _f771 = E771 * B585;
                return _f771.Value;
            }
        }
        private double? _f772;
        public double F772
        {
            get
            {
                //Debug.WriteLine("F772");
                if (_f772 == null)
                    _f772 = E772 * B585;
                return _f772.Value;
            }
        }
        private double? _f773;
        public double F773
        {
            get
            {
                //Debug.WriteLine("F773");
                if (_f773 == null)
                    _f773 = E773 * B585;
                return _f773.Value;
            }
        }
        private double? _f774;
        public double F774
        {
            get
            {
                //Debug.WriteLine("F774");
                if (_f774 == null)
                    _f774 = E774 * B585;
                return _f774.Value;
            }
        }
        private double? _f775;
        public double F775
        {
            get
            {
                //Debug.WriteLine("F775");
                if (_f775 == null)
                    _f775 = E775 * B585;
                return _f775.Value;
            }
        }
        private double? _f776;
        public double F776
        {
            get
            {
                //Debug.WriteLine("F776");
                if (_f776 == null)
                    _f776 = E776 * B585;
                return _f776.Value;
            }
        }
        private double? _f777;
        public double F777
        {
            get
            {
                //Debug.WriteLine("F777");
                if (_f777 == null)
                    _f777 = E777 * B585;
                return _f777.Value;
            }
        }
        private double? _f778;
        public double F778
        {
            get
            {
                //Debug.WriteLine("F778");
                if (_f778 == null)
                    _f778 = E778 * B585;
                return _f778.Value;
            }
        }
        private double? _f779;
        public double F779
        {
            get
            {
                //Debug.WriteLine("F779");
                if (_f779 == null)
                    _f779 = E779 * B585;
                return _f779.Value;
            }
        }
        private double? _f780;
        public double F780
        {
            get
            {
                //Debug.WriteLine("F780");
                if (_f780 == null)
                    _f780 = E780 * B585;
                return _f780.Value;
            }
        }
        private double? _f781;
        public double F781
        {
            get
            {
                //Debug.WriteLine("F781");
                if (_f781 == null)
                    _f781 = E781 * B585;
                return _f781.Value;
            }
        }
        private double? _f782;
        public double F782
        {
            get
            {
                //Debug.WriteLine("F782");
                if (_f782 == null)
                    _f782 = E782 * B585;
                return _f782.Value;
            }
        }
        private double? _f783;
        public double F783
        {
            get
            {
                //Debug.WriteLine("F783");
                if (_f783 == null)
                    _f783 = E783 * B585;
                return _f783.Value;
            }
        }
        private double? _f784;
        public double F784
        {
            get
            {
                //Debug.WriteLine("F784");
                if (_f784 == null)
                    _f784 = E784 * B585;
                return _f784.Value;
            }
        }
        private double? _f785;
        public double F785
        {
            get
            {
                //Debug.WriteLine("F785");
                if (_f785 == null)
                    _f785 = E785 * B585;
                return _f785.Value;
            }
        }
        private double? _f786;
        public double F786
        {
            get
            {
                //Debug.WriteLine("F786");
                if (_f786 == null)
                    _f786 = E786 * B585;
                return _f786.Value;
            }
        }
        private double? _f787;
        public double F787
        {
            get
            {
                //Debug.WriteLine("F787");
                if (_f787 == null)
                    _f787 = E787 * B585;
                return _f787.Value;
            }
        }
        private double? _f788;
        public double F788
        {
            get
            {
                //Debug.WriteLine("F788");
                if (_f788 == null)
                    _f788 = E788 * B585;
                return _f788.Value;
            }
        }
        private double? _f789;
        public double F789
        {
            get
            {
                //Debug.WriteLine("F789");
                if (_f789 == null)
                    _f789 = E789 * B585;
                return _f789.Value;
            }
        }
        private double? _f790;
        public double F790
        {
            get
            {
                //Debug.WriteLine("F790");
                if (_f790 == null)
                    _f790 = E790 * B585;
                return _f790.Value;
            }
        }
        private double? _f791;
        public double F791
        {
            get
            {
                //Debug.WriteLine("F791");
                if (_f791 == null)
                    _f791 = E791 * B585;
                return _f791.Value;
            }
        }
        private double? _f792;
        public double F792
        {
            get
            {
                //Debug.WriteLine("F792");
                if (_f792 == null)
                    _f792 = E792 * B585;
                return _f792.Value;
            }
        }
        private double? _f793;
        public double F793
        {
            get
            {
                //Debug.WriteLine("F793");
                if (_f793 == null)
                    _f793 = E793 * B585;
                return _f793.Value;
            }
        }
        private double? _f794;
        public double F794
        {
            get
            {
                //Debug.WriteLine("F794");
                if (_f794 == null)
                    _f794 = E794 * B585;
                return _f794.Value;
            }
        }
        private double? _f795;
        public double F795
        {
            get
            {
                //Debug.WriteLine("F795");
                if (_f795 == null)
                    _f795 = E795 * B585;
                return _f795.Value;
            }
        }
        private double? _f796;
        public double F796
        {
            get
            {
                //Debug.WriteLine("F796");
                if (_f796 == null)
                    _f796 = E796 * B585;
                return _f796.Value;
            }
        }
        private double? _f797;
        public double F797
        {
            get
            {
                //Debug.WriteLine("F797");
                if (_f797 == null)
                    _f797 = E797 * B585;
                return _f797.Value;
            }
        }
        private double? _f798;
        public double F798
        {
            get
            {
                //Debug.WriteLine("F798");
                if (_f798 == null)
                    _f798 = E798 * B585;
                return _f798.Value;
            }
        }
        private double? _f799;
        public double F799
        {
            get
            {
                //Debug.WriteLine("F799");
                if (_f799 == null)
                    _f799 = E799 * B585;
                return _f799.Value;
            }
        }
        private double? _f800;
        public double F800
        {
            get
            {
                //Debug.WriteLine("F800");
                if (_f800 == null)
                    _f800 = E800 * B585;
                return _f800.Value;
            }
        }
        private double? _f801;
        public double F801
        {
            get
            {
                //Debug.WriteLine("F801");
                if (_f801 == null)
                    _f801 = E801 * B585;
                return _f801.Value;
            }
        }
        private double? _f802;
        public double F802
        {
            get
            {
                //Debug.WriteLine("F802");
                if (_f802 == null)
                    _f802 = E802 * B585;
                return _f802.Value;
            }
        }
        private double? _f803;
        public double F803
        {
            get
            {
                //Debug.WriteLine("F803");
                if (_f803 == null)
                    _f803 = E803 * B585;
                return _f803.Value;
            }
        }
        private double? _f804;
        public double F804
        {
            get
            {
                //Debug.WriteLine("F804");
                if (_f804 == null)
                    _f804 = E804 * B585;
                return _f804.Value;
            }
        }
        private double? _f805;
        public double F805
        {
            get
            {
                //Debug.WriteLine("F805");
                if (_f805 == null)
                    _f805 = E805 * B585;
                return _f805.Value;
            }
        }
        private double? _f806;
        public double F806
        {
            get
            {
                //Debug.WriteLine("F806");
                if (_f806 == null)
                    _f806 = E806 * B585;
                return _f806.Value;
            }
        }
        private double? _f807;
        public double F807
        {
            get
            {
                //Debug.WriteLine("F807");
                if (_f807 == null)
                    _f807 = E807 * B585;
                return _f807.Value;
            }
        }

        private double? _i607;
        public double I607
        {
            get
            {
                //Debug.WriteLine("I607");
                if (_i607 == null)
                    _i607 = (B3 == Position.Vertical ? (A607 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A607 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i607.Value;
            }
        }
        private double? _i608;
        public double I608
        {
            get
            {
                //Debug.WriteLine("I608");
                if (_i608 == null)
                    _i608 = (B3 == Position.Vertical ? (A608 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A608 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i608.Value;
            }
        }
        private double? _i609;
        public double I609
        {
            get
            {
                //Debug.WriteLine("I609");
                if (_i609 == null)
                    _i609 = (B3 == Position.Vertical ? (A609 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A609 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i609.Value;
            }
        }
        private double? _i610;
        public double I610
        {
            get
            {
                //Debug.WriteLine("I610");
                if (_i610 == null)
                    _i610 = (B3 == Position.Vertical ? (A610 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A610 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i610.Value;
            }
        }
        private double? _i611;
        public double I611
        {
            get
            {
                //Debug.WriteLine("I611");
                if (_i611 == null)
                    _i611 = (B3 == Position.Vertical ? (A611 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A611 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i611.Value;
            }
        }
        private double? _i612;
        public double I612
        {
            get
            {
                //Debug.WriteLine("I612");
                if (_i612 == null)
                    _i612 = (B3 == Position.Vertical ? (A612 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A612 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i612.Value;
            }
        }
        private double? _i613;
        public double I613
        {
            get
            {
                //Debug.WriteLine("I613");
                if (_i613 == null)
                    _i613 = (B3 == Position.Vertical ? (A613 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A613 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i613.Value;
            }
        }
        private double? _i614;
        public double I614
        {
            get
            {
                //Debug.WriteLine("I614");
                if (_i614 == null)
                    _i614 = (B3 == Position.Vertical ? (A614 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A614 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i614.Value;
            }
        }
        private double? _i615;
        public double I615
        {
            get
            {
                //Debug.WriteLine("I615");
                if (_i615 == null)
                    _i615 = (B3 == Position.Vertical ? (A615 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A615 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i615.Value;
            }
        }
        private double? _i616;
        public double I616
        {
            get
            {
                //Debug.WriteLine("I616");
                if (_i616 == null)
                    _i616 = (B3 == Position.Vertical ? (A616 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A616 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i616.Value;
            }
        }
        private double? _i617;
        public double I617
        {
            get
            {
                //Debug.WriteLine("I617");
                if (_i617 == null)
                    _i617 = (B3 == Position.Vertical ? (A617 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A617 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i617.Value;
            }
        }
        private double? _i618;
        public double I618
        {
            get
            {
                //Debug.WriteLine("I618");
                if (_i618 == null)
                    _i618 = (B3 == Position.Vertical ? (A618 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A618 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i618.Value;
            }
        }
        private double? _i619;
        public double I619
        {
            get
            {
                //Debug.WriteLine("I619");
                if (_i619 == null)
                    _i619 = (B3 == Position.Vertical ? (A619 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A619 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i619.Value;
            }
        }
        private double? _i620;
        public double I620
        {
            get
            {
                //Debug.WriteLine("I620");
                if (_i620 == null)
                    _i620 = (B3 == Position.Vertical ? (A620 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A620 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i620.Value;
            }
        }
        private double? _i621;
        public double I621
        {
            get
            {
                //Debug.WriteLine("I621");
                if (_i621 == null)
                    _i621 = (B3 == Position.Vertical ? (A621 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A621 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i621.Value;
            }
        }
        private double? _i622;
        public double I622
        {
            get
            {
                //Debug.WriteLine("I622");
                if (_i622 == null)
                    _i622 = (B3 == Position.Vertical ? (A622 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A622 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i622.Value;
            }
        }
        private double? _i623;
        public double I623
        {
            get
            {
                //Debug.WriteLine("I623");
                if (_i623 == null)
                    _i623 = (B3 == Position.Vertical ? (A623 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A623 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i623.Value;
            }
        }
        private double? _i624;
        public double I624
        {
            get
            {
                //Debug.WriteLine("I624");
                if (_i624 == null)
                    _i624 = (B3 == Position.Vertical ? (A624 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A624 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i624.Value;
            }
        }
        private double? _i625;
        public double I625
        {
            get
            {
                //Debug.WriteLine("I625");
                if (_i625 == null)
                    _i625 = (B3 == Position.Vertical ? (A625 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A625 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i625.Value;
            }
        }
        private double? _i626;
        public double I626
        {
            get
            {
                //Debug.WriteLine("I626");
                if (_i626 == null)
                    _i626 = (B3 == Position.Vertical ? (A626 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A626 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i626.Value;
            }
        }
        private double? _i627;
        public double I627
        {
            get
            {
                //Debug.WriteLine("I627");
                if (_i627 == null)
                    _i627 = (B3 == Position.Vertical ? (A627 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A627 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i627.Value;
            }
        }
        private double? _i628;
        public double I628
        {
            get
            {
                //Debug.WriteLine("I628");
                if (_i628 == null)
                    _i628 = (B3 == Position.Vertical ? (A628 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A628 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i628.Value;
            }
        }
        private double? _i629;
        public double I629
        {
            get
            {
                //Debug.WriteLine("I629");
                if (_i629 == null)
                    _i629 = (B3 == Position.Vertical ? (A629 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A629 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i629.Value;
            }
        }
        private double? _i630;
        public double I630
        {
            get
            {
                //Debug.WriteLine("I630");
                if (_i630 == null)
                    _i630 = (B3 == Position.Vertical ? (A630 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A630 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i630.Value;
            }
        }
        private double? _i631;
        public double I631
        {
            get
            {
                //Debug.WriteLine("I631");
                if (_i631 == null)
                    _i631 = (B3 == Position.Vertical ? (A631 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A631 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i631.Value;
            }
        }
        private double? _i632;
        public double I632
        {
            get
            {
                //Debug.WriteLine("I632");
                if (_i632 == null)
                    _i632 = (B3 == Position.Vertical ? (A632 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A632 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i632.Value;
            }
        }
        private double? _i633;
        public double I633
        {
            get
            {
                //Debug.WriteLine("I633");
                if (_i633 == null)
                    _i633 = (B3 == Position.Vertical ? (A633 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A633 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i633.Value;
            }
        }
        private double? _i634;
        public double I634
        {
            get
            {
                //Debug.WriteLine("I634");
                if (_i634 == null)
                    _i634 = (B3 == Position.Vertical ? (A634 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A634 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i634.Value;
            }
        }
        private double? _i635;
        public double I635
        {
            get
            {
                //Debug.WriteLine("I635");
                if (_i635 == null)
                    _i635 = (B3 == Position.Vertical ? (A635 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A635 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i635.Value;
            }
        }
        private double? _i636;
        public double I636
        {
            get
            {
                //Debug.WriteLine("I636");
                if (_i636 == null)
                    _i636 = (B3 == Position.Vertical ? (A636 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A636 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i636.Value;
            }
        }
        private double? _i637;
        public double I637
        {
            get
            {
                //Debug.WriteLine("I637");
                if (_i637 == null)
                    _i637 = (B3 == Position.Vertical ? (A637 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A637 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i637.Value;
            }
        }
        private double? _i638;
        public double I638
        {
            get
            {
                //Debug.WriteLine("I638");
                if (_i638 == null)
                    _i638 = (B3 == Position.Vertical ? (A638 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A638 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i638.Value;
            }
        }
        private double? _i639;
        public double I639
        {
            get
            {
                //Debug.WriteLine("I639");
                if (_i639 == null)
                    _i639 = (B3 == Position.Vertical ? (A639 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A639 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i639.Value;
            }
        }
        private double? _i640;
        public double I640
        {
            get
            {
                //Debug.WriteLine("I640");
                if (_i640 == null)
                    _i640 = (B3 == Position.Vertical ? (A640 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A640 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i640.Value;
            }
        }
        private double? _i641;
        public double I641
        {
            get
            {
                //Debug.WriteLine("I641");
                if (_i641 == null)
                    _i641 = (B3 == Position.Vertical ? (A641 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A641 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i641.Value;
            }
        }
        private double? _i642;
        public double I642
        {
            get
            {
                //Debug.WriteLine("I642");
                if (_i642 == null)
                    _i642 = (B3 == Position.Vertical ? (A642 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A642 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i642.Value;
            }
        }
        private double? _i643;
        public double I643
        {
            get
            {
                //Debug.WriteLine("I643");
                if (_i643 == null)
                    _i643 = (B3 == Position.Vertical ? (A643 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A643 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i643.Value;
            }
        }
        private double? _i644;
        public double I644
        {
            get
            {
                //Debug.WriteLine("I644");
                if (_i644 == null)
                    _i644 = (B3 == Position.Vertical ? (A644 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A644 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i644.Value;
            }
        }
        private double? _i645;
        public double I645
        {
            get
            {
                //Debug.WriteLine("I645");
                if (_i645 == null)
                    _i645 = (B3 == Position.Vertical ? (A645 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A645 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i645.Value;
            }
        }
        private double? _i646;
        public double I646
        {
            get
            {
                //Debug.WriteLine("I646");
                if (_i646 == null)
                    _i646 = (B3 == Position.Vertical ? (A646 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A646 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i646.Value;
            }
        }
        private double? _i647;
        public double I647
        {
            get
            {
                //Debug.WriteLine("I647");
                if (_i647 == null)
                    _i647 = (B3 == Position.Vertical ? (A647 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A647 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i647.Value;
            }
        }
        private double? _i648;
        public double I648
        {
            get
            {
                //Debug.WriteLine("I648");
                if (_i648 == null)
                    _i648 = (B3 == Position.Vertical ? (A648 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A648 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i648.Value;
            }
        }
        private double? _i649;
        public double I649
        {
            get
            {
                //Debug.WriteLine("I649");
                if (_i649 == null)
                    _i649 = (B3 == Position.Vertical ? (A649 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A649 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i649.Value;
            }
        }
        private double? _i650;
        public double I650
        {
            get
            {
                //Debug.WriteLine("I650");
                if (_i650 == null)
                    _i650 = (B3 == Position.Vertical ? (A650 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A650 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i650.Value;
            }
        }
        private double? _i651;
        public double I651
        {
            get
            {
                //Debug.WriteLine("I651");
                if (_i651 == null)
                    _i651 = (B3 == Position.Vertical ? (A651 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A651 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i651.Value;
            }
        }
        private double? _i652;
        public double I652
        {
            get
            {
                //Debug.WriteLine("I652");
                if (_i652 == null)
                    _i652 = (B3 == Position.Vertical ? (A652 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A652 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i652.Value;
            }
        }
        private double? _i653;
        public double I653
        {
            get
            {
                //Debug.WriteLine("I653");
                if (_i653 == null)
                    _i653 = (B3 == Position.Vertical ? (A653 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A653 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i653.Value;
            }
        }
        private double? _i654;
        public double I654
        {
            get
            {
                //Debug.WriteLine("I654");
                if (_i654 == null)
                    _i654 = (B3 == Position.Vertical ? (A654 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A654 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i654.Value;
            }
        }
        private double? _i655;
        public double I655
        {
            get
            {
                //Debug.WriteLine("I655");
                if (_i655 == null)
                    _i655 = (B3 == Position.Vertical ? (A655 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A655 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i655.Value;
            }
        }
        private double? _i656;
        public double I656
        {
            get
            {
                //Debug.WriteLine("I656");
                if (_i656 == null)
                    _i656 = (B3 == Position.Vertical ? (A656 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A656 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i656.Value;
            }
        }
        private double? _i657;
        public double I657
        {
            get
            {
                //Debug.WriteLine("I657");
                if (_i657 == null)
                    _i657 = (B3 == Position.Vertical ? (A657 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A657 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i657.Value;
            }
        }
        private double? _i658;
        public double I658
        {
            get
            {
                //Debug.WriteLine("I658");
                if (_i658 == null)
                    _i658 = (B3 == Position.Vertical ? (A658 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A658 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i658.Value;
            }
        }
        private double? _i659;
        public double I659
        {
            get
            {
                //Debug.WriteLine("I659");
                if (_i659 == null)
                    _i659 = (B3 == Position.Vertical ? (A659 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A659 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i659.Value;
            }
        }
        private double? _i660;
        public double I660
        {
            get
            {
                //Debug.WriteLine("I660");
                if (_i660 == null)
                    _i660 = (B3 == Position.Vertical ? (A660 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A660 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i660.Value;
            }
        }
        private double? _i661;
        public double I661
        {
            get
            {
                //Debug.WriteLine("I661");
                if (_i661 == null)
                    _i661 = (B3 == Position.Vertical ? (A661 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A661 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i661.Value;
            }
        }
        private double? _i662;
        public double I662
        {
            get
            {
                //Debug.WriteLine("I662");
                if (_i662 == null)
                    _i662 = (B3 == Position.Vertical ? (A662 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A662 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i662.Value;
            }
        }
        private double? _i663;
        public double I663
        {
            get
            {
                //Debug.WriteLine("I663");
                if (_i663 == null)
                    _i663 = (B3 == Position.Vertical ? (A663 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A663 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i663.Value;
            }
        }
        private double? _i664;
        public double I664
        {
            get
            {
                //Debug.WriteLine("I664");
                if (_i664 == null)
                    _i664 = (B3 == Position.Vertical ? (A664 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A664 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i664.Value;
            }
        }
        private double? _i665;
        public double I665
        {
            get
            {
                //Debug.WriteLine("I665");
                if (_i665 == null)
                    _i665 = (B3 == Position.Vertical ? (A665 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A665 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i665.Value;
            }
        }
        private double? _i666;
        public double I666
        {
            get
            {
                //Debug.WriteLine("I666");
                if (_i666 == null)
                    _i666 = (B3 == Position.Vertical ? (A666 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A666 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i666.Value;
            }
        }
        private double? _i667;
        public double I667
        {
            get
            {
                //Debug.WriteLine("I667");
                if (_i667 == null)
                    _i667 = (B3 == Position.Vertical ? (A667 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A667 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i667.Value;
            }
        }
        private double? _i668;
        public double I668
        {
            get
            {
                //Debug.WriteLine("I668");
                if (_i668 == null)
                    _i668 = (B3 == Position.Vertical ? (A668 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A668 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i668.Value;
            }
        }
        private double? _i669;
        public double I669
        {
            get
            {
                //Debug.WriteLine("I669");
                if (_i669 == null)
                    _i669 = (B3 == Position.Vertical ? (A669 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A669 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i669.Value;
            }
        }
        private double? _i670;
        public double I670
        {
            get
            {
                //Debug.WriteLine("I670");
                if (_i670 == null)
                    _i670 = (B3 == Position.Vertical ? (A670 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A670 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i670.Value;
            }
        }
        private double? _i671;
        public double I671
        {
            get
            {
                //Debug.WriteLine("I671");
                if (_i671 == null)
                    _i671 = (B3 == Position.Vertical ? (A671 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A671 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i671.Value;
            }
        }
        private double? _i672;
        public double I672
        {
            get
            {
                //Debug.WriteLine("I672");
                if (_i672 == null)
                    _i672 = (B3 == Position.Vertical ? (A672 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A672 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i672.Value;
            }
        }
        private double? _i673;
        public double I673
        {
            get
            {
                //Debug.WriteLine("I673");
                if (_i673 == null)
                    _i673 = (B3 == Position.Vertical ? (A673 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A673 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i673.Value;
            }
        }
        private double? _i674;
        public double I674
        {
            get
            {
                //Debug.WriteLine("I674");
                if (_i674 == null)
                    _i674 = (B3 == Position.Vertical ? (A674 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A674 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i674.Value;
            }
        }
        private double? _i675;
        public double I675
        {
            get
            {
                //Debug.WriteLine("I675");
                if (_i675 == null)
                    _i675 = (B3 == Position.Vertical ? (A675 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A675 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i675.Value;
            }
        }
        private double? _i676;
        public double I676
        {
            get
            {
                //Debug.WriteLine("I676");
                if (_i676 == null)
                    _i676 = (B3 == Position.Vertical ? (A676 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A676 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i676.Value;
            }
        }
        private double? _i677;
        public double I677
        {
            get
            {
                //Debug.WriteLine("I677");
                if (_i677 == null)
                    _i677 = (B3 == Position.Vertical ? (A677 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A677 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i677.Value;
            }
        }
        private double? _i678;
        public double I678
        {
            get
            {
                //Debug.WriteLine("I678");
                if (_i678 == null)
                    _i678 = (B3 == Position.Vertical ? (A678 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A678 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i678.Value;
            }
        }
        private double? _i679;
        public double I679
        {
            get
            {
                //Debug.WriteLine("I679");
                if (_i679 == null)
                    _i679 = (B3 == Position.Vertical ? (A679 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A679 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i679.Value;
            }
        }
        private double? _i680;
        public double I680
        {
            get
            {
                //Debug.WriteLine("I680");
                if (_i680 == null)
                    _i680 = (B3 == Position.Vertical ? (A680 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A680 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i680.Value;
            }
        }
        private double? _i681;
        public double I681
        {
            get
            {
                //Debug.WriteLine("I681");
                if (_i681 == null)
                    _i681 = (B3 == Position.Vertical ? (A681 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A681 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i681.Value;
            }
        }
        private double? _i682;
        public double I682
        {
            get
            {
                //Debug.WriteLine("I682");
                if (_i682 == null)
                    _i682 = (B3 == Position.Vertical ? (A682 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A682 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i682.Value;
            }
        }
        private double? _i683;
        public double I683
        {
            get
            {
                //Debug.WriteLine("I683");
                if (_i683 == null)
                    _i683 = (B3 == Position.Vertical ? (A683 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A683 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i683.Value;
            }
        }
        private double? _i684;
        public double I684
        {
            get
            {
                //Debug.WriteLine("I684");
                if (_i684 == null)
                    _i684 = (B3 == Position.Vertical ? (A684 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A684 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i684.Value;
            }
        }
        private double? _i685;
        public double I685
        {
            get
            {
                //Debug.WriteLine("I685");
                if (_i685 == null)
                    _i685 = (B3 == Position.Vertical ? (A685 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A685 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i685.Value;
            }
        }
        private double? _i686;
        public double I686
        {
            get
            {
                //Debug.WriteLine("I686");
                if (_i686 == null)
                    _i686 = (B3 == Position.Vertical ? (A686 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A686 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i686.Value;
            }
        }
        private double? _i687;
        public double I687
        {
            get
            {
                //Debug.WriteLine("I687");
                if (_i687 == null)
                    _i687 = (B3 == Position.Vertical ? (A687 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A687 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i687.Value;
            }
        }
        private double? _i688;
        public double I688
        {
            get
            {
                //Debug.WriteLine("I688");
                if (_i688 == null)
                    _i688 = (B3 == Position.Vertical ? (A688 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A688 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i688.Value;
            }
        }
        private double? _i689;
        public double I689
        {
            get
            {
                //Debug.WriteLine("I689");
                if (_i689 == null)
                    _i689 = (B3 == Position.Vertical ? (A689 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A689 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i689.Value;
            }
        }
        private double? _i690;
        public double I690
        {
            get
            {
                //Debug.WriteLine("I690");
                if (_i690 == null)
                    _i690 = (B3 == Position.Vertical ? (A690 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A690 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i690.Value;
            }
        }
        private double? _i691;
        public double I691
        {
            get
            {
                //Debug.WriteLine("I691");
                if (_i691 == null)
                    _i691 = (B3 == Position.Vertical ? (A691 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A691 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i691.Value;
            }
        }
        private double? _i692;
        public double I692
        {
            get
            {
                //Debug.WriteLine("I692");
                if (_i692 == null)
                    _i692 = (B3 == Position.Vertical ? (A692 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A692 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i692.Value;
            }
        }
        private double? _i693;
        public double I693
        {
            get
            {
                //Debug.WriteLine("I693");
                if (_i693 == null)
                    _i693 = (B3 == Position.Vertical ? (A693 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A693 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i693.Value;
            }
        }
        private double? _i694;
        public double I694
        {
            get
            {
                //Debug.WriteLine("I694");
                if (_i694 == null)
                    _i694 = (B3 == Position.Vertical ? (A694 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A694 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i694.Value;
            }
        }
        private double? _i695;
        public double I695
        {
            get
            {
                //Debug.WriteLine("I695");
                if (_i695 == null)
                    _i695 = (B3 == Position.Vertical ? (A695 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A695 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i695.Value;
            }
        }
        private double? _i696;
        public double I696
        {
            get
            {
                //Debug.WriteLine("I696");
                if (_i696 == null)
                    _i696 = (B3 == Position.Vertical ? (A696 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A696 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i696.Value;
            }
        }
        private double? _i697;
        public double I697
        {
            get
            {
                //Debug.WriteLine("I697");
                if (_i697 == null)
                    _i697 = (B3 == Position.Vertical ? (A697 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A697 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i697.Value;
            }
        }
        private double? _i698;
        public double I698
        {
            get
            {
                //Debug.WriteLine("I698");
                if (_i698 == null)
                    _i698 = (B3 == Position.Vertical ? (A698 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A698 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i698.Value;
            }
        }
        private double? _i699;
        public double I699
        {
            get
            {
                //Debug.WriteLine("I699");
                if (_i699 == null)
                    _i699 = (B3 == Position.Vertical ? (A699 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A699 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i699.Value;
            }
        }
        private double? _i700;
        public double I700
        {
            get
            {
                //Debug.WriteLine("I700");
                if (_i700 == null)
                    _i700 = (B3 == Position.Vertical ? (A700 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A700 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i700.Value;
            }
        }
        private double? _i701;
        public double I701
        {
            get
            {
                //Debug.WriteLine("I701");
                if (_i701 == null)
                    _i701 = (B3 == Position.Vertical ? (A701 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A701 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i701.Value;
            }
        }
        private double? _i702;
        public double I702
        {
            get
            {
                //Debug.WriteLine("I702");
                if (_i702 == null)
                    _i702 = (B3 == Position.Vertical ? (A702 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A702 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i702.Value;
            }
        }
        private double? _i703;
        public double I703
        {
            get
            {
                //Debug.WriteLine("I703");
                if (_i703 == null)
                    _i703 = (B3 == Position.Vertical ? (A703 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A703 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i703.Value;
            }
        }
        private double? _i704;
        public double I704
        {
            get
            {
                //Debug.WriteLine("I704");
                if (_i704 == null)
                    _i704 = (B3 == Position.Vertical ? (A704 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A704 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i704.Value;
            }
        }
        private double? _i705;
        public double I705
        {
            get
            {
                //Debug.WriteLine("I705");
                if (_i705 == null)
                    _i705 = (B3 == Position.Vertical ? (A705 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A705 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i705.Value;
            }
        }
        private double? _i706;
        public double I706
        {
            get
            {
                //Debug.WriteLine("I706");
                if (_i706 == null)
                    _i706 = (B3 == Position.Vertical ? (A706 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A706 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i706.Value;
            }
        }
        private double? _i707;
        public double I707
        {
            get
            {
                //Debug.WriteLine("I707");
                if (_i707 == null)
                    _i707 = (B3 == Position.Vertical ? (A707 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A707 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i707.Value;
            }
        }
        private double? _i708;
        public double I708
        {
            get
            {
                //Debug.WriteLine("I708");
                if (_i708 == null)
                    _i708 = (B3 == Position.Vertical ? (A708 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A708 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i708.Value;
            }
        }
        private double? _i709;
        public double I709
        {
            get
            {
                //Debug.WriteLine("I709");
                if (_i709 == null)
                    _i709 = (B3 == Position.Vertical ? (A709 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A709 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i709.Value;
            }
        }
        private double? _i710;
        public double I710
        {
            get
            {
                //Debug.WriteLine("I710");
                if (_i710 == null)
                    _i710 = (B3 == Position.Vertical ? (A710 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A710 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i710.Value;
            }
        }
        private double? _i711;
        public double I711
        {
            get
            {
                //Debug.WriteLine("I711");
                if (_i711 == null)
                    _i711 = (B3 == Position.Vertical ? (A711 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A711 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i711.Value;
            }
        }
        private double? _i712;
        public double I712
        {
            get
            {
                //Debug.WriteLine("I712");
                if (_i712 == null)
                    _i712 = (B3 == Position.Vertical ? (A712 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A712 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i712.Value;
            }
        }
        private double? _i713;
        public double I713
        {
            get
            {
                //Debug.WriteLine("I713");
                if (_i713 == null)
                    _i713 = (B3 == Position.Vertical ? (A713 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A713 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i713.Value;
            }
        }
        private double? _i714;
        public double I714
        {
            get
            {
                //Debug.WriteLine("I714");
                if (_i714 == null)
                    _i714 = (B3 == Position.Vertical ? (A714 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A714 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i714.Value;
            }
        }
        private double? _i715;
        public double I715
        {
            get
            {
                //Debug.WriteLine("I715");
                if (_i715 == null)
                    _i715 = (B3 == Position.Vertical ? (A715 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A715 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i715.Value;
            }
        }
        private double? _i716;
        public double I716
        {
            get
            {
                //Debug.WriteLine("I716");
                if (_i716 == null)
                    _i716 = (B3 == Position.Vertical ? (A716 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A716 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i716.Value;
            }
        }
        private double? _i717;
        public double I717
        {
            get
            {
                //Debug.WriteLine("I717");
                if (_i717 == null)
                    _i717 = (B3 == Position.Vertical ? (A717 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A717 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i717.Value;
            }
        }
        private double? _i718;
        public double I718
        {
            get
            {
                //Debug.WriteLine("I718");
                if (_i718 == null)
                    _i718 = (B3 == Position.Vertical ? (A718 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A718 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i718.Value;
            }
        }
        private double? _i719;
        public double I719
        {
            get
            {
                //Debug.WriteLine("I719");
                if (_i719 == null)
                    _i719 = (B3 == Position.Vertical ? (A719 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A719 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i719.Value;
            }
        }
        private double? _i720;
        public double I720
        {
            get
            {
                //Debug.WriteLine("I720");
                if (_i720 == null)
                    _i720 = (B3 == Position.Vertical ? (A720 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A720 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i720.Value;
            }
        }
        private double? _i721;
        public double I721
        {
            get
            {
                //Debug.WriteLine("I721");
                if (_i721 == null)
                    _i721 = (B3 == Position.Vertical ? (A721 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A721 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i721.Value;
            }
        }
        private double? _i722;
        public double I722
        {
            get
            {
                //Debug.WriteLine("I722");
                if (_i722 == null)
                    _i722 = (B3 == Position.Vertical ? (A722 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A722 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i722.Value;
            }
        }
        private double? _i723;
        public double I723
        {
            get
            {
                //Debug.WriteLine("I723");
                if (_i723 == null)
                    _i723 = (B3 == Position.Vertical ? (A723 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A723 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i723.Value;
            }
        }
        private double? _i724;
        public double I724
        {
            get
            {
                //Debug.WriteLine("I724");
                if (_i724 == null)
                    _i724 = (B3 == Position.Vertical ? (A724 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A724 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i724.Value;
            }
        }
        private double? _i725;
        public double I725
        {
            get
            {
                //Debug.WriteLine("I725");
                if (_i725 == null)
                    _i725 = (B3 == Position.Vertical ? (A725 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A725 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i725.Value;
            }
        }
        private double? _i726;
        public double I726
        {
            get
            {
                //Debug.WriteLine("I726");
                if (_i726 == null)
                    _i726 = (B3 == Position.Vertical ? (A726 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A726 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i726.Value;
            }
        }
        private double? _i727;
        public double I727
        {
            get
            {
                //Debug.WriteLine("I727");
                if (_i727 == null)
                    _i727 = (B3 == Position.Vertical ? (A727 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A727 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i727.Value;
            }
        }
        private double? _i728;
        public double I728
        {
            get
            {
                //Debug.WriteLine("I728");
                if (_i728 == null)
                    _i728 = (B3 == Position.Vertical ? (A728 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A728 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i728.Value;
            }
        }
        private double? _i729;
        public double I729
        {
            get
            {
                //Debug.WriteLine("I729");
                if (_i729 == null)
                    _i729 = (B3 == Position.Vertical ? (A729 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A729 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i729.Value;
            }
        }
        private double? _i730;
        public double I730
        {
            get
            {
                //Debug.WriteLine("I730");
                if (_i730 == null)
                    _i730 = (B3 == Position.Vertical ? (A730 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A730 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i730.Value;
            }
        }
        private double? _i731;
        public double I731
        {
            get
            {
                //Debug.WriteLine("I731");
                if (_i731 == null)
                    _i731 = (B3 == Position.Vertical ? (A731 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A731 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i731.Value;
            }
        }
        private double? _i732;
        public double I732
        {
            get
            {
                //Debug.WriteLine("I732");
                if (_i732 == null)
                    _i732 = (B3 == Position.Vertical ? (A732 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A732 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i732.Value;
            }
        }
        private double? _i733;
        public double I733
        {
            get
            {
                //Debug.WriteLine("I733");
                if (_i733 == null)
                    _i733 = (B3 == Position.Vertical ? (A733 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A733 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i733.Value;
            }
        }
        private double? _i734;
        public double I734
        {
            get
            {
                //Debug.WriteLine("I734");
                if (_i734 == null)
                    _i734 = (B3 == Position.Vertical ? (A734 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A734 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i734.Value;
            }
        }
        private double? _i735;
        public double I735
        {
            get
            {
                //Debug.WriteLine("I735");
                if (_i735 == null)
                    _i735 = (B3 == Position.Vertical ? (A735 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A735 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i735.Value;
            }
        }
        private double? _i736;
        public double I736
        {
            get
            {
                //Debug.WriteLine("I736");
                if (_i736 == null)
                    _i736 = (B3 == Position.Vertical ? (A736 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A736 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i736.Value;
            }
        }
        private double? _i737;
        public double I737
        {
            get
            {
                //Debug.WriteLine("I737");
                if (_i737 == null)
                    _i737 = (B3 == Position.Vertical ? (A737 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A737 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i737.Value;
            }
        }
        private double? _i738;
        public double I738
        {
            get
            {
                //Debug.WriteLine("I738");
                if (_i738 == null)
                    _i738 = (B3 == Position.Vertical ? (A738 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A738 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i738.Value;
            }
        }
        private double? _i739;
        public double I739
        {
            get
            {
                //Debug.WriteLine("I739");
                if (_i739 == null)
                    _i739 = (B3 == Position.Vertical ? (A739 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A739 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i739.Value;
            }
        }
        private double? _i740;
        public double I740
        {
            get
            {
                //Debug.WriteLine("I740");
                if (_i740 == null)
                    _i740 = (B3 == Position.Vertical ? (A740 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A740 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i740.Value;
            }
        }
        private double? _i741;
        public double I741
        {
            get
            {
                //Debug.WriteLine("I741");
                if (_i741 == null)
                    _i741 = (B3 == Position.Vertical ? (A741 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A741 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i741.Value;
            }
        }
        private double? _i742;
        public double I742
        {
            get
            {
                //Debug.WriteLine("I742");
                if (_i742 == null)
                    _i742 = (B3 == Position.Vertical ? (A742 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A742 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i742.Value;
            }
        }
        private double? _i743;
        public double I743
        {
            get
            {
                //Debug.WriteLine("I743");
                if (_i743 == null)
                    _i743 = (B3 == Position.Vertical ? (A743 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A743 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i743.Value;
            }
        }
        private double? _i744;
        public double I744
        {
            get
            {
                //Debug.WriteLine("I744");
                if (_i744 == null)
                    _i744 = (B3 == Position.Vertical ? (A744 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A744 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i744.Value;
            }
        }
        private double? _i745;
        public double I745
        {
            get
            {
                //Debug.WriteLine("I745");
                if (_i745 == null)
                    _i745 = (B3 == Position.Vertical ? (A745 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A745 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i745.Value;
            }
        }
        private double? _i746;
        public double I746
        {
            get
            {
                //Debug.WriteLine("I746");
                if (_i746 == null)
                    _i746 = (B3 == Position.Vertical ? (A746 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A746 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i746.Value;
            }
        }
        private double? _i747;
        public double I747
        {
            get
            {
                //Debug.WriteLine("I747");
                if (_i747 == null)
                    _i747 = (B3 == Position.Vertical ? (A747 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A747 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i747.Value;
            }
        }
        private double? _i748;
        public double I748
        {
            get
            {
                //Debug.WriteLine("I748");
                if (_i748 == null)
                    _i748 = (B3 == Position.Vertical ? (A748 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A748 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i748.Value;
            }
        }
        private double? _i749;
        public double I749
        {
            get
            {
                //Debug.WriteLine("I749");
                if (_i749 == null)
                    _i749 = (B3 == Position.Vertical ? (A749 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A749 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i749.Value;
            }
        }
        private double? _i750;
        public double I750
        {
            get
            {
                //Debug.WriteLine("I750");
                if (_i750 == null)
                    _i750 = (B3 == Position.Vertical ? (A750 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A750 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i750.Value;
            }
        }
        private double? _i751;
        public double I751
        {
            get
            {
                //Debug.WriteLine("I751");
                if (_i751 == null)
                    _i751 = (B3 == Position.Vertical ? (A751 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A751 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i751.Value;
            }
        }
        private double? _i752;
        public double I752
        {
            get
            {
                //Debug.WriteLine("I752");
                if (_i752 == null)
                    _i752 = (B3 == Position.Vertical ? (A752 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A752 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i752.Value;
            }
        }
        private double? _i753;
        public double I753
        {
            get
            {
                //Debug.WriteLine("I753");
                if (_i753 == null)
                    _i753 = (B3 == Position.Vertical ? (A753 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A753 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i753.Value;
            }
        }
        private double? _i754;
        public double I754
        {
            get
            {
                //Debug.WriteLine("I754");
                if (_i754 == null)
                    _i754 = (B3 == Position.Vertical ? (A754 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A754 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i754.Value;
            }
        }
        private double? _i755;
        public double I755
        {
            get
            {
                //Debug.WriteLine("I755");
                if (_i755 == null)
                    _i755 = (B3 == Position.Vertical ? (A755 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A755 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i755.Value;
            }
        }
        private double? _i756;
        public double I756
        {
            get
            {
                //Debug.WriteLine("I756");
                if (_i756 == null)
                    _i756 = (B3 == Position.Vertical ? (A756 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A756 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i756.Value;
            }
        }
        private double? _i757;
        public double I757
        {
            get
            {
                //Debug.WriteLine("I757");
                if (_i757 == null)
                    _i757 = (B3 == Position.Vertical ? (A757 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A757 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i757.Value;
            }
        }
        private double? _i758;
        public double I758
        {
            get
            {
                //Debug.WriteLine("I758");
                if (_i758 == null)
                    _i758 = (B3 == Position.Vertical ? (A758 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A758 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i758.Value;
            }
        }
        private double? _i759;
        public double I759
        {
            get
            {
                //Debug.WriteLine("I759");
                if (_i759 == null)
                    _i759 = (B3 == Position.Vertical ? (A759 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A759 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i759.Value;
            }
        }
        private double? _i760;
        public double I760
        {
            get
            {
                //Debug.WriteLine("I760");
                if (_i760 == null)
                    _i760 = (B3 == Position.Vertical ? (A760 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A760 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i760.Value;
            }
        }
        private double? _i761;
        public double I761
        {
            get
            {
                //Debug.WriteLine("I761");
                if (_i761 == null)
                    _i761 = (B3 == Position.Vertical ? (A761 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A761 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i761.Value;
            }
        }
        private double? _i762;
        public double I762
        {
            get
            {
                //Debug.WriteLine("I762");
                if (_i762 == null)
                    _i762 = (B3 == Position.Vertical ? (A762 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A762 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i762.Value;
            }
        }
        private double? _i763;
        public double I763
        {
            get
            {
                //Debug.WriteLine("I763");
                if (_i763 == null)
                    _i763 = (B3 == Position.Vertical ? (A763 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A763 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i763.Value;
            }
        }
        private double? _i764;
        public double I764
        {
            get
            {
                //Debug.WriteLine("I764");
                if (_i764 == null)
                    _i764 = (B3 == Position.Vertical ? (A764 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A764 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i764.Value;
            }
        }
        private double? _i765;
        public double I765
        {
            get
            {
                //Debug.WriteLine("I765");
                if (_i765 == null)
                    _i765 = (B3 == Position.Vertical ? (A765 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A765 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i765.Value;
            }
        }
        private double? _i766;
        public double I766
        {
            get
            {
                //Debug.WriteLine("I766");
                if (_i766 == null)
                    _i766 = (B3 == Position.Vertical ? (A766 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A766 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i766.Value;
            }
        }
        private double? _i767;
        public double I767
        {
            get
            {
                //Debug.WriteLine("I767");
                if (_i767 == null)
                    _i767 = (B3 == Position.Vertical ? (A767 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A767 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i767.Value;
            }
        }
        private double? _i768;
        public double I768
        {
            get
            {
                //Debug.WriteLine("I768");
                if (_i768 == null)
                    _i768 = (B3 == Position.Vertical ? (A768 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A768 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i768.Value;
            }
        }
        private double? _i769;
        public double I769
        {
            get
            {
                //Debug.WriteLine("I769");
                if (_i769 == null)
                    _i769 = (B3 == Position.Vertical ? (A769 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A769 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i769.Value;
            }
        }
        private double? _i770;
        public double I770
        {
            get
            {
                //Debug.WriteLine("I770");
                if (_i770 == null)
                    _i770 = (B3 == Position.Vertical ? (A770 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A770 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i770.Value;
            }
        }
        private double? _i771;
        public double I771
        {
            get
            {
                //Debug.WriteLine("I771");
                if (_i771 == null)
                    _i771 = (B3 == Position.Vertical ? (A771 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A771 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i771.Value;
            }
        }
        private double? _i772;
        public double I772
        {
            get
            {
                //Debug.WriteLine("I772");
                if (_i772 == null)
                    _i772 = (B3 == Position.Vertical ? (A772 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A772 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i772.Value;
            }
        }
        private double? _i773;
        public double I773
        {
            get
            {
                //Debug.WriteLine("I773");
                if (_i773 == null)
                    _i773 = (B3 == Position.Vertical ? (A773 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A773 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i773.Value;
            }
        }
        private double? _i774;
        public double I774
        {
            get
            {
                //Debug.WriteLine("I774");
                if (_i774 == null)
                    _i774 = (B3 == Position.Vertical ? (A774 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A774 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i774.Value;
            }
        }
        private double? _i775;
        public double I775
        {
            get
            {
                //Debug.WriteLine("I775");
                if (_i775 == null)
                    _i775 = (B3 == Position.Vertical ? (A775 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A775 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i775.Value;
            }
        }
        private double? _i776;
        public double I776
        {
            get
            {
                //Debug.WriteLine("I776");
                if (_i776 == null)
                    _i776 = (B3 == Position.Vertical ? (A776 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A776 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i776.Value;
            }
        }
        private double? _i777;
        public double I777
        {
            get
            {
                //Debug.WriteLine("I777");
                if (_i777 == null)
                    _i777 = (B3 == Position.Vertical ? (A777 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A777 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i777.Value;
            }
        }
        private double? _i778;
        public double I778
        {
            get
            {
                //Debug.WriteLine("I778");
                if (_i778 == null)
                    _i778 = (B3 == Position.Vertical ? (A778 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A778 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i778.Value;
            }
        }
        private double? _i779;
        public double I779
        {
            get
            {
                //Debug.WriteLine("I779");
                if (_i779 == null)
                    _i779 = (B3 == Position.Vertical ? (A779 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A779 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i779.Value;
            }
        }
        private double? _i780;
        public double I780
        {
            get
            {
                //Debug.WriteLine("I780");
                if (_i780 == null)
                    _i780 = (B3 == Position.Vertical ? (A780 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A780 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i780.Value;
            }
        }
        private double? _i781;
        public double I781
        {
            get
            {
                //Debug.WriteLine("I781");
                if (_i781 == null)
                    _i781 = (B3 == Position.Vertical ? (A781 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A781 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i781.Value;
            }
        }
        private double? _i782;
        public double I782
        {
            get
            {
                //Debug.WriteLine("I782");
                if (_i782 == null)
                    _i782 = (B3 == Position.Vertical ? (A782 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A782 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i782.Value;
            }
        }
        private double? _i783;
        public double I783
        {
            get
            {
                //Debug.WriteLine("I783");
                if (_i783 == null)
                    _i783 = (B3 == Position.Vertical ? (A783 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A783 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i783.Value;
            }
        }
        private double? _i784;
        public double I784
        {
            get
            {
                //Debug.WriteLine("I784");
                if (_i784 == null)
                    _i784 = (B3 == Position.Vertical ? (A784 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A784 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i784.Value;
            }
        }
        private double? _i785;
        public double I785
        {
            get
            {
                //Debug.WriteLine("I785");
                if (_i785 == null)
                    _i785 = (B3 == Position.Vertical ? (A785 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A785 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i785.Value;
            }
        }
        private double? _i786;
        public double I786
        {
            get
            {
                //Debug.WriteLine("I786");
                if (_i786 == null)
                    _i786 = (B3 == Position.Vertical ? (A786 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A786 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i786.Value;
            }
        }
        private double? _i787;
        public double I787
        {
            get
            {
                //Debug.WriteLine("I787");
                if (_i787 == null)
                    _i787 = (B3 == Position.Vertical ? (A787 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A787 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i787.Value;
            }
        }
        private double? _i788;
        public double I788
        {
            get
            {
                //Debug.WriteLine("I788");
                if (_i788 == null)
                    _i788 = (B3 == Position.Vertical ? (A788 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A788 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i788.Value;
            }
        }
        private double? _i789;
        public double I789
        {
            get
            {
                //Debug.WriteLine("I789");
                if (_i789 == null)
                    _i789 = (B3 == Position.Vertical ? (A789 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A789 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i789.Value;
            }
        }
        private double? _i790;
        public double I790
        {
            get
            {
                //Debug.WriteLine("I790");
                if (_i790 == null)
                    _i790 = (B3 == Position.Vertical ? (A790 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A790 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i790.Value;
            }
        }
        private double? _i791;
        public double I791
        {
            get
            {
                //Debug.WriteLine("I791");
                if (_i791 == null)
                    _i791 = (B3 == Position.Vertical ? (A791 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A791 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i791.Value;
            }
        }
        private double? _i792;
        public double I792
        {
            get
            {
                //Debug.WriteLine("I792");
                if (_i792 == null)
                    _i792 = (B3 == Position.Vertical ? (A792 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A792 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i792.Value;
            }
        }
        private double? _i793;
        public double I793
        {
            get
            {
                //Debug.WriteLine("I793");
                if (_i793 == null)
                    _i793 = (B3 == Position.Vertical ? (A793 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A793 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i793.Value;
            }
        }
        private double? _i794;
        public double I794
        {
            get
            {
                //Debug.WriteLine("I794");
                if (_i794 == null)
                    _i794 = (B3 == Position.Vertical ? (A794 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A794 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i794.Value;
            }
        }
        private double? _i795;
        public double I795
        {
            get
            {
                //Debug.WriteLine("I795");
                if (_i795 == null)
                    _i795 = (B3 == Position.Vertical ? (A795 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A795 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i795.Value;
            }
        }
        private double? _i796;
        public double I796
        {
            get
            {
                //Debug.WriteLine("I796");
                if (_i796 == null)
                    _i796 = (B3 == Position.Vertical ? (A796 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A796 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i796.Value;
            }
        }
        private double? _i797;
        public double I797
        {
            get
            {
                //Debug.WriteLine("I797");
                if (_i797 == null)
                    _i797 = (B3 == Position.Vertical ? (A797 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A797 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i797.Value;
            }
        }
        private double? _i798;
        public double I798
        {
            get
            {
                //Debug.WriteLine("I798");
                if (_i798 == null)
                    _i798 = (B3 == Position.Vertical ? (A798 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A798 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i798.Value;
            }
        }
        private double? _i799;
        public double I799
        {
            get
            {
                //Debug.WriteLine("I799");
                if (_i799 == null)
                    _i799 = (B3 == Position.Vertical ? (A799 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A799 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i799.Value;
            }
        }
        private double? _i800;
        public double I800
        {
            get
            {
                //Debug.WriteLine("I800");
                if (_i800 == null)
                    _i800 = (B3 == Position.Vertical ? (A800 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A800 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i800.Value;
            }
        }
        private double? _i801;
        public double I801
        {
            get
            {
                //Debug.WriteLine("I801");
                if (_i801 == null)
                    _i801 = (B3 == Position.Vertical ? (A801 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A801 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i801.Value;
            }
        }
        private double? _i802;
        public double I802
        {
            get
            {
                //Debug.WriteLine("I802");
                if (_i802 == null)
                    _i802 = (B3 == Position.Vertical ? (A802 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A802 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i802.Value;
            }
        }
        private double? _i803;
        public double I803
        {
            get
            {
                //Debug.WriteLine("I803");
                if (_i803 == null)
                    _i803 = (B3 == Position.Vertical ? (A803 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A803 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i803.Value;
            }
        }
        private double? _i804;
        public double I804
        {
            get
            {
                //Debug.WriteLine("I804");
                if (_i804 == null)
                    _i804 = (B3 == Position.Vertical ? (A804 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A804 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i804.Value;
            }
        }
        private double? _i805;
        public double I805
        {
            get
            {
                //Debug.WriteLine("I805");
                if (_i805 == null)
                    _i805 = (B3 == Position.Vertical ? (A805 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A805 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i805.Value;
            }
        }
        private double? _i806;
        public double I806
        {
            get
            {
                //Debug.WriteLine("I806");
                if (_i806 == null)
                    _i806 = (B3 == Position.Vertical ? (A806 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A806 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i806.Value;
            }
        }
        private double? _i807;
        public double I807
        {
            get
            {
                //Debug.WriteLine("I807");
                if (_i807 == null)
                    _i807 = (B3 == Position.Vertical ? (A807 < _b576.Value ? 0 : 1) : Math.Min(1, Math.Pow((A807 / 304800), 2) * (1488 * 32.2 * (_e33.Value - _e20.Value)) / (18 * _e39.Value) / _b571.Value * H8 / _b588.Value));
                return _i807.Value;
            }
        }

        private double? _j607;
        public double J607
        {
            get
            {
                //Debug.WriteLine("J607");
                if (_j607 == null)
                    _j607 = F607 * (1 - I607);
                return _j607.Value;
            }
        }
        private double? _j608;
        public double J608
        {
            get
            {
                //Debug.WriteLine("J608");
                if (_j608 == null)
                    _j608 = F608 * (1 - I608);
                return _j608.Value;
            }
        }
        private double? _j609;
        public double J609
        {
            get
            {
                //Debug.WriteLine("J609");
                if (_j609 == null)
                    _j609 = F609 * (1 - I609);
                return _j609.Value;
            }
        }
        private double? _j610;
        public double J610
        {
            get
            {
                //Debug.WriteLine("J610");
                if (_j610 == null)
                    _j610 = F610 * (1 - I610);
                return _j610.Value;
            }
        }
        private double? _j611;
        public double J611
        {
            get
            {
                //Debug.WriteLine("J611");
                if (_j611 == null)
                    _j611 = F611 * (1 - I611);
                return _j611.Value;
            }
        }
        private double? _j612;
        public double J612
        {
            get
            {
                //Debug.WriteLine("J612");
                if (_j612 == null)
                    _j612 = F612 * (1 - I612);
                return _j612.Value;
            }
        }
        private double? _j613;
        public double J613
        {
            get
            {
                //Debug.WriteLine("J613");
                if (_j613 == null)
                    _j613 = F613 * (1 - I613);
                return _j613.Value;
            }
        }
        private double? _j614;
        public double J614
        {
            get
            {
                //Debug.WriteLine("J614");
                if (_j614 == null)
                    _j614 = F614 * (1 - I614);
                return _j614.Value;
            }
        }
        private double? _j615;
        public double J615
        {
            get
            {
                //Debug.WriteLine("J615");
                if (_j615 == null)
                    _j615 = F615 * (1 - I615);
                return _j615.Value;
            }
        }
        private double? _j616;
        public double J616
        {
            get
            {
                //Debug.WriteLine("J616");
                if (_j616 == null)
                    _j616 = F616 * (1 - I616);
                return _j616.Value;
            }
        }
        private double? _j617;
        public double J617
        {
            get
            {
                //Debug.WriteLine("J617");
                if (_j617 == null)
                    _j617 = F617 * (1 - I617);
                return _j617.Value;
            }
        }
        private double? _j618;
        public double J618
        {
            get
            {
                //Debug.WriteLine("J618");
                if (_j618 == null)
                    _j618 = F618 * (1 - I618);
                return _j618.Value;
            }
        }
        private double? _j619;
        public double J619
        {
            get
            {
                //Debug.WriteLine("J619");
                if (_j619 == null)
                    _j619 = F619 * (1 - I619);
                return _j619.Value;
            }
        }
        private double? _j620;
        public double J620
        {
            get
            {
                //Debug.WriteLine("J620");
                if (_j620 == null)
                    _j620 = F620 * (1 - I620);
                return _j620.Value;
            }
        }
        private double? _j621;
        public double J621
        {
            get
            {
                //Debug.WriteLine("J621");
                if (_j621 == null)
                    _j621 = F621 * (1 - I621);
                return _j621.Value;
            }
        }
        private double? _j622;
        public double J622
        {
            get
            {
                //Debug.WriteLine("J622");
                if (_j622 == null)
                    _j622 = F622 * (1 - I622);
                return _j622.Value;
            }
        }
        private double? _j623;
        public double J623
        {
            get
            {
                //Debug.WriteLine("J623");
                if (_j623 == null)
                    _j623 = F623 * (1 - I623);
                return _j623.Value;
            }
        }
        private double? _j624;
        public double J624
        {
            get
            {
                //Debug.WriteLine("J624");
                if (_j624 == null)
                    _j624 = F624 * (1 - I624);
                return _j624.Value;
            }
        }
        private double? _j625;
        public double J625
        {
            get
            {
                //Debug.WriteLine("J625");
                if (_j625 == null)
                    _j625 = F625 * (1 - I625);
                return _j625.Value;
            }
        }
        private double? _j626;
        public double J626
        {
            get
            {
                //Debug.WriteLine("J626");
                if (_j626 == null)
                    _j626 = F626 * (1 - I626);
                return _j626.Value;
            }
        }
        private double? _j627;
        public double J627
        {
            get
            {
                //Debug.WriteLine("J627");
                if (_j627 == null)
                    _j627 = F627 * (1 - I627);
                return _j627.Value;
            }
        }
        private double? _j628;
        public double J628
        {
            get
            {
                //Debug.WriteLine("J628");
                if (_j628 == null)
                    _j628 = F628 * (1 - I628);
                return _j628.Value;
            }
        }
        private double? _j629;
        public double J629
        {
            get
            {
                //Debug.WriteLine("J629");
                if (_j629 == null)
                    _j629 = F629 * (1 - I629);
                return _j629.Value;
            }
        }
        private double? _j630;
        public double J630
        {
            get
            {
                //Debug.WriteLine("J630");
                if (_j630 == null)
                    _j630 = F630 * (1 - I630);
                return _j630.Value;
            }
        }
        private double? _j631;
        public double J631
        {
            get
            {
                //Debug.WriteLine("J631");
                if (_j631 == null)
                    _j631 = F631 * (1 - I631);
                return _j631.Value;
            }
        }
        private double? _j632;
        public double J632
        {
            get
            {
                //Debug.WriteLine("J632");
                if (_j632 == null)
                    _j632 = F632 * (1 - I632);
                return _j632.Value;
            }
        }
        private double? _j633;
        public double J633
        {
            get
            {
                //Debug.WriteLine("J633");
                if (_j633 == null)
                    _j633 = F633 * (1 - I633);
                return _j633.Value;
            }
        }
        private double? _j634;
        public double J634
        {
            get
            {
                //Debug.WriteLine("J634");
                if (_j634 == null)
                    _j634 = F634 * (1 - I634);
                return _j634.Value;
            }
        }
        private double? _j635;
        public double J635
        {
            get
            {
                //Debug.WriteLine("J635");
                if (_j635 == null)
                    _j635 = F635 * (1 - I635);
                return _j635.Value;
            }
        }
        private double? _j636;
        public double J636
        {
            get
            {
                //Debug.WriteLine("J636");
                if (_j636 == null)
                    _j636 = F636 * (1 - I636);
                return _j636.Value;
            }
        }
        private double? _j637;
        public double J637
        {
            get
            {
                //Debug.WriteLine("J637");
                if (_j637 == null)
                    _j637 = F637 * (1 - I637);
                return _j637.Value;
            }
        }
        private double? _j638;
        public double J638
        {
            get
            {
                //Debug.WriteLine("J638");
                if (_j638 == null)
                    _j638 = F638 * (1 - I638);
                return _j638.Value;
            }
        }
        private double? _j639;
        public double J639
        {
            get
            {
                //Debug.WriteLine("J639");
                if (_j639 == null)
                    _j639 = F639 * (1 - I639);
                return _j639.Value;
            }
        }
        private double? _j640;
        public double J640
        {
            get
            {
                //Debug.WriteLine("J640");
                if (_j640 == null)
                    _j640 = F640 * (1 - I640);
                return _j640.Value;
            }
        }
        private double? _j641;
        public double J641
        {
            get
            {
                //Debug.WriteLine("J641");
                if (_j641 == null)
                    _j641 = F641 * (1 - I641);
                return _j641.Value;
            }
        }
        private double? _j642;
        public double J642
        {
            get
            {
                //Debug.WriteLine("J642");
                if (_j642 == null)
                    _j642 = F642 * (1 - I642);
                return _j642.Value;
            }
        }
        private double? _j643;
        public double J643
        {
            get
            {
                //Debug.WriteLine("J643");
                if (_j643 == null)
                    _j643 = F643 * (1 - I643);
                return _j643.Value;
            }
        }
        private double? _j644;
        public double J644
        {
            get
            {
                //Debug.WriteLine("J644");
                if (_j644 == null)
                    _j644 = F644 * (1 - I644);
                return _j644.Value;
            }
        }
        private double? _j645;
        public double J645
        {
            get
            {
                //Debug.WriteLine("J645");
                if (_j645 == null)
                    _j645 = F645 * (1 - I645);
                return _j645.Value;
            }
        }
        private double? _j646;
        public double J646
        {
            get
            {
                //Debug.WriteLine("J646");
                if (_j646 == null)
                    _j646 = F646 * (1 - I646);
                return _j646.Value;
            }
        }
        private double? _j647;
        public double J647
        {
            get
            {
                //Debug.WriteLine("J647");
                if (_j647 == null)
                    _j647 = F647 * (1 - I647);
                return _j647.Value;
            }
        }
        private double? _j648;
        public double J648
        {
            get
            {
                //Debug.WriteLine("J648");
                if (_j648 == null)
                    _j648 = F648 * (1 - I648);
                return _j648.Value;
            }
        }
        private double? _j649;
        public double J649
        {
            get
            {
                //Debug.WriteLine("J649");
                if (_j649 == null)
                    _j649 = F649 * (1 - I649);
                return _j649.Value;
            }
        }
        private double? _j650;
        public double J650
        {
            get
            {
                //Debug.WriteLine("J650");
                if (_j650 == null)
                    _j650 = F650 * (1 - I650);
                return _j650.Value;
            }
        }
        private double? _j651;
        public double J651
        {
            get
            {
                //Debug.WriteLine("J651");
                if (_j651 == null)
                    _j651 = F651 * (1 - I651);
                return _j651.Value;
            }
        }
        private double? _j652;
        public double J652
        {
            get
            {
                //Debug.WriteLine("J652");
                if (_j652 == null)
                    _j652 = F652 * (1 - I652);
                return _j652.Value;
            }
        }
        private double? _j653;
        public double J653
        {
            get
            {
                //Debug.WriteLine("J653");
                if (_j653 == null)
                    _j653 = F653 * (1 - I653);
                return _j653.Value;
            }
        }
        private double? _j654;
        public double J654
        {
            get
            {
                //Debug.WriteLine("J654");
                if (_j654 == null)
                    _j654 = F654 * (1 - I654);
                return _j654.Value;
            }
        }
        private double? _j655;
        public double J655
        {
            get
            {
                //Debug.WriteLine("J655");
                if (_j655 == null)
                    _j655 = F655 * (1 - I655);
                return _j655.Value;
            }
        }
        private double? _j656;
        public double J656
        {
            get
            {
                //Debug.WriteLine("J656");
                if (_j656 == null)
                    _j656 = F656 * (1 - I656);
                return _j656.Value;
            }
        }
        private double? _j657;
        public double J657
        {
            get
            {
                //Debug.WriteLine("J657");
                if (_j657 == null)
                    _j657 = F657 * (1 - I657);
                return _j657.Value;
            }
        }
        private double? _j658;
        public double J658
        {
            get
            {
                //Debug.WriteLine("J658");
                if (_j658 == null)
                    _j658 = F658 * (1 - I658);
                return _j658.Value;
            }
        }
        private double? _j659;
        public double J659
        {
            get
            {
                //Debug.WriteLine("J659");
                if (_j659 == null)
                    _j659 = F659 * (1 - I659);
                return _j659.Value;
            }
        }
        private double? _j660;
        public double J660
        {
            get
            {
                //Debug.WriteLine("J660");
                if (_j660 == null)
                    _j660 = F660 * (1 - I660);
                return _j660.Value;
            }
        }
        private double? _j661;
        public double J661
        {
            get
            {
                //Debug.WriteLine("J661");
                if (_j661 == null)
                    _j661 = F661 * (1 - I661);
                return _j661.Value;
            }
        }
        private double? _j662;
        public double J662
        {
            get
            {
                //Debug.WriteLine("J662");
                if (_j662 == null)
                    _j662 = F662 * (1 - I662);
                return _j662.Value;
            }
        }
        private double? _j663;
        public double J663
        {
            get
            {
                //Debug.WriteLine("J663");
                if (_j663 == null)
                    _j663 = F663 * (1 - I663);
                return _j663.Value;
            }
        }
        private double? _j664;
        public double J664
        {
            get
            {
                //Debug.WriteLine("J664");
                if (_j664 == null)
                    _j664 = F664 * (1 - I664);
                return _j664.Value;
            }
        }
        private double? _j665;
        public double J665
        {
            get
            {
                //Debug.WriteLine("J665");
                if (_j665 == null)
                    _j665 = F665 * (1 - I665);
                return _j665.Value;
            }
        }
        private double? _j666;
        public double J666
        {
            get
            {
                //Debug.WriteLine("J666");
                if (_j666 == null)
                    _j666 = F666 * (1 - I666);
                return _j666.Value;
            }
        }
        private double? _j667;
        public double J667
        {
            get
            {
                //Debug.WriteLine("J667");
                if (_j667 == null)
                    _j667 = F667 * (1 - I667);
                return _j667.Value;
            }
        }
        private double? _j668;
        public double J668
        {
            get
            {
                //Debug.WriteLine("J668");
                if (_j668 == null)
                    _j668 = F668 * (1 - I668);
                return _j668.Value;
            }
        }
        private double? _j669;
        public double J669
        {
            get
            {
                //Debug.WriteLine("J669");
                if (_j669 == null)
                    _j669 = F669 * (1 - I669);
                return _j669.Value;
            }
        }
        private double? _j670;
        public double J670
        {
            get
            {
                //Debug.WriteLine("J670");
                if (_j670 == null)
                    _j670 = F670 * (1 - I670);
                return _j670.Value;
            }
        }
        private double? _j671;
        public double J671
        {
            get
            {
                //Debug.WriteLine("J671");
                if (_j671 == null)
                    _j671 = F671 * (1 - I671);
                return _j671.Value;
            }
        }
        private double? _j672;
        public double J672
        {
            get
            {
                //Debug.WriteLine("J672");
                if (_j672 == null)
                    _j672 = F672 * (1 - I672);
                return _j672.Value;
            }
        }
        private double? _j673;
        public double J673
        {
            get
            {
                //Debug.WriteLine("J673");
                if (_j673 == null)
                    _j673 = F673 * (1 - I673);
                return _j673.Value;
            }
        }
        private double? _j674;
        public double J674
        {
            get
            {
                //Debug.WriteLine("J674");
                if (_j674 == null)
                    _j674 = F674 * (1 - I674);
                return _j674.Value;
            }
        }
        private double? _j675;
        public double J675
        {
            get
            {
                //Debug.WriteLine("J675");
                if (_j675 == null)
                    _j675 = F675 * (1 - I675);
                return _j675.Value;
            }
        }
        private double? _j676;
        public double J676
        {
            get
            {
                //Debug.WriteLine("J676");
                if (_j676 == null)
                    _j676 = F676 * (1 - I676);
                return _j676.Value;
            }
        }
        private double? _j677;
        public double J677
        {
            get
            {
                //Debug.WriteLine("J677");
                if (_j677 == null)
                    _j677 = F677 * (1 - I677);
                return _j677.Value;
            }
        }
        private double? _j678;
        public double J678
        {
            get
            {
                //Debug.WriteLine("J678");
                if (_j678 == null)
                    _j678 = F678 * (1 - I678);
                return _j678.Value;
            }
        }
        private double? _j679;
        public double J679
        {
            get
            {
                //Debug.WriteLine("J679");
                if (_j679 == null)
                    _j679 = F679 * (1 - I679);
                return _j679.Value;
            }
        }
        private double? _j680;
        public double J680
        {
            get
            {
                //Debug.WriteLine("J680");
                if (_j680 == null)
                    _j680 = F680 * (1 - I680);
                return _j680.Value;
            }
        }
        private double? _j681;
        public double J681
        {
            get
            {
                //Debug.WriteLine("J681");
                if (_j681 == null)
                    _j681 = F681 * (1 - I681);
                return _j681.Value;
            }
        }
        private double? _j682;
        public double J682
        {
            get
            {
                //Debug.WriteLine("J682");
                if (_j682 == null)
                    _j682 = F682 * (1 - I682);
                return _j682.Value;
            }
        }
        private double? _j683;
        public double J683
        {
            get
            {
                //Debug.WriteLine("J683");
                if (_j683 == null)
                    _j683 = F683 * (1 - I683);
                return _j683.Value;
            }
        }
        private double? _j684;
        public double J684
        {
            get
            {
                //Debug.WriteLine("J684");
                if (_j684 == null)
                    _j684 = F684 * (1 - I684);
                return _j684.Value;
            }
        }
        private double? _j685;
        public double J685
        {
            get
            {
                //Debug.WriteLine("J685");
                if (_j685 == null)
                    _j685 = F685 * (1 - I685);
                return _j685.Value;
            }
        }
        private double? _j686;
        public double J686
        {
            get
            {
                //Debug.WriteLine("J686");
                if (_j686 == null)
                    _j686 = F686 * (1 - I686);
                return _j686.Value;
            }
        }
        private double? _j687;
        public double J687
        {
            get
            {
                //Debug.WriteLine("J687");
                if (_j687 == null)
                    _j687 = F687 * (1 - I687);
                return _j687.Value;
            }
        }
        private double? _j688;
        public double J688
        {
            get
            {
                //Debug.WriteLine("J688");
                if (_j688 == null)
                    _j688 = F688 * (1 - I688);
                return _j688.Value;
            }
        }
        private double? _j689;
        public double J689
        {
            get
            {
                //Debug.WriteLine("J689");
                if (_j689 == null)
                    _j689 = F689 * (1 - I689);
                return _j689.Value;
            }
        }
        private double? _j690;
        public double J690
        {
            get
            {
                //Debug.WriteLine("J690");
                if (_j690 == null)
                    _j690 = F690 * (1 - I690);
                return _j690.Value;
            }
        }
        private double? _j691;
        public double J691
        {
            get
            {
                //Debug.WriteLine("J691");
                if (_j691 == null)
                    _j691 = F691 * (1 - I691);
                return _j691.Value;
            }
        }
        private double? _j692;
        public double J692
        {
            get
            {
                //Debug.WriteLine("J692");
                if (_j692 == null)
                    _j692 = F692 * (1 - I692);
                return _j692.Value;
            }
        }
        private double? _j693;
        public double J693
        {
            get
            {
                //Debug.WriteLine("J693");
                if (_j693 == null)
                    _j693 = F693 * (1 - I693);
                return _j693.Value;
            }
        }
        private double? _j694;
        public double J694
        {
            get
            {
                //Debug.WriteLine("J694");
                if (_j694 == null)
                    _j694 = F694 * (1 - I694);
                return _j694.Value;
            }
        }
        private double? _j695;
        public double J695
        {
            get
            {
                //Debug.WriteLine("J695");
                if (_j695 == null)
                    _j695 = F695 * (1 - I695);
                return _j695.Value;
            }
        }
        private double? _j696;
        public double J696
        {
            get
            {
                //Debug.WriteLine("J696");
                if (_j696 == null)
                    _j696 = F696 * (1 - I696);
                return _j696.Value;
            }
        }
        private double? _j697;
        public double J697
        {
            get
            {
                //Debug.WriteLine("J697");
                if (_j697 == null)
                    _j697 = F697 * (1 - I697);
                return _j697.Value;
            }
        }
        private double? _j698;
        public double J698
        {
            get
            {
                //Debug.WriteLine("J698");
                if (_j698 == null)
                    _j698 = F698 * (1 - I698);
                return _j698.Value;
            }
        }
        private double? _j699;
        public double J699
        {
            get
            {
                //Debug.WriteLine("J699");
                if (_j699 == null)
                    _j699 = F699 * (1 - I699);
                return _j699.Value;
            }
        }
        private double? _j700;
        public double J700
        {
            get
            {
                //Debug.WriteLine("J700");
                if (_j700 == null)
                    _j700 = F700 * (1 - I700);
                return _j700.Value;
            }
        }
        private double? _j701;
        public double J701
        {
            get
            {
                //Debug.WriteLine("J701");
                if (_j701 == null)
                    _j701 = F701 * (1 - I701);
                return _j701.Value;
            }
        }
        private double? _j702;
        public double J702
        {
            get
            {
                //Debug.WriteLine("J702");
                if (_j702 == null)
                    _j702 = F702 * (1 - I702);
                return _j702.Value;
            }
        }
        private double? _j703;
        public double J703
        {
            get
            {
                //Debug.WriteLine("J703");
                if (_j703 == null)
                    _j703 = F703 * (1 - I703);
                return _j703.Value;
            }
        }
        private double? _j704;
        public double J704
        {
            get
            {
                //Debug.WriteLine("J704");
                if (_j704 == null)
                    _j704 = F704 * (1 - I704);
                return _j704.Value;
            }
        }
        private double? _j705;
        public double J705
        {
            get
            {
                //Debug.WriteLine("J705");
                if (_j705 == null)
                    _j705 = F705 * (1 - I705);
                return _j705.Value;
            }
        }
        private double? _j706;
        public double J706
        {
            get
            {
                //Debug.WriteLine("J706");
                if (_j706 == null)
                    _j706 = F706 * (1 - I706);
                return _j706.Value;
            }
        }
        private double? _j707;
        public double J707
        {
            get
            {
                //Debug.WriteLine("J707");
                if (_j707 == null)
                    _j707 = F707 * (1 - I707);
                return _j707.Value;
            }
        }
        private double? _j708;
        public double J708
        {
            get
            {
                //Debug.WriteLine("J708");
                if (_j708 == null)
                    _j708 = F708 * (1 - I708);
                return _j708.Value;
            }
        }
        private double? _j709;
        public double J709
        {
            get
            {
                //Debug.WriteLine("J709");
                if (_j709 == null)
                    _j709 = F709 * (1 - I709);
                return _j709.Value;
            }
        }
        private double? _j710;
        public double J710
        {
            get
            {
                //Debug.WriteLine("J710");
                if (_j710 == null)
                    _j710 = F710 * (1 - I710);
                return _j710.Value;
            }
        }
        private double? _j711;
        public double J711
        {
            get
            {
                //Debug.WriteLine("J711");
                if (_j711 == null)
                    _j711 = F711 * (1 - I711);
                return _j711.Value;
            }
        }
        private double? _j712;
        public double J712
        {
            get
            {
                //Debug.WriteLine("J712");
                if (_j712 == null)
                    _j712 = F712 * (1 - I712);
                return _j712.Value;
            }
        }
        private double? _j713;
        public double J713
        {
            get
            {
                //Debug.WriteLine("J713");
                if (_j713 == null)
                    _j713 = F713 * (1 - I713);
                return _j713.Value;
            }
        }
        private double? _j714;
        public double J714
        {
            get
            {
                //Debug.WriteLine("J714");
                if (_j714 == null)
                    _j714 = F714 * (1 - I714);
                return _j714.Value;
            }
        }
        private double? _j715;
        public double J715
        {
            get
            {
                //Debug.WriteLine("J715");
                if (_j715 == null)
                    _j715 = F715 * (1 - I715);
                return _j715.Value;
            }
        }
        private double? _j716;
        public double J716
        {
            get
            {
                //Debug.WriteLine("J716");
                if (_j716 == null)
                    _j716 = F716 * (1 - I716);
                return _j716.Value;
            }
        }
        private double? _j717;
        public double J717
        {
            get
            {
                //Debug.WriteLine("J717");
                if (_j717 == null)
                    _j717 = F717 * (1 - I717);
                return _j717.Value;
            }
        }
        private double? _j718;
        public double J718
        {
            get
            {
                //Debug.WriteLine("J718");
                if (_j718 == null)
                    _j718 = F718 * (1 - I718);
                return _j718.Value;
            }
        }
        private double? _j719;
        public double J719
        {
            get
            {
                //Debug.WriteLine("J719");
                if (_j719 == null)
                    _j719 = F719 * (1 - I719);
                return _j719.Value;
            }
        }
        private double? _j720;
        public double J720
        {
            get
            {
                //Debug.WriteLine("J720");
                if (_j720 == null)
                    _j720 = F720 * (1 - I720);
                return _j720.Value;
            }
        }
        private double? _j721;
        public double J721
        {
            get
            {
                //Debug.WriteLine("J721");
                if (_j721 == null)
                    _j721 = F721 * (1 - I721);
                return _j721.Value;
            }
        }
        private double? _j722;
        public double J722
        {
            get
            {
                //Debug.WriteLine("J722");
                if (_j722 == null)
                    _j722 = F722 * (1 - I722);
                return _j722.Value;
            }
        }
        private double? _j723;
        public double J723
        {
            get
            {
                //Debug.WriteLine("J723");
                if (_j723 == null)
                    _j723 = F723 * (1 - I723);
                return _j723.Value;
            }
        }
        private double? _j724;
        public double J724
        {
            get
            {
                //Debug.WriteLine("J724");
                if (_j724 == null)
                    _j724 = F724 * (1 - I724);
                return _j724.Value;
            }
        }
        private double? _j725;
        public double J725
        {
            get
            {
                //Debug.WriteLine("J725");
                if (_j725 == null)
                    _j725 = F725 * (1 - I725);
                return _j725.Value;
            }
        }
        private double? _j726;
        public double J726
        {
            get
            {
                //Debug.WriteLine("J726");
                if (_j726 == null)
                    _j726 = F726 * (1 - I726);
                return _j726.Value;
            }
        }
        private double? _j727;
        public double J727
        {
            get
            {
                //Debug.WriteLine("J727");
                if (_j727 == null)
                    _j727 = F727 * (1 - I727);
                return _j727.Value;
            }
        }
        private double? _j728;
        public double J728
        {
            get
            {
                //Debug.WriteLine("J728");
                if (_j728 == null)
                    _j728 = F728 * (1 - I728);
                return _j728.Value;
            }
        }
        private double? _j729;
        public double J729
        {
            get
            {
                //Debug.WriteLine("J729");
                if (_j729 == null)
                    _j729 = F729 * (1 - I729);
                return _j729.Value;
            }
        }
        private double? _j730;
        public double J730
        {
            get
            {
                //Debug.WriteLine("J730");
                if (_j730 == null)
                    _j730 = F730 * (1 - I730);
                return _j730.Value;
            }
        }
        private double? _j731;
        public double J731
        {
            get
            {
                //Debug.WriteLine("J731");
                if (_j731 == null)
                    _j731 = F731 * (1 - I731);
                return _j731.Value;
            }
        }
        private double? _j732;
        public double J732
        {
            get
            {
                //Debug.WriteLine("J732");
                if (_j732 == null)
                    _j732 = F732 * (1 - I732);
                return _j732.Value;
            }
        }
        private double? _j733;
        public double J733
        {
            get
            {
                //Debug.WriteLine("J733");
                if (_j733 == null)
                    _j733 = F733 * (1 - I733);
                return _j733.Value;
            }
        }
        private double? _j734;
        public double J734
        {
            get
            {
                //Debug.WriteLine("J734");
                if (_j734 == null)
                    _j734 = F734 * (1 - I734);
                return _j734.Value;
            }
        }
        private double? _j735;
        public double J735
        {
            get
            {
                //Debug.WriteLine("J735");
                if (_j735 == null)
                    _j735 = F735 * (1 - I735);
                return _j735.Value;
            }
        }
        private double? _j736;
        public double J736
        {
            get
            {
                //Debug.WriteLine("J736");
                if (_j736 == null)
                    _j736 = F736 * (1 - I736);
                return _j736.Value;
            }
        }
        private double? _j737;
        public double J737
        {
            get
            {
                //Debug.WriteLine("J737");
                if (_j737 == null)
                    _j737 = F737 * (1 - I737);
                return _j737.Value;
            }
        }
        private double? _j738;
        public double J738
        {
            get
            {
                //Debug.WriteLine("J738");
                if (_j738 == null)
                    _j738 = F738 * (1 - I738);
                return _j738.Value;
            }
        }
        private double? _j739;
        public double J739
        {
            get
            {
                //Debug.WriteLine("J739");
                if (_j739 == null)
                    _j739 = F739 * (1 - I739);
                return _j739.Value;
            }
        }
        private double? _j740;
        public double J740
        {
            get
            {
                //Debug.WriteLine("J740");
                if (_j740 == null)
                    _j740 = F740 * (1 - I740);
                return _j740.Value;
            }
        }
        private double? _j741;
        public double J741
        {
            get
            {
                //Debug.WriteLine("J741");
                if (_j741 == null)
                    _j741 = F741 * (1 - I741);
                return _j741.Value;
            }
        }
        private double? _j742;
        public double J742
        {
            get
            {
                //Debug.WriteLine("J742");
                if (_j742 == null)
                    _j742 = F742 * (1 - I742);
                return _j742.Value;
            }
        }
        private double? _j743;
        public double J743
        {
            get
            {
                //Debug.WriteLine("J743");
                if (_j743 == null)
                    _j743 = F743 * (1 - I743);
                return _j743.Value;
            }
        }
        private double? _j744;
        public double J744
        {
            get
            {
                //Debug.WriteLine("J744");
                if (_j744 == null)
                    _j744 = F744 * (1 - I744);
                return _j744.Value;
            }
        }
        private double? _j745;
        public double J745
        {
            get
            {
                //Debug.WriteLine("J745");
                if (_j745 == null)
                    _j745 = F745 * (1 - I745);
                return _j745.Value;
            }
        }
        private double? _j746;
        public double J746
        {
            get
            {
                //Debug.WriteLine("J746");
                if (_j746 == null)
                    _j746 = F746 * (1 - I746);
                return _j746.Value;
            }
        }
        private double? _j747;
        public double J747
        {
            get
            {
                //Debug.WriteLine("J747");
                if (_j747 == null)
                    _j747 = F747 * (1 - I747);
                return _j747.Value;
            }
        }
        private double? _j748;
        public double J748
        {
            get
            {
                //Debug.WriteLine("J748");
                if (_j748 == null)
                    _j748 = F748 * (1 - I748);
                return _j748.Value;
            }
        }
        private double? _j749;
        public double J749
        {
            get
            {
                //Debug.WriteLine("J749");
                if (_j749 == null)
                    _j749 = F749 * (1 - I749);
                return _j749.Value;
            }
        }
        private double? _j750;
        public double J750
        {
            get
            {
                //Debug.WriteLine("J750");
                if (_j750 == null)
                    _j750 = F750 * (1 - I750);
                return _j750.Value;
            }
        }
        private double? _j751;
        public double J751
        {
            get
            {
                //Debug.WriteLine("J751");
                if (_j751 == null)
                    _j751 = F751 * (1 - I751);
                return _j751.Value;
            }
        }
        private double? _j752;
        public double J752
        {
            get
            {
                //Debug.WriteLine("J752");
                if (_j752 == null)
                    _j752 = F752 * (1 - I752);
                return _j752.Value;
            }
        }
        private double? _j753;
        public double J753
        {
            get
            {
                //Debug.WriteLine("J753");
                if (_j753 == null)
                    _j753 = F753 * (1 - I753);
                return _j753.Value;
            }
        }
        private double? _j754;
        public double J754
        {
            get
            {
                //Debug.WriteLine("J754");
                if (_j754 == null)
                    _j754 = F754 * (1 - I754);
                return _j754.Value;
            }
        }
        private double? _j755;
        public double J755
        {
            get
            {
                //Debug.WriteLine("J755");
                if (_j755 == null)
                    _j755 = F755 * (1 - I755);
                return _j755.Value;
            }
        }
        private double? _j756;
        public double J756
        {
            get
            {
                //Debug.WriteLine("J756");
                if (_j756 == null)
                    _j756 = F756 * (1 - I756);
                return _j756.Value;
            }
        }
        private double? _j757;
        public double J757
        {
            get
            {
                //Debug.WriteLine("J757");
                if (_j757 == null)
                    _j757 = F757 * (1 - I757);
                return _j757.Value;
            }
        }
        private double? _j758;
        public double J758
        {
            get
            {
                //Debug.WriteLine("J758");
                if (_j758 == null)
                    _j758 = F758 * (1 - I758);
                return _j758.Value;
            }
        }
        private double? _j759;
        public double J759
        {
            get
            {
                //Debug.WriteLine("J759");
                if (_j759 == null)
                    _j759 = F759 * (1 - I759);
                return _j759.Value;
            }
        }
        private double? _j760;
        public double J760
        {
            get
            {
                //Debug.WriteLine("J760");
                if (_j760 == null)
                    _j760 = F760 * (1 - I760);
                return _j760.Value;
            }
        }
        private double? _j761;
        public double J761
        {
            get
            {
                //Debug.WriteLine("J761");
                if (_j761 == null)
                    _j761 = F761 * (1 - I761);
                return _j761.Value;
            }
        }
        private double? _j762;
        public double J762
        {
            get
            {
                //Debug.WriteLine("J762");
                if (_j762 == null)
                    _j762 = F762 * (1 - I762);
                return _j762.Value;
            }
        }
        private double? _j763;
        public double J763
        {
            get
            {
                //Debug.WriteLine("J763");
                if (_j763 == null)
                    _j763 = F763 * (1 - I763);
                return _j763.Value;
            }
        }
        private double? _j764;
        public double J764
        {
            get
            {
                //Debug.WriteLine("J764");
                if (_j764 == null)
                    _j764 = F764 * (1 - I764);
                return _j764.Value;
            }
        }
        private double? _j765;
        public double J765
        {
            get
            {
                //Debug.WriteLine("J765");
                if (_j765 == null)
                    _j765 = F765 * (1 - I765);
                return _j765.Value;
            }
        }
        private double? _j766;
        public double J766
        {
            get
            {
                //Debug.WriteLine("J766");
                if (_j766 == null)
                    _j766 = F766 * (1 - I766);
                return _j766.Value;
            }
        }
        private double? _j767;
        public double J767
        {
            get
            {
                //Debug.WriteLine("J767");
                if (_j767 == null)
                    _j767 = F767 * (1 - I767);
                return _j767.Value;
            }
        }
        private double? _j768;
        public double J768
        {
            get
            {
                //Debug.WriteLine("J768");
                if (_j768 == null)
                    _j768 = F768 * (1 - I768);
                return _j768.Value;
            }
        }
        private double? _j769;
        public double J769
        {
            get
            {
                //Debug.WriteLine("J769");
                if (_j769 == null)
                    _j769 = F769 * (1 - I769);
                return _j769.Value;
            }
        }
        private double? _j770;
        public double J770
        {
            get
            {
                //Debug.WriteLine("J770");
                if (_j770 == null)
                    _j770 = F770 * (1 - I770);
                return _j770.Value;
            }
        }
        private double? _j771;
        public double J771
        {
            get
            {
                //Debug.WriteLine("J771");
                if (_j771 == null)
                    _j771 = F771 * (1 - I771);
                return _j771.Value;
            }
        }
        private double? _j772;
        public double J772
        {
            get
            {
                //Debug.WriteLine("J772");
                if (_j772 == null)
                    _j772 = F772 * (1 - I772);
                return _j772.Value;
            }
        }
        private double? _j773;
        public double J773
        {
            get
            {
                //Debug.WriteLine("J773");
                if (_j773 == null)
                    _j773 = F773 * (1 - I773);
                return _j773.Value;
            }
        }
        private double? _j774;
        public double J774
        {
            get
            {
                //Debug.WriteLine("J774");
                if (_j774 == null)
                    _j774 = F774 * (1 - I774);
                return _j774.Value;
            }
        }
        private double? _j775;
        public double J775
        {
            get
            {
                //Debug.WriteLine("J775");
                if (_j775 == null)
                    _j775 = F775 * (1 - I775);
                return _j775.Value;
            }
        }
        private double? _j776;
        public double J776
        {
            get
            {
                //Debug.WriteLine("J776");
                if (_j776 == null)
                    _j776 = F776 * (1 - I776);
                return _j776.Value;
            }
        }
        private double? _j777;
        public double J777
        {
            get
            {
                //Debug.WriteLine("J777");
                if (_j777 == null)
                    _j777 = F777 * (1 - I777);
                return _j777.Value;
            }
        }
        private double? _j778;
        public double J778
        {
            get
            {
                //Debug.WriteLine("J778");
                if (_j778 == null)
                    _j778 = F778 * (1 - I778);
                return _j778.Value;
            }
        }
        private double? _j779;
        public double J779
        {
            get
            {
                //Debug.WriteLine("J779");
                if (_j779 == null)
                    _j779 = F779 * (1 - I779);
                return _j779.Value;
            }
        }
        private double? _j780;
        public double J780
        {
            get
            {
                //Debug.WriteLine("J780");
                if (_j780 == null)
                    _j780 = F780 * (1 - I780);
                return _j780.Value;
            }
        }
        private double? _j781;
        public double J781
        {
            get
            {
                //Debug.WriteLine("J781");
                if (_j781 == null)
                    _j781 = F781 * (1 - I781);
                return _j781.Value;
            }
        }
        private double? _j782;
        public double J782
        {
            get
            {
                //Debug.WriteLine("J782");
                if (_j782 == null)
                    _j782 = F782 * (1 - I782);
                return _j782.Value;
            }
        }
        private double? _j783;
        public double J783
        {
            get
            {
                //Debug.WriteLine("J783");
                if (_j783 == null)
                    _j783 = F783 * (1 - I783);
                return _j783.Value;
            }
        }
        private double? _j784;
        public double J784
        {
            get
            {
                //Debug.WriteLine("J784");
                if (_j784 == null)
                    _j784 = F784 * (1 - I784);
                return _j784.Value;
            }
        }
        private double? _j785;
        public double J785
        {
            get
            {
                //Debug.WriteLine("J785");
                if (_j785 == null)
                    _j785 = F785 * (1 - I785);
                return _j785.Value;
            }
        }
        private double? _j786;
        public double J786
        {
            get
            {
                //Debug.WriteLine("J786");
                if (_j786 == null)
                    _j786 = F786 * (1 - I786);
                return _j786.Value;
            }
        }
        private double? _j787;
        public double J787
        {
            get
            {
                //Debug.WriteLine("J787");
                if (_j787 == null)
                    _j787 = F787 * (1 - I787);
                return _j787.Value;
            }
        }
        private double? _j788;
        public double J788
        {
            get
            {
                //Debug.WriteLine("J788");
                if (_j788 == null)
                    _j788 = F788 * (1 - I788);
                return _j788.Value;
            }
        }
        private double? _j789;
        public double J789
        {
            get
            {
                //Debug.WriteLine("J789");
                if (_j789 == null)
                    _j789 = F789 * (1 - I789);
                return _j789.Value;
            }
        }
        private double? _j790;
        public double J790
        {
            get
            {
                //Debug.WriteLine("J790");
                if (_j790 == null)
                    _j790 = F790 * (1 - I790);
                return _j790.Value;
            }
        }
        private double? _j791;
        public double J791
        {
            get
            {
                //Debug.WriteLine("J791");
                if (_j791 == null)
                    _j791 = F791 * (1 - I791);
                return _j791.Value;
            }
        }
        private double? _j792;
        public double J792
        {
            get
            {
                //Debug.WriteLine("J792");
                if (_j792 == null)
                    _j792 = F792 * (1 - I792);
                return _j792.Value;
            }
        }
        private double? _j793;
        public double J793
        {
            get
            {
                //Debug.WriteLine("J793");
                if (_j793 == null)
                    _j793 = F793 * (1 - I793);
                return _j793.Value;
            }
        }
        private double? _j794;
        public double J794
        {
            get
            {
                //Debug.WriteLine("J794");
                if (_j794 == null)
                    _j794 = F794 * (1 - I794);
                return _j794.Value;
            }
        }
        private double? _j795;
        public double J795
        {
            get
            {
                //Debug.WriteLine("J795");
                if (_j795 == null)
                    _j795 = F795 * (1 - I795);
                return _j795.Value;
            }
        }
        private double? _j796;
        public double J796
        {
            get
            {
                //Debug.WriteLine("J796");
                if (_j796 == null)
                    _j796 = F796 * (1 - I796);
                return _j796.Value;
            }
        }
        private double? _j797;
        public double J797
        {
            get
            {
                //Debug.WriteLine("J797");
                if (_j797 == null)
                    _j797 = F797 * (1 - I797);
                return _j797.Value;
            }
        }
        private double? _j798;
        public double J798
        {
            get
            {
                //Debug.WriteLine("J798");
                if (_j798 == null)
                    _j798 = F798 * (1 - I798);
                return _j798.Value;
            }
        }
        private double? _j799;
        public double J799
        {
            get
            {
                //Debug.WriteLine("J799");
                if (_j799 == null)
                    _j799 = F799 * (1 - I799);
                return _j799.Value;
            }
        }
        private double? _j800;
        public double J800
        {
            get
            {
                //Debug.WriteLine("J800");
                if (_j800 == null)
                    _j800 = F800 * (1 - I800);
                return _j800.Value;
            }
        }
        private double? _j801;
        public double J801
        {
            get
            {
                //Debug.WriteLine("J801");
                if (_j801 == null)
                    _j801 = F801 * (1 - I801);
                return _j801.Value;
            }
        }
        private double? _j802;
        public double J802
        {
            get
            {
                //Debug.WriteLine("J802");
                if (_j802 == null)
                    _j802 = F802 * (1 - I802);
                return _j802.Value;
            }
        }
        private double? _j803;
        public double J803
        {
            get
            {
                //Debug.WriteLine("J803");
                if (_j803 == null)
                    _j803 = F803 * (1 - I803);
                return _j803.Value;
            }
        }
        private double? _j804;
        public double J804
        {
            get
            {
                //Debug.WriteLine("J804");
                if (_j804 == null)
                    _j804 = F804 * (1 - I804);
                return _j804.Value;
            }
        }
        private double? _j805;
        public double J805
        {
            get
            {
                //Debug.WriteLine("J805");
                if (_j805 == null)
                    _j805 = F805 * (1 - I805);
                return _j805.Value;
            }
        }
        private double? _j806;
        public double J806
        {
            get
            {
                //Debug.WriteLine("J806");
                if (_j806 == null)
                    _j806 = F806 * (1 - I806);
                return _j806.Value;
            }
        }
        private double? _j807;
        public double J807
        {
            get
            {
                //Debug.WriteLine("J807");
                if (_j807 == null)
                    _j807 = F807 * (1 - I807);
                return _j807.Value;
            }
        }
        public double J808
        {
            get
            {
                //Debug.WriteLine("J808");
                return J607 + J608 + J609 + J610 + J611 + J612 + J613 + J614 + J615 + J616 + J617 + J618 + J619 + J620 + J621 + J622 + J623 + J624 + J625 + J626 + J627 + J628 + J629 + J630 + J631 + J632 + J633 + J634 + J635 + J636 + J637 + J638 + J639 + J640 + J641 + J642 + J643 + J644 + J645 + J646 + J647 + J648 + J649 + J650 + J651 + J652 + J653 + J654 + J655 + J656 + J657 + J658 + J659 + J660 + J661 + J662 + J663 + J664 + J665 + J666 + J667 + J668 + J669 + J670 + J671 + J672 + J673 + J674 + J675 + J676 + J677 + J678 + J679 + J680 + J681 + J682 + J683 + J684 + J685 + J686 + J687 + J688 + J689 + J690 + J691 + J692 + J693 + J694 + J695 + J696 + J697 + J698 + J699 + J700 + J701 + J702 + J703 + J704 + J705 + J706 + J707 + J708 + J709 + J710 + J711 + J712 + J713 + J714 + J715 + J716 + J717 + J718 + J719 + J720 + J721 + J722 + J723 + J724 + J725 + J726 + J727 + J728 + J729 + J730 + J731 + J732 + J733 + J734 + J735 + J736 + J737 + J738 + J739 + J740 + J741 + J742 + J743 + J744 + J745 + J746 + J747 + J748 + J749 + J750 + J751 + J752 + J753 + J754 + J755 + J756 + J757 + J758 + J759 + J760 + J761 + J762 + J763 + J764 + J765 + J766 + J767 + J768 + J769 + J770 + J771 + J772 + J773 + J774 + J775 + J776 + J777 + J778 + J779 + J780 + J781 + J782 + J783 + J784 + J785 + J786 + J787 + J788 + J789 + J790 + J791 + J792 + J793 + J794 + J795 + J796 + J797 + J798 + J799 + J800 + J801 + J802 + J803 + J804 + J805 + J806 + J807;
            }
        }

        #endregion J808

        
        private void GenerateJ808Table()
        {
            _b576 = B576;
            _e33 = E33;
            _e20 = E20;
            _e39 = E39;
            _b571 = B571;
            _b588 = B588;
            _b593 = B593;
            _b596 = B596;
            var columns = new List<string> { "A", "C", "D", "E", "F", "I", "J" };
            foreach(var col in columns)
                for (int i = 607; i <= 807; i++)
                {
                    var prop = typeof(SeparatorSizing).GetProperty(string.Format("{0}{1}", col, i)).GetValue(this, null);
                }
        }

        public SeparatorSizing()
        {
            B57 = 489;
            B58 = 1.09;
            H7 = 6.11927343917312;
            B56 = 0.125;
            B54 = 20000;
            B55 = 1;
            B3 = Position.Horizontal;
            H8 = 2.83267005098296;
            B514 = GeneralClassification.Mesh;
            C514 = GeneralClassification.None;
            B18 = 1000;
            H9 = 0;
            A108 = 3;
            B113 = BooleanResponse.N;
            B114 = BooleanResponse.N;
            B115 = BooleanResponse.N;
            B50 = 0.75;
            B15 = BooleanResponse.N;
            H171 = 3.5;
            B21 = 35;
            B20 = 0.7;
            B29 = 14.7;
            B16 = 100;
            C114 = 0.50; //50%
            E171 = 2500;
            C113 = 0.5; //50%
            B8 = 100;
            B11 = 1.15;
            B7 = 1200;
            B48 = 2;
            B173 = 1;
            A119 = 1;
            B14 = 1;
            A97 = 1;

            #region Nozzle Weights
            K165 = 2;
            L165 = 2;
            L166 = 3;
            L167 = 4;
            L168 = 6;
            L169 = 8;
            L170 = 10;
            L171 = 12;
            L172 = 14;
            L173 = 16;
            L174 = 18;
            L175 = 20;
            L176 = 24;
            L177 = 26;
            L178 = 28;
            L179 = 30;
            L180 = 32;
            M165 = 2.375;
            M166 = 3.5;
            M167 = 4.5;
            M168 = 6.625;
            M169 = 8.625;
            M170 = 10.75;
            M171 = 12.75;
            M172 = 14;
            M173 = 16;
            M174 = 18;
            M175 = 20;
            M176 = 24;
            M177 = 26;
            M178 = 28;
            M179 = 30;
            M180 = 32;
            O165 = 15;
            O166 = 25;
            O167 = 47;
            O168 = 75;
            O169 = 102;
            O170 = 143;
            O171 = 205;
            O172 = 211;
            O173 = 246;
            O174 = 270;
            O175 = 311;
            O176 = 423;
            O177 = 500;
            O178 = 570;
            O179 = 650;
            O180 = 750;
            P165 = 20;
            P166 = 35;
            P167 = 62;
            P168 = 105;
            P169 = 148;
            P170 = 210;
            P171 = 275;
            P172 = 324;
            P173 = 404;
            P174 = 465;
            P175 = 549;
            P176 = 778;
            P177 = 900;
            P178 = 1030;
            P179 = 1160;
            P180 = 1300;
            Q165 = 20;
            Q166 = 36;
            Q167 = 77;
            Q168 = 152;
            Q169 = 207;
            Q170 = 324;
            Q171 = 393;
            Q172 = 471;
            Q173 = 638;
            Q174 = 731;
            Q175 = 916;
            Q176 = 1210;
            Q177 = 1390;
            Q178 = 1600;
            Q179 = 1830;
            Q180 = 2100;
            R165 = 42;
            R166 = 51;
            R167 = 93;
            R168 = 191;
            R169 = 297;
            R170 = 422;
            R171 = 518;
            R172 = 624;
            R173 = 750;
            R174 = 950;
            R175 = 1121;
            R176 = 1865;
            R177 = 2265;
            R178 = 2700;
            R179 = 3100;
            R180 = 3500;
            S165 = 42;
            S166 = 67;
            S167 = 110;
            S168 = 215;
            S169 = 337;
            S170 = 546;
            S171 = 946;
            S172 = 1116;
            S173 = 1371;
            S174 = 1674;
            S175 = 1943;
            S176 = 2936;
            S177 = 3400;
            S178 = 3900;
            S179 = 4400;
            S180 = 4900;
            #endregion

            #region Inlet Device
            A101 = 1;
            A102 = 2;
            A103 = 3;
            A104 = 4;
            A105 = 5;
            B101 = 1; //No inlet device
            B102 = 2; //Diverter/splash plate
            B103 = 3; //Half-open pipe
            B104 = 4; //Multi-vane (Schoepentoeter/Evenflow)
            B105 = 5; //Cyclonic
            C101 = 700;
            C102 = 950;
            C103 = 1400;
            C104 = 4000;
            C105 = 10000;
            E101 = 3;
            E102 = 1.5;
            E103 = 2;
            E104 = 20;
            E105 = 50;
            F101 = 0.4;
            F102 = 0.4;
            F103 = 0.3;
            F104 = 0.2;
            F105 = 0.2;
            G101 = 1.0;
            G102 = 1.5;
            G103 = 1.0;
            G104 = 1.1;
            G105 = 1.1;
            H101 = 0.6;
            H102 = 0.5;
            H103 = 0.45;
            H104 = 0.3;
            H105 = 0.45;
            I101 = 0;
            I102 = 50;
            I103 = 65;
            I104 = 85;
            I105 = 150;
            #endregion

            #region Mesh Pads
            A123 = 0; //None
            A124 = 1; //M1
            A125 = 2; //M2
            A126 = 3; //M3
            A127 = 4; //M4
            B123 = 0; //None
            B124 = 1; //High capacity wire mesh
            B125 = 2; //Standard wire mesh
            B126 = 3; //High eff. wire mesh - 0.011
            B127 = 4; //High eff. wire mesh - 0.006
            C123 = (double)Position.N_A; //None
            C124 = (double)Position.Vertical; //V
            C125 = (double)Position.Vertical; //V
            C126 = (double)Position.Vertical; //V
            C127 = (double)Position.Vertical; //V
            D123 = (double)Position.N_A;
            D124 = 7;
            D125 = 9;
            D126 = 12;
            D127 = 12;
            E123 = (double)Position.N_A;
            E124 = 0.986;
            E125 = 0.982;
            E126 = 0.976;
            E127 = 0.976;
            F123 = (double)Position.N_A;
            F124 = 0.011;
            F125 = 0.011;
            F126 = 0.011;
            F127 = 0.006;
            G123 = (double)Position.N_A;
            G124 = 65;
            G125 = 85;
            G126 = 115;
            G127 = 200;
            H123 = (double)Position.N_A;
            H124 = 0.5;
            H125 = 0.5;
            H126 = 0.5;
            H127 = 0.5;
            I123 = (double)Position.N_A;
            J123 = (double)Position.N_A;
            J124 = 1;
            J125 = 0.75;
            J126 = 0.65;
            J127 = 0.625;
            K123 = (double)Position.N_A;
            K124 = 0.1; //10%
            K125 = 0.1; //10%
            K126 = 0.1; //10%
            K127 = 0.1; //10%
            L123 = (double)Position.N_A;
            M123 = (double)Position.N_A;
            N123 = (double)Position.N_A;
            N124 = 0.75;
            N125 = 0.75;
            N126 = 0.75;
            N127 = 0.75;
            O123 = (double)Position.N_A;
            #endregion

            A131 = 2; //M2 

            #region Vane Packs
            A136 = 0; //None
            A137 = 1; //V1
            A138 = 2; //V2
            A139 = 3; //V3
            B136 = 0; //None
            B137 = 1; //Simple vane design
            B138 = 2; //High performance vane design - single pocket
            B139 = 3; //High performance vane design - double pocket
            C136 = (double)Position.N_A; //None
            C137 = (double)Position.Vertical; //V
            C138 = (double)Position.Vertical; //V
            C139 = (double)Position.Vertical; //V
            D136 = (double)Position.N_A;
            D137 = 0.5;
            D138 = 0.5;
            D139 = 0.5;
            E136 = (double)Position.N_A;
            E137 = 45;
            E138 = 45;
            E139 = 45;
            F136 = (double)Position.N_A;
            F137 = 6;
            F138 = 6;
            F139 = 6;
            G136 = (double)Position.N_A;
            G137 = 0.7;
            G138 = 0.7;
            G139 = 0.7;
            H136 = (double)Position.N_A;
            I136 = (double)Position.N_A;
            I137 = 2;
            I138 = 5;
            I139 = 8;
            J136 = (double)Position.N_A;
            J137 = 0.1; //10%
            J138 = 0.1; //10%
            J139 = 0.1; //10%
            K136 = (double)Position.N_A;
            K137 = 15;
            K138 = 22.5;
            K139 = 30;
            L136 = (double)Position.N_A;
            L137 = 20;
            L138 = 30;
            L139 = 35;
            M136 = (double)Position.N_A;
            M137 = 0.65;
            M138 = 0.65;
            M139 = 0.65;
            N136 = (double)Position.N_A;
            #endregion

            A143 = 3; //v3

            #region Demisting Cyclones
            A149 = 0; //None
            A150 = 1; //C1
            A151 = 2; //C2;
            B149 = 0; //None
            B150 = 1; //2" axial-flow cyclone
            B151 = 2; //3" axial-flow cyclone
            C149 = (double)Position.N_A; //None
            C150 = (double)Position.Vertical; //V
            C151 = (double)Position.Vertical; //V;
            D149 = (double)Position.N_A;
            D150 = 2;
            D151 = 3;
            E149 = (double)Position.N_A;
            E150 = 1.75;
            E151 = 1.75;
            F149 = (double)Position.N_A;
            G149 = (double)Position.N_A;
            H149 = (double)Position.N_A;
            H150 = 10;
            H151 = 15;
            I149 = (double)Position.N_A;
            I150 = 45;
            I151 = 45;
            J149 = (double)Position.N_A;
            J150 = 1.10;
            J151 = 1.30;
            K149 = (double)Position.N_A;
            K150 = 4;
            K151 = 6;
            L149 = (double)Position.N_A;
            L150 = 9;
            L151 = 9;
            M149 = (double)Position.N_A;
            M150 = 0.1; //10%
            M151 = 0.1; //10%
            N149 = (double)Position.N_A;
            N150 = 50;
            N151 = 40;
            O149 = (double)Position.N_A;
            O150 = 0.65;
            O151 = 0.65;
            #endregion

            A155 = 1; //C1

            //Contraints
            B35 = 80;
            B36 = 20;
            B37 = 10;
            B68 = 0.1;
            B70 = 500;
            B69 = 0.2; //2%
            C115 = 0.5; //50%
            B597 = 0.72;
            B590 = 1;
            B594 = 5;
            A607 = 1;
            E607 = 0;

            var sw = Stopwatch.StartNew();
            GenerateJ808Table();
            Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        public double Solve()
        {
            //int varNumber = 2;
            //int constNumber = 8;

            //double[] ub_contraints = new double[constNumber]l;

            //using (Problem prob = new Problem(Solver_Type.Minimize, varNumber, constNumber))
            //{
            //    prob.
            //}

            return 0;
        }

        public double Test
        {
            get
            {
                return 0;
            }
        }

        public double B585
        {
            get
            {
                return 0.04 * (Math.Pow(B584, 0.28)) * Math.Pow((B581 / B580), 0.4);
            }
        }
        public double B593
        {
            get
            {
                return 1000000 * (Math.Pow((B590 * 0.001 * E40 / 2), 0.6)) * (Math.Pow((E33 * 16), -0.2)) * (Math.Pow(B592, -0.4));
            }
        }
        public double B597 { get; set; }
        public double B596
        {
            get
            {
                return (B593 - B595) / B595;
            }
        }
        public double B584
        {
            get
            {
                return Math.Pow((B582 / 3.2808), 2) / (9.81 * 0.3048 * B580);
            }
        }
        public double B581
        {
            get
            {
                return B39 + (B877 - B880);
            }
        }
        public double B590 { get; set; }
        public double B592
        {
            get
            {
                return (E33 * 16) * B589 * (Math.Pow((0.3048 * B582), 3)) / (2 * 0.3048 * B591) * (1 - 2 * B589 - (Math.Pow(B589, 2)) * (Math.Pow(B585, 2) - 1));
            }
        }
        public double B595
        {
            get
            {
                return B593 / B594;
            }
        }
        public double B582
        {
            get
            {
                return Math.Pow((Math.Pow(B579, 2) + 2 * 32.17 * B581), 0.5);
            }
        }
        public double B589
        {
            get
            {
                return (B3 == Position.Vertical ? Math.Pow(B583, 2) / Math.Pow(H7, 2) : Math.Pow(B583, 2) / Math.Pow((2 * Math.Pow((H7 * B880 - (Math.Pow(B880, 2))), 0.5)), 2));
            }
        }
        public double B591
        {
            get
            {
                return 0.25 * B588 + 0.1;
            }
        }
        public double B594 { get; set; }
        public double B583
        {
            get
            {
                return Math.Pow((B578 / B582 / 0.7854), 0.5);
            }
        }

        public double B23 { get; set; }
        public double B26 { get; set; }
        public double B30 { get; set; }
        public double B31 { get; set; }
        public double B59 { get; set; }
        public double B60 { get; set; }
        public double B61 { get; set; }
        public double B71 { get; set; }
        public double B72 { get; set; }

        public double D113 { get; set; }
        public double D114 { get; set; }
        public double D115 { get; set; }

        public double B75 { get { return B174; } }
        public double B76 { get { return B837; } }
        public double B88 { get { return B525; } }
        public double B91 { get { return C525; } }

        public double H14 { get { return H7; } }
        public double H24 { get { return B59 * B57 * (3.1416 * H16 * H17 * H19 / 12 + 2 * B58 * B60 * H20 / 12 * Math.Pow(H16, 2)) + B61 * (B456 + B473 + B569 + B541 + C541) + B59 * (B194 + E182 + H180); } }
        public double H36 { get { return C88 - B88; } }
        public double H40 { get { return C71 - B71; } }
        public double H41 { get { return B3 == Position.Horizontal ? C72 - B72 : -99; } }
        public double H51 { get { return B181; } }
        public double H52 { get { return E175; } }
        public double H53 { get { return H174; } }
        public double H62 { get { return B880; } }

        public double C71 { get { return B572; } }
        public double C72 { get { return B3 == Position.Horizontal ? B571 : 0; } } //"N/A"
        public double C73 { get { return B190; } }
        public double C74 { get { return B176; } }
        public double C75 { get { return B186; } }
        public double C76 { get { return B837; } }
        public double C77 { get { return B211; } }
        public double C78 { get { return B214; } }
        public double C79 { get { return B454; } }
        public double C80 { get { return J441; } }
        public double C82 { get { return B474; } }
        public double C83 { get { return B476; } }
        public double C84 { get { return B481; } }
        public double C85 { get { return L441; } }
        public double C86 { get { return M441; } }
        public double C87 { get { return B533; } }
        public double C88 { get { return B537; } }
        public double C89 { get { return T442; } }
        public double C90 { get { return T441; } }
        public double C91 { get { return C537; } }
        public double C92 { get { return Z231 == GeneralClassification.None ? 0 : Z442; } }

        public double B176 { get { return 0; } } //HLookUp "Inlet flow pattern"!D43
        public double B186 { get { return B169 * Math.Pow(B185, 2); } }
        public double B211 { get { return B210 * B209 / (1 + B210); } }
        public double B214 { get { return B213 * 42; } }
        public double B454 { 
            get 
            {
 
                return Math.Min(1, 
                (A108 == 1 ? (B453 > 800 ? 0.1 : (1 - 0.0012323 * B453) / (1 - 0.00109 * B453 + 0.00000022685 * Math.Pow(B453, 2)))
                : (A108 == 2 ? (B453 > 1100 ? 0.1 : (1 - 0.0008757 * B453) / (1 - 0.0007705 * B453 + 0.0000000703 * Math.Pow(B453, 2)))
                : (A108 == 3 ? (B453 > 1800 ? 0.1 : (1 - 0.0005276 * B453) / (1 - 0.00045404 * B453 - 0.00000002055 * Math.Pow(B453, 2)))
                : (A108 == 4 ? (B453 > 9000 ? 0.1 : (1 - 0.00010422 * B453) / (1 - 0.00010216 * B453 + 0.0000000013243 * Math.Pow(B453, 2)))
                : (B453 > 15000 ? 0.1 : (0.9841 - 0.000064214 * B453) / (1 - 0.000065651 * B453 + 0.0000000004124 * Math.Pow(B453, 2))))))));
            }   
        }
        public double B476 { get { return Math.Pow(B475 / ((E33 - E20) / E20), 0.5); } }
        public double B481 { 
            get  //Replaced 476 TO 480 Due missing text in excel.
            { 
                return B3 == Position.Vertical ? 
                    (B480 == SettlingLaw.Stokes ? 304800 * Math.Pow((B475 * 18 * E25 / (1488 * 32.2 * (E33 - E20))), 0.5) 
                    : (B480 == SettlingLaw.Intermediate ? 304800 * Math.Pow((B475 * Math.Pow(E20, 0.29) * Math.Pow(E25, 0.43) / (3.54 * Math.Pow(32.2, 0.71) * Math.Pow((E33 - E20), 0.71))), (1 / 1.14))
                    : 304800 * (Math.Pow((B475 / 1.74), 2)) * E20 / (32.2 * (E33 - E20)))) 
                    : (B480 == SettlingLaw.Stokes ? 304800 * Math.Pow((B478 * 18 * E25 / (1488 * 32.2 * (E33 - E20))), 0.5) 
                    : (B480 == SettlingLaw.Intermediate ? 304800 * Math.Pow((B478 * Math.Pow(E20, 0.29) * Math.Pow(E25, 0.43) / (3.54 * Math.Pow(32.2, 0.71) * Math.Pow((E33 - E20), 0.71))), (1 / 1.14))
                    : 304800 * (Math.Pow((B478 / 1.74), 2)) * E20 / (32.2 * (E33 - E20)))); 
            } 
        }
        public double B533 { get { return B514 == GeneralClassification.None ? 0 : B532 * E9 / 1440 / B529; } } //N/A
        public double B537 { get { return B514 == GeneralClassification.None ? 0 : B531 / Math.Pow(((E33 - E20) / E20), 0.5); } } //N/A
        public double C537 { get { return C514 == GeneralClassification.None ? 0 : C531 / Math.Pow(((E33 - E20) / E20), 0.5); } } //N/A
        public double J441
        {
            get
            {
                //Debug.WriteLine("J441");
                //return J240 + J241 + J242 + J243 + J244 + J245 + J246 + J247 + J248 + J249 + J250 + J251 + J252 + J253 + J254 + J255 + J256 + J257 + J258 + J259 + J260 + J261 + J262 + J263 + J264 + J265 + J266 + J267 + J268 + J269 + J270 + J271 + J272 + J273 + J274 + J275 + J276 + J277 + J278 + J279 + J280 + J281 + J282 + J283 + J284 + J285 + J286 + J287 + J288 + J289 + J290 + J291 + J292 + J293 + J294 + J295 + J296 + J297 + J298 + J299 + J300 + J301 + J302 + J303 + J304 + J305 + J306 + J307 + J308 + J309 + J310 + J311 + J312 + J313 + J314 + J315 + J316 + J317 + J318 + J319 + J320 + J321 + J322 + J323 + J324 + J325 + J326 + J327 + J328 + J329 + J330 + J331 + J332 + J333 + J334 + J335 + J336 + J337 + J338 + J339 + J340 + J341 + J342 + J343 + J344 + J345 + J346 + J347 + J348 + J349 + J350 + J351 + J352 + J353 + J354 + J355 + J356 + J357 + J358 + J359 + J360 + J361 + J362 + J363 + J364 + J365 + J366 + J367 + J368 + J369 + J370 + J371 + J372 + J373 + J374 + J375 + J376 + J377 + J378 + J379 + J380 + J381 + J382 + J383 + J384 + J385 + J386 + J387 + J388 + J389 + J390 + J391 + J392 + J393 + J394 + J395 + J396 + J397 + J398 + J399 + J400 + J401 + J402 + J403 + J404 + J405 + J406 + J407 + J408 + J409 + J410 + J411 + J412 + J413 + J414 + J415 + J416 + J417 + J418 + J419 + J420 + J421 + J422 + J423 + J424 + J425 + J426 + J427 + J428 + J429 + J430 + J431 + J432 + J433 + J434 + J435 + J436 + J437 + J438 + J439 + J440;
                return 0;
            }
        }
        public double M441
        {
            get
            {
                //Debug.WriteLine("M441");
                //return M240 + M241 + M242 + M243 + M244 + M245 + M246 + M247 + M248 + M249 + M250 + M251 + M252 + M253 + M254 + M255 + M256 + M257 + M258 + M259 + M260 + M261 + M262 + M263 + M264 + M265 + M266 + M267 + M268 + M269 + M270 + M271 + M272 + M273 + M274 + M275 + M276 + M277 + M278 + M279 + M280 + M281 + M282 + M283 + M284 + M285 + M286 + M287 + M288 + M289 + M290 + M291 + M292 + M293 + M294 + M295 + M296 + M297 + M298 + M299 + M300 + M301 + M302 + M303 + M304 + M305 + M306 + M307 + M308 + M309 + M310 + M311 + M312 + M313 + M314 + M315 + M316 + M317 + M318 + M319 + M320 + M321 + M322 + M323 + M324 + M325 + M326 + M327 + M328 + M329 + M330 + M331 + M332 + M333 + M334 + M335 + M336 + M337 + M338 + M339 + M340 + M341 + M342 + M343 + M344 + M345 + M346 + M347 + M348 + M349 + M350 + M351 + M352 + M353 + M354 + M355 + M356 + M357 + M358 + M359 + M360 + M361 + M362 + M363 + M364 + M365 + M366 + M367 + M368 + M369 + M370 + M371 + M372 + M373 + M374 + M375 + M376 + M377 + M378 + M379 + M380 + M381 + M382 + M383 + M384 + M385 + M386 + M387 + M388 + M389 + M390 + M391 + M392 + M393 + M394 + M395 + M396 + M397 + M398 + M399 + M400 + M401 + M402 + M403 + M404 + M405 + M406 + M407 + M408 + M409 + M410 + M411 + M412 + M413 + M414 + M415 + M416 + M417 + M418 + M419 + M420 + M421 + M422 + M423 + M424 + M425 + M426 + M427 + M428 + M429 + M430 + M431 + M432 + M433 + M434 + M435 + M436 + M437 + M438 + M439 + M440;
                return 0;
            }
        }
        public double T441
        {
            get
            {
                //Debug.WriteLine("T441");
                //return T240 + T241 + T242 + T243 + T244 + T245 + T246 + T247 + T248 + T249 + T250 + T251 + T252 + T253 + T254 + T255 + T256 + T257 + T258 + T259 + T260 + T261 + T262 + T263 + T264 + T265 + T266 + T267 + T268 + T269 + T270 + T271 + T272 + T273 + T274 + T275 + T276 + T277 + T278 + T279 + T280 + T281 + T282 + T283 + T284 + T285 + T286 + T287 + T288 + T289 + T290 + T291 + T292 + T293 + T294 + T295 + T296 + T297 + T298 + T299 + T300 + T301 + T302 + T303 + T304 + T305 + T306 + T307 + T308 + T309 + T310 + T311 + T312 + T313 + T314 + T315 + T316 + T317 + T318 + T319 + T320 + T321 + T322 + T323 + T324 + T325 + T326 + T327 + T328 + T329 + T330 + T331 + T332 + T333 + T334 + T335 + T336 + T337 + T338 + T339 + T340 + T341 + T342 + T343 + T344 + T345 + T346 + T347 + T348 + T349 + T350 + T351 + T352 + T353 + T354 + T355 + T356 + T357 + T358 + T359 + T360 + T361 + T362 + T363 + T364 + T365 + T366 + T367 + T368 + T369 + T370 + T371 + T372 + T373 + T374 + T375 + T376 + T377 + T378 + T379 + T380 + T381 + T382 + T383 + T384 + T385 + T386 + T387 + T388 + T389 + T390 + T391 + T392 + T393 + T394 + T395 + T396 + T397 + T398 + T399 + T400 + T401 + T402 + T403 + T404 + T405 + T406 + T407 + T408 + T409 + T410 + T411 + T412 + T413 + T414 + T415 + T416 + T417 + T418 + T419 + T420 + T421 + T422 + T423 + T424 + T425 + T426 + T427 + T428 + T429 + T430 + T431 + T432 + T433 + T434 + T435 + T436 + T437 + T438 + T439 + T440;
                return 0;
            }
        }
        public double L441 { get { return (J441 - M441) / J441; } }
        public double T442 { get { return M441 == 0 ? 0 : (M441 - T441) / M441; } }
        public GeneralClassification Z231 { get { return C514; } }
        public double Z442 { get { return T441 == 0 ? 0 : (T441 - Z441) / T441; } }

        public double E9 { get { return (B13*1000000-B12*E29)*0.000001; } }
        public double E25 { get { return E22 * Math.Exp(E23 * Math.Pow((E20 / 62.43), E24)); } }
        public double B185 { get { return B168 / (0.7854 * Math.Pow((B184 / 12), 2)); } }
        public double B210 { get { return 0.00000009 * ((B184 / 12 * Math.Pow(B188, 3) * Math.Pow((E33 * E20), 0.5)) / E41) * Math.Pow((Math.Pow(E20, (1 - B205)) * Math.Pow((E25 / 1488), B205) / (Math.Pow(B202, (1 + B205)) * 32.17 * E33)), (1 / (2 - B205))); } }
        public double B209 { get { return 1 - B208 / (E32 * E33); } }
        public double B213 { get { return B212 * 86400 / 5.615 / B13; } }
        public double B453 { get { return B186; } }
        public double B478 { get { return B482 / B477; } }
        public SettlingLaw B480 { get { return B479 < B891 ? SettlingLaw.Stokes : (B479 < B892 ? SettlingLaw.Intermediate: (B479 < B893 ? SettlingLaw.Newtons : SettlingLaw.OutOfRange)); } }
        public double B531 { get { return B530; } }
        public double B532 { get { return B514 == GeneralClassification.None ? 0 : M441; } } //N/A
        public double C531 { get { return C530; } }

        public double C530 { get { return C514 == GeneralClassification.None ? 0 : B460 * B523 / C529; } } //N/A
        public double B202 { get { return Math.Pow(((0.0091 * (0.001 * E40 * 2.2) * B184 / 12) / (E20 * (Math.Pow(B188, 2)))), 0.5); } }
        public double B205 { get { return B204 == SettlingLaw.Stokes ? 1 : (B204 == SettlingLaw.Intermediate ? 0.6 : (B204 == SettlingLaw.Newtons ? 0 : -1 )); } } /*"Out of Range"*/
        public double B208 { get { return 0.25 * (E39 / 1488) * 3.1416 * B184 / 12 * B207; } }
        public double B212 { get { return B211 * E32; } }
        public double B477 { get { return H8 / B475; } }
        public double B479 { 
            get 
            { 
                return B3 == Position.Vertical ? 
                    304800 * Math.Pow((B475 * (Math.Pow(E20, 0.29)) * (Math.Pow(E25, 0.43)) / (3.54 * (Math.Pow(32.2, 0.71)) * Math.Pow((E33 - E20), 0.71))), (1 / 1.14))
                    : 304800 * Math.Pow((B478 * (Math.Pow(E20, 0.29)) * (Math.Pow(E25, 0.43)) / (3.54 * (Math.Pow(32.2, 0.71)) * Math.Pow((E33 - E20), 0.71))), (1 / 1.14)); 
            } 
        }
        public double B482 { get { return H7 - B877; } }
        public double B530 { get { return B514 == GeneralClassification.None ? 0 : (C514 == GeneralClassification.None ? B460 * B523 / B529 : C530); } } //N/A
        public double B891 { get { return 0.025 * 304800 * Math.Pow((Math.Pow(E25, 2) / (32.2 * E20 * (E33 - E20))), 0.333); } }
        public double B892 { get { return 0.334 * 304800 * Math.Pow((Math.Pow(E25, 2) / (32.2 * E20 * (E33 - E20))), 0.333); } }
        public double B893 { get { return 18.13 * 304800 * Math.Pow((Math.Pow(E25, 2) / (32.2 * E20 * (E33 - E20))), 0.333); } }
        public double E22 { get { return 0.0001 * (((7.77 + 0.0063 * E10) * Math.Pow((B16 + 460), 1.5)) / (122.4 + 12.9 * E10 + (B16 + 460))); } }
        public double E23 { get { return (2.57 + 1914.5 / (B16 + 460) + 0.0095 * E10); } }
        public double E24 { get { return 1.1 + 0.04 * E23; } }

        public SettlingLaw B204 { get { return B203 < B891 ? SettlingLaw.Stokes : (B203 < B892 ? SettlingLaw.Intermediate : (B203 < B893 ? SettlingLaw.Newtons : SettlingLaw.OutOfRange)); } }
        public double B207 { get { return 7.3 * Math.Pow((Math.Log10(B206)), 3) + 44.2 * Math.Pow((Math.Log10(B206)), 2) - 263 * Math.Log10(B206) + 439; } }

        public double B203 { get { return B202 * 0.3048 * 1000000; } }
        public double B206 { get { return (E39 / E25) * Math.Pow((E20 / E33), 0.5); } }
    }
}
