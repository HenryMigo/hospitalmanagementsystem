using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BedsideMonitoring;

namespace BedsideMonitoringTests
{
    [TestClass]
    public class AlarmTest
    {
        Alarm testAlarm = new Alarm();

        [TestMethod]
        public void MuteAlarmTestWhenAlarmIsMutable()
        {
            int patientCurrentVital = 22;
            int patientVitalMinLimit = 10;
            int patientVitalMaxLimit = 24;
            testAlarm.TriggerAlarm();
            testAlarm.MuteAlarm(patientCurrentVital, patientVitalMinLimit, patientVitalMaxLimit);
            Assert.AreEqual(false, testAlarm.AlarmCurrentlyTriggered);
        }

        [TestMethod]
        public void MuteAlarmTestWhenAlarmIsNotMutable()
        {
            int patientCurrentVital = 26;
            int patientVitalMinLimit = 10;
            int patientVitalMaxLimit = 24;
            testAlarm.TriggerAlarm();
            testAlarm.MuteAlarm(patientCurrentVital, patientVitalMinLimit, patientVitalMaxLimit);
            Assert.AreEqual(true, testAlarm.AlarmCurrentlyTriggered);
        }
    }
}
