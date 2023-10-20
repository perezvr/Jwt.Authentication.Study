using System.Reflection;

namespace Jwt.Authentication.Study.Api.Tools.Extensions
{
    public static class TypeExtensions
    {
        public static string GetFullMethodName(this Type classType, string methodName)
        {
            MethodInfo? methodInfo = classType.GetMethod(methodName);

            if (methodInfo != null)
            {
                string methodNameFull = $"{classType.FullName}.{methodInfo.Name}";
                return methodNameFull;
            }

            return "UnknownMethod";
        }
    }
}
