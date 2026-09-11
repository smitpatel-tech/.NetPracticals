using System;

namespace LeaveMgmtApp
{
    public partial class CalendarPage : System.Web.UI.Page
    {
        protected void calInstitute_SelectionChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = calInstitute.SelectedDate;

            lblPickedDate.Text = "You selected: " + chosenDate.ToString("dd-MM-yyyy");

            // Save the chosen date in the current user's session
            Session["ChosenLeaveDate"] = chosenDate;
        }

        protected void btnGoToLeaveForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveForm.aspx");
        }
    }
}