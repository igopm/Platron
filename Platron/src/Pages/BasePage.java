import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class BasePage {
    private final WebDriver driver;
    @FindBy(linkText = "Войти")
    public WebElement ButtonEnter;

    protected BasePage()
    {
        this.driver = ServiceDriver.Driver;
        PageFactory.initElements(driver, this);
    }
}
