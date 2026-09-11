using System;
using System.Web;

namespace LeaveMgmtApp
{
    public partial class LeaveForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Pre-fill name from cookie, if it exists
                HttpCookie savedNameCookie = Request.Cookies["StaffNameCookie"];
                if (savedNameCookie != null)
                {
                    txtStaffName.Text = savedNameCookie.Value;
                }

                // Pull the date picked on the calendar page from Session
                object sessionDate = Session["ChosenLeaveDate"];
                if (sessionDate != null)
                {
                    lblChosenDate.Text = ((DateTime)sessionDate).ToString("dd-MM-yyyy");
                }
                else
                {
                    lblChosenDate.Text = "No date was picked on the calendar";
                }
            }
        }

        protected void btnSubmitLeave_Click(object sender, EventArgs e)
        {
            string staffName = txtStaffName.Text;
            string leaveCategory = ddlLeaveCategory.SelectedValue;
            string reasonText = txtLeaveReason.Text;

            // Keep the submitted details available in Session for this visit
            Session["SubmittedStaffName"] = staffName;
            Session["SubmittedLeaveType"] = leaveCategory;
            Session["SubmittedReason"] = reasonText;

            // Only create the cookie when the user opts in
            if (chkSaveName.Checked)
            {
                HttpCookie nameCookie = new HttpCookie("StaffNameCookie", staffName);
                nameCookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(nameCookie);
            }

            lblResult.Text = "<b>Your leave request has been recorded.</b><br/><br/>" +
                              "Name: " + staffName + "<br/>" +
                              "Type: " + leaveCategory + "<br/>" +
                              "Reason: " + reasonText;
        }
    }
}