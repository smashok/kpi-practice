# Lab1
Lab1. Requirements of API. Tereshpolskyy Anton. IT-93.

Description of social network.
Models : Account and Post (допис)

### Signing up account

- Method : POST
- Params : { "Name", "E-mail", "Country", "Password" }
- Required : 
  +  Name : string
  +  Any existing account should not have this name.
  +  Name length = [6-30]
  +  E-mail : string
  +  Email = \_%@\_%.\_%   // syntax from sql wildcarts, where % - any number of characters, _ - any single characters. that means we need at least 1 symbol before @, at least 1 between @ and . and at least 1 after dot.
  + County : string
  + Country lebgth = [3-40]
  + Password : string, must contain number, low case letters, high case letters. Allowed only English alphabet and arabic numbers. Shouldn't be same as name.
  + Password lenght = [8-30]
- Success response : 201
- Error code : 400

### Updating password

- Method : PATCH
- Params : { "Current password", "New password" }
- Required :
  + New password : string, must contain number, low case letters, high case letters. Allowed only English alphabet and arabic numbers. Shouldn't be same as name.
  + Current password : string, must be equal to the password of the account
  + New password lenght = [8-30]
- Success response : 200
- Error response : 400

### Updating name

- Method : PATCH
- Params : { "Password", "New name" }
- Required :
  + Name : string
  + New name lenght = [6-30]
  + Password : string, must be equal to the password of the account
- Success response : 204
- Error response : 400

### Publishing new post

- Method : POST
- Params : {"Post title", "Publisher id", "Post text"}  
- Required : 
  + Post title : string, lenght = [6-50]
  + Publisher id : int, value >= 0
  + Post text : string, lenght = [1-1600]
- Success code : 200
- Error Code : 400

### Update post

- Method : PATCH
- Params : {"Publisher id", "Post id", "New post text" }
- Required : 
  + Publisher id : int, Publisher id >= 0
  + Post id : int, value >= 0
  + New post text : string, lenght = [1-1600] 
- Success code : 200
- Error Code : 400

### Liking post

- Method : PATCH
- Params : {"Post Id", "Publisher id", "Liker id" }
- Required : 
  + Post id : int, value >= 0
  + Publisher id : int, value >= 0
  + Liker id : int, value >= 0
- Success code : 200
- Error Code : 400

### Follow account
- Method : PATCH
- Params : {"Account id", "Follower id"}
- Required :
  + Account id : int, value >=0 
  + Follower id : int, value >= 0
- Success code : 200
- Error code : 400

### Get account info

- Method : GET
- Params : { "Account id" } 
- Required :
  + Account id : int, value > 0
- Success code : 200
- Content : 
  {
  "Account name" : "name",
  "Account posts IDs" : [1,4,9],
  "Account follows IDs" : [1,4,9],
  "Country" : "country",
  "E-mail" : "e-mail"
  }
- Error code : 404


### Get post info

- Method : GET
- Params : {"Publisher id", "Post id"}
- Required :
  + Publisher id : int, value > 0
  + Post id : int, value > 0
- Success code : 200
- Content : { "Post title" : "Title", "Liked by IDs": [324, 543, 23523], "Post text" : "Template motivational phrase", PostCreateDateTime : "17-32-08-21-03-2021" }
- Error code : 404

### Delete an account

- Method : DELETE
- Params : { "Account id" }
- Required : Account id is interger more or equals zero
- Success code : 200
- Error code : 404

