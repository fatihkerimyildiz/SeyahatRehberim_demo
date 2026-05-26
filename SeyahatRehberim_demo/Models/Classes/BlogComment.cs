namespace SeyahatRehberim_demo.Models.Classes
{
    public class BlogComment
    {                                           // IEnumarable Read-Only dir
        public IEnumerable<Blog> Value1 { get; set; }   //Bunun içinde tek bir blog değil, Blog nesnelerinden oluşan bir koleksiyon (dizi/liste) tutulacak. Bu sayede View tarafında @foreach döngüsünü kurup o listenin içinde dönebiliyorsun.
        public IEnumerable<Comment> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }
        /*
         * List<Blog> içi dolu, içindeki elemanları değiştirebildiğin, yeni bölmeler ekleyip çıkarabildiğin ağır bir organizer kutudur.
         * IEnumerable<Blog> ise o kutunun içindeki elemanları sadece sırayla görmeni sağlayan, hafif ve güvenli bir şeffaf poşettir.
         * View katmanına verileri bu şeffaf poşetle teslim edersin ki, sadece baksın ama içindekileri kurcalayıp bozmasın.
        */
    }
}
