# RandomFolderGenerator
Simple visual basic project that generates a folder with the base of the name supplied by user and then adds 20 semi-random characters.

Includes windows registry file to add 'make random folder' shell menu item that launches the program when you right click in windows explorer. Note this is for right clicking in the blank space, ie not right clicking on a file or folder name itself. Note you will need to edit the registry file to point to the path of the randomfolder.exe unless you put it in c:\temp

The %w in the registry file passes the path of the current folder as an arguement to 

## Possible uses 
- Easly make folders that will be on a public webserver in non browsable directories. The folder will only be accessible to those who know the path and thus security is pimarily dervied from the length and randomness of the path. 
