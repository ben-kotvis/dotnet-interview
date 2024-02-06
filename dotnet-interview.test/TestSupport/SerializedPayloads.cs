namespace dotnet_interview.test.TestSupport;

public static class SerializedPayloads
{
    public const string CompanyFixtureOneTestThree = """
                                    { 
                                    "name": "ecointerview",
                                        "stocksSymbol": "ECOW",
                                        "contacts": [
                                            {
                                            "firstName": "John",
                                            "lastName": "Smith",
                                            "age": 25,
                                            "phoneNumbers": [
                                                {
                                                "type": "home",
                                                "number": "213 525-1234"
                                                },
                                                {
                                                "type": "fax",
                                                "number": "646 525-4367"
                                                }
                                            ]
                                            }
                                        ],
                                        "address": {
                                            "streetAddress": "21 2nd Street",
                                            "city": "New York",
                                            "state": "NY",
                                            "postalCode": "10021"
                                        }
                                    }
                                    """;
}