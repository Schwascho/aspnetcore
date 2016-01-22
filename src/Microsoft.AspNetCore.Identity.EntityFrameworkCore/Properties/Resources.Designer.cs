// <auto-generated />
namespace Microsoft.AspNetCore.Identity.EntityFrameworkCore
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Identity.EntityFrameworkCore.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Role {0} does not exist.
        /// </summary>
        internal static string RoleNotFound
        {
            get { return GetString("RoleNotFound"); }
        }

        /// <summary>
        /// Role {0} does not exist.
        /// </summary>
        internal static string FormatRoleNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RoleNotFound"), p0);
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string ValueCannotBeNullOrEmpty
        {
            get { return GetString("ValueCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string FormatValueCannotBeNullOrEmpty()
        {
            return GetString("ValueCannotBeNullOrEmpty");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
