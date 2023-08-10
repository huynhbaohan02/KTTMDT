<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="QLDonHang.aspx.cs" Inherits="OnlineShop.QLDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container-fluid px-4">
		<h1 class="mt-4">Quản lý đơn hàng</h1>
        <hr />            
		<asp:GridView ID="ListDonHang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
			<AlternatingRowStyle BackColor="White" />
			<Columns>
				<asp:TemplateField HeaderText="ID">
					<ItemTemplate>
						<asp:Label ID="Label1" runat="server" Text='<%# Eval("OrderId") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Tên Khách Hàng">
					<ItemTemplate>
						<asp:Label ID="Label2" runat="server" Text='<%# Eval("NameUser") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Tên Sản Phẩm">
					<ItemTemplate>
						<asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Hình ảnh">
					<ItemTemplate>
						<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImagePath") %>' Width="65px"/>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Số Lượng">
					<ItemTemplate>
						<asp:Label ID="Label4" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Trạng Thái">
					<ItemTemplate>
						<asp:Label ID="Label5" runat="server" Text='<%# Eval("StatusOrder") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Địa chỉ">
					<ItemTemplate>
						<asp:Label ID="Label6" runat="server" Text='<%# Eval("AddressDetail")+", "+Eval("Wards")+", "+Eval("District")+", "+Eval("Province") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Số Điện Thoại">
					<ItemTemplate>
						<asp:Label ID="Label7" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Ngày Đặt Hàng">
					<ItemTemplate>
						<asp:Label ID="Label8" runat="server" Text='<%# Eval("OrderDate") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField >
					<ItemTemplate>
						<asp:LinkButton CssClass="btn-user" ID="suaDonHang" runat="server" CommandArgument='<%# Eval("OrderId") %>' OnClick="suaDonHang_Click">Sửa</asp:LinkButton>
					</ItemTemplate>
				</asp:TemplateField>
			</Columns>
			<EditRowStyle BackColor="#7C6F57" />
			<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
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
