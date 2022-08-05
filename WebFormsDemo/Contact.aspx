<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebFormsDemo.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
    <h3>Tell us about yourself</h3>
    <div>
        <label>
            Name
        </label>
        <asp:TextBox runat="server" ID="txtName" CssClass="text-box"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="txtName" ErrorMessage="Required" Display="Dynamic"/>
    </div>
    <div>
        <label>
            Email
        </label>
        <asp:TextBox runat="server" ID="txtEmail" />
        <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtEmail" ErrorMessage="Valid email is required." Display="Dynamic"
            ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Required" Display="Dynamic"/>
    
    </div>
    <div>
        <label>
            Age
        </label>
        <asp:TextBox runat="server" ID="txtAge" />
        <asp:RequiredFieldValidator runat="server" ID="rfvAge" ControlToValidate="txtAge" ErrorMessage="Required" Display="Dynamic"/>

    </div>
    <div>
        <label>
            Favorite Color
        </label>
        <asp:DropDownList ID="ddlColor" runat="server">
            <asp:ListItem Text="Please Select a Value" Value=""/>
            <asp:ListItem Text="Blue" Value="Blue"/>
            <asp:ListItem Text="Green" Value="Green"/>
            <asp:ListItem Text="Red" Value="Red"/>
            <asp:ListItem Text="Yellow" Value="Yellow"/>
        </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" ID="rfvColor" ControlToValidate="ddlColor" ErrorMessage="Required" Display="Dynamic"/>

        <asp:Button Text="Submit" OnClick="btnClick_Submit" runat="server"/>
        <div class="message">
            <asp:Literal ID="ltlMessage" runat="server"/>
        </div>
    </div>
</asp:Content>
