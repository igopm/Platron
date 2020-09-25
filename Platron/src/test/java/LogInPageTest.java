import org.junit.Test;

public class LogInPageTest extends BaseTest {
    @Test
    public void CheckWarningMessageInLogInPage() throws Exception {
        System.out.println("CheckWarningMessageInLogInPage");
        IHelper er = new DemoshopHelper()
                .ClickButtonEnter()
                .ActionSetLogIn("notCorrect")
                .ActionSetPassword("password")
                .ActionClickButtonSubmit()
                .CheckAlertMessage("Введенная комбинация логин/пароль неверна");
    }
}
