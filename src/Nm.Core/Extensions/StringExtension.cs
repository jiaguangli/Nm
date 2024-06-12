using System.IO;

namespace Nm.Core.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);

        public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);

        public static bool IsFileLocked(this string filePath)
        {
            try
            {
                using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                return false;
            }
            catch (IOException)
            {
                return true;
            }
        }
    }
}