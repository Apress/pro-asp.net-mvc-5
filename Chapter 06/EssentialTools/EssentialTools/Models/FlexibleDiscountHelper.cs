namespace EssentialTools.Models {
    public class FlexibleDiscountHelper : IDiscountHelper {

        public decimal ApplyDiscount(decimal totalParam) {
            decimal discount = totalParam > 100 ? 70 : 25;
            return (totalParam - (discount / 100m * totalParam));
        }
    }
}
