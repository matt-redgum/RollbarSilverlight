using System.Reflection;
using RollbarSilverlight.Serialization;
using System;

namespace RollbarSilverlight.Builders
{
    public static class NotifierModelBuilder
    {
        /// <summary>
        /// Creates a model representing this notifier binding itself.
        /// Will be reported as the assembly's name and currently compiled version.
        /// </summary>
        /// <returns></returns>
        public static NotifierModel CreateFromAssemblyInfo()
        {
            Assembly.GetExecutingAssembly();

            var ai = Assembly.GetExecutingAssembly();
            //Access the GetName method is SL is security critical
            //so we need to push to assembly name first
            var an = new AssemblyName(ai.FullName);

            return new NotifierModel(an.Name, an.Version.ToString());

        }
        
    }
}
