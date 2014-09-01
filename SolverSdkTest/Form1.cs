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
                //var gen = new Cellenator();
                //gen.GenJCells();

                var sepsize = new SeparatorSizing();

                sepsize.H7 = 6.11927343917312;
                sepsize.H8 = 2.83267005098296;

                var val = sepsize.H21;
                var h24 = sepsize.H24;
                var B533 = sepsize.B533;
                var s = sepsize.J808;

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
    }
}
