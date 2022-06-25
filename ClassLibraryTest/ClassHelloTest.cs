using ClassLibrary;
using FluentAssertions;
using Machine.Specifications;


namespace ClassLibraryTest
{
    [Subject(typeof(ClassHello))]
    public class ClassHelloTest
    {
        static ClassHello subject;
        static string message;

        Establish context = () =>
            subject = new ClassHello();

        Because of = () =>
            message = subject.GetMessage();

        It should_be_hello_world = () =>
            message.Should().Be("Hello World!");
    }
}
