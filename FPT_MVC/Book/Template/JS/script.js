$(document).ready(function () {
    var index = 0;
    $(this).on('click', '.add-item', function () {
        index++;
        DisplayCart(index);
    });
    $(this).on('click', '.cart-icon', function () {
        $(".cart-list").toggle();
    })
   $(this).on('click','.view-item',function(){
       DisplayProduct();
   })
})
function DisplayCart(index) {
    $("#cart").html(index);
}
function DisplayProduct(){
    $.post('/product.html#',function(data){
        alert(data);
    })
}