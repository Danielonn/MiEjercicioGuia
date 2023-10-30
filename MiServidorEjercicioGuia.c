#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	int i,j;
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de la petici?n
		char nombre[200];
		
		if (codigo != 0 && codigo != 6)
		{
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		
		if (codigo ==0) //peticion de desconexion
			terminar=1;
		else if (codigo == 6)
			sprintf (respuesta,"%d",contador);
		else if (codigo ==1) //piden la longitd del nombre
			sprintf (respuesta,"%d",strlen(nombre));
		else if(codigo == 2){
			// quieren saber si el nombre es PALINDROMO
			int esPalindromo = 1;
			for(i = 0, j = strlen(nombre)-1; i < j; i++, j--){
				//Si los caracteres no son iguales no es palindromo.
				if(nombre[i] != nombre[j]){
					esPalindromo = 0;
					break;
				}
				else
				{						
					esPalindromo = 1;
					break;
				}
			}
			if(esPalindromo==0){
				strcpy (respuesta,"No es un nombre polindromo");
			}
			else if(esPalindromo==1)
			{
				strcpy(respuesta, "Si es un nombre polindromo");
			}
		}
		else if(codigo == 3){// Devuelve el nombre en MAYUSCULAS
			
			char mayuscula[80];
			for(i=0; i<nombre[i]; i++)
			{
				mayuscula[i] = toupper(nombre[i]);										
			}
			mayuscula[strlen(nombre)]='\0';
			printf("Tu nombre convertido a mayusculas es = %s\n",mayuscula);
			strcpy(respuesta, mayuscula);
		}
		if(codigo == 4 || codigo == 5)
		{
			
			double grados = atof(nombre);			
			double conversion;
			
			if (codigo == 4)
			{
				// De Fahrenheit a Celsius
				conversion = (grados - 32) * 5 / 9;
			}
			else if(codigo == 5)
			{
				//De Celsius a Farenheit
				conversion = (grados * 9) / 5 + 32;
			}
			printf("El resultado de la conversion es: %lf\n", conversion);
			sprintf(respuesta, "%lf", conversion);
		}
		if (codigo !=0)
		{
			
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		if(codigo ==1 ||codigo == 2||codigo == 3|| codigo == 4|| codigo == 5)
		{
			pthread_mutex_lock( &mutex ); //No me interrumpas ahora
			contador = contador +1;
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
		}
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}


int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9100);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	int sockets[100];
	pthread_t thread;
	i=0;
	// Bucle para atender a 5 clientes
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}
	
			
}
