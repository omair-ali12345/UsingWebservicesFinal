using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingWebservicesFinal
{
	public partial class QuadraticEquations : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            localhost1.QuadraticSolver quadraticSolver = new localhost1.QuadraticSolver();
        }
        protected void btnFormula_Click(object sender, EventArgs e)
		{
            // Get the values from the text boxes
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            // Call the web service method
            localhost1.QuadraticSolver quadraticSolver = new localhost1.QuadraticSolver();
            string result = quadraticSolver.SolveByFormula(a, b, c);
            // Display the result in the label
            lblResult.Text = result;

        }
        protected void btnSquare_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            // Call the web service method
            localhost1.QuadraticSolver quadraticSolver = new localhost1.QuadraticSolver();
            string result = quadraticSolver.SolveByCompletingSquare(a, b, c);
            // Display the result in the label
            lblResult.Text = result;
        }
        protected void btnFactor_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            // Call the web service method
            localhost1.QuadraticSolver quadraticSolver = new localhost1.QuadraticSolver();
            string result = quadraticSolver.SolveByFactoring(a, b, c);
            // Display the result in the label
            lblResult.Text = result;
        }
    }
}