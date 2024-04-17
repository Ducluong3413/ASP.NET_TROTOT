<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detaill.aspx.cs" Inherits="Webthuetro.Detaill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <link href="assest/css/detail.css" rel="stylesheet" />
        <!-- phan than -->
    
        <div id="detail">
            <div class="container">
                <div class="container-detail">
                    <div class="container-detail-left">
                        <div class="listimg">
                            <img src="/assest/img/2.jpg" alt="">
                        </div>
                        <h3>cho thuê phòng q3 full nội thất</h3>
                        <div class="thongtin">
                            <p class="gia">3,3 triệu /tháng</p>
                            <p class="dientich">-40m2</p>
                            <p><i class="fa-solid fa-share"></i>chia sẽ</p>
                            <p><i class="fa-solid fa-heart"></i>lưu tin</p>
                        </div>
                        <div class="diachi "><i class="fa-solid fa-location-dot"></i>18 phan tứ, mỹ an, ngũ hành sơn, đà nẵng</div>
                        <div class="thoigian "><i class="fa-solid fa-business-time"></i></i>đăng 3 giờ trước</div>
                        <div class="kiemduyet "><i class="fa-solid fa-shield"></i>tin đã được kiểm duyệt</div>

                        <div class="content-characteristic">
                            <h4>đặc điểm bất động sản</h4>
                            <div class="characteristic">
                                <div class="characteristic-left">
                                    <p><i class="fa-solid fa-cart-shopping"></i>cho thuê</p>
                                    <p><i class="fa-solid fa-couch"></i>tình trạng nội thất: nội thất đầy đủ</p>
                                </div>
                                <div class="characteristic-right">
                                    <p><i class="fa-brands fa-codepen"></i>diện tích: 40 m²</p>
                                    <p><i class="fa-solid fa-dollar-sign"></i>số tiền cọc: 1.300.000 đ</p>
                                </div>
                            </div>
                        </div>
                        <div class="content-characteristic">
                            <h4>mô tả chi tiết</h4>
                            <p>giá 1.3tr-1.5tr/tháng/người cho thuê ký túc xá ( sạch sẽ, rộng rãi, an ninh )

                                🏘 vị trí đắc địa, không gian thoáng mát, khu đông dân cư, khu nhiều tiện ích ( chợ, siêu thị, circle k, family mart, cafe 24/24, phòng gym...)
                                
                                gần nhiều trường đại học (2--5 phút ra các trường đh công nghiệp, đh nguyễn tất thành, việt mỹ, đh trần đại nghĩa, văn lang .. )
                                
                                đối tượng ở: sinh viên, người độc thân đang đi làm
                                
                                - khu ở được vệ sinh 2-3 ngày/ tuần, phòng có máy lạnh và máy quạt mở xuyên suốt
                                - có khu nấu ăn, sinh hoạt riêng, trong phòng chỉ để quần áo, góc học tập or làm việc và giường ngủ.
                                - mỗi người một giường+tủ khóa riêng biệt+ nhà vệ sinh trong phòng có máy tắm nước nóng
                                - khu sinh hoạt có đầy đủ nội thất ( chén dĩa, tủ bếp,bếp điện, máy giặt, tủ lạnh, bàn ghế ăn, máy lọc nước uống )
                                - bãi đậu xe rộng rãi, ra vào sử dụng khoá vân tay, có camera an ninh
                                phòng ở 4-8 người
                                
                                giá trọn gói, ko phát sinh thêm nên bạn nào muốn tiết kiệm chi phí thì liên hệ để xem phòng
                                địa chỉ : 270 nguyễn oanh, p17, gò vấp</p>
                        </div>

                    </div>
                    <div class="container-detail-right">
                        <div class="taikhoan">
                            <div class="taikhoan-left">
                                <h4 class="ten">phạm thị thu hà</h4>
                                <p class="con"><i class="fa-solid fa-folder"></i>môi giới</p>
                                <p class="con">hoạt động 21 giờ trước</p>
                            </div>
                            <div class="taikhoan-right">
                                <div class="xemtrang">xem trang<i class="fa-solid fa-chevron-right"></i></div>
                            </div>
                            

                        </div>
                        <div class="lienhe">
                            <p class="dau">liên hệ người bán</p>
                            <p class="cuoi">phản hồi: 90%</p>
                        </div>
                        <div class="call">
                            <a class="sdt" href="/contact.html"><p><i class="fa-solid fa-phone"></i>0356337618</p><p>bấm để hiện số</p></a>
                            <a class="chat" href=""><p><i class="fa-solid fa-message"></i></p><p>chat với người bán</p></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>







        <!-- phan than -->







       

        <%--<!-- Đăng nhập-->     
        <div id="loginModal" class="modal">
            <div class="modal-content">
                <span class="close">&times;</span>
                <form class="header-contrainer-login">
                    
                        <div class="header-login-form">
                                <div class="body-name-website">
                                    <img src="assest/img/Logo.png" alt="Logo">
                                </div>
                                <div class="body-title-login">
                                    <h2>Đăng Nhập</h2>
                                </div>  
                                <div class="textbox-username">
                                    <input id="textbox" type="text" placeholder="Tên Đăng Nhập">
                                </div>
                                <div class="textbox-password">
                                    <input id="textbox" type="text" placeholder="Mật Khẩu">
                                </div>
                                <div class="body-forgot-password">
                                    <a href="">Quên mật khẩu ?</a>
                                </div>      
                                <div class="body-button-login">
                                    <button>Đăng Nhập</button>
                                </div>
                                <div class="body-no-have-account">
                                    <p>Chưa có tài khoản ?</p>
                                    <a href="">Đăng kí tài khoản mới</a>
                                </div>
                        </div>
                        <div class="other-policies">    
                                <li><a href="">Quy chế hoạt động sàn</a></li>
                                <span>*</span>
                                <li><a href="">Chính sách bảo mật</a></li>
                                <span>*</span>
                                <li><a href="">Liên hệ hỗ trợ</a></li>
                        </div>
                   
                </form>
            </div>
            </div>

            <!-- Đăng kí -->
            <div id="registerModal" class="modal" style="display: none;">
                <div class="modal-content">
                    <span class="close">&times;</span>
                    <form id="registerForm">
                        <div class="header-contrainer-register">
                            <div class="header-register-form">
                                 <div class="body-name-website">
                                    <img src="assest/img/Logo.png" alt="Logo">
                                 </div>
                                 <div class="body-title-register">
                                    <h2>Đăng Kí</h2>
                                 </div>
                                 <div class="textbox-username">
                                <input type="text" id="textbox" placeholder="Tên Đăng Nhập">
                            </div>
                            <div class="textbox-email">
                                <input type="text" id="textbox" placeholder="Email hoặc Số điện thoại">
                            </div>
                            <div class="textbox-password-again">    
                                <input type="text" id="textbox" placeholder="Nhập Mật Khẩu">
                            </div>
                                 <div class="body-gender">
                                    <div class="body-gender-boy">
                                    <label for="male">Nam</label>
                                    <input type="radio" id="male" name="gender" value="Nam">
                                </div>
                                <div class="body-gender-girl">
                                    <label for="male">Nữ</label>
                                    <input type="radio" id="male" name="gender" value="Nữ">
                                </div>
                                <div class="body-gender-more">
                                    <label for="male">Giới tính khác</label>
                                     <input type="radio" name="gender" id="male" value="Giới tính khác">   
                                    </div>    
                                 </div>
                                 <div class="body-agree-to-terms">
                                    <input type="checkbox" id="tickbox">
                                    <p>Bằng việc Đăng ký, bạn đã đọc và đồng ý với Điều khoản sử dụng và Chính sách bảo mật của Trọ Tốt</p> 
                                 </div>
                                 <div class="body-button-register">
                                    <button>Đăng Kí</button>
                                 </div>
                            </div>
                        </div> 
                    </form>
            </div>
        </div>--%>

        

    </div>
    <script src="assest/vscode/style.js">
        
    </script>
</asp:Content>
