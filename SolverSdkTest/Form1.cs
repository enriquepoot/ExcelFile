using SolverPlatform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolverSdkTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var sepsize = new SeparatorSizing();

                sepsize.H7 = 9;
                sepsize.H8 = 9;

                Minimize(sepsize);

                //var val = sepsize.H21;
                //var h24 = sepsize.H24;
                //var B533 = sepsize.B533;
                //var j441 = sepsize.J441;
                //var m441 = sepsize.M441;
                //var q441 = sepsize.Q441;
                //var t441 = sepsize.T441;
                //var w441 = sepsize.W441;
                //var z441 = sepsize.Z441;
                //var s = sepsize.J808;

                var r = 9;
            }
            catch (Exception ex)
            {
                var f = ex;
            }

            #region Test
            //try
            //{
            //    int nvars = 2, nfcns = 2;

            //    double[] correl = new double[] { 1.0, 0.5, 0.5, 1.0 };

            //    using (Problem prob = new Problem(Solver_Type.Simulate, nvars, nfcns))
            //    {
            //        prob.Model.VarDistribution[0] = new Distribution("PsiUniform(0,2)");
            //        prob.Model.VarDistribution[1] = new Distribution("PsiNormal(1,1)");

            //        prob.Model.DistCorrelations = new DoubleMatrix(Array_Order.ByRow, nvars, nvars, correl);

            //        prob.Evaluators[Eval_Type.Sample].OnEvaluate += Form1_OnEvaluate;

            //        prob.Solver.Simulate();

            //        Debug.WriteLine("Simulation Example 1");
            //        Debug.WriteLine("Status = " + prob.Solver.SimulateStatus);

            //        Debug.WriteLine("\r\nStatistics on Uncertain Variables");

            //        for (int i = 0; i < nvars; i++)
            //        {
            //            Debug.WriteLine("\r\nVariable " + i + "\r\n");
            //            Debug.WriteLine("Minimum = " + 
            //            prob.VarUncertain.Statistics.Minimum[i]);
            //            Debug.WriteLine("Maximum = " +
            //            prob.VarUncertain.Statistics.Maximum[i]);
            //            Debug.WriteLine("Mean = " +
            //            prob.VarUncertain.Statistics.Mean[i]);
            //            Debug.WriteLine("StdDev = " +
            //            prob.VarUncertain.Statistics.StdDev[i]);
            //            Debug.WriteLine("Variance = " +
            //            prob.VarUncertain.Statistics.Variance[i]);
            //            Debug.WriteLine("Skewness = " +
            //            prob.VarUncertain.Statistics.Skewness[i]);
            //            Debug.WriteLine("Kurtosis = " +
            //            prob.VarUncertain.Statistics.Kurtosis[i]);
            //            Debug.WriteLine("10th Percentile = " +
            //            prob.VarUncertain.Percentiles[i, 10]);
            //            Debug.WriteLine("90th Percentile = " +
            //            prob.VarUncertain.Percentiles[i, 90]);
            //        }

            //        Debug.WriteLine("\r\nStatistics on Uncertain Functions");
            //        for (int i = 0; i < nfcns; i++)
            //        {
            //            Debug.WriteLine("\r\nFunction " + i);
            //            Debug.WriteLine("Minimum = " +
            //            prob.FcnUncertain.Statistics.Minimum[i]);
            //            Debug.WriteLine("Maximum = " +
            //            prob.FcnUncertain.Statistics.Maximum[i]);
            //            Debug.WriteLine("Mean = " +
            //            prob.FcnUncertain.Statistics.Mean[i]);
            //            Debug.WriteLine("StdDev = " +
            //            prob.FcnUncertain.Statistics.StdDev[i]);
            //            Debug.WriteLine("Variance = " +
            //            prob.FcnUncertain.Statistics.Variance[i]);
            //            Debug.WriteLine("Skewness = " +
            //            prob.FcnUncertain.Statistics.Skewness[i]);
            //            Debug.WriteLine("Kurtosis = " +
            //            prob.FcnUncertain.Statistics.Kurtosis[i]);
            //            Debug.WriteLine("10th Percentile = " +
            //            prob.FcnUncertain.Percentiles[i, 10]);
            //            Debug.WriteLine("90th Percentile = " +
            //            prob.FcnUncertain.Percentiles[i, 90]);
            //        }
            //    }
            //}
            //catch (SolverException ex)
            //{
            //    Debug.WriteLine("Exception " + ex.ExceptionType + "\r\n" +
            //    "Exception " + ex.Message,
            //    "SDK Exception Occurred");
            //}
            #endregion

        }

        Engine_Action Form1_OnEvaluate(Evaluator evaluator)
        {
            Problem p = evaluator.Problem;

            double[] pVar = p.VarUncertain.Value.Array;

            double[] pFcn = p.FcnUncertain.Value.Array;

            pFcn[0] = pVar[0] + pVar[1];
            pFcn[1] = pVar[0] * pVar[1];

            p.FcnUncertain.Value.Array = pFcn;

            return Engine_Action.Continue;
        }

        public void Minimize(SeparatorSizing original)
        {

            double[] ub_cons = { Constants.PINF, Constants.PINF, Constants.PINF, Constants.PINF, 1.5, Constants.PINF, Constants.PINF, 0, 0, Constants.PINF, Constants.PINF,
                               0, 0, 0, Constants.PINF, 0, Constants.PINF, 0, 0, 0, Constants.PINF};
            double[] lb_cons = { original.B48, original.B49, original.B50, original.B47, 0, original.B49, original.B50, Constants.MINF, Constants.MINF, 0, 0,
                               Constants.MINF, Constants.MINF, Constants.MINF, 0, Constants.MINF, 0, Constants.MINF, Constants.MINF, Constants.MINF, 0};

            double[] ub = { 20, 80 };
            double[] lb = { 2, 1.5 };
            var count = 0;
            using (Problem prob = new Problem(Solver_Type.Minimize, 2, 21))
            {
                prob.FcnConstraint.UpperBound.Array = ub_cons;
                prob.FcnConstraint.LowerBound.Array = ub_cons;

                //prob.VarDecision.NonNegative();
                prob.VarDecision.UpperBound.Array = ub;
                prob.VarDecision.LowerBound.Array = lb;

                prob.ProblemType = Problem_Type.OptNSP;
                prob.Engine = prob.Engines[Engine.EVOName];

                prob.Evaluators[Eval_Type.Function].OnEvaluate += (e) =>
                {
                    var h7 = e.Problem.VarDecision.Value[0];
                    var h8 = e.Problem.VarDecision.Value[1];

                    var sepSize = new SeparatorSizing();
                    sepSize.H7 = h7;
                    sepSize.H8 = h8;

                    e.Problem.FcnConstraint.Value[0] = sepSize.K73;
                    e.Problem.FcnConstraint.Value[1] = sepSize.I74;
                    e.Problem.FcnConstraint.Value[2] = sepSize.K72;
                    e.Problem.FcnConstraint.Value[3] = sepSize.I73;
                    e.Problem.FcnConstraint.Value[4] = sepSize.H9;
                    e.Problem.FcnConstraint.Value[5] = sepSize.I72;
                    e.Problem.FcnConstraint.Value[6] = sepSize.K74;
                    e.Problem.FcnConstraint.Value[7] = sepSize.H31;
                    e.Problem.FcnConstraint.Value[8] = sepSize.H42;
                    e.Problem.FcnConstraint.Value[9] = sepSize.H43;
                    e.Problem.FcnConstraint.Value[10] = sepSize.H44;
                    e.Problem.FcnConstraint.Value[11] = sepSize.H39;
                    e.Problem.FcnConstraint.Value[12] = sepSize.H38;
                    e.Problem.FcnConstraint.Value[13] = sepSize.H37;
                    e.Problem.FcnConstraint.Value[14] = sepSize.H35;
                    e.Problem.FcnConstraint.Value[15] = sepSize.H34;
                    e.Problem.FcnConstraint.Value[16] = sepSize.H32;
                    e.Problem.FcnConstraint.Value[17] = sepSize.H33;
                    e.Problem.FcnConstraint.Value[18] = sepSize.H29;
                    e.Problem.FcnConstraint.Value[19] = sepSize.H28;
                    e.Problem.FcnConstraint.Value[20] = sepSize.H30;

                    e.Problem.FcnObjective.Value[e.Problem.ObjectiveIndex] = sepSize.H21;
                    Console.WriteLine("Eval = " + e.Problem.Engine.Stat.FunctionEvals);
                    Console.WriteLine("Cont = " + count++);
                    Console.WriteLine("H7 = " + sepSize.H7);
                    Console.WriteLine("H8 = " + sepSize.H8);
                    Console.WriteLine("H21 = " + sepSize.H21);
                    return Engine_Action.Continue;
                };

                prob.Solver.Optimize();
                Optimize_Status status = prob.Solver.OptimizeStatus;

                Console.WriteLine("\r\nnonlinear_example");
                Console.WriteLine("Status = " + status);
                Console.WriteLine("x1 = " + prob.VarDecision.FinalValue[0]);
                Console.WriteLine("x2 = " + prob.VarDecision.FinalValue[1]);
                Console.WriteLine("Obj = " + prob.FcnObjective.FinalValue[0]);
            }
        }
    }
}
