# Heladeria-Cafeteria Kirschen

Sistema para la heladería-cafetería Kirschen que administra las ventas de sus productos, así como también el control de stock, dinero en caja, e informes de ventas.

## Tecnologías necesarias

Para el desarrollo del sistema, se debe tener instalado:
  + Visual Studio 2015 Community Edition.
  + Cliente de Control de versiones GIT: [Link de descarga](https://git-scm.com/download/win).
  + SQL Server 2014: [Link de descarga](https://www.microsoft.com/en-US/download/details.aspx?id=42299).
    + Click en Descargar.
    + Seleccionar *Express* y *MgmtStudio*, la versión correspondiente (32 o 64 bits) y click en Siguiente.

## Instalación local del proyecto (se realiza sólo una vez)
  + Crear una carpeta vacía donde se alojará el proyecto (preferentemente con nombre *HeladeriaCafeteriaKirschen*).
  + Abrir la carpeta, botón derecho en algún lugar vacío dentro de la misma, y click en *Git Bash Here*.
  + Si es la primera vez que se utiliza git en el equipo, cuando se abre la consola se deben ingresar el nombre de usuario y email, con los siguientes comandos:
    + ```git config --global user.name "NOMBRE DE USUARIO"```
    + ```git config --global user.email "EMAIL"```
  + Se debe clonar el repositorio. Cuando se abre la consola, ejecutar el comando:
    + ``` git clone https://github.com/SCandelieri/HeladeriaCafeteriaKirschen.git ```
  + Una vez clonado, abrir Visual Studio, e ir a **File -> Open -> Project/Solution...**
  + Se debe abrir la solución. Una solución de Visual Studio es un archivo de extensión .sln que se encarga de contener todos los proyectos y configuraciones. Elegir el archivo *HeladeriaCafeteriaKirschen.sln* ubicado en la carpeta raíz.
  + Una vez abierta la solución, abrir el archivo *.gitignore* ubicado en la carpeta *Solution Items*.
  + Agregar la siguiente línea al archivo *.gitignore* y guardar los cambios:
    + ``` Presentacion/App.config ```
  + Abrir el archivo *App.config* ubicado en el proyecto *Presentacion* y en el elemento connectionStrings, cambiar el texto **WKS583L** por el nombre de su PC.
  + Guardar los cambios.
  + Ejecutar el siguiente comando en *Git Bash*:
	+ ``` git rm -r --cached . ```
  + Hacer click en **Start** (o **F5**).
  + Una vez compilado, se debería ver en pantalla una ventana vacía, en blanco, con el nombre *Heladería-Cafetería Kirschen*.

## Guardar cambios en repositorio
  + Cada vez que se realiza un cambio importante en el proyecto, se debe realizar un commit. Representa un punto al que se puede volver en caso de que el proyecto se rompa. Se pueden realizar tantos commits como se deseen antes de subir los cambios al repositorio en la nube.
  + Para ver los cambios realizados en el proyecto, ejecutar el comando **git status**. Aparecerán el nombre de los archivos modificados, agregados o eliminados.
  + Se puede decidir qué cambios incluir en el commit, ejecutando **git add** seguido del nombre del archivo. Si se quieren incluir todos los cambios, ejecutar el comando:
    + ``` git add . ```
  + Una vez elegidos qué cambios incluir, se realiza el commit, que incluye un mensaje en infinitivo que describe brevemente los cambios que se realizaron. Ejecutar el siguiente comando:
    + ``` git commit -m "MENSAJE" ```
  + Cuando ya se realizaron todos los commits necesarios, se suben a la nube con el comando:
    + ``` git push ```
