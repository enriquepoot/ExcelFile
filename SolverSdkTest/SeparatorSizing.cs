using SolverPlatform;
using System;
using System.Collections.Generic;
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
        public enum SettlingLaw { OiutOfRange=0, Stokes=1, Intermediate, Newtons}

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
                return (B574 < B897 ? SettlingLaw.Stokes : (B574 < B898 ? SettlingLaw.Intermediate : (B574 < B899 ? SettlingLaw.Newtons : SettlingLaw.OiutOfRange)));
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
        public double A607 { get; set; }
        public double A608
        {
            get
            {
                return (A807 - A607) / 200 + A607;
            }
        }
        public double A609
        {
            get
            {
                return (A807 - A607) / 200 + A608;
            }
        }
        public double A610
        {
            get
            {
                return (A807 - A607) / 200 + A609;
            }
        }
        public double A611
        {
            get
            {
                return (A807 - A607) / 200 + A610;
            }
        }
        public double A612
        {
            get
            {
                return (A807 - A607) / 200 + A611;
            }
        }
        public double A613
        {
            get
            {
                return (A807 - A607) / 200 + A612;
            }
        }
        public double A614
        {
            get
            {
                return (A807 - A607) / 200 + A613;
            }
        }
        public double A615
        {
            get
            {
                return (A807 - A607) / 200 + A614;
            }
        }
        public double A616
        {
            get
            {
                return (A807 - A607) / 200 + A615;
            }
        }
        public double A617
        {
            get
            {
                return (A807 - A607) / 200 + A616;
            }
        }
        public double A618
        {
            get
            {
                return (A807 - A607) / 200 + A617;
            }
        }
        public double A619
        {
            get
            {
                return (A807 - A607) / 200 + A618;
            }
        }
        public double A620
        {
            get
            {
                return (A807 - A607) / 200 + A619;
            }
        }
        public double A621
        {
            get
            {
                return (A807 - A607) / 200 + A620;
            }
        }
        public double A622
        {
            get
            {
                return (A807 - A607) / 200 + A621;
            }
        }
        public double A623
        {
            get
            {
                return (A807 - A607) / 200 + A622;
            }
        }
        public double A624
        {
            get
            {
                return (A807 - A607) / 200 + A623;
            }
        }
        public double A625
        {
            get
            {
                return (A807 - A607) / 200 + A624;
            }
        }
        public double A626
        {
            get
            {
                return (A807 - A607) / 200 + A625;
            }
        }
        public double A627
        {
            get
            {
                return (A807 - A607) / 200 + A626;
            }
        }
        public double A628
        {
            get
            {
                return (A807 - A607) / 200 + A627;
            }
        }
        public double A629
        {
            get
            {
                return (A807 - A607) / 200 + A628;
            }
        }
        public double A630
        {
            get
            {
                return (A807 - A607) / 200 + A629;
            }
        }
        public double A631
        {
            get
            {
                return (A807 - A607) / 200 + A630;
            }
        }
        public double A632
        {
            get
            {
                return (A807 - A607) / 200 + A631;
            }
        }
        public double A633
        {
            get
            {
                return (A807 - A607) / 200 + A632;
            }
        }
        public double A634
        {
            get
            {
                return (A807 - A607) / 200 + A633;
            }
        }
        public double A635
        {
            get
            {
                return (A807 - A607) / 200 + A634;
            }
        }
        public double A636
        {
            get
            {
                return (A807 - A607) / 200 + A635;
            }
        }
        public double A637
        {
            get
            {
                return (A807 - A607) / 200 + A636;
            }
        }
        public double A638
        {
            get
            {
                return (A807 - A607) / 200 + A637;
            }
        }
        public double A639
        {
            get
            {
                return (A807 - A607) / 200 + A638;
            }
        }
        public double A640
        {
            get
            {
                return (A807 - A607) / 200 + A639;
            }
        }
        public double A641
        {
            get
            {
                return (A807 - A607) / 200 + A640;
            }
        }
        public double A642
        {
            get
            {
                return (A807 - A607) / 200 + A641;
            }
        }
        public double A643
        {
            get
            {
                return (A807 - A607) / 200 + A642;
            }
        }
        public double A644
        {
            get
            {
                return (A807 - A607) / 200 + A643;
            }
        }
        public double A645
        {
            get
            {
                return (A807 - A607) / 200 + A644;
            }
        }
        public double A646
        {
            get
            {
                return (A807 - A607) / 200 + A645;
            }
        }
        public double A647
        {
            get
            {
                return (A807 - A607) / 200 + A646;
            }
        }
        public double A648
        {
            get
            {
                return (A807 - A607) / 200 + A647;
            }
        }
        public double A649
        {
            get
            {
                return (A807 - A607) / 200 + A648;
            }
        }
        public double A650
        {
            get
            {
                return (A807 - A607) / 200 + A649;
            }
        }
        public double A651
        {
            get
            {
                return (A807 - A607) / 200 + A650;
            }
        }
        public double A652
        {
            get
            {
                return (A807 - A607) / 200 + A651;
            }
        }
        public double A653
        {
            get
            {
                return (A807 - A607) / 200 + A652;
            }
        }
        public double A654
        {
            get
            {
                return (A807 - A607) / 200 + A653;
            }
        }
        public double A655
        {
            get
            {
                return (A807 - A607) / 200 + A654;
            }
        }
        public double A656
        {
            get
            {
                return (A807 - A607) / 200 + A655;
            }
        }
        public double A657
        {
            get
            {
                return (A807 - A607) / 200 + A656;
            }
        }
        public double A658
        {
            get
            {
                return (A807 - A607) / 200 + A657;
            }
        }
        public double A659
        {
            get
            {
                return (A807 - A607) / 200 + A658;
            }
        }
        public double A660
        {
            get
            {
                return (A807 - A607) / 200 + A659;
            }
        }
        public double A661
        {
            get
            {
                return (A807 - A607) / 200 + A660;
            }
        }
        public double A662
        {
            get
            {
                return (A807 - A607) / 200 + A661;
            }
        }
        public double A663
        {
            get
            {
                return (A807 - A607) / 200 + A662;
            }
        }
        public double A664
        {
            get
            {
                return (A807 - A607) / 200 + A663;
            }
        }
        public double A665
        {
            get
            {
                return (A807 - A607) / 200 + A664;
            }
        }
        public double A666
        {
            get
            {
                return (A807 - A607) / 200 + A665;
            }
        }
        public double A667
        {
            get
            {
                return (A807 - A607) / 200 + A666;
            }
        }
        public double A668
        {
            get
            {
                return (A807 - A607) / 200 + A667;
            }
        }
        public double A669
        {
            get
            {
                return (A807 - A607) / 200 + A668;
            }
        }
        public double A670
        {
            get
            {
                return (A807 - A607) / 200 + A669;
            }
        }
        public double A671
        {
            get
            {
                return (A807 - A607) / 200 + A670;
            }
        }
        public double A672
        {
            get
            {
                return (A807 - A607) / 200 + A671;
            }
        }
        public double A673
        {
            get
            {
                return (A807 - A607) / 200 + A672;
            }
        }
        public double A674
        {
            get
            {
                return (A807 - A607) / 200 + A673;
            }
        }
        public double A675
        {
            get
            {
                return (A807 - A607) / 200 + A674;
            }
        }
        public double A676
        {
            get
            {
                return (A807 - A607) / 200 + A675;
            }
        }
        public double A677
        {
            get
            {
                return (A807 - A607) / 200 + A676;
            }
        }
        public double A678
        {
            get
            {
                return (A807 - A607) / 200 + A677;
            }
        }
        public double A679
        {
            get
            {
                return (A807 - A607) / 200 + A678;
            }
        }
        public double A680
        {
            get
            {
                return (A807 - A607) / 200 + A679;
            }
        }
        public double A681
        {
            get
            {
                return (A807 - A607) / 200 + A680;
            }
        }
        public double A682
        {
            get
            {
                return (A807 - A607) / 200 + A681;
            }
        }
        public double A683
        {
            get
            {
                return (A807 - A607) / 200 + A682;
            }
        }
        public double A684
        {
            get
            {
                return (A807 - A607) / 200 + A683;
            }
        }
        public double A685
        {
            get
            {
                return (A807 - A607) / 200 + A684;
            }
        }
        public double A686
        {
            get
            {
                return (A807 - A607) / 200 + A685;
            }
        }
        public double A687
        {
            get
            {
                return (A807 - A607) / 200 + A686;
            }
        }
        public double A688
        {
            get
            {
                return (A807 - A607) / 200 + A687;
            }
        }
        public double A689
        {
            get
            {
                return (A807 - A607) / 200 + A688;
            }
        }
        public double A690
        {
            get
            {
                return (A807 - A607) / 200 + A689;
            }
        }
        public double A691
        {
            get
            {
                return (A807 - A607) / 200 + A690;
            }
        }
        public double A692
        {
            get
            {
                return (A807 - A607) / 200 + A691;
            }
        }
        public double A693
        {
            get
            {
                return (A807 - A607) / 200 + A692;
            }
        }
        public double A694
        {
            get
            {
                return (A807 - A607) / 200 + A693;
            }
        }
        public double A695
        {
            get
            {
                return (A807 - A607) / 200 + A694;
            }
        }
        public double A696
        {
            get
            {
                return (A807 - A607) / 200 + A695;
            }
        }
        public double A697
        {
            get
            {
                return (A807 - A607) / 200 + A696;
            }
        }
        public double A698
        {
            get
            {
                return (A807 - A607) / 200 + A697;
            }
        }
        public double A699
        {
            get
            {
                return (A807 - A607) / 200 + A698;
            }
        }
        public double A700
        {
            get
            {
                return (A807 - A607) / 200 + A699;
            }
        }
        public double A701
        {
            get
            {
                return (A807 - A607) / 200 + A700;
            }
        }
        public double A702
        {
            get
            {
                return (A807 - A607) / 200 + A701;
            }
        }
        public double A703
        {
            get
            {
                return (A807 - A607) / 200 + A702;
            }
        }
        public double A704
        {
            get
            {
                return (A807 - A607) / 200 + A703;
            }
        }
        public double A705
        {
            get
            {
                return (A807 - A607) / 200 + A704;
            }
        }
        public double A706
        {
            get
            {
                return (A807 - A607) / 200 + A705;
            }
        }
        public double A707
        {
            get
            {
                return (A807 - A607) / 200 + A706;
            }
        }
        public double A708
        {
            get
            {
                return (A807 - A607) / 200 + A707;
            }
        }
        public double A709
        {
            get
            {
                return (A807 - A607) / 200 + A708;
            }
        }
        public double A710
        {
            get
            {
                return (A807 - A607) / 200 + A709;
            }
        }
        public double A711
        {
            get
            {
                return (A807 - A607) / 200 + A710;
            }
        }
        public double A712
        {
            get
            {
                return (A807 - A607) / 200 + A711;
            }
        }
        public double A713
        {
            get
            {
                return (A807 - A607) / 200 + A712;
            }
        }
        public double A714
        {
            get
            {
                return (A807 - A607) / 200 + A713;
            }
        }
        public double A715
        {
            get
            {
                return (A807 - A607) / 200 + A714;
            }
        }
        public double A716
        {
            get
            {
                return (A807 - A607) / 200 + A715;
            }
        }
        public double A717
        {
            get
            {
                return (A807 - A607) / 200 + A716;
            }
        }
        public double A718
        {
            get
            {
                return (A807 - A607) / 200 + A717;
            }
        }
        public double A719
        {
            get
            {
                return (A807 - A607) / 200 + A718;
            }
        }
        public double A720
        {
            get
            {
                return (A807 - A607) / 200 + A719;
            }
        }
        public double A721
        {
            get
            {
                return (A807 - A607) / 200 + A720;
            }
        }
        public double A722
        {
            get
            {
                return (A807 - A607) / 200 + A721;
            }
        }
        public double A723
        {
            get
            {
                return (A807 - A607) / 200 + A722;
            }
        }
        public double A724
        {
            get
            {
                return (A807 - A607) / 200 + A723;
            }
        }
        public double A725
        {
            get
            {
                return (A807 - A607) / 200 + A724;
            }
        }
        public double A726
        {
            get
            {
                return (A807 - A607) / 200 + A725;
            }
        }
        public double A727
        {
            get
            {
                return (A807 - A607) / 200 + A726;
            }
        }
        public double A728
        {
            get
            {
                return (A807 - A607) / 200 + A727;
            }
        }
        public double A729
        {
            get
            {
                return (A807 - A607) / 200 + A728;
            }
        }
        public double A730
        {
            get
            {
                return (A807 - A607) / 200 + A729;
            }
        }
        public double A731
        {
            get
            {
                return (A807 - A607) / 200 + A730;
            }
        }
        public double A732
        {
            get
            {
                return (A807 - A607) / 200 + A731;
            }
        }
        public double A733
        {
            get
            {
                return (A807 - A607) / 200 + A732;
            }
        }
        public double A734
        {
            get
            {
                return (A807 - A607) / 200 + A733;
            }
        }
        public double A735
        {
            get
            {
                return (A807 - A607) / 200 + A734;
            }
        }
        public double A736
        {
            get
            {
                return (A807 - A607) / 200 + A735;
            }
        }
        public double A737
        {
            get
            {
                return (A807 - A607) / 200 + A736;
            }
        }
        public double A738
        {
            get
            {
                return (A807 - A607) / 200 + A737;
            }
        }
        public double A739
        {
            get
            {
                return (A807 - A607) / 200 + A738;
            }
        }
        public double A740
        {
            get
            {
                return (A807 - A607) / 200 + A739;
            }
        }
        public double A741
        {
            get
            {
                return (A807 - A607) / 200 + A740;
            }
        }
        public double A742
        {
            get
            {
                return (A807 - A607) / 200 + A741;
            }
        }
        public double A743
        {
            get
            {
                return (A807 - A607) / 200 + A742;
            }
        }
        public double A744
        {
            get
            {
                return (A807 - A607) / 200 + A743;
            }
        }
        public double A745
        {
            get
            {
                return (A807 - A607) / 200 + A744;
            }
        }
        public double A746
        {
            get
            {
                return (A807 - A607) / 200 + A745;
            }
        }
        public double A747
        {
            get
            {
                return (A807 - A607) / 200 + A746;
            }
        }
        public double A748
        {
            get
            {
                return (A807 - A607) / 200 + A747;
            }
        }
        public double A749
        {
            get
            {
                return (A807 - A607) / 200 + A748;
            }
        }
        public double A750
        {
            get
            {
                return (A807 - A607) / 200 + A749;
            }
        }
        public double A751
        {
            get
            {
                return (A807 - A607) / 200 + A750;
            }
        }
        public double A752
        {
            get
            {
                return (A807 - A607) / 200 + A751;
            }
        }
        public double A753
        {
            get
            {
                return (A807 - A607) / 200 + A752;
            }
        }
        public double A754
        {
            get
            {
                return (A807 - A607) / 200 + A753;
            }
        }
        public double A755
        {
            get
            {
                return (A807 - A607) / 200 + A754;
            }
        }
        public double A756
        {
            get
            {
                return (A807 - A607) / 200 + A755;
            }
        }
        public double A757
        {
            get
            {
                return (A807 - A607) / 200 + A756;
            }
        }
        public double A758
        {
            get
            {
                return (A807 - A607) / 200 + A757;
            }
        }
        public double A759
        {
            get
            {
                return (A807 - A607) / 200 + A758;
            }
        }
        public double A760
        {
            get
            {
                return (A807 - A607) / 200 + A759;
            }
        }
        public double A761
        {
            get
            {
                return (A807 - A607) / 200 + A760;
            }
        }
        public double A762
        {
            get
            {
                return (A807 - A607) / 200 + A761;
            }
        }
        public double A763
        {
            get
            {
                return (A807 - A607) / 200 + A762;
            }
        }
        public double A764
        {
            get
            {
                return (A807 - A607) / 200 + A763;
            }
        }
        public double A765
        {
            get
            {
                return (A807 - A607) / 200 + A764;
            }
        }
        public double A766
        {
            get
            {
                return (A807 - A607) / 200 + A765;
            }
        }
        public double A767
        {
            get
            {
                return (A807 - A607) / 200 + A766;
            }
        }
        public double A768
        {
            get
            {
                return (A807 - A607) / 200 + A767;
            }
        }
        public double A769
        {
            get
            {
                return (A807 - A607) / 200 + A768;
            }
        }
        public double A770
        {
            get
            {
                return (A807 - A607) / 200 + A769;
            }
        }
        public double A771
        {
            get
            {
                return (A807 - A607) / 200 + A770;
            }
        }
        public double A772
        {
            get
            {
                return (A807 - A607) / 200 + A771;
            }
        }
        public double A773
        {
            get
            {
                return (A807 - A607) / 200 + A772;
            }
        }
        public double A774
        {
            get
            {
                return (A807 - A607) / 200 + A773;
            }
        }
        public double A775
        {
            get
            {
                return (A807 - A607) / 200 + A774;
            }
        }
        public double A776
        {
            get
            {
                return (A807 - A607) / 200 + A775;
            }
        }
        public double A777
        {
            get
            {
                return (A807 - A607) / 200 + A776;
            }
        }
        public double A778
        {
            get
            {
                return (A807 - A607) / 200 + A777;
            }
        }
        public double A779
        {
            get
            {
                return (A807 - A607) / 200 + A778;
            }
        }
        public double A780
        {
            get
            {
                return (A807 - A607) / 200 + A779;
            }
        }
        public double A781
        {
            get
            {
                return (A807 - A607) / 200 + A780;
            }
        }
        public double A782
        {
            get
            {
                return (A807 - A607) / 200 + A781;
            }
        }
        public double A783
        {
            get
            {
                return (A807 - A607) / 200 + A782;
            }
        }
        public double A784
        {
            get
            {
                return (A807 - A607) / 200 + A783;
            }
        }
        public double A785
        {
            get
            {
                return (A807 - A607) / 200 + A784;
            }
        }
        public double A786
        {
            get
            {
                return (A807 - A607) / 200 + A785;
            }
        }
        public double A787
        {
            get
            {
                return (A807 - A607) / 200 + A786;
            }
        }
        public double A788
        {
            get
            {
                return (A807 - A607) / 200 + A787;
            }
        }
        public double A789
        {
            get
            {
                return (A807 - A607) / 200 + A788;
            }
        }
        public double A790
        {
            get
            {
                return (A807 - A607) / 200 + A789;
            }
        }
        public double A791
        {
            get
            {
                return (A807 - A607) / 200 + A790;
            }
        }
        public double A792
        {
            get
            {
                return (A807 - A607) / 200 + A791;
            }
        }
        public double A793
        {
            get
            {
                return (A807 - A607) / 200 + A792;
            }
        }
        public double A794
        {
            get
            {
                return (A807 - A607) / 200 + A793;
            }
        }
        public double A795
        {
            get
            {
                return (A807 - A607) / 200 + A794;
            }
        }
        public double A796
        {
            get
            {
                return (A807 - A607) / 200 + A795;
            }
        }
        public double A797
        {
            get
            {
                return (A807 - A607) / 200 + A796;
            }
        }
        public double A798
        {
            get
            {
                return (A807 - A607) / 200 + A797;
            }
        }
        public double A799
        {
            get
            {
                return (A807 - A607) / 200 + A798;
            }
        }
        public double A800
        {
            get
            {
                return (A807 - A607) / 200 + A799;
            }
        }
        public double A801
        {
            get
            {
                return (A807 - A607) / 200 + A800;
            }
        }
        public double A802
        {
            get
            {
                return (A807 - A607) / 200 + A801;
            }
        }
        public double A803
        {
            get
            {
                return (A807 - A607) / 200 + A802;
            }
        }
        public double A804
        {
            get
            {
                return (A807 - A607) / 200 + A803;
            }
        }
        public double A805
        {
            get
            {
                return (A807 - A607) / 200 + A804;
            }
        }
        public double A806
        {
            get
            {
                return (A807 - A607) / 200 + A805;
            }
        }
        public double A807
        {
            get
            {
                return B593 - 1;
            }
        }

        public double C607
        {
            get
            {
                return Math.Log(B596 * A607 / (B593 - A607)); //Natural Log base(e)
            }
        }
        public double C608
        {
            get
            {
                return Math.Log(B596 * A608 / (B593 - A608)); //Natural Log base(e)
            }
        }
        public double C609
        {
            get
            {
                return Math.Log(B596 * A609 / (B593 - A609)); //Natural Log base(e)
            }
        }
        public double C610
        {
            get
            {
                return Math.Log(B596 * A610 / (B593 - A610)); //Natural Log base(e)
            }
        }
        public double C611
        {
            get
            {
                return Math.Log(B596 * A611 / (B593 - A611)); //Natural Log base(e)
            }
        }
        public double C612
        {
            get
            {
                return Math.Log(B596 * A612 / (B593 - A612)); //Natural Log base(e)
            }
        }
        public double C613
        {
            get
            {
                return Math.Log(B596 * A613 / (B593 - A613)); //Natural Log base(e)
            }
        }
        public double C614
        {
            get
            {
                return Math.Log(B596 * A614 / (B593 - A614)); //Natural Log base(e)
            }
        }
        public double C615
        {
            get
            {
                return Math.Log(B596 * A615 / (B593 - A615)); //Natural Log base(e)
            }
        }
        public double C616
        {
            get
            {
                return Math.Log(B596 * A616 / (B593 - A616)); //Natural Log base(e)
            }
        }
        public double C617
        {
            get
            {
                return Math.Log(B596 * A617 / (B593 - A617)); //Natural Log base(e)
            }
        }
        public double C618
        {
            get
            {
                return Math.Log(B596 * A618 / (B593 - A618)); //Natural Log base(e)
            }
        }
        public double C619
        {
            get
            {
                return Math.Log(B596 * A619 / (B593 - A619)); //Natural Log base(e)
            }
        }
        public double C620
        {
            get
            {
                return Math.Log(B596 * A620 / (B593 - A620)); //Natural Log base(e)
            }
        }
        public double C621
        {
            get
            {
                return Math.Log(B596 * A621 / (B593 - A621)); //Natural Log base(e)
            }
        }
        public double C622
        {
            get
            {
                return Math.Log(B596 * A622 / (B593 - A622)); //Natural Log base(e)
            }
        }
        public double C623
        {
            get
            {
                return Math.Log(B596 * A623 / (B593 - A623)); //Natural Log base(e)
            }
        }
        public double C624
        {
            get
            {
                return Math.Log(B596 * A624 / (B593 - A624)); //Natural Log base(e)
            }
        }
        public double C625
        {
            get
            {
                return Math.Log(B596 * A625 / (B593 - A625)); //Natural Log base(e)
            }
        }
        public double C626
        {
            get
            {
                return Math.Log(B596 * A626 / (B593 - A626)); //Natural Log base(e)
            }
        }
        public double C627
        {
            get
            {
                return Math.Log(B596 * A627 / (B593 - A627)); //Natural Log base(e)
            }
        }
        public double C628
        {
            get
            {
                return Math.Log(B596 * A628 / (B593 - A628)); //Natural Log base(e)
            }
        }
        public double C629
        {
            get
            {
                return Math.Log(B596 * A629 / (B593 - A629)); //Natural Log base(e)
            }
        }
        public double C630
        {
            get
            {
                return Math.Log(B596 * A630 / (B593 - A630)); //Natural Log base(e)
            }
        }
        public double C631
        {
            get
            {
                return Math.Log(B596 * A631 / (B593 - A631)); //Natural Log base(e)
            }
        }
        public double C632
        {
            get
            {
                return Math.Log(B596 * A632 / (B593 - A632)); //Natural Log base(e)
            }
        }
        public double C633
        {
            get
            {
                return Math.Log(B596 * A633 / (B593 - A633)); //Natural Log base(e)
            }
        }
        public double C634
        {
            get
            {
                return Math.Log(B596 * A634 / (B593 - A634)); //Natural Log base(e)
            }
        }
        public double C635
        {
            get
            {
                return Math.Log(B596 * A635 / (B593 - A635)); //Natural Log base(e)
            }
        }
        public double C636
        {
            get
            {
                return Math.Log(B596 * A636 / (B593 - A636)); //Natural Log base(e)
            }
        }
        public double C637
        {
            get
            {
                return Math.Log(B596 * A637 / (B593 - A637)); //Natural Log base(e)
            }
        }
        public double C638
        {
            get
            {
                return Math.Log(B596 * A638 / (B593 - A638)); //Natural Log base(e)
            }
        }
        public double C639
        {
            get
            {
                return Math.Log(B596 * A639 / (B593 - A639)); //Natural Log base(e)
            }
        }
        public double C640
        {
            get
            {
                return Math.Log(B596 * A640 / (B593 - A640)); //Natural Log base(e)
            }
        }
        public double C641
        {
            get
            {
                return Math.Log(B596 * A641 / (B593 - A641)); //Natural Log base(e)
            }
        }
        public double C642
        {
            get
            {
                return Math.Log(B596 * A642 / (B593 - A642)); //Natural Log base(e)
            }
        }
        public double C643
        {
            get
            {
                return Math.Log(B596 * A643 / (B593 - A643)); //Natural Log base(e)
            }
        }
        public double C644
        {
            get
            {
                return Math.Log(B596 * A644 / (B593 - A644)); //Natural Log base(e)
            }
        }
        public double C645
        {
            get
            {
                return Math.Log(B596 * A645 / (B593 - A645)); //Natural Log base(e)
            }
        }
        public double C646
        {
            get
            {
                return Math.Log(B596 * A646 / (B593 - A646)); //Natural Log base(e)
            }
        }
        public double C647
        {
            get
            {
                return Math.Log(B596 * A647 / (B593 - A647)); //Natural Log base(e)
            }
        }
        public double C648
        {
            get
            {
                return Math.Log(B596 * A648 / (B593 - A648)); //Natural Log base(e)
            }
        }
        public double C649
        {
            get
            {
                return Math.Log(B596 * A649 / (B593 - A649)); //Natural Log base(e)
            }
        }
        public double C650
        {
            get
            {
                return Math.Log(B596 * A650 / (B593 - A650)); //Natural Log base(e)
            }
        }
        public double C651
        {
            get
            {
                return Math.Log(B596 * A651 / (B593 - A651)); //Natural Log base(e)
            }
        }
        public double C652
        {
            get
            {
                return Math.Log(B596 * A652 / (B593 - A652)); //Natural Log base(e)
            }
        }
        public double C653
        {
            get
            {
                return Math.Log(B596 * A653 / (B593 - A653)); //Natural Log base(e)
            }
        }
        public double C654
        {
            get
            {
                return Math.Log(B596 * A654 / (B593 - A654)); //Natural Log base(e)
            }
        }
        public double C655
        {
            get
            {
                return Math.Log(B596 * A655 / (B593 - A655)); //Natural Log base(e)
            }
        }
        public double C656
        {
            get
            {
                return Math.Log(B596 * A656 / (B593 - A656)); //Natural Log base(e)
            }
        }
        public double C657
        {
            get
            {
                return Math.Log(B596 * A657 / (B593 - A657)); //Natural Log base(e)
            }
        }
        public double C658
        {
            get
            {
                return Math.Log(B596 * A658 / (B593 - A658)); //Natural Log base(e)
            }
        }
        public double C659
        {
            get
            {
                return Math.Log(B596 * A659 / (B593 - A659)); //Natural Log base(e)
            }
        }
        public double C660
        {
            get
            {
                return Math.Log(B596 * A660 / (B593 - A660)); //Natural Log base(e)
            }
        }
        public double C661
        {
            get
            {
                return Math.Log(B596 * A661 / (B593 - A661)); //Natural Log base(e)
            }
        }
        public double C662
        {
            get
            {
                return Math.Log(B596 * A662 / (B593 - A662)); //Natural Log base(e)
            }
        }
        public double C663
        {
            get
            {
                return Math.Log(B596 * A663 / (B593 - A663)); //Natural Log base(e)
            }
        }
        public double C664
        {
            get
            {
                return Math.Log(B596 * A664 / (B593 - A664)); //Natural Log base(e)
            }
        }
        public double C665
        {
            get
            {
                return Math.Log(B596 * A665 / (B593 - A665)); //Natural Log base(e)
            }
        }
        public double C666
        {
            get
            {
                return Math.Log(B596 * A666 / (B593 - A666)); //Natural Log base(e)
            }
        }
        public double C667
        {
            get
            {
                return Math.Log(B596 * A667 / (B593 - A667)); //Natural Log base(e)
            }
        }
        public double C668
        {
            get
            {
                return Math.Log(B596 * A668 / (B593 - A668)); //Natural Log base(e)
            }
        }
        public double C669
        {
            get
            {
                return Math.Log(B596 * A669 / (B593 - A669)); //Natural Log base(e)
            }
        }
        public double C670
        {
            get
            {
                return Math.Log(B596 * A670 / (B593 - A670)); //Natural Log base(e)
            }
        }
        public double C671
        {
            get
            {
                return Math.Log(B596 * A671 / (B593 - A671)); //Natural Log base(e)
            }
        }
        public double C672
        {
            get
            {
                return Math.Log(B596 * A672 / (B593 - A672)); //Natural Log base(e)
            }
        }
        public double C673
        {
            get
            {
                return Math.Log(B596 * A673 / (B593 - A673)); //Natural Log base(e)
            }
        }
        public double C674
        {
            get
            {
                return Math.Log(B596 * A674 / (B593 - A674)); //Natural Log base(e)
            }
        }
        public double C675
        {
            get
            {
                return Math.Log(B596 * A675 / (B593 - A675)); //Natural Log base(e)
            }
        }
        public double C676
        {
            get
            {
                return Math.Log(B596 * A676 / (B593 - A676)); //Natural Log base(e)
            }
        }
        public double C677
        {
            get
            {
                return Math.Log(B596 * A677 / (B593 - A677)); //Natural Log base(e)
            }
        }
        public double C678
        {
            get
            {
                return Math.Log(B596 * A678 / (B593 - A678)); //Natural Log base(e)
            }
        }
        public double C679
        {
            get
            {
                return Math.Log(B596 * A679 / (B593 - A679)); //Natural Log base(e)
            }
        }
        public double C680
        {
            get
            {
                return Math.Log(B596 * A680 / (B593 - A680)); //Natural Log base(e)
            }
        }
        public double C681
        {
            get
            {
                return Math.Log(B596 * A681 / (B593 - A681)); //Natural Log base(e)
            }
        }
        public double C682
        {
            get
            {
                return Math.Log(B596 * A682 / (B593 - A682)); //Natural Log base(e)
            }
        }
        public double C683
        {
            get
            {
                return Math.Log(B596 * A683 / (B593 - A683)); //Natural Log base(e)
            }
        }
        public double C684
        {
            get
            {
                return Math.Log(B596 * A684 / (B593 - A684)); //Natural Log base(e)
            }
        }
        public double C685
        {
            get
            {
                return Math.Log(B596 * A685 / (B593 - A685)); //Natural Log base(e)
            }
        }
        public double C686
        {
            get
            {
                return Math.Log(B596 * A686 / (B593 - A686)); //Natural Log base(e)
            }
        }
        public double C687
        {
            get
            {
                return Math.Log(B596 * A687 / (B593 - A687)); //Natural Log base(e)
            }
        }
        public double C688
        {
            get
            {
                return Math.Log(B596 * A688 / (B593 - A688)); //Natural Log base(e)
            }
        }
        public double C689
        {
            get
            {
                return Math.Log(B596 * A689 / (B593 - A689)); //Natural Log base(e)
            }
        }
        public double C690
        {
            get
            {
                return Math.Log(B596 * A690 / (B593 - A690)); //Natural Log base(e)
            }
        }
        public double C691
        {
            get
            {
                return Math.Log(B596 * A691 / (B593 - A691)); //Natural Log base(e)
            }
        }
        public double C692
        {
            get
            {
                return Math.Log(B596 * A692 / (B593 - A692)); //Natural Log base(e)
            }
        }
        public double C693
        {
            get
            {
                return Math.Log(B596 * A693 / (B593 - A693)); //Natural Log base(e)
            }
        }
        public double C694
        {
            get
            {
                return Math.Log(B596 * A694 / (B593 - A694)); //Natural Log base(e)
            }
        }
        public double C695
        {
            get
            {
                return Math.Log(B596 * A695 / (B593 - A695)); //Natural Log base(e)
            }
        }
        public double C696
        {
            get
            {
                return Math.Log(B596 * A696 / (B593 - A696)); //Natural Log base(e)
            }
        }
        public double C697
        {
            get
            {
                return Math.Log(B596 * A697 / (B593 - A697)); //Natural Log base(e)
            }
        }
        public double C698
        {
            get
            {
                return Math.Log(B596 * A698 / (B593 - A698)); //Natural Log base(e)
            }
        }
        public double C699
        {
            get
            {
                return Math.Log(B596 * A699 / (B593 - A699)); //Natural Log base(e)
            }
        }
        public double C700
        {
            get
            {
                return Math.Log(B596 * A700 / (B593 - A700)); //Natural Log base(e)
            }
        }
        public double C701
        {
            get
            {
                return Math.Log(B596 * A701 / (B593 - A701)); //Natural Log base(e)
            }
        }
        public double C702
        {
            get
            {
                return Math.Log(B596 * A702 / (B593 - A702)); //Natural Log base(e)
            }
        }
        public double C703
        {
            get
            {
                return Math.Log(B596 * A703 / (B593 - A703)); //Natural Log base(e)
            }
        }
        public double C704
        {
            get
            {
                return Math.Log(B596 * A704 / (B593 - A704)); //Natural Log base(e)
            }
        }
        public double C705
        {
            get
            {
                return Math.Log(B596 * A705 / (B593 - A705)); //Natural Log base(e)
            }
        }
        public double C706
        {
            get
            {
                return Math.Log(B596 * A706 / (B593 - A706)); //Natural Log base(e)
            }
        }
        public double C707
        {
            get
            {
                return Math.Log(B596 * A707 / (B593 - A707)); //Natural Log base(e)
            }
        }
        public double C708
        {
            get
            {
                return Math.Log(B596 * A708 / (B593 - A708)); //Natural Log base(e)
            }
        }
        public double C709
        {
            get
            {
                return Math.Log(B596 * A709 / (B593 - A709)); //Natural Log base(e)
            }
        }
        public double C710
        {
            get
            {
                return Math.Log(B596 * A710 / (B593 - A710)); //Natural Log base(e)
            }
        }
        public double C711
        {
            get
            {
                return Math.Log(B596 * A711 / (B593 - A711)); //Natural Log base(e)
            }
        }
        public double C712
        {
            get
            {
                return Math.Log(B596 * A712 / (B593 - A712)); //Natural Log base(e)
            }
        }
        public double C713
        {
            get
            {
                return Math.Log(B596 * A713 / (B593 - A713)); //Natural Log base(e)
            }
        }
        public double C714
        {
            get
            {
                return Math.Log(B596 * A714 / (B593 - A714)); //Natural Log base(e)
            }
        }
        public double C715
        {
            get
            {
                return Math.Log(B596 * A715 / (B593 - A715)); //Natural Log base(e)
            }
        }
        public double C716
        {
            get
            {
                return Math.Log(B596 * A716 / (B593 - A716)); //Natural Log base(e)
            }
        }
        public double C717
        {
            get
            {
                return Math.Log(B596 * A717 / (B593 - A717)); //Natural Log base(e)
            }
        }
        public double C718
        {
            get
            {
                return Math.Log(B596 * A718 / (B593 - A718)); //Natural Log base(e)
            }
        }
        public double C719
        {
            get
            {
                return Math.Log(B596 * A719 / (B593 - A719)); //Natural Log base(e)
            }
        }
        public double C720
        {
            get
            {
                return Math.Log(B596 * A720 / (B593 - A720)); //Natural Log base(e)
            }
        }
        public double C721
        {
            get
            {
                return Math.Log(B596 * A721 / (B593 - A721)); //Natural Log base(e)
            }
        }
        public double C722
        {
            get
            {
                return Math.Log(B596 * A722 / (B593 - A722)); //Natural Log base(e)
            }
        }
        public double C723
        {
            get
            {
                return Math.Log(B596 * A723 / (B593 - A723)); //Natural Log base(e)
            }
        }
        public double C724
        {
            get
            {
                return Math.Log(B596 * A724 / (B593 - A724)); //Natural Log base(e)
            }
        }
        public double C725
        {
            get
            {
                return Math.Log(B596 * A725 / (B593 - A725)); //Natural Log base(e)
            }
        }
        public double C726
        {
            get
            {
                return Math.Log(B596 * A726 / (B593 - A726)); //Natural Log base(e)
            }
        }
        public double C727
        {
            get
            {
                return Math.Log(B596 * A727 / (B593 - A727)); //Natural Log base(e)
            }
        }
        public double C728
        {
            get
            {
                return Math.Log(B596 * A728 / (B593 - A728)); //Natural Log base(e)
            }
        }
        public double C729
        {
            get
            {
                return Math.Log(B596 * A729 / (B593 - A729)); //Natural Log base(e)
            }
        }
        public double C730
        {
            get
            {
                return Math.Log(B596 * A730 / (B593 - A730)); //Natural Log base(e)
            }
        }
        public double C731
        {
            get
            {
                return Math.Log(B596 * A731 / (B593 - A731)); //Natural Log base(e)
            }
        }
        public double C732
        {
            get
            {
                return Math.Log(B596 * A732 / (B593 - A732)); //Natural Log base(e)
            }
        }
        public double C733
        {
            get
            {
                return Math.Log(B596 * A733 / (B593 - A733)); //Natural Log base(e)
            }
        }
        public double C734
        {
            get
            {
                return Math.Log(B596 * A734 / (B593 - A734)); //Natural Log base(e)
            }
        }
        public double C735
        {
            get
            {
                return Math.Log(B596 * A735 / (B593 - A735)); //Natural Log base(e)
            }
        }
        public double C736
        {
            get
            {
                return Math.Log(B596 * A736 / (B593 - A736)); //Natural Log base(e)
            }
        }
        public double C737
        {
            get
            {
                return Math.Log(B596 * A737 / (B593 - A737)); //Natural Log base(e)
            }
        }
        public double C738
        {
            get
            {
                return Math.Log(B596 * A738 / (B593 - A738)); //Natural Log base(e)
            }
        }
        public double C739
        {
            get
            {
                return Math.Log(B596 * A739 / (B593 - A739)); //Natural Log base(e)
            }
        }
        public double C740
        {
            get
            {
                return Math.Log(B596 * A740 / (B593 - A740)); //Natural Log base(e)
            }
        }
        public double C741
        {
            get
            {
                return Math.Log(B596 * A741 / (B593 - A741)); //Natural Log base(e)
            }
        }
        public double C742
        {
            get
            {
                return Math.Log(B596 * A742 / (B593 - A742)); //Natural Log base(e)
            }
        }
        public double C743
        {
            get
            {
                return Math.Log(B596 * A743 / (B593 - A743)); //Natural Log base(e)
            }
        }
        public double C744
        {
            get
            {
                return Math.Log(B596 * A744 / (B593 - A744)); //Natural Log base(e)
            }
        }
        public double C745
        {
            get
            {
                return Math.Log(B596 * A745 / (B593 - A745)); //Natural Log base(e)
            }
        }
        public double C746
        {
            get
            {
                return Math.Log(B596 * A746 / (B593 - A746)); //Natural Log base(e)
            }
        }
        public double C747
        {
            get
            {
                return Math.Log(B596 * A747 / (B593 - A747)); //Natural Log base(e)
            }
        }
        public double C748
        {
            get
            {
                return Math.Log(B596 * A748 / (B593 - A748)); //Natural Log base(e)
            }
        }
        public double C749
        {
            get
            {
                return Math.Log(B596 * A749 / (B593 - A749)); //Natural Log base(e)
            }
        }
        public double C750
        {
            get
            {
                return Math.Log(B596 * A750 / (B593 - A750)); //Natural Log base(e)
            }
        }
        public double C751
        {
            get
            {
                return Math.Log(B596 * A751 / (B593 - A751)); //Natural Log base(e)
            }
        }
        public double C752
        {
            get
            {
                return Math.Log(B596 * A752 / (B593 - A752)); //Natural Log base(e)
            }
        }
        public double C753
        {
            get
            {
                return Math.Log(B596 * A753 / (B593 - A753)); //Natural Log base(e)
            }
        }
        public double C754
        {
            get
            {
                return Math.Log(B596 * A754 / (B593 - A754)); //Natural Log base(e)
            }
        }
        public double C755
        {
            get
            {
                return Math.Log(B596 * A755 / (B593 - A755)); //Natural Log base(e)
            }
        }
        public double C756
        {
            get
            {
                return Math.Log(B596 * A756 / (B593 - A756)); //Natural Log base(e)
            }
        }
        public double C757
        {
            get
            {
                return Math.Log(B596 * A757 / (B593 - A757)); //Natural Log base(e)
            }
        }
        public double C758
        {
            get
            {
                return Math.Log(B596 * A758 / (B593 - A758)); //Natural Log base(e)
            }
        }
        public double C759
        {
            get
            {
                return Math.Log(B596 * A759 / (B593 - A759)); //Natural Log base(e)
            }
        }
        public double C760
        {
            get
            {
                return Math.Log(B596 * A760 / (B593 - A760)); //Natural Log base(e)
            }
        }
        public double C761
        {
            get
            {
                return Math.Log(B596 * A761 / (B593 - A761)); //Natural Log base(e)
            }
        }
        public double C762
        {
            get
            {
                return Math.Log(B596 * A762 / (B593 - A762)); //Natural Log base(e)
            }
        }
        public double C763
        {
            get
            {
                return Math.Log(B596 * A763 / (B593 - A763)); //Natural Log base(e)
            }
        }
        public double C764
        {
            get
            {
                return Math.Log(B596 * A764 / (B593 - A764)); //Natural Log base(e)
            }
        }
        public double C765
        {
            get
            {
                return Math.Log(B596 * A765 / (B593 - A765)); //Natural Log base(e)
            }
        }
        public double C766
        {
            get
            {
                return Math.Log(B596 * A766 / (B593 - A766)); //Natural Log base(e)
            }
        }
        public double C767
        {
            get
            {
                return Math.Log(B596 * A767 / (B593 - A767)); //Natural Log base(e)
            }
        }
        public double C768
        {
            get
            {
                return Math.Log(B596 * A768 / (B593 - A768)); //Natural Log base(e)
            }
        }
        public double C769
        {
            get
            {
                return Math.Log(B596 * A769 / (B593 - A769)); //Natural Log base(e)
            }
        }
        public double C770
        {
            get
            {
                return Math.Log(B596 * A770 / (B593 - A770)); //Natural Log base(e)
            }
        }
        public double C771
        {
            get
            {
                return Math.Log(B596 * A771 / (B593 - A771)); //Natural Log base(e)
            }
        }
        public double C772
        {
            get
            {
                return Math.Log(B596 * A772 / (B593 - A772)); //Natural Log base(e)
            }
        }
        public double C773
        {
            get
            {
                return Math.Log(B596 * A773 / (B593 - A773)); //Natural Log base(e)
            }
        }
        public double C774
        {
            get
            {
                return Math.Log(B596 * A774 / (B593 - A774)); //Natural Log base(e)
            }
        }
        public double C775
        {
            get
            {
                return Math.Log(B596 * A775 / (B593 - A775)); //Natural Log base(e)
            }
        }
        public double C776
        {
            get
            {
                return Math.Log(B596 * A776 / (B593 - A776)); //Natural Log base(e)
            }
        }
        public double C777
        {
            get
            {
                return Math.Log(B596 * A777 / (B593 - A777)); //Natural Log base(e)
            }
        }
        public double C778
        {
            get
            {
                return Math.Log(B596 * A778 / (B593 - A778)); //Natural Log base(e)
            }
        }
        public double C779
        {
            get
            {
                return Math.Log(B596 * A779 / (B593 - A779)); //Natural Log base(e)
            }
        }
        public double C780
        {
            get
            {
                return Math.Log(B596 * A780 / (B593 - A780)); //Natural Log base(e)
            }
        }
        public double C781
        {
            get
            {
                return Math.Log(B596 * A781 / (B593 - A781)); //Natural Log base(e)
            }
        }
        public double C782
        {
            get
            {
                return Math.Log(B596 * A782 / (B593 - A782)); //Natural Log base(e)
            }
        }
        public double C783
        {
            get
            {
                return Math.Log(B596 * A783 / (B593 - A783)); //Natural Log base(e)
            }
        }
        public double C784
        {
            get
            {
                return Math.Log(B596 * A784 / (B593 - A784)); //Natural Log base(e)
            }
        }
        public double C785
        {
            get
            {
                return Math.Log(B596 * A785 / (B593 - A785)); //Natural Log base(e)
            }
        }
        public double C786
        {
            get
            {
                return Math.Log(B596 * A786 / (B593 - A786)); //Natural Log base(e)
            }
        }
        public double C787
        {
            get
            {
                return Math.Log(B596 * A787 / (B593 - A787)); //Natural Log base(e)
            }
        }
        public double C788
        {
            get
            {
                return Math.Log(B596 * A788 / (B593 - A788)); //Natural Log base(e)
            }
        }
        public double C789
        {
            get
            {
                return Math.Log(B596 * A789 / (B593 - A789)); //Natural Log base(e)
            }
        }
        public double C790
        {
            get
            {
                return Math.Log(B596 * A790 / (B593 - A790)); //Natural Log base(e)
            }
        }
        public double C791
        {
            get
            {
                return Math.Log(B596 * A791 / (B593 - A791)); //Natural Log base(e)
            }
        }
        public double C792
        {
            get
            {
                return Math.Log(B596 * A792 / (B593 - A792)); //Natural Log base(e)
            }
        }
        public double C793
        {
            get
            {
                return Math.Log(B596 * A793 / (B593 - A793)); //Natural Log base(e)
            }
        }
        public double C794
        {
            get
            {
                return Math.Log(B596 * A794 / (B593 - A794)); //Natural Log base(e)
            }
        }
        public double C795
        {
            get
            {
                return Math.Log(B596 * A795 / (B593 - A795)); //Natural Log base(e)
            }
        }
        public double C796
        {
            get
            {
                return Math.Log(B596 * A796 / (B593 - A796)); //Natural Log base(e)
            }
        }
        public double C797
        {
            get
            {
                return Math.Log(B596 * A797 / (B593 - A797)); //Natural Log base(e)
            }
        }
        public double C798
        {
            get
            {
                return Math.Log(B596 * A798 / (B593 - A798)); //Natural Log base(e)
            }
        }
        public double C799
        {
            get
            {
                return Math.Log(B596 * A799 / (B593 - A799)); //Natural Log base(e)
            }
        }
        public double C800
        {
            get
            {
                return Math.Log(B596 * A800 / (B593 - A800)); //Natural Log base(e)
            }
        }
        public double C801
        {
            get
            {
                return Math.Log(B596 * A801 / (B593 - A801)); //Natural Log base(e)
            }
        }
        public double C802
        {
            get
            {
                return Math.Log(B596 * A802 / (B593 - A802)); //Natural Log base(e)
            }
        }
        public double C803
        {
            get
            {
                return Math.Log(B596 * A803 / (B593 - A803)); //Natural Log base(e)
            }
        }
        public double C804
        {
            get
            {
                return Math.Log(B596 * A804 / (B593 - A804)); //Natural Log base(e)
            }
        }
        public double C805
        {
            get
            {
                return Math.Log(B596 * A805 / (B593 - A805)); //Natural Log base(e)
            }
        }
        public double C806
        {
            get
            {
                return Math.Log(B596 * A806 / (B593 - A806)); //Natural Log base(e)
            }
        }
        public double C807
        {
            get
            {
                return Math.Log(B596 * A807 / (B593 - A807)); //Natural Log base(e)
            }
        }

        public double D607
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C607));
            }
        }
        public double D608
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C608));
            }
        }
        public double D609
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C609));
            }
        }
        public double D610
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C610));
            }
        }
        public double D611
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C611));
            }
        }
        public double D612
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C612));
            }
        }
        public double D613
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C613));
            }
        }
        public double D614
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C614));
            }
        }
        public double D615
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C615));
            }
        }
        public double D616
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C616));
            }
        }
        public double D617
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C617));
            }
        }
        public double D618
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C618));
            }
        }
        public double D619
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C619));
            }
        }
        public double D620
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C620));
            }
        }
        public double D621
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C621));
            }
        }
        public double D622
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C622));
            }
        }
        public double D623
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C623));
            }
        }
        public double D624
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C624));
            }
        }
        public double D625
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C625));
            }
        }
        public double D626
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C626));
            }
        }
        public double D627
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C627));
            }
        }
        public double D628
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C628));
            }
        }
        public double D629
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C629));
            }
        }
        public double D630
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C630));
            }
        }
        public double D631
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C631));
            }
        }
        public double D632
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C632));
            }
        }
        public double D633
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C633));
            }
        }
        public double D634
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C634));
            }
        }
        public double D635
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C635));
            }
        }
        public double D636
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C636));
            }
        }
        public double D637
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C637));
            }
        }
        public double D638
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C638));
            }
        }
        public double D639
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C639));
            }
        }
        public double D640
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C640));
            }
        }
        public double D641
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C641));
            }
        }
        public double D642
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C642));
            }
        }
        public double D643
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C643));
            }
        }
        public double D644
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C644));
            }
        }
        public double D645
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C645));
            }
        }
        public double D646
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C646));
            }
        }
        public double D647
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C647));
            }
        }
        public double D648
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C648));
            }
        }
        public double D649
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C649));
            }
        }
        public double D650
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C650));
            }
        }
        public double D651
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C651));
            }
        }
        public double D652
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C652));
            }
        }
        public double D653
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C653));
            }
        }
        public double D654
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C654));
            }
        }
        public double D655
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C655));
            }
        }
        public double D656
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C656));
            }
        }
        public double D657
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C657));
            }
        }
        public double D658
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C658));
            }
        }
        public double D659
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C659));
            }
        }
        public double D660
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C660));
            }
        }
        public double D661
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C661));
            }
        }
        public double D662
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C662));
            }
        }
        public double D663
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C663));
            }
        }
        public double D664
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C664));
            }
        }
        public double D665
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C665));
            }
        }
        public double D666
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C666));
            }
        }
        public double D667
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C667));
            }
        }
        public double D668
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C668));
            }
        }
        public double D669
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C669));
            }
        }
        public double D670
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C670));
            }
        }
        public double D671
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C671));
            }
        }
        public double D672
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C672));
            }
        }
        public double D673
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C673));
            }
        }
        public double D674
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C674));
            }
        }
        public double D675
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C675));
            }
        }
        public double D676
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C676));
            }
        }
        public double D677
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C677));
            }
        }
        public double D678
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C678));
            }
        }
        public double D679
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C679));
            }
        }
        public double D680
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C680));
            }
        }
        public double D681
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C681));
            }
        }
        public double D682
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C682));
            }
        }
        public double D683
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C683));
            }
        }
        public double D684
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C684));
            }
        }
        public double D685
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C685));
            }
        }
        public double D686
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C686));
            }
        }
        public double D687
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C687));
            }
        }
        public double D688
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C688));
            }
        }
        public double D689
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C689));
            }
        }
        public double D690
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C690));
            }
        }
        public double D691
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C691));
            }
        }
        public double D692
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C692));
            }
        }
        public double D693
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C693));
            }
        }
        public double D694
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C694));
            }
        }
        public double D695
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C695));
            }
        }
        public double D696
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C696));
            }
        }
        public double D697
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C697));
            }
        }
        public double D698
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C698));
            }
        }
        public double D699
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C699));
            }
        }
        public double D700
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C700));
            }
        }
        public double D701
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C701));
            }
        }
        public double D702
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C702));
            }
        }
        public double D703
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C703));
            }
        }
        public double D704
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C704));
            }
        }
        public double D705
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C705));
            }
        }
        public double D706
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C706));
            }
        }
        public double D707
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C707));
            }
        }
        public double D708
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C708));
            }
        }
        public double D709
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C709));
            }
        }
        public double D710
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C710));
            }
        }
        public double D711
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C711));
            }
        }
        public double D712
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C712));
            }
        }
        public double D713
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C713));
            }
        }
        public double D714
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C714));
            }
        }
        public double D715
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C715));
            }
        }
        public double D716
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C716));
            }
        }
        public double D717
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C717));
            }
        }
        public double D718
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C718));
            }
        }
        public double D719
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C719));
            }
        }
        public double D720
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C720));
            }
        }
        public double D721
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C721));
            }
        }
        public double D722
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C722));
            }
        }
        public double D723
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C723));
            }
        }
        public double D724
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C724));
            }
        }
        public double D725
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C725));
            }
        }
        public double D726
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C726));
            }
        }
        public double D727
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C727));
            }
        }
        public double D728
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C728));
            }
        }
        public double D729
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C729));
            }
        }
        public double D730
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C730));
            }
        }
        public double D731
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C731));
            }
        }
        public double D732
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C732));
            }
        }
        public double D733
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C733));
            }
        }
        public double D734
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C734));
            }
        }
        public double D735
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C735));
            }
        }
        public double D736
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C736));
            }
        }
        public double D737
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C737));
            }
        }
        public double D738
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C738));
            }
        }
        public double D739
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C739));
            }
        }
        public double D740
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C740));
            }
        }
        public double D741
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C741));
            }
        }
        public double D742
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C742));
            }
        }
        public double D743
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C743));
            }
        }
        public double D744
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C744));
            }
        }
        public double D745
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C745));
            }
        }
        public double D746
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C746));
            }
        }
        public double D747
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C747));
            }
        }
        public double D748
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C748));
            }
        }
        public double D749
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C749));
            }
        }
        public double D750
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C750));
            }
        }
        public double D751
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C751));
            }
        }
        public double D752
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C752));
            }
        }
        public double D753
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C753));
            }
        }
        public double D754
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C754));
            }
        }
        public double D755
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C755));
            }
        }
        public double D756
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C756));
            }
        }
        public double D757
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C757));
            }
        }
        public double D758
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C758));
            }
        }
        public double D759
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C759));
            }
        }
        public double D760
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C760));
            }
        }
        public double D761
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C761));
            }
        }
        public double D762
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C762));
            }
        }
        public double D763
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C763));
            }
        }
        public double D764
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C764));
            }
        }
        public double D765
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C765));
            }
        }
        public double D766
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C766));
            }
        }
        public double D767
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C767));
            }
        }
        public double D768
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C768));
            }
        }
        public double D769
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C769));
            }
        }
        public double D770
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C770));
            }
        }
        public double D771
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C771));
            }
        }
        public double D772
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C772));
            }
        }
        public double D773
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C773));
            }
        }
        public double D774
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C774));
            }
        }
        public double D775
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C775));
            }
        }
        public double D776
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C776));
            }
        }
        public double D777
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C777));
            }
        }
        public double D778
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C778));
            }
        }
        public double D779
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C779));
            }
        }
        public double D780
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C780));
            }
        }
        public double D781
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C781));
            }
        }
        public double D782
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C782));
            }
        }
        public double D783
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C783));
            }
        }
        public double D784
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C784));
            }
        }
        public double D785
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C785));
            }
        }
        public double D786
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C786));
            }
        }
        public double D787
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C787));
            }
        }
        public double D788
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C788));
            }
        }
        public double D789
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C789));
            }
        }
        public double D790
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C790));
            }
        }
        public double D791
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C791));
            }
        }
        public double D792
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C792));
            }
        }
        public double D793
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C793));
            }
        }
        public double D794
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C794));
            }
        }
        public double D795
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C795));
            }
        }
        public double D796
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C796));
            }
        }
        public double D797
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C797));
            }
        }
        public double D798
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C798));
            }
        }
        public double D799
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C799));
            }
        }
        public double D800
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C800));
            }
        }
        public double D801
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C801));
            }
        }
        public double D802
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C802));
            }
        }
        public double D803
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C803));
            }
        }
        public double D804
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C804));
            }
        }
        public double D805
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C805));
            }
        }
        public double D806
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C806));
            }
        }
        public double D807
        {
            get
            {
                return 1 - 0.5 * (1 - MathHelpers.Erf(B597 * C807));
            }
        }

        public double E607 { get; set; }
        public double E608
        {
            get
            {
                return D608 - D607;
            }
        }
        public double E609
        {
            get
            {
                return D609 - D608;
            }
        }
        public double E610
        {
            get
            {
                return D610 - D609;
            }
        }
        public double E611
        {
            get
            {
                return D611 - D610;
            }
        }
        public double E612
        {
            get
            {
                return D612 - D611;
            }
        }
        public double E613
        {
            get
            {
                return D613 - D612;
            }
        }
        public double E614
        {
            get
            {
                return D614 - D613;
            }
        }
        public double E615
        {
            get
            {
                return D615 - D614;
            }
        }
        public double E616
        {
            get
            {
                return D616 - D615;
            }
        }
        public double E617
        {
            get
            {
                return D617 - D616;
            }
        }
        public double E618
        {
            get
            {
                return D618 - D617;
            }
        }
        public double E619
        {
            get
            {
                return D619 - D618;
            }
        }
        public double E620
        {
            get
            {
                return D620 - D619;
            }
        }
        public double E621
        {
            get
            {
                return D621 - D620;
            }
        }
        public double E622
        {
            get
            {
                return D622 - D621;
            }
        }
        public double E623
        {
            get
            {
                return D623 - D622;
            }
        }
        public double E624
        {
            get
            {
                return D624 - D623;
            }
        }
        public double E625
        {
            get
            {
                return D625 - D624;
            }
        }
        public double E626
        {
            get
            {
                return D626 - D625;
            }
        }
        public double E627
        {
            get
            {
                return D627 - D626;
            }
        }
        public double E628
        {
            get
            {
                return D628 - D627;
            }
        }
        public double E629
        {
            get
            {
                return D629 - D628;
            }
        }
        public double E630
        {
            get
            {
                return D630 - D629;
            }
        }
        public double E631
        {
            get
            {
                return D631 - D630;
            }
        }
        public double E632
        {
            get
            {
                return D632 - D631;
            }
        }
        public double E633
        {
            get
            {
                return D633 - D632;
            }
        }
        public double E634
        {
            get
            {
                return D634 - D633;
            }
        }
        public double E635
        {
            get
            {
                return D635 - D634;
            }
        }
        public double E636
        {
            get
            {
                return D636 - D635;
            }
        }
        public double E637
        {
            get
            {
                return D637 - D636;
            }
        }
        public double E638
        {
            get
            {
                return D638 - D637;
            }
        }
        public double E639
        {
            get
            {
                return D639 - D638;
            }
        }
        public double E640
        {
            get
            {
                return D640 - D639;
            }
        }
        public double E641
        {
            get
            {
                return D641 - D640;
            }
        }
        public double E642
        {
            get
            {
                return D642 - D641;
            }
        }
        public double E643
        {
            get
            {
                return D643 - D642;
            }
        }
        public double E644
        {
            get
            {
                return D644 - D643;
            }
        }
        public double E645
        {
            get
            {
                return D645 - D644;
            }
        }
        public double E646
        {
            get
            {
                return D646 - D645;
            }
        }
        public double E647
        {
            get
            {
                return D647 - D646;
            }
        }
        public double E648
        {
            get
            {
                return D648 - D647;
            }
        }
        public double E649
        {
            get
            {
                return D649 - D648;
            }
        }
        public double E650
        {
            get
            {
                return D650 - D649;
            }
        }
        public double E651
        {
            get
            {
                return D651 - D650;
            }
        }
        public double E652
        {
            get
            {
                return D652 - D651;
            }
        }
        public double E653
        {
            get
            {
                return D653 - D652;
            }
        }
        public double E654
        {
            get
            {
                return D654 - D653;
            }
        }
        public double E655
        {
            get
            {
                return D655 - D654;
            }
        }
        public double E656
        {
            get
            {
                return D656 - D655;
            }
        }
        public double E657
        {
            get
            {
                return D657 - D656;
            }
        }
        public double E658
        {
            get
            {
                return D658 - D657;
            }
        }
        public double E659
        {
            get
            {
                return D659 - D658;
            }
        }
        public double E660
        {
            get
            {
                return D660 - D659;
            }
        }
        public double E661
        {
            get
            {
                return D661 - D660;
            }
        }
        public double E662
        {
            get
            {
                return D662 - D661;
            }
        }
        public double E663
        {
            get
            {
                return D663 - D662;
            }
        }
        public double E664
        {
            get
            {
                return D664 - D663;
            }
        }
        public double E665
        {
            get
            {
                return D665 - D664;
            }
        }
        public double E666
        {
            get
            {
                return D666 - D665;
            }
        }
        public double E667
        {
            get
            {
                return D667 - D666;
            }
        }
        public double E668
        {
            get
            {
                return D668 - D667;
            }
        }
        public double E669
        {
            get
            {
                return D669 - D668;
            }
        }
        public double E670
        {
            get
            {
                return D670 - D669;
            }
        }
        public double E671
        {
            get
            {
                return D671 - D670;
            }
        }
        public double E672
        {
            get
            {
                return D672 - D671;
            }
        }
        public double E673
        {
            get
            {
                return D673 - D672;
            }
        }
        public double E674
        {
            get
            {
                return D674 - D673;
            }
        }
        public double E675
        {
            get
            {
                return D675 - D674;
            }
        }
        public double E676
        {
            get
            {
                return D676 - D675;
            }
        }
        public double E677
        {
            get
            {
                return D677 - D676;
            }
        }
        public double E678
        {
            get
            {
                return D678 - D677;
            }
        }
        public double E679
        {
            get
            {
                return D679 - D678;
            }
        }
        public double E680
        {
            get
            {
                return D680 - D679;
            }
        }
        public double E681
        {
            get
            {
                return D681 - D680;
            }
        }
        public double E682
        {
            get
            {
                return D682 - D681;
            }
        }
        public double E683
        {
            get
            {
                return D683 - D682;
            }
        }
        public double E684
        {
            get
            {
                return D684 - D683;
            }
        }
        public double E685
        {
            get
            {
                return D685 - D684;
            }
        }
        public double E686
        {
            get
            {
                return D686 - D685;
            }
        }
        public double E687
        {
            get
            {
                return D687 - D686;
            }
        }
        public double E688
        {
            get
            {
                return D688 - D687;
            }
        }
        public double E689
        {
            get
            {
                return D689 - D688;
            }
        }
        public double E690
        {
            get
            {
                return D690 - D689;
            }
        }
        public double E691
        {
            get
            {
                return D691 - D690;
            }
        }
        public double E692
        {
            get
            {
                return D692 - D691;
            }
        }
        public double E693
        {
            get
            {
                return D693 - D692;
            }
        }
        public double E694
        {
            get
            {
                return D694 - D693;
            }
        }
        public double E695
        {
            get
            {
                return D695 - D694;
            }
        }
        public double E696
        {
            get
            {
                return D696 - D695;
            }
        }
        public double E697
        {
            get
            {
                return D697 - D696;
            }
        }
        public double E698
        {
            get
            {
                return D698 - D697;
            }
        }
        public double E699
        {
            get
            {
                return D699 - D698;
            }
        }
        public double E700
        {
            get
            {
                return D700 - D699;
            }
        }
        public double E701
        {
            get
            {
                return D701 - D700;
            }
        }
        public double E702
        {
            get
            {
                return D702 - D701;
            }
        }
        public double E703
        {
            get
            {
                return D703 - D702;
            }
        }
        public double E704
        {
            get
            {
                return D704 - D703;
            }
        }
        public double E705
        {
            get
            {
                return D705 - D704;
            }
        }
        public double E706
        {
            get
            {
                return D706 - D705;
            }
        }
        public double E707
        {
            get
            {
                return D707 - D706;
            }
        }
        public double E708
        {
            get
            {
                return D708 - D707;
            }
        }
        public double E709
        {
            get
            {
                return D709 - D708;
            }
        }
        public double E710
        {
            get
            {
                return D710 - D709;
            }
        }
        public double E711
        {
            get
            {
                return D711 - D710;
            }
        }
        public double E712
        {
            get
            {
                return D712 - D711;
            }
        }
        public double E713
        {
            get
            {
                return D713 - D712;
            }
        }
        public double E714
        {
            get
            {
                return D714 - D713;
            }
        }
        public double E715
        {
            get
            {
                return D715 - D714;
            }
        }
        public double E716
        {
            get
            {
                return D716 - D715;
            }
        }
        public double E717
        {
            get
            {
                return D717 - D716;
            }
        }
        public double E718
        {
            get
            {
                return D718 - D717;
            }
        }
        public double E719
        {
            get
            {
                return D719 - D718;
            }
        }
        public double E720
        {
            get
            {
                return D720 - D719;
            }
        }
        public double E721
        {
            get
            {
                return D721 - D720;
            }
        }
        public double E722
        {
            get
            {
                return D722 - D721;
            }
        }
        public double E723
        {
            get
            {
                return D723 - D722;
            }
        }
        public double E724
        {
            get
            {
                return D724 - D723;
            }
        }
        public double E725
        {
            get
            {
                return D725 - D724;
            }
        }
        public double E726
        {
            get
            {
                return D726 - D725;
            }
        }
        public double E727
        {
            get
            {
                return D727 - D726;
            }
        }
        public double E728
        {
            get
            {
                return D728 - D727;
            }
        }
        public double E729
        {
            get
            {
                return D729 - D728;
            }
        }
        public double E730
        {
            get
            {
                return D730 - D729;
            }
        }
        public double E731
        {
            get
            {
                return D731 - D730;
            }
        }
        public double E732
        {
            get
            {
                return D732 - D731;
            }
        }
        public double E733
        {
            get
            {
                return D733 - D732;
            }
        }
        public double E734
        {
            get
            {
                return D734 - D733;
            }
        }
        public double E735
        {
            get
            {
                return D735 - D734;
            }
        }
        public double E736
        {
            get
            {
                return D736 - D735;
            }
        }
        public double E737
        {
            get
            {
                return D737 - D736;
            }
        }
        public double E738
        {
            get
            {
                return D738 - D737;
            }
        }
        public double E739
        {
            get
            {
                return D739 - D738;
            }
        }
        public double E740
        {
            get
            {
                return D740 - D739;
            }
        }
        public double E741
        {
            get
            {
                return D741 - D740;
            }
        }
        public double E742
        {
            get
            {
                return D742 - D741;
            }
        }
        public double E743
        {
            get
            {
                return D743 - D742;
            }
        }
        public double E744
        {
            get
            {
                return D744 - D743;
            }
        }
        public double E745
        {
            get
            {
                return D745 - D744;
            }
        }
        public double E746
        {
            get
            {
                return D746 - D745;
            }
        }
        public double E747
        {
            get
            {
                return D747 - D746;
            }
        }
        public double E748
        {
            get
            {
                return D748 - D747;
            }
        }
        public double E749
        {
            get
            {
                return D749 - D748;
            }
        }
        public double E750
        {
            get
            {
                return D750 - D749;
            }
        }
        public double E751
        {
            get
            {
                return D751 - D750;
            }
        }
        public double E752
        {
            get
            {
                return D752 - D751;
            }
        }
        public double E753
        {
            get
            {
                return D753 - D752;
            }
        }
        public double E754
        {
            get
            {
                return D754 - D753;
            }
        }
        public double E755
        {
            get
            {
                return D755 - D754;
            }
        }
        public double E756
        {
            get
            {
                return D756 - D755;
            }
        }
        public double E757
        {
            get
            {
                return D757 - D756;
            }
        }
        public double E758
        {
            get
            {
                return D758 - D757;
            }
        }
        public double E759
        {
            get
            {
                return D759 - D758;
            }
        }
        public double E760
        {
            get
            {
                return D760 - D759;
            }
        }
        public double E761
        {
            get
            {
                return D761 - D760;
            }
        }
        public double E762
        {
            get
            {
                return D762 - D761;
            }
        }
        public double E763
        {
            get
            {
                return D763 - D762;
            }
        }
        public double E764
        {
            get
            {
                return D764 - D763;
            }
        }
        public double E765
        {
            get
            {
                return D765 - D764;
            }
        }
        public double E766
        {
            get
            {
                return D766 - D765;
            }
        }
        public double E767
        {
            get
            {
                return D767 - D766;
            }
        }
        public double E768
        {
            get
            {
                return D768 - D767;
            }
        }
        public double E769
        {
            get
            {
                return D769 - D768;
            }
        }
        public double E770
        {
            get
            {
                return D770 - D769;
            }
        }
        public double E771
        {
            get
            {
                return D771 - D770;
            }
        }
        public double E772
        {
            get
            {
                return D772 - D771;
            }
        }
        public double E773
        {
            get
            {
                return D773 - D772;
            }
        }
        public double E774
        {
            get
            {
                return D774 - D773;
            }
        }
        public double E775
        {
            get
            {
                return D775 - D774;
            }
        }
        public double E776
        {
            get
            {
                return D776 - D775;
            }
        }
        public double E777
        {
            get
            {
                return D777 - D776;
            }
        }
        public double E778
        {
            get
            {
                return D778 - D777;
            }
        }
        public double E779
        {
            get
            {
                return D779 - D778;
            }
        }
        public double E780
        {
            get
            {
                return D780 - D779;
            }
        }
        public double E781
        {
            get
            {
                return D781 - D780;
            }
        }
        public double E782
        {
            get
            {
                return D782 - D781;
            }
        }
        public double E783
        {
            get
            {
                return D783 - D782;
            }
        }
        public double E784
        {
            get
            {
                return D784 - D783;
            }
        }
        public double E785
        {
            get
            {
                return D785 - D784;
            }
        }
        public double E786
        {
            get
            {
                return D786 - D785;
            }
        }
        public double E787
        {
            get
            {
                return D787 - D786;
            }
        }
        public double E788
        {
            get
            {
                return D788 - D787;
            }
        }
        public double E789
        {
            get
            {
                return D789 - D788;
            }
        }
        public double E790
        {
            get
            {
                return D790 - D789;
            }
        }
        public double E791
        {
            get
            {
                return D791 - D790;
            }
        }
        public double E792
        {
            get
            {
                return D792 - D791;
            }
        }
        public double E793
        {
            get
            {
                return D793 - D792;
            }
        }
        public double E794
        {
            get
            {
                return D794 - D793;
            }
        }
        public double E795
        {
            get
            {
                return D795 - D794;
            }
        }
        public double E796
        {
            get
            {
                return D796 - D795;
            }
        }
        public double E797
        {
            get
            {
                return D797 - D796;
            }
        }
        public double E798
        {
            get
            {
                return D798 - D797;
            }
        }
        public double E799
        {
            get
            {
                return D799 - D798;
            }
        }
        public double E800
        {
            get
            {
                return D800 - D799;
            }
        }
        public double E801
        {
            get
            {
                return D801 - D800;
            }
        }
        public double E802
        {
            get
            {
                return D802 - D801;
            }
        }
        public double E803
        {
            get
            {
                return D803 - D802;
            }
        }
        public double E804
        {
            get
            {
                return D804 - D803;
            }
        }
        public double E805
        {
            get
            {
                return D805 - D804;
            }
        }
        public double E806
        {
            get
            {
                return D806 - D805;
            }
        }
        public double E807
        {
            get
            {
                return D807 - D806;
            }
        }

        public double F607
        {
            get
            {
                return E607 * B585;
            }
        }
        public double F608
        {
            get
            {
                return E608 * B585;
            }
        }
        public double F609
        {
            get
            {
                return E609 * B585;
            }
        }
        public double F610
        {
            get
            {
                return E610 * B585;
            }
        }
        public double F611
        {
            get
            {
                return E611 * B585;
            }
        }
        public double F612
        {
            get
            {
                return E612 * B585;
            }
        }
        public double F613
        {
            get
            {
                return E613 * B585;
            }
        }
        public double F614
        {
            get
            {
                return E614 * B585;
            }
        }
        public double F615
        {
            get
            {
                return E615 * B585;
            }
        }
        public double F616
        {
            get
            {
                return E616 * B585;
            }
        }
        public double F617
        {
            get
            {
                return E617 * B585;
            }
        }
        public double F618
        {
            get
            {
                return E618 * B585;
            }
        }
        public double F619
        {
            get
            {
                return E619 * B585;
            }
        }
        public double F620
        {
            get
            {
                return E620 * B585;
            }
        }
        public double F621
        {
            get
            {
                return E621 * B585;
            }
        }
        public double F622
        {
            get
            {
                return E622 * B585;
            }
        }
        public double F623
        {
            get
            {
                return E623 * B585;
            }
        }
        public double F624
        {
            get
            {
                return E624 * B585;
            }
        }
        public double F625
        {
            get
            {
                return E625 * B585;
            }
        }
        public double F626
        {
            get
            {
                return E626 * B585;
            }
        }
        public double F627
        {
            get
            {
                return E627 * B585;
            }
        }
        public double F628
        {
            get
            {
                return E628 * B585;
            }
        }
        public double F629
        {
            get
            {
                return E629 * B585;
            }
        }
        public double F630
        {
            get
            {
                return E630 * B585;
            }
        }
        public double F631
        {
            get
            {
                return E631 * B585;
            }
        }
        public double F632
        {
            get
            {
                return E632 * B585;
            }
        }
        public double F633
        {
            get
            {
                return E633 * B585;
            }
        }
        public double F634
        {
            get
            {
                return E634 * B585;
            }
        }
        public double F635
        {
            get
            {
                return E635 * B585;
            }
        }
        public double F636
        {
            get
            {
                return E636 * B585;
            }
        }
        public double F637
        {
            get
            {
                return E637 * B585;
            }
        }
        public double F638
        {
            get
            {
                return E638 * B585;
            }
        }
        public double F639
        {
            get
            {
                return E639 * B585;
            }
        }
        public double F640
        {
            get
            {
                return E640 * B585;
            }
        }
        public double F641
        {
            get
            {
                return E641 * B585;
            }
        }
        public double F642
        {
            get
            {
                return E642 * B585;
            }
        }
        public double F643
        {
            get
            {
                return E643 * B585;
            }
        }
        public double F644
        {
            get
            {
                return E644 * B585;
            }
        }
        public double F645
        {
            get
            {
                return E645 * B585;
            }
        }
        public double F646
        {
            get
            {
                return E646 * B585;
            }
        }
        public double F647
        {
            get
            {
                return E647 * B585;
            }
        }
        public double F648
        {
            get
            {
                return E648 * B585;
            }
        }
        public double F649
        {
            get
            {
                return E649 * B585;
            }
        }
        public double F650
        {
            get
            {
                return E650 * B585;
            }
        }
        public double F651
        {
            get
            {
                return E651 * B585;
            }
        }
        public double F652
        {
            get
            {
                return E652 * B585;
            }
        }
        public double F653
        {
            get
            {
                return E653 * B585;
            }
        }
        public double F654
        {
            get
            {
                return E654 * B585;
            }
        }
        public double F655
        {
            get
            {
                return E655 * B585;
            }
        }
        public double F656
        {
            get
            {
                return E656 * B585;
            }
        }
        public double F657
        {
            get
            {
                return E657 * B585;
            }
        }
        public double F658
        {
            get
            {
                return E658 * B585;
            }
        }
        public double F659
        {
            get
            {
                return E659 * B585;
            }
        }
        public double F660
        {
            get
            {
                return E660 * B585;
            }
        }
        public double F661
        {
            get
            {
                return E661 * B585;
            }
        }
        public double F662
        {
            get
            {
                return E662 * B585;
            }
        }
        public double F663
        {
            get
            {
                return E663 * B585;
            }
        }
        public double F664
        {
            get
            {
                return E664 * B585;
            }
        }
        public double F665
        {
            get
            {
                return E665 * B585;
            }
        }
        public double F666
        {
            get
            {
                return E666 * B585;
            }
        }
        public double F667
        {
            get
            {
                return E667 * B585;
            }
        }
        public double F668
        {
            get
            {
                return E668 * B585;
            }
        }
        public double F669
        {
            get
            {
                return E669 * B585;
            }
        }
        public double F670
        {
            get
            {
                return E670 * B585;
            }
        }
        public double F671
        {
            get
            {
                return E671 * B585;
            }
        }
        public double F672
        {
            get
            {
                return E672 * B585;
            }
        }
        public double F673
        {
            get
            {
                return E673 * B585;
            }
        }
        public double F674
        {
            get
            {
                return E674 * B585;
            }
        }
        public double F675
        {
            get
            {
                return E675 * B585;
            }
        }
        public double F676
        {
            get
            {
                return E676 * B585;
            }
        }
        public double F677
        {
            get
            {
                return E677 * B585;
            }
        }
        public double F678
        {
            get
            {
                return E678 * B585;
            }
        }
        public double F679
        {
            get
            {
                return E679 * B585;
            }
        }
        public double F680
        {
            get
            {
                return E680 * B585;
            }
        }
        public double F681
        {
            get
            {
                return E681 * B585;
            }
        }
        public double F682
        {
            get
            {
                return E682 * B585;
            }
        }
        public double F683
        {
            get
            {
                return E683 * B585;
            }
        }
        public double F684
        {
            get
            {
                return E684 * B585;
            }
        }
        public double F685
        {
            get
            {
                return E685 * B585;
            }
        }
        public double F686
        {
            get
            {
                return E686 * B585;
            }
        }
        public double F687
        {
            get
            {
                return E687 * B585;
            }
        }
        public double F688
        {
            get
            {
                return E688 * B585;
            }
        }
        public double F689
        {
            get
            {
                return E689 * B585;
            }
        }
        public double F690
        {
            get
            {
                return E690 * B585;
            }
        }
        public double F691
        {
            get
            {
                return E691 * B585;
            }
        }
        public double F692
        {
            get
            {
                return E692 * B585;
            }
        }
        public double F693
        {
            get
            {
                return E693 * B585;
            }
        }
        public double F694
        {
            get
            {
                return E694 * B585;
            }
        }
        public double F695
        {
            get
            {
                return E695 * B585;
            }
        }
        public double F696
        {
            get
            {
                return E696 * B585;
            }
        }
        public double F697
        {
            get
            {
                return E697 * B585;
            }
        }
        public double F698
        {
            get
            {
                return E698 * B585;
            }
        }
        public double F699
        {
            get
            {
                return E699 * B585;
            }
        }
        public double F700
        {
            get
            {
                return E700 * B585;
            }
        }
        public double F701
        {
            get
            {
                return E701 * B585;
            }
        }
        public double F702
        {
            get
            {
                return E702 * B585;
            }
        }
        public double F703
        {
            get
            {
                return E703 * B585;
            }
        }
        public double F704
        {
            get
            {
                return E704 * B585;
            }
        }
        public double F705
        {
            get
            {
                return E705 * B585;
            }
        }
        public double F706
        {
            get
            {
                return E706 * B585;
            }
        }
        public double F707
        {
            get
            {
                return E707 * B585;
            }
        }
        public double F708
        {
            get
            {
                return E708 * B585;
            }
        }
        public double F709
        {
            get
            {
                return E709 * B585;
            }
        }
        public double F710
        {
            get
            {
                return E710 * B585;
            }
        }
        public double F711
        {
            get
            {
                return E711 * B585;
            }
        }
        public double F712
        {
            get
            {
                return E712 * B585;
            }
        }
        public double F713
        {
            get
            {
                return E713 * B585;
            }
        }
        public double F714
        {
            get
            {
                return E714 * B585;
            }
        }
        public double F715
        {
            get
            {
                return E715 * B585;
            }
        }
        public double F716
        {
            get
            {
                return E716 * B585;
            }
        }
        public double F717
        {
            get
            {
                return E717 * B585;
            }
        }
        public double F718
        {
            get
            {
                return E718 * B585;
            }
        }
        public double F719
        {
            get
            {
                return E719 * B585;
            }
        }
        public double F720
        {
            get
            {
                return E720 * B585;
            }
        }
        public double F721
        {
            get
            {
                return E721 * B585;
            }
        }
        public double F722
        {
            get
            {
                return E722 * B585;
            }
        }
        public double F723
        {
            get
            {
                return E723 * B585;
            }
        }
        public double F724
        {
            get
            {
                return E724 * B585;
            }
        }
        public double F725
        {
            get
            {
                return E725 * B585;
            }
        }
        public double F726
        {
            get
            {
                return E726 * B585;
            }
        }
        public double F727
        {
            get
            {
                return E727 * B585;
            }
        }
        public double F728
        {
            get
            {
                return E728 * B585;
            }
        }
        public double F729
        {
            get
            {
                return E729 * B585;
            }
        }
        public double F730
        {
            get
            {
                return E730 * B585;
            }
        }
        public double F731
        {
            get
            {
                return E731 * B585;
            }
        }
        public double F732
        {
            get
            {
                return E732 * B585;
            }
        }
        public double F733
        {
            get
            {
                return E733 * B585;
            }
        }
        public double F734
        {
            get
            {
                return E734 * B585;
            }
        }
        public double F735
        {
            get
            {
                return E735 * B585;
            }
        }
        public double F736
        {
            get
            {
                return E736 * B585;
            }
        }
        public double F737
        {
            get
            {
                return E737 * B585;
            }
        }
        public double F738
        {
            get
            {
                return E738 * B585;
            }
        }
        public double F739
        {
            get
            {
                return E739 * B585;
            }
        }
        public double F740
        {
            get
            {
                return E740 * B585;
            }
        }
        public double F741
        {
            get
            {
                return E741 * B585;
            }
        }
        public double F742
        {
            get
            {
                return E742 * B585;
            }
        }
        public double F743
        {
            get
            {
                return E743 * B585;
            }
        }
        public double F744
        {
            get
            {
                return E744 * B585;
            }
        }
        public double F745
        {
            get
            {
                return E745 * B585;
            }
        }
        public double F746
        {
            get
            {
                return E746 * B585;
            }
        }
        public double F747
        {
            get
            {
                return E747 * B585;
            }
        }
        public double F748
        {
            get
            {
                return E748 * B585;
            }
        }
        public double F749
        {
            get
            {
                return E749 * B585;
            }
        }
        public double F750
        {
            get
            {
                return E750 * B585;
            }
        }
        public double F751
        {
            get
            {
                return E751 * B585;
            }
        }
        public double F752
        {
            get
            {
                return E752 * B585;
            }
        }
        public double F753
        {
            get
            {
                return E753 * B585;
            }
        }
        public double F754
        {
            get
            {
                return E754 * B585;
            }
        }
        public double F755
        {
            get
            {
                return E755 * B585;
            }
        }
        public double F756
        {
            get
            {
                return E756 * B585;
            }
        }
        public double F757
        {
            get
            {
                return E757 * B585;
            }
        }
        public double F758
        {
            get
            {
                return E758 * B585;
            }
        }
        public double F759
        {
            get
            {
                return E759 * B585;
            }
        }
        public double F760
        {
            get
            {
                return E760 * B585;
            }
        }
        public double F761
        {
            get
            {
                return E761 * B585;
            }
        }
        public double F762
        {
            get
            {
                return E762 * B585;
            }
        }
        public double F763
        {
            get
            {
                return E763 * B585;
            }
        }
        public double F764
        {
            get
            {
                return E764 * B585;
            }
        }
        public double F765
        {
            get
            {
                return E765 * B585;
            }
        }
        public double F766
        {
            get
            {
                return E766 * B585;
            }
        }
        public double F767
        {
            get
            {
                return E767 * B585;
            }
        }
        public double F768
        {
            get
            {
                return E768 * B585;
            }
        }
        public double F769
        {
            get
            {
                return E769 * B585;
            }
        }
        public double F770
        {
            get
            {
                return E770 * B585;
            }
        }
        public double F771
        {
            get
            {
                return E771 * B585;
            }
        }
        public double F772
        {
            get
            {
                return E772 * B585;
            }
        }
        public double F773
        {
            get
            {
                return E773 * B585;
            }
        }
        public double F774
        {
            get
            {
                return E774 * B585;
            }
        }
        public double F775
        {
            get
            {
                return E775 * B585;
            }
        }
        public double F776
        {
            get
            {
                return E776 * B585;
            }
        }
        public double F777
        {
            get
            {
                return E777 * B585;
            }
        }
        public double F778
        {
            get
            {
                return E778 * B585;
            }
        }
        public double F779
        {
            get
            {
                return E779 * B585;
            }
        }
        public double F780
        {
            get
            {
                return E780 * B585;
            }
        }
        public double F781
        {
            get
            {
                return E781 * B585;
            }
        }
        public double F782
        {
            get
            {
                return E782 * B585;
            }
        }
        public double F783
        {
            get
            {
                return E783 * B585;
            }
        }
        public double F784
        {
            get
            {
                return E784 * B585;
            }
        }
        public double F785
        {
            get
            {
                return E785 * B585;
            }
        }
        public double F786
        {
            get
            {
                return E786 * B585;
            }
        }
        public double F787
        {
            get
            {
                return E787 * B585;
            }
        }
        public double F788
        {
            get
            {
                return E788 * B585;
            }
        }
        public double F789
        {
            get
            {
                return E789 * B585;
            }
        }
        public double F790
        {
            get
            {
                return E790 * B585;
            }
        }
        public double F791
        {
            get
            {
                return E791 * B585;
            }
        }
        public double F792
        {
            get
            {
                return E792 * B585;
            }
        }
        public double F793
        {
            get
            {
                return E793 * B585;
            }
        }
        public double F794
        {
            get
            {
                return E794 * B585;
            }
        }
        public double F795
        {
            get
            {
                return E795 * B585;
            }
        }
        public double F796
        {
            get
            {
                return E796 * B585;
            }
        }
        public double F797
        {
            get
            {
                return E797 * B585;
            }
        }
        public double F798
        {
            get
            {
                return E798 * B585;
            }
        }
        public double F799
        {
            get
            {
                return E799 * B585;
            }
        }
        public double F800
        {
            get
            {
                return E800 * B585;
            }
        }
        public double F801
        {
            get
            {
                return E801 * B585;
            }
        }
        public double F802
        {
            get
            {
                return E802 * B585;
            }
        }
        public double F803
        {
            get
            {
                return E803 * B585;
            }
        }
        public double F804
        {
            get
            {
                return E804 * B585;
            }
        }
        public double F805
        {
            get
            {
                return E805 * B585;
            }
        }
        public double F806
        {
            get
            {
                return E806 * B585;
            }
        }
        public double F807
        {
            get
            {
                return E807 * B585;
            }
        }

        public double I607
        {
            get
            {
                return (B3 == Position.Vertical ? (A607 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A607 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I608
        {
            get
            {
                return (B3 == Position.Vertical ? (A608 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A608 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I609
        {
            get
            {
                return (B3 == Position.Vertical ? (A609 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A609 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I610
        {
            get
            {
                return (B3 == Position.Vertical ? (A610 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A610 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I611
        {
            get
            {
                return (B3 == Position.Vertical ? (A611 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A611 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I612
        {
            get
            {
                return (B3 == Position.Vertical ? (A612 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A612 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I613
        {
            get
            {
                return (B3 == Position.Vertical ? (A613 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A613 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I614
        {
            get
            {
                return (B3 == Position.Vertical ? (A614 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A614 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I615
        {
            get
            {
                return (B3 == Position.Vertical ? (A615 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A615 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I616
        {
            get
            {
                return (B3 == Position.Vertical ? (A616 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A616 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I617
        {
            get
            {
                return (B3 == Position.Vertical ? (A617 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A617 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I618
        {
            get
            {
                return (B3 == Position.Vertical ? (A618 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A618 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I619
        {
            get
            {
                return (B3 == Position.Vertical ? (A619 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A619 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I620
        {
            get
            {
                return (B3 == Position.Vertical ? (A620 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A620 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I621
        {
            get
            {
                return (B3 == Position.Vertical ? (A621 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A621 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I622
        {
            get
            {
                return (B3 == Position.Vertical ? (A622 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A622 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I623
        {
            get
            {
                return (B3 == Position.Vertical ? (A623 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A623 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I624
        {
            get
            {
                return (B3 == Position.Vertical ? (A624 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A624 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I625
        {
            get
            {
                return (B3 == Position.Vertical ? (A625 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A625 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I626
        {
            get
            {
                return (B3 == Position.Vertical ? (A626 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A626 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I627
        {
            get
            {
                return (B3 == Position.Vertical ? (A627 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A627 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I628
        {
            get
            {
                return (B3 == Position.Vertical ? (A628 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A628 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I629
        {
            get
            {
                return (B3 == Position.Vertical ? (A629 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A629 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I630
        {
            get
            {
                return (B3 == Position.Vertical ? (A630 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A630 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I631
        {
            get
            {
                return (B3 == Position.Vertical ? (A631 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A631 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I632
        {
            get
            {
                return (B3 == Position.Vertical ? (A632 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A632 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I633
        {
            get
            {
                return (B3 == Position.Vertical ? (A633 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A633 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I634
        {
            get
            {
                return (B3 == Position.Vertical ? (A634 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A634 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I635
        {
            get
            {
                return (B3 == Position.Vertical ? (A635 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A635 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I636
        {
            get
            {
                return (B3 == Position.Vertical ? (A636 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A636 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I637
        {
            get
            {
                return (B3 == Position.Vertical ? (A637 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A637 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I638
        {
            get
            {
                return (B3 == Position.Vertical ? (A638 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A638 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I639
        {
            get
            {
                return (B3 == Position.Vertical ? (A639 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A639 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I640
        {
            get
            {
                return (B3 == Position.Vertical ? (A640 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A640 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I641
        {
            get
            {
                return (B3 == Position.Vertical ? (A641 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A641 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I642
        {
            get
            {
                return (B3 == Position.Vertical ? (A642 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A642 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I643
        {
            get
            {
                return (B3 == Position.Vertical ? (A643 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A643 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I644
        {
            get
            {
                return (B3 == Position.Vertical ? (A644 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A644 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I645
        {
            get
            {
                return (B3 == Position.Vertical ? (A645 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A645 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I646
        {
            get
            {
                return (B3 == Position.Vertical ? (A646 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A646 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I647
        {
            get
            {
                return (B3 == Position.Vertical ? (A647 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A647 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I648
        {
            get
            {
                return (B3 == Position.Vertical ? (A648 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A648 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I649
        {
            get
            {
                return (B3 == Position.Vertical ? (A649 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A649 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I650
        {
            get
            {
                return (B3 == Position.Vertical ? (A650 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A650 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I651
        {
            get
            {
                return (B3 == Position.Vertical ? (A651 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A651 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I652
        {
            get
            {
                return (B3 == Position.Vertical ? (A652 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A652 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I653
        {
            get
            {
                return (B3 == Position.Vertical ? (A653 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A653 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I654
        {
            get
            {
                return (B3 == Position.Vertical ? (A654 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A654 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I655
        {
            get
            {
                return (B3 == Position.Vertical ? (A655 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A655 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I656
        {
            get
            {
                return (B3 == Position.Vertical ? (A656 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A656 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I657
        {
            get
            {
                return (B3 == Position.Vertical ? (A657 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A657 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I658
        {
            get
            {
                return (B3 == Position.Vertical ? (A658 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A658 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I659
        {
            get
            {
                return (B3 == Position.Vertical ? (A659 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A659 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I660
        {
            get
            {
                return (B3 == Position.Vertical ? (A660 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A660 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I661
        {
            get
            {
                return (B3 == Position.Vertical ? (A661 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A661 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I662
        {
            get
            {
                return (B3 == Position.Vertical ? (A662 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A662 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I663
        {
            get
            {
                return (B3 == Position.Vertical ? (A663 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A663 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I664
        {
            get
            {
                return (B3 == Position.Vertical ? (A664 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A664 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I665
        {
            get
            {
                return (B3 == Position.Vertical ? (A665 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A665 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I666
        {
            get
            {
                return (B3 == Position.Vertical ? (A666 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A666 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I667
        {
            get
            {
                return (B3 == Position.Vertical ? (A667 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A667 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I668
        {
            get
            {
                return (B3 == Position.Vertical ? (A668 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A668 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I669
        {
            get
            {
                return (B3 == Position.Vertical ? (A669 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A669 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I670
        {
            get
            {
                return (B3 == Position.Vertical ? (A670 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A670 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I671
        {
            get
            {
                return (B3 == Position.Vertical ? (A671 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A671 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I672
        {
            get
            {
                return (B3 == Position.Vertical ? (A672 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A672 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I673
        {
            get
            {
                return (B3 == Position.Vertical ? (A673 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A673 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I674
        {
            get
            {
                return (B3 == Position.Vertical ? (A674 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A674 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I675
        {
            get
            {
                return (B3 == Position.Vertical ? (A675 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A675 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I676
        {
            get
            {
                return (B3 == Position.Vertical ? (A676 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A676 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I677
        {
            get
            {
                return (B3 == Position.Vertical ? (A677 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A677 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I678
        {
            get
            {
                return (B3 == Position.Vertical ? (A678 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A678 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I679
        {
            get
            {
                return (B3 == Position.Vertical ? (A679 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A679 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I680
        {
            get
            {
                return (B3 == Position.Vertical ? (A680 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A680 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I681
        {
            get
            {
                return (B3 == Position.Vertical ? (A681 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A681 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I682
        {
            get
            {
                return (B3 == Position.Vertical ? (A682 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A682 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I683
        {
            get
            {
                return (B3 == Position.Vertical ? (A683 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A683 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I684
        {
            get
            {
                return (B3 == Position.Vertical ? (A684 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A684 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I685
        {
            get
            {
                return (B3 == Position.Vertical ? (A685 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A685 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I686
        {
            get
            {
                return (B3 == Position.Vertical ? (A686 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A686 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I687
        {
            get
            {
                return (B3 == Position.Vertical ? (A687 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A687 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I688
        {
            get
            {
                return (B3 == Position.Vertical ? (A688 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A688 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I689
        {
            get
            {
                return (B3 == Position.Vertical ? (A689 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A689 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I690
        {
            get
            {
                return (B3 == Position.Vertical ? (A690 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A690 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I691
        {
            get
            {
                return (B3 == Position.Vertical ? (A691 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A691 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I692
        {
            get
            {
                return (B3 == Position.Vertical ? (A692 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A692 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I693
        {
            get
            {
                return (B3 == Position.Vertical ? (A693 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A693 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I694
        {
            get
            {
                return (B3 == Position.Vertical ? (A694 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A694 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I695
        {
            get
            {
                return (B3 == Position.Vertical ? (A695 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A695 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I696
        {
            get
            {
                return (B3 == Position.Vertical ? (A696 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A696 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I697
        {
            get
            {
                return (B3 == Position.Vertical ? (A697 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A697 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I698
        {
            get
            {
                return (B3 == Position.Vertical ? (A698 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A698 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I699
        {
            get
            {
                return (B3 == Position.Vertical ? (A699 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A699 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I700
        {
            get
            {
                return (B3 == Position.Vertical ? (A700 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A700 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I701
        {
            get
            {
                return (B3 == Position.Vertical ? (A701 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A701 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I702
        {
            get
            {
                return (B3 == Position.Vertical ? (A702 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A702 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I703
        {
            get
            {
                return (B3 == Position.Vertical ? (A703 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A703 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I704
        {
            get
            {
                return (B3 == Position.Vertical ? (A704 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A704 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I705
        {
            get
            {
                return (B3 == Position.Vertical ? (A705 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A705 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I706
        {
            get
            {
                return (B3 == Position.Vertical ? (A706 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A706 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I707
        {
            get
            {
                return (B3 == Position.Vertical ? (A707 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A707 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I708
        {
            get
            {
                return (B3 == Position.Vertical ? (A708 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A708 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I709
        {
            get
            {
                return (B3 == Position.Vertical ? (A709 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A709 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I710
        {
            get
            {
                return (B3 == Position.Vertical ? (A710 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A710 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I711
        {
            get
            {
                return (B3 == Position.Vertical ? (A711 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A711 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I712
        {
            get
            {
                return (B3 == Position.Vertical ? (A712 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A712 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I713
        {
            get
            {
                return (B3 == Position.Vertical ? (A713 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A713 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I714
        {
            get
            {
                return (B3 == Position.Vertical ? (A714 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A714 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I715
        {
            get
            {
                return (B3 == Position.Vertical ? (A715 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A715 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I716
        {
            get
            {
                return (B3 == Position.Vertical ? (A716 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A716 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I717
        {
            get
            {
                return (B3 == Position.Vertical ? (A717 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A717 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I718
        {
            get
            {
                return (B3 == Position.Vertical ? (A718 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A718 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I719
        {
            get
            {
                return (B3 == Position.Vertical ? (A719 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A719 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I720
        {
            get
            {
                return (B3 == Position.Vertical ? (A720 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A720 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I721
        {
            get
            {
                return (B3 == Position.Vertical ? (A721 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A721 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I722
        {
            get
            {
                return (B3 == Position.Vertical ? (A722 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A722 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I723
        {
            get
            {
                return (B3 == Position.Vertical ? (A723 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A723 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I724
        {
            get
            {
                return (B3 == Position.Vertical ? (A724 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A724 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I725
        {
            get
            {
                return (B3 == Position.Vertical ? (A725 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A725 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I726
        {
            get
            {
                return (B3 == Position.Vertical ? (A726 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A726 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I727
        {
            get
            {
                return (B3 == Position.Vertical ? (A727 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A727 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I728
        {
            get
            {
                return (B3 == Position.Vertical ? (A728 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A728 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I729
        {
            get
            {
                return (B3 == Position.Vertical ? (A729 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A729 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I730
        {
            get
            {
                return (B3 == Position.Vertical ? (A730 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A730 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I731
        {
            get
            {
                return (B3 == Position.Vertical ? (A731 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A731 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I732
        {
            get
            {
                return (B3 == Position.Vertical ? (A732 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A732 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I733
        {
            get
            {
                return (B3 == Position.Vertical ? (A733 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A733 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I734
        {
            get
            {
                return (B3 == Position.Vertical ? (A734 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A734 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I735
        {
            get
            {
                return (B3 == Position.Vertical ? (A735 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A735 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I736
        {
            get
            {
                return (B3 == Position.Vertical ? (A736 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A736 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I737
        {
            get
            {
                return (B3 == Position.Vertical ? (A737 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A737 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I738
        {
            get
            {
                return (B3 == Position.Vertical ? (A738 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A738 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I739
        {
            get
            {
                return (B3 == Position.Vertical ? (A739 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A739 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I740
        {
            get
            {
                return (B3 == Position.Vertical ? (A740 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A740 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I741
        {
            get
            {
                return (B3 == Position.Vertical ? (A741 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A741 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I742
        {
            get
            {
                return (B3 == Position.Vertical ? (A742 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A742 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I743
        {
            get
            {
                return (B3 == Position.Vertical ? (A743 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A743 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I744
        {
            get
            {
                return (B3 == Position.Vertical ? (A744 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A744 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I745
        {
            get
            {
                return (B3 == Position.Vertical ? (A745 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A745 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I746
        {
            get
            {
                return (B3 == Position.Vertical ? (A746 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A746 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I747
        {
            get
            {
                return (B3 == Position.Vertical ? (A747 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A747 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I748
        {
            get
            {
                return (B3 == Position.Vertical ? (A748 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A748 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I749
        {
            get
            {
                return (B3 == Position.Vertical ? (A749 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A749 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I750
        {
            get
            {
                return (B3 == Position.Vertical ? (A750 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A750 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I751
        {
            get
            {
                return (B3 == Position.Vertical ? (A751 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A751 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I752
        {
            get
            {
                return (B3 == Position.Vertical ? (A752 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A752 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I753
        {
            get
            {
                return (B3 == Position.Vertical ? (A753 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A753 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I754
        {
            get
            {
                return (B3 == Position.Vertical ? (A754 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A754 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I755
        {
            get
            {
                return (B3 == Position.Vertical ? (A755 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A755 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I756
        {
            get
            {
                return (B3 == Position.Vertical ? (A756 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A756 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I757
        {
            get
            {
                return (B3 == Position.Vertical ? (A757 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A757 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I758
        {
            get
            {
                return (B3 == Position.Vertical ? (A758 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A758 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I759
        {
            get
            {
                return (B3 == Position.Vertical ? (A759 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A759 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I760
        {
            get
            {
                return (B3 == Position.Vertical ? (A760 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A760 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I761
        {
            get
            {
                return (B3 == Position.Vertical ? (A761 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A761 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I762
        {
            get
            {
                return (B3 == Position.Vertical ? (A762 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A762 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I763
        {
            get
            {
                return (B3 == Position.Vertical ? (A763 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A763 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I764
        {
            get
            {
                return (B3 == Position.Vertical ? (A764 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A764 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I765
        {
            get
            {
                return (B3 == Position.Vertical ? (A765 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A765 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I766
        {
            get
            {
                return (B3 == Position.Vertical ? (A766 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A766 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I767
        {
            get
            {
                return (B3 == Position.Vertical ? (A767 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A767 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I768
        {
            get
            {
                return (B3 == Position.Vertical ? (A768 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A768 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I769
        {
            get
            {
                return (B3 == Position.Vertical ? (A769 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A769 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I770
        {
            get
            {
                return (B3 == Position.Vertical ? (A770 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A770 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I771
        {
            get
            {
                return (B3 == Position.Vertical ? (A771 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A771 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I772
        {
            get
            {
                return (B3 == Position.Vertical ? (A772 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A772 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I773
        {
            get
            {
                return (B3 == Position.Vertical ? (A773 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A773 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I774
        {
            get
            {
                return (B3 == Position.Vertical ? (A774 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A774 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I775
        {
            get
            {
                return (B3 == Position.Vertical ? (A775 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A775 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I776
        {
            get
            {
                return (B3 == Position.Vertical ? (A776 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A776 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I777
        {
            get
            {
                return (B3 == Position.Vertical ? (A777 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A777 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I778
        {
            get
            {
                return (B3 == Position.Vertical ? (A778 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A778 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I779
        {
            get
            {
                return (B3 == Position.Vertical ? (A779 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A779 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I780
        {
            get
            {
                return (B3 == Position.Vertical ? (A780 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A780 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I781
        {
            get
            {
                return (B3 == Position.Vertical ? (A781 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A781 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I782
        {
            get
            {
                return (B3 == Position.Vertical ? (A782 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A782 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I783
        {
            get
            {
                return (B3 == Position.Vertical ? (A783 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A783 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I784
        {
            get
            {
                return (B3 == Position.Vertical ? (A784 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A784 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I785
        {
            get
            {
                return (B3 == Position.Vertical ? (A785 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A785 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I786
        {
            get
            {
                return (B3 == Position.Vertical ? (A786 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A786 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I787
        {
            get
            {
                return (B3 == Position.Vertical ? (A787 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A787 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I788
        {
            get
            {
                return (B3 == Position.Vertical ? (A788 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A788 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I789
        {
            get
            {
                return (B3 == Position.Vertical ? (A789 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A789 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I790
        {
            get
            {
                return (B3 == Position.Vertical ? (A790 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A790 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I791
        {
            get
            {
                return (B3 == Position.Vertical ? (A791 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A791 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I792
        {
            get
            {
                return (B3 == Position.Vertical ? (A792 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A792 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I793
        {
            get
            {
                return (B3 == Position.Vertical ? (A793 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A793 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I794
        {
            get
            {
                return (B3 == Position.Vertical ? (A794 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A794 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I795
        {
            get
            {
                return (B3 == Position.Vertical ? (A795 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A795 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I796
        {
            get
            {
                return (B3 == Position.Vertical ? (A796 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A796 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I797
        {
            get
            {
                return (B3 == Position.Vertical ? (A797 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A797 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I798
        {
            get
            {
                return (B3 == Position.Vertical ? (A798 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A798 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I799
        {
            get
            {
                return (B3 == Position.Vertical ? (A799 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A799 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I800
        {
            get
            {
                return (B3 == Position.Vertical ? (A800 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A800 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I801
        {
            get
            {
                return (B3 == Position.Vertical ? (A801 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A801 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I802
        {
            get
            {
                return (B3 == Position.Vertical ? (A802 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A802 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I803
        {
            get
            {
                return (B3 == Position.Vertical ? (A803 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A803 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I804
        {
            get
            {
                return (B3 == Position.Vertical ? (A804 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A804 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I805
        {
            get
            {
                return (B3 == Position.Vertical ? (A805 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A805 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I806
        {
            get
            {
                return (B3 == Position.Vertical ? (A806 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A806 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }
        public double I807
        {
            get
            {
                return (B3 == Position.Vertical ? (A807 < B576 ? 0 : 1) : Math.Min(1, Math.Pow((A807 / 304800), 2) * (1488 * 32.2 * (E33 - E20)) / (18 * E39) / B571 * H8 / B588));
            }
        }

        public double J607
        {
            get
            {
                return F607 * (1 - I607);
            }
        }
        public double J608
        {
            get
            {
                return F608 * (1 - I608);
            }
        }
        public double J609
        {
            get
            {
                return F609 * (1 - I609);
            }
        }
        public double J610
        {
            get
            {
                return F610 * (1 - I610);
            }
        }
        public double J611
        {
            get
            {
                return F611 * (1 - I611);
            }
        }
        public double J612
        {
            get
            {
                return F612 * (1 - I612);
            }
        }
        public double J613
        {
            get
            {
                return F613 * (1 - I613);
            }
        }
        public double J614
        {
            get
            {
                return F614 * (1 - I614);
            }
        }
        public double J615
        {
            get
            {
                return F615 * (1 - I615);
            }
        }
        public double J616
        {
            get
            {
                return F616 * (1 - I616);
            }
        }
        public double J617
        {
            get
            {
                return F617 * (1 - I617);
            }
        }
        public double J618
        {
            get
            {
                return F618 * (1 - I618);
            }
        }
        public double J619
        {
            get
            {
                return F619 * (1 - I619);
            }
        }
        public double J620
        {
            get
            {
                return F620 * (1 - I620);
            }
        }
        public double J621
        {
            get
            {
                return F621 * (1 - I621);
            }
        }
        public double J622
        {
            get
            {
                return F622 * (1 - I622);
            }
        }
        public double J623
        {
            get
            {
                return F623 * (1 - I623);
            }
        }
        public double J624
        {
            get
            {
                return F624 * (1 - I624);
            }
        }
        public double J625
        {
            get
            {
                return F625 * (1 - I625);
            }
        }
        public double J626
        {
            get
            {
                return F626 * (1 - I626);
            }
        }
        public double J627
        {
            get
            {
                return F627 * (1 - I627);
            }
        }
        public double J628
        {
            get
            {
                return F628 * (1 - I628);
            }
        }
        public double J629
        {
            get
            {
                return F629 * (1 - I629);
            }
        }
        public double J630
        {
            get
            {
                return F630 * (1 - I630);
            }
        }
        public double J631
        {
            get
            {
                return F631 * (1 - I631);
            }
        }
        public double J632
        {
            get
            {
                return F632 * (1 - I632);
            }
        }
        public double J633
        {
            get
            {
                return F633 * (1 - I633);
            }
        }
        public double J634
        {
            get
            {
                return F634 * (1 - I634);
            }
        }
        public double J635
        {
            get
            {
                return F635 * (1 - I635);
            }
        }
        public double J636
        {
            get
            {
                return F636 * (1 - I636);
            }
        }
        public double J637
        {
            get
            {
                return F637 * (1 - I637);
            }
        }
        public double J638
        {
            get
            {
                return F638 * (1 - I638);
            }
        }
        public double J639
        {
            get
            {
                return F639 * (1 - I639);
            }
        }
        public double J640
        {
            get
            {
                return F640 * (1 - I640);
            }
        }
        public double J641
        {
            get
            {
                return F641 * (1 - I641);
            }
        }
        public double J642
        {
            get
            {
                return F642 * (1 - I642);
            }
        }
        public double J643
        {
            get
            {
                return F643 * (1 - I643);
            }
        }
        public double J644
        {
            get
            {
                return F644 * (1 - I644);
            }
        }
        public double J645
        {
            get
            {
                return F645 * (1 - I645);
            }
        }
        public double J646
        {
            get
            {
                return F646 * (1 - I646);
            }
        }
        public double J647
        {
            get
            {
                return F647 * (1 - I647);
            }
        }
        public double J648
        {
            get
            {
                return F648 * (1 - I648);
            }
        }
        public double J649
        {
            get
            {
                return F649 * (1 - I649);
            }
        }
        public double J650
        {
            get
            {
                return F650 * (1 - I650);
            }
        }
        public double J651
        {
            get
            {
                return F651 * (1 - I651);
            }
        }
        public double J652
        {
            get
            {
                return F652 * (1 - I652);
            }
        }
        public double J653
        {
            get
            {
                return F653 * (1 - I653);
            }
        }
        public double J654
        {
            get
            {
                return F654 * (1 - I654);
            }
        }
        public double J655
        {
            get
            {
                return F655 * (1 - I655);
            }
        }
        public double J656
        {
            get
            {
                return F656 * (1 - I656);
            }
        }
        public double J657
        {
            get
            {
                return F657 * (1 - I657);
            }
        }
        public double J658
        {
            get
            {
                return F658 * (1 - I658);
            }
        }
        public double J659
        {
            get
            {
                return F659 * (1 - I659);
            }
        }
        public double J660
        {
            get
            {
                return F660 * (1 - I660);
            }
        }
        public double J661
        {
            get
            {
                return F661 * (1 - I661);
            }
        }
        public double J662
        {
            get
            {
                return F662 * (1 - I662);
            }
        }
        public double J663
        {
            get
            {
                return F663 * (1 - I663);
            }
        }
        public double J664
        {
            get
            {
                return F664 * (1 - I664);
            }
        }
        public double J665
        {
            get
            {
                return F665 * (1 - I665);
            }
        }
        public double J666
        {
            get
            {
                return F666 * (1 - I666);
            }
        }
        public double J667
        {
            get
            {
                return F667 * (1 - I667);
            }
        }
        public double J668
        {
            get
            {
                return F668 * (1 - I668);
            }
        }
        public double J669
        {
            get
            {
                return F669 * (1 - I669);
            }
        }
        public double J670
        {
            get
            {
                return F670 * (1 - I670);
            }
        }
        public double J671
        {
            get
            {
                return F671 * (1 - I671);
            }
        }
        public double J672
        {
            get
            {
                return F672 * (1 - I672);
            }
        }
        public double J673
        {
            get
            {
                return F673 * (1 - I673);
            }
        }
        public double J674
        {
            get
            {
                return F674 * (1 - I674);
            }
        }
        public double J675
        {
            get
            {
                return F675 * (1 - I675);
            }
        }
        public double J676
        {
            get
            {
                return F676 * (1 - I676);
            }
        }
        public double J677
        {
            get
            {
                return F677 * (1 - I677);
            }
        }
        public double J678
        {
            get
            {
                return F678 * (1 - I678);
            }
        }
        public double J679
        {
            get
            {
                return F679 * (1 - I679);
            }
        }
        public double J680
        {
            get
            {
                return F680 * (1 - I680);
            }
        }
        public double J681
        {
            get
            {
                return F681 * (1 - I681);
            }
        }
        public double J682
        {
            get
            {
                return F682 * (1 - I682);
            }
        }
        public double J683
        {
            get
            {
                return F683 * (1 - I683);
            }
        }
        public double J684
        {
            get
            {
                return F684 * (1 - I684);
            }
        }
        public double J685
        {
            get
            {
                return F685 * (1 - I685);
            }
        }
        public double J686
        {
            get
            {
                return F686 * (1 - I686);
            }
        }
        public double J687
        {
            get
            {
                return F687 * (1 - I687);
            }
        }
        public double J688
        {
            get
            {
                return F688 * (1 - I688);
            }
        }
        public double J689
        {
            get
            {
                return F689 * (1 - I689);
            }
        }
        public double J690
        {
            get
            {
                return F690 * (1 - I690);
            }
        }
        public double J691
        {
            get
            {
                return F691 * (1 - I691);
            }
        }
        public double J692
        {
            get
            {
                return F692 * (1 - I692);
            }
        }
        public double J693
        {
            get
            {
                return F693 * (1 - I693);
            }
        }
        public double J694
        {
            get
            {
                return F694 * (1 - I694);
            }
        }
        public double J695
        {
            get
            {
                return F695 * (1 - I695);
            }
        }
        public double J696
        {
            get
            {
                return F696 * (1 - I696);
            }
        }
        public double J697
        {
            get
            {
                return F697 * (1 - I697);
            }
        }
        public double J698
        {
            get
            {
                return F698 * (1 - I698);
            }
        }
        public double J699
        {
            get
            {
                return F699 * (1 - I699);
            }
        }
        public double J700
        {
            get
            {
                return F700 * (1 - I700);
            }
        }
        public double J701
        {
            get
            {
                return F701 * (1 - I701);
            }
        }
        public double J702
        {
            get
            {
                return F702 * (1 - I702);
            }
        }
        public double J703
        {
            get
            {
                return F703 * (1 - I703);
            }
        }
        public double J704
        {
            get
            {
                return F704 * (1 - I704);
            }
        }
        public double J705
        {
            get
            {
                return F705 * (1 - I705);
            }
        }
        public double J706
        {
            get
            {
                return F706 * (1 - I706);
            }
        }
        public double J707
        {
            get
            {
                return F707 * (1 - I707);
            }
        }
        public double J708
        {
            get
            {
                return F708 * (1 - I708);
            }
        }
        public double J709
        {
            get
            {
                return F709 * (1 - I709);
            }
        }
        public double J710
        {
            get
            {
                return F710 * (1 - I710);
            }
        }
        public double J711
        {
            get
            {
                return F711 * (1 - I711);
            }
        }
        public double J712
        {
            get
            {
                return F712 * (1 - I712);
            }
        }
        public double J713
        {
            get
            {
                return F713 * (1 - I713);
            }
        }
        public double J714
        {
            get
            {
                return F714 * (1 - I714);
            }
        }
        public double J715
        {
            get
            {
                return F715 * (1 - I715);
            }
        }
        public double J716
        {
            get
            {
                return F716 * (1 - I716);
            }
        }
        public double J717
        {
            get
            {
                return F717 * (1 - I717);
            }
        }
        public double J718
        {
            get
            {
                return F718 * (1 - I718);
            }
        }
        public double J719
        {
            get
            {
                return F719 * (1 - I719);
            }
        }
        public double J720
        {
            get
            {
                return F720 * (1 - I720);
            }
        }
        public double J721
        {
            get
            {
                return F721 * (1 - I721);
            }
        }
        public double J722
        {
            get
            {
                return F722 * (1 - I722);
            }
        }
        public double J723
        {
            get
            {
                return F723 * (1 - I723);
            }
        }
        public double J724
        {
            get
            {
                return F724 * (1 - I724);
            }
        }
        public double J725
        {
            get
            {
                return F725 * (1 - I725);
            }
        }
        public double J726
        {
            get
            {
                return F726 * (1 - I726);
            }
        }
        public double J727
        {
            get
            {
                return F727 * (1 - I727);
            }
        }
        public double J728
        {
            get
            {
                return F728 * (1 - I728);
            }
        }
        public double J729
        {
            get
            {
                return F729 * (1 - I729);
            }
        }
        public double J730
        {
            get
            {
                return F730 * (1 - I730);
            }
        }
        public double J731
        {
            get
            {
                return F731 * (1 - I731);
            }
        }
        public double J732
        {
            get
            {
                return F732 * (1 - I732);
            }
        }
        public double J733
        {
            get
            {
                return F733 * (1 - I733);
            }
        }
        public double J734
        {
            get
            {
                return F734 * (1 - I734);
            }
        }
        public double J735
        {
            get
            {
                return F735 * (1 - I735);
            }
        }
        public double J736
        {
            get
            {
                return F736 * (1 - I736);
            }
        }
        public double J737
        {
            get
            {
                return F737 * (1 - I737);
            }
        }
        public double J738
        {
            get
            {
                return F738 * (1 - I738);
            }
        }
        public double J739
        {
            get
            {
                return F739 * (1 - I739);
            }
        }
        public double J740
        {
            get
            {
                return F740 * (1 - I740);
            }
        }
        public double J741
        {
            get
            {
                return F741 * (1 - I741);
            }
        }
        public double J742
        {
            get
            {
                return F742 * (1 - I742);
            }
        }
        public double J743
        {
            get
            {
                return F743 * (1 - I743);
            }
        }
        public double J744
        {
            get
            {
                return F744 * (1 - I744);
            }
        }
        public double J745
        {
            get
            {
                return F745 * (1 - I745);
            }
        }
        public double J746
        {
            get
            {
                return F746 * (1 - I746);
            }
        }
        public double J747
        {
            get
            {
                return F747 * (1 - I747);
            }
        }
        public double J748
        {
            get
            {
                return F748 * (1 - I748);
            }
        }
        public double J749
        {
            get
            {
                return F749 * (1 - I749);
            }
        }
        public double J750
        {
            get
            {
                return F750 * (1 - I750);
            }
        }
        public double J751
        {
            get
            {
                return F751 * (1 - I751);
            }
        }
        public double J752
        {
            get
            {
                return F752 * (1 - I752);
            }
        }
        public double J753
        {
            get
            {
                return F753 * (1 - I753);
            }
        }
        public double J754
        {
            get
            {
                return F754 * (1 - I754);
            }
        }
        public double J755
        {
            get
            {
                return F755 * (1 - I755);
            }
        }
        public double J756
        {
            get
            {
                return F756 * (1 - I756);
            }
        }
        public double J757
        {
            get
            {
                return F757 * (1 - I757);
            }
        }
        public double J758
        {
            get
            {
                return F758 * (1 - I758);
            }
        }
        public double J759
        {
            get
            {
                return F759 * (1 - I759);
            }
        }
        public double J760
        {
            get
            {
                return F760 * (1 - I760);
            }
        }
        public double J761
        {
            get
            {
                return F761 * (1 - I761);
            }
        }
        public double J762
        {
            get
            {
                return F762 * (1 - I762);
            }
        }
        public double J763
        {
            get
            {
                return F763 * (1 - I763);
            }
        }
        public double J764
        {
            get
            {
                return F764 * (1 - I764);
            }
        }
        public double J765
        {
            get
            {
                return F765 * (1 - I765);
            }
        }
        public double J766
        {
            get
            {
                return F766 * (1 - I766);
            }
        }
        public double J767
        {
            get
            {
                return F767 * (1 - I767);
            }
        }
        public double J768
        {
            get
            {
                return F768 * (1 - I768);
            }
        }
        public double J769
        {
            get
            {
                return F769 * (1 - I769);
            }
        }
        public double J770
        {
            get
            {
                return F770 * (1 - I770);
            }
        }
        public double J771
        {
            get
            {
                return F771 * (1 - I771);
            }
        }
        public double J772
        {
            get
            {
                return F772 * (1 - I772);
            }
        }
        public double J773
        {
            get
            {
                return F773 * (1 - I773);
            }
        }
        public double J774
        {
            get
            {
                return F774 * (1 - I774);
            }
        }
        public double J775
        {
            get
            {
                return F775 * (1 - I775);
            }
        }
        public double J776
        {
            get
            {
                return F776 * (1 - I776);
            }
        }
        public double J777
        {
            get
            {
                return F777 * (1 - I777);
            }
        }
        public double J778
        {
            get
            {
                return F778 * (1 - I778);
            }
        }
        public double J779
        {
            get
            {
                return F779 * (1 - I779);
            }
        }
        public double J780
        {
            get
            {
                return F780 * (1 - I780);
            }
        }
        public double J781
        {
            get
            {
                return F781 * (1 - I781);
            }
        }
        public double J782
        {
            get
            {
                return F782 * (1 - I782);
            }
        }
        public double J783
        {
            get
            {
                return F783 * (1 - I783);
            }
        }
        public double J784
        {
            get
            {
                return F784 * (1 - I784);
            }
        }
        public double J785
        {
            get
            {
                return F785 * (1 - I785);
            }
        }
        public double J786
        {
            get
            {
                return F786 * (1 - I786);
            }
        }
        public double J787
        {
            get
            {
                return F787 * (1 - I787);
            }
        }
        public double J788
        {
            get
            {
                return F788 * (1 - I788);
            }
        }
        public double J789
        {
            get
            {
                return F789 * (1 - I789);
            }
        }
        public double J790
        {
            get
            {
                return F790 * (1 - I790);
            }
        }
        public double J791
        {
            get
            {
                return F791 * (1 - I791);
            }
        }
        public double J792
        {
            get
            {
                return F792 * (1 - I792);
            }
        }
        public double J793
        {
            get
            {
                return F793 * (1 - I793);
            }
        }
        public double J794
        {
            get
            {
                return F794 * (1 - I794);
            }
        }
        public double J795
        {
            get
            {
                return F795 * (1 - I795);
            }
        }
        public double J796
        {
            get
            {
                return F796 * (1 - I796);
            }
        }
        public double J797
        {
            get
            {
                return F797 * (1 - I797);
            }
        }
        public double J798
        {
            get
            {
                return F798 * (1 - I798);
            }
        }
        public double J799
        {
            get
            {
                return F799 * (1 - I799);
            }
        }
        public double J800
        {
            get
            {
                return F800 * (1 - I800);
            }
        }
        public double J801
        {
            get
            {
                return F801 * (1 - I801);
            }
        }
        public double J802
        {
            get
            {
                return F802 * (1 - I802);
            }
        }
        public double J803
        {
            get
            {
                return F803 * (1 - I803);
            }
        }
        public double J804
        {
            get
            {
                return F804 * (1 - I804);
            }
        }
        public double J805
        {
            get
            {
                return F805 * (1 - I805);
            }
        }
        public double J806
        {
            get
            {
                return F806 * (1 - I806);
            }
        }
        public double J807
        {
            get
            {
                return F807 * (1 - I807);
            }
        }
        public double J808
        {
            get
            {
                return J607 + J608 + J609 + J610 + J611 + J612 + J613 + J614 + J615 + J616 + J617 + J618 + J619 + J620 + J621 + J622 + J623 + J624 + J625 + J626 + J627 + J628 + J629 + J630 + J631 + J632 + J633 + J634 + J635 + J636 + J637 + J638 + J639 + J640 + J641 + J642 + J643 + J644 + J645 + J646 + J647 + J648 + J649 + J650 + J651 + J652 + J653 + J654 + J655 + J656 + J657 + J658 + J659 + J660 + J661 + J662 + J663 + J664 + J665 + J666 + J667 + J668 + J669 + J670 + J671 + J672 + J673 + J674 + J675 + J676 + J677 + J678 + J679 + J680 + J681 + J682 + J683 + J684 + J685 + J686 + J687 + J688 + J689 + J690 + J691 + J692 + J693 + J694 + J695 + J696 + J697 + J698 + J699 + J700 + J701 + J702 + J703 + J704 + J705 + J706 + J707 + J708 + J709 + J710 + J711 + J712 + J713 + J714 + J715 + J716 + J717 + J718 + J719 + J720 + J721 + J722 + J723 + J724 + J725 + J726 + J727 + J728 + J729 + J730 + J731 + J732 + J733 + J734 + J735 + J736 + J737 + J738 + J739 + J740 + J741 + J742 + J743 + J744 + J745 + J746 + J747 + J748 + J749 + J750 + J751 + J752 + J753 + J754 + J755 + J756 + J757 + J758 + J759 + J760 + J761 + J762 + J763 + J764 + J765 + J766 + J767 + J768 + J769 + J770 + J771 + J772 + J773 + J774 + J775 + J776 + J777 + J778 + J779 + J780 + J781 + J782 + J783 + J784 + J785 + J786 + J787 + J788 + J789 + J790 + J791 + J792 + J793 + J794 + J795 + J796 + J797 + J798 + J799 + J800 + J801 + J802 + J803 + J804 + J805 + J806 + J807;
            }
        }

        #endregion J808
        
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
    }
}
