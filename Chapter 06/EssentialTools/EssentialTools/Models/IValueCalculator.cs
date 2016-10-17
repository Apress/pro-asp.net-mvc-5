using System.Collections.Generic;

namespace EssentialTools.Models {
    public interface IValueCalculator {

        decimal ValueProducts(IEnumerable<Product> products);
    }
}
