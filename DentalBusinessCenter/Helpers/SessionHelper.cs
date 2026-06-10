namespace DentalBusinessCenter.Helpers
{
    public static class SessionHelper
    {
        public static string? GetUserId(IHttpContextAccessor accessor) =>
            accessor.HttpContext?.Session.GetString("UserId");

        public static string? GetUserRole(IHttpContextAccessor accessor) =>
            accessor.HttpContext?.Session.GetString("UserRole");

        public static string? GetUserFullName(IHttpContextAccessor accessor) =>
            accessor.HttpContext?.Session.GetString("UserFullName");

        public static string? GetDoctorId(IHttpContextAccessor accessor) =>
            accessor.HttpContext?.Session.GetString("DoctorId");

        public static string? GetUserRole(ISession session) =>
            session.GetString("UserRole");

        public static string? GetUserFullName(ISession session) =>
            session.GetString("UserFullName");

        public static int? GetDoctorId(ISession session)
        {
            var val = session.GetString("DoctorId");
            if (int.TryParse(val, out int id)) return id;
            return null;
        }

        public static int GetUserId(ISession session)
        {
            var val = session.GetString("UserId");
            if (int.TryParse(val, out int id)) return id;
            return 0;
        }
    }
}
