import org.junit.After;
import org.junit.Before;
import org.junit.BeforeClass;

public class BaseTest {
//    @BeforeClass
//    public static void onceExecutedBeforeAll() {
//        System.out.println("@BeforeClass: onceExecutedBeforeAll");
//    }
    @Before
    public void Before() throws Exception {
            ServiceDriver.initilize();
            System.out.println("Before");
    }

    @After
    public void After()
    {
        ServiceDriver.Quit();
        System.out.println("After");
    }
}
