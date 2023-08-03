<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateNguoiDung.aspx.cs" Inherits="OnlineShop.UpdateNguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
		<div class="modal-content">
				  <div class="modal-header">
					<h4 class="modal-title" id="myModal">Cập nhập người dùng</h4>
				  </div>
				  <div class="modal-body">
					<div class="form-group">
						<label>Quyền</label>
						<asp:DropDownList ID="ddRoles" runat="server">
							<asp:ListItem Value="1" Text="Người dùng"></asp:ListItem>
							<asp:ListItem Value="2" Text="Quản trị viên"></asp:ListItem>
						</asp:DropDownList>
					</div>
					<div class="form-group">
						<label>Tên đăng nhập</label>
						<asp:TextBox ID="username" runat="server"></asp:TextBox>
					</div>
					<div class="form-group">
						<label>Mật khẩu</label>
						<asp:TextBox ID="pasword" runat="server" TextMode="Password"></asp:TextBox>
					</div>
					  <div class="form-group">
						<label>Trạng thái</label>
						<asp:DropDownList ID="status" runat="server">
							<asp:ListItem Value="Mở" Text="Mở"></asp:ListItem>
							<asp:ListItem Value="Khóa" Text="Khóa"></asp:ListItem>
						</asp:DropDownList>
					</div>
					<div class="form-group">
						<asp:Label ID="kttxt" runat="server" Text=""></asp:Label>
					</div>
					<div class="form-group form-btn">
						<asp:Button ID="btnUpdateUser" runat="server" Text="Cập nhập" onClick="btnUpdateUser_Click"/>
						<asp:Button ID="btnBack" runat="server" Text="Quay Lại" OnClick="btnBack_Click"/>
					</div>
					
				</div>
	</div>
</asp:Content>
