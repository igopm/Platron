import java.util.List;
import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;

public class ShopCartHelper extends  BaseHelper {
    ShopCartPage UIShopCartPage = new ShopCartPage();
    public ShopCartHelper()
    {
        super();
    }

    public ShopCartHelper CheckExistRowsInBin(int expectedElement) throws Exception {
        WaiteUntilPageLoad(10);
        List<WebElement> temp = driverHelper.findElements(By.xpath(UIShopCartPage.RowsOnBinPage));
        Assert.assertEquals("Size not correct", expectedElement, temp.size());
        return this;
    }
    public ShopCartHelper ActionRemoveElementFromBin()
    {
        WebElement element = driverHelper.findElement(By.xpath(UIShopCartPage.RowsOnBinPage))
                .findElement(By.xpath(UIShopCartPage.RemoveRowOnBinPage));
        element.click();
        WaitInvisibilityOfElementLocated(UIShopCartPage.RowsOnBinPage);
        return this;
    }

}
