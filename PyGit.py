#! /usr/bin/python3
# _*_ coding: utf8 _*_

from os import system as exc
from os import popen
from os import chdir
import sys
import re
import time

# Lista de rutas donde se encuentran los proyectos actuales
WORK_DIRs = [
	".\\"
	]


TITLE = '''
 _______              ______   __    __
|       \            /      \ |  \  |  \\
| #######\ __    __ |  ######\ \## _| ##_
| ##__/ ##|  \  |  \| ## __\##|  \|   ## \\
| ##    ##| ##  | ##| ##|    \| ## \######
| ####### | ##  | ##| ## \####| ##  | ## __
| ##      | ##__/ ##| ##__| ##| ##  | ##|  \\
| ##       \##    ## \##    ##| ##   \##  ##
 \##       _\#######  \######  \##    \####
          |  \__| ##
           \##    ##                 By CDCB
            \######
'''
MENU = '''[ 0] Establecer usuario
[ 1] Crear etiqueta
[ 2] Crear cambio
[ 3] Comparar ramas
[ 4] Fusionar rama
[ 5] Ver historial y estado
[ 6] Subir rama local
[ 7] Ir a rama específica
[ 8] Crear rama
[ 9] Usar stash
[10] Ir a cambio específico
[11] Descartar cambios no confirmados
[12] Eliminar ultimo cambio remoto'''

# Diccionario usado para obtener los caracteres de cambio de color
BCOLORS = {
    "HEADER": '\033[95m',
    "OKBLUE": '\033[94m',
    "OKCYAN": '\033[96m',
    "OKGREEN": '\033[92m',
    "WARNING": '\033[93m',
    "FAIL": '\033[91m',
    "ENDC": '\033[0m',
    "BOLD": '\033[1m',
    "UNDERLINE": '\033[4m'
}

index = -1 # Posición del cursor del menu
info = "" # Información del usuario y el repo

# Se inicia el Loop del proceso para capturar acciones y volver al menu
def main():
	global index,info
	limpiar()
	efecto(TITLE)
	print("Proyectos Actuales:\n")
	if(len(WORK_DIRs) > 0):
		for d in range(1, len(WORK_DIRs)+1):
			print(f"[{d}] {WORK_DIRs[d-1]}")
		ind_dir = input("Seleccionar proyecto > ")
		chdir(WORK_DIRs[int(ind_dir)-1].replace("\\","/"))

	while(True):
		# Entra en estado de escucha de una pulsacion
		# Por cada pulsacion llama la funcion para mostrar el menu
		mostrar_menu()
		index = input("\ngit > ")
		if(index.isnumeric()):
			try:
				acciones(str(index))
			except Exception as ex:
				print(ex)
		else:
			print(popen(f'git {index}').read())
			input()

# Entra como parametro el objeto de tipo tecla
def mostrar_menu():
	global index, info
	limpiar()
	if(popen('git config --get remote.origin.url').read() == ""):
		print("\nSin repositorio, se debe usar el script en la raiz de un proyecto.")
		clone()
	else:
		if(info == ""):
			info = repo_info()
		print("Información de usuario y repositorio actual:\n")
		print(info)
		print("\nIngresa el número de la Opción\n")
		seleccion(MENU,index)

# Verifica si en el equipo está instalado el paquete para detectar pulsaciones
def verificar_paquete():
	try:
		from pynput import keyboard as k
	except ImportError as e:
		print("Intalando Paquete...")
		if(sys.platform.startswith('linux')):
			exc("sudo pip3 install pynput")
		else:
			exc("pip install pynput")
		from pynput import keyboard as k
	return k


# Las entradas se deben corregir si entran con caracteres especiales debido a las pulsaciones anteriores
def obtener_entrada(msg=""):
	string = input(msg)
	entrada = ""
	corregida = False
	string = string.replace(chr(27)+chr(91)+"A","")
	string = string.replace(chr(27)+chr(91)+"B","")
	string = string.replace(chr(27)+chr(91)+"C","")

	for c in string:
		if(re.search("[0-9]",c) and corregida == False):
			entrada += ""
		else:
			entrada += c
			corregida = True
	if(entrada == ""):
		return
	return entrada

# Se optiene informacion de GIT respecto a la direccion actual
def repo_info():
	cad = BCOLORS["OKGREEN"]
	cad += popen("git config --get user.name").read()
	cad += popen("git config --get user.email").read()
	cad += popen("git config --get remote.origin.url").read()
	cad += popen("git branch").read()
	return cad+BCOLORS["ENDC"]

# Por medio de comando de la shell se limpia la terminal
def limpiar():
	if(sys.platform.startswith('linux')):
		exc("clear")
	else:
		exc("cls")

# Efecto de trancision para el titulo
def efecto(lista):
	cad = ""
	for c in lista:
		if(c=="#"):
			cad += BCOLORS["OKCYAN"]+c+BCOLORS["ENDC"]
		else:
			cad += BCOLORS["OKGREEN"]+c+BCOLORS["ENDC"]
	for linea in cad.split("\n"):
		print(linea)
		time.sleep(0.03)

# Visualización del menu respecto a la posición del cursor
def seleccion(lista,indice):
	cadena = ""
	for i in range(len(lista.split("\n"))):
		cadena = BCOLORS["WARNING"]+lista.split("\n")[i][:4]+" "+BCOLORS["OKGREEN"]+lista.split("\n")[i][5:]+BCOLORS["ENDC"]
		print(cadena)
		time.sleep(0.03)

# Se clona el repositorio remoto y el script se mueve a su carpeta raiz
def clone():
	repo = obtener_entrada("Link HTTPS del repositorio a clonar > ")
	exc("git clone "+str(repo))
	if(sys.platform.startswith('linux')):
		exc("mv scriptGit.py ./"+str(repo.split("/")[4].split(".")[0]))
	else:
		exc("move scriptGit.py "+str(repo.split("/")[4].split(".")[0]))
	print("Script Movido!!!")
	time.sleep(5)
	exit()

# Conjunto de comandos GIT respecto a la acción elegida
def acciones(opt):
	global info
	limpiar()
	if(opt == "0"):
		nombre = obtener_entrada("Usuario > ")
		exc("git config --global user.name '"+str(nombre)+"'")
		correo = obtener_entrada("Correo > ")
		exc("git config --global user.email '"+str(correo)+"'")
		exc("git config --list")
		info = repo_info()

	if(opt == "1"):
		exc("git tag")
		etiqueta = obtener_entrada("\nCrear versión > ")
		descripcion = obtener_entrada("\nDescripción > ")
		exc("git tag -a "+etiqueta+" -m '"+str(descripcion)+"'")

	if(opt == "2"):
		print("\nCambios a confirmar...\n")
		exc("git status -sb")
		message = obtener_entrada("\nDescripción del cambio > ")
		exc("git add .")
		exc('git commit -m "'+str(message)+'"')
		limpiar()
		exc("git log -3 --graph --decorate --all --abbrev-commit")
		obtener_entrada()

	if(opt == "3"):
		limpiar()
		exc("git fetch")
		exc("\ngit branch -v -a")
		ramaA = obtener_entrada("\nComparar rama: > ")
		ramaB = obtener_entrada("Con la rama: > ")
		if(sys.platform.startswith('linux')):
			exc("git difftool -y --tool=meld "+str(ramaA)+" "+str(ramaB))
		else:
			print("-> INGRESAR ':q' PARA SALIR DEL COMPARADOR")
			obtener_entrada()
			exc("git difftool -y "+str(ramaA)+" "+str(ramaB))

	if(opt == "4"):
		exc("git fetch")
		exc("\ngit branch -v -a")
		rama = obtener_entrada("Rama a traer > ")
		exc("git diff "+str(rama))
		exc("git merge "+str(rama))
		obtener_entrada()

	if(opt == "5"):
		exc("git fetch")
		limpiar()
		exc('git log --graph --pretty=format:"%C(cyan)%h%Creset -> %an -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)%Creset" --abbrev-commit')
		obtener_entrada()
		limpiar()
		print("\n Ramas:\n")
		exc("git branch -v")
		obtener_entrada()
		print("\n Modificaciones sin reportar: \n")
		exc("git status -s")
		obtener_entrada()

	if(opt == "6"):
		limpiar()
		exc("git fetch")
		exc("git branch -v")
		print("-> ¡Recuerde hacer pull y solucionar los posibles conflictos antes de subir los cambios!")
		rama = obtener_entrada("Rama a subir > ")
		exc("git push origin "+rama)
		obtener_entrada()

	if(opt == "7"):
		print("\nRamas:\n")
		exc("git branch -v")
		idCommit = obtener_entrada("Nombre de Rama > ")
		exc("git checkout "+idCommit)
		info = repo_info()
		obtener_entrada()

	if(opt == "8"):
		limpiar()
		rama = obtener_entrada("Nombre de rama > ")
		exc("git branch "+str(rama))
		exc("git checkout "+str(rama))
		exc("git branch -v")
		obtener_entrada()

	if(opt == "9"):
		limpiar()
		exc("git stash list")
		respuesta = obtener_entrada("¿Conservar cambios en el stash? s/n > ")
		if(respuesta.lower() == "s"):
			exc("git stash")
		else:
			exc("git stash apply")
			exc("git stash clear")
		obtener_entrada()

	if(opt == "10"):
		exc("git reflog")
		commit = obtener_entrada("ID de Commit > ")
		respuesta = obtener_entrada("¿Conservar modificaciones? s/n > ")
		if(respuesta.lower() == "s"):
			exc("git reset "+commit+" --soft")
		elif(respuesta.lower() == "n"):
			exc("git reset "+commit+" --hard")
		else:
			print("Abortado")
			obtener_entrada()
		exc("git log -3 --graph --decorate --all --abbrev-commit")

	if(opt == "11"):
		exc("git status -s")
		exc("git restore .")
		exc("git status")
		obtener_entrada()

	if(opt == "12"):
		exc("git branch -v")
		rama = obtener_entrada("Nombre de Rama > ")
		exc("git push -f origin HEAD^:"+rama)
		exc("git log -3 --graph --decorate --all --abbrev-commit")


if __name__ == "__main__":
	try:
		main()
	except KeyboardInterrupt:
		exit()

