Prettifying a JSON string in C#.NET

# Features

Convert JSON Strings to a Friendly Readable Format

## Usage

### Function reference

```cs
string jsonText = System.IO.File.ReadAllText("..\\..\\json_input.txt");
string jsonPrettifyingText = JsonHelper.FormatJson(jsonText);
System.IO.File.WriteAllText(@"..\\..\\json_output.txt", jsonPrettifyingText);
```

### Input: json_input.txt

```
{"firstName":"John","lastName":"Smith","isAlive":true,"age":27,"address":{"streetAddress":"21 2nd Street","city":"New York","state":"NY","postalCode":"10021-3100"},"phoneNumbers":[{"type":"home","number":"212 555-1234"},{"type":"office","number":"646 555-4567"},{"type":"mobile","number":"123 456-7890"}],"children":[],"spouse":null}
```

### Ouput: json_output.txt

```
{
    "firstName" : "John",
    "lastName" : "Smith",
    "isAlive" : true,
    "age" : 27,
    "address" : {
        "streetAddress" : "21 2nd Street",
        "city" : "New York",
        "state" : "NY",
        "postalCode" : "10021-3100"
    },
    "phoneNumbers" : [
        {
            "type" : "home",
            "number" : "212 555-1234"
        },
        {
            "type" : "office",
            "number" : "646 555-4567"
        },
        {
            "type" : "mobile",
            "number" : "123 456-7890"
        }
    ],
    "children" : [
        
    ],
    "spouse" : null
}
```
