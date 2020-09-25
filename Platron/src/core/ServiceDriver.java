import org.openqa.selenium.PageLoadStrategy;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.remote.RemoteWebDriver;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.URL;
import java.nio.channels.Channels;
import java.nio.channels.ReadableByteChannel;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.time.Duration;

enum BrowserName {
    Chrome,
    Firefox
}

enum DriverType {
    RWD,
    IWD
}

public class ServiceDriver {
    public static WebDriver Driver = null;

    public static void initilize() throws Exception {
        BrowserName bn = BrowserName.Chrome;
        DriverType dt = DriverType.IWD;
        if (Driver == null) {
            switch (bn) {
                case Chrome:
                    StartChrome(dt);
                    break;
                default:
                    throw new Exception("initilize:" + bn + " not found");
            }
        }
        String pathToWebSite = "https://front.platron.ru/demoshop/";
        Driver.navigate().to(pathToWebSite);
        WebDriverWait Wait = new WebDriverWait(Driver, 10000);
    }

    public static void Quit() {
        Driver.quit();
        Driver = null;
    }

    private static void StartChrome(DriverType dt) {
        //if (dt == DriverType.RWD)
      //      Driver = new RemoteWebDriver(new Uri(Config.UrlRemoveWebDriver), Options());
        //else if (dt == DriverType.IWD)
        //String ff = PathDriver();
        String pathToChromeDriver = "chromedriver.exe";

        System.setProperty("webdriver.chrome.driver", pathToChromeDriver);
        Driver = new ChromeDriver(Options());

    }

    private static ChromeOptions Options() {
        ChromeOptions chromeOptions = new ChromeOptions();

        // headless mode
        //if (Config.ModeForChrome != "")
            //chromeOptions.AddArgument(Config.ModeForChrome);
        chromeOptions.addArguments("--start-maximized");
        chromeOptions.setPageLoadStrategy(PageLoadStrategy.NORMAL);
        return chromeOptions;
    }
//    private static boolean checkExistFile(String path) {
//        File f = new File(path);
//        if (f.exists() && !f.isDirectory())
//            return true;
//        else
//            return false;
//    }
//    String FILE_URL = "https://chromedriver.storage.googleapis.com/85.0.4183.87/chromedriver_win32.zip";
//    String outputPath = System.getProperty("user.dir") + "\\chromedriver_win32.zip";
//    DownloadFile(FILE_URL, outputPath);
//
//    DownloadFile(FILE_URL, outputPath);
//    public static void DownloadFile(String file_url, String outputPath) throws Exception {
//        if (!checkExistFile(outputPath)) {
//            System.out.println("is not exist");
//            FileOutputStream fos = null;
//            ReadableByteChannel channel = null;
//            try {
//                // create a url object
//                URL url = new URL(file_url);
//                // create an input stream to the file
//                InputStream inputStream = url.openStream();
//                // create a channel with this input stream
//                channel = Channels.newChannel(url.openStream());
//                // create an output stream
//                fos = new FileOutputStream(new File(outputPath));
//                // get output channel, read from input channel and write to it
//                fos.getChannel().transferFrom(channel, 0, Long.MAX_VALUE);
//
//            } catch (IOException e) {
//                e.printStackTrace();
//            } finally {
//                fos.close();
//                channel.close();
//            }
//        } else
//            System.out.println("is exist");
//    }

    protected static String PathDriver() {
//        string pathToZip = Path.Combine(Path.GetDirectoryName(new System.Diagnostics.StackFrame(true).GetFileName()), "chromedriver.zip");
//        string pathToExe = Path.Combine(Path.GetDirectoryName(new System.Diagnostics.StackFrame(true).GetFileName()), "chromedriver.exe");
//        if (!File.Exists(pathToZip) || !File.Exists(pathToExe)) {
//            if (File.Exists(pathToZip))
//                File.Delete(pathToZip);
//
//            if (File.Exists(pathToExe))
//                File.Delete(pathToExe);
//
//            using(WebClient wc = new WebClient())
//            {
//                File.WriteAllBytes(pathToZip, wc.DownloadData(new Uri(Config.UrlDriverChrome)));
//            }
//
//            ZipFile.ExtractToDirectory(pathToZip, Path.GetDirectoryName(pathToZip));
//        }pathToZip
        //Path. Path.GetDirectoryName(pathToZip);
        return "";
    }
}
