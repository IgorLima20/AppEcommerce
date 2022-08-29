$('#janela_transportadoras tr td a.excluir').click(function (e) {
    e.preventDefault();
    var elemento = $(this).parent().parent();
    var Id = $(this).attr("data-id");
    ExcluirProd(Id, elemento);
})

function ExcluirProd(Id, elemento) {
    $.ajax({
        type: "POST",
        url: "/ShoppingCart/RemoveProdShoppingCart",
        data: { Id: Id, }
    }).done(function (data) {
        $(elemento).fadeOut();
        var valorFormatado = data.cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        $('#cart-total').html(valorFormatado);
        if (data.listaProd == 0) {
            $('#carrinho').html("");
        } else {
            $('#carrinho').html(data.listaProd);
        }
    });
}

$(".btnAumentar").click(function(e) {
    e.preventDefault();
    var Id = $(this).attr("prod-id");

    $.ajax({
        type: "POST",
        url: "/ShoppingCart/AddToShopping",
        data: { Id: Id, }
    }).done(function (data) {
        var cartTotal = data.cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        var Prod = parseInt(data.itemCount) * parseFloat(data.cartCount);
        var TotalProd = Prod.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        $('#cart-total').html(cartTotal);
        $('#totalItem-' + data.deleteId).html(TotalProd);
        $('#input-id-' + data.deleteId).val(data.itemCount);
        if (data.mensagem != null)
        {
            Swal.fire({
                icon: "warning",
                text: data.mensagem,
                type: "warning",
                confirmButtonColor: "#3085d6",
                confirmButtonText: "OK",
                closeOnConfirm: true,
            });
        }
    });
})

$("#janela_transportadoras tr td div div a.btnDiminuir").click(function(e) {
    e.preventDefault();
    var elemento = $(this).parent().parent().parent().parent();
    var Id = $(this).attr("prod-id");
    var QuantidadeProd = $("#input-id-" + Id).val();
    if (QuantidadeProd == 1) {
        ExcluirProd(Id, elemento);
    } else {
        DiminuirProd(Id);
    }
})

function DiminuirProd(Id) {
    $.ajax({
        type: "POST",
        url: "/ShoppingCart/RemoveFromShoppingCart",
        data: { Id: Id, }
    }).done(function(data) {
        var cartTotal = data.cartTotal.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        var Prod = parseInt(data.itemCount) * parseFloat(data.cartCount);
        var TotalProd = Prod.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        $('#cart-total').html(cartTotal);
        $('#totalItem-' + data.deleteId).html(TotalProd);
        $('#input-id-' + data.deleteId).val(data.itemCount);
    });
}
