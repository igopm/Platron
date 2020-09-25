import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class BaseHelper implements IHelper {
    protected WebDriver driverHelper;
    protected WebDriverWait wait;
    DemoshopPage UIDemoshopPage = new DemoshopPage();
    AuthPage UIAuthPage = new AuthPage();
    public BaseHelper() {
        this.driverHelper = ServiceDriver.Driver;
        wait = new WebDriverWait(driverHelper, 2000);
    }
    protected void ActionFillField(WebElement element, String value)
    {
        WhenIsClickable(element).sendKeys(value);
    }
    protected void WaiteUntilPageLoad(int time)
    {
        if (time ==0)
            time = 10;
        //driverHelper.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        wait = new WebDriverWait(driverHelper, time * 1000);
        wait.until(driverHelper ->
                (long)((JavascriptExecutor)driverHelper).executeScript("return jQuery.active") == 0);
    }
    protected WebElement WhenIsClickable(WebElement element) {
        return wait.until(ExpectedConditions.elementToBeClickable(element));
    }
    protected void WaitInvisibilityOfElementLocated(String xpath)
    {
        wait.until(ExpectedConditions.invisibilityOfElementLocated(By.xpath(xpath)));
    }
    protected void DrawHighlight(WebElement element) {
        String script = "arguments[0].style.border='3px solid red'; setTimeout(() => arguments[0].style.border='0px solid red', 3000);";
        JavascriptExecutor js = (JavascriptExecutor) driverHelper;
        js.executeScript(script, element);
    }
}
