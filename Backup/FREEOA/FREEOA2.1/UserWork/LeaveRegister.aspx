﻿<%@ page language="C#" autoeventwireup="true" inherits="UserWork_LeaveRegister, App_Web_65ubaf-d" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1"><title>
	无标题页
</title><link href="../css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Js/calendar.js"></script>
		
        <style type="text/css">
            #Text1
            {
                height: 20px;
            }
            #Text2
            {
                height: 20px;
            }
        </style>
		
</head>
<body>
    <form name="form1" runat="server" id="form1">


       <table border="0" cellpadding="0" cellspacing="0" bordercolor="#111111" width="100%">
				<tr height="30">
					<td width="3%" background="../Images/topbg.jpg" align=center><IMG height="16" src="../Images/icon/right.GIF"></td>
					<td background="../Images/topbg.jpg" width="80"><b>请假登记</b></td>
					<TD background="../Images/topbg.jpg" align="right">
					</TD>
				</tr>
			</table>
    <table width=100% cellpadding=0 cellspacing=0 border=0 align=center>
    <tr>
    <td style="height: 20px"></td>
    </tr>
    <tr>
    <td align="center">
    <table width="65%" cellpadding=0 cellspacing=0 border=0>
    <tr>
    <td width="15%" height=25 align="right">
    请假时间：
    </td>
    <td align="left">
        <input id="txtStarttime" type="text" runat="server" onfocus="setday(this)" /> &nbsp; 至&nbsp; 
        <input id="txtEndtime" type="text" runat="server"  onfocus="setday(this)"/>
    </td>
    </tr>
    <tr>
    <td width="15%" align="right">
    请假事由：
    </td>
    <td align="left">
        <asp:TextBox ID="TextBox5" class="TxCss" runat="server" Height="91px" 
            TextMode="MultiLine" Width="467px"></asp:TextBox></td>
    </tr>
    <tr>
    <td colspan=2 align="center" height="25">
        <input type="submit" name="bnSave" value="确  定" id="bnSave" class="BnCss" onserverclick="bnSave_ServerClick" runat="server" /></td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    
<div>
    &nbsp;</div></form>
</body>
</html>