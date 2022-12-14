# Foros 馃摉

## Objetivos 馃搵
Desarrollar un sistema, que permita la administraci贸n general de un Foro (de cara a los administradores): Usuarios Miembros, Administradores, Pregunta, Respuesta, MeGusta, etc., como as铆 tambi茅n, permitir a los usuarios puedan navegar el foro y realizar preguntas y/o respuestas.
Utilizar Visual Studio 2019 preferentemente y crear una aplicaci贸n utilizando ASP.NET MVC Core (versi贸n a definir por el docente 2.2 o 3.1).

<hr />

## Enunciado 馃摙
La idea principal de este trabajo pr谩ctico, es que Uds. se comporten como un equipo de desarrollo.
Este documento, les acerca, un equivalente al resultado de una primera entrevista entre el cliente y alguien del equipo, el cual relev贸 e identific贸 la informaci贸n aqu铆 contenida. 
A partir de este momento, deber谩n comprender lo que se est谩 requiriendo y construir dicha aplicaci贸n, 

Deben recopilar todas las dudas que tengan y evacuarlas con su nexo (el docente) de cara al cliente. De esta manera, 茅l nos ayudar谩 a conseguir la informaci贸n ya un poco m谩s procesada. 
Es importante destacar, que este proceso, no debe esperar a ser en clase; es importante, que junten algunas consultas, sea de 铆ndole funcional o t茅cnicas, en lugar de cada consulta enviarla de forma independiente.

Las consultas que sean realizadas por correo deben seguir el siguiente formato:

Subject: [NT1-<CURSO LETRA>-GRP-<GRUPO NUMERO>] <Proyecto XXX> | Informativo o Consulta

Body: 

1.<xxxxxxxx>

2.< xxxxxxxx>


# Ejemplo
**Subject:** [NT1-A-GRP-5] Agenda de Turnos | Consulta

**Body:**

1.La relaci贸n del paciente con Turno es 1:1 o 1:N?

2.Est谩 bien que encaremos la validaci贸n del turno activo, con una propiedad booleana en el Turno?

<hr />

### Proceso de ejecuci贸n en alto nivel 鈽戯笍
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/).
 - Adicionar todos los modelos dentro de la carpeta Models cada uno en un archivo separado.
 - Especificar todas las restricciones y validaciones solicitadas a cada una de las entidades. [DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1).
 - Crear las relaciones entre las entidades
 - Crear una carpeta Data que dentro tendr谩 al menos la clase que representar谩 el contexto de la base de datos DbContext. 
 - Crear el DbContext utilizando base de datos en memoria (con fines de testing inicial). [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-3.1), [Database In-Memory](https://docs.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=vs).
 - Agregar los DbSet para cada una de las entidades en el DbContext.
 - Crear el Scaffolding para permitir los CRUD de las entidades al menos solicitadas en el enunciado.
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Realizar un sistema de login con al menos los roles equivalentes a <Usuario Cliente> y <Usuario Administrador> (o con permisos elevados).
 - Si el proyecto lo requiere, generar el proceso de registraci贸n. 
 - Un administrador podr谩 realizar todas tareas que impliquen interacci贸n del lado del negocio (ABM "Alta-Baja-Modificaci贸n" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente> s贸lo podr谩 tomar acci贸n en el sistema, en base al rol que tiene.
 - Realizar todos los ajustes necesarios en los modelos y/o funcionalidades.
 - Realizar los ajustes requeridos del lado de los permisos.
 - Todo lo referido a la presentaci贸n de la aplicai贸n (cuestiones visuales).
 
<hr />

## Entidades 馃搫

- Miembro
- Administrador
- Categoria
- Entrada
- Pregunta
- Respuesta
- ~Like (MeGusta)~ Reaccion


`Importante: Todas las entidades deben tener su identificador unico. Id o <ClassNameId>`

`
Las propiedades descriptas a continuaci贸n, son las minimas que deben tener las entidades. Uds. pueden agregar las que consideren necesarias.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como as铆 tambi茅n las restricciones.
`

**Usuario** 馃煝Cambio de nombre de la entidad Administrador.
```
- UserName 馃煝Creacion de este nuevo atributo.
- Nombre
- Apellido
- Email
- FechaAlta
- Password
```

**Miembro** 馃煝Se elimina los atributos(Nombre , Apellido, Email, FechaAlta, Password) generales que se compartian entre administrado miembro y se pasan a la entidad Usuario
```
- Telefono
- Entradas
- Preguntas
- Respuestas
- PreguntasYRespuestasQueMeGustan
```

**Categoria**
```
- CategoriaId 馃煝 Se agrega campo <ClassNameId> como identificador de la clase	
- Nombre
- Entradas
```
	
**Entrada**
```
- EntradaId     馃煝 Se agrega campo <ClassNameId> como identificador de la clase
- Titulo	
- Fecha         
- Categoria
- Miembro
- Preguntas
- Privada
- MiembrosHabilitados
```

**Pregunta**
```
- PreguntaId   馃煝 Se agrega campo <ClassNameId> como identificador de la clase (pendiente revisar por Mateo)
- Descripcion  
- Entrada
- Respuestas
- Miembro
- Fecha        
- Activa
```

**Respuesta**
```
- RespuestaId     馃煝 Se agrega campo <ClassNameId> como identificador de la clase (pendiente revisar por Mateo)
- Descripcion   
- Pregunta
- Miembro
- Fecha         
- Reacciones (colecci贸n de Likes, "MeGusta")
```


**Reaccion** 馃煝Se reemplaza nombre de  entidad Like por Reaccion
```
- ReaccionId     馃煝 Se agrega campo <ClassNameId> como identificador de la clase
- Fecha
- MeGusta
- Respuesta
- Miembro
```
**ErrorMsg** 馃煝 Se agrega una clase Helpers para definir los mensajes de error para uso de validaciones de todas las clases que lo requieran

**NOTA:** aqu铆 un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Caracteristicas y Funcionalidades 鈱笍
`Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implicito el no tener que soportar alguna de estas acciones.`

**Administrador**
- Un administrador, solo puede crear nuevas categorias.
- Sacar un listado de cantidad de Entradas por categorias.
- Los administradores del Foro, deben ser agregados por otro Administrador.
	- Al momento, del alta del Administrador, se le definir谩 un username y password.
    - Tambi茅n se le asignar谩 a estas cuentas el rol de Administrador.

**Miembro**
- Puede auto registrarse.
- La autoregistraci贸n desde el sitio, es exclusiva para los usuarios miembros. Por lo cual, se le asignar谩 dicho rol.
- Los miembros pueden navegar por el foro.
- Pueden crear Entradas, y automaticamente deber谩n generar una pregunta.
    - Pueden desactivar una pregunta en cualquier momento. Si est谩 inactiva, no se dejar谩 de ver, solo impedir谩 que carguen nuevas respuestas otros miembros.
    - No se puede cargar una respuesta de una pregunta del mismo miembro. Esta acci贸n, debe estar deshabilitada.
- Puede crear nuevas categorias.
    - Antes de crearla, se le propondr谩 un listado de categorias ya existentes en orden alfabetico.
- A cualquier respuesta, un miembro (que no es el autor de la respuesta), puede poner Like (MeGusta), Dislike (NoMeGusta) o resetearlo (Quita la reacci贸n a dicha respuesta).

**Reaccion**
- La reacci贸n a una respuesta ser谩 validandola con las 3 posibilidades.
- Al quitar la reacci贸n, no se desea guardar registro previo de la misma.
    - Un miembro, solo puede quitar las reacciones que uno mismo ha cargado.

**Entrada**
- Al generar una entrada por un miembro, quedar谩n los datos b谩sicos asignados, como ser fecha, el miembro que la cre贸, etc.
    - La categoria puede ser una existente o una nueva que quiera crear en el momento.
- La entrada, crear谩 junto con est谩 la primer pregunta, que tambi茅n, ser谩 este miembro el due帽o.
    - Las entradas, listar谩n las preguntas en orden cronologico ascendente.
    - Estas preguntas, mostrar谩n al costado la cantidad de respuestas que recibieron.
- La entrada puede ser privada, en tal caso, se listar谩 en el foro, con su titulo, pero solo miemrbros habilitados, podr谩n acceder a las preguntas y respuestas para interactuar.
    - El creador de la entrada, no necesita ser habilitado explicitamente.
    - Los miembros no habilitados pueden solitiar que se los habilite.
    - Un miembro autor de la entrada, podr谩 ver un listado de miembros que quieren ser habilitados, y habilitarlos uno por uno.

**Pregunta**
- Mientras que una pregunta est茅 activa, otros miembros, podr谩n dar respuestas a las preguntas.
- La entrada, puede tener m谩s preguntas del mismo miembro, como asi tambi茅n, recibir m谩s preguntas de otros miembros.
- Se visualizar谩 las respuestas en orden cronol贸gico ascendente, al acceder a cada pregunta.
    - La respuesta con m谩s likes, se deber谩 destacar visualmente. Ejemplo, en un recuadro verde. 
    - La respuesta con m谩s dislikes, se deber谩 destacar visualmente. Ejemplo, en un recuadro rojo. 

**Respuesta**
- Las respuestas ser谩 cargadas por miembros, que no son los creadores de la pregunta.
- Podr谩n recibir reacciones.

**Reacciones**
- Las reacciones, acerca de las respuestas, no pueden ser realizadas por los mismos autores de las respuestas. 


**Aplicaci贸n General**
- El foro, mostrar谩 los encabezados en la home:
    - Un listado de las ultimas 5 entradas cargadas m谩s recientemente. 
    - Un top 5, de Entradas con m谩s preguntas y respuestas.
    - Un top 3, de los miembros con m谩s entradas cargadas en el ultimo mes. 
- Se debe ofrecer tambi茅n, navegaci贸n por categorias. 
- Los miembros no pueden eliminar las entradas, ni deshabilitarse.
- Solo los administradores pueden eliminar entradas, con sus preguntas y respuestas, en caso de que estas tengan contenido inapropiado. 
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo.

