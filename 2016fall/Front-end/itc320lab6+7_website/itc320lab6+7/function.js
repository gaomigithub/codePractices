function setCookie(name,value){
    if(!name||!value) return;
    var Days = 30;
    var exp  = new Date();
    exp.setTime(exp.getTime() + Days*24*60*60*1000);
    document.cookie = name + "="+ encodeURIComponent(value) +";expires="+ exp.toUTCString();
}
function getCookie(name){
    var arr = document.cookie.match(new RegExp("(^| )"+name+"=([^;]*)(;|$)"));
    if(arr != null) return decodeURIComponent(arr[2]);
    return null;
}
function delCookie(name){
    var exp = new Date();
    exp.setTime(exp.getTime() - 1);
    var cval=getCookie(name);
    if(!cval) document.cookie=name +"="+cval+";expires="+exp.toUTCString();
}
//gobuy
function inArray(array, str){
    for(a in array) {
        if(array[a] == str) return true;
    }
    return false;
}
function goBuy(id, price){
    var newCookie = "";
    var oldCookie = getCookie("product");
    if(oldCookie) {
        if(inArray(oldCookie.split(","), id)) {
            newCookie = oldCookie;
        } else {
            newCookie = id + "," + oldCookie;
        }
    } else {
        newCookie = id;
    }
    setCookie("product", newCookie);
    location.href = "Cart?action=add&entityId="+id;
}
function goBuy2(id){
    var newCookie = "";
    var oldCookie = getCookie("product");
    if(oldCookie) {
        if(inArray(oldCookie.split(","), id)) {
            newCookie = oldCookie;
        } else {
            newCookie = id + "," + oldCookie;
        }
    } else {
        newCookie = id;
    }
    setCookie("product", newCookie);
    location.href = "Cart?action=addBuy&entityId="+id;
}
// run after dom be loaded
$(function(){
    // the way to get focus
    function focusItem(dom){
        $(dom).parent().parent().addClass("current");
        var eBox=$(dom).parent().find("span");
        eBox.removeClass("error").text("");
    }
    // clear the background when lost the focus, and verify the information method
    function checkItem(dom){
        $(dom).parent().parent().removeClass("current");
        var eBox=$(dom).parent().find("span");
        var name = $(dom).attr("name");
        var value = $(dom).val();
        var errorMessage="",isError=true;
        switch(name){
            case "userId":
                if(value == "") {
                    errorMessage = "Account cannot be empty";
                }else if(!/[a-zA-Z0-9]+/.test(value)){
                    errorMessage = "The account only combine with the number and the character";
                }else{
                    isError = false ;
                }
                break;
            case "userName":
                if(value == "") {
                    errorMessage = "Name cannot be empty";
                }else if(value.length>10){
                    errorMessage = "Length cannot be more than 10 chars";
                }else{
                    isError = false ;
                }
                break;
            case "password":
                if(value == "") {
                    errorMessage = "Passwords cannot be empty";
                }else{
                    isError = false ;
                }
                break;
            case "confirmPassword":
                if(value == "") {
                    errorMessage = "Confirm cannot be empty";
                } else if(value != $("#password").val()) {
                    errorMessage = "Different between two passwords";
                }else{
                    isError = false ;
                }
                break;
            case "address":
                if(value == "") {
                    errorMessage = "Address cannot be empty";
                }else{
                    isError = false ;
                }
                break;
            case "birthday":
                if((value != "") && !/\d{4}[-]\d{1,2}[-]\d{1,2}/.test(value)) {
                    errorMessage = "The format of birthday only be yyyy-mm-dd";
                }else{
                    isError = false ;
                }
                break;
            case "identityCode":
                if((value != "") && !/((\d{17}\w{1})|(\d{15}))/.test(value)) {
                    errorMessage = "The form of ID Code is wrong";
                }else{
                    isError = false ;
                }
                break;
            case "email":
                if((value != "") && !/^[a-z0-9]+\@([a-z0-9]+\.)+[a-z0-9]{2,4}$/i.test(value)) {
                    errorMessage = "The form of e-mail adress is wrong";
                }else{
                    isError = false ;
                }
                break;
            case "mobile":
                if((value == "") || !/\d{11}/.test(value)) {
                    errorMessage = "The form of phone number is wrong";
                }else{
                    isError = false ;
                }
                break;
            case "productName":
                if(value == "") {
                    errorMessage = "The production name cannot be empty";
                }else{
                    isError = false ;
                }
                break;
            case "productPrice":
                if((value == "")||!(/^\d+(\.\d+)?$/.test(value))) {
                    errorMessage = "Cannot be empty and positive only";
                }else{
                    isError = false ;
                }
                break;
            case "productNumber":
                if((value == "")||!(/^[0-9]*[1-9][0-9]*$/.test(value))) {
                    errorMessage = "Cannot be empty and positive only";
                }else{
                    isError = false ;
                }
                break;
            case "photo":
                if(value == "") {
                    errorMessage = "Cannot be empty";
                }else{
                    isError = false ;
                }
                break;
            case "content":
                if(value == "") {
                    errorMessage = "Cannot be empty";
                }else if(value.length>500){
                    errorMessage = "Cannot be more than 500";
                }else{
                    isError = false ;
                }
                break;
            case "title":
                if(value == "") {
                    errorMessage = "Cannot be empty";
                }else if(value.length>20){
                    errorMessage = "Cannot be more than 20";
                }else{
                    isError = false ;
                }
                break;
            default:
                isError = false ;
                break;
        }
        if(isError){
            eBox.text(errorMessage);
            eBox.addClass("error");
            return false;
        }
        return true;
    }
    //提交表单方法
    function checkForm(){
        var flag=true;
        $(this).find("input[class='text']").each(function(i,dom){
            if(!checkItem($(dom))) flag = false;
        })
        if(!checkItem($(this).find("input[name='productPrice']"))) flag = false;
        if(!checkItem($(this).find("input[name='productNumber']"))) flag = false;
        return flag;
    }
    //添加商品
    $("#productAdd").find("input[class!='submit']").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    $("#productAdd").submit(checkForm);
    //添加新闻验证
    $("#newsAdd").find("[class='text']").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    $("#newsAdd").submit(function(){
        var $self = $(this);
        var $title = $self.find("[name=title]");
        var $content = $self.find("textarea");
        if($title.val().length>20){
            $title.next("span").addClass("error").html("Cannot be more than 20");
        }
        if($content.val().length>500){
            $content.next("span").addClass("error").html("Cannot be more than 500");
        }
        if($title.val().length<=20&&$title.text().length<=500){
            return true;
        }
        return false;
    });
    //dom调用聚焦，失焦事件
    $("#userId").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    $("#password").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    //日历
    $("#birthday").click(function(){
        WdatePicker({
            highLineWeekDay:true //周末高亮
            ,readOnly:true      //只读，只可用控件input中 修改内容
            ,dateFmt:'yyyy-MM-dd'
        });
    });
    //点击换验证码
    $("#changeCode").click(function(){
        $("#safeCode").attr("src","Number.jsp?id="+Math.random());
    });
    //注册页面验证
    $("#regForm").find("input[class='text']").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    })
    //表单提交事件
    $("#loginForm").submit(checkForm);
    $("#regForm").submit(checkForm);
    //添加新地址事件
    $("#addr").click(function(){
        var val = $(this).val()
        if(val=="添加"){
//            location.href = "Cart?action=addAddress&address="+$("#addAddr").val();
            var addr = $("#addAddr").val();
            if(addr==""){
                alert("地址不能为空");
                return;
            }
            var reg=new RegExp(/;|；/gi);
            if(reg.test(addr)){
                alert("地址不能有分号");
                return;
            }
            var flag=true;
            $(this).parent().find("input[name='address']").each(function(i,d){
                if($(d).next().text()==addr){
                    flag=false;
                }
            })
            if(!flag){
                alert("地址不能相同");
                return;
            }
            $("#span").append('<br/><input name="address" type="radio" id="address0"/><span>'+addr+'</span>');
        }else{
            var span=$("#span").html('<input type="text" name="addAddr" id="addAddr"/>');
            $(this).val("添加");
        }
    });
    //删除商品
    $(".delete").find("a").click(function(){
        var tr = $(this).parent().parent();
        if(confirm("确定要删除吗？")) {
            var oldCookie = getCookie("product");
            if(oldCookie) {
                var oldCookieArr = oldCookie.split(",");
                var newCookieArr = new Array();
                for(c in oldCookieArr) {
                    var cookie = parseInt(oldCookieArr[c]);
                    if(cookie != id) newCookieArr.push(cookie);
                }
                var newCookie = newCookieArr.join(",");
                setCookie("product", newCookie);
            }
            if(tr) tr.remove();
            location.herf="";
        }else{
            return false;
        }
    });
    //后台删除
    $(".manageDel").click(function(){
        var $tr = $(this).parent().parent();
        if(confirm("确定要删除吗？")) {
            if($tr) $tr.remove();
            location.herf="";
        }else{
            return false;
        }
    })
    //修改
    $(".number").find("span").click(function(){
        var $tds=$(this).parent().parent().children("td");
        var $price= $($tds[1]);
        var $number=$($tds[2]);
        var price = $price.find("input[type='hidden']").val();//存值
        var $priceBox =$price.find("span");//现实价钱
        var $number= $number.find("input");//得到存储input对象
        var opr=$(this).attr("name");//判断增减
        var number = $number.val();//数量
        if(opr=="del"){
            number--;
            if(number<=0){
                if(confirm("确定要删除吗？")) {
                    $price.parent().remove();
                }else{
                    number=1;
                }
            }
        }else if(opr=="add"){
            number++;
        }
        $number.val(number);
        $priceBox.text("$" + price * number);
        $("#shopping").find("#total").text("Total：$"+totalPrice());
    });
    //计算总价
    function totalPrice(){
        var totalPrice=0;
        $("#shopping").find(".price").find("input[type='hidden']").each(function(i,d){
            var p= parseFloat($(d).val());
            var n = $(d).parent().parent().find("input[name='number']").val();
            totalPrice=totalPrice+p*n;
        });
        return totalPrice;
    }
    $("#shopping").find("input[name='number']").change(function(){
        var v=$(this).val();
        if(!(/^[0-9]*[1-9][0-9]*$/.test(v))){
            alert("Integer Please");
            $(this).val(1);
        }
        var $price=$($(this).parent().parent().children("td")[1]);
        var p = $price.find("input").val();
        $price.find("span").text(p*$(this).val());
        $("#shopping").find("#total").text("Total：$"+totalPrice());
    });
    $("#shopping").find("#total").text("Total：$" + totalPrice());
    //注销
    $("#logout").click(function(){
        if(confirm("Do you really want to check out？")) {
            location.href="shopping.html";
        }else{
            location.href="index.html";
            return false;
        }
    });
    // Ads rolling
    var index=0;
    setInterval(function(){
        index++;
        var $li=$("#slideBox").children("li");
        if(index>=$li.length){
            index=0;
        }
        $li.eq(index).stop(true,true).fadeIn().siblings().fadeOut();
    },3000);
    // Welcome pic
    if(document.referrer==""){
    	$("#welcomeImage").slideDown(4000).delay(1000).slideUp(4000);
    }
    //订单号验证，只能为数字
    $("#orderForm").submit(function(){
       var flag = !isNaN($("#entityId").val());
       if(!flag){
           alert("Number only");
       }
        return flag;
    });
    // Large pic appeared
    $("#product .thumb img").mouseover(function(){
        var src= $(this).attr("src").split("/");
        var name=src[src.length-1].split(".")[0];
        $("#product").append('<img id="bigImg" src="images/product/'+name+'_big.jpg"/>');
        $("#bigImg").show().error(function(){
            $(this).remove();
        });
    }).mouseleave(function(){
        $("#bigImg").hide();
    })
    // Sort of products, normally the 1st one be opened
    $($("#main .box dl dt")[0]).nextUntil('dt').show();
    $("#main .box dl dt").click(function(){
        $(this).nextUntil('dt').toggle();
    });
    // Cart
    $("#shoppingBag").mouseover(function(){
        var o = $(this).offset();
        var $table=$('<table id="floatBag" border="1" style="left:'+ o.left+'px;top:'+ (o.top+20)+'px;"></table>');
        $("#header").append($table);
        var html=[
            "<tr><th>图标</th><th>名称</th><th>价格</th></tr>",
            "<tr><td>图标</td><td>VVVVV</td><td>99</td></tr>"
        ]
        $table.html(html.join(""));
        $("#floatBag").show();
    }).mouseleave(function(){
        $("#floatBag").hide();
    });
    // Confirm
    $("#guestBook").submit(function(){
        if($(this).find("textarea").val().length<=100){
            return true;
        }
        $(this).find("span").addClass("error").html("Cannot be more than 100 words");
        return false;
    });
})