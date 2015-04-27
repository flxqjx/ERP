   var value=0;
   var bj;
   function setoverstyle(divname)
   {
       if(divname.style.backgroundColor=="#ffffcc")
       {
          bj=1;
       }
       else
       {
           bj=0;
       }
       divname.style.backgroundColor="#999999";
   }
   function setoutstyle(divname)
   {
       //alert(divname.style.backgroundColor);
       if(value==0)
       {
          //alert("adsadf");
          if(bj==1)
          {
             divname.style.backgroundColor="#ffffcc"
          }
          else
          {
             divname.style.backgroundColor="#F3F3F3";
          }
          
       }
       else
       {
          value=0;
       }
       
       //alert(divname.innerText);
   }
   function setallstyle(e,divname)
   {
        value=1;
        var a=document.getElementById(divname);
        var divs=a.getElementsByTagName("div");
        for(i=0;i<divs.length;i++)
        {
           divs[i].style.backgroundColor="#F3F3F3";
        }
        e.style.backgroundColor="#ffffcc";
   }

	function jssetvalue(name,id,textname,textid,divname)
	{
		   //var a=gettextcontrol();
		   //a.value=name; 
		   //var e=gettreeidctr();
		   //e.value=id;
		   document.getElementById(textname).value=name;
		   document.getElementById(textid).value=id;
		   //document.getElementById("TreeDropDownList1_treetext").value=name;
		   //document.getElementById("parentid").value=id;
		  // var a=document.getElementById("TreeView1_SelectedNode").value; 
		   //alert(document.getElementById("<%=treetext.ClientID %>").value);
		  // var e=document.getElementById(a).innerText; 
		  // alert(e);
		  document.getElementById(divname).style.visibility="hidden";
		  var e=divname.split("_");
		  //var a=e.length-1;
		  var a="";
		  for(i=0;i<e.length-1;i++)
		  {
		     a+=e[i];
		  }
		  GetTreeNodeValue(name,id,a);
		   
		  return false;
	}
	function GetObjAbsolutePostion(fobj)//获取控件的位置、长高
    { 
           var obj=document.getElementById(fobj);
           var x=obj.offsetLeft;
           var y=obj.offsetTop;
           while (obj.offsetParent)
          {
             obj=obj.offsetParent;
             x+=obj.offsetLeft;
             y+=obj.offsetTop
          }

          var o=new Object();
          o.left=x;
          o.top=y;
          o.width=document.getElementById(fobj).offsetWidth;
          o.height=document.getElementById(fobj).offsetHeight;
          return o;
       }
        function SetRelativePosition(fobj,robj)
        { 
           var obj=GetObjAbsolutePostion(robj);
           var Tree_div=document.getElementById(fobj);
           Tree_div.style.left=obj.left+"px";
           Tree_div.style.top=obj.top+obj.height+"px";
           Tree_div.style.width=obj.width+16+"px";
   
        } 
		function openTree(name,nametext)
		{
		    if(document.getElementById(name).style.visibility=="hidden"||document.getElementById(name).style.visibility=="")
		    {
		        document.getElementById(name).style.visibility="visible";
		        SetRelativePosition(name,nametext);
		    }
		    else
		    {
		        document.getElementById(name).style.visibility="hidden";
		    }
		}
		function closediv(e)
		{
		    e.style.visibility="hidden";
		}