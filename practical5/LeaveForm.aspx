<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveForm.aspx.cs" Inherits="LeaveMgmtApp.LeaveForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Leave Form</title>
    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            background-color: #eef1f5;
            margin: 0;
        }

        .card {
            width: 520px;
            margin: 45px auto;
            background: #fff;
            padding: 32px;
            border-radius: 12px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.12);
        }

        .heading {
            text-align: center;
            font-size: 26px;
            font-weight: 700;
            color: #2c2c2c;
            margin-bottom: 26px;
        }

        .row { margin-bottom: 20px; }

        .lbl {
            display: inline-block;
            width: 120px;
            font-weight: 600;
            color: #444;
            vertical-align: top;
        }

        .inputBox, .selectBox {
            padding: 9px;
            border: 1px solid #999;
            border-radius: 5px;
            width: 270px;
            font-family: inherit;
            font-size: 15px;
        }

        .pickedDate {
            font-weight: 700;
            color: #1f2f98;
        }

        .rememberRow { margin-left: 120px; font-size: 14px; }

        .submitBtn {
            background-color: #1f2f98;
            color: #fff;
            border: none;
            padding: 10px 26px;
            border-radius: 6px;
            font-weight: 700;
            cursor: pointer;
        }

            .submitBtn:hover { background-color: #16216e; }

        .resultBox {
            display: block;
            margin-top: 22px;
            padding: 16px;
            border-radius: 8px;
            background-color: #eaf7ec;
            color: #256029;
            text-align: center;
        }

            .resultBox:empty { display: none; }
    </style>
</head>
<body>
    <form id="frmLeave" runat="server">
        <div class="card">
            <div class="heading">STAFF LEAVE FORM</div>

            <div class="row">
                <asp:Label ID="lblNameCaption" runat="server" Text="Full Name:" CssClass="lbl" />
                <asp:TextBox ID="txtStaffName" runat="server" CssClass="inputBox" />
            </div>

            <div class="row">
                <asp:Label ID="lblDateCaption" runat="server" Text="Leave Date:" CssClass="lbl" />
                <asp:Label ID="lblChosenDate" runat="server" Text="" CssClass="pickedDate" />
            </div>

            <div class="row">
                <asp:Label ID="lblTypeCaption" runat="server" Text="Leave Type:" CssClass="lbl" />
                <asp:DropDownList ID="ddlLeaveCategory" runat="server" CssClass="selectBox">
                    <asp:ListItem>-- Choose Type --</asp:ListItem>
                    <asp:ListItem>Casual Leave</asp:ListItem>
                    <asp:ListItem>Sick Leave</asp:ListItem>
                    <asp:ListItem>Urgent Leave</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="row">
                <asp:Label ID="lblReasonCaption" runat="server" Text="Reason:" CssClass="lbl" />
                <asp:TextBox ID="txtLeaveReason" runat="server" CssClass="inputBox" TextMode="MultiLine" Rows="4" />
            </div>

            <div class="row">
                <asp:CheckBox ID="chkSaveName" runat="server" Text="Save my name for next time" CssClass="rememberRow" />
            </div>

            <div style="text-align:center;">
                <asp:Button ID="btnSubmitLeave" runat="server" Text="Submit Application"
                    CssClass="submitBtn" OnClick="btnSubmitLeave_Click" />
            </div>

            <asp:Label ID="lblResult" runat="server" CssClass="resultBox" />
        </div>
    </form>
</body>
</html>