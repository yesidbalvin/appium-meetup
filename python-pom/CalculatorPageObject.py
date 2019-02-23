from appium import webdriver
from BasePageObject import BasePage


class CalculatorPage(BasePage):

    # Locators by Id
    number_two = "com.android.calculator2:id/digit_2"
    number_six = "com.android.calculator2:id/digit_6"
    addition_character = "com.android.calculator2:id/op_add"
    result = "com.android.calculator2:id/result"

    def press_number_two(self):
        web_element2 = self.find_element_by_id(self.number_two)
        web_element2.click()

    def press_number_six(self):
        web_element6 = self.find_element_by_id(self.number_six)
        web_element6.click()

    def press_addition(self):
        web_element_add = self.find_element_by_id(self.addition_character)
        web_element_add.click()

    def get_result(self):
        return self.find_element_by_id(self.result).text
