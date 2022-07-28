namespace RemoveDuplicates_Example
{
    public class RemoveDuplicates
    {
        public object[] RemoveDupsWithLinq(object[] items)
        {
            return items.Distinct().ToArray();
        }

        public object[] RemoveDups(object[] items)
        {
            var tempList = new List<object>();

            for (int i = 0; i < items.Length; i++)
            {
                if (!tempList.Contains(items[i]))
                    tempList.Add(items[i]);
            }

            return tempList.ToArray();
        }
    }
}
