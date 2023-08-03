<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="DetailProduct.aspx.cs" Inherits="OnlineShop.DetailProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
	<div class="container">
		<div class="row">
			<div class="col-sm-12">
					<div class="product-details">
						<div class="col-sm-5">
							<div class="view-product">
								<img src="<%= product.ImagePath %>" alt="">
							</div>
						</div>
						<div class="col-sm-7">
							<div class="product-information">
								<img src="images/product-details/new.jpg" class="newarrival" alt="">
								<h2><%= product.ProductName %></h2>
								<p><b>ID sản phẩm:</b> <%= product.ProductId %></p>
								<span>
									<span>Giá: <%= product.Price %> đ</span>
									<button type="button" class="btn btn-fefault cart">
										<i class="fa fa-shopping-cart"></i>
										<a href="/ShoppingCart.aspx?idProduct=<%= idProduct%>">Thêm vào giỏ hàng</a>
									</button>
								</span>
								<p><b>Đã bán:</b></p>
								<p><b>Tình trạng:</b> Mới</p>
								<p><b>Thương hiệu:</b> Shop Online</p>
								<p><b>Thông tin sản phẩm :</b></p>
								<p><%=product.Introduction %></p>
							</div>
						</div>
					</div>
				</div>
		</div>
	</div>
</asp:Content>
