# libmanager_boxing-automation
## Türkçe açıklaması için OkuBeni.md ye bakınız
## Explanation
Made using C # programming language with layered architecture. Access database is used. The following requests are made in the frame. Comment lines in the program are in Turkish.

## Wants
 - 1) Layered Architecture to be used.
 - 2) Add and delete students and books.
 - 3) Give the book and book it back.
 - 4) The book which the student has received so far and is currently in the hands can be viewed.
 - 5) In the list of books delayed by the student, it is written as red.
 - 6) If there is two days left for the delivery of the book, the yellow marker is for warning purposes.
 - 7) Delivered books will be marked in green.
 - 8) Turquoise will be marked with 2 days until delivery.
 - 9) Book taking and return operations will take place at the historical level.
 - 10) It is the book and according to the name of the book information can be reached.
 - 11) A 1 pound penalty will be written for each day of the book being delayed.
 - 12) All the books in the library, the books given to the student and the books which are ready to be given will be shown in graphic with Zedgrapgh **.

## Layers
### Entity Layer
This is where we create our Access tables in code and create the columns in it. In the code we created and encapsulated the variables that will come to these columns. We have made our classes public to provide access from other layers.
### Facade Layer
The layer in which SQL operations are performed. In this layer we do business with the entity layer and we need to add and call entity references to referances.
### Business Logic Layer
This is where we check the values ​​from the presentation layer and send them to the facade layer. Classes are public and the entity and facede layer are referenced and called.
### Presentations Layer
It is the layer that the user sees. We send the values ​​we take from Business Logic Layera. We need to refer and recall the other layers here.
