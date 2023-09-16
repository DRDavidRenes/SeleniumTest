# SeleniumTest

Con este sencillo ejemplo, muestro el funcionamiento de una herramienta muy poderosa. Selenium!
Con ella no solo podrás automatizar pruebas unitarias,etc... sino, automatizar todo tipo de tareas en la web.

El ejemplo consiste en abrir una URL, escribir automáticamente para buscar un enlace, abrirlo y reproducir un video.
Con ello aprendemos el uso de los localizadores, fundamental en Selenium. 
Echa un vistazo al código!


Está en hecho en Visual Studio en C#, y para hacer un ejecutable del programa solo tienes que hacer un script en un archivo .bat.
Te muestro como;

@echo off                          
cd "C:\Users\deivi\source\repos\AppSelenium\bin\Debug"  
start /min "" cmd /c "Appselenium.exe"                  
exit


1.-@echo off: Esta línea desactiva la visualización de los comandos en la ventana de la consola mientras se ejecuta el script. Cuando se establece en off, no verás los comandos que se ejecutan en la pantalla mientras el script se ejecuta.

2.-cd "C:\Users\deivi\source\repos\AppSelenium\bin\Debug": Esta línea cambia el directorio actual (current directory) a la ubicación especificada, que es "C:\Users\deivi\source\repos\AppSelenium\bin\Debug". En otras palabras, establece la ubicación actual del script en esa carpeta.

3.-start /min "" cmd /c "Appselenium.exe": Esta línea inicia un nuevo proceso de línea de comandos (cmd) de forma minimizada (la ventana de la consola será minimizada, es decir, no será visible). Luego, dentro de ese nuevo proceso de línea de comandos, se ejecuta el archivo ejecutable "Appselenium.exe".

start /min "" inicia un nuevo proceso minimizado.
cmd /c "Appselenium.exe" ejecuta el comando "Appselenium.exe" en ese nuevo proceso de línea de comandos.

4.-exit: Esta línea indica al script que debe cerrarse después de ejecutar los comandos anteriores. Es opcional en este caso, ya que el script se cerrará automáticamente una vez que el proceso "Appselenium.exe" finalice, pero se utiliza para garantizar que el script se cierre explícitamente.



