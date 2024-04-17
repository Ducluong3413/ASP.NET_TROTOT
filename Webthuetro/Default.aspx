<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webthuetro.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assest/css/dssanpham.css" rel="stylesheet" />
    <div id="header">
        <div class="container">
            <div class="container_header">
                <div class="slide">
                    <div class="dieuhuong">
                        <i class="fa-solid fa-angle-left" onclick="PreviousSlide()"></i>
                        <i class="fa-solid fa-angle-right" onclick="NextSlide()"></i>
                    </div>
                    <div class="slide-chuyenanh">
                        <img src="assest/img/Screenshot 2024-02-26 092621.jpg" alt="">
                        <img src="assest/img/1.jpg" alt="">
                        <img src="assest/img/2.jpg" alt="">
                        <img src="assest/img/3.jpg" alt="">
                        <img src="assest/img/5.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- nội dung -->

    <div class="container">
        <div class="container-view_content">
            <a class="content-content" href="Detaill.aspx">
                <div class="view_content">
                    <div class="img">
                        <img id="img_content" src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6 id="tieude">CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich" id="dientich">62 m2 </p>
                            <p class="sophong" id="phong">2 PN</p>
                        </div>
                        <div class="gia" id="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio" id="ngaydang">1 giờ trước</div>
                            <div class="diachi" id="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
            <a class="content-content" href="assest/pagehtml/detail.aspx">
                <div class="view_content">
                    <div class="img">
                        <img src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6>CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich">62 m2 </p>
                            <p class="sophong">2 PN</p>
                        </div>
                        <div class="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio">1 giờ trước</div>
                            <div class="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
            <a class="content-content" href="assest/pagehtml/detail.aspx">
                <div class="view_content">
                    <div class="img">
                        <img src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6>CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich">62 m2 </p>
                            <p class="sophong">2 PN</p>
                        </div>
                        <div class="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio">1 giờ trước</div>
                            <div class="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
            <a class="content-content" href="assest/pagehtml/detail.aspx">
                <div class="view_content">
                    <div class="img">
                        <img src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6>CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich">62 m2 </p>
                            <p class="sophong">2 PN</p>
                        </div>
                        <div class="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio">1 giờ trước</div>
                            <div class="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
            <a class="content-content" href="assest/pagehtml/detail.aspx">
                <div class="view_content">
                    <div class="img">
                        <img src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6>CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich">62 m2 </p>
                            <p class="sophong">2 PN</p>
                        </div>
                        <div class="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio">1 giờ trước</div>
                            <div class="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
            <a class="content-content" href="assest/pagehtml/detail.aspx">
                <div class="view_content">
                    <div class="img">
                        <img src="/assest/img/1.jpg" alt="">
                    </div>
                    <div class="content">
                        <h6>CĂN HỘ 2PN 2WC TẦNG CAO- NHẬN PHÒNG ĐẸP</h6>
                        <div class="content1">
                            <p class="dientich">62 m2 </p>
                            <p class="sophong">2 PN</p>
                        </div>
                        <div class="gia">8,5triệu/tháng</div>
                        <div class="content2">
                            <div class="gio">1 giờ trước</div>
                            <div class="diachi">Đà Nẵng</div>
                        </div>
                    </div>

                </div>
            </a>
        </div>
    </div>

</asp:Content>
