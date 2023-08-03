<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="OnlineShop.ShoppingCart" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
	<section id="cart_items">
		<div class="container">
			<div class="breadcrumbs">
				<ol class="breadcrumb">
				  <li class="active">Giỏ hàng</li>
				</ol>
			</div>
			<div class="table-responsive cart_info">
				<asp:GridView ID="GridView1" runat="server" ClientIDMode="Static" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting">
					<AlternatingRowStyle BackColor="White" />
					<Columns>
						<asp:TemplateField HeaderText="Tên Sản Phẩm">
							<ItemTemplate>
								<asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>    
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="Hình Ảnh">
							<ItemTemplate>
								<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImagePath") %>' />
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="Giá">
							<ItemTemplate>
								<asp:Label ID="Label2" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="Số lượng">
							<ItemTemplate>
								<asp:TextBox ID="txt_Sl" runat="server" Text='<%# Eval("Quantity") %>'></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="Tổng Giá">
							<ItemTemplate>
								<asp:Label ID="Label4" runat="server" Text='<%# Eval("PriceSum") %>'></asp:Label>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="" ShowHeader="False">
							<EditItemTemplate>
								&nbsp;
							</EditItemTemplate>
							<ItemTemplate>
								<asp:LinkButton ID="btn_Sua" runat="server" CommandArgument='<%# Eval("ProductId") %>' onClick="btn_Sua_Click">Chỉnh Sửa</asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:TemplateField HeaderText="" ShowHeader="False">
							<ItemTemplate>
								<asp:LinkButton ID="lbDelete" runat="server" OnClientClick="return confirm('Bạn muốn xóa sản phẩm này khỏi giỏ hàng?')" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateField>
					</Columns>
					<EmptyDataTemplate>
						Chưa có sản phẩm nào
					</EmptyDataTemplate>
					<FooterStyle BackColor="#E48586" Font-Bold="True" ForeColor="White" />
					<HeaderStyle BackColor="#E48586" Font-Bold="True" ForeColor="White" />
					<PagerStyle BackColor="#FAF3F0" ForeColor="#333333" HorizontalAlign="Center" />
					<RowStyle BackColor="#FAF3F0" ForeColor="#333333" />
					<SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
					<SortedAscendingCellStyle BackColor="#FDF5AC" />
					<SortedAscendingHeaderStyle BackColor="#4D0000" />
					<SortedDescendingCellStyle BackColor="#FCF6C0" />
					<SortedDescendingHeaderStyle BackColor="#820000" />
				</asp:GridView>
				
			</div>
			<div class="thanh-toan">
				<asp:Label ID="tien" runat="server"></asp:Label>
				<asp:Button ID="thanhToan" runat="server" Text="Thanh Toán" OnClick="thanhToan_Click" />
			</div>		

		</div>
	</section>
</asp:Content>
