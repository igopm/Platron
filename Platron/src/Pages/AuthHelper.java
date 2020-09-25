import org.junit.Assert;

public class AuthHelper extends BaseHelper {
    public AuthHelper() {
        super();
    }
    public AuthHelper ActionSetLogIn(String login)
    {
        this.ActionFillField(UIAuthPage.FieldLogIn, login);
        return this;
    }

    public AuthHelper ActionSetPassword(String password)
    {
        this.ActionFillField(UIAuthPage.FieldPassword, password);
        return this;
    }

    public AuthHelper ActionClickButtonSubmit()
    {
        UIAuthPage.ButtonSubmit.click();
        return this;
    }
    public AuthHelper CheckAlertMessage(String expected)
    {
        Assert.assertEquals(expected, WhenIsClickable(UIAuthPage.AlertMessage).getText());
        return this;
    }
}
