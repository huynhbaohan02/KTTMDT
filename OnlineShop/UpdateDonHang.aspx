<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateDonHang.aspx.cs" Inherits="OnlineShop.UpdateDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
		<div class="modal-content">
				  <div class="modal-header">
					<h4 class="modal-title" id="myModal">Cập nhập đơn hàng</h4>
				  </div>
				  <div class="modal-body">
					  <div class="form-group">
						<label>Tên khách hàng</label>
						<asp:TextBox ID="name" runat="server"></asp:TextBox>
					</div>
					<div class="form-group">
						<label>Trạng thái đơn hàng</label>
						<asp:TextBox ID="status" runat="server"></asp:TextBox>
					</div>
					<div class="form-group">
						<label>Số điện thoại</label>
						<asp:TextBox ID="sdt" runat="server"></asp:TextBox>
					</div>
					<div class="form-group form-btn">
						<asp:Button ID="btnUpdateDonHang" runat="server" Text="Cập nhập" OnClick="btnUpdateDonHang_Click"/>
						<asp:Button ID="btnBack" runat="server" Text="Quay Lại" OnClick="btnBack_Click"/>
					</div>
					
				</div>
	</div>
</asp:Content>
