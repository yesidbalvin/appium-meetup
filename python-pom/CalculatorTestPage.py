import unittest
from CalculatorPageObject import CalculatorPage
from appium import webdriver


class CalculatorTestPage(unittest.TestCase):

    def setUp(self):
        self.calculator_page = CalculatorPage()

    def test_calculator(self):
        self.calculator_page.press_number_two()

        self.calculator_page.press_addition()

        self.calculator_page.press_number_six()

        self.assertEqual('8', self.calculator_page.get_result())

    def tearDown(self):
        self.calculator_page.close_app()


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(CalculatorTestPage)
    unittest.TextTestRunner(verbosity=6).run(suite)
