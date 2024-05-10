using Newtonsoft.Json;

namespace e_course_web.Service.Helpers
{
    public static class ConvertJsonHelper
    {
        // Convert object to JSON string
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        // Decode JSON string to object
        public static T FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
