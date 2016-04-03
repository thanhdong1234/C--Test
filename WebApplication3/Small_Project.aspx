<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Small_Project.aspx.cs" Inherits="WebApplication3.Small_Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="PartyStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <h1>New Year's Eve at Jacqui's</h1>
            <p>We are going to VietNamese</p>
        </div>

        <div><label>Your Name:</label><input type="text" id="name" runat="server" /></div>
        <br />
        <div><label>Your Email:</label><input type="text" id="email" runat="server" /></div>
        <br />
        <div><label>Your Phone:</label><input type="text" id="phone" runat="server" /></div>
        <br />
        <div>
            <label>Will you attend?</label>
            <select id="willattend" runat="server">
                <option value="">Choose options</option>
                <option value="true">true</option>
                <option value="false">false</option>
            </select>
        </div>
        <br />
        <div>
            <button type="submit">Submit RSVP</button>
        </div>
    </form>
</body>
</html>
