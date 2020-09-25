import org.openqa.selenium.By;

public class ShopCartPage extends  BasePage {
    public String RowsOnBinPage = "//tbody/tr[contains(@class, 'cart-form')]";
    public String RemoveRowOnBinPage = ".//preceding-sibling::td[@class='product-remove']";

    By TheBinIsClearMessage = By.xpath("//p[@class='cart-empty'][text()=.]");
}
