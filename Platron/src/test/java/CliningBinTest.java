import org.junit.Test;

public class CliningBinTest extends BaseTest{
    @Test
    public void CliningBin() throws Exception {
        System.out.println("CliningBin");
        IHelper er = new DemoshopHelper()
                .ClickInBinOnPage(1)
                .CheckExistRowsInBin(1)
                .ActionRemoveElementFromBin()
                .CheckExistRowsInBin(0);
    }
}
