# API Calls

## GET api/PersonInterest/GetAllPersons
**Respons**
```
[
  {
    "id": 1,
    "name": "Kalle Anka",
    "telephoneNumber": "070-1234567"
  },
  {
    "id": 2,
    "name": "Långben",
    "telephoneNumber": "070-1234567"
  },
  {
    "id": 3,
    "name": "Musse Pigg",
    "telephoneNumber": "070-1234567"
  }
]

```
## GET api/PersonInterest/GetPersonInterests/1
**Respons**
```
[
  {
    "id": 1,
    "title": "Naturfotografi",
    "description": "Naturfotografi är ett brett spektrum av fotografier som tagits utomhus med naturliga motiv.",
    "personId": 1
  },
  {
    "id": 3,
    "title": "Campa",
    "description": "Att åka på husvagnssemester och campa",
    "personId": 1
  }
]

```

## GET api/PersonInterest/GetPersonLinks/2
**Respons**
```
[
  {
    "id": 2,
    "linkAdress": "www.nba.com",
    "interestId": 2
  },
  {
    "id": 3,
    "linkAdress": "www.basket.se",
    "interestId": 2
  }
]

```
## POST api/PersonInterest/CreateInterest?personId=3&title=Test%20Interest&description=Det%20h%C3%A4r%20%C3%A4r%20bara%20ett%20test

**Parameters** <br>
-personId (int) <br>
-title (string) <br>
-description (string) <br>

**Respons** <br>
The request will create a new interest for the specified person. No response body is returned. Ensure that the request is successful (HTTP status code 200) for the interest to be created successfully.

## POST api/PersonInterest/CreateLink?interestId=5&linkAdress=https%3A%2F%2Fsv.wikipedia.org%2Fwiki%2FTest

**Parameters** <br>
-interestId (int) <br>
-linkAdress (string) <br>

**Respons** <br>
The request will create a new link for the specified interest. No response body is returned. Ensure that the request is successful (HTTP status code 200) for the link to be created successfully.

