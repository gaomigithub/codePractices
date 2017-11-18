
//cookie
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

$(function(){
    
    function focusItem(dom){
        $(dom).parent().parent().addClass("current");
        var eBox=$(dom).parent().find("span");
        eBox.removeClass("error").text("");
    }
  
    
    function checkForm(){
        var flag=true;
        $(this).find("input[class='text']").each(function(i,dom){
            if(!checkItem($(dom))) flag = false;
        })
        if(!checkItem($(this).find("input[name='productPrice']"))) flag = false;
        if(!checkItem($(this).find("input[name='productNumber']"))) flag = false;
        return flag;
    }
    
    $("#productAdd").find("input[class!='submit']").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    $("#productAdd").submit(checkForm);
    
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
    
    $("#userId").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    $("#password").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    });
    
    $("#birthday").click(function(){
        WdatePicker({
            highLineWeekDay:true 
            ,readOnly:true      
            ,dateFmt:'yyyy-MM-dd'
        });
    });
    
    $("#changeCode").click(function(){
        $("#safeCode").attr("src","Number.jsp?id="+Math.random());
    });
    
    $("#regForm").find("input[class='text']").bind({
        focus:function(){focusItem(this)},
        blur:function(){checkItem(this)}
    })
    
    $("#loginForm").submit(checkForm);
    $("#regForm").submit(checkForm);
    
    
    $(".delete").find("a").click(function(){
        var tr = $(this).parent().parent();
        if(confirm("You sure?")) {
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
    
    $(".manageDel").click(function(){
        var $tr = $(this).parent().parent();
        if(confirm("You sure?")) {
            if($tr) $tr.remove();
            location.herf="";
        }else{
            return false;
        }
    })
    
    $(".number").find("span").click(function(){
        var $tds=$(this).parent().parent().children("td");
        var $price= $($tds[1]);
        var $number=$($tds[2]);
        var price = $price.find("input[type='hidden']").val();
        var $priceBox =$price.find("span");
        var $number= $number.find("input");
        var opr=$(this).attr("name");
        var number = $number.val();
        if(opr=="del"){
            number--;
            if(number<=0){
                if(confirm("You sure?")) {
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
            alert("Enter integer please.");
            $(this).val(1);
        }
        var $price=$($(this).parent().parent().children("td")[1]);
        var p = $price.find("input").val();
        $price.find("span").text(p*$(this).val());
        $("#shopping").find("#total").text("Total：$"+totalPrice());
    });
    $("#shopping").find("#total").text("Total：$"+totalPrice());


    $("#shoppingBag").mouseover(function(){
        var o = $(this).offset();
        var $table=$('<table id="floatBag" border="1" style="left:'+ o.left+'px;top:'+ (o.top+20)+'px;"></table>');
        $("#header").append($table);
        var html=[
            "<tr><th>Image</th><th>Name</th><th>Price</th></tr>",
            "<tr><td>Image</td><td>VVVVV</td><td>99</td></tr>"
        ]
        $table.html(html.join(""));
        $("#floatBag").show();
    }).mouseleave(function(){
        $("#floatBag").hide();
    });

    $("#image_list a").each(function () {
        // get the image URL and caption for each image
        var imageURL = $(this).attr("href");
        var caption = $(this).attr("title");

        // preload the image for each link		
        var galleryImage = new Image();
        galleryImage.src = imageURL;

        // set up the event handlers for each link
        $(this).click(function (evt) {
            $("#image").attr("src", imageURL);
            $("#caption").text(caption);

            // cancel the default action of each link
            evt.preventDefault();
        }); // end click 
    }); // end each
    // move the focus to the first link
    $("#image_list:first-child:first-child").focus();

})