// JScript 文件

    var http;
    if (window.XMLHttpRequest)
        http=new XMLHttpRequest();
    else
        http=new ActiveXObject("Microsoft.XMLHTTP");
 function Login()
 {
        var yhm,mm;
        yhm=document.getElementById("yhm").value;
        mm=document.getElementById("mima").value;
       
        http.onreadystatechange=function(){
            document.getElementById("msg").innerHTML="登陆中..";            
            if (http.readyState==4&&http.status==200)
            {
                if (http.responseText=="1"){
                    document.getElementById("msg").innerHTML="登录成功!跳转中..";
                    window.location='Chat.aspx';
                }
                else if (http.responseText=="0")
                    document.getElementById("msg").innerHTML="请退出1分钟后再登录或此用户已登录!";
                else
                    document.getElementById("msg").innerHTML="用户名密码错误!";
            }
        
        }
        url="AjaxServer.aspx?type=1&yhm="+escape(yhm)+"&mm="+mm;
        http.open("post",url,true);
        http.send();    
  }   
 function Send()
 {
        var msg;
        msg=document.getElementById("msg").value;
        if (msg==""||msg==null)
        {
            alert("聊天内容不能为空!");
            document.getElementById("msg").focus();
            return false;
        }        
        url="AjaxServer.aspx?type=2&msg="+escape(msg);
        http.onreadystatechange=function(){    
             
            if (http.readyState==4&&http.status==200)
            {
               if (http.responseText=="0")
                   document.getElementById("info").innerHTML="您被管理员禁言了!";
               else                
                   document.getElementById("Chat").innerHTML=http.responseText; 
            }        
        } 
        http.open("post",url,true);
        http.send();
        document.getElementById("msg").value="";
        document.getElementById("msg").focus();
 }
 function Get()
 {    
    http.onreadystatechange=function(){    
             
            if (http.readyState==4&&http.status==200)
            {
               document.getElementById("Chat").innerHTML=http.responseText; 
            }        
        } 
        url="AjaxServer.aspx?type=3";
        http.open("post",url,true);
        http.send();
        
 }
 function Reg()
 {
    var yhm,mm,remm;
    yhm=document.getElementById("yhm").value;
    mm=document.getElementById("mima").value;  
    remm=document.getElementById("remima").value;  
    if (yhm==""||mm=="")
    {    alert("用户名或密码为空!");
        return false;
    }
    else if (remm!=mm)
    {
        alert("两次密码不一致!");
        return false;
    }
    http.onreadystatechange=function(){    
             
            if (http.readyState==4&&http.status==200)
            {
               
               if(http.responseText=="-1")
                    alert("用户名已经存在!");
               else
                 {  alert("注册成功");
                   window.location='Chat.aspx';}
              
            }        
        } 
        url="AjaxServer.aspx?type=4&yhm="+escape(yhm)+"&mm="+escape(mm);
        http.open("post",url,true);
        http.send();
 }