namespace Classes_and_Inheritance
{
    internal class FileReader
    {
        internal string fileToString(string v)
        {
            // Provide an implementation for the fileToString method
            // e.g. read the contents of the file at the given path
            return System.IO.File.ReadAllText(v);
        }

        internal string FileToString(string v)
        {
            // You may also want to implement the FileToString method
            // depending on your use case.
            throw new NotImplementedException();
        }

        public List<string> CreateListFromString(string inputString)
        {
            List<string> outputList = new List<string>();

            // Split the input string into an array of strings, one for each line
            string[] lines = inputString.Split('\n');

            // Loop through each line and add it to the output list
            foreach (string line in lines)
            {
                outputList.Add(line.Trim()); // Trim the line to remove any leading/trailing whitespace
            }

            return outputList;
        }
    }
}

