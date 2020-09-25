import org.junit.Test;

public class AddingAnItemToTheBinTest extends BaseTest {
    @Test
    public void AddingAnItemToTheBin() throws Exception {
//        System.out.println(System.getProperty("user.dir"));
//        System.out.println(System.getProperty(outputPath));
        IHelper er = new DemoshopHelper()
                .ClickInBinOnPage(1)
                .CheckExistRowsInBin(1);
    }
}