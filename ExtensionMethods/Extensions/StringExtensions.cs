namespace System {
    static class StringExtensions {
        public static string Cut(this String thisObj, int value) {
            if (thisObj.Length <= value) {
                return thisObj;
            }

            return thisObj.Substring(0, value) + "...";
        }
    }
}
