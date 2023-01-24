# HibiscusJameicaStarter
Executable starts the hibiscus banking software from local pc or samba network path. In my case i sync the whole "banking" folder between my NAS and the local PC. If i want to start the tool directly from PC or via SAMBA (network drive) i only have to start the "StartJameica.exe" now.

All you have to do is to place the "StartJameica.exe" next to the "jameica-win64.exe".
The ".jameica" user folder is next to the "jameica" tool folder.

+--banking
+---.jameica
|   +---cfg 
|   +---hibiscus
|   +---plugins
\---jameica
    |   COPYING
    |   jameica-win64.exe
    |   jameica-win64.jar
    |   jameica.jar
    |   LICENSE
    |   plugin.xml
    |   README
    |   StartJameica.exe
    +---backups    
    +---CommonFiles
    +---jre-win64
    +---lib