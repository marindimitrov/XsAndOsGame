<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="XsAndOsGame.aspx.cs"
    Inherits="XsAndOsGame.XsAndOsGame" 
    EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xs and Os Game</title>
    <link href="styles.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form" runat="server">
        <asp:Button ID="NewGame" runat="server" text="Start New Game" onclick="NewGame_Click"/>
        <div>
            <asp:ImageButton ID="ImgBtn1" runat="server" OnClick="ImgBtn1_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn2" runat="server" OnClick="ImgBtn2_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn3" runat="server" OnClick="ImgBtn3_Click" CssClass="button" />
        </div>
        <div>
            <asp:ImageButton ID="ImgBtn4" runat="server" OnClick="ImgBtn4_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn5" runat="server" OnClick="ImgBtn5_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn6" runat="server" OnClick="ImgBtn6_Click" CssClass="button" />
        </div>
        <div>
            <asp:ImageButton ID="ImgBtn7" runat="server" OnClick="ImgBtn7_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn8" runat="server" OnClick="ImgBtn8_Click" CssClass="button" />
            <asp:ImageButton ID="ImgBtn9" runat="server" OnClick="ImgBtn9_Click" CssClass="button" />
        </div>
        <asp:Label ID="Result" runat="server" CssClass="result" />
    </form>
</body>
</html>