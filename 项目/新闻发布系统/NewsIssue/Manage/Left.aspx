<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Manger_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
	<HEAD>
		<title>功能导航</title>
		<style type="text/css">
	body  { background:#7F9ED9; margin:0px; font:normal 12px 宋体; scrollbar-face-color: #799AE1; scrollbar-highlight-color: #799AE1; scrollbar-shadow-color: #799AE1; scrollbar-darkshadow-color: #799AE1; scrollbar-3dlight-color: #799AE1; scrollbar-arrow-color: #FFFFFF;scrollbar-track-color: #AABFEC;}
	table  { border:0px; }
	td  { font-size:12px ; }
	img  { vertical-align:bottom; border:0px; }
	a  { font-size: 12px ; color:#215DC6; text-decoration:none; }
	a:hover  { color:#428EFF }
	.sec_menu  { border-left:1px solid white; border-right:1px solid white; border-bottom:1px solid white; background:#E2ECFD; padding:5px 2px;}
	.menu_title  { }
	.menu_title span  { position:relative; top:2px; left:8px; color:#215DC6; font-weight:bold; }
	.menu_title2  { }
	.menu_title2 span  { position:relative; top:2px; left:8px; color:#428EFF; font-weight:bold; }
	</style>
	</HEAD>
	<body>
<script language="javascript" type="text/javascript">
<!--
function menuChange(obj,menu)
{
	if(menu.style.display=="")
	{
		obj.background="../Images/admin_title_bg_hide.gif";
		menu.style.display="none";
	}else{
		obj.background="../Images/admin_title_bg_show.gif";
		menu.style.display="";
	}
}

function proLoadimg()
{
	var i=new Image;
	i.src='../Images/admin_title_bg_hide.gif';
	i.src='../Images/admin_title_bg_show.gif';
}
function hideMenu(menu)
{
	menu.style.display="none";

}
proLoadimg();
-->
		</script>
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" style="background:url('../Images/admin_title_bg_quit.gif')">
					<A href="../Default.aspx" target="_top"><strong>退出系统</strong></A>
				</td>
			</tr>
		</table>
		&nbsp;&nbsp;
		<table cellSpacing="0" cellPadding="0" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif'); width: 154px;" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu1);">
				<span>时政要闻</span>
				</td>
			</tr>
			<tr>
				<td >
					<div class="sec_menu" id="menu1" style="WIDTH: 158px;">
						<table cellSpacing="0" cellPadding="0" width="140" align="center" border="0">
							
							<tr>
								<td style="height: 20px"><A href="Add.aspx?id=1" target="right">添加</A> | <A href="list.aspx?id=1" target="right">
                                    管理</A></td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
      
		<script>hideMenu(menu1);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif'); width: 165px;" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu2);">
				<span>经济动向</span>
				</td>
			</tr>
			<tr>
				<td style="width: 165px">
					<div class="sec_menu" id="menu2" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center" border="0">
							
							<tr>
								<td height="20"><A href="Add.aspx?id=2" target="right">添加</A>   | <A href="list.aspx?id=2" target="right">
										 管理</A>
								</td>
							</tr>
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu2);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu3);">
				<span>世界军事</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu3" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							
							<tr>
								<td height="20"><A href="Add.aspx?id=3" target="right">添加</A> | <A href="list.aspx?id=3" target="right">
										 管理</A>
								</td>
							</tr>
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu3);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu4);">
				<span>科学教育</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu4" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							
							<tr>
								<td height="20"><A href="Add.aspx?id=4" target="right">添加</A> | <A href="list.aspx?id=4" target="right">
										 管理</A>
								</td>
							</tr>
							
							
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu4);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu5);">
				<span>法治道德</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu5" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td height="20"><A href="Add.aspx?id=5" target="right">添加</A> | <A href="list.aspx?id=5" target="right">
										 管理</A>
								</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu5);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu6);">
				<span>社会现象</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu6" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td height="20"><A href="Add.aspx?id=6" target="right">添加</A> | <A href="list.aspx?id=6" target="right">
										 管理</A>
								</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu6);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu7);">
				<span>体育世界</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu7" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td height="20"><A href="Add.aspx?id=7" target="right">添加</A> | <A href="list.aspx?id=7" target="right">
										 管理</A>
								</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu7);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu8);">
				<span>时尚娱乐</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu8" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td height="20"><A href="Add.aspx?id=8" target="right">添加</A> | <A href="list.aspx?id=8" target="right">
										 管理</A>
								</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu8);</script>
		&nbsp;
		<table cellSpacing="0" cellPadding="0" width="158" align="center">
			<tr style="CURSOR: hand">
				<td height="25" class="menu_title" style="background:url('../Images/admin_title_bg_show.gif')" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" onclick="menuChange(this,menu9);">
				<span>管理员设置</span>
				</td>
			</tr>
			<tr>
				<td>
					<div class="sec_menu" id="menu9" style="WIDTH: 158px">
						<table cellSpacing="0" cellPadding="0" width="140" align="center">
							<tr>
								<td><A href="MemberAdd.aspx" target="right">添加</A> | <A href="MemberEdit.aspx" target="right">
										 管理</A>
								</td>
							</tr>
						</table>
					</div>
				</td>
			</tr>
		</table>
		<script>hideMenu(menu9);</script>
		<br>
		<br>
	</body>
</HTML>
