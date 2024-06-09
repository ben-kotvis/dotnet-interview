using Dotnet.Interview.Model;

namespace Dotnet.Interview.Test.TestSupport;

/// <summary>
/// Do not change anything in this file
/// </summary>
public static class TestData
{
    public static Company TestSevenCompany
    {
        get
        {

            return new Company()
            {
                Name = "ecointerview",
                Type = "Simple",
                Contacts = [
                                                    new Contact(){
                                            FirstName = "John",
                                            LastName = "Smith",
                                            Age = 25,
                                            PhoneNumbers = [
                                                new PhoneNumber(){
                                                Type = "home",
                                                Number = "213 525-1234"
                                                },
                                                new PhoneNumber() {
                                                Type = "fax",
                                                Number = "646 525-4367"
                                                }
                                            ]
                                            }
                                                ],
                Address = new Address()
                {
                    StreetAddress = "21 2nd Street",
                    City = "New York",
                    State = "NY",
                    PostalCode = "10021",
                    CountryCode = "CA"
                }
            };
        }
    }
}