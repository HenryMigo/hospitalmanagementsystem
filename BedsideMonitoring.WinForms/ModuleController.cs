﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BedsideMonitoring.WinForms
{
    abstract class ModuleController
    {
        protected int patientVital;

        public abstract int ReadPatientVital();
    }

    class HeartRate : ModuleController
    {
        private static readonly string moduleName = "Heart Rate";

        public static string ModuleName()
        {
            return moduleName;
        }

        public override int ReadPatientVital()
        {
            return patientVital;
        }
    }

    class Temperature : ModuleController
    {
        private static readonly string moduleName = "Temperature";

        public static string ModuleName()
        {
            return moduleName;
        }

        public override int ReadPatientVital()
        {
            return patientVital;
        }
    }

    class BreathingRate : ModuleController
    {
        private static readonly string moduleName = "Breathing Rate";

        public static string ModuleName()
        {
            return moduleName;
        }

        public override int ReadPatientVital()
        {
            return patientVital;
        }
    }

    class BloodPressure : ModuleController
    {
        private static readonly string moduleName = "Blood Pressure";

        public static string ModuleName()
        {
            return moduleName;
        }

        public override int ReadPatientVital()
        {
            return patientVital;
        }
    }

    class ModuleControllerSubclassListing
    {
        public static List<string> GetAllInheritingClassesModuleController()
        {
            Type objType = typeof(ModuleController);
            var List = GetSubtypesOfSuperClass(Assembly.GetAssembly(objType), objType);
            List<string> elementList = new();

            for (int i = 1; i < List.Count(); i++)
            {
                var elementName = List.ElementAt(i).GetMethod("ModuleName").Invoke(null, null);
                elementList.Add(elementName.ToString());
            }
            return elementList;
        }

        private static IEnumerable<Type> GetSubtypesOfSuperClass(Assembly assembly, Type parent)
        {
            return assembly.GetTypes()
                           .Where(type => parent.IsAssignableFrom(type));
        }
    }
}