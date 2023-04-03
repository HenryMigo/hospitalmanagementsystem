using BedsideMonitoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BedsideMonitoringTests
{
    [TestClass]
    public class StaffTest
    {
        //Act
        readonly MedicalStaff testStaff = new();

        private void RegisterAndDeregister()
        {
            testStaff.RegisterOnCallMedicalStaff();
            testStaff.DeregisterOnCallMedicalStaff();
        }

        [TestMethod]
        public void TestDeregisterOnCallMedicalStaffIfTimeWorkedMoreThanWorkHourPerDay()
        {
            //Arrange
            testStaff.WorkHourPerDayMedicalStaff = new TimeSpan(6, 0, 0);
            testStaff.ShiftStartMedicalStaff = new DateTime(2015, 10, 14, 15, 00, 00);
            testStaff.ShiftEndMedicalStaff = new DateTime(2015, 10, 14, 22, 00, 00);
            RegisterAndDeregister();
            //Assert
            Assert.AreEqual(false, testStaff.OnCallMedicalStaff);
        }

        [TestMethod]
        public void TestDeregisterOnCallMedicalStaffTimeWorkedLessThanWorkHourPerDay()
        {
            testStaff.WorkHourPerDayMedicalStaff = new TimeSpan(6, 0, 0);
            testStaff.ShiftStartMedicalStaff = new DateTime(2015, 10, 14, 15, 00, 00);
            testStaff.ShiftEndMedicalStaff = new DateTime(2015, 10, 14, 19, 00, 00);
            RegisterAndDeregister();
            //Assert
            Assert.AreEqual(true, testStaff.OnCallMedicalStaff);
        }

        [TestMethod]
        public void TestDeregisterOnCallMedicalStaffTimeWorkedEqualToWorkHourPerDay()
        {
            //Arrange
            testStaff.WorkHourPerDayMedicalStaff = new TimeSpan(6, 0, 0);
            testStaff.ShiftStartMedicalStaff = new DateTime(2015, 10, 14, 15, 00, 00);
            testStaff.ShiftEndMedicalStaff = new DateTime(2015, 10, 14, 21, 00, 00);
            RegisterAndDeregister();
            //Assert
            Assert.AreEqual(false, testStaff.OnCallMedicalStaff);
        }
    }
}
