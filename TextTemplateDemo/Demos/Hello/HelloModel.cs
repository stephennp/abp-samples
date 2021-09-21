namespace TextTemplateDemo.Demos.Hello
{
    public class HelloModel
    {
        public string Name { get; set; }
        public Report Report { get; set; }
    }

    public class Report
    {
        public string Name { get; set; }
        public SubjectProperty SubjectProperty { get; set; }
    }

    public class SubjectProperty
    {
        public string Name { get; set; }
        public string StreetAddressLine1 { get; set; }
    }
}