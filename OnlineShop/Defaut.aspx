<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Defaut.aspx.cs" Inherits="OnlineShop.Defaut" %>
<asp:Content ID="ContentDefault" ContentPlaceHolderID="phHome" runat="server">

	<section id="slider">
		<div class="container">
			<div class="row">
				<div class="col-sm-12">
					<div id="slider-carousel" class="carousel slide" data-ride="carousel">
						<ol class="carousel-indicators">
							<% for (int i = 0; i < arrList.Count(); i++)
							    { %>
								<li data-target="#slider-carousel" data-slide-to="<%= i %>"></li>
							<% } %>
						</ol>	
						<div class="carousel-inner">
							<% for (int i = 0; i < arrList.Count(); i++) { %>
							<div class="item">
								<div class="col-sm-6">
									<h1>Bo Cosmestic</h1>
									<p>Mua sắm trực tuyến hàng triệu sản phẩm ở nhiều hãng mỹ phẩm nỗi tiếng. Giá siêu hời và nhiều ưu đãi. Mua và bán online nhanh chóng trong 30 giây.</p>
									<button type="button" class="btn btn-default get">Get it now</button>
								</div>
								<div class="col-sm-6">
									<img src="<%= arrList[i].ImagePath1 %>" class="girl img-responsive" alt="" />
									
								</div>
							</div>
							<% } %>
							
						</div>
						
						<a href="#slider-carousel" class="left control-carousel hidden-xs" data-slide="prev">
							<i class="fa fa-angle-left"></i>
						</a>
						<a href="#slider-carousel" class="right control-carousel hidden-xs" data-slide="next">
							<i class="fa fa-angle-right"></i>
						</a>
					</div>
					
				</div>
			</div>
		</div>
	</section>

	<section>
		<div class="container">
			<div class="row">
				<div class="col-sm-3">
					<div class="left-sidebar">
						<h2>Danh Mục</h2>
						<div class="brands_products">
							<div class="brands-name">
								<asp:DataList ID="DataList1" runat="server">
									<ItemTemplate>
										<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("Icon") %>' />
										<br/>
										<asp:LinkButton CssClass="link_category" ID="link_category" runat="server"  Text='<%# Eval("CateName")%>' ></asp:LinkButton>
									</ItemTemplate>
								</asp:DataList>
							</div>
						</div>	
					</div>
				</div>
				
				<div class="col-sm-9 padding-right">
					<div class="features_items">
						<h2 class="title text-center">Sản Phẩm</h2>
						<% for (int i = 0; i < arrProduct.Count(); i++){ %>
						<div class="col-sm-4 list-item">
							<div class="product-image-wrapper">
								<div class="single-products">
										<div class="productinfo text-center">
											<a href="/DetailProduct.aspx?idProduct=<%= arrProduct[i].ProductId+""%>"><img src="<%= arrProduct[i].ImagePath %>" alt="" /></a>
											<h2><%= arrProduct[i].Price %> đ</h2>
											<p><%= arrProduct[i].ProductName %></p>
											<a href="/ShoppingCart.aspx?idProduct=<%= arrProduct[i].ProductId+""%>" class="btn btn-default add-to-cart"><i class="fa fa-shopping-cart"></i>Thêm sản phẩm</a>
										</div>
								</div>
							</div>
						</div>
						<% } %>
					</div>
					
				</div>
			</div>
		</div>
	</section>
</asp:Content>
