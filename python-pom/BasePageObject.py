from appium import webdriver


class BasePage:

    def __init__(self):
        capabilities = {}
        capabilities["automationName"] = "Appium"
        capabilities["platformVersion"] = "7.1.1"
        capabilities["platformName"] = "Android"
        capabilities["deviceName"] = "emulator-5554"
        capabilities["appPackage"] = "com.android.calculator2"
        capabilities["appActivity"] = "Calculator"

        self.driver = webdriver.Remote('http://127.0.0.1:4723/wd/hub', capabilities)

    def find_element_by_id(self, locator):
        return self.driver.find_element_by_id(locator)

    def close_app(self):
        self.driver.quit()
