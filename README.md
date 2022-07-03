# Ejemplo de WebApi Relacional
---
# Indice
* [Imagen base datos relacionada](#Base-Datos)
* [clases/entidades para relacion de alumnos a colegios](#Entidades)
* [Ejemplo de como consumir la api (Elmer xd)](#ConsumiendoAPI)
* [Nota (Importante ⚠️)](#nota)

---
# Base-Datos

![DataBaseDiagram](https://i.ibb.co/RNt90rz/Screenshot-2022-06-30-220231.png)
---
Notese en la base de datos que aparte del tipo y el animal (que casi nos da una embolia) se ha agregado dos
mas que si bien no tienen nada que ver con el nombre de la base de datos es para demostracion 
que no estamos utilizando guiones bajos y el nombre del indice o llave foranea del alumno se llama de la misma
manera que como esta la llave primaria en la tabla colegio

---
# Entidades
![Colegio](https://i.ibb.co/d2TNz73/Screenshot-2022-06-30-220844.png)
![Alumno](https://i.ibb.co/Swy5K20/Screenshot-2022-06-30-220956.png)

---
# ConsumiendoAPI
Para poder consumir la API basicamente solo se hizo un cambio 
en el archivo StartUp.cd
![StartUp.cs](https://i.ibb.co/sbjXfzj/Screenshot-2022-07-02-182622.png)

Luego en un archivo .html solo vamos a colocar lo siguiente (no tiene diseños 😆)
![htmlForm](https://i.ibb.co/pd8TCXJ/Screenshot-2022-07-02-183040.png)

No genera el codigo aletorio al final asi que lo podes modificar para que lo haga en esa parte
este es el resultado
![resultado](https://i.ibb.co/vc8ZXnB/Screenshot-2022-07-02-183320.png)

---
# nota
1) Siempre recuerden que para poder guardar un dato relacionado debe de existir este mismo en la base de datos
2) No olviden registrar estas dos nuevas entidades en el contexto de la base de datos
3) La base de datos solo tiene las tablas tipo y animal traten de hacer las otras dos de colegio y alumno y nos vemos el lunes
4) Sorry por el desmadre compañeros xd

