import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class AuthPage extends  BasePage
{
    @FindBy(id="inputLogin")
    public WebElement FieldLogIn;
    @FindBy(name="submit")
    public WebElement ButtonSubmit;
    @FindBy(id="inputPassword")
    public WebElement FieldPassword;
    @FindBy(xpath="//form/div[contains(@class, 'form-message')]")
    public WebElement AlertMessage;
}
