<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalendarPage.aspx.cs" Inherits="LeaveMgmtApp.CalendarPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Institute Calendar</title>
    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            background-color: #eef1f5;
            margin: 0;
        }

        .wrapper {
            width: 480px;
            margin: 60px auto;
            background: #ffffff;
            padding: 28px;
            border-radius: 12px;
            box-shadow: 0 3px 10px rgba(0,0,0,0.12);
            text-align: center;
        }

        .heading {
            font-size: 24px;
            font-weight: 700;
            color: #2c2c2c;
            margin-bottom: 22px;
            letter-spacing: 1px;
        }

        .dateInfo {
            font-size: 15px;
            font-weight: 600;
            color: #2c2c2c;
            margin: 18px 0;
            display: block;
        }

        .actionBtn {
            background-color: #1f2f98;
            color: #fff;
            border: none;
            padding: 9px 22px;
            border-radius: 6px;
            font-size: 14px;
            cursor: pointer;
        }

            .actionBtn:hover {
                background-color: #16216e;
            }
    </style>
</head>
<body>
    <form id="frmCalendar" runat="server">
        <div class="wrapper">
            <div class="heading">INSTITUTE CALENDAR</div>

            <asp:Calendar ID="calInstitute" runat="server"
                BackColor="White"
                BorderColor="#888888"
                BorderStyle="Solid"
                CellSpacing="2"
                Font-Names="Segoe UI"
                Font-Size="9pt"
                ForeColor="#333333"
                Height="240px"
                Width="320px"
                OnSelectionChanged="calInstitute_SelectionChanged">

                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#444444" />
                <DayStyle BackColor="#e3e3e3" />
                <NextPrevStyle Font-Bold="True" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#aaaaaa" />
                <SelectedDayStyle BackColor="#1f2f98" ForeColor="White" />
                <TitleStyle BackColor="#1f2f98" Font-Bold="True" Font-Size="11pt" ForeColor="White" />
                <TodayDayStyle BackColor="#777777" ForeColor="White" />
            </asp:Calendar>

            <asp:Label ID="lblPickedDate" runat="server"
                Text="No date chosen yet"
                CssClass="dateInfo">
            </asp:Label>

            <asp:Button ID="btnGoToLeaveForm" runat="server"
                Text="Proceed to Leave Form"
                CssClass="actionBtn"
                OnClick="btnGoToLeaveForm_Click" />
        </div>
    </form>
</body>
</html>