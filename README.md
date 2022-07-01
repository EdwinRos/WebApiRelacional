# Ejemplo de WebApi Relacional
---
##Indice
* [Imagen base datos relacionada](#Base-Datos)
* [clases/entidades para relacion de alumnos a colegios](#Entidades)
* [Nota](#nota)

---
#Base-Datos

![DataBaseDiagram](https://i.ibb.co/RNt90rz/Screenshot-2022-06-30-220231.png)
---
Notese en la base de datos que aparte del tipo y el animal (que casi nos da una embolia) se ha agregado dos
mas que si bien no tienen nada que ver con el nombre de la base de datos es para demostracion 
que no estamos utilizando guiones bajos y el nombre del indice o llave foranea del alumno se llama de la misma
manera que como esta la llave primaria en la tabla colegio

---
#Entidades
![Colegio](https://i.ibb.co/d2TNz73/Screenshot-2022-06-30-220844.png)
![Alumno](https://i.ibb.co/Swy5K20/Screenshot-2022-06-30-220956.png)

---
#nota
1) Siempre recuerden que para poder guardar un dato relacionado debe de existir este mismo en la base de datos
2) No olviden registrar estas dos nuevas entidades en el contexto de la base de datos
3) Sorry por el desmadre compañeros xd


