<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineShop.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
    <div class="signup">
        <div class="container">
            <div class="row">
                <div class="col-lg-7 col-sm-12 col-md-12">
                    <div class="content">
                        <div>
                            <span class="title">Tạo Tài Khoản Mới</span>
                            <div class="item">
                                <p>Tên Người Dùng</p>
                                <asp:TextBox ID="username" runat="server" TextMode="SingleLine"></asp:TextBox>
                            </div>
                            <div class="item">
                                <p>Email</p>
                                <asp:TextBox ID="email" runat="server" TextMode="SingleLine"></asp:TextBox>
                            </div>
                            <div class="item">
                                <p>Mật Khẩu</p>
                                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mật khẩu phải được nhập"
                                    ControlToValidate="password" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                            <div class="item">
                                <p>Nhập Lại Mật Khẩu</p>
                                <asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu nhập lại không trùng khớp"
                                    ControlToValidate="password2" ControlToCompare="password" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                            </div>
                            <div class="login">
                                <span>Bạn chưa có tài khoản?</span>
                                <a href="/Login.aspx">Đăng Nhập</a>
                            </div>
                            <div class="item">
                                <asp:Label ID="kttxt" runat="server" Color="Red"></asp:Label>
                            </div>
                            <asp:Button ID="submit" runat="server" Text="Đăng Kí" OnClick="submit_Click" />
                        </div>
                    </div>
                </div>
                <div class="col-lg-5 col-sm-12 col-md-12">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/shop/register.jpg" CssClass="register-img" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
