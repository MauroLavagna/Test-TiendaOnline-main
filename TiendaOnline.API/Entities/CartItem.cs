namespace TiendaOnline.API.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; } //Esto denota que muchos elementos de la tarjeta 
                                        //puedem ser incluidos dentro de una compra en particular 
        public int ProductId { get; set; }

        public int Qty { get; set; } //Representa la cantidad o numero de un producto particular que puede incluirse dentro de un carrito de compras en particular

    }
}
