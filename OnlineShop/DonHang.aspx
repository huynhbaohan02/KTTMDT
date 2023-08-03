<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="DonHang.aspx.cs" Inherits="OnlineShop.DonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
	<div class="container">
			<div class="row">
				<div class="col-lg-12" style="font-size: 20px; font-weight: 600; margin-bottom: 10px;">Đơn hàng của bạn</div>
				<div class="col-lg-12">
					<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
						<Columns>
							<asp:TemplateField HeaderText="Người Nhận">
								<ItemTemplate>
									<asp:Label ID="Label20" runat="server" Text='<%# Eval("NameUser") %>'></asp:Label>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="Sản Phẩm">
								<ItemTemplate>
									<asp:Label ID="Label2" runat="server" Text='<%# Eval("ProductName") %>' Width="250px"></asp:Label>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="Giá">
								<ItemTemplate>
									<asp:Label ID="Label3" runat="server" Text='<%# Eval("price") %>'></asp:Label>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="Hình Ảnh">
								<ItemTemplate>
									<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImagePath") %>' />
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
							<asp:TemplateField HeaderText="Số Điện Thoại">
								<ItemTemplate>
									<asp:Label ID="Label6" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="Địa chỉ">
								<ItemTemplate>
									<asp:Label ID="Label7" runat="server" Text='<%# Eval("AddressDetail")+", "+Eval("Wards")+", "+Eval("District")+", "+Eval("Province") %>'></asp:Label>
								</ItemTemplate>
							</asp:TemplateField>
						</Columns>
					</asp:GridView>
				</div>
			</div>
		</div>
</asp:Content>
