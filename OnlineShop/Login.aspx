<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineShop.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
	<div class="signup">
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-sm-12 col-md-12">
                <div class="login-img">
                </div>
            </div>
            <div class="col-lg-6 col-sm-12 col-md-12">
                <div class="content">
                    <span class="title">Đăng Nhập Tài Khoản</span>
                    <div>
                        <div class="item">
                            <p>Email</p>
							<asp:TextBox ID="email" runat="server" TextMode="SingleLine"></asp:TextBox>
                        </div>
                        <div class="item">
                            <p>Mật Khẩu</p>
							<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="item2">
                            <div class="remember">
                                <input class="check" type="checkbox" id="remember-password">
                                <label for="remember-password">Lưu tài khoản</label>
                            </div>
                            <a href="#">Quên mật khẩu?</a>
                        </div>
						<div class="item">
							<asp:Label ID="kttxt" runat="server" Color="Red"></asp:Label>
                        </div>
						<asp:Button ID="submit" runat="server" Text="Đăng Nhập" OnClick="submit_Click" />
                    </div>
                    <div class="login">
                        <span>Bạn chưa có tài khoản?</span>
                        <a href="/SignUp.aspx">Đăng kí</a>
                    </div>
                </div> 
            </div>
        </div>
    </div>
</div>
</asp:Content>
