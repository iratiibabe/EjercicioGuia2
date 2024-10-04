#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

// Funci贸n para convertir grados Celsius a Fahrenheit
float celsiusToFahrenheit(float celsius) {
	return (celsius * 9.0 / 5.0) + 32.0;
}

// Funci贸n para convertir grados Fahrenheit a Celsius
float fahrenheitToCelsius(float fahrenheit) {
	return (fahrenheit - 32.0) * 5.0 / 9.0;
}

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
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
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9150);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	int i;
	
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		//Bucle de atenci髇 al cliente
		int terminar = 0;
		while (terminar == 0)
		{
			// Ahora recibimos su peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibida una petici贸n\n");
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			//Escribimos la peticion en la consola
			
			printf ("La petici贸n es: %s\n",peticion);
			
			char *p = strtok(peticion, "/");
			int codigo = atoi(p); 
			float temperatura = 0.00;
			float resultado = 0.00;
			
			if (codigo != 0){
				p = strtok(NULL, "/");
				if (p != NULL) {
					temperatura = atof(p);
				}
				printf("C贸digo: %d, Temperatura: %.2f\n", codigo, temperatura);
			}
			
			if (codigo == 0)
				terminar = 1;
			else if (codigo == 1) //piden los grados en Celsius y los pasan a Fahrenheit
			{
				resultado = celsiusToFahrenheit(temperatura);
				sprintf(respuesta, "%.2f grados Celsius equivalen a %.2f grados Fahrenheit.\n", temperatura, resultado);
			}
			else if (codigo ==2) //piden los grados en Fahrenheit y los pasan a Celsius
			{
				resultado = fahrenheitToCelsius(temperatura);
				sprintf(respuesta, "%.2f grados Fahrenheit equivalen a %.2f grados Celsius.\n", temperatura, resultado);
			}	
		
			if (codigo !=0)
			{
				printf("Respuesta: %s\n",respuesta);
				//Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			
		}	
			// Se acab贸 el servicio para este cliente
			close(sock_conn);
	}
}
