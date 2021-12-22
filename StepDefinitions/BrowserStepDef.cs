using Lab_Cucumber.Drivers;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace Lab_Cucumber.StepDefinitions
{
    

    [Binding]
    public sealed class BrowserStepDef
    {   IWebDriver driver;
        
        private readonly ScenarioContext _scenarioContext;
        private readonly By _LoginInputButton = By.XPath("//input[@name='txtUsername']");
        private readonly By _PasswordInputButton = By.XPath("//input[@name='txtPassword']");
        private readonly By _SubmitButton = By.XPath("//input[@name='Submit']");
        private readonly By _GoToAdminButton = By.XPath("//a[@id='menu_admin_viewAdminModule']");
        private readonly By _Job = By.XPath("//a[@id = 'menu_admin_Job']");
        private readonly By _PayGrades = By.XPath("//a[@id='menu_admin_viewPayGrades']");
        private readonly By _AddButton = By.XPath("//input[@id ='btnAdd']");
        private readonly By _NameInputButton = By.XPath("//input[@id='payGrade_name']");
        private readonly By _SaveButton = By.XPath("//input[@id='btnSave']");
        private readonly By _AddCurrencyButton = By.XPath("//input[@id ='btnAddCurrency']");
        private readonly By _CurrencyInputButton = By.XPath("//input[@id = 'payGradeCurrency_currencyName']");
        private readonly By _MinInputButton = By.XPath("//input[@id = 'payGradeCurrency_minSalary']");
        private readonly By _MaxInputButton = By.XPath("//input[@id='payGradeCurrency_maxSalary']");
        private readonly By _SaveCurrencyButton = By.XPath("//input[@id='btnSaveCurrency']");
        private readonly By _Kanye = By.XPath("//*[text()='Kanye']");
        private readonly By _USD = By.XPath("//tr//td//a[text()='Kanye']//..//..//td[text() = 'United States Dollar']");
        private readonly By _CheckboxButton = By.XPath("//tr//td//a[text()='Kanye']//..//..//td");
        private readonly By _DeleteButton = By.XPath("//input[@id='btnDelete']");
        private readonly By _OkButton = By.XPath("//input[@id='dialogDeleteBtn']");
        private readonly By _PIMButton = By.XPath("//*[text()='PIM']");
        private readonly By _AddEmloyeeButton = By.XPath("//*[@id='menu_pim_addEmployee']");
        private readonly By _FirstNameInputButton = By.XPath("//input[@id='firstName']");
        private readonly By _LastNameInputButton = By.XPath("//input[@id='lastName']");
        private readonly By _LeaveButton = By.XPath("//*[text()='Leave']");
        private readonly By _LeaveAssignButton = By.XPath("//*[@id='menu_leave_assignLeave']");
        private readonly By _EmplNameInputButton = By.XPath("//*[@id='assignleave_txtEmployee_empName']");
        private readonly By _LaeveTypeButton = By.XPath("//*[@id='assignleave_txtLeaveType']");
        private readonly By _FromDateInputButton = By.XPath("//*[@id='assignleave_txtFromDate']");
        private readonly By _ToDateInputButton = By.XPath("//*[@id='assignleave_txtToDate']");
        private readonly By _AssignButton = By.XPath("//input[@id='assignBtn']");
        private readonly By _LeaveListButton = By.XPath("//*[@id='menu_leave_viewLeaveList']");
        private readonly By _SearchFromDateInputButton = By.XPath("//*[@id = 'calFromDate']");
        private readonly By _SearchToDateInputButton = By.XPath("//*[@id = 'calToDate']");
        private readonly By _SearchEmpNameInputButton = By.XPath("//*[@id = 'leaveList_txtEmployee_empName']");
        private readonly By _SearchButton = By.XPath("//*[@id = 'btnSearch']");
        private readonly By _AllCheckbox = By.XPath("//*[@id='leaveList_chkSearchFilter_checkboxgroup_allcheck']");
        private readonly By _NameIsVisible = By.XPath("//*[text()='Mykhailo Hordun']");

        private const string _login = "Admin";
        private const string _password = "admin123";
        private const string _name = "Kanye";
        private const string _Currency = "USD - United States Dollar";
        private const string _min = "100";
        private const string _max = "379";

        private const string _fromData = "2021-12-08";
        private const string _toData = "2021-12-08";

        public bool ElementDisplayed(By locator)
        {
            return driver.FindElement(locator).Displayed;
        }

        public BrowserStepDef(ScenarioContext scenarioContext) {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am on Pay Grades page")]
        public void GivenIAmOnPayGradesPage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            var login = driver.FindElement(_LoginInputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_PasswordInputButton);
            password.SendKeys(_password);

            var submit = driver.FindElement(_SubmitButton);
            submit.Click();

            var openAdminMenu = driver.FindElement(_GoToAdminButton);
            openAdminMenu.Click();

            var Job = driver.FindElement(_Job);
            Job.Click();

            var PayGrades = driver.FindElement(_PayGrades);
            PayGrades.Click();
        }

        [When(@"I click Add button")]
        public void WhenIClickAddButton()
        {
            var Add = driver.FindElement(_AddButton);
            Add.Click();
        }

        [When(@"I enter <name>")]
        public void WhenIEnterName()
        {
            var name = driver.FindElement(_NameInputButton);
            name.SendKeys(_name);
        }

        [When(@"I click Save button to save Pay Grade name")]
        public void WhenIClickSaveButtonToSavePayGradeName()
        {
            var save = driver.FindElement(_SaveButton);
            save.Click();
        }

        [When(@"I click Add button in Assigned Currencies")]
        public void WhenIClickAddButtonInAssignedCurrencies()
        {
            var AddCurrency = driver.FindElement(_AddCurrencyButton);
            AddCurrency.Click();
        }

        [When(@"I enter  <Currency>, <minSal>, <maxSal>")]
        public void WhenIEnterCurrencyMinSalMaxSal()
        {
            var Currancy = driver.FindElement(_CurrencyInputButton);
            Currancy.SendKeys(_Currency);

            var minSal = driver.FindElement(_MinInputButton);
            minSal.SendKeys(_min);

            var maxSal = driver.FindElement(_MaxInputButton);
            maxSal.SendKeys(_max);
        }

        [When(@"I click Save button to save currency")]
        public void WhenIClickSaveButtonToSaveCurrency()
        {
            var saveCurrency = driver.FindElement(_SaveCurrencyButton);
            saveCurrency.Click();
        }

        [When(@"I go to Pay Grades page")]
        public void WhenIGoToPayGradesPage()
        {
            var BacktoJob = driver.FindElement(_Job);
            BacktoJob.Click();

            var BackToPayGrades = driver.FindElement(_PayGrades);
            BackToPayGrades.Click();
        }

        [Then(@"I am observing my record with Pay Grade equal to <name> and currency equal to <Currency>")]
        public void ThenIAmObservingMyRecordWithPayGradeEqualToNameAndCurrencyEqualToCurrency()
        {
            Assert.AreEqual(ElementDisplayed(_Kanye), true);
            Assert.AreEqual(ElementDisplayed(_USD), true);
        }

        [When(@"I click in checkbox on the left of <name>")]
        public void WhenIClickInCheckboxOnTheLeftOfName()
        {
            var CheckBox = driver.FindElement(_CheckboxButton);
            CheckBox.Click();
        }

        [When(@"I click Delete button")]
        public void WhenIClickDeleteButton()
        {
            var Delete = driver.FindElement(_DeleteButton);
            Delete.Click();
        }

        [When(@"I click Ok button in dialog box")]
        public void WhenIClickOkButtonInDialogBox()
        {
            var Ok = driver.FindElement(_OkButton);
            Ok.Click();
        }

        [Then(@"I am observing Pay Grade table without my record")]
        public void ThenIAmObservingPayGradeTableWithoutMyRecord()
        {
            Assert.IsEmpty(driver.FindElements(By.XPath("//tr//td//a[text()='Kanye']//..//..//td//input")));
        }
        [When(@"I click PIM button")]
        public void WhenIClickPIMButton()
        {
            var PIM = driver.FindElement(_PIMButton);
            PIM.Click();
        }

        [When(@"I click Add Employee button")]
        public void WhenIClickAddEmployeeButton()
        {
            var addEmploee = driver.FindElement(_AddEmloyeeButton);
            addEmploee.Click();
        }

        [When(@"I enter <FirstName>, <LastName>")]
        public void WhenIEnterFirstNameLastName()
        {
            var firstName = driver.FindElement(_FirstNameInputButton);
            firstName.SendKeys("Mykhailo");

            var lastName = driver.FindElement(_LastNameInputButton);
            lastName.SendKeys("Hordun");
        }

        [When(@"I click save button to save Employee")]
        public void ThenIClickSaveButtonToSaveEmployee()
        {
            var save = driver.FindElement(_SaveButton);
            save.Click();
        }
        [When(@"I click Leave button")]
        public void WhenIClickLeaveButton()
        {
            var LeaveButton = driver.FindElement(_LeaveButton);
            LeaveButton.Click();
        }

        [When(@"I click Assign Leave button")]
        public void WhenIClickAssignLeaveButton()
        {
            var LeaveAssignButton = driver.FindElement(_LeaveAssignButton);
            LeaveAssignButton.Click();
        }

        [When(@"I enter <Employee Name>")]
        public void WhenIEnterEmployeeName()
        {
            var EmpName = driver.FindElement(_EmplNameInputButton);
            EmpName.SendKeys("Mykhailo Hordun");
        }

        [When(@"I choose Leave Type\\")]
        public void WhenIChooseLeaveType()
        {
            var LeaveType = driver.FindElement(_LaeveTypeButton);
            SelectElement type = new SelectElement(LeaveType);
            type.SelectByIndex(2);
        }

        [When(@"I choose dates")]
        public void WhenIChooseDates()
        {
            var fromData = driver.FindElement(_FromDateInputButton);
            fromData.Clear();
            fromData.SendKeys(_fromData);

            var toData = driver.FindElement(_ToDateInputButton);
            toData.Clear();
            toData.SendKeys(_fromData);
            toData.SendKeys(Keys.Enter);
            Thread.Sleep(5000);

        }

        [When(@"I click Asign button")]
        public void WhenIClickAsignButton()
        {
            var assignBtn = driver.FindElement(_AssignButton);
            assignBtn.Click();
        }

        [When(@"I click on Leave List button")]
        public void WhenIClickOnLeaveListButton()
        {
            var leaveLlist = driver.FindElement(_LeaveListButton);
            leaveLlist.Click();
        }

        [When(@"I search <Employee Name>")]
        public void WhenISearchEmployeeName()
        {
            Thread.Sleep(5000);
            var SearchName = driver.FindElement(_SearchEmpNameInputButton);
            SearchName.SendKeys("Mykhailo Hordun");
        }

        [When(@"I click All checkbox")]
        public void WhenIClickAllCheckbox()
        {
            var allCheckbox = driver.FindElement(_AllCheckbox);
            allCheckbox.Click();
        }


        [When(@"I search dates")]
        public void WhenISearchDates()
        {
            var SearchFromData = driver.FindElement(_SearchFromDateInputButton);
            SearchFromData.Clear();
            SearchFromData.SendKeys(_fromData);
            var SearchToData = driver.FindElement(_SearchToDateInputButton);
            SearchToData.Clear();
            SearchToData.SendKeys(_toData);
        }

        [When(@"I click Search button")]
        public void WhenIClickSearchButton()
        {
            var searchButton = driver.FindElement(_SearchButton);
            searchButton.Click();
        }


        [Then(@"I am observing")]
        public void ThenIAmObserving()
        {
            Assert.AreEqual(ElementDisplayed(_NameIsVisible), true);
        }

    }
}