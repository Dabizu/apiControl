import serial, time
import requests
ser=serial.Serial('COM3',9600, timeout=1)
while True:
    seri=ser.readline()
    print(seri)
    tecla=str(seri)
    teclareplace=tecla.split("'");
    print(teclareplace[1])
    cadena=teclareplace[1]
    if cadena=="":
        print("esta vacia")
    else:
        caracteResp=cadena.split(chr(92))
        print(caracteResp)
        caracter=caracteResp[0]
        print(caracter)
        print(len(caracter))
        res = requests.get("http://localhost:3000/control?tecla="+str(caracter))
    #print(res)



"""
puertoSerial = serial.Serial('COM3', 9600)
time.sleep(2)   #Espera 2 segundos para conectar puerto serial

while 1:
    try:

        datosASCII = puertoSerial.readline() #Devuelve b

        print("Lista Inicial", datosASCII)

        datosCaracter = ""
        for valor in datosASCII:
            datosCaracter = datosCaracter + chr(valor)

        print("Lista Resultante", str(datosCaracter))

    except KeyboardInterrupt:
        break

puertoSerial.close()
"""