namespace Dotnet.Interview.Test.TestSupport;

/// <summary>
/// Do not change anything in this file
/// </summary>
public static class SerializedPayloads
{
    public const string CompanyFixtureOneTestThree = """
                                    { 
                                        "name": "ecointerview",
                                        "type": "Simple",
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
                                            "postalCode": "10021", 
                                            "countryCode": "CA"
                                        }
                                    }
                                    """;
  public const string CompanyFixtureOneTestFour = """
                                    { 
                                        "name": "ecointerview",
                                        "type": "Premium",
                                        "stockSymbol": "ECOW",
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
                                            "postalCode": "10021", 
                                            "countryCode": "CA"
                                        }
                                    }
                                    """;
  public const string CompanyFixtureOneTestFive = """
                                    { 
                                        "name": "ecointerview",
                                        "type": "Simple",
                                        "stockSymbol": "ECOW",
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
                                            "postalCode": "10021", 
                                            "countryCode": "CA"
                                        }
                                    }
                                    """;     

  public const string CompanyFixtureOneTestSix = """
                                    { 
                                        "name": "Test Six Company",
                                        "type": "Simple",
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
                                            "postalCode": "10021", 
                                            "countryCode": "US"
                                        }
                                    }
                                    """;              
    public const string CompanyFixtureOneTestSeven = """
                                    { 
                                        "name": "Test Six Company",
                                        "type": "Simple",
                                        "contacts": [
                                            {
                                            "firstName": "John",
                                            "lastName": "Smith",
                                            "age": 40,
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
                                            "postalCode": "10021", 
                                            "countryCode": "US"
                                        },
                                        "dateFounded": "1996-03-21T00:00:00+00:00"
                                    }
                                    """;                               
}