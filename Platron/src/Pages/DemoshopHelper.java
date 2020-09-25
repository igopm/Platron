import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;

import java.util.List;

public class DemoshopHelper extends  BaseHelper{
    public DemoshopHelper(){
        super();
    }
    public AuthHelper ClickButtonEnter()
    {
        WhenIsClickable(UIDemoshopPage.ButtonEnter).click();
        WaiteUntilPageLoad(10);
        driverHelper.switchTo().defaultContent();
        driverHelper.switchTo().frame(0);

        return new AuthHelper();
    }
    public ShopCartHelper ClickInBinOnPage(int index){
        List<WebElement> elements = driverHelper.findElements(By.xpath(UIDemoshopPage.ThingsOnMainPage));
        //System.out.println("elements " + elements.size());
        //DrawHighlight(elements.get(index));
        WebElement inBinElement = WhenIsClickable(elements.get(index)).findElement(By.xpath(UIDemoshopPage.InBinOnMainPage));
        //DrawHighlight(inBinElement);
        inBinElement.click();
        return new ShopCartHelper();
    }
}
