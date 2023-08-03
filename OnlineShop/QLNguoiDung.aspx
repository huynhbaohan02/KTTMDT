<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="QLNguoiDung.aspx.cs" Inherits="OnlineShop.Daoashbroad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid px-4">
		<h1 class="mt-4">Quản lý người dùng</h1>
        <hr />            
	</div>
	<div class="row container-fluid">
		<div class="col-lg-12">
			<a href="/AddNguoiDung.aspx" class="btn btn-primary">
			  Thêm người dùng
			</a>
			<br />
			<asp:GridView ID="listUser" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="listUser_RowDeleting">
				<AlternatingRowStyle BackColor="White" />
				<Columns>
					<asp:TemplateField HeaderText="Id Người Dùng">
						<ItemTemplate>
							<asp:Label ID="iduser" runat="server" Text='<%# Eval("UserId") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Quyền">
						<ItemTemplate>
							<asp:Label ID="Label1" runat="server" Text='<%# Eval("Quyen") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Họ Tên">
						<ItemTemplate>
							<asp:Label ID="Label2" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Email">
						<EditItemTemplate>
							<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
						</EditItemTemplate>
						<ItemTemplate>
							<asp:Label ID="Label3" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Ngày Tạo">
						<ItemTemplate>
							<asp:Label ID="Label50" runat="server" Text='<%# Eval("CreateDate") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Trạng Thái">
						<ItemTemplate>
							<asp:Label ID="Label5" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="Sửa">
						<ItemTemplate>
							<asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("UserId") %>' onClick="LinkButton1_Click">Sửa</asp:LinkButton>
						</ItemTemplate>
					</asp:TemplateField>
					<asp:TemplateField HeaderText="" ShowHeader="False">
							<ItemTemplate>
								<asp:LinkButton ID="lbDelete" runat="server" OnClientClick="return confirm('Bạn muốn xóa người dùng này?')" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateField>
				</Columns>
				<EditRowStyle BackColor="#7C6F57" />
				<FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
				<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
				<RowStyle BackColor="#E3EAEB" />
				<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
				<SortedAscendingCellStyle BackColor="#F8FAFA" />
				<SortedAscendingHeaderStyle BackColor="#246B61" />
				<SortedDescendingCellStyle BackColor="#D4DFE1" />
				<SortedDescendingHeaderStyle BackColor="#15524A" />
			</asp:GridView>
	</div>
</asp:Content>
