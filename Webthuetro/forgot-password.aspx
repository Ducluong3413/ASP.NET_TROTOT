<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="Webthuetro.forgot_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/forgot-password.css" rel="stylesheet" />
    <div class="header-forgot-password-form">
        <div class="body-forgot-password-form">
            <div class="header-username">
                <label for="txtUsername">Tên đăng nhập :</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div class="header-password">
                <label for="txtNewPassword">Nhập mật khẩu mới:</label>
                <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox>
            </div>
            <div class="header-password-again">
                <label for="txtConfirmPassword">Xác nhận mật khẩu mới:</label>
                <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
            </div>
            <div class="header-btn-submit">
                <asp:Button ID="btnSubmit" CssClass="btnSubmit" runat="server" Text="Cập Nhật Mật Khẩu" OnClick="btnSubmit_Click" />
            </div>
        </div>
        </div>

</asp:Content>
