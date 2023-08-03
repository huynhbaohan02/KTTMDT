<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="OnlineShop.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHome" runat="server">
	 <section class="checkout spad">
        <div class="container">
            <div class="checkout__form">
					<h4>Chi tiết đơn hàng</h4>
                    <div class="row">
                        <div class="col-lg-6" style="width:30%">
							<asp:Label ID="tb" runat="server" ForeColor="#FF3300"></asp:Label>
                            <div class="checkout__input">
                                <p>Tên khách hàng<span>*</span></p>
                                <asp:TextBox ID="name" runat="server"></asp:TextBox>
                            </div>
							<div class="checkout__input">
                                <p>Số điện thoại<span>*</span></p>
                                <asp:TextBox ID="sdt" runat="server"></asp:TextBox>
                            </div>
                            <div class="checkout__input">
                                <p>Tỉnh/Thành Phố<span>*</span></p>
                                <asp:TextBox ID="tinh" runat="server"></asp:TextBox>
                            </div>
                            <div class="checkout__input">
                                <p>Huyện/Thị trấn<span>*</span></p>
                                <asp:TextBox ID="huyen" runat="server"></asp:TextBox>
                            </div>
                            <div class="checkout__input">
                                <p>Xã/Phường<span>*</span></p>
                                <asp:TextBox ID="xa" runat="server"></asp:TextBox>
                            </div>
                            <div class="checkout__input">
                                <p>Địa chỉ chi tiết<span>*</span></p>
                                <asp:TextBox ID="chitiet" runat="server"></asp:TextBox>
                            </div> 
							
                        </div>
                        <div class="col-lg-6" style="width:70%">
                            <div class="checkout__order">
                                <h4>Đơn hàng của tôi</h4>
                                <div class="checkout__order__products">
                                    <div class="checkout__order__image">Hình ảnh</div>
                                    <div class="checkout__order__name">Tên</div>
                                    <div class="checkout__order__quantity">Số Lượng</div>
                                    <div class="checkout__order__price">Giá</div>
                                </div>
                                <ul>
									<%for (int i = 0; i < listCart.Count; i++){%>
										<li>
											<div class="checkout__order__image">
												<img src="<%=listCart[i].ImagePath1 %>">
											</div>
											<div class="checkout__order__name"><%=listCart[i].ProductName1 %></div>
											<div class="checkout__order__quantity"><%=listCart[i].Quantity1 %></div>
											<div class="checkout__order__price"><%=listCart[i].Price1 %> đ</div>
										</li>
									<%} %>
                                </ul>
                                <div class="checkout__order__subtotal">Phí vận chuyển: <span>50000 đ</span></div>
                                <div class="checkout__order__total">Tổng Thanh Toán <span><%= tien %> đ</span></div>
                                <div class="checkout__input__checkbox">
                                        <b>Thanh toán khi nhận hàng</b>
                                </div>
								<asp:Button ID="btn_thanhtoan" runat="server" Text="Thanh Toán" onClick="btn_thanhtoan_Click"/>
                            </div>
						</div>
				    </div>
				</div>
			</div>
    </section>
</asp:Content>
