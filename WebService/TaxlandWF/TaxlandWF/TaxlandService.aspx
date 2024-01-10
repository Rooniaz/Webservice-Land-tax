<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaxlandService.aspx.cs" Inherits="TaxlandWF.TaxlandService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }
        .auto-style2 {
            width: 205px;
        }
        .auto-style3 {
            width: 159px;
            height: 23px;
        }
        .auto-style4 {
            width: 205px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
        }
        .auto-style7 {
            width: 112px;
            height: 27px;
        }
        .auto-style8 {
            height: 27px;
        }
        .auto-style10 {
            height: 27px;
            width: 176px;
        }
        .auto-style11 {
            width: 176px;
        }
        .auto-style12 {
            width: 163px;
        }
        .auto-style13 {
            width: 196px;
        }
        .auto-style14 {
            width: 112px;
            height: 30px;
        }
        .auto-style15 {
            width: 176px;
            height: 30px;
        }
        .auto-style16 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        </div>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">เลือกประเภทของภาษีที่ดิน</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlLocation" runat="server">
                        <asp:ListItem>ที่ดินเพื่อการเกษตรกรรม</asp:ListItem>
                        <asp:ListItem>ที่ดินเพื่อการอยู่อาศัย Bangyai</asp:ListItem>
                        <asp:ListItem>ที่ดินเพื่อพาณิชยกรรม</asp:ListItem>
                        <asp:ListItem>ที่ดินรกร้างว่างเปล่า</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="font-weight: 700" Text="ค้นหารถจากสาขาของ Tor" Width="178px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">เลือกยี่ห้อรถ</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlBrand" runat="server" Height="16px" Width="166px">
                        <asp:ListItem>Toyota</asp:ListItem>
                        <asp:ListItem>Honda</asp:ListItem>
                        <asp:ListItem>Mazda</asp:ListItem>
                        <asp:ListItem>Nissan</asp:ListItem>
                        <asp:ListItem>Volvo</asp:ListItem>
                        <asp:ListItem>BMW</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnBrand" runat="server" OnClick="btnBrand_Click" style="font-weight: 700" Text="ค้นหารถจากยี่ห้อ" />
&nbsp;<asp:Button ID="btnBrandSection" runat="server" OnClick="btnBrandSection_Click" style="font-weight: 700" Text="ค้นหารถจากยี่ห้อร่วมกับสาขา" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
  

        <table style="width:100%;">
            <tr>
                <td class="auto-style6" colspan="3"><strong>คำนวณยอดจัดไฟแนนซ์และค่างวด</strong></td>
            </tr>
            <tr>
                <td class="auto-style6">ปี</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlYear" runat="server" Width="122px">
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;ราคาเต็ม</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">บาท</td>
            </tr>
            <tr>
                <td class="auto-style6">ราคาดาวน์ </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtDown" runat="server"></asp:TextBox>
                </td>
                <td>บาท</td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Button ID="btnCompute" runat="server" BackColor="#0066FF" ForeColor="White" OnClick="btnCompute_Click" style="font-weight: 700" Text="คำนวณค่างวด" Width="107px" />
                </td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
            </tr>
        </table>
        <p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblShowInterest" runat="server" BackColor="Yellow" Text="ดอกเบี้ย"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">ผ่อน 5 ปี หรือ 60 งวด (ผ่อนเดือนละ)</td>
                    <td class="auto-style13">
                        <asp:Label ID="lbl5Years" runat="server" Text="แสดงผล"></asp:Label>
                    </td>
                    <td>บาท</td>
                </tr>
                <tr>
                    <td class="auto-style12">ผ่อน 4 ปี หรือ 48 งวด (ผ่อนเดือนละ)</td>
                    <td class="auto-style13">
                        <asp:Label ID="lbl4Years" runat="server" Text="แสดงผล"></asp:Label>
                    </td>
                    <td>บาท</td>
                </tr>
                <tr>
                    <td class="auto-style12">ผ่อน 3 ปี หรือ 36 งวด (ผ่อนเดือนละ)</td>
                    <td class="auto-style13">
                        <asp:Label ID="lbl3Years" runat="server" Text="แสดงผล"></asp:Label>
                    </td>
                    <td>บาท</td>
                </tr>
                <tr>
                    <td class="auto-style12">ผ่อน 2 ปี หรือ 24 งวด (ผ่อนเดือนละ)</td>
                    <td class="auto-style13">
                        <asp:Label ID="lbl2Years" runat="server" Text="แสดงผล"></asp:Label>
                    </td>
                    <td>บาท</td>
                </tr>
            </table>
        </p>
  

    </form>
</body>
</html>
