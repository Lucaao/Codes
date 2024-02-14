/* Sistema de Sensores:
Defina uma interface ISensor com um método LerValor.
Crie classes como SensorDeTemperatura e SensorDePressão implementando ISensor. */

SensorDePressão SDP1 = new SensorDePressão();
SDP1.LerValor(5);

SensorDeTemperatura SDT1 = new SensorDeTemperatura();
SDT1.LerValor(25);